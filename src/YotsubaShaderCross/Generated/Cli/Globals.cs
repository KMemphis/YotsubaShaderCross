#region MS-PL License - Copyright (c) 2026 Memphis Yomael Núñez Cruz - Dominican Republic
/*
╔════════════════════════════════════════════════════════════════════════════════════╗
║                                                                                    ║
║  ███╗   ███╗███████╗      ██████╗ ██╗                                              ║
║  ████╗ ████║██╔════╝      ██╔══██╗██║                                              ║
║  ██╔████╔██║███████╗█████╗██████╔╝██║                                              ║
║  ██║╚██╔╝██║╚════██║╚════╝██╔═══╝ ██║                                              ║
║  ██║ ╚═╝ ██║███████║      ██║     ███████╗                                         ║
║  ╚═╝     ╚═╝╚══════╝      ╚═╝     ╚══════╝                                         ║
║                                                                                    ║
╠════════════════════════════════════════════════════════════════════════════════════╣
║  Copyright (c) 2026 Memphis Yomael Núñez Cruz - Dominican Republic                 ║
╠════════════════════════════════════════════════════════════════════════════════════╣
║                                                                                    ║
║  Microsoft Public License (MS-PL)                                                  ║
║                                                                                    ║
║  This license governs use of the accompanying software. If you use the software,   ║
║  you accept this license. If you do not accept the license, do not use the         ║
║  software.                                                                         ║
║                                                                                    ║
║  1. Definitions                                                                    ║
║  The terms "reproduce," "reproduction," "derivative works," and "distribution"     ║
║  have the same meaning here as under U.S. copyright law.                           ║
║  A "contribution" is the original software, to which copyright notices are         ║
║  attached, and any additions or changes to the software.                           ║
║  A "contributor" is any person that distributes its contribution under this        ║
║  license.                                                                          ║
║  "Licensed patents" are a contributor's patent claims that read directly on its    ║
║  contribution.                                                                     ║
║                                                                                    ║
║  2. Grant of Rights                                                                ║
║  (A) Copyright Grant- Subject to the terms of this license, including the license  ║
║  conditions and limitations in section 3, each contributor grants you a non-       ║
║  exclusive, worldwide, royalty-free copyright license to reproduce its             ║
║  contribution, prepare derivative works of its contribution, and distribute its    ║
║  contribution or any derivative works that you create.                             ║
║  (B) Patent Grant- Subject to the terms of this license, including the license     ║
║  conditions and limitations in section 3, each contributor grants you a non-       ║
║  exclusive, worldwide, royalty-free license under its licensed patents to make,    ║
║  have made, use, sell, offer for sale, import, and/or otherwise dispose of its     ║
║  contribution in the software or derivative works of the contribution in the       ║
║  software.                                                                         ║
║                                                                                    ║
║  3. Conditions and Limitations                                                     ║
║  (A) No Trademark License- This license does not grant you rights to use any       ║
║  contributors' name, logo, or trademarks.                                          ║
║  (B) If you bring a patent claim against any contributor over patents that you     ║
║  claim are infringed by the software, your patent license from such contributor    ║
║  to the software ends automatically.                                               ║
║  (C) If you distribute any portion of the software, you must retain all copyright, ║
║  patent, trademark, and attribution notices that are present in the software.      ║
║  (D) If you distribute any portion of the software in source code form, you may do ║
║  so only under this license by including a complete copy of this license with      ║
║  your distribution. If you distribute any portion of the software in compiled or   ║
║  object code form, you may only do so under a license that complies with this      ║
║  license.                                                                          ║
║  (E) The software is licensed "as-is." You bear the risk of using it. The          ║
║  contributors give no express warranties, guarantees or conditions. You may have   ║
║  additional consumer rights under your local laws which this license cannot        ║
║  change. To the extent permitted under your local laws, the contributors exclude   ║
║  the implied warranties of merchantability, fitness for a particular purpose and   ║
║  non-infringement.                                                                 ║
║                                                                                    ║
╚════════════════════════════════════════════════════════════════════════════════════╝
*/
#endregion

// Automatically translated from SPIRV-Cross (https://github.com/KhronosGroup/SPIRV-Cross), commit 300681b.
// Upstream sources: main.cpp
// Upstream copyright: Copyright 2015-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross.Cli;

