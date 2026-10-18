# YotsubaShaderCross

A complete **C# port of [SPIRV-Cross](https://github.com/KhronosGroup/SPIRV-Cross)** that is not written by hand:
a purpose-built translator turns the C++ sources into the C# project in `src/YotsubaShaderCross`.
When SPIRV-Cross changes, you re-run the translator instead of porting patches.

SPIRV-Cross reads a SPIR-V binary and emits readable **GLSL**, **HLSL**, **MSL** (and a JSON reflection report).
This library does exactly that from C#, with no native dependency.

> YotsubaShaderCross is an independent project. It is not an official Khronos, Arm or SPIRV-Cross project.
> The translated code remains under SPIRV-Cross' copyright, see [THIRD-PARTY-NOTICES.md](THIRD-PARTY-NOTICES.md).

## Use it from C#

The API keeps the names, options and behaviour of the C++ one, so the SPIRV-Cross documentation applies as is.

```csharp
using YotsubaShaderCross;

byte[] bytes = File.ReadAllBytes("shader.spv");
uint[] words = new uint[bytes.Length / 4];
Buffer.BlockCopy(bytes, 0, words, 0, words.Length * 4);

// SPIR-V words -> intermediate representation
var parser = new Parser(new CppVector<uint>(words));
parser.parse();

// pick a backend: CompilerGLSL, CompilerHLSL, CompilerMSL, CompilerReflection, CompilerCPP
var glsl = new CompilerGLSL(parser.get_parsed_ir());

CompilerGLSL.Options options = glsl.get_common_options();
options.version = 450;
options.vulkan_semantics = true;
glsl.set_common_options(options);

string source = glsl.compile().str();
```

Backend specific options work the same way:

```csharp
var msl = new CompilerMSL(parser.get_parsed_ir());
CompilerMSL.Options mslOptions = msl.get_msl_options();
mslOptions.set_msl_version(2, 1);                      // C++ default arguments are kept: patch = 0
mslOptions.argument_buffers = true;
msl.set_msl_options(mslOptions);

string metal = msl.compile().str();
```

A runnable version lives in [`samples/SpirvToGlsl`](samples/SpirvToGlsl).

## The command line tool

`src/YotsubaShaderCross.Cli` is not a re-implementation of SPIRV-Cross' command line: it is the translation of
its `main.cpp`, so every flag of `spirv-cross` is there with the same meaning.

```bash
dotnet run -c Release --project src/YotsubaShaderCross.Cli -- shader.spv --version 450 --output shader.glsl
dotnet run -c Release --project src/YotsubaShaderCross.Cli -- shader.spv --msl --msl-version 20100
dotnet run -c Release --project src/YotsubaShaderCross.Cli -- shader.spv --hlsl --shader-model 50
dotnet run -c Release --project src/YotsubaShaderCross.Cli -- shader.spv --reflect
```

## How the translation works

`Cpp2Cs` does not parse C++ itself. It asks `clang++ -Xclang -ast-dump=json` for the typed AST of every SPIRV-Cross
translation unit, keeps the declarations that belong to the project, and writes C#. The interesting decisions are
the places where the two languages disagree; each one is a rule in the translator, never an edit of the output:

```csharp
// value semantics: C++ copies objects, C# shares references.
// Every class gets Clone()/CopyFrom(); the translator inserts them exactly where the C++ copy constructor
// or operator= ran (clang's AST contains a CXXConstructExpr for each one).
SPIRType copy = original.Clone();
target.CopyFrom(source);

// std::string, std::vector, std::unordered_map ... are mirrored by runtime types with the same member names,
// so translated code reads like the original:
CppVector<uint> ids = new CppVector<uint>();
ids.push_back(7u);
CppString name = "main";
name.push_back('!');

// pointers to a C# value (uint*, bool*) become Ptr<T>; pointers to objects are the object reference itself.
void HasResultAndType(Spv.Op op, Ptr<bool> hasResult, Ptr<bool> hasResultType)
{
    hasResult.Value = true;
}

// RAII (~LoopLock, ValueSaver) becomes IDisposable + 'using' at the places the destructor used to run.
using var loopLock = ir.create_loop_hard_lock();

// templates are monomorphised from the instantiations clang already resolved:
SPIRType type = get__SPIRType(id);   // Compiler::get<SPIRType>(id)

// lambdas capturing by value copy their captures when created (Std.bind), by reference stay closures.
Func<uint, bool> predicate = Std.bind(limit, limit__c => (uint x) => x < limit__c);

// switch fall-through is explicit in C#:
switch (op)
{
    case 1u: { statement(); goto case 2u; }
    case 2u: { break; }
}
```

The few constructs with no sensible automatic translation live in `src/YotsubaShaderCross/Manual`
(variadic `statement(...)` helpers, one pointer-range walk over a constant table, an in-place string compaction).
They are small, listed in `tools/Cpp2Cs/Intrinsics.cs` and regenerated around, never overwritten.

## Port a newer SPIRV-Cross

```bash
scripts/regenerate.sh            # the revision pinned in upstream.lock
scripts/regenerate.sh main       # any branch, tag or commit
```

Requirements: .NET 8 SDK and `clang++` (Xcode command line tools or LLVM).
The script clones SPIRV-Cross into `upstream/` (ignored by git), runs the translator and builds the solution.
The translator prints a histogram of the C++ constructs it could not translate; for the pinned revision it is empty.
Only the pinned revision has been verified end to end: for a newer one, run the conformance suite below and treat any
new entry in that histogram, build error or mismatch as a rule still missing in the translator.

## Is it faithful?

Compiling is not enough, so the port is checked against the original. `scripts/run-conformance.sh` feeds
the same SPIR-V and the same command lines to the translated tool and to a natively built SPIRV-Cross and compares the
outputs byte by byte. For the pinned revision, with upstream's own regression shaders (GLSL, MSL, HLSL and
reflection, with and without `spirv-opt`):

```text
glsl     pass= 1389 mismatch=0 crash=0
msl      pass= 1387 mismatch=0 crash=0
hlsl     pass=  437 mismatch=0 crash=0
reflect  pass=   30 mismatch=0 crash=0
total    pass= 3243 mismatch=0 crash=0
```

Against the reference files shipped with SPIRV-Cross the result is 2961 of 2972 identical; the 11 that differ do so only
because the glslang / spirv-opt installed here emit different SPIR-V ids than the ones upstream used.

```bash
scripts/run-conformance.sh              # compare with upstream/reference
scripts/run-conformance.sh --native     # compare with a native build, same SPIR-V (needs glslang + spirv-tools)
```

## Layout

```text
src/YotsubaShaderCross          generated library (Generated/) + the few hand written members (Manual/)
src/YotsubaShaderCross.Runtime  the std:: mirror: CppString, CppVector, maps, Ptr<T>, printf, ...
src/YotsubaShaderCross.Cli      entry point of the translated command line tool
tests/                          conformance runner and case preparation
samples/SpirvToGlsl             the smallest useful program
```

Not translated: the C ABI wrapper `spirv_cross_c.cpp` (opaque handles and raw pointers have no C# counterpart).
The translator accepts `--include-c-api`, but that output is neither maintained nor tested.

## License

MS-PL, see [LICENSE](LICENSE). The translated SPIRV-Cross code keeps its authors' copyright:
[THIRD-PARTY-NOTICES.md](THIRD-PARTY-NOTICES.md).
