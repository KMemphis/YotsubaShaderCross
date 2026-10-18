#!/usr/bin/env python3
"""Builds the case list consumed by the conformance runner.

For every shader of the upstream regression folders this reuses upstream's own test_shaders.py: its
cross_compile* functions compile the shader with glslang / spirv-as (+ spirv-opt) and assemble the SPIRV-Cross command
line from the file name tokens. The spirv-cross executable is replaced by record_cross.py, which only records the
arguments, so that the runner can later execute exactly those arguments against the C# port.

usage: prepare_cases.py <spirv-cross-checkout> <work-dir> [--backend glsl|msl|hlsl|reflect]... [--filter text] [--jobs N]
Environment: GLSLANG, SPIRV_AS, SPIRV_OPT, SPIRV_VAL select the tools (default: from PATH).
"""
import importlib.util, json, multiprocessing, os, shutil, subprocess, sys, tempfile

HERE = os.path.dirname(os.path.abspath(__file__))

# (backend, folder, spirv-opt)
MATRIX = [
    ('glsl', 'shaders', False), ('glsl', 'shaders', True), ('glsl', 'shaders-no-opt', False),
    ('msl', 'shaders-msl', False), ('msl', 'shaders-msl', True), ('msl', 'shaders-msl-no-opt', False),
    ('msl', 'shaders-ue4', False), ('msl', 'shaders-ue4', True), ('msl', 'shaders-ue4-no-opt', False),
    ('hlsl', 'shaders-hlsl', False), ('hlsl', 'shaders-hlsl', True), ('hlsl', 'shaders-hlsl-no-opt', False),
    ('reflect', 'shaders-reflection', False),
]

def load_upstream(root):
    spec = importlib.util.spec_from_file_location('upstream_test_shaders', os.path.join(root, 'test_shaders.py'))
    mod = importlib.util.module_from_spec(spec)
    spec.loader.exec_module(mod)
    return mod

def reference_path(root, folder, rel, opt):
    return os.path.join(root, 'reference', 'opt' if opt else '', folder, rel)

def prepare(job):
    root, work, backend, folder, opt, rel = job
    os.chdir(root)
    ts = load_upstream(root)
    ts.validate_shader = lambda *a, **k: None
    ts.validate_library_glsl = lambda *a, **k: None
    ts.validate_shader_msl = lambda *a, **k: None
    ts.validate_shader_hlsl = lambda *a, **k: None

    record = tempfile.mktemp(suffix='.rec')
    os.environ['YSC_RECORD'] = record
    tools = lambda name, default: os.environ.get(name, default)
    paths = ts.Paths(os.path.join(HERE, 'record_cross.py'), tools('GLSLANG', 'glslangValidator'), tools('SPIRV_AS', 'spirv-as'),
                     tools('SPIRV_VAL', 'spirv-val'), tools('SPIRV_OPT', 'spirv-opt'))
    joined = os.path.join(folder, rel)
    is_spirv = ts.shader_is_spirv(rel)
    noopt = ts.shader_is_noopt(rel)
    eff_opt = opt and not noopt
    spv_copy = os.path.join(work, backend, folder + ('-opt' if opt else ''), rel + '.spv')
    os.makedirs(os.path.dirname(spv_copy), exist_ok=True)

    try:
        if backend == 'glsl':
            vulkan = ts.shader_is_vulkan(rel)
            spirv, glsl, vk = ts.cross_compile(joined, vulkan, is_spirv, ts.shader_is_invalid_spirv(rel), ts.shader_is_eliminate_dead_variables(rel),
                                               ts.shader_is_legacy(rel), ts.shader_is_force_es(rel), ts.shader_is_flatten_ubo(rel), ts.shader_is_sso(rel),
                                               ts.shader_is_flatten_dimensions(rel), eff_opt, ts.shader_is_push_ubo(rel), 1, paths)
        elif backend == 'msl':
            spirv, _ = ts.cross_compile_msl(joined, is_spirv, eff_opt, 1, paths)
        elif backend == 'hlsl':
            if os.path.splitext(joined)[1] == '.hlsl':
                return []
            spirv, _ = ts.cross_compile_hlsl(joined, is_spirv, eff_opt, True, 1, paths)
        else:
            spirv, _ = ts.cross_compile_reflect(joined, is_spirv, eff_opt, 1, paths)
    except Exception as e:
        return []
    if not os.path.exists(spirv) or not os.path.exists(record):
        return []
    shutil.copy(spirv, spv_copy)
    os.remove(spirv)

    cases = []
    with open(record) as f:
        calls = [json.loads(l) for l in f if l.strip()]
    os.remove(record)
    for argv in calls:
        out = []
        i = 0
        while i < len(argv):
            if argv[i] == '--output':
                i += 2
                continue
            out.append(argv[i])
            i += 1
        ref = reference_path(root, folder, rel, opt)
        if backend == 'reflect': ref += '.json'
        name = f'{backend}:{folder}{"+opt" if opt else ""}/{rel}'
        if backend == 'glsl' and '-V' in argv:
            ref += '.vk'
            name += '.vk'
        # the SPIR-V input is the positional argument that is a temporary file
        out = ['{IN}' if (a == out_spirv(argv, spirv)) else a for a in out]
        cases.append((name, spv_copy, ref, out))
    return cases

def out_spirv(argv, spirv):
    return spirv

def main():
    if len(sys.argv) < 3:
        print(__doc__); return 2
    root, work = os.path.abspath(sys.argv[1]), os.path.abspath(sys.argv[2])
    flt = None; jobs = multiprocessing.cpu_count(); backends = []
    a = sys.argv[3:]
    while a:
        if a[0] == '--filter': flt = a[1]; a = a[2:]
        elif a[0] == '--jobs': jobs = int(a[1]); a = a[2:]
        elif a[0] == '--backend': backends.append(a[1]); a = a[2:]
        else: a = a[1:]
    items = []
    for backend, folder, opt in MATRIX:
        if backends and backend not in backends: continue
        for dirpath, _, files in os.walk(os.path.join(root, folder)):
            for f in sorted(files):
                if f.startswith('.'): continue
                rel = os.path.relpath(os.path.join(dirpath, f), os.path.join(root, folder))
                if flt and flt not in rel: continue
                items.append((root, work, backend, folder, opt, rel))
    with multiprocessing.Pool(jobs) as pool:
        results = pool.map(prepare, items, chunksize=4)
    os.makedirs(work, exist_ok=True)
    count = 0
    with open(os.path.join(work, 'cases.tsv'), 'w') as out:
        for cases in results:
            for name, spv, ref, args in cases:
                out.write('\t'.join([name, spv, ref] + args) + '\n')
                count += 1
    print(f'{count} cases written to {os.path.join(work, "cases.tsv")}')

if __name__ == '__main__':
    sys.exit(main())
