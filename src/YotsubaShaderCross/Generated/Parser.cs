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
// Upstream sources: spirv_parser.cpp, spirv_parser.hpp
// Upstream copyright: Copyright 2018-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class Parser
{
    public Parser(Ptr<uint> spirv_data, ulong word_count)
    {
        this.ir = new ParsedIR();
        this.global_struct_cache = new CppVector<uint>();
        this.forward_pointer_fixups = new CppVector<Pair<uint, uint>>();
        ir.spirv.CopyFrom(new CppVector<uint>(spirv_data, spirv_data + word_count));
    }
    public Parser(CppVector<uint> spirv)
    {
        this.ir = new ParsedIR();
        this.global_struct_cache = new CppVector<uint>();
        this.forward_pointer_fixups = new CppVector<Pair<uint, uint>>();
        ir.spirv.CopyFrom(spirv);
    }
    public void parse()
    {
        var spirv = ir.spirv;
        var len = spirv.size();
        if (len < 5UL)
        {
            throw new CompilerError("SPIRV file too small.");
        }
        var s = spirv.data();
        if (s[0] == Globals.swap_endian(Spv.Globals.MagicNumber))
        {
            Std.transform(Std.begin(spirv), Std.end(spirv), Std.begin(spirv), (uint c) =>
            {
                return Globals.swap_endian(c);
            });
        }
        if (s[0] != Spv.Globals.MagicNumber || !Globals.is_valid_spirv_version(s[1]))
        {
            throw new CompilerError("Invalid SPIRV format.");
        }
        uint bound = s[3];
        uint MaximumNumberOfIDs = 4194303u;
        if (bound > MaximumNumberOfIDs)
        {
            throw new CompilerError("ID bound exceeds limit of 0x3fffff.\n");
        }
        ir.set_id_bounds(bound);
        uint offset = 5u;
        CppVector<Instruction> instructions = new CppVector<Instruction>();
        while (unchecked((ulong)offset) < len)
        {
            Instruction instr = new Instruction();
            instr.op = unchecked((ushort)(spirv[unchecked((ulong)offset)] & 65535u));
            instr.count = unchecked((ushort)(spirv[unchecked((ulong)offset)] >> 16 & 65535u));
            if (unchecked((int)instr.count) == 0)
            {
                throw new CompilerError("SPIR-V instructions cannot consume 0 words. Invalid SPIR-V file.");
            }
            instr.offset = offset + 1u;
            instr.length = unchecked((uint)(unchecked((int)instr.count) - 1));
            offset += unchecked((uint)instr.count);
            if (unchecked((ulong)offset) > spirv.size())
            {
                throw new CompilerError("SPIR-V instruction goes out of bounds.");
            }
            instructions.push_back(instr.Clone());
        }
        {
            foreach (Instruction i in instructions)
            {
                parse(i);
            }
        }
        {
            foreach (Pair<uint, uint> fixup in forward_pointer_fixups)
            {
                var target = get__SPIRType(fixup.first);
                var source = get__SPIRType(fixup.second);
                target.member_types.CopyFrom(source.member_types.Clone());
                target.basetype = source.basetype;
                target.self = source.self;
            }
        }
        forward_pointer_fixups.clear();
        {
            foreach (ParsedIR.Source source in ir.sources)
            {
                var cmp = (ParsedIR.Source.Marker a, ParsedIR.Source.Marker b) =>
                {
                    return ((uint)a.line) < ((uint)b.line);
                };
                Std.sort(source.line_markers.begin(), source.line_markers.end(), cmp);
            }
        }
        if (current_function != null)
        {
            throw new CompilerError("Function was not terminated.");
        }
        if (current_block != null)
        {
            throw new CompilerError("Block was not terminated.");
        }
        {
            foreach (uint id in ir.library_exports)
            {
                if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeFunction))
                {
                    ir.library_exported_functions.push_back(new TypedID_TypeFunction(id));
                }
            }
        }
        if (((uint)ir.default_entry_point) == 0u)
        {
            if (ir.library_exported_functions.empty())
            {
                throw new CompilerError("There is no entry point in the SPIR-V module.");
            }
            ir.is_library_module = true;
            ir.default_entry_point = ir.library_exported_functions.front();
            var name = ir.get_name(new TypedID_TypeNone(ir.default_entry_point));
            ir.entry_points.insert(Std.make_pair(ir.default_entry_point, new SPIREntryPoint(ir.default_entry_point, Spv.ExecutionModel.ExecutionModelGLCompute, name)));
        }
    }
    public ParsedIR get_parsed_ir()
    {
        return ir;
    }
    public ParsedIR ir = new ParsedIR();
    public SPIRFunction current_function = null;
    public SPIRBlock current_block = null;
    public bool ignore_trailing_block_opcodes = false;
    public void parse(Instruction instruction)
    {
        var ops = stream(instruction);
        var op = unchecked((Spv.Op)instruction.op);
        uint length = instruction.length;
        if (ignore_trailing_block_opcodes)
        {
            ignore_trailing_block_opcodes = false;
            if (unchecked((int)op) == unchecked((int)Spv.Op.OpReturn) || unchecked((int)op) == unchecked((int)Spv.Op.OpBranch) || unchecked((int)op) == unchecked((int)Spv.Op.OpUnreachable))
            {
                return;
            }
        }
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpSourceExtension):
                case unchecked((int)Spv.Op.OpNop):
                case unchecked((int)Spv.Op.OpModuleProcessed):
                {
                    break;
                }
                case unchecked((int)Spv.Op.OpString):
                {
                    {
                        set__SPIRString_X(ops[0], Globals.extract_string(ir.spirv, instruction.offset + 1u));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpMemoryModel):
                {
                    ir.addressing_model = unchecked((Spv.AddressingModel)ops[0]);
                    ir.memory_model = unchecked((Spv.MemoryModel)ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpSource):
                {
                    {
                        ir.sources.push_back(new ParsedIR.Source());
                        ref var source = ref ir.sources.back();
                        source.lang = unchecked((Spv.SourceLanguage)ops[0]);
                        {
                            switch (unchecked((int)source.lang))
                            {
                                case unchecked((int)Spv.SourceLanguage.SourceLanguageESSL):
                                {
                                    source.es = true;
                                    source.version = ops[1];
                                    source.known = true;
                                    source.hlsl = false;
                                    break;
                                }
                                case unchecked((int)Spv.SourceLanguage.SourceLanguageGLSL):
                                {
                                    source.es = false;
                                    source.version = ops[1];
                                    source.known = true;
                                    source.hlsl = false;
                                    break;
                                }
                                case unchecked((int)Spv.SourceLanguage.SourceLanguageHLSL):
                                {
                                    source.es = false;
                                    source.version = 450u;
                                    source.known = true;
                                    source.hlsl = true;
                                    break;
                                }
                                default:
                                {
                                    source.known = false;
                                    break;
                                }
                            }
                        }
                        if (length >= 3u)
                        {
                            source.file_id = new TypedID_TypeNone(ops[2]);
                        }
                        if (length >= 4u)
                        {
                            source.source = Globals.extract_string(ir.spirv, instruction.offset + 3u);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSourceContinued):
                {
                    if (!ir.sources.empty())
                    {
                        ir.sources.back().source += Globals.extract_string(ir.spirv, instruction.offset);
                    }
                    break;
                }
                case unchecked((int)Spv.Op.OpUndef):
                {
                    {
                        uint result_type = ops[0];
                        uint id = ops[1];
                        set__SPIRUndef_X(id, result_type);
                        if (current_block != null)
                        {
                            current_block.ops.push_back(instruction.Clone());
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpCapability):
                {
                    {
                        uint cap = ops[0];
                        if (cap == unchecked((uint)Spv.Capability.CapabilityKernel))
                        {
                            throw new CompilerError("Kernel capability not supported.");
                        }
                        ir.declared_capabilities.push_back(unchecked((Spv.Capability)ops[0]));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpExtension):
                {
                    {
                        var ext = Globals.extract_string(ir.spirv, instruction.offset);
                        ir.declared_extensions.push_back(ext);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpExtInstImport):
                {
                    {
                        uint id = ops[0];
                        SPIRExtension.Extension spirv_ext = SPIRExtension.Extension.Unsupported;
                        var ext = Globals.extract_string(ir.spirv, instruction.offset + 1u);
                        if (ext == "GLSL.std.450")
                        {
                            spirv_ext = SPIRExtension.Extension.GLSL;
                        }
                        else
                        if (ext == "DebugInfo")
                        {
                            spirv_ext = SPIRExtension.Extension.SPV_debug_info;
                        }
                        else
                        if (ext == "SPV_AMD_shader_ballot")
                        {
                            spirv_ext = SPIRExtension.Extension.SPV_AMD_shader_ballot;
                        }
                        else
                        if (ext == "SPV_AMD_shader_explicit_vertex_parameter")
                        {
                            spirv_ext = SPIRExtension.Extension.SPV_AMD_shader_explicit_vertex_parameter;
                        }
                        else
                        if (ext == "SPV_AMD_shader_trinary_minmax")
                        {
                            spirv_ext = SPIRExtension.Extension.SPV_AMD_shader_trinary_minmax;
                        }
                        else
                        if (ext == "SPV_AMD_gcn_shader")
                        {
                            spirv_ext = SPIRExtension.Extension.SPV_AMD_gcn_shader;
                        }
                        else
                        if (ext == "NonSemantic.DebugPrintf")
                        {
                            spirv_ext = SPIRExtension.Extension.NonSemanticDebugPrintf;
                        }
                        else
                        if (ext.find("NonSemantic.Shader.DebugInfo.", 0UL) == 0UL)
                        {
                            spirv_ext = SPIRExtension.Extension.NonSemanticShaderDebugInfo;
                        }
                        else
                        if (ext.find("NonSemantic.", 0UL) == 0UL)
                        {
                            spirv_ext = SPIRExtension.Extension.NonSemanticGeneric;
                        }
                        set__SPIRExtension_X(id, spirv_ext);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpExtInst):
                case unchecked((int)Spv.Op.OpExtInstWithForwardRefsKHR):
                {
                    {
                        if (current_block != null)
                        {
                            current_block.ops.push_back(instruction.Clone());
                            if (length >= 2u)
                            {
                                var type = maybe_get__SPIRType(ops[0]);
                                if (type != null)
                                {
                                    ir.load_type_width.insert(new Pair<TypedID_TypeNone, uint>(ops[1], type.width));
                                }
                            }
                        }
                        if (unchecked((int)op) == unchecked((int)Spv.Op.OpExtInst) && length > 4u)
                        {
                            var ext = get__SPIRExtension(ops[2]);
                            if (unchecked((int)ext.ext) == unchecked((int)SPIRExtension.Extension.NonSemanticShaderDebugInfo))
                            {
                                var instr = ops[3];
                                if (instr == unchecked((uint)NonSemanticShaderDebugInfo100Instructions.NonSemanticShaderDebugInfo100DebugSource))
                                {
                                    set__SPIRString_X(ops[1], get__SPIRString(ops[4]).str);
                                    ir.sources.push_back(new ParsedIR.Source());
                                    ref var source = ref ir.sources.back();
                                    source.file_id = new TypedID_TypeNone(ops[4]);
                                    source.define_id = new TypedID_TypeNone(ops[1]);
                                    if (length >= 6u)
                                    {
                                        source.source = ir.get__SPIRString(ops[5]).str;
                                    }
                                }
                                else
                                if (instr == unchecked((uint)NonSemanticShaderDebugInfo100Instructions.NonSemanticShaderDebugInfo100DebugSourceContinued))
                                {
                                    if (length < 5u)
                                    {
                                        throw new CompilerError("Invalid arguments for ShaderDebugInfo100DebugSourceContinued");
                                    }
                                    if (!ir.sources.empty())
                                    {
                                        ir.sources.back().source += ir.get__SPIRString(ops[4]).str;
                                    }
                                }
                                else
                                if (instr == unchecked((uint)NonSemanticShaderDebugInfo100Instructions.NonSemanticShaderDebugInfo100DebugLine))
                                {
                                    if (length < 9u)
                                    {
                                        throw new CompilerError("Invalid arguments for ShaderDebugInfo100DebugLine");
                                    }
                                    var source_id = ops[4];
                                    var line_start = ir.get__SPIRConstant(ops[5]).scalar_i32(0u, 0u);
                                    var col_start = ir.get__SPIRConstant(ops[7]).scalar_i32(0u, 0u);
                                    {
                                        foreach (ParsedIR.Source source in ir.sources)
                                        {
                                            if (((uint)source.define_id) != source_id)
                                            {
                                                continue;
                                            }
                                            source.line_markers.push_back(new ParsedIR.Source.Marker());
                                            ref var marker = ref source.line_markers.back();
                                            marker.line = new TypedID_TypeNone(unchecked((uint)line_start));
                                            marker.col = new TypedID_TypeNone(unchecked((uint)col_start));
                                            marker.offset = new TypedID_TypeNone(instruction.offset - 1u);
                                            marker.function_id = current_function != null ? current_function.self : new TypedID_TypeNone(0u);
                                            marker.block_id = current_block != null ? current_block.self : new TypedID_TypeNone(0u);
                                            break;
                                        }
                                    }
                                }
                                else
                                if (instr == unchecked((uint)NonSemanticShaderDebugInfo100Instructions.NonSemanticShaderDebugInfo100DebugLocalVariable))
                                {
                                    if (length < 11u)
                                    {
                                        throw new CompilerError("Invalid arguments for ShaderDebugInfo100DebugLocalVariable");
                                    }
                                    var lvar = set__SPIRDebugLocalVariable_X(ops[1]);
                                    lvar.name_id = ops[4];
                                }
                                else
                                if (instr == unchecked((uint)NonSemanticShaderDebugInfo100Instructions.NonSemanticShaderDebugInfo100DebugDeclare))
                                {
                                    if (length < 7u)
                                    {
                                        throw new CompilerError("Invalid arguments for ShaderDebugInfo100DebugDeclare");
                                    }
                                    var lvar = get__SPIRDebugLocalVariable(ops[4]);
                                    var @var = get__SPIRVariable(ops[5]);
                                    @var.debug_local_variables.push_back(lvar.self);
                                }
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpEntryPoint):
                {
                    {
                        var itr = ir.entry_points.insert(Std.make_pair(ops[1], new SPIREntryPoint(new TypedID_TypeFunction(ops[1]), unchecked((Spv.ExecutionModel)ops[0]), Globals.extract_string(ir.spirv, instruction.offset + 2u))));
                        var e = itr.first.deref().second;
                        uint strlen_words = unchecked((uint)(e.name.size() + 1UL + 3UL >> 2));
                        {
                            for (uint i = strlen_words + 2u; i < instruction.length; i++)
                            {
                                e.interface_variables.push_back(new TypedID_TypeVariable(ops[i]));
                            }
                        }
                        ir.set_name(new TypedID_TypeNone(ops[1]), e.name);
                        if (!(((uint)ir.default_entry_point) != 0u))
                        {
                            ir.default_entry_point = new TypedID_TypeFunction(ops[1]);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpExecutionMode):
                {
                    {
                        ref var execution = ref ir.entry_points[new TypedID_TypeFunction(ops[0])];
                        var mode = unchecked((Spv.ExecutionMode)ops[1]);
                        execution.flags.set(unchecked((uint)mode));
                        {
                            switch (unchecked((int)mode))
                            {
                                case unchecked((int)Spv.ExecutionMode.ExecutionModeInvocations):
                                {
                                    execution.invocations = ops[2];
                                    break;
                                }
                                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSize):
                                {
                                    execution.workgroup_size.x = ops[2];
                                    execution.workgroup_size.y = ops[3];
                                    execution.workgroup_size.z = ops[4];
                                    break;
                                }
                                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputVertices):
                                {
                                    execution.output_vertices = ops[2];
                                    break;
                                }
                                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputPrimitivesEXT):
                                {
                                    execution.output_primitives = ops[2];
                                    break;
                                }
                                case unchecked((int)Spv.ExecutionMode.ExecutionModeSignedZeroInfNanPreserve):
                                {
                                    {
                                        switch (ops[2])
                                        {
                                            case 8u:
                                            {
                                                execution.signed_zero_inf_nan_preserve_8 = true;
                                                break;
                                            }
                                            case 16u:
                                            {
                                                execution.signed_zero_inf_nan_preserve_16 = true;
                                                break;
                                            }
                                            case 32u:
                                            {
                                                execution.signed_zero_inf_nan_preserve_32 = true;
                                                break;
                                            }
                                            case 64u:
                                            {
                                                execution.signed_zero_inf_nan_preserve_64 = true;
                                                break;
                                            }
                                            default:
                                            {
                                                throw new CompilerError("Invalid bit-width for SignedZeroInfNanPreserve.");
                                            }
                                        }
                                    }
                                    break;
                                }
                                default:
                                {
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpExecutionModeId):
                {
                    {
                        ref var execution = ref ir.entry_points[new TypedID_TypeFunction(ops[0])];
                        var mode = unchecked((Spv.ExecutionMode)ops[1]);
                        execution.flags.set(unchecked((uint)mode));
                        {
                            switch (unchecked((int)mode))
                            {
                                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSizeId):
                                {
                                    execution.workgroup_size.id_x = ops[2];
                                    execution.workgroup_size.id_y = ops[3];
                                    execution.workgroup_size.id_z = ops[4];
                                    break;
                                }
                                case unchecked((int)Spv.ExecutionMode.ExecutionModeFPFastMathDefault):
                                {
                                    execution.fp_fast_math_defaults[ops[2]] = ops[3];
                                    break;
                                }
                                default:
                                {
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpName):
                {
                    {
                        uint id = ops[0];
                        ir.set_name(new TypedID_TypeNone(id), Globals.extract_string(ir.spirv, instruction.offset + 1u));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpMemberName):
                {
                    {
                        uint id = ops[0];
                        uint member = ops[1];
                        ir.set_member_name(new TypedID_TypeType(id), member, Globals.extract_string(ir.spirv, instruction.offset + 2u));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpDecorationGroup):
                {
                    {
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupDecorate):
                {
                    {
                        uint group_id = ops[0];
                        ref var decorations = ref ir.meta[new TypedID_TypeNone(group_id)].decoration;
                        var flags = decorations.decoration_flags;
                        {
                            for (uint i = 1u; i < length; i++)
                            {
                                uint target = ops[i];
                                flags.for_each_bit__lambda((uint bit) =>
                                {
                                    var decoration = unchecked((Spv.Decoration)bit);
                                    if (Globals.decoration_is_string(decoration))
                                    {
                                        this.ir.set_decoration_string(new TypedID_TypeNone(target), decoration, this.ir.get_decoration_string(new TypedID_TypeNone(group_id), decoration));
                                    }
                                    else
                                    {
                                        this.ir.meta[new TypedID_TypeNone(target)].decoration_word_offset[unchecked((uint)decoration)] = this.ir.meta[new TypedID_TypeNone(group_id)].decoration_word_offset[unchecked((uint)decoration)];
                                        this.ir.set_decoration(new TypedID_TypeNone(target), decoration, this.ir.get_decoration(new TypedID_TypeNone(group_id), decoration));
                                    }
                                });
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupMemberDecorate):
                {
                    {
                        uint group_id = ops[0];
                        var flags = ir.meta[new TypedID_TypeNone(group_id)].decoration.decoration_flags;
                        {
                            for (uint i = 1u; i + 1u < length; i += 2u)
                            {
                                uint target = ops[i + 0u];
                                uint index = ops[i + 1u];
                                flags.for_each_bit__lambda((uint bit) =>
                                {
                                    var decoration = unchecked((Spv.Decoration)bit);
                                    if (Globals.decoration_is_string(decoration))
                                    {
                                        this.ir.set_member_decoration_string(new TypedID_TypeType(target), index, decoration, this.ir.get_decoration_string(new TypedID_TypeNone(group_id), decoration));
                                    }
                                    else
                                    {
                                        this.ir.set_member_decoration(new TypedID_TypeType(target), index, decoration, this.ir.get_decoration(new TypedID_TypeNone(group_id), decoration));
                                    }
                                });
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpDecorate):
                case unchecked((int)Spv.Op.OpDecorateId):
                {
                    {
                        uint id = ops[0];
                        var decoration = unchecked((Spv.Decoration)ops[1]);
                        if (length >= 3u)
                        {
                            ir.meta[new TypedID_TypeNone(id)].decoration_word_offset[unchecked((uint)decoration)] = unchecked((uint)(ops + 2 - ir.spirv.data()));
                            ir.set_decoration(new TypedID_TypeNone(id), decoration, ops[2]);
                        }
                        else
                        {
                            ir.set_decoration(new TypedID_TypeNone(id), decoration, 0u);
                        }
                        if (unchecked((int)decoration) == unchecked((int)Spv.Decoration.DecorationLinkageAttributes) && length >= 4u && unchecked((int)unchecked((Spv.LinkageType)ops[length - 1u])) == unchecked((int)Spv.LinkageType.LinkageTypeExport))
                        {
                            ir.library_exports.push_back(id);
                            if (ir.get_name(new TypedID_TypeNone(id)).empty())
                            {
                                ir.set_name(new TypedID_TypeNone(id), Globals.extract_string(ir.spirv, instruction.offset + 2u));
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpDecorateStringGOOGLE):
                {
                    {
                        uint id = ops[0];
                        var decoration = unchecked((Spv.Decoration)ops[1]);
                        ir.set_decoration_string(new TypedID_TypeNone(id), decoration, Globals.extract_string(ir.spirv, instruction.offset + 2u));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpMemberDecorate):
                case unchecked((int)Spv.Op.OpMemberDecorateIdEXT):
                {
                    {
                        uint id = ops[0];
                        uint member = ops[1];
                        var decoration = unchecked((Spv.Decoration)ops[2]);
                        if (length >= 4u)
                        {
                            ir.set_member_decoration(new TypedID_TypeType(id), member, decoration, ops[3]);
                        }
                        else
                        {
                            ir.set_member_decoration(new TypedID_TypeType(id), member, decoration, 0u);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpMemberDecorateStringGOOGLE):
                {
                    {
                        uint id = ops[0];
                        uint member = ops[1];
                        var decoration = unchecked((Spv.Decoration)ops[2]);
                        ir.set_member_decoration_string(new TypedID_TypeType(id), member, decoration, Globals.extract_string(ir.spirv, instruction.offset + 3u));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeVoid):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.Void;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeBool):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.Boolean;
                        type.width = 1u;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeFloat):
                {
                    {
                        uint id = ops[0];
                        uint width = ops[1];
                        var type = set__SPIRType_X(id, op);
                        if (width != 16u && width != 8u && length > 2u)
                        {
                            throw new CompilerError("Unrecognized FP encoding mode for OpTypeFloat.");
                        }
                        if (width == 64u)
                        {
                            type.basetype = SPIRType.BaseType.Double;
                        }
                        else
                        if (width == 32u)
                        {
                            type.basetype = SPIRType.BaseType.Float;
                        }
                        else
                        if (width == 16u)
                        {
                            if (length > 2u)
                            {
                                if (ops[2] == unchecked((uint)Spv.FPEncoding.FPEncodingBFloat16KHR))
                                {
                                    type.basetype = SPIRType.BaseType.BFloat16;
                                }
                                else
                                {
                                    throw new CompilerError("Unrecognized encoding for OpTypeFloat 16.");
                                }
                            }
                            else
                            {
                                type.basetype = SPIRType.BaseType.Half;
                            }
                        }
                        else
                        if (width == 8u)
                        {
                            if (length < 2u)
                            {
                                throw new CompilerError("Missing encoding for OpTypeFloat 8.");
                            }
                            else
                            if (ops[2] == unchecked((uint)Spv.FPEncoding.FPEncodingFloat8E4M3EXT))
                            {
                                type.basetype = SPIRType.BaseType.FloatE4M3;
                            }
                            else
                            if (ops[2] == unchecked((uint)Spv.FPEncoding.FPEncodingFloat8E5M2EXT))
                            {
                                type.basetype = SPIRType.BaseType.FloatE5M2;
                            }
                            else
                            {
                                throw new CompilerError("Invalid encoding for OpTypeFloat 8.");
                            }
                        }
                        else
                        {
                            throw new CompilerError("Unrecognized bit-width of floating point type.");
                        }
                        type.width = width;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeInt):
                {
                    {
                        uint id = ops[0];
                        uint width = ops[1];
                        bool signedness = ops[2] != 0u;
                        var type = set__SPIRType_X(id, op);
                        type.basetype = signedness ? Globals.to_signed_basetype(width) : Globals.to_unsigned_basetype(width);
                        type.width = width;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeVector):
                {
                    {
                        uint id = ops[0];
                        uint vecsize = ops[2];
                        var @base = get__SPIRType(ops[1]);
                        var vecbase = set__SPIRType_X(id, @base);
                        vecbase.op = op;
                        vecbase.vecsize = vecsize;
                        vecbase.self = new TypedID_TypeNone(id);
                        vecbase.parent_type = new TypedID_TypeType(ops[1]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeMatrix):
                {
                    {
                        uint id = ops[0];
                        uint colcount = ops[2];
                        var @base = get__SPIRType(ops[1]);
                        var matrixbase = set__SPIRType_X(id, @base);
                        matrixbase.op = op;
                        matrixbase.columns = colcount;
                        matrixbase.self = new TypedID_TypeNone(id);
                        matrixbase.parent_type = new TypedID_TypeType(ops[1]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeCooperativeMatrixKHR):
                {
                    {
                        uint id = ops[0];
                        var @base = get__SPIRType(ops[1]);
                        var matrixbase = set__SPIRType_X(id, @base);
                        matrixbase.op = op;
                        matrixbase.ext.cooperative.scope_id = ops[2];
                        matrixbase.ext.cooperative.rows_id = ops[3];
                        matrixbase.ext.cooperative.columns_id = ops[4];
                        matrixbase.ext.cooperative.use_id = ops[5];
                        matrixbase.self = new TypedID_TypeNone(id);
                        matrixbase.parent_type = new TypedID_TypeType(ops[1]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeCooperativeVectorNV):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.CoopVecNV;
                        type.op = op;
                        type.ext.coopVecNV.component_type_id = ops[1];
                        type.ext.coopVecNV.component_count_id = ops[2];
                        type.parent_type = new TypedID_TypeType(ops[1]);
                        var component_type = (get__SPIRType(type.ext.coopVecNV.component_type_id)).Clone();
                        type.width = component_type.width;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeArray):
                {
                    {
                        uint id = ops[0];
                        uint tid = ops[1];
                        var @base = get__SPIRType(tid);
                        var arraybase = set__SPIRType_X(id, @base);
                        arraybase.op = op;
                        arraybase.parent_type = new TypedID_TypeType(tid);
                        uint cid = ops[2];
                        ir.mark_used_as_array_length(new TypedID_TypeNone(cid));
                        var c = maybe_get__SPIRConstant(cid);
                        bool literal = c != null && !c.specialization;
                        if (@base.forward_pointer)
                        {
                            forward_pointer_fixups.push_back(new Pair<uint, uint>(id, tid));
                        }
                        arraybase.array_size_literal.push_back(literal);
                        arraybase.array.push_back(literal ? c.scalar(0u, 0u) : cid);
                        arraybase.self = @base.self;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeRuntimeArray):
                {
                    {
                        uint id = ops[0];
                        var @base = get__SPIRType(ops[1]);
                        var arraybase = set__SPIRType_X(id, @base);
                        if (@base.forward_pointer)
                        {
                            forward_pointer_fixups.push_back(new Pair<uint, uint>(id, ops[1]));
                        }
                        arraybase.op = op;
                        arraybase.array.push_back(0u);
                        arraybase.array_size_literal.push_back(true);
                        arraybase.parent_type = new TypedID_TypeType(ops[1]);
                        arraybase.self = @base.self;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeImage):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.Image;
                        type.image.type = new TypedID_TypeType(ops[1]);
                        type.image.dim = unchecked((Spv.Dim)ops[2]);
                        type.image.depth = ops[3] == 1u;
                        type.image.arrayed = ops[4] != 0u;
                        type.image.ms = ops[5] != 0u;
                        type.image.sampled = ops[6];
                        type.image.format = unchecked((Spv.ImageFormat)ops[7]);
                        type.image.access = length >= 9u ? unchecked((Spv.AccessQualifier)ops[8]) : Spv.AccessQualifier.AccessQualifierMax;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeSampledImage):
                {
                    {
                        uint id = ops[0];
                        uint imagetype = ops[1];
                        var type = set__SPIRType_X(id, op);
                        type.CopyFrom(get__SPIRType(imagetype));
                        type.basetype = SPIRType.BaseType.SampledImage;
                        type.self = new TypedID_TypeNone(id);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeSampler):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.Sampler;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeUntypedPointerKHR):
                case unchecked((int)Spv.Op.OpTypePointer):
                {
                    {
                        uint id = ops[0];
                        var @base = unchecked((int)op) == unchecked((int)Spv.Op.OpTypePointer) ? maybe_get__SPIRType(ops[2]) : null;
                        var ptrbase = set__SPIRType_X(id, op);
                        if (@base != null)
                        {
                            ptrbase.CopyFrom(@base);
                            ptrbase.op = op;
                        }
                        ptrbase.pointer = true;
                        ptrbase.pointer_depth++;
                        ptrbase.storage = unchecked((Spv.StorageClass)ops[1]);
                        if (unchecked((int)ptrbase.storage) == unchecked((int)Spv.StorageClass.StorageClassAtomicCounter))
                        {
                            ptrbase.basetype = SPIRType.BaseType.AtomicCounter;
                        }
                        if (@base != null && @base.forward_pointer)
                        {
                            forward_pointer_fixups.push_back(new Pair<uint, uint>(id, ops[2]));
                        }
                        if (unchecked((int)op) == unchecked((int)Spv.Op.OpTypePointer))
                        {
                            ptrbase.parent_type = new TypedID_TypeType(ops[2]);
                        }
                        else
                        {
                            ptrbase.basetype = SPIRType.BaseType.Void;
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeForwardPointer):
                {
                    {
                        uint id = ops[0];
                        var ptrbase = set__SPIRType_X(id, op);
                        ptrbase.pointer = true;
                        ptrbase.pointer_depth++;
                        ptrbase.storage = unchecked((Spv.StorageClass)ops[1]);
                        ptrbase.forward_pointer = true;
                        if (unchecked((int)ptrbase.storage) == unchecked((int)Spv.StorageClass.StorageClassAtomicCounter))
                        {
                            ptrbase.basetype = SPIRType.BaseType.AtomicCounter;
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeStruct):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.Struct;
                        {
                            for (uint i = 1u; i < length; i++)
                            {
                                type.member_types.push_back(new TypedID_TypeType(ops[i]));
                            }
                        }
                        bool consider_aliasing = !ir.get_name(type.self).empty();
                        if (consider_aliasing)
                        {
                            {
                                var __r0 = global_struct_cache;
                                for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
                                {
                                    ref uint other = ref __r0[__i1];
                                    if (ir.get_name(type.self) == ir.get_name(new TypedID_TypeNone(other)) && types_are_logically_equivalent(type, get__SPIRType(other)))
                                    {
                                        type.type_alias = new TypedID_TypeType(other);
                                        break;
                                    }
                                }
                            }
                            if (((uint)type.type_alias) == ((uint)new TypedID_TypeType(0u)))
                            {
                                global_struct_cache.push_back(id);
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeFunction):
                {
                    {
                        uint id = ops[0];
                        uint ret = ops[1];
                        var func = set__SPIRFunctionPrototype_X(id, ret);
                        {
                            for (uint i = 2u; i < length; i++)
                            {
                                func.parameter_types.push_back(ops[i]);
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeAccelerationStructureKHR):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.AccelerationStructure;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeRayQueryKHR):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.RayQuery;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeTensorARM):
                {
                    {
                        uint id = ops[0];
                        var type = set__SPIRType_X(id, op);
                        type.basetype = SPIRType.BaseType.Tensor;
                        type.ext.tensor.CopyFrom(new SPIRType.ext_t.tensor_t());
                        type.ext.tensor.type = ops[1];
                        if (length >= 3u)
                        {
                            type.ext.tensor.rank = ops[2];
                        }
                        if (length >= 4u)
                        {
                            type.ext.tensor.shape = ops[3];
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpVariable):
                {
                    {
                        uint type = ops[0];
                        uint id = ops[1];
                        var storage = unchecked((Spv.StorageClass)ops[2]);
                        uint initializer = length == 4u ? ops[3] : 0u;
                        if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassFunction))
                        {
                            if (!(current_function != null))
                            {
                                throw new CompilerError("No function currently in scope");
                            }
                            current_function.add_local_variable(new TypedID_TypeVariable(id));
                        }
                        set__SPIRVariable_X(id, type, storage, initializer);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpUntypedVariableKHR):
                {
                    {
                        uint type = ops[0];
                        uint id = ops[1];
                        var storage = unchecked((Spv.StorageClass)ops[2]);
                        uint data_type = length >= 4u ? ops[3] : 0u;
                        uint initializer = length >= 5u ? ops[4] : 0u;
                        if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassFunction))
                        {
                            if (!(current_function != null))
                            {
                                throw new CompilerError("No function currently in scope");
                            }
                            current_function.add_local_variable(new TypedID_TypeVariable(id));
                        }
                        var v = set__SPIRVariable_X(id, type, storage, initializer);
                        v.untyped = true;
                        v.untyped_alloca_type = new TypedID_TypeNone(data_type);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpPhi):
                {
                    {
                        if (!(current_function != null))
                        {
                            throw new CompilerError("No function currently in scope");
                        }
                        if (!(current_block != null))
                        {
                            throw new CompilerError("No block currently in scope");
                        }
                        uint result_type = ops[0];
                        uint id = ops[1];
                        var @var = set__SPIRVariable_X(id, result_type, Spv.StorageClass.StorageClassFunction);
                        @var.phi_variable = true;
                        current_function.add_local_variable(new TypedID_TypeVariable(id));
                        {
                            for (uint i = 2u; i + 2u <= length; i += 2u)
                            {
                                current_block.phi_variables.push_back(new SPIRBlock.Phi { local_variable = new TypedID_TypeNone(ops[i]), parent = new TypedID_TypeBlock(ops[i + 1u]), function_variable = new TypedID_TypeVariable(id) });
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSpecConstant):
                case unchecked((int)Spv.Op.OpConstant):
                case unchecked((int)Spv.Op.OpConstantCompositeReplicateEXT):
                case unchecked((int)Spv.Op.OpSpecConstantCompositeReplicateEXT):
                {
                    {
                        uint id = ops[1];
                        var type = get__SPIRType(ops[0]);
                        if (unchecked((int)op) == unchecked((int)Spv.Op.OpConstantCompositeReplicateEXT) || unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstantCompositeReplicateEXT))
                        {
                            var subconstant = ops[2];
                            set__SPIRConstant_X(id, ops[0], Ptr.Ref<uint>(() => subconstant, __v => subconstant = __v), 1, unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstantCompositeReplicateEXT), true);
                        }
                        else
                        {
                            if (type.width > 32u)
                            {
                                set__SPIRConstant_X(id, ops[0], unchecked((ulong)ops[2]) | unchecked((ulong)ops[3]) << 32, unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstant));
                            }
                            else
                            {
                                set__SPIRConstant_X(id, ops[0], ops[2], unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstant));
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSpecConstantFalse):
                case unchecked((int)Spv.Op.OpConstantFalse):
                {
                    {
                        uint id = ops[1];
                        set__SPIRConstant_X(id, ops[0], 0u, unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstantFalse));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSpecConstantTrue):
                case unchecked((int)Spv.Op.OpConstantTrue):
                {
                    {
                        uint id = ops[1];
                        set__SPIRConstant_X(id, ops[0], 1u, unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstantTrue));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpConstantNull):
                {
                    {
                        uint id = ops[1];
                        uint type = ops[0];
                        ir.make_constant_null(id, type, true);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSpecConstantComposite):
                case unchecked((int)Spv.Op.OpConstantComposite):
                {
                    {
                        uint id = ops[1];
                        uint type = ops[0];
                        var ctype = get__SPIRType(type);
                        uint elements = length - 2u;
                        if (unchecked((int)ctype.basetype) == unchecked((int)SPIRType.BaseType.Struct) || !ctype.array.empty() || elements > 4u)
                        {
                            set__SPIRConstant_X(id, type, ops + 2, length - 2u, unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstantComposite));
                        }
                        else
                        {
                            SPIRConstant[] remapped_constant_ops = Std.new_array<SPIRConstant>(4);
                            SPIRConstant[] c = new SPIRConstant[4];
                            {
                                for (uint i = 0u; i < elements; i++)
                                {
                                    var constant_op = maybe_get__SPIRConstantOp(ops[2u + i]);
                                    var undef_op = maybe_get__SPIRUndef(ops[2u + i]);
                                    if (constant_op != null)
                                    {
                                        if (unchecked((int)op) == unchecked((int)Spv.Op.OpConstantComposite))
                                        {
                                            throw new CompilerError("Specialization constant operation used in OpConstantComposite.");
                                        }
                                        remapped_constant_ops[i].make_null(get__SPIRType(((uint)constant_op.basetype)));
                                        remapped_constant_ops[i].self = constant_op.self;
                                        remapped_constant_ops[i].constant_type = constant_op.basetype;
                                        remapped_constant_ops[i].specialization = true;
                                        c[i] = remapped_constant_ops[i];
                                    }
                                    else
                                    if (undef_op != null)
                                    {
                                        remapped_constant_ops[i].make_null(get__SPIRType(((uint)undef_op.basetype)));
                                        remapped_constant_ops[i].constant_type = undef_op.basetype;
                                        c[i] = remapped_constant_ops[i];
                                    }
                                    else
                                    {
                                        c[i] = get__SPIRConstant(ops[2u + i]);
                                    }
                                }
                            }
                            set__SPIRConstant_X(id, type, c, elements, unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstantComposite));
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpConstantSizeOfEXT):
                {
                    {
                        uint id = ops[1];
                        uint type = ops[0];
                        var c = set__SPIRConstant_X(id, type);
                        c.size_of_type = new TypedID_TypeNone(ops[2]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpConstantDataKHR):
                case unchecked((int)Spv.Op.OpSpecConstantDataKHR):
                {
                    {
                        uint id = ops[1];
                        uint type = ops[0];
                        set__SPIRConstantData_X(id, type, ops + 2, length - 2u, unchecked((int)op) == unchecked((int)Spv.Op.OpSpecConstantDataKHR));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTypeBufferEXT):
                {
                    {
                        uint type = ops[0];
                        var t = set__SPIRType_X(type, Spv.Op.OpTypeBufferEXT);
                        t.basetype = SPIRType.BaseType.DescriptorHeapBuffer;
                        t.ext.descriptor_heap_buffer.storage = unchecked((Spv.StorageClass)ops[1]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFunction):
                {
                    {
                        uint res = ops[0];
                        uint id = ops[1];
                        uint control = ops[2];
                        uint type = ops[3];
                        if (current_function != null)
                        {
                            throw new CompilerError("Must end a function before starting a new one!");
                        }
                        current_function = set__SPIRFunction_X(id, res, control, type);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFunctionParameter):
                {
                    {
                        uint type = ops[0];
                        uint id = ops[1];
                        if (!(current_function != null))
                        {
                            throw new CompilerError("Must be in a function!");
                        }
                        current_function.add_parameter(new TypedID_TypeType(type), new TypedID_TypeNone(id), false);
                        set__SPIRVariable_X(id, type, Spv.StorageClass.StorageClassFunction);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFunctionEnd):
                {
                    {
                        if (current_block != null)
                        {
                            throw new CompilerError("Cannot end a function before ending the current block.\nLikely cause: If this SPIR-V was created from glslang HLSL, make sure the entry point is valid.");
                        }
                        current_function = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpLabel):
                {
                    {
                        if (!(current_function != null))
                        {
                            throw new CompilerError("Blocks cannot exist outside functions!");
                        }
                        uint id = ops[0];
                        current_function.blocks.push_back(new TypedID_TypeBlock(id));
                        if (!(((uint)current_function.entry_block) != 0u))
                        {
                            current_function.entry_block = new TypedID_TypeBlock(id);
                        }
                        if (current_block != null)
                        {
                            throw new CompilerError("Cannot start a block before ending the current block.");
                        }
                        current_block = set__SPIRBlock_X(id);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpBranch):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to end a non-existing block.");
                        }
                        uint target = ops[0];
                        current_block.terminator = SPIRBlock.Terminator.Direct;
                        current_block.next_block = new TypedID_TypeBlock(target);
                        current_block = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpBranchConditional):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to end a non-existing block.");
                        }
                        current_block.condition = new TypedID_TypeNone(ops[0]);
                        current_block.true_block = new TypedID_TypeBlock(ops[1]);
                        current_block.false_block = new TypedID_TypeBlock(ops[2]);
                        current_block.terminator = SPIRBlock.Terminator.Select;
                        if (((uint)current_block.true_block) == ((uint)current_block.false_block))
                        {
                            if (((uint)current_block.true_block) != ((uint)current_block.next_block) && unchecked((int)current_block.merge) == unchecked((int)SPIRBlock.Merge.MergeSelection))
                            {
                                uint ids = ir.increase_bound_by(2u);
                                var type = set__SPIRType_X(ids, Spv.Op.OpTypeInt);
                                type.basetype = SPIRType.BaseType.Int;
                                type.width = 32u;
                                var c = set__SPIRConstant_X(ids + 1u, ids);
                                current_block.condition = c.self;
                                current_block.default_block = current_block.true_block;
                                current_block.terminator = SPIRBlock.Terminator.MultiSelect;
                                ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] & ~unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_SELECTION_MERGE_BIT)));
                                ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_MULTISELECT_MERGE_BIT)));
                            }
                            else
                            {
                                bool collapsed_loop = ((uint)current_block.true_block) == ((uint)current_block.merge_block) && unchecked((int)current_block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop);
                                if (collapsed_loop)
                                {
                                    ir.block_meta[unchecked((ulong)((uint)current_block.merge_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.merge_block))] & ~unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_LOOP_MERGE_BIT)));
                                    ir.block_meta[unchecked((ulong)((uint)current_block.continue_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.continue_block))] & ~unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_CONTINUE_BIT)));
                                }
                                current_block.next_block = current_block.true_block;
                                current_block.condition = new TypedID_TypeNone(0u);
                                current_block.true_block = new TypedID_TypeBlock(0u);
                                current_block.false_block = new TypedID_TypeBlock(0u);
                                current_block.merge_block = new TypedID_TypeBlock(0u);
                                current_block.merge = SPIRBlock.Merge.MergeNone;
                                current_block.terminator = SPIRBlock.Terminator.Direct;
                            }
                        }
                        current_block = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSwitch):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to end a non-existing block.");
                        }
                        current_block.terminator = SPIRBlock.Terminator.MultiSelect;
                        current_block.condition = new TypedID_TypeNone(ops[0]);
                        current_block.default_block = new TypedID_TypeBlock(ops[1]);
                        uint remaining_ops = length - 2u;
                        if (remaining_ops % 2u == 0u)
                        {
                            {
                                for (uint i = 2u; i + 2u <= length; i += 2u)
                                {
                                    current_block.cases_32bit.push_back(new SPIRBlock.Case { value = unchecked((ulong)ops[i]), block = new TypedID_TypeBlock(ops[i + 1u]) });
                                }
                            }
                        }
                        if (remaining_ops % 3u == 0u)
                        {
                            {
                                for (uint i = 2u; i + 3u <= length; i += 3u)
                                {
                                    ulong value = unchecked((ulong)ops[i + 1u]) << 32 | unchecked((ulong)ops[i]);
                                    current_block.cases_64bit.push_back(new SPIRBlock.Case { value = value, block = new TypedID_TypeBlock(ops[i + 2u]) });
                                }
                            }
                        }
                        ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_MULTISELECT_MERGE_BIT)));
                        current_block = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpKill):
                case unchecked((int)Spv.Op.OpTerminateInvocation):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to end a non-existing block.");
                        }
                        current_block.terminator = SPIRBlock.Terminator.Kill;
                        current_block = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpTerminateRayKHR):
                {
                    if (!(current_block != null))
                    {
                        throw new CompilerError("Trying to end a non-existing block.");
                    }
                    current_block.terminator = SPIRBlock.Terminator.TerminateRay;
                    current_block = null;
                    break;
                }
                case unchecked((int)Spv.Op.OpIgnoreIntersectionKHR):
                {
                    if (!(current_block != null))
                    {
                        throw new CompilerError("Trying to end a non-existing block.");
                    }
                    current_block.terminator = SPIRBlock.Terminator.IgnoreIntersection;
                    current_block = null;
                    break;
                }
                case unchecked((int)Spv.Op.OpEmitMeshTasksEXT):
                {
                    if (!(current_block != null))
                    {
                        throw new CompilerError("Trying to end a non-existing block.");
                    }
                    current_block.terminator = SPIRBlock.Terminator.EmitMeshTasks;
                    {
                        for (uint i = 0u; i < 3u; i++)
                        {
                            current_block.mesh.groups[i] = new TypedID_TypeNone(ops[i]);
                        }
                    }
                    current_block.mesh.payload = new TypedID_TypeNone(length >= 4u ? ops[3] : 0u);
                    current_block = null;
                    ignore_trailing_block_opcodes = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAbortKHR):
                {
                    if (!(current_block != null))
                    {
                        throw new CompilerError("Trying to end a non-existing block.");
                    }
                    current_block.terminator = SPIRBlock.Terminator.ShaderAbort;
                    current_block.shader_abort.physical_type = new TypedID_TypeType(ops[0]);
                    current_block.shader_abort.payload = new TypedID_TypeNone(ops[1]);
                    current_block = null;
                    break;
                }
                case unchecked((int)Spv.Op.OpReturn):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to end a non-existing block.");
                        }
                        current_block.terminator = SPIRBlock.Terminator.Return;
                        current_block = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpReturnValue):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to end a non-existing block.");
                        }
                        current_block.terminator = SPIRBlock.Terminator.Return;
                        current_block.return_value = new TypedID_TypeNone(ops[0]);
                        current_block = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpUnreachable):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to end a non-existing block.");
                        }
                        current_block.terminator = SPIRBlock.Terminator.Unreachable;
                        current_block = null;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSelectionMerge):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to modify a non-existing block.");
                        }
                        current_block.next_block = new TypedID_TypeBlock(ops[0]);
                        current_block.merge = SPIRBlock.Merge.MergeSelection;
                        ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.next_block))] | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_SELECTION_MERGE_BIT)));
                        if (length >= 2u)
                        {
                            if ((ops[1] & unchecked((uint)Spv.SelectionControlMask.SelectionControlFlattenMask)) != 0u)
                            {
                                current_block.hint = SPIRBlock.Hints.HintFlatten;
                            }
                            else
                            if ((ops[1] & unchecked((uint)Spv.SelectionControlMask.SelectionControlDontFlattenMask)) != 0u)
                            {
                                current_block.hint = SPIRBlock.Hints.HintDontFlatten;
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpLoopMerge):
                {
                    {
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Trying to modify a non-existing block.");
                        }
                        current_block.merge_block = new TypedID_TypeBlock(ops[0]);
                        current_block.continue_block = new TypedID_TypeBlock(ops[1]);
                        current_block.merge = SPIRBlock.Merge.MergeLoop;
                        ir.block_meta[unchecked((ulong)((uint)current_block.self))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.self))] | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_LOOP_HEADER_BIT)));
                        ir.block_meta[unchecked((ulong)((uint)current_block.merge_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.merge_block))] | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_LOOP_MERGE_BIT)));
                        ir.continue_block_to_loop_header[current_block.continue_block] = new TypedID_TypeBlock(current_block.self);
                        if (((uint)current_block.continue_block) != ((uint)new TypedID_TypeBlock(current_block.self)))
                        {
                            ir.block_meta[unchecked((ulong)((uint)current_block.continue_block))] = unchecked((byte)(ir.block_meta[unchecked((ulong)((uint)current_block.continue_block))] | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_CONTINUE_BIT)));
                        }
                        if (length >= 3u)
                        {
                            if ((ops[2] & unchecked((uint)Spv.LoopControlMask.LoopControlUnrollMask)) != 0u)
                            {
                                current_block.hint = SPIRBlock.Hints.HintUnroll;
                            }
                            else
                            if ((ops[2] & unchecked((uint)Spv.LoopControlMask.LoopControlDontUnrollMask)) != 0u)
                            {
                                current_block.hint = SPIRBlock.Hints.HintDontUnroll;
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSpecConstantOp):
                {
                    {
                        if (length < 3u)
                        {
                            throw new CompilerError("OpSpecConstantOp not enough arguments.");
                        }
                        uint result_type = ops[0];
                        uint id = ops[1];
                        var spec_op = unchecked((Spv.Op)ops[2]);
                        set__SPIRConstantOp_X(id, result_type, spec_op, ops + 3, length - 3u);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpLine):
                {
                    {
                        if (current_block != null)
                        {
                            current_block.ops.push_back(instruction.Clone());
                        }
                        if (current_function != null)
                        {
                            if (current_function.entry_line.file_id == 0u)
                            {
                                current_function.entry_line.file_id = ops[0];
                                current_function.entry_line.line_literal = ops[1];
                            }
                        }
                        uint file = ops[0];
                        uint line = ops[1];
                        {
                            foreach (ParsedIR.Source source in ir.sources)
                            {
                                if (((uint)source.file_id) == file)
                                {
                                    source.line_markers.push_back(new ParsedIR.Source.Marker());
                                    ref var marker = ref source.line_markers.back();
                                    marker.line = new TypedID_TypeNone(line);
                                    marker.offset = new TypedID_TypeNone(instruction.offset - 1u);
                                    marker.function_id = current_function != null ? current_function.self : new TypedID_TypeNone(0u);
                                    marker.block_id = current_block != null ? current_block.self : new TypedID_TypeNone(0u);
                                    break;
                                }
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpNoLine):
                {
                    {
                        if (current_block != null)
                        {
                            current_block.ops.push_back(instruction.Clone());
                        }
                        break;
                    }
                }
                default:
                {
                    {
                        if (length >= 2u)
                        {
                            var type = maybe_get__SPIRType(ops[0]);
                            if (type != null)
                            {
                                ir.load_type_width.insert(new Pair<TypedID_TypeNone, uint>(ops[1], type.width));
                            }
                        }
                        if (!(current_block != null))
                        {
                            throw new CompilerError("Currently no block to insert opcode.");
                        }
                        current_block.ops.push_back(instruction.Clone());
                        break;
                    }
                }
            }
        }
    }
    public Ptr<uint> stream(Instruction instr)
    {
        if (!(instr.length != 0u))
        {
            return null;
        }
        if (unchecked((ulong)(instr.offset + instr.length)) > ir.spirv.size())
        {
            throw new CompilerError("Compiler::stream() out of range.");
        }
        return ir.spirv.ptr_at(unchecked((ulong)instr.offset));
    }
    public CppVector<uint> global_struct_cache = new CppVector<uint>();
    public CppVector<Pair<uint, uint>> forward_pointer_fixups = new CppVector<Pair<uint, uint>>();
    public bool types_are_logically_equivalent(SPIRType a, SPIRType b)
    {
        if (unchecked((int)a.basetype) != unchecked((int)b.basetype))
        {
            return false;
        }
        if (a.width != b.width)
        {
            return false;
        }
        if (a.vecsize != b.vecsize)
        {
            return false;
        }
        if (a.columns != b.columns)
        {
            return false;
        }
        if (a.array.size() != b.array.size())
        {
            return false;
        }
        ulong array_count = a.array.size();
        if (array_count != 0UL && Std.memcmp(a.array.data(), b.array.data(), array_count * 4) != 0)
        {
            return false;
        }
        if (unchecked((int)a.basetype) == unchecked((int)SPIRType.BaseType.Image) || unchecked((int)a.basetype) == unchecked((int)SPIRType.BaseType.SampledImage))
        {
            if (Std.memcmp(a.image, b.image, Std.sizeof_expr(SPIRType.BaseType.Image)) != 0)
            {
                return false;
            }
        }
        if (a.member_types.size() != b.member_types.size())
        {
            return false;
        }
        ulong member_types = a.member_types.size();
        {
            for (ulong i = 0UL; i < member_types; i++)
            {
                if (!types_are_logically_equivalent(get__SPIRType(((uint)a.member_types[i])), get__SPIRType(((uint)b.member_types[i]))))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public bool variable_storage_is_aliased(SPIRVariable v)
    {
        var type = get__SPIRType(((uint)v.basetype));
        var type_meta = ir.find_meta(type.self);
        bool ssbo = unchecked((int)v.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || type_meta != null && type_meta.decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBufferBlock));
        bool image = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image);
        bool counter = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.AtomicCounter);
        bool is_restrict = default;
        if (ssbo)
        {
            is_restrict = ir.get_buffer_block_flags(v).get(unchecked((uint)Spv.Decoration.DecorationRestrict));
        }
        else
        {
            is_restrict = ir.has_decoration(v.self, Spv.Decoration.DecorationRestrict);
        }
        return !is_restrict && (ssbo || image || counter);
    }
    public SPIRString set__SPIRString_X(uint id, CppString args)
    {
        ir.add_typed_id(unchecked((Types)SPIRString.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRString_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRUndef set__SPIRUndef_X(uint id, uint args)
    {
        ir.add_typed_id(unchecked((Types)SPIRUndef.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRUndef_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRExtension set__SPIRExtension_X(uint id, SPIRExtension.Extension args)
    {
        ir.add_typed_id(unchecked((Types)SPIRExtension.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRExtension_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRDebugLocalVariable set__SPIRDebugLocalVariable_X(uint id)
    {
        ir.add_typed_id(unchecked((Types)SPIRDebugLocalVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRDebugLocalVariable_X(ir.ids[unchecked((ulong)id)]);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRType set__SPIRType_X(uint id, Spv.Op args)
    {
        ir.add_typed_id(unchecked((Types)SPIRType.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRType_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRType set__SPIRType_X(uint id, SPIRType args)
    {
        ir.add_typed_id(unchecked((Types)SPIRType.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRType_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRFunctionPrototype set__SPIRFunctionPrototype_X(uint id, uint args)
    {
        ir.add_typed_id(unchecked((Types)SPIRFunctionPrototype.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRFunctionPrototype_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRVariable set__SPIRVariable_X(uint id, uint args, Spv.StorageClass args_1, uint args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRVariable_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRVariable set__SPIRVariable_X(uint id, uint args, Spv.StorageClass args_1)
    {
        ir.add_typed_id(unchecked((Types)SPIRVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRVariable_X(ir.ids[unchecked((ulong)id)], args, args_1);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, Ptr<uint> args_1, int args_2, bool args_3, bool args_4)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3, args_4);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, ulong args_1, bool args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, uint args_1, bool args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, Ptr<uint> args_1, uint args_2, bool args_3)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, SPIRConstant[] args_1, uint args_2, bool args_3)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstantData set__SPIRConstantData_X(uint id, uint args, Ptr<uint> args_1, uint args_2, bool args_3)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstantData.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstantData_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRFunction set__SPIRFunction_X(uint id, uint args, uint args_1, uint args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRFunction.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRFunction_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRBlock set__SPIRBlock_X(uint id)
    {
        ir.add_typed_id(unchecked((Types)SPIRBlock.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRBlock_X(ir.ids[unchecked((ulong)id)]);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRConstantOp set__SPIRConstantOp_X(uint id, uint args, Spv.Op args_1, Ptr<uint> args_2, uint args_3)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstantOp.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstantOp_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3);
        @var.self = new TypedID_TypeNone(id);
        return @var;
    }
    public SPIRType get__SPIRType(uint id)
    {
        return Globals.variant_get__SPIRType(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRExtension get__SPIRExtension(uint id)
    {
        return Globals.variant_get__SPIRExtension(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRString get__SPIRString(uint id)
    {
        return Globals.variant_get__SPIRString(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRDebugLocalVariable get__SPIRDebugLocalVariable(uint id)
    {
        return Globals.variant_get__SPIRDebugLocalVariable(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRVariable get__SPIRVariable(uint id)
    {
        return Globals.variant_get__SPIRVariable(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRConstant get__SPIRConstant(uint id)
    {
        return Globals.variant_get__SPIRConstant(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRConstantOp get__SPIRConstantOp(uint id)
    {
        return Globals.variant_get__SPIRConstantOp(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRUndef get__SPIRUndef(uint id)
    {
        return Globals.variant_get__SPIRUndef(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRType maybe_get__SPIRType(uint id)
    {
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRType.type)))
        {
            return get__SPIRType(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRConstant maybe_get__SPIRConstant(uint id)
    {
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRConstant.type)))
        {
            return get__SPIRConstant(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRConstantOp maybe_get__SPIRConstantOp(uint id)
    {
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRConstantOp.type)))
        {
            return get__SPIRConstantOp(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRUndef maybe_get__SPIRUndef(uint id)
    {
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRUndef.type)))
        {
            return get__SPIRUndef(id);
        }
        else
        {
            return null;
        }
    }

    protected virtual void FixClone()
    {
        this.ir = this.ir.Clone();
        this.global_struct_cache = this.global_struct_cache.Clone();
        this.forward_pointer_fixups = this.forward_pointer_fixups.Clone(__e => __e.Clone());
    }

    public Parser Clone()
    {
        var __c = (Parser)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(Parser o)
    {
        this.ir = o.ir.Clone();
        this.current_function = o.current_function;
        this.current_block = o.current_block;
        this.ignore_trailing_block_opcodes = o.ignore_trailing_block_opcodes;
        this.global_struct_cache = o.global_struct_cache.Clone();
        this.forward_pointer_fixups = o.forward_pointer_fixups.Clone(__e => __e.Clone());
    }
}
