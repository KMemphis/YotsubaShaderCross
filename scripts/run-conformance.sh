#!/usr/bin/env bash
# Runs upstream's regression shaders through the C# port (the translated spirv-cross command line tool).
#   scripts/run-conformance.sh              -> compare with the reference outputs shipped in upstream/reference
#   scripts/run-conformance.sh --native     -> also build native SPIRV-Cross and compare against it, byte for byte,
#                                              using the very same SPIR-V (removes glslang / spirv-opt version noise)
# Requires: glslangValidator, spirv-as, spirv-opt in PATH (or GLSLANG / SPIRV_AS / SPIRV_OPT), python3, clang++.
set -euo pipefail
cd "$(dirname "$0")/.."
work=conformance-work
python3 tests/prepare_cases.py upstream/SPIRV-Cross "$work"
dotnet build tests/YotsubaShaderCross.Conformance -c Release -v q
extra=()
if [ "${1:-}" = "--native" ]; then
    mkdir -p "$work/native"
    (cd upstream/SPIRV-Cross && clang++ -O1 -std=c++11 -I. spirv_cross.cpp spirv_cfg.cpp spirv_glsl.cpp spirv_hlsl.cpp spirv_msl.cpp \
        spirv_parser.cpp spirv_cross_parsed_ir.cpp spirv_reflect.cpp spirv_cpp.cpp spirv_cross_util.cpp main.cpp -o "../../$work/native/spirv-cross")
    extra=(--native "$work/native/spirv-cross")
fi
dotnet run -c Release --no-build --project tests/YotsubaShaderCross.Conformance -- "$work/cases.tsv" "${extra[@]}"
