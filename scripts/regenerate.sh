#!/usr/bin/env bash
# Regenerates src/YotsubaShaderCross/Generated from the SPIRV-Cross sources.
#   scripts/regenerate.sh            -> revision pinned in upstream.lock
#   scripts/regenerate.sh <rev|tag>  -> any other revision (e.g. master) to port a newer SPIRV-Cross
# Requires: dotnet 8 SDK and clang++ (Xcode command line tools / LLVM) to produce the AST.
set -euo pipefail
cd "$(dirname "$0")/.."
scripts/fetch-upstream.sh "${1:-}"
dotnet run -c Release --project tools/Cpp2Cs -- generate upstream/SPIRV-Cross src/YotsubaShaderCross
dotnet build YotsubaShaderCross.sln -c Release