public static partial class Globals
{
    public static CppVector<uint> read_spirv_file_stdin()
    {
        CppVector<uint> buffer = new CppVector<uint>();
        uint[] tmp = new uint[256];
        ulong ret = default;
        while ((ret = Std.fread(Ptr.From(tmp), 4, 256UL, Std.stdin)) != 0UL)
        {
            buffer.insert(buffer.end(), Ptr.From(tmp), Ptr.From(tmp) + ret);
        }
        return buffer;
    }
    public static CppVector<uint> read_spirv_file(string path)
    {
        if (unchecked((int)Std.cat(path, 0)) == 45 && unchecked((int)Std.cat(path, 1)) == 0)
        {
            return Cli.Globals.read_spirv_file_stdin();
        }
        var file = Std.fopen(path, "rb");
        if (!(file != null))
        {
            Std.fprintf(Std.stderr, "Failed to open SPIR-V file: %s\n", path);
            return new CppVector<uint>();
        }
        Std.fseek(file, 0L, 2);
        long len = unchecked((long)(unchecked((ulong)Std.ftell(file)) / 4));
        Std.rewind(file);
        CppVector<uint> spirv = new CppVector<uint>(unchecked((ulong)len));
        if (Std.fread(spirv.data(), 4, unchecked((ulong)len), file) != unchecked((ulong)len))
        {
            spirv.clear();
        }
        Std.fclose(file);
        return spirv;
    }
    public static bool write_string_to_file(string path, string @string)
    {
        var file = Std.fopen(path, "w");
        if (!(file != null))
        {
            Std.fprintf(Std.stderr, "Failed to write file: %s\n", path);
            return false;
        }
        Std.fprintf(file, "%s", @string);
        Std.fclose(file);
        return true;
    }
    public static void print_resources(Compiler compiler, Spv.StorageClass storage, CppVector<BuiltInResource> resources)
    {
        Std.fprintf(Std.stderr, "%s\n", unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassInput) ? "builtin inputs" : "builtin outputs");
        Std.fprintf(Std.stderr, "=============\n\n");
        {
            foreach (BuiltInResource res in resources)
            {
                bool active = compiler.has_active_builtin(res.builtin, storage);
                string basetype = "?";
                var type = compiler.get_type(res.value_type_id);
                {
                    switch (unchecked((int)type.basetype))
                    {
                        case unchecked((int)SPIRType.BaseType.Float):
                        {
                            basetype = "float";
                            break;
                        }
                        case unchecked((int)SPIRType.BaseType.Int):
                        {
                            basetype = "int";
                            break;
                        }
                        case unchecked((int)SPIRType.BaseType.UInt):
                        {
                            basetype = "uint";
                            break;
                        }
                        default:
                        {
                            break;
                        }
                    }
                }
                uint array_size = 0u;
                bool array_size_literal = false;
                if (!type.array.empty())
                {
                    array_size = type.array.front();
                    array_size_literal = type.array_size_literal.front();
                }
                CppString type_str = new CppString(basetype);
                if (type.vecsize > 1u)
                {
                    type_str += Std.to_string(type.vecsize);
                }
                if (array_size != 0u)
                {
                    if (array_size_literal)
                    {
                        type_str += Std.join("[", array_size, "]");
                    }
                    else
                    {
                        type_str += Std.join("[", array_size, " (spec constant ID)]");
                    }
                }
                CppString builtin_str = default(CppString);
                {
                    switch (unchecked((int)res.builtin))
                    {
                        case unchecked((int)Spv.BuiltIn.BuiltInPosition):
                        {
                            builtin_str = "Position";
                            break;
                        }
                        case unchecked((int)Spv.BuiltIn.BuiltInPointSize):
                        {
                            builtin_str = "PointSize";
                            break;
                        }
                        case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                        {
                            builtin_str = "CullDistance";
                            break;
                        }
                        case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                        {
                            builtin_str = "ClipDistance";
                            break;
                        }
                        case unchecked((int)Spv.BuiltIn.BuiltInTessLevelInner):
                        {
                            builtin_str = "TessLevelInner";
                            break;
                        }
                        case unchecked((int)Spv.BuiltIn.BuiltInTessLevelOuter):
                        {
                            builtin_str = "TessLevelOuter";
                            break;
                        }
                        default:
                        {
                            builtin_str = new CppString("builtin #") + Std.to_string(unchecked((int)res.builtin));
                            break;
                        }
                    }
                }
                Std.fprintf(Std.stderr, "Builtin %s (%s) (active: %s).\n", builtin_str.c_str(), type_str.c_str(), active ? "yes" : "no");
            }
        }
        Std.fprintf(Std.stderr, "=============\n\n");
    }
    public static void print_resources(Compiler compiler, string tag, CppVector<Resource> resources)
    {
        Std.fprintf(Std.stderr, "%s\n", tag);
        Std.fprintf(Std.stderr, "=============\n\n");
        bool print_ssbo = !(Std.strcmp(tag, "ssbos") != 0);
        {
            foreach (Resource res in resources)
            {
                var type = compiler.get_type(res.type_id);
                if (print_ssbo && compiler.buffer_is_hlsl_counter_buffer(((TypedID_TypeVariable)res.id)))
                {
                    continue;
                }
                bool is_push_constant = unchecked((int)compiler.get_storage_class(((TypedID_TypeVariable)res.id))) == unchecked((int)Spv.StorageClass.StorageClassPushConstant);
                bool is_block = compiler.get_decoration_bitset(type.self).get(unchecked((uint)Spv.Decoration.DecorationBlock)) || compiler.get_decoration_bitset(type.self).get(unchecked((uint)Spv.Decoration.DecorationBufferBlock));
                bool is_sized_block = is_block && (unchecked((int)compiler.get_storage_class(((TypedID_TypeVariable)res.id))) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)compiler.get_storage_class(((TypedID_TypeVariable)res.id))) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant));
                TypedID_TypeNone fallback_id = !is_push_constant && is_block ? new TypedID_TypeNone(res.base_type_id) : res.id;
                uint block_size = 0u;
                uint runtime_array_stride = 0u;
                if (is_sized_block)
                {
                    var base_type = compiler.get_type(res.base_type_id);
                    block_size = unchecked((uint)compiler.get_declared_struct_size(base_type));
                    runtime_array_stride = unchecked((uint)(compiler.get_declared_struct_size_runtime_array(base_type, 1UL) - compiler.get_declared_struct_size_runtime_array(base_type, 0UL)));
                }
                Bitset mask = new Bitset();
                if (print_ssbo)
                {
                    mask.CopyFrom(compiler.get_buffer_block_flags(((TypedID_TypeVariable)res.id)));
                }
                else
                {
                    mask.CopyFrom(compiler.get_decoration_bitset(res.id));
                }
                CppString array = default(CppString);
                {
                    foreach (uint arr in type.array)
                    {
                        array = Std.join("[", arr != 0u ? YotsubaShaderCross.Globals.convert_to_string__uint__0(arr) : new CppString(""), "]") + array;
                    }
                }
                Std.fprintf(Std.stderr, " ID %03u : %s%s", ((uint)res.id), !res.name.empty() ? res.name.c_str() : compiler.get_fallback_name(fallback_id).c_str(), array.c_str());
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationLocation)))
                {
                    Std.fprintf(Std.stderr, " (Location : %u)", compiler.get_decoration(res.id, Spv.Decoration.DecorationLocation));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationDescriptorSet)))
                {
                    Std.fprintf(Std.stderr, " (Set : %u)", compiler.get_decoration(res.id, Spv.Decoration.DecorationDescriptorSet));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationBinding)))
                {
                    Std.fprintf(Std.stderr, " (Binding : %u)", compiler.get_decoration(res.id, Spv.Decoration.DecorationBinding));
                }
                if (((CompilerGLSL)compiler).variable_is_depth_or_compare(((TypedID_TypeVariable)res.id)))
                {
                    Std.fprintf(Std.stderr, " (comparison)");
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationInputAttachmentIndex)))
                {
                    Std.fprintf(Std.stderr, " (Attachment : %u)", compiler.get_decoration(res.id, Spv.Decoration.DecorationInputAttachmentIndex));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationNonReadable)))
                {
                    Std.fprintf(Std.stderr, " writeonly");
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationNonWritable)))
                {
                    Std.fprintf(Std.stderr, " readonly");
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationRestrict)))
                {
                    Std.fprintf(Std.stderr, " restrict");
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationCoherent)))
                {
                    Std.fprintf(Std.stderr, " coherent");
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationVolatile)))
                {
                    Std.fprintf(Std.stderr, " volatile");
                }
                if (is_sized_block)
                {
                    Std.fprintf(Std.stderr, " (BlockSize : %u bytes)", block_size);
                    if (runtime_array_stride != 0u)
                    {
                        Std.fprintf(Std.stderr, " (Unsized array stride: %u bytes)", runtime_array_stride);
                    }
                }
                uint counter_id = 0u;
                if (print_ssbo && compiler.buffer_get_hlsl_counter_buffer(((TypedID_TypeVariable)res.id), ref counter_id))
                {
                    Std.fprintf(Std.stderr, " (HLSL counter buffer ID: %u)", counter_id);
                }
                Std.fprintf(Std.stderr, "\n");
            }
        }
        Std.fprintf(Std.stderr, "=============\n\n");
    }
    public static string execution_model_to_str(Spv.ExecutionModel model)
    {
        {
            switch (unchecked((int)model))
            {
                case unchecked((int)Spv.ExecutionModel.ExecutionModelVertex):
                {
                    return "vertex";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl):
                {
                    return "tessellation control";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation):
                {
                    return "tessellation evaluation";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry):
                {
                    return "geometry";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelFragment):
                {
                    return "fragment";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute):
                {
                    return "compute";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelRayGenerationNV):
                {
                    return "raygenNV";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelIntersectionNV):
                {
                    return "intersectionNV";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelCallableNV):
                {
                    return "callableNV";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelAnyHitNV):
                {
                    return "anyhitNV";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelClosestHitNV):
                {
                    return "closesthitNV";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMissNV):
                {
                    return "missNV";
                }
                default:
                {
                    return "???";
                }
            }
        }
    }
    public static void print_resources(Compiler compiler, ShaderResources res)
    {
        var modes = compiler.get_execution_mode_bitset();
        Std.fprintf(Std.stderr, "Entry points:\n");
        var entry_points = compiler.get_entry_points_and_stages();
        {
            foreach (EntryPoint e in entry_points)
            {
                Std.fprintf(Std.stderr, "  %s (%s)\n", e.name.c_str(), Cli.Globals.execution_model_to_str(e.execution_model));
            }
        }
        Std.fprintf(Std.stderr, "\n");
        Std.fprintf(Std.stderr, "Execution modes:\n");
        modes.for_each_bit__lambda((uint i) =>
        {
            var mode = unchecked((Spv.ExecutionMode)i);
            uint arg0 = compiler.get_execution_mode_argument(mode, 0u);
            uint arg1 = compiler.get_execution_mode_argument(mode, 1u);
            uint arg2 = compiler.get_execution_mode_argument(mode, 2u);
            {
                switch (unchecked((int)unchecked((Spv.ExecutionMode)i)))
                {
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeInvocations):
                    {
                        Std.fprintf(Std.stderr, "  Invocations: %u\n", arg0);
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSize):
                    {
                        Std.fprintf(Std.stderr, "  LocalSize: (%u, %u, %u)\n", arg0, arg1, arg2);
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputVertices):
                    {
                        Std.fprintf(Std.stderr, "  OutputVertices: %u\n", arg0);
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeSpacingEqual):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "SpacingEqual");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeSpacingFractionalEven):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "SpacingFractionalEven");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeSpacingFractionalOdd):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "SpacingFractionalOdd");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeVertexOrderCw):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "VertexOrderCw");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeVertexOrderCcw):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "VertexOrderCcw");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModePixelCenterInteger):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "PixelCenterInteger");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeOriginUpperLeft):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "OriginUpperLeft");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeOriginLowerLeft):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "OriginLowerLeft");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeEarlyFragmentTests):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "EarlyFragmentTests");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModePointMode):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "PointMode");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeXfb):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "Xfb");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthReplacing):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "DepthReplacing");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthGreater):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "DepthGreater");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthLess):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "DepthLess");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthUnchanged):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "DepthUnchanged");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSizeHint):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "LocalSizeHint");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeInputPoints):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "InputPoints");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeInputLines):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "InputLines");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeInputLinesAdjacency):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "InputLinesAdjacency");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeTriangles):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "Triangles");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeInputTrianglesAdjacency):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "InputTrianglesAdjacency");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeQuads):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "Quads");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeIsolines):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "Isolines");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputPoints):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "OutputPoints");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputLineStrip):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "OutputLineStrip");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputTriangleStrip):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "OutputTriangleStrip");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeVecTypeHint):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "VecTypeHint");
                        break;
                    }
                    case unchecked((int)Spv.ExecutionMode.ExecutionModeContractionOff):
                    {
                        Std.fprintf(Std.stderr, "  %s\n", "ContractionOff");
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
        });
        Std.fprintf(Std.stderr, "\n");
        Cli.Globals.print_resources(compiler, "subpass inputs", res.subpass_inputs);
        Cli.Globals.print_resources(compiler, "inputs", res.stage_inputs);
        Cli.Globals.print_resources(compiler, "outputs", res.stage_outputs);
        Cli.Globals.print_resources(compiler, "textures", res.sampled_images);
        Cli.Globals.print_resources(compiler, "separate images", res.separate_images);
        Cli.Globals.print_resources(compiler, "separate samplers", res.separate_samplers);
        Cli.Globals.print_resources(compiler, "images", res.storage_images);
        Cli.Globals.print_resources(compiler, "ssbos", res.storage_buffers);
        Cli.Globals.print_resources(compiler, "ubos", res.uniform_buffers);
        Cli.Globals.print_resources(compiler, "push", res.push_constant_buffers);
        Cli.Globals.print_resources(compiler, "counters", res.atomic_counters);
        Cli.Globals.print_resources(compiler, "acceleration structures", res.acceleration_structures);
        Cli.Globals.print_resources(compiler, "tensors", res.tensors);
        Cli.Globals.print_resources(compiler, "record buffers", res.shader_record_buffers);
        Cli.Globals.print_resources(compiler, Spv.StorageClass.StorageClassInput, res.builtin_inputs);
        Cli.Globals.print_resources(compiler, Spv.StorageClass.StorageClassOutput, res.builtin_outputs);
    }
    public static void print_push_constant_resources(Compiler compiler, CppVector<Resource> res)
    {
        {
            foreach (Resource block in res)
            {
                var ranges = compiler.get_active_buffer_ranges(((TypedID_TypeVariable)block.id));
                Std.fprintf(Std.stderr, "Active members in buffer: %s\n", !block.name.empty() ? block.name.c_str() : compiler.get_fallback_name(block.id).c_str());
                Std.fprintf(Std.stderr, "==================\n\n");
                {
                    foreach (BufferRange range in ranges)
                    {
                        var name = compiler.get_member_name(block.base_type_id, range.index);
                        Std.fprintf(Std.stderr, "Member #%3u (%s): Offset: %4u, Range: %4u\n", range.index, !name.empty() ? name.c_str() : compiler.get_fallback_member_name(range.index).c_str(), unchecked((uint)range.offset), unchecked((uint)range.range));
                    }
                }
                Std.fprintf(Std.stderr, "==================\n\n");
            }
        }
    }
    public static void print_spec_constants(Compiler compiler)
    {
        var spec_constants = compiler.get_specialization_constants();
        Std.fprintf(Std.stderr, "Specialization constants\n");
        Std.fprintf(Std.stderr, "==================\n\n");
        {
            foreach (SpecializationConstant c in spec_constants)
            {
                Std.fprintf(Std.stderr, "ID: %u, Spec ID: %u\n", ((uint)c.id), c.constant_id);
            }
        }
        Std.fprintf(Std.stderr, "==================\n\n");
    }
    public static void print_capabilities_and_extensions(Compiler compiler)
    {
        Std.fprintf(Std.stderr, "Capabilities\n");
        Std.fprintf(Std.stderr, "============\n");
        {
            foreach (Spv.Capability capability in compiler.get_declared_capabilities())
            {
                Std.fprintf(Std.stderr, "Capability: %u\n", unchecked((uint)capability));
            }
        }
        Std.fprintf(Std.stderr, "============\n\n");
        Std.fprintf(Std.stderr, "Extensions\n");
        Std.fprintf(Std.stderr, "============\n");
        {
            foreach (CppString ext in compiler.get_declared_extensions())
            {
                Std.fprintf(Std.stderr, "Extension: %s\n", ext.c_str());
            }
        }
        Std.fprintf(Std.stderr, "============\n\n");
    }
    public static void print_version()
    {
        Std.fprintf(Std.stderr, "Git revision unknown. Build with CMake to create timestamp and revision info.\n");
    }
    public static void print_help_backend()
    {
        Std.fprintf(Std.stderr, "\nSelect backend:\n\tBy default, OpenGL-style GLSL is the target, with #version and GLSL/ESSL information inherited from the SPIR-V module if present.\n\t[--vulkan-semantics] or [-V]:\n\t\tEmit Vulkan GLSL instead of plain GLSL. Makes use of Vulkan-only features to match SPIR-V.\n\t[--msl]:\n\t\tEmit Metal Shading Language (MSL).\n\t[--hlsl]:\n\t\tEmit HLSL.\n\t[--reflect]:\n\t\tEmit JSON reflection.\n\t[--cpp]:\n\t\tDEPRECATED. Emits C++ code.\n");
    }
    public static void print_help_glsl()
    {
        Std.fprintf(Std.stderr, "\nGLSL options:\n\t[--es]:\n\t\tForce ESSL.\n\t[--no-es]:\n\t\tForce desktop GLSL.\n\t[--version <GLSL version>]:\n\t\tE.g. --version 450 will emit '#version 450' in shader.\n\t\tCode generation will depend on the version used.\n\t[--flatten-ubo]:\n\t\tEmit UBOs as plain uniform arrays which are suitable for use with glUniform4*v().\n\t\tThis can be an optimization on GL implementations where this is faster or works around buggy driver implementations.\n\t\tE.g.: uniform MyUBO { vec4 a; float b, c, d, e; }; will be emitted as uniform vec4 MyUBO[2];\n\t\tCaveat: You cannot mix and match floating-point and integer in the same UBO with this option.\n\t\tLegacy GLSL/ESSL (where this flattening makes sense) does not support bit-casting, which would have been the obvious workaround.\n\t[--extension ext]:\n\t\tAdd #extension string of your choosing to GLSL output.\n\t\tUseful if you use variable name remapping to something that requires an extension unknown to SPIRV-Cross.\n\t[--remove-unused-variables]:\n\t\tDo not emit interface variables which are not statically accessed by the shader.\n\t[--separate-shader-objects]:\n\t\tRedeclare gl_PerVertex blocks to be suitable for desktop GL separate shader objects.\n\t[--glsl-emit-push-constant-as-ubo]:\n\t\tInstead of a plain uniform of struct for push constants, emit a UBO block instead.\n\t[--glsl-emit-ubo-as-plain-uniforms]:\n\t\tInstead of emitting UBOs, emit them as plain uniform structs.\n\t[--glsl-remap-ext-framebuffer-fetch input-attachment color-location]:\n\t\tRemaps an input attachment to use GL_EXT_shader_framebuffer_fetch.\n\t\tgl_LastFragData[location] is read from. The attachment to read from must be declared as an output in the shader.\n\t[--glsl-ext-framebuffer-fetch-noncoherent]:\n\t\tUses noncoherent qualifier for framebuffer fetch.\n\t[--vulkan-glsl-disable-ext-samplerless-texture-functions]:\n\t\tDo not allow use of GL_EXT_samperless_texture_functions, even in Vulkan GLSL.\n\t\tUse of texelFetch and similar might have to create dummy samplers to work around it.\n\t[--combined-samplers-inherit-bindings]:\n\t\tInherit binding information from the textures when building combined image samplers from separate textures and samplers.\n\t[--no-support-nonzero-baseinstance]:\n\t\tWhen using gl_InstanceIndex with desktop GL,\n\t\tassume that base instance is always 0, and do not attempt to fix up gl_InstanceID to match Vulkan semantics.\n\t[--pls-in format input-name]:\n\t\tRemaps a subpass input with name into a GL_EXT_pixel_local_storage input.\n\t\tEntry in PLS block is ordered where first --pls-in marks the first entry. Can be called multiple times.\n\t\tFormats allowed: r11f_g11f_b10f, r32f, rg16f, rg16, rgb10_a2, rgba8, rgba8i, rgba8ui, rg16i, rgb10_a2ui, rg16ui, r32ui.\n\t\tRequires ESSL.\n\t[--pls-out format output-name]:\n\t\tRemaps a color output with name into a GL_EXT_pixel_local_storage output.\n\t\tEntry in PLS block is ordered where first --pls-output marks the first entry. Can be called multiple times.\n\t\tFormats allowed: r11f_g11f_b10f, r32f, rg16f, rg16, rgb10_a2, rgba8, rgba8i, rgba8ui, rg16i, rgb10_a2ui, rg16ui, r32ui.\n\t\tRequires ESSL.\n\t[--remap source_name target_name components]:\n\t\tRemaps a variable to a different name with N components.\n\t\tMain use case is to remap a subpass input to gl_LastFragDepthARM.\n\t\tE.g.:\n\t\tuniform subpassInput uDepth;\n\t\t--remap uDepth gl_LastFragDepthARM 1 --extension GL_ARM_shader_framebuffer_fetch_depth_stencil\n\t[--no-420pack-extension]:\n\t\tDo not make use of GL_ARB_shading_language_420pack in older GL targets to support layout(binding).\n\t[--remap-variable-type <variable_name> <new_variable_type>]:\n\t\tRemaps a variable type based on name.\n\t\tPrimary use case is supporting external samplers in ESSL for video rendering on Android where you could remap a texture to a YUV one.\n\t[--glsl-force-flattened-io-blocks]:\n\t\tAlways flatten I/O blocks and structs.\n\t[--glsl-ovr-multiview-view-count count]:\n\t\tIn GL_OVR_multiview2, specify layout(num_views).\n\t[--glsl-descriptor-heap-set-binding desc_set binding]:\n\t\tInstead of layout(descriptor_heap), emit layout(set = desc_set, binding = binding) instead for compatibility with mapping API.\n");
    }
    public static void print_help_hlsl()
    {
        Std.fprintf(Std.stderr, "\nHLSL options:\n\t[--shader-model]:\n\t\tEnables a specific shader model, e.g. --shader-model 50 for SM 5.0.\n\t[--flatten-ubo]:\n\t\tEmit UBOs as plain uniform arrays.\n\t\tE.g.: uniform MyUBO { vec4 a; float b, c, d, e; }; will be emitted as uniform float4 MyUBO[2];\n\t\tCaveat: You cannot mix and match floating-point and integer in the same UBO with this option.\n\t[--hlsl-enable-compat]:\n\t\tAllow point size and point coord to be used, even if they won't work as expected.\n\t\tPointSize is ignored, and PointCoord returns (0.5, 0.5).\n\t[--hlsl-support-nonzero-basevertex-baseinstance]:\n\t\tSupport base vertex and base instance by emitting a special cbuffer declared as:\n\t\tcbuffer SPIRV_Cross_VertexInfo { int SPIRV_Cross_BaseVertex; int SPIRV_Cross_BaseInstance; };\n\t[--hlsl-basevertex-baseinstance-binding <register index> <register space>]:\n\t\tAssign a fixed binding to SPIRV_Cross_VertexInfo.\n\t[--hlsl-auto-binding (push, cbv, srv, uav, sampler, all)]\n\t\tDo not emit any : register(#) bindings for specific resource types, and rely on HLSL compiler to assign something.\n\t[--hlsl-force-storage-buffer-as-uav]:\n\t\tAlways emit SSBOs as UAVs, even when marked as read-only.\n\t\tNormally, SSBOs marked with NonWritable will be emitted as SRVs.\n\t[--hlsl-nonwritable-uav-texture-as-srv]:\n\t\tEmit NonWritable storage images as SRV textures instead of UAV.\n\t\tUsing this option messes with the type system. SPIRV-Cross cannot guarantee that this will work.\n\t\tOne major problem area with this feature is function arguments, where we won't know if we're seeing a UAV or SRV.\n\t\tShader must ensure that read/write state is consistent at all call sites.\n\t[--set-hlsl-vertex-input-semantic <location> <semantic>]:\n\t\tEmits a specific vertex input semantic for a given location.\n\t\tOtherwise, TEXCOORD# is used as semantics, where # is location.\n\t[--set-hlsl-named-vertex-input-semantic <name> <semantic>]:\n\t\tEmits a specific vertex input semantic for a given name.\n\t\tOpName reflection information must be intact.\n\t[--hlsl-enable-16bit-types]:\n\t\tEnables native use of half/int16_t/uint16_t and ByteAddressBuffer interaction with these types. Requires SM 6.2.\n\t[--hlsl-flatten-matrix-vertex-input-semantics]:\n\t\tEmits matrix vertex inputs with input semantics as if they were independent vectors, e.g. TEXCOORD{2,3,4} rather than matrix form TEXCOORD2_{0,1,2}.\n\t[--hlsl-preserve-structured-buffers]:\n\t\tEmit SturucturedBuffer<T> rather than ByteAddressBuffer. Requires UserTypeGOOGLE to be emitted. Intended for DXC roundtrips.\n\t[--hlsl-user-semantic]:\n\t\tUses UserSemantic decoration to generate vertex input and output semantics.\n");
    }
    public static void print_help_msl()
    {
        Std.fprintf(Std.stderr, "\nMSL options:\n\t[--msl-version <MMmmpp>]:\n\t\tUses a specific MSL version, e.g. --msl-version 20100 for MSL 2.1.\n\t[--msl-capture-output]:\n\t\tWrites geometry varyings to a buffer instead of as stage-outputs.\n\t[--msl-swizzle-texture-samples]:\n\t\tWorks around lack of support for VkImageView component swizzles.\n\t\tThis has a massive impact on performance and bloat. Do not use this unless you are absolutely forced to.\n\t\tTo use this feature, the API side must pass down swizzle buffers.\n\t\tShould only be used by translation layers as a last resort.\n\t\tRecent Metal versions do not require this workaround.\n\t[--msl-ios]:\n\t\tTarget iOS Metal instead of macOS Metal.\n\t[--msl-pad-fragment-output]:\n\t\tAlways emit color outputs as 4-component variables.\n\t\tIn Metal, the fragment shader must emit at least as many components as the render target format.\n\t[--msl-domain-lower-left]:\n\t\tUse a lower-left tessellation domain.\n\t[--msl-argument-buffers]:\n\t\tEmit Metal argument buffers instead of discrete resource bindings.\n\t\tRequires MSL 2.0 to be enabled.\n\t[--msl-argument-buffer-tier]:\n\t\tWhen using Metal argument buffers, indicate the Metal argument buffer tier level supported by the Metal platform.\n\t\tUses same values as Metal MTLArgumentBuffersTier enumeration (0 = Tier1, 1 = Tier2).\n\t\tNOTE: Setting this value no longer enables msl-argument-buffers implicitly.\n\t[--msl-runtime-array-rich-descriptor]:\n\t\tWhen declaring a runtime array of SSBOs, declare an array of {ptr, len} pairs to support OpArrayLength.\n\t[--msl-replace-recursive-inputs]:\n\t\tWorks around a Metal 3.1 regression bug, which causes an infinite recursion crash during Metal's analysis of an entry point input structure that itself contains internal recursion.\n\t[--msl-texture-buffer-native]:\n\t\tEnable native support for texel buffers. Otherwise, it is emulated as a normal texture.\n\t[--msl-input-attachment-is-ds-attachment]:\n\t\tAdds a simple depth passthrough in fragment shaders when they do not modify the depth value.\n\t\tRequired to force Metal to write to the depth/stencil attachment post fragment execution.\n\t\tOtherwise, Metal may optimize the write to pre fragment execution which goes against the Vulkan spec.\n\t\tOnly required if an input attachment and depth/stencil attachment reference the same resource.\n\t[--msl-framebuffer-fetch]:\n\t\tImplement subpass inputs with frame buffer fetch.\n\t\tEmits [[color(N)]] inputs in fragment stage.\n\t\tRequires an Apple GPU.\n\t[--msl-emulate-cube-array]:\n\t\tEmulate cube arrays with 2D array and manual math.\n\t[--msl-discrete-descriptor-set <index>]:\n\t\tWhen using argument buffers, forces a specific descriptor set to be implemented without argument buffers.\n\t\tUseful for implementing push descriptors in emulation layers.\n\t\tCan be used multiple times for each descriptor set in question.\n\t[--msl-device-argument-buffer <descriptor set index>]:\n\t\tUse device address space to hold indirect argument buffers instead of constant.\n\t\tComes up when trying to support argument buffers which are larger than 64 KiB.\n\t[--msl-multiview]:\n\t\tEnable SPV_KHR_multiview emulation.\n\t[--msl-multiview-no-layered-rendering]:\n\t\tDon't set [[render_target_array_index]] in multiview shaders.\n\t\tUseful for devices which don't support layered rendering. Only effective when --msl-multiview is enabled.\n\t[--msl-view-index-from-device-index]:\n\t\tTreat the view index as the device index instead.\n\t\tFor multi-GPU rendering.\n\t[--msl-dispatch-base]:\n\t\tAdd support for vkCmdDispatchBase() or similar APIs.\n\t\tOffsets the workgroup ID based on a buffer.\n\t[--msl-dynamic-buffer <set index> <binding>]:\n\t\tMarks a buffer as having dynamic offset.\n\t\tThe offset is applied in the shader with pointer arithmetic.\n\t\tUseful for argument buffers where it is non-trivial to apply dynamic offset otherwise.\n\t[--msl-inline-uniform-block <set index> <binding>]:\n\t\tIn argument buffers, mark an UBO as being an inline uniform block which is embedded into the argument buffer itself.\n\t[--msl-decoration-binding]:\n\t\tUse SPIR-V bindings directly as MSL bindings.\n\t\tThis does not work in the general case as there is no descriptor set support, and combined image samplers are split up.\n\t\tHowever, if the shader author knows of binding limitations, this option will avoid the need for reflection on Metal side.\n\t[--msl-force-active-argument-buffer-resources]:\n\t\tAlways emit resources which are part of argument buffers.\n\t\tThis makes sure that similar shaders with same resource declarations can share the argument buffer as declaring an argument buffer implies an ABI.\n\t[--msl-force-native-arrays]:\n\t\tRather than implementing array types as a templated value type ala std::array<T>, use plain, native arrays.\n\t\tThis will lead to worse code-gen, but can work around driver bugs on certain driver revisions of certain Intel-based Macbooks where template arrays break.\n\t[--msl-disable-frag-depth-builtin]:\n\t\tDisables FragDepth output. Useful if pipeline does not enable depth, as pipeline creation might otherwise fail.\n\t[--msl-disable-frag-stencil-ref-builtin]:\n\t\tDisable FragStencilRef output. Useful if pipeline does not enable stencil output, as pipeline creation might otherwise fail.\n\t[--msl-enable-frag-output-mask <mask>]:\n\t\tOnly selectively enable fragment outputs. Useful if pipeline does not enable fragment output for certain locations, as pipeline creation might otherwise fail.\n\t[--msl-no-clip-distance-user-varying]:\n\t\tDo not emit user varyings to emulate gl_ClipDistance in fragment shaders.\n\t[--msl-add-shader-input <index> <format> <size> <rate>]:\n\t\tSpecify the format of the shader input at <index>.\n\t\t<format> can be 'any32', 'any16', 'u16', 'u8', or 'other', to indicate a 32-bit opaque value, 16-bit opaque value, 16-bit unsigned integer, 8-bit unsigned integer, or other-typed variable. <size> is the vector length of the variable, which must be greater than or equal to that declared in the shader. <rate> can be 'vertex', 'primitive', or 'patch' to indicate a per-vertex, per-primitive, or per-patch variable.\n\t\tUseful if shader stage interfaces don't match up, as pipeline creation might otherwise fail.\n\t[--msl-add-shader-output <index> <format> <size> <rate>]:\n\t\tSpecify the format of the shader output at <index>.\n\t\t<format> can be 'any32', 'any16', 'u16', 'u8', or 'other', to indicate a 32-bit opaque value, 16-bit opaque value, 16-bit unsigned integer, 8-bit unsigned integer, or other-typed variable. <size> is the vector length of the variable, which must be greater than or equal to that declared in the shader. <rate> can be 'vertex', 'primitive', or 'patch' to indicate a per-vertex, per-primitive, or per-patch variable.\n\t\tUseful if shader stage interfaces don't match up, as pipeline creation might otherwise fail.\n\t[--msl-shader-input <index> <format> <size>]:\n\t\tSpecify the format of the shader input at <index>.\n\t\t<format> can be 'any32', 'any16', 'u16', 'u8', or 'other', to indicate a 32-bit opaque value, 16-bit opaque value, 16-bit unsigned integer, 8-bit unsigned integer, or other-typed variable. <size> is the vector length of the variable, which must be greater than or equal to that declared in the shader.\t\tEquivalent to --msl-add-shader-input with a rate of 'vertex'.\n\t[--msl-shader-output <index> <format> <size>]:\n\t\tSpecify the format of the shader output at <index>.\n\t\t<format> can be 'any32', 'any16', 'u16', 'u8', or 'other', to indicate a 32-bit opaque value, 16-bit opaque value, 16-bit unsigned integer, 8-bit unsigned integer, or other-typed variable. <size> is the vector length of the variable, which must be greater than or equal to that declared in the shader.\t\tEquivalent to --msl-add-shader-output with a rate of 'vertex'.\n\t[--msl-raw-buffer-tese-input]:\n\t\tUse raw buffers for tessellation evaluation input.\n\t\tThis allows the use of nested structures and arrays.\n\t\tIn a future version of SPIRV-Cross, this will become the default.\n\t[--msl-multi-patch-workgroup]:\n\t\tUse the new style of tessellation control processing, where multiple patches are processed per workgroup.\n\t\tThis should increase throughput by ensuring all the GPU's SIMD lanes are occupied, but it is not compatible with the old style.\n\t\tIn addition, this style also passes input variables in buffers directly instead of using vertex attribute processing.\n\t\tIn a future version of SPIRV-Cross, this will become the default.\n\t[--msl-vertex-for-tessellation]:\n\t\tWhen handling a vertex shader, marks it as one that will be used with a new-style tessellation control shader.\n\t\tThe vertex shader is output to MSL as a compute kernel which outputs vertices to the buffer in the order they are received, rather than in index order as with --msl-capture-output normally.\n\t[--msl-additional-fixed-sample-mask <mask>]:\n\t\tSet an additional fixed sample mask. If the shader outputs a sample mask, then the final sample mask will be a bitwise AND of the two.\n\t[--msl-arrayed-subpass-input]:\n\t\tAssume that images of dimension SubpassData have multiple layers. Layered input attachments are accessed relative to BuiltInLayer.\n\t\tThis option has no effect if multiview is also enabled.\n\t[--msl-r32ui-linear-texture-align <alignment>]:\n\t\tThe required alignment of linear textures of format MTLPixelFormatR32Uint.\n\t\tThis is used to align the row stride for atomic accesses to such images.\n\t[--msl-r32ui-linear-texture-align-constant-id <id>]:\n\t\tThe function constant ID to use for the linear texture alignment.\n\t\tOn MSL 1.2 or later, you can override the alignment by setting this function constant.\n\t[--msl-texture-1d-as-2d]:\n\t\tEmit Image variables of dimension Dim1D as texture2d.\n\t\tIn Metal, 1D textures do not support all features that 2D textures do. Use this option if your code relies on these features.\n\t[--msl-ios-use-simdgroup-functions]:\n\t\tUse simd_*() functions for subgroup ops instead of quad_*().\n\t\tRecent Apple GPUs support SIMD-groups larger than a quad. Use this option to take advantage of this support.\n\t[--msl-emulate-subgroups]:\n\t\tAssume subgroups of size 1.\n\t\tIntended for Vulkan Portability implementations where Metal support for SIMD-groups is insufficient for true subgroups.\n\t[--msl-fixed-subgroup-size <size>]:\n\t\tAssign a constant <size> to the SubgroupSize builtin.\n\t\tIntended for Vulkan Portability implementations where VK_EXT_subgroup_size_control is not supported or disabled.\n\t\tIf 0, assume variable subgroup size as actually exposed by Metal.\n\t[--msl-force-sample-rate-shading]:\n\t\tForce fragment shaders to run per sample.\n\t\tThis adds a [[sample_id]] parameter if none is already present.\n\t[--msl-no-manual-helper-invocation-updates]:\n\t\tDo not manually update the HelperInvocation builtin when a fragment is discarded.\n\t\tSome Metal devices have a bug where simd_is_helper_thread() does not return true\n\t\tafter the fragment is discarded. This behavior is required by Vulkan and SPIR-V, however.\n\t[--msl-check-discarded-frag-stores]:\n\t\tAdd additional checks to resource stores in a fragment shader.\n\t\tSome Metal devices have a bug where stores to resources from a fragment shader\n\t\tcontinue to execute, even when the fragment is discarded. These checks\n\t\tprevent these stores from executing.\n\t[--msl-force-frag-execution]:\n\t\tEnforces fragment execution to avoid early discard by Metal\n\t\tMetal will prematurely discard fragments before execution when side effects are present.\n\t\tThis condition is triggered under the following conditions (side effect operations happen before discard):\n\t\t\t1. Pre fragment depth test fails.\n\t\t\t2. Modify depth value in fragment shader to constant value known at compile time.\n\t\t\t3. Constant value will not pass post fragment depth test.\n\t\t\t4. Fragment is always discarded in fragment execution.\n\t\tHowever, Vulkan expects fragment shader to be executed since it cannot be discarded until the discard\n\t\tpresent in the fragment execution, which would also execute the operations with side effects.\n\t[--msl-emulate-reversed-depth-viewport]:\n\t\tEmulate reversed-depth viewports by inverting clip-space Z.\n\t[--msl-emulate-depth-clip-enable]:\n\t\tEmulate Vulkan depth clip and clamp combinations unsupported by Metal.\n\t[--msl-sample-dref-lod-array-as-grad]:\n\t\tUse a gradient instead of a level argument.\n\t\tSome Metal devices have a bug where the level() argument to\n\t\tdepth2d_array<T>::sample_compare() in a fragment shader is biased by some\n\t\tunknown amount. This prevents the bias from being added.\n\t[--msl-no-readwrite-texture-fences]:\n\t\tDo not insert fences before each read of a\n\t\tread_write texture. MSL does not guarantee coherence between writes and later reads\n\t\tof read_write textures. If you don't rely on this, you can disable this for a\n\t\tpossible performance improvement.\n\t[--msl-agx-manual-cube-grad-fixup]:\n\t\tManually transform cube texture gradients.\n\t\tAll released Apple Silicon GPUs to date ignore one of the three partial derivatives\n\t\tbased on the selected major axis, and expect the remaining derivatives to be\n\t\tpartially transformed. This fixup gives correct results on Apple Silicon.\n\t[--msl-combined-sampler-suffix <suffix>]:\n\t\tUses a custom suffix for combined samplers.\n\t[--msl-disable-rasterization]:\n\t\tDisables rasterization and returns void from vertex-like entry points.\n\t[--msl-auto-disable-rasterization]:\n\t\tDisables rasterization if BuiltInPosition is not written.\n\t[--msl-default-point-size <size>]:\n\t\tApplies a default value if BuiltInPointSize is not written.\n");
    }
    public static void print_help_common()
    {
        Std.fprintf(Std.stderr, "\nCommon options:\n\t[--entry name]:\n\t\tUse a specific entry point. By default, the first entry point in the module is used.\n\t[--stage <stage (vert, frag, geom, tesc, tese, comp)>]:\n\t\tForces use of a certain shader stage.\n\t\tCan disambiguate the entry point if more than one entry point exists with same name, but different stage.\n\t[--emit-line-directives]:\n\t\tIf SPIR-V has OpLine directives, aim to emit those accurately in output code as well.\n\t[--rename-entry-point <old> <new> <stage>]:\n\t\tRenames an entry point from what is declared in SPIR-V to code output.\n\t\tMostly relevant for HLSL or MSL.\n\t[--rename-interface-variable <in|out> <location> <new_variable_name>]:\n\t\tRename an interface variable based on location decoration.\n\t[--force-zero-initialized-variables]:\n\t\tForces temporary variables to be initialized to zero.\n\t\tCan be useful in environments where compilers do not allow potentially uninitialized variables.\n\t\tThis usually comes up with Phi temporaries.\n\t[--fixup-clipspace]:\n\t\tFixup Z clip-space at the end of a vertex shader. The behavior is backend-dependent.\n\t\tGLSL: Rewrites [0, w] Z range (D3D/Metal/Vulkan) to GL-style [-w, w].\n\t\tHLSL/MSL: Rewrites [-w, w] Z range (GL) to D3D/Metal/Vulkan-style [0, w].\n\t[--flip-vert-y]:\n\t\tInverts gl_Position.y (or equivalent) at the end of a vertex shader. This is equivalent to using negative viewport height.\n\t[--mask-stage-output-location <location> <component>]:\n\t\tIf a stage output variable with matching location and component is active, optimize away the variable if applicable.\n\t[--mask-stage-output-builtin <Position|PointSize|ClipDistance|CullDistance>]:\n\t\tIf a stage output variable with matching builtin is active, optimize away the variable if it can affect cross-stage linking correctness.\n\t[--relax-nan-checks]:\n\t\tRelax NaN checks for N{Clamp,Min,Max} and ordered vs. unordered compare instructions.\n");
    }
    public static void print_help_obscure()
    {
        Std.fprintf(Std.stderr, "\nObscure options:\n\tThese options are not meant to be used on a regular basis. They have some occasional uses in the test suite.\n\t[--force-temporary]:\n\t\tAggressively emit temporary expressions instead of forwarding expressions. Very rarely used and under-tested.\n\t[--revision]:\n\t\tPrints build timestamp and Git commit information (updated when cmake is configured).\n\t[--iterations iter]:\n\t\tRecompiles the same shader over and over, benchmarking related.\n\t[--disable-storage-image-qualifier-deduction]:\n\t\tIf storage images are received without any nonwritable or nonreadable information,\n\t\tdo not attempt to analyze usage, and always emit read/write state.\n\t[--flatten-multidimensional-arrays]:\n\t\tDo not support multi-dimensional arrays and flatten them to one dimension.\n\t[--cpp-interface-name <name>]:\n\t\tEmit a specific class name in C++ codegen.\n\t[--force-recompile-max-debug-iterations <count>]:\n\t\tAllow compilation loop to run for N loops.\n\t\tCan be used to triage workarounds, but should not be used as a crutch, since it masks an implementation bug.\n");
    }
    public static void print_help_all()
    {
        Cli.Globals.print_version();
        Std.fprintf(Std.stderr, "Usage: spirv-cross [SPIR-V file] [options]\n\nBasic:\n\t[SPIR-V file] (- is stdin)\n\t[--output <output path>]: If not provided, prints output to stdout.\n\t[--dump-resources]:\n\t\tPrints a basic reflection of the SPIR-V module along with other output.\n\t[--help]:\n\t\tPrints a summary help message.\n");
        Cli.Globals.print_help_backend();
        Cli.Globals.print_help_common();
        Cli.Globals.print_help_glsl();
        Cli.Globals.print_help_msl();
        Cli.Globals.print_help_hlsl();
        Cli.Globals.print_help_obscure();
    }
    public static void print_help()
    {
        Cli.Globals.print_version();
        Std.fprintf(Std.stderr, "Usage: spirv-cross [SPIR-V file] [options]\n\nBasic:\n\t[SPIR-V file] (- is stdin)\n\t[--output <output path>]: If not provided, prints output to stdout.\n\t[--help]:\n\t\tPrints this summary help message.\n\t[--help-all]:\n\t\tPrints all available help options.\n");
        Cli.Globals.print_help_backend();
        Cli.Globals.print_help_common();
        Std.fprintf(Std.stderr, "\nHelp Categories:\n\t[--help-glsl]\n\t[--help-msl]\n\t[--help-hlsl]\n\t[--help-obscure]\n");
    }
    public static bool remap_generic(Compiler compiler, CppVector<Resource> resources, Cli.Remap remap)
    {
        var itr = Std.find_if(Std.begin(resources), Std.end(resources), (Resource res) =>
        {
            return res.name == remap.src_name;
        });
        if (itr != Std.end(resources))
        {
            compiler.set_remapped_variable_state(((TypedID_TypeVariable)itr.deref().id), true);
            compiler.set_name(itr.deref().id, remap.dst_name);
            compiler.set_subpass_input_remapped_components(((TypedID_TypeVariable)itr.deref().id), remap.components);
            return true;
        }
        else
        {
            return false;
        }
    }
    public static CppVector<PlsRemap> remap_pls(CppVector<Cli.PLSArg> pls_variables, CppVector<Resource> resources, CppVector<Resource> secondary_resources)
    {
        CppVector<PlsRemap> ret = new CppVector<PlsRemap>();
        {
            foreach (Cli.PLSArg pls in pls_variables)
            {
                bool found = false;
                {
                    foreach (Resource res in resources)
                    {
                        if (res.name == pls.name)
                        {
                            ret.push_back(new PlsRemap { id = ((uint)res.id), format = pls.format });
                            found = true;
                            break;
                        }
                    }
                }
                if (!found && secondary_resources != null)
                {
                    {
                        foreach (Resource res in secondary_resources)
                        {
                            if (res.name == pls.name)
                            {
                                ret.push_back(new PlsRemap { id = ((uint)res.id), format = pls.format });
                                found = true;
                                break;
                            }
                        }
                    }
                }
                if (!found)
                {
                    Std.fprintf(Std.stderr, "Did not find stage input/output/target with name \"%s\".\n", pls.name.c_str());
                }
            }
        }
        return ret;
    }
    public static PlsFormat pls_format(string str)
    {
        if (!(Std.strcmp(str, "r11f_g11f_b10f") != 0))
        {
            return PlsFormat.PlsR11FG11FB10F;
        }
        else
        if (!(Std.strcmp(str, "r32f") != 0))
        {
            return PlsFormat.PlsR32F;
        }
        else
        if (!(Std.strcmp(str, "rg16f") != 0))
        {
            return PlsFormat.PlsRG16F;
        }
        else
        if (!(Std.strcmp(str, "rg16") != 0))
        {
            return PlsFormat.PlsRG16;
        }
        else
        if (!(Std.strcmp(str, "rgb10_a2") != 0))
        {
            return PlsFormat.PlsRGB10A2;
        }
        else
        if (!(Std.strcmp(str, "rgba8") != 0))
        {
            return PlsFormat.PlsRGBA8;
        }
        else
        if (!(Std.strcmp(str, "rgba8i") != 0))
        {
            return PlsFormat.PlsRGBA8I;
        }
        else
        if (!(Std.strcmp(str, "rgba8ui") != 0))
        {
            return PlsFormat.PlsRGBA8UI;
        }
        else
        if (!(Std.strcmp(str, "rg16i") != 0))
        {
            return PlsFormat.PlsRG16I;
        }
        else
        if (!(Std.strcmp(str, "rgb10_a2ui") != 0))
        {
            return PlsFormat.PlsRGB10A2UI;
        }
        else
        if (!(Std.strcmp(str, "rg16ui") != 0))
        {
            return PlsFormat.PlsRG16UI;
        }
        else
        if (!(Std.strcmp(str, "r32ui") != 0))
        {
            return PlsFormat.PlsR32UI;
        }
        else
        {
            return PlsFormat.PlsNone;
        }
    }
    public static Spv.ExecutionModel stage_to_execution_model(CppString stage)
    {
        if (stage == "vert")
        {
            return Spv.ExecutionModel.ExecutionModelVertex;
        }
        else
        if (stage == "frag")
        {
            return Spv.ExecutionModel.ExecutionModelFragment;
        }
        else
        if (stage == "comp")
        {
            return Spv.ExecutionModel.ExecutionModelGLCompute;
        }
        else
        if (stage == "tesc")
        {
            return Spv.ExecutionModel.ExecutionModelTessellationControl;
        }
        else
        if (stage == "tese")
        {
            return Spv.ExecutionModel.ExecutionModelTessellationEvaluation;
        }
        else
        if (stage == "geom")
        {
            return Spv.ExecutionModel.ExecutionModelGeometry;
        }
        else
        if (stage == "rgen")
        {
            return Spv.ExecutionModel.ExecutionModelRayGenerationKHR;
        }
        else
        if (stage == "rint")
        {
            return Spv.ExecutionModel.ExecutionModelIntersectionKHR;
        }
        else
        if (stage == "rahit")
        {
            return Spv.ExecutionModel.ExecutionModelAnyHitKHR;
        }
        else
        if (stage == "rchit")
        {
            return Spv.ExecutionModel.ExecutionModelClosestHitKHR;
        }
        else
        if (stage == "rmiss")
        {
            return Spv.ExecutionModel.ExecutionModelMissKHR;
        }
        else
        if (stage == "rcall")
        {
            return Spv.ExecutionModel.ExecutionModelCallableKHR;
        }
        else
        if (stage == "mesh")
        {
            return Spv.ExecutionModel.ExecutionModelMeshEXT;
        }
        else
        if (stage == "task")
        {
            return Spv.ExecutionModel.ExecutionModelTaskEXT;
        }
        else
        {
            throw new CompilerError("Invalid stage.");
        }
    }
    public static uint hlsl_resource_type_to_flag(CppString arg)
    {
        if (arg == "push")
        {
            return unchecked((uint)HLSLBindingFlagBits.HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT);
        }
        else
        if (arg == "cbv")
        {
            return unchecked((uint)HLSLBindingFlagBits.HLSL_BINDING_AUTO_CBV_BIT);
        }
        else
        if (arg == "srv")
        {
            return unchecked((uint)HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT);
        }
        else
        if (arg == "uav")
        {
            return unchecked((uint)HLSLBindingFlagBits.HLSL_BINDING_AUTO_UAV_BIT);
        }
        else
        if (arg == "sampler")
        {
            return unchecked((uint)HLSLBindingFlagBits.HLSL_BINDING_AUTO_SAMPLER_BIT);
        }
        else
        if (arg == "all")
        {
            return unchecked((uint)HLSLBindingFlagBits.HLSL_BINDING_AUTO_ALL);
        }
        else
        {
            Std.fprintf(Std.stderr, "Invalid resource type for --hlsl-auto-binding: %s\n", arg.c_str());
            return 0u;
        }
    }
    public static CppString compile_iteration(Cli.CLIArguments args, CppVector<uint> spirv_file)
    {
        Parser spirv_parser = new Parser(spirv_file);
        spirv_parser.parse();
        CompilerGLSL compiler = null;
        bool combined_image_samplers = false;
        bool build_dummy_sampler = false;
        if (args.cpp)
        {
            compiler = new CompilerCPP(spirv_parser.get_parsed_ir());
            if (args.cpp_interface_name != null)
            {
                ((CompilerCPP)compiler).set_interface_name(new CppString(args.cpp_interface_name));
            }
        }
        else
        if (args.msl)
        {
            compiler = new CompilerMSL(spirv_parser.get_parsed_ir());
            var msl_comp = (CompilerMSL)compiler;
            var msl_opts = (msl_comp.get_msl_options()).Clone();
            if (args.set_msl_version)
            {
                msl_opts.msl_version = args.msl_version;
            }
            msl_opts.capture_output_to_buffer = args.msl_capture_output_to_buffer;
            msl_opts.swizzle_texture_samples = args.msl_swizzle_texture_samples;
            msl_opts.invariant_float_math = args.msl_invariant_float_math;
            if (args.msl_ios)
            {
                msl_opts.platform = CompilerMSL.Options.Platform.iOS;
                msl_opts.emulate_cube_array = args.msl_emulate_cube_array;
            }
            msl_opts.use_framebuffer_fetch_subpasses = args.msl_framebuffer_fetch;
            msl_opts.pad_fragment_output_components = args.msl_pad_fragment_output;
            msl_opts.tess_domain_origin_lower_left = args.msl_domain_lower_left;
            msl_opts.argument_buffers = args.msl_argument_buffers;
            msl_opts.argument_buffers_tier = unchecked((CompilerMSL.Options.ArgumentBuffersTier)args.msl_argument_buffers_tier);
            msl_opts.texture_buffer_native = args.msl_texture_buffer_native;
            msl_opts.multiview = args.msl_multiview;
            msl_opts.multiview_layered_rendering = args.msl_multiview_layered_rendering;
            msl_opts.view_index_from_device_index = args.msl_view_index_from_device_index;
            msl_opts.dispatch_base = args.msl_dispatch_base;
            msl_opts.enable_decoration_binding = args.msl_decoration_binding;
            msl_opts.force_active_argument_buffer_resources = args.msl_force_active_argument_buffer_resources;
            msl_opts.force_native_arrays = args.msl_force_native_arrays;
            msl_opts.enable_frag_depth_builtin = args.msl_enable_frag_depth_builtin;
            msl_opts.enable_frag_stencil_ref_builtin = args.msl_enable_frag_stencil_ref_builtin;
            msl_opts.enable_frag_output_mask = args.msl_enable_frag_output_mask;
            msl_opts.enable_clip_distance_user_varying = args.msl_enable_clip_distance_user_varying;
            msl_opts.raw_buffer_tese_input = args.msl_raw_buffer_tese_input;
            msl_opts.multi_patch_workgroup = args.msl_multi_patch_workgroup;
            msl_opts.vertex_for_tessellation = args.msl_vertex_for_tessellation;
            msl_opts.additional_fixed_sample_mask = args.msl_additional_fixed_sample_mask;
            msl_opts.arrayed_subpass_input = args.msl_arrayed_subpass_input;
            msl_opts.r32ui_linear_texture_alignment = args.msl_r32ui_linear_texture_alignment;
            msl_opts.r32ui_alignment_constant_id = args.msl_r32ui_alignment_constant_id;
            msl_opts.texture_1D_as_2D = args.msl_texture_1d_as_2d;
            msl_opts.ios_use_simdgroup_functions = args.msl_ios_use_simdgroup_functions;
            msl_opts.emulate_subgroups = args.msl_emulate_subgroups;
            msl_opts.fixed_subgroup_size = args.msl_fixed_subgroup_size;
            msl_opts.force_sample_rate_shading = args.msl_force_sample_rate_shading;
            msl_opts.manual_helper_invocation_updates = args.msl_manual_helper_invocation_updates;
            msl_opts.check_discarded_frag_stores = args.msl_check_discarded_frag_stores;
            msl_opts.force_fragment_with_side_effects_execution = args.msl_force_fragment_with_side_effects_execution;
            msl_opts.emulate_reversed_depth_viewport = args.msl_emulate_reversed_depth_viewport;
            msl_opts.emulate_depth_clip_enable = args.msl_emulate_depth_clip_enable;
            msl_opts.sample_dref_lod_array_as_grad = args.msl_sample_dref_lod_array_as_grad;
            msl_opts.ios_support_base_vertex_instance = true;
            msl_opts.runtime_array_rich_descriptor = args.msl_runtime_array_rich_descriptor;
            msl_opts.replace_recursive_inputs = args.msl_replace_recursive_inputs;
            msl_opts.input_attachment_is_ds_attachment = args.msl_input_attachment_is_ds_attachment;
            msl_opts.readwrite_texture_fences = args.msl_readwrite_texture_fences;
            msl_opts.agx_manual_cube_grad_fixup = args.msl_agx_manual_cube_grad_fixup;
            msl_opts.disable_rasterization = args.msl_disable_rasterization;
            msl_opts.auto_disable_rasterization = args.msl_auto_disable_rasterization;
            msl_opts.enable_point_size_default = args.msl_enable_point_size_default;
            msl_opts.default_point_size = args.msl_default_point_size;
            msl_comp.set_msl_options(msl_opts);
            {
                foreach (uint v in args.msl_discrete_descriptor_sets)
                {
                    msl_comp.add_discrete_descriptor_set(v);
                }
            }
            {
                foreach (uint v in args.msl_device_argument_buffers)
                {
                    msl_comp.set_argument_buffer_device_address_space(v, true);
                }
            }
            uint i = 0u;
            {
                foreach (Pair<uint, uint> v in args.msl_dynamic_buffers)
                {
                    msl_comp.add_dynamic_buffer(v.first, v.second, i++);
                }
            }
            {
                foreach (Pair<uint, uint> v in args.msl_inline_uniform_blocks)
                {
                    msl_comp.add_inline_uniform_block(v.first, v.second);
                }
            }
            {
                foreach (MSLShaderInterfaceVariable v in args.msl_shader_inputs)
                {
                    msl_comp.add_msl_shader_input(v);
                }
            }
            {
                foreach (MSLShaderInterfaceVariable v in args.msl_shader_outputs)
                {
                    msl_comp.add_msl_shader_output(v);
                }
            }
            if (args.msl_combined_sampler_suffix != null)
            {
                msl_comp.set_combined_sampler_suffix(args.msl_combined_sampler_suffix);
            }
        }
        else
        if (args.hlsl)
        {
            compiler = new CompilerHLSL(spirv_parser.get_parsed_ir());
        }
        else
        {
            combined_image_samplers = !args.vulkan_semantics;
            if (!args.vulkan_semantics || args.vulkan_glsl_disable_ext_samplerless_texture_functions)
            {
                build_dummy_sampler = true;
            }
            compiler = new CompilerGLSL(spirv_parser.get_parsed_ir());
        }
        if (!args.variable_type_remaps.empty())
        {
            Callback_126331 remap_cb = (SPIRType _p, CppString name, ref CppString @out) =>
            {
                {
                    foreach (Cli.VariableTypeRemap remap in args.variable_type_remaps)
                    {
                        if (name == remap.variable_name)
                        {
                            @out = remap.new_variable_type;
                        }
                    }
                }
            };
            compiler.set_variable_type_remap_callback(remap_cb);
        }
        {
            foreach (Pair<uint, uint> masked in args.masked_stage_outputs)
            {
                compiler.mask_stage_output_by_location(masked.first, masked.second);
            }
        }
        {
            foreach (Spv.BuiltIn masked in args.masked_stage_builtins)
            {
                compiler.mask_stage_output_by_builtin(masked);
            }
        }
        {
            foreach (Cli.CLIArguments.Rename rename in args.entry_point_rename)
            {
                compiler.rename_entry_point(rename.old_name, rename.new_name, rename.execution_model);
            }
        }
        var entry_points = compiler.get_entry_points_and_stages();
        var entry_point = args.entry;
        Spv.ExecutionModel model = Spv.ExecutionModel.ExecutionModelMax;
        if (!args.entry_stage.empty())
        {
            model = Cli.Globals.stage_to_execution_model(args.entry_stage);
            if (entry_point.empty())
            {
                {
                    foreach (EntryPoint e in entry_points)
                    {
                        if (unchecked((int)e.execution_model) == unchecked((int)model))
                        {
                            entry_point = e.name;
                            break;
                        }
                    }
                }
                if (entry_point.empty())
                {
                    Std.fprintf(Std.stderr, "Could not find an entry point with stage: %s\n", args.entry_stage.c_str());
                    Std.exit(1);
                }
            }
            else
            {
                bool exists = false;
                {
                    foreach (EntryPoint e in entry_points)
                    {
                        if (unchecked((int)e.execution_model) == unchecked((int)model) && e.name == entry_point)
                        {
                            exists = true;
                            break;
                        }
                    }
                }
                if (!exists)
                {
                    Std.fprintf(Std.stderr, "Could not find an entry point %s with stage: %s\n", entry_point.c_str(), args.entry_stage.c_str());
                    Std.exit(1);
                }
            }
        }
        else
        if (!entry_point.empty())
        {
            uint stage_count = 0u;
            {
                foreach (EntryPoint e in entry_points)
                {
                    if (e.name == entry_point)
                    {
                        stage_count++;
                        model = e.execution_model;
                    }
                }
            }
            if (stage_count == 0u)
            {
                Std.fprintf(Std.stderr, "There is no entry point with name: %s\n", entry_point.c_str());
                Std.exit(1);
            }
            else
            if (stage_count > 1u)
            {
                Std.fprintf(Std.stderr, "There is more than one entry point with name: %s. Use --stage.\n", entry_point.c_str());
                Std.exit(1);
            }
        }
        if (!entry_point.empty())
        {
            compiler.set_entry_point(entry_point, model);
        }
        if (!args.set_version && !(compiler.get_common_options().version != 0u))
        {
            Std.fprintf(Std.stderr, "Didn't specify GLSL version and SPIR-V did not specify language.\n");
            Cli.Globals.print_help();
            Std.exit(1);
        }
        CompilerGLSL.Options opts = (compiler.get_common_options()).Clone();
        if (args.set_version)
        {
            opts.version = args.version;
        }
        if (args.set_es)
        {
            opts.es = args.es;
        }
        opts.force_temporary = args.force_temporary;
        opts.separate_shader_objects = args.sso;
        opts.flatten_multidimensional_arrays = args.flatten_multidimensional_arrays;
        opts.enable_420pack_extension = args.use_420pack_extension;
        opts.vulkan_semantics = args.vulkan_semantics;
        opts.vertex.fixup_clipspace = args.fixup;
        opts.vertex.flip_vert_y = args.yflip;
        opts.vertex.support_nonzero_base_instance = args.support_nonzero_baseinstance;
        opts.emit_push_constant_as_uniform_buffer = args.glsl_emit_push_constant_as_ubo;
        opts.emit_uniform_buffer_as_plain_uniforms = args.glsl_emit_ubo_as_plain_uniforms;
        opts.force_flattened_io_blocks = args.glsl_force_flattened_io_blocks;
        opts.ovr_multiview_view_count = args.glsl_ovr_multiview_view_count;
        opts.emit_line_directives = args.emit_line_directives;
        opts.enable_storage_image_qualifier_deduction = args.enable_storage_image_qualifier_deduction;
        opts.force_zero_initialized_variables = args.force_zero_initialized_variables;
        opts.relax_nan_checks = args.relax_nan_checks;
        opts.force_recompile_max_debug_iterations = args.force_recompile_max_debug_iterations;
        compiler.set_common_options(opts);
        if (args.glsl_descriptor_heap_set != 4294967295u)
        {
            compiler.remap_descriptor_heap(ResourceType.ResourceTypeUnknown, args.glsl_descriptor_heap_set, args.glsl_descriptor_heap_binding, Spv.Dim.DimMax);
        }
        {
            foreach (Pair<uint, uint> fetch in args.glsl_ext_framebuffer_fetch)
            {
                compiler.remap_ext_framebuffer_fetch(fetch.first, fetch.second, !args.glsl_ext_framebuffer_fetch_noncoherent);
            }
        }
        if (args.hlsl)
        {
            var hlsl = (CompilerHLSL)compiler;
            var hlsl_opts = (hlsl.get_hlsl_options()).Clone();
            if (args.set_shader_model)
            {
                if (args.shader_model < 30u)
                {
                    Std.fprintf(Std.stderr, "Shader model earlier than 30 (3.0) not supported.\n");
                    Std.exit(1);
                }
                hlsl_opts.shader_model = args.shader_model;
            }
            if (args.hlsl_compat)
            {
                hlsl_opts.point_size_compat = true;
                hlsl_opts.point_coord_compat = true;
            }
            if (hlsl_opts.shader_model <= 30u)
            {
                combined_image_samplers = true;
                build_dummy_sampler = true;
            }
            if (!args.entry_point_rename.empty())
            {
                hlsl_opts.use_entry_point_name = true;
            }
            hlsl_opts.support_nonzero_base_vertex_base_instance = args.hlsl_support_nonzero_base;
            hlsl_opts.force_storage_buffer_as_uav = args.hlsl_force_storage_buffer_as_uav;
            hlsl_opts.nonwritable_uav_texture_as_srv = args.hlsl_nonwritable_uav_texture_as_srv;
            hlsl_opts.enable_16bit_types = args.hlsl_enable_16bit_types;
            hlsl_opts.flatten_matrix_vertex_input_semantics = args.hlsl_flatten_matrix_vertex_input_semantics;
            hlsl_opts.preserve_structured_buffers = args.hlsl_preserve_structured_buffers;
            hlsl_opts.user_semantic = args.hlsl_user_semantic;
            hlsl.set_hlsl_options(hlsl_opts);
            hlsl.set_resource_binding_flags(args.hlsl_binding_flags);
            if (args.hlsl_base_vertex_index_explicit_binding)
            {
                hlsl.set_hlsl_aux_buffer_binding(HLSLAuxBinding.HLSL_AUX_BINDING_BASE_VERTEX_INSTANCE, args.hlsl_base_vertex_index_register_index, args.hlsl_base_vertex_index_register_space);
            }
        }
        if (build_dummy_sampler)
        {
            uint sampler = ((uint)compiler.build_dummy_sampler_for_combined_images());
            if (sampler != 0u)
            {
                compiler.set_decoration(new TypedID_TypeNone(sampler), Spv.Decoration.DecorationDescriptorSet, 0u);
                compiler.set_decoration(new TypedID_TypeNone(sampler), Spv.Decoration.DecorationBinding, 0u);
            }
        }
        ShaderResources res = new ShaderResources();
        if (args.remove_unused)
        {
            var active = compiler.get_active_interface_variables();
            res.CopyFrom(compiler.get_shader_resources(active));
            compiler.set_enabled_interface_variables(active);
        }
        else
        {
            res.CopyFrom(compiler.get_shader_resources());
        }
        if (args.flatten_ubo)
        {
            {
                foreach (Resource ubo in res.uniform_buffers)
                {
                    compiler.flatten_buffer_block(((TypedID_TypeVariable)ubo.id));
                }
            }
            {
                foreach (Resource ubo in res.push_constant_buffers)
                {
                    compiler.flatten_buffer_block(((TypedID_TypeVariable)ubo.id));
                }
            }
        }
        var pls_inputs = Cli.Globals.remap_pls(args.pls_in, res.stage_inputs, res.subpass_inputs);
        var pls_outputs = Cli.Globals.remap_pls(args.pls_out, res.stage_outputs, null);
        compiler.remap_pixel_local_storage(pls_inputs, pls_outputs);
        {
            foreach (CppString ext in args.extensions)
            {
                compiler.require_extension(ext);
            }
        }
        {
            foreach (Cli.Remap remap in args.remaps)
            {
                if (Cli.Globals.remap_generic(compiler, res.stage_inputs, remap))
                {
                    continue;
                }
                if (Cli.Globals.remap_generic(compiler, res.stage_outputs, remap))
                {
                    continue;
                }
                if (Cli.Globals.remap_generic(compiler, res.subpass_inputs, remap))
                {
                    continue;
                }
            }
        }
        {
            foreach (Cli.InterfaceVariableRename rename in args.interface_variable_renames)
            {
                if (unchecked((int)rename.storageClass) == unchecked((int)Spv.StorageClass.StorageClassInput))
                {
                    YotsubaShaderCross.Globals.rename_interface_variable(compiler, res.stage_inputs, rename.location, rename.variable_name);
                }
                else
                if (unchecked((int)rename.storageClass) == unchecked((int)Spv.StorageClass.StorageClassOutput))
                {
                    YotsubaShaderCross.Globals.rename_interface_variable(compiler, res.stage_outputs, rename.location, rename.variable_name);
                }
                else
                {
                    Std.fprintf(Std.stderr, "error at --rename-interface-variable <in|out> ...\n");
                    Std.exit(1);
                }
            }
        }
        if (combined_image_samplers)
        {
            compiler.build_combined_image_samplers();
            if (args.combined_samplers_inherit_bindings)
            {
                YotsubaShaderCross.Globals.inherit_combined_sampler_bindings(compiler);
            }
            {
                foreach (CombinedImageSampler remap in compiler.get_combined_image_samplers())
                {
                    compiler.set_name(new TypedID_TypeNone(remap.combined_id), Std.join("SPIRV_Cross_Combined", compiler.get_name(new TypedID_TypeNone(remap.image_id)), compiler.get_name(new TypedID_TypeNone(remap.sampler_id))));
                }
            }
        }
        if (args.hlsl)
        {
            var hlsl_compiler = (CompilerHLSL)compiler;
            hlsl_compiler.remap_num_workgroups_builtin();
        }
        if (args.hlsl)
        {
            {
                foreach (HLSLVertexAttributeRemap remap in args.hlsl_attr_remap)
                {
                    ((CompilerHLSL)compiler).add_vertex_attribute_remap(remap);
                }
            }
            {
                foreach (Cli.HLSLVertexAttributeRemapNamed named_remap in args.hlsl_attr_remap_named)
                {
                    var itr = Std.find_if(res.stage_inputs.begin(), res.stage_inputs.end(), (Resource input_res) =>
                    {
                        return input_res.name == named_remap.name;
                    });
                    if (itr != res.stage_inputs.end())
                    {
                        HLSLVertexAttributeRemap remap = new HLSLVertexAttributeRemap { location = compiler.get_decoration(itr.deref().id, Spv.Decoration.DecorationLocation), semantic = named_remap.semantic };
                        ((CompilerHLSL)compiler).add_vertex_attribute_remap(remap);
                    }
                }
            }
        }
        var ret = compiler.compile();
        if (args.dump_resources)
        {
            compiler.update_active_builtins();
            Cli.Globals.print_resources(compiler, res);
            Cli.Globals.print_push_constant_resources(compiler, res.push_constant_buffers);
            Cli.Globals.print_spec_constants(compiler);
            Cli.Globals.print_capabilities_and_extensions(compiler);
        }
        return ret;
    }
    public static int main_inner(int argc, Ptr<string> argv)
    {
        Cli.CLIArguments args = new Cli.CLIArguments();
        Cli.CLICallbacks cbs = new Cli.CLICallbacks();
        cbs.add("--help", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help();
            parser.end();
        });
        cbs.add("--help-all", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help_all();
            parser.end();
        });
        cbs.add("--help-backend", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help_backend();
            parser.end();
        });
        cbs.add("--help-common", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help_common();
            parser.end();
        });
        cbs.add("--help-glsl", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help_glsl();
            parser.end();
        });
        cbs.add("--help-msl", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help_msl();
            parser.end();
        });
        cbs.add("--help-hlsl", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help_hlsl();
            parser.end();
        });
        cbs.add("--help-obscure", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_help_obscure();
            parser.end();
        });
        cbs.add("--revision", (Cli.CLIParser parser) =>
        {
            Cli.Globals.print_version();
            parser.end();
        });
        cbs.add("--output", (Cli.CLIParser parser) =>
        {
            args.output = parser.next_string();
        });
        cbs.add("--es", (Cli.CLIParser _p) =>
        {
            args.es = true;
            args.set_es = true;
        });
        cbs.add("--no-es", (Cli.CLIParser _p) =>
        {
            args.es = false;
            args.set_es = true;
        });
        cbs.add("--version", (Cli.CLIParser parser) =>
        {
            args.version = parser.next_uint();
            args.set_version = true;
        });
        cbs.add("--dump-resources", (Cli.CLIParser _p) =>
        {
            args.dump_resources = true;
        });
        cbs.add("--force-temporary", (Cli.CLIParser _p) =>
        {
            args.force_temporary = true;
        });
        cbs.add("--flatten-ubo", (Cli.CLIParser _p) =>
        {
            args.flatten_ubo = true;
        });
        cbs.add("--fixup-clipspace", (Cli.CLIParser _p) =>
        {
            args.fixup = true;
        });
        cbs.add("--flip-vert-y", (Cli.CLIParser _p) =>
        {
            args.yflip = true;
        });
        cbs.add("--iterations", (Cli.CLIParser parser) =>
        {
            args.iterations = parser.next_uint();
        });
        cbs.add("--cpp", (Cli.CLIParser _p) =>
        {
            args.cpp = true;
        });
        cbs.add("--reflect", (Cli.CLIParser parser) =>
        {
            args.reflect = parser.next_value_string("json");
        });
        cbs.add("--cpp-interface-name", (Cli.CLIParser parser) =>
        {
            args.cpp_interface_name = parser.next_string();
        });
        cbs.add("--metal", (Cli.CLIParser _p) =>
        {
            args.msl = true;
        });
        cbs.add("--glsl-emit-push-constant-as-ubo", (Cli.CLIParser _p) =>
        {
            args.glsl_emit_push_constant_as_ubo = true;
        });
        cbs.add("--glsl-emit-ubo-as-plain-uniforms", (Cli.CLIParser _p) =>
        {
            args.glsl_emit_ubo_as_plain_uniforms = true;
        });
        cbs.add("--glsl-force-flattened-io-blocks", (Cli.CLIParser _p) =>
        {
            args.glsl_force_flattened_io_blocks = true;
        });
        cbs.add("--glsl-ovr-multiview-view-count", (Cli.CLIParser parser) =>
        {
            args.glsl_ovr_multiview_view_count = parser.next_uint();
        });
        cbs.add("--glsl-remap-ext-framebuffer-fetch", (Cli.CLIParser parser) =>
        {
            uint input_index = parser.next_uint();
            uint color_attachment = parser.next_uint();
            args.glsl_ext_framebuffer_fetch.push_back(new Pair<uint, uint>(input_index, color_attachment));
        });
        cbs.add("--glsl-ext-framebuffer-fetch-noncoherent", (Cli.CLIParser _p) =>
        {
            args.glsl_ext_framebuffer_fetch_noncoherent = true;
        });
        cbs.add("--glsl-descriptor-heap-set-binding", (Cli.CLIParser parser) =>
        {
            args.glsl_descriptor_heap_set = parser.next_uint();
            args.glsl_descriptor_heap_binding = parser.next_uint();
        });
        cbs.add("--vulkan-glsl-disable-ext-samplerless-texture-functions", (Cli.CLIParser _p) =>
        {
            args.vulkan_glsl_disable_ext_samplerless_texture_functions = true;
        });
        cbs.add("--disable-storage-image-qualifier-deduction", (Cli.CLIParser _p) =>
        {
            args.enable_storage_image_qualifier_deduction = false;
        });
        cbs.add("--force-zero-initialized-variables", (Cli.CLIParser _p) =>
        {
            args.force_zero_initialized_variables = true;
        });
        cbs.add("--msl", (Cli.CLIParser _p) =>
        {
            args.msl = true;
        });
        cbs.add("--hlsl", (Cli.CLIParser _p) =>
        {
            args.hlsl = true;
        });
        cbs.add("--hlsl-enable-compat", (Cli.CLIParser _p) =>
        {
            args.hlsl_compat = true;
        });
        cbs.add("--hlsl-support-nonzero-basevertex-baseinstance", (Cli.CLIParser _p) =>
        {
            args.hlsl_support_nonzero_base = true;
        });
        cbs.add("--hlsl-basevertex-baseinstance-binding", (Cli.CLIParser parser) =>
        {
            args.hlsl_base_vertex_index_explicit_binding = true;
            args.hlsl_base_vertex_index_register_index = parser.next_uint();
            args.hlsl_base_vertex_index_register_space = parser.next_uint();
        });
        cbs.add("--hlsl-auto-binding", (Cli.CLIParser parser) =>
        {
            args.hlsl_binding_flags |= Cli.Globals.hlsl_resource_type_to_flag(new CppString(parser.next_string()));
        });
        cbs.add("--hlsl-force-storage-buffer-as-uav", (Cli.CLIParser _p) =>
        {
            args.hlsl_force_storage_buffer_as_uav = true;
        });
        cbs.add("--hlsl-nonwritable-uav-texture-as-srv", (Cli.CLIParser _p) =>
        {
            args.hlsl_nonwritable_uav_texture_as_srv = true;
        });
        cbs.add("--hlsl-enable-16bit-types", (Cli.CLIParser _p) =>
        {
            args.hlsl_enable_16bit_types = true;
        });
        cbs.add("--hlsl-flatten-matrix-vertex-input-semantics", (Cli.CLIParser _p) =>
        {
            args.hlsl_flatten_matrix_vertex_input_semantics = true;
        });
        cbs.add("--hlsl-preserve-structured-buffers", (Cli.CLIParser _p) =>
        {
            args.hlsl_preserve_structured_buffers = true;
        });
        cbs.add("--hlsl-user-semantic", (Cli.CLIParser _p) =>
        {
            args.hlsl_user_semantic = true;
        });
        cbs.add("--vulkan-semantics", (Cli.CLIParser _p) =>
        {
            args.vulkan_semantics = true;
        });
        cbs.add("-V", (Cli.CLIParser _p) =>
        {
            args.vulkan_semantics = true;
        });
        cbs.add("--flatten-multidimensional-arrays", (Cli.CLIParser _p) =>
        {
            args.flatten_multidimensional_arrays = true;
        });
        cbs.add("--no-420pack-extension", (Cli.CLIParser _p) =>
        {
            args.use_420pack_extension = false;
        });
        cbs.add("--msl-capture-output", (Cli.CLIParser _p) =>
        {
            args.msl_capture_output_to_buffer = true;
        });
        cbs.add("--msl-swizzle-texture-samples", (Cli.CLIParser _p) =>
        {
            args.msl_swizzle_texture_samples = true;
        });
        cbs.add("--msl-ios", (Cli.CLIParser _p) =>
        {
            args.msl_ios = true;
        });
        cbs.add("--msl-pad-fragment-output", (Cli.CLIParser _p) =>
        {
            args.msl_pad_fragment_output = true;
        });
        cbs.add("--msl-domain-lower-left", (Cli.CLIParser _p) =>
        {
            args.msl_domain_lower_left = true;
        });
        cbs.add("--msl-argument-buffers", (Cli.CLIParser _p) =>
        {
            args.msl_argument_buffers = true;
        });
        cbs.add("--msl-argument-buffer-tier", (Cli.CLIParser parser) =>
        {
            args.msl_argument_buffers_tier = parser.next_uint();
        });
        cbs.add("--msl-discrete-descriptor-set", (Cli.CLIParser parser) =>
        {
            args.msl_discrete_descriptor_sets.push_back(parser.next_uint());
        });
        cbs.add("--msl-device-argument-buffer", (Cli.CLIParser parser) =>
        {
            args.msl_device_argument_buffers.push_back(parser.next_uint());
        });
        cbs.add("--msl-texture-buffer-native", (Cli.CLIParser _p) =>
        {
            args.msl_texture_buffer_native = true;
        });
        cbs.add("--msl-framebuffer-fetch", (Cli.CLIParser _p) =>
        {
            args.msl_framebuffer_fetch = true;
        });
        cbs.add("--msl-invariant-float-math", (Cli.CLIParser _p) =>
        {
            args.msl_invariant_float_math = true;
        });
        cbs.add("--msl-emulate-cube-array", (Cli.CLIParser _p) =>
        {
            args.msl_emulate_cube_array = true;
        });
        cbs.add("--msl-multiview", (Cli.CLIParser _p) =>
        {
            args.msl_multiview = true;
        });
        cbs.add("--msl-multiview-no-layered-rendering", (Cli.CLIParser _p) =>
        {
            args.msl_multiview_layered_rendering = false;
        });
        cbs.add("--msl-view-index-from-device-index", (Cli.CLIParser _p) =>
        {
            args.msl_view_index_from_device_index = true;
        });
        cbs.add("--msl-dispatch-base", (Cli.CLIParser _p) =>
        {
            args.msl_dispatch_base = true;
        });
        cbs.add("--msl-dynamic-buffer", (Cli.CLIParser parser) =>
        {
            args.msl_argument_buffers = true;
            uint desc_set = parser.next_uint();
            uint binding = parser.next_uint();
            args.msl_dynamic_buffers.push_back(Std.make_pair(desc_set, binding));
        });
        cbs.add("--msl-decoration-binding", (Cli.CLIParser _p) =>
        {
            args.msl_decoration_binding = true;
        });
        cbs.add("--msl-force-active-argument-buffer-resources", (Cli.CLIParser _p) =>
        {
            args.msl_force_active_argument_buffer_resources = true;
        });
        cbs.add("--msl-inline-uniform-block", (Cli.CLIParser parser) =>
        {
            args.msl_argument_buffers = true;
            uint desc_set = parser.next_uint();
            uint binding = parser.next_uint();
            args.msl_inline_uniform_blocks.push_back(Std.make_pair(desc_set, binding));
        });
        cbs.add("--msl-force-native-arrays", (Cli.CLIParser _p) =>
        {
            args.msl_force_native_arrays = true;
        });
        cbs.add("--msl-disable-frag-depth-builtin", (Cli.CLIParser _p) =>
        {
            args.msl_enable_frag_depth_builtin = false;
        });
        cbs.add("--msl-disable-frag-stencil-ref-builtin", (Cli.CLIParser _p) =>
        {
            args.msl_enable_frag_stencil_ref_builtin = false;
        });
        cbs.add("--msl-enable-frag-output-mask", (Cli.CLIParser parser) =>
        {
            args.msl_enable_frag_output_mask = parser.next_hex_uint();
        });
        cbs.add("--msl-no-clip-distance-user-varying", (Cli.CLIParser _p) =>
        {
            args.msl_enable_clip_distance_user_varying = false;
        });
        cbs.add("--msl-add-shader-input", (Cli.CLIParser parser) =>
        {
            MSLShaderInterfaceVariable input = new MSLShaderInterfaceVariable();
            input.location = parser.next_uint();
            string format = parser.next_value_string("other");
            if (Std.strcmp(format, "any32") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY32;
            }
            else
            if (Std.strcmp(format, "any16") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY16;
            }
            else
            if (Std.strcmp(format, "u16") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT16;
            }
            else
            if (Std.strcmp(format, "u8") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT8;
            }
            else
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_OTHER;
            }
            input.vecsize = parser.next_uint();
            string rate = parser.next_value_string("vertex");
            if (Std.strcmp(rate, "primitive") == 0)
            {
                input.rate = MSLShaderVariableRate.MSL_SHADER_VARIABLE_RATE_PER_PRIMITIVE;
            }
            else
            if (Std.strcmp(rate, "patch") == 0)
            {
                input.rate = MSLShaderVariableRate.MSL_SHADER_VARIABLE_RATE_PER_PATCH;
            }
            else
            {
                input.rate = MSLShaderVariableRate.MSL_SHADER_VARIABLE_RATE_PER_VERTEX;
            }
            args.msl_shader_inputs.push_back(input.Clone());
        });
        cbs.add("--msl-add-shader-output", (Cli.CLIParser parser) =>
        {
            MSLShaderInterfaceVariable output = new MSLShaderInterfaceVariable();
            output.location = parser.next_uint();
            string format = parser.next_value_string("other");
            if (Std.strcmp(format, "any32") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY32;
            }
            else
            if (Std.strcmp(format, "any16") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY16;
            }
            else
            if (Std.strcmp(format, "u16") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT16;
            }
            else
            if (Std.strcmp(format, "u8") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT8;
            }
            else
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_OTHER;
            }
            output.vecsize = parser.next_uint();
            string rate = parser.next_value_string("vertex");
            if (Std.strcmp(rate, "primitive") == 0)
            {
                output.rate = MSLShaderVariableRate.MSL_SHADER_VARIABLE_RATE_PER_PRIMITIVE;
            }
            else
            if (Std.strcmp(rate, "patch") == 0)
            {
                output.rate = MSLShaderVariableRate.MSL_SHADER_VARIABLE_RATE_PER_PATCH;
            }
            else
            {
                output.rate = MSLShaderVariableRate.MSL_SHADER_VARIABLE_RATE_PER_VERTEX;
            }
            args.msl_shader_outputs.push_back(output.Clone());
        });
        cbs.add("--msl-shader-input", (Cli.CLIParser parser) =>
        {
            MSLShaderInterfaceVariable input = new MSLShaderInterfaceVariable();
            input.location = parser.next_uint();
            string format = parser.next_value_string("other");
            if (Std.strcmp(format, "any32") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY32;
            }
            else
            if (Std.strcmp(format, "any16") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY16;
            }
            else
            if (Std.strcmp(format, "u16") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT16;
            }
            else
            if (Std.strcmp(format, "u8") == 0)
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT8;
            }
            else
            {
                input.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_OTHER;
            }
            input.vecsize = parser.next_uint();
            args.msl_shader_inputs.push_back(input.Clone());
        });
        cbs.add("--msl-shader-output", (Cli.CLIParser parser) =>
        {
            MSLShaderInterfaceVariable output = new MSLShaderInterfaceVariable();
            output.location = parser.next_uint();
            string format = parser.next_value_string("other");
            if (Std.strcmp(format, "any32") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY32;
            }
            else
            if (Std.strcmp(format, "any16") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_ANY16;
            }
            else
            if (Std.strcmp(format, "u16") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT16;
            }
            else
            if (Std.strcmp(format, "u8") == 0)
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_UINT8;
            }
            else
            {
                output.format = MSLShaderVariableFormat.MSL_SHADER_VARIABLE_FORMAT_OTHER;
            }
            output.vecsize = parser.next_uint();
            args.msl_shader_outputs.push_back(output.Clone());
        });
        cbs.add("--msl-raw-buffer-tese-input", (Cli.CLIParser _p) =>
        {
            args.msl_raw_buffer_tese_input = true;
        });
        cbs.add("--msl-multi-patch-workgroup", (Cli.CLIParser _p) =>
        {
            args.msl_multi_patch_workgroup = true;
        });
        cbs.add("--msl-vertex-for-tessellation", (Cli.CLIParser _p) =>
        {
            args.msl_vertex_for_tessellation = true;
        });
        cbs.add("--msl-additional-fixed-sample-mask", (Cli.CLIParser parser) =>
        {
            args.msl_additional_fixed_sample_mask = parser.next_hex_uint();
        });
        cbs.add("--msl-arrayed-subpass-input", (Cli.CLIParser _p) =>
        {
            args.msl_arrayed_subpass_input = true;
        });
        cbs.add("--msl-r32ui-linear-texture-align", (Cli.CLIParser parser) =>
        {
            args.msl_r32ui_linear_texture_alignment = parser.next_uint();
        });
        cbs.add("--msl-r32ui-linear-texture-align-constant-id", (Cli.CLIParser parser) =>
        {
            args.msl_r32ui_alignment_constant_id = parser.next_uint();
        });
        cbs.add("--msl-texture-1d-as-2d", (Cli.CLIParser _p) =>
        {
            args.msl_texture_1d_as_2d = true;
        });
        cbs.add("--msl-ios-use-simdgroup-functions", (Cli.CLIParser _p) =>
        {
            args.msl_ios_use_simdgroup_functions = true;
        });
        cbs.add("--msl-emulate-subgroups", (Cli.CLIParser _p) =>
        {
            args.msl_emulate_subgroups = true;
        });
        cbs.add("--msl-fixed-subgroup-size", (Cli.CLIParser parser) =>
        {
            args.msl_fixed_subgroup_size = parser.next_uint();
        });
        cbs.add("--msl-force-sample-rate-shading", (Cli.CLIParser _p) =>
        {
            args.msl_force_sample_rate_shading = true;
        });
        cbs.add("--msl-no-manual-helper-invocation-updates", (Cli.CLIParser _p) =>
        {
            args.msl_manual_helper_invocation_updates = false;
        });
        cbs.add("--msl-check-discarded-frag-stores", (Cli.CLIParser _p) =>
        {
            args.msl_check_discarded_frag_stores = true;
        });
        cbs.add("--msl-force-frag-with-side-effects-execution", (Cli.CLIParser _p) =>
        {
            args.msl_force_fragment_with_side_effects_execution = true;
        });
        cbs.add("--msl-emulate-reversed-depth-viewport", (Cli.CLIParser _p) =>
        {
            args.msl_emulate_reversed_depth_viewport = true;
        });
        cbs.add("--msl-emulate-depth-clip-enable", (Cli.CLIParser _p) =>
        {
            args.msl_emulate_depth_clip_enable = true;
        });
        cbs.add("--msl-sample-dref-lod-array-as-grad", (Cli.CLIParser _p) =>
        {
            args.msl_sample_dref_lod_array_as_grad = true;
        });
        cbs.add("--msl-no-readwrite-texture-fences", (Cli.CLIParser _p) =>
        {
            args.msl_readwrite_texture_fences = false;
        });
        cbs.add("--msl-agx-manual-cube-grad-fixup", (Cli.CLIParser _p) =>
        {
            args.msl_agx_manual_cube_grad_fixup = true;
        });
        cbs.add("--msl-combined-sampler-suffix", (Cli.CLIParser parser) =>
        {
            args.msl_combined_sampler_suffix = parser.next_string();
        });
        cbs.add("--msl-runtime-array-rich-descriptor", (Cli.CLIParser _p) =>
        {
            args.msl_runtime_array_rich_descriptor = true;
        });
        cbs.add("--msl-replace-recursive-inputs", (Cli.CLIParser _p) =>
        {
            args.msl_replace_recursive_inputs = true;
        });
        cbs.add("--msl-input-attachment-is-ds-attachment", (Cli.CLIParser _p) =>
        {
            args.msl_input_attachment_is_ds_attachment = true;
        });
        cbs.add("--msl-disable-rasterization", (Cli.CLIParser _p) =>
        {
            args.msl_disable_rasterization = true;
        });
        cbs.add("--msl-auto-disable-rasterization", (Cli.CLIParser _p) =>
        {
            args.msl_auto_disable_rasterization = true;
        });
        cbs.add("--msl-default-point-size", (Cli.CLIParser parser) =>
        {
            args.msl_enable_point_size_default = true;
            args.msl_default_point_size = unchecked((float)parser.next_double());
        });
        cbs.add("--extension", (Cli.CLIParser parser) =>
        {
            args.extensions.push_back(new CppString(parser.next_string()));
        });
        cbs.add("--rename-entry-point", (Cli.CLIParser parser) =>
        {
            var old_name = parser.next_string();
            var new_name = parser.next_string();
            var model = Cli.Globals.stage_to_execution_model(new CppString(parser.next_string()));
            args.entry_point_rename.push_back(new Cli.CLIArguments.Rename { old_name = new CppString(old_name), new_name = new CppString(new_name), execution_model = model });
        });
        cbs.add("--entry", (Cli.CLIParser parser) =>
        {
            args.entry = parser.next_string();
        });
        cbs.add("--stage", (Cli.CLIParser parser) =>
        {
            args.entry_stage = parser.next_string();
        });
        cbs.add("--separate-shader-objects", (Cli.CLIParser _p) =>
        {
            args.sso = true;
        });
        cbs.add("--set-hlsl-vertex-input-semantic", (Cli.CLIParser parser) =>
        {
            HLSLVertexAttributeRemap remap = new HLSLVertexAttributeRemap();
            remap.location = parser.next_uint();
            remap.semantic = parser.next_string();
            args.hlsl_attr_remap.push_back(remap);
        });
        cbs.add("--set-hlsl-named-vertex-input-semantic", (Cli.CLIParser parser) =>
        {
            Cli.HLSLVertexAttributeRemapNamed remap = new Cli.HLSLVertexAttributeRemapNamed();
            remap.name = parser.next_string();
            remap.semantic = parser.next_string();
            args.hlsl_attr_remap_named.push_back(remap);
        });
        cbs.add("--remap", (Cli.CLIParser parser) =>
        {
            CppString src = new CppString(parser.next_string());
            CppString dst = new CppString(parser.next_string());
            uint components = parser.next_uint();
            args.remaps.push_back(new Cli.Remap { src_name = src, dst_name = dst, components = components });
        });
        cbs.add("--remap-variable-type", (Cli.CLIParser parser) =>
        {
            CppString var_name = new CppString(parser.next_string());
            CppString new_type = new CppString(parser.next_string());
            args.variable_type_remaps.push_back(new Cli.VariableTypeRemap { variable_name = var_name, new_variable_type = new_type });
        });
        cbs.add("--rename-interface-variable", (Cli.CLIParser parser) =>
        {
            Spv.StorageClass cls = Spv.StorageClass.StorageClassMax;
            CppString clsStr = new CppString(parser.next_string());
            if (clsStr == "in")
            {
                cls = Spv.StorageClass.StorageClassInput;
            }
            else
            if (clsStr == "out")
            {
                cls = Spv.StorageClass.StorageClassOutput;
            }
            uint loc = parser.next_uint();
            CppString var_name = new CppString(parser.next_string());
            args.interface_variable_renames.push_back(new Cli.InterfaceVariableRename { storageClass = cls, location = loc, variable_name = var_name });
        });
        cbs.add("--pls-in", (Cli.CLIParser parser) =>
        {
            var fmt = Cli.Globals.pls_format(parser.next_string());
            var name = parser.next_string();
            args.pls_in.push_back(new Cli.PLSArg { format = fmt, name = new CppString(name) });
        });
        cbs.add("--pls-out", (Cli.CLIParser parser) =>
        {
            var fmt = Cli.Globals.pls_format(parser.next_string());
            var name = parser.next_string();
            args.pls_out.push_back(new Cli.PLSArg { format = fmt, name = new CppString(name) });
        });
        cbs.add("--shader-model", (Cli.CLIParser parser) =>
        {
            args.shader_model = parser.next_uint();
            args.set_shader_model = true;
        });
        cbs.add("--msl-version", (Cli.CLIParser parser) =>
        {
            args.msl_version = parser.next_uint();
            args.set_msl_version = true;
        });
        cbs.add("--remove-unused-variables", (Cli.CLIParser _p) =>
        {
            args.remove_unused = true;
        });
        cbs.add("--combined-samplers-inherit-bindings", (Cli.CLIParser _p) =>
        {
            args.combined_samplers_inherit_bindings = true;
        });
        cbs.add("--no-support-nonzero-baseinstance", (Cli.CLIParser _p) =>
        {
            args.support_nonzero_baseinstance = false;
        });
        cbs.add("--emit-line-directives", (Cli.CLIParser _p) =>
        {
            args.emit_line_directives = true;
        });
        cbs.add("--mask-stage-output-location", (Cli.CLIParser parser) =>
        {
            uint location = parser.next_uint();
            uint component = parser.next_uint();
            args.masked_stage_outputs.push_back(new Pair<uint, uint>(location, component));
        });
        cbs.add("--mask-stage-output-builtin", (Cli.CLIParser parser) =>
        {
            Spv.BuiltIn masked_builtin = Spv.BuiltIn.BuiltInMax;
            CppString builtin = new CppString(parser.next_string());
            if (builtin == "Position")
            {
                masked_builtin = Spv.BuiltIn.BuiltInPosition;
            }
            else
            if (builtin == "PointSize")
            {
                masked_builtin = Spv.BuiltIn.BuiltInPointSize;
            }
            else
            if (builtin == "CullDistance")
            {
                masked_builtin = Spv.BuiltIn.BuiltInCullDistance;
            }
            else
            if (builtin == "ClipDistance")
            {
                masked_builtin = Spv.BuiltIn.BuiltInClipDistance;
            }
            else
            {
                Cli.Globals.print_help();
                Std.exit(1);
            }
            args.masked_stage_builtins.push_back(masked_builtin);
        });
        cbs.add("--force-recompile-max-debug-iterations", (Cli.CLIParser parser) =>
        {
            args.force_recompile_max_debug_iterations = parser.next_uint();
        });
        cbs.add("--relax-nan-checks", (Cli.CLIParser _p) =>
        {
            args.relax_nan_checks = true;
        });
        cbs.default_handler = ((string value) =>
        {
            args.input = value;
        });
        cbs.add("-", (Cli.CLIParser _p) =>
        {
            args.input = "-";
        });
        cbs.error_handler = (() =>
        {
            Cli.Globals.print_help();
        });
        Cli.CLIParser parser_1 = new Cli.CLIParser(cbs, argc - 1, argv + 1);
        if (!parser_1.parse())
        {
            return 1;
        }
        else
        if (parser_1.ended_state)
        {
            return 0;
        }
        if (!(args.input != null))
        {
            Std.fprintf(Std.stderr, "Didn't specify input file.\n");
            Cli.Globals.print_help();
            return 1;
        }
        var spirv_file = Cli.Globals.read_spirv_file(args.input);
        if (spirv_file.empty())
        {
            return 1;
        }
        if (!args.reflect.empty())
        {
            Parser spirv_parser = new Parser(spirv_file);
            spirv_parser.parse();
            CompilerReflection compiler = new CompilerReflection(spirv_parser.get_parsed_ir());
            compiler.set_format(args.reflect);
            var json = compiler.compile();
            if (args.output != null)
            {
                Cli.Globals.write_string_to_file(args.output, json.c_str());
            }
            else
            {
                Std.printf("%s", json.c_str());
            }
            return 0;
        }
        CppString compiled_output = default(CppString);
        if (args.iterations == 1u)
        {
            compiled_output = Cli.Globals.compile_iteration(args, spirv_file);
        }
        else
        {
            {
                for (uint i = 0u; i < args.iterations; i++)
                {
                    compiled_output = Cli.Globals.compile_iteration(args, spirv_file.Clone());
                }
            }
        }
        if (args.output != null)
        {
            Cli.Globals.write_string_to_file(args.output, compiled_output.c_str());
        }
        else
        {
            Std.printf("%s", compiled_output.c_str());
        }
        return 0;
    }
    public static int main(int argc, Ptr<string> argv)
    {
        try
        {
            return Cli.Globals.main_inner(argc, argv);
        }
        catch (Exception e)
        {
            Std.fprintf(Std.stderr, "SPIRV-Cross threw an exception: %s\n", e.Message);
            return 1;
        }
    }
}
