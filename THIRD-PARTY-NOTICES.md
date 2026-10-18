# Third-party notices

YotsubaShaderCross is a **derived work**. Most of the C# in `src/YotsubaShaderCross/Generated` and in
`src/YotsubaShaderCross/Manual` is an automatic (or, for `Manual`, hand-made) translation of
[SPIRV-Cross](https://github.com/KhronosGroup/SPIRV-Cross), which belongs to its authors. The translation
tool, the runtime in `src/YotsubaShaderCross.Runtime`, the test harness and all
scripts are original work of Memphis Yomael Núñez Cruz - Dominican Republic (see `LICENSE`).

SPIRV-Cross is dual licensed **Apache-2.0 OR MIT**; this project uses it **under the MIT License**.
The copyright notices below have to travel with every copy of the translated code.

## SPIRV-Cross

Source: https://github.com/KhronosGroup/SPIRV-Cross (revision pinned in `upstream.lock`)

Translated files: `spirv_cross.cpp/.hpp`, `spirv_common.hpp`, `spirv_cross_containers.hpp`, `spirv_cross_error_handling.hpp`,
`spirv_cross_parsed_ir.cpp/.hpp`, `spirv_cfg.cpp/.hpp`, `spirv_parser.cpp/.hpp`, `spirv_glsl.cpp/.hpp`, `spirv_hlsl.cpp/.hpp`,
`spirv_msl.cpp/.hpp`, `spirv_cpp.cpp/.hpp`, `spirv_reflect.cpp/.hpp`, `spirv_cross_util.cpp/.hpp` and `main.cpp`.

Copyright holders of those files (each generated C# file lists the ones that apply to it in its header):

- Copyright 2015-2021 Arm Limited
- Copyright 2016-2021 Arm Limited
- Copyright 2018-2021 Arm Limited
- Copyright 2016-2021 Robert Konrad
- Copyright 2016-2021 The Brenwill Workshop Ltd.
- Copyright 2018-2021 Bradley Austin Davis
- Copyright 2019-2021 Hans-Kristian Arntzen
- Copyright 2014-2016,2021 The Khronos Group, Inc.

```text
MIT License

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is furnished
to do so, subject to the following conditions:

The above copyright notice and this permission notice (including the next
paragraph) shall be included in all copies or substantial portions of the
Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS
OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF
OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
```

(The licence text as distributed by SPIRV-Cross is kept in `LICENSES/SPIRV-Cross-MIT.txt`.)

## Khronos SPIR-V headers

The enumerations in `src/YotsubaShaderCross/Generated/Spv` and `GLSLstd450.cs` are translated from
`spirv.hpp` (Copyright 2014-2024 The Khronos Group Inc., MIT) and `GLSL.std.450.h` /
`NonSemanticShaderDebugInfo100.h` (Copyright 2014-2020 The Khronos Group Inc., Khronos Free Use licence).
The Khronos Free Use licence text is kept in `LICENSES/Khronos-FreeUse.txt`; it requires the notice to be
included in all copies or substantial portions of the Materials.

## Test material (not redistributed here)

`tests/prepare_cases.py` downloads nothing and copies nothing from SPIRV-Cross: it reads the regression shaders
and reference outputs of a local SPIRV-Cross checkout (`upstream/`, ignored by git) when you run the conformance
suite. They are Copyright The Khronos Group, Inc. under Apache-2.0.

## What is *not* covered by these notices

`src/YotsubaShaderCross.Runtime`, `src/YotsubaShaderCross.Cli/Program.cs`, `tests/` and `scripts/`
are original code under the MS-PL License of this repository (`LICENSE`).
