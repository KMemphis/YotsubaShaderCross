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
// Upstream sources: spirv_cross_parsed_ir.cpp, spirv_cross_parsed_ir.hpp
// Upstream copyright: Copyright 2018-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class ParsedIR
{
    public ObjectPoolGroup pool_group;
    public ParsedIR()
    {
        this.pool_group = null;
        this.spirv = new CppVector<uint>();
        this.ids = new CppVector<Variant>();
        this.meta = new UnorderedMap<TypedID_TypeNone, Meta>();
        this.ids_for_type = Std.new_array<CppVector<TypedID_TypeNone>>(16);
        this.ids_for_constant_undef_or_type = new CppVector<TypedID_TypeNone>();
        this.ids_for_constant_or_variable = new CppVector<TypedID_TypeNone>();
        this.load_type_width = new UnorderedMap<TypedID_TypeNone, uint>();
        this.declared_capabilities = new CppVector<Spv.Capability>();
        this.declared_extensions = new CppVector<CppString>();
        this.block_meta = new CppVector<byte>();
        this.continue_block_to_loop_header = new UnorderedMap<TypedID_TypeBlock, TypedID_TypeBlock>();
        this.entry_points = new UnorderedMap<TypedID_TypeFunction, SPIREntryPoint>();
        this.library_exports = new CppVector<uint>();
        this.library_exported_functions = new CppVector<TypedID_TypeFunction>();
        this.sources = new CppVector<ParsedIR.Source>();
        this.empty_string = default(CppString);
        this.cleared_bitset = new Bitset();
        this.meta_needing_name_fixup = new UnorderedSet<uint>();
        pool_group = new ObjectPoolGroup();
        pool_group.pools[(int)Types.TypeType] = new ObjectPool<SPIRType>(16u);
        pool_group.pools[(int)Types.TypeVariable] = new ObjectPool<SPIRVariable>(16u);
        pool_group.pools[(int)Types.TypeConstant] = new ObjectPool<SPIRConstant>(16u);
        pool_group.pools[(int)Types.TypeFunction] = new ObjectPool<SPIRFunction>(16u);
        pool_group.pools[(int)Types.TypeFunctionPrototype] = new ObjectPool<SPIRFunctionPrototype>(16u);
        pool_group.pools[(int)Types.TypeBlock] = new ObjectPool<SPIRBlock>(16u);
        pool_group.pools[(int)Types.TypeExtension] = new ObjectPool<SPIRExtension>(16u);
        pool_group.pools[(int)Types.TypeExpression] = new ObjectPool<SPIRExpression>(16u);
        pool_group.pools[(int)Types.TypeConstantOp] = new ObjectPool<SPIRConstantOp>(16u);
        pool_group.pools[(int)Types.TypeCombinedImageSampler] = new ObjectPool<SPIRCombinedImageSampler>(16u);
        pool_group.pools[(int)Types.TypeAccessChain] = new ObjectPool<SPIRAccessChain>(16u);
        pool_group.pools[(int)Types.TypeUndef] = new ObjectPool<SPIRUndef>(16u);
        pool_group.pools[(int)Types.TypeString] = new ObjectPool<SPIRString>(16u);
        pool_group.pools[(int)Types.TypeDebugLocalVariable] = new ObjectPool<SPIRDebugLocalVariable>(16u);
        pool_group.pools[(int)Types.TypeConstantData] = new ObjectPool<SPIRConstantData>(16u);
    }
    public ParsedIR(ParsedIR other)
    {
        this.pool_group = null;
        this.spirv = new CppVector<uint>();
        this.ids = new CppVector<Variant>();
        this.meta = new UnorderedMap<TypedID_TypeNone, Meta>();
        this.ids_for_type = Std.new_array<CppVector<TypedID_TypeNone>>(16);
        this.ids_for_constant_undef_or_type = new CppVector<TypedID_TypeNone>();
        this.ids_for_constant_or_variable = new CppVector<TypedID_TypeNone>();
        this.load_type_width = new UnorderedMap<TypedID_TypeNone, uint>();
        this.declared_capabilities = new CppVector<Spv.Capability>();
        this.declared_extensions = new CppVector<CppString>();
        this.block_meta = new CppVector<byte>();
        this.continue_block_to_loop_header = new UnorderedMap<TypedID_TypeBlock, TypedID_TypeBlock>();
        this.entry_points = new UnorderedMap<TypedID_TypeFunction, SPIREntryPoint>();
        this.library_exports = new CppVector<uint>();
        this.library_exported_functions = new CppVector<TypedID_TypeFunction>();
        this.sources = new CppVector<ParsedIR.Source>();
        this.empty_string = default(CppString);
        this.cleared_bitset = new Bitset();
        this.meta_needing_name_fixup = new UnorderedSet<uint>();
        this.CopyFrom(other);
    }
    public ParsedIR operator_assign(ParsedIR other)
    {
        if (this != other)
        {
            pool_group = other.pool_group;
            spirv.CopyFrom(other.spirv);
            meta.CopyFrom(other.meta);
            {
                for (int i = 0; i < unchecked((int)Types.TypeCount); i++)
                {
                    ids_for_type[i].CopyFrom(other.ids_for_type[i]);
                }
            }
            ids_for_constant_undef_or_type.CopyFrom(other.ids_for_constant_undef_or_type);
            ids_for_constant_or_variable.CopyFrom(other.ids_for_constant_or_variable);
            declared_capabilities.CopyFrom(other.declared_capabilities);
            declared_extensions.CopyFrom(other.declared_extensions);
            block_meta.CopyFrom(other.block_meta);
            continue_block_to_loop_header.CopyFrom(other.continue_block_to_loop_header);
            entry_points.CopyFrom(other.entry_points);
            ids.CopyFrom(other.ids);
            addressing_model = other.addressing_model;
            memory_model = other.memory_model;
            default_entry_point = other.default_entry_point;
            is_library_module = other.is_library_module;
            library_exports.CopyFrom(other.library_exports);
            library_exported_functions.CopyFrom(other.library_exported_functions);
            sources.CopyFrom(other.sources);
            loop_iteration_depth_hard = other.loop_iteration_depth_hard;
            loop_iteration_depth_soft = other.loop_iteration_depth_soft;
            meta_needing_name_fixup.CopyFrom(other.meta_needing_name_fixup);
            load_type_width.CopyFrom(other.load_type_width);
        }
        return this;
    }
    public void set_id_bounds(uint bounds)
    {
        ids.reserve(unchecked((ulong)bounds));
        while (ids.size() < unchecked((ulong)bounds))
        {
            ids.push_back(new Variant(pool_group));
        }
        block_meta.resize(unchecked((ulong)bounds));
    }
    public CppVector<uint> spirv = new CppVector<uint>();
    public CppVector<Variant> ids = new CppVector<Variant>();
    public UnorderedMap<TypedID_TypeNone, Meta> meta = new UnorderedMap<TypedID_TypeNone, Meta>();
    public CppVector<TypedID_TypeNone>[] ids_for_type = Std.new_array<CppVector<TypedID_TypeNone>>(16);
    public CppVector<TypedID_TypeNone> ids_for_constant_undef_or_type = new CppVector<TypedID_TypeNone>();
    public CppVector<TypedID_TypeNone> ids_for_constant_or_variable = new CppVector<TypedID_TypeNone>();
    public UnorderedMap<TypedID_TypeNone, uint> load_type_width = new UnorderedMap<TypedID_TypeNone, uint>();
    public CppVector<Spv.Capability> declared_capabilities = new CppVector<Spv.Capability>();
    public CppVector<CppString> declared_extensions = new CppVector<CppString>();
    public CppVector<byte> block_meta = new CppVector<byte>();
    public UnorderedMap<TypedID_TypeBlock, TypedID_TypeBlock> continue_block_to_loop_header = new UnorderedMap<TypedID_TypeBlock, TypedID_TypeBlock>();
    public UnorderedMap<TypedID_TypeFunction, SPIREntryPoint> entry_points = new UnorderedMap<TypedID_TypeFunction, SPIREntryPoint>();
    public TypedID_TypeFunction default_entry_point = new TypedID_TypeFunction(0u);
    public bool is_library_module = false;
    public CppVector<uint> library_exports = new CppVector<uint>();
    public CppVector<TypedID_TypeFunction> library_exported_functions = new CppVector<TypedID_TypeFunction>();
    public CppVector<ParsedIR.Source> sources = new CppVector<ParsedIR.Source>();
    public Spv.AddressingModel addressing_model = Spv.AddressingModel.AddressingModelMax;
    public Spv.MemoryModel memory_model = Spv.MemoryModel.MemoryModelMax;
    public void set_name(TypedID_TypeNone id, CppString name)
    {
        ref var m = ref meta[id];
        m.decoration.alias = name;
        if (!Globals.is_valid_identifier(name) || Globals.is_reserved_identifier(name, false, false))
        {
            meta_needing_name_fixup.insert(((uint)id));
        }
    }
    public CppString get_name(TypedID_TypeNone id)
    {
        var m = find_meta(id);
        if (m != null)
        {
            return m.decoration.alias;
        }
        else
        {
            return empty_string;
        }
    }
    public void set_decoration(TypedID_TypeNone id, Spv.Decoration decoration, uint argument = 0u)
    {
        ref var dec = ref meta[id].decoration;
        dec.decoration_flags.set(unchecked((uint)decoration));
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationBuiltIn):
                {
                    dec.builtin = true;
                    dec.builtin_type = unchecked((Spv.BuiltIn)argument);
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationLocation):
                {
                    dec.location = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationComponent):
                {
                    dec.component = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffset):
                {
                    dec.offset = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffsetIdEXT):
                {
                    dec.offset_id = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbBuffer):
                {
                    dec.xfb_buffer = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbStride):
                {
                    dec.xfb_stride = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationStream):
                {
                    dec.stream = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationArrayStride):
                {
                    dec.array_stride = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationArrayStrideIdEXT):
                {
                    dec.array_stride_id = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationMatrixStride):
                {
                    dec.matrix_stride = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationBinding):
                {
                    dec.binding = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationDescriptorSet):
                {
                    dec.set = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationInputAttachmentIndex):
                {
                    dec.input_attachment = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationSpecId):
                {
                    dec.spec_id = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationIndex):
                {
                    dec.index = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationHlslCounterBufferGOOGLE):
                {
                    meta[id].hlsl_magic_counter_buffer = argument;
                    meta[new TypedID_TypeNone(argument)].hlsl_is_magic_counter_buffer = true;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationFPRoundingMode):
                {
                    dec.fp_rounding_mode = unchecked((Spv.FPRoundingMode)argument);
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationFPFastMathMode):
                {
                    dec.fp_fast_math_mode = unchecked((Spv.FPFastMathModeMask)argument);
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public void set_decoration_string(TypedID_TypeNone id, Spv.Decoration decoration, CppString argument)
    {
        ref var dec = ref meta[id].decoration;
        dec.decoration_flags.set(unchecked((uint)decoration));
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationUserSemantic):
                {
                    dec.user_semantic = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationUserTypeGOOGLE):
                {
                    dec.user_type = argument;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public bool has_decoration(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        return get_decoration_bitset(id).get(unchecked((uint)decoration));
    }
    public uint get_decoration(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        var m = find_meta(id);
        if (!(m != null))
        {
            return 0u;
        }
        var dec = m.decoration;
        if (!dec.decoration_flags.get(unchecked((uint)decoration)))
        {
            return 0u;
        }
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationBuiltIn):
                {
                    return unchecked((uint)dec.builtin_type);
                }
                case unchecked((int)Spv.Decoration.DecorationLocation):
                {
                    return dec.location;
                }
                case unchecked((int)Spv.Decoration.DecorationComponent):
                {
                    return dec.component;
                }
                case unchecked((int)Spv.Decoration.DecorationOffset):
                {
                    return dec.offset;
                }
                case unchecked((int)Spv.Decoration.DecorationOffsetIdEXT):
                {
                    return dec.offset_id;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbBuffer):
                {
                    return dec.xfb_buffer;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbStride):
                {
                    return dec.xfb_stride;
                }
                case unchecked((int)Spv.Decoration.DecorationStream):
                {
                    return dec.stream;
                }
                case unchecked((int)Spv.Decoration.DecorationBinding):
                {
                    return dec.binding;
                }
                case unchecked((int)Spv.Decoration.DecorationDescriptorSet):
                {
                    return dec.set;
                }
                case unchecked((int)Spv.Decoration.DecorationInputAttachmentIndex):
                {
                    return dec.input_attachment;
                }
                case unchecked((int)Spv.Decoration.DecorationSpecId):
                {
                    return dec.spec_id;
                }
                case unchecked((int)Spv.Decoration.DecorationArrayStride):
                {
                    return dec.array_stride;
                }
                case unchecked((int)Spv.Decoration.DecorationArrayStrideIdEXT):
                {
                    return dec.array_stride_id;
                }
                case unchecked((int)Spv.Decoration.DecorationMatrixStride):
                {
                    return dec.matrix_stride;
                }
                case unchecked((int)Spv.Decoration.DecorationIndex):
                {
                    return dec.index;
                }
                case unchecked((int)Spv.Decoration.DecorationFPRoundingMode):
                {
                    return unchecked((uint)dec.fp_rounding_mode);
                }
                case unchecked((int)Spv.Decoration.DecorationFPFastMathMode):
                {
                    return unchecked((uint)dec.fp_fast_math_mode);
                }
                default:
                {
                    return 1u;
                }
            }
        }
    }
    public CppString get_decoration_string(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        var m = find_meta(id);
        if (!(m != null))
        {
            return empty_string;
        }
        var dec = m.decoration;
        if (!dec.decoration_flags.get(unchecked((uint)decoration)))
        {
            return empty_string;
        }
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationUserSemantic):
                {
                    return dec.user_semantic;
                }
                case unchecked((int)Spv.Decoration.DecorationUserTypeGOOGLE):
                {
                    return dec.user_type;
                }
                default:
                {
                    return empty_string;
                }
            }
        }
    }
    public Bitset get_decoration_bitset(TypedID_TypeNone id)
    {
        var m = find_meta(id);
        if (m != null)
        {
            var dec = m.decoration;
            return dec.decoration_flags;
        }
        else
        {
            return cleared_bitset;
        }
    }
    public void unset_decoration(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        ref var dec = ref meta[id].decoration;
        dec.decoration_flags.clear(unchecked((uint)decoration));
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationBuiltIn):
                {
                    dec.builtin = false;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationLocation):
                {
                    dec.location = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationComponent):
                {
                    dec.component = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffset):
                {
                    dec.offset = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffsetIdEXT):
                {
                    dec.offset_id = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbBuffer):
                {
                    dec.xfb_buffer = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbStride):
                {
                    dec.xfb_stride = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationStream):
                {
                    dec.stream = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationBinding):
                {
                    dec.binding = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationDescriptorSet):
                {
                    dec.set = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationInputAttachmentIndex):
                {
                    dec.input_attachment = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationSpecId):
                {
                    dec.spec_id = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationUserSemantic):
                {
                    dec.user_semantic.clear();
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationFPRoundingMode):
                {
                    dec.fp_rounding_mode = Spv.FPRoundingMode.FPRoundingModeMax;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationFPFastMathMode):
                {
                    dec.fp_fast_math_mode = Spv.FPFastMathModeMask.FPFastMathModeMaskNone;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationHlslCounterBufferGOOGLE):
                {
                    {
                        ref var counter = ref meta[id].hlsl_magic_counter_buffer;
                        if (counter != 0u)
                        {
                            meta[new TypedID_TypeNone(counter)].hlsl_is_magic_counter_buffer = false;
                            counter = 0u;
                        }
                        break;
                    }
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public void set_member_name(TypedID_TypeType id, uint index, CppString name)
    {
        ref var m = ref meta[new TypedID_TypeNone(id)];
        m.members.resize(Std.max(m.members.size(), unchecked((ulong)index) + 1UL));
        m.members[unchecked((ulong)index)].alias = name;
        if (!Globals.is_valid_identifier(name) || Globals.is_reserved_identifier(name, true, false))
        {
            meta_needing_name_fixup.insert(((uint)id));
        }
    }
    public CppString get_member_name(TypedID_TypeType id, uint index)
    {
        var m = find_meta(new TypedID_TypeNone(id));
        if (m != null)
        {
            if (unchecked((ulong)index) >= m.members.size())
            {
                return empty_string;
            }
            return m.members[unchecked((ulong)index)].alias;
        }
        else
        {
            return empty_string;
        }
    }
    public void set_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration, uint argument = 0u)
    {
        ref var m = ref meta[new TypedID_TypeNone(id)];
        m.members.resize(Std.max(m.members.size(), unchecked((ulong)index) + 1UL));
        ref var dec = ref m.members[unchecked((ulong)index)];
        dec.decoration_flags.set(unchecked((uint)decoration));
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationBuiltIn):
                {
                    dec.builtin = true;
                    dec.builtin_type = unchecked((Spv.BuiltIn)argument);
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationLocation):
                {
                    dec.location = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationComponent):
                {
                    dec.component = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationBinding):
                {
                    dec.binding = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffset):
                {
                    dec.offset = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffsetIdEXT):
                {
                    dec.offset_id = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbBuffer):
                {
                    dec.xfb_buffer = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbStride):
                {
                    dec.xfb_stride = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationStream):
                {
                    dec.stream = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationSpecId):
                {
                    dec.spec_id = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationMatrixStride):
                {
                    dec.matrix_stride = argument;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationIndex):
                {
                    dec.index = argument;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public void set_member_decoration_string(TypedID_TypeType id, uint index, Spv.Decoration decoration, CppString argument)
    {
        ref var m = ref meta[new TypedID_TypeNone(id)];
        m.members.resize(Std.max(m.members.size(), unchecked((ulong)index) + 1UL));
        ref var dec = ref meta[new TypedID_TypeNone(id)].members[unchecked((ulong)index)];
        dec.decoration_flags.set(unchecked((uint)decoration));
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationUserSemantic):
                {
                    dec.user_semantic = argument;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public uint get_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        var m = find_meta(new TypedID_TypeNone(id));
        if (!(m != null))
        {
            return 0u;
        }
        if (unchecked((ulong)index) >= m.members.size())
        {
            return 0u;
        }
        var dec = m.members[unchecked((ulong)index)];
        if (!dec.decoration_flags.get(unchecked((uint)decoration)))
        {
            return 0u;
        }
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationBuiltIn):
                {
                    return unchecked((uint)dec.builtin_type);
                }
                case unchecked((int)Spv.Decoration.DecorationLocation):
                {
                    return dec.location;
                }
                case unchecked((int)Spv.Decoration.DecorationComponent):
                {
                    return dec.component;
                }
                case unchecked((int)Spv.Decoration.DecorationBinding):
                {
                    return dec.binding;
                }
                case unchecked((int)Spv.Decoration.DecorationOffset):
                {
                    return dec.offset;
                }
                case unchecked((int)Spv.Decoration.DecorationOffsetIdEXT):
                {
                    return dec.offset_id;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbBuffer):
                {
                    return dec.xfb_buffer;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbStride):
                {
                    return dec.xfb_stride;
                }
                case unchecked((int)Spv.Decoration.DecorationStream):
                {
                    return dec.stream;
                }
                case unchecked((int)Spv.Decoration.DecorationSpecId):
                {
                    return dec.spec_id;
                }
                case unchecked((int)Spv.Decoration.DecorationMatrixStride):
                {
                    return dec.matrix_stride;
                }
                case unchecked((int)Spv.Decoration.DecorationIndex):
                {
                    return dec.index;
                }
                default:
                {
                    return 1u;
                }
            }
        }
    }
    public CppString get_member_decoration_string(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        var m = find_meta(new TypedID_TypeNone(id));
        if (m != null)
        {
            if (!has_member_decoration(id, index, decoration))
            {
                return empty_string;
            }
            var dec = m.members[unchecked((ulong)index)];
            {
                switch (unchecked((int)decoration))
                {
                    case unchecked((int)Spv.Decoration.DecorationUserSemantic):
                    {
                        return dec.user_semantic;
                    }
                    default:
                    {
                        return empty_string;
                    }
                }
            }
        }
        else
        {
            return empty_string;
        }
    }
    public bool has_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        return get_member_decoration_bitset(id, index).get(unchecked((uint)decoration));
    }
    public Bitset get_member_decoration_bitset(TypedID_TypeType id, uint index)
    {
        var m = find_meta(new TypedID_TypeNone(id));
        if (m != null)
        {
            if (unchecked((ulong)index) >= m.members.size())
            {
                return cleared_bitset;
            }
            return m.members[unchecked((ulong)index)].decoration_flags;
        }
        else
        {
            return cleared_bitset;
        }
    }
    public void unset_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        ref var m = ref meta[new TypedID_TypeNone(id)];
        if (unchecked((ulong)index) >= m.members.size())
        {
            return;
        }
        ref var dec = ref m.members[unchecked((ulong)index)];
        dec.decoration_flags.clear(unchecked((uint)decoration));
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationBuiltIn):
                {
                    dec.builtin = false;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationLocation):
                {
                    dec.location = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationComponent):
                {
                    dec.component = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffset):
                {
                    dec.offset = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationOffsetIdEXT):
                {
                    dec.offset_id = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbBuffer):
                {
                    dec.xfb_buffer = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationXfbStride):
                {
                    dec.xfb_stride = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationStream):
                {
                    dec.stream = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationSpecId):
                {
                    dec.spec_id = 0u;
                    break;
                }
                case unchecked((int)Spv.Decoration.DecorationUserSemantic):
                {
                    dec.user_semantic.clear();
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public void mark_used_as_array_length(TypedID_TypeNone id)
    {
        {
            switch (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()))
            {
                case unchecked((int)Types.TypeConstant):
                {
                    {
                        var c = get__SPIRConstant(((uint)id));
                        c.is_used_as_array_length = true;
                        {
                            var __r0 = c.m.id;
                            for (int __i1 = 0; __i1 < __r0.Length; __i1++)
                            {
                                ref TypedID_TypeNone sub_id = ref __r0[__i1];
                                if (((uint)sub_id) != 0u)
                                {
                                    mark_used_as_array_length(sub_id);
                                }
                            }
                        }
                        {
                            for (uint col = 0u; col < c.m.columns; col++)
                            {
                                {
                                    var __r2 = c.m.c[col].id;
                                    for (int __i3 = 0; __i3 < __r2.Length; __i3++)
                                    {
                                        ref TypedID_TypeNone sub_id = ref __r2[__i3];
                                        if (((uint)sub_id) != 0u)
                                        {
                                            mark_used_as_array_length(sub_id);
                                        }
                                    }
                                }
                            }
                        }
                        {
                            var __r4 = c.subconstants;
                            for (int __i5 = 0; __i5 < (int)__r4.size(); __i5++)
                            {
                                ref TypedID_TypeConstant sub_id = ref __r4[__i5];
                                if (((uint)sub_id) != 0u)
                                {
                                    mark_used_as_array_length(new TypedID_TypeNone(sub_id));
                                }
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Types.TypeConstantOp):
                {
                    {
                        var cop = get__SPIRConstantOp(((uint)id));
                        if (unchecked((int)cop.opcode) == unchecked((int)Spv.Op.OpCompositeExtract))
                        {
                            mark_used_as_array_length(new TypedID_TypeNone(cop.arguments[0UL]));
                        }
                        else
                        if (unchecked((int)cop.opcode) == unchecked((int)Spv.Op.OpCompositeInsert))
                        {
                            mark_used_as_array_length(new TypedID_TypeNone(cop.arguments[0UL]));
                            mark_used_as_array_length(new TypedID_TypeNone(cop.arguments[1UL]));
                        }
                        else
                        {
                            {
                                foreach (uint arg_id in cop.arguments)
                                {
                                    mark_used_as_array_length(new TypedID_TypeNone(arg_id));
                                }
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Types.TypeUndef):
                {
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public uint increase_bound_by(uint incr_amount)
    {
        var curr_bound = ids.size();
        var new_bound = curr_bound + unchecked((ulong)incr_amount);
        ids.reserve(ids.size() + unchecked((ulong)incr_amount));
        {
            for (uint i = 0u; i < incr_amount; i++)
            {
                ids.push_back(new Variant(pool_group));
            }
        }
        block_meta.resize(new_bound);
        return unchecked((uint)curr_bound);
    }
    public Bitset get_buffer_block_flags(SPIRVariable @var)
    {
        var type = get__SPIRType(((uint)@var.basetype));
        if (unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Struct))
        {
            throw new CompilerError("Cannot get buffer block flags for non-buffer variable.");
        }
        Bitset base_flags = new Bitset();
        var m = find_meta(@var.self);
        if (m != null)
        {
            base_flags.CopyFrom(m.decoration.decoration_flags);
        }
        if (type.member_types.empty())
        {
            return base_flags;
        }
        var all_members_flags = get_buffer_block_type_flags(type);
        base_flags.merge_or(all_members_flags);
        return base_flags;
    }
    public Bitset get_buffer_block_type_flags(SPIRType type)
    {
        if (type.member_types.empty())
        {
            return new Bitset();
        }
        Bitset all_members_flags = (get_member_decoration_bitset(((TypedID_TypeType)type.self), 0u)).Clone();
        {
            for (uint i = 1u; i < unchecked((uint)type.member_types.size()); i++)
            {
                all_members_flags.merge_and(get_member_decoration_bitset(((TypedID_TypeType)type.self), i));
            }
        }
        return all_members_flags;
    }
    public void add_typed_id(Types type, TypedID_TypeNone id)
    {
        if (loop_iteration_depth_hard != 0u)
        {
            throw new CompilerError("Cannot add typed ID while looping over it.");
        }
        if (loop_iteration_depth_soft != 0u)
        {
            if (!ids[unchecked((ulong)((uint)id))].empty())
            {
                throw new CompilerError("Cannot override IDs when loop is soft locked.");
            }
            return;
        }
        if (ids[unchecked((ulong)((uint)id))].empty() || unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) != unchecked((int)type))
        {
            {
                switch (unchecked((int)type))
                {
                    case unchecked((int)Types.TypeConstant):
                    {
                        ids_for_constant_or_variable.push_back(id);
                        ids_for_constant_undef_or_type.push_back(id);
                        break;
                    }
                    case unchecked((int)Types.TypeVariable):
                    {
                        ids_for_constant_or_variable.push_back(id);
                        break;
                    }
                    case unchecked((int)Types.TypeType):
                    case unchecked((int)Types.TypeConstantOp):
                    case unchecked((int)Types.TypeUndef):
                    {
                        ids_for_constant_undef_or_type.push_back(id);
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
        }
        if (ids[unchecked((ulong)((uint)id))].empty())
        {
            ids_for_type[(int)type].push_back(id);
        }
        else
        if (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) != unchecked((int)type))
        {
            remove_typed_id(ids[unchecked((ulong)((uint)id))].get_type(), id);
            ids_for_type[(int)type].push_back(id);
        }
    }
    public void remove_typed_id(Types type, TypedID_TypeNone id)
    {
        var type_ids = ids_for_type[(int)type];
        type_ids.erase(Std.remove(Std.begin(type_ids), Std.end(type_ids), id), Std.end(type_ids));
    }
    public ParsedIR.LoopLock create_loop_hard_lock()
    {
        return new ParsedIR.LoopLock(Ptr.Ref<uint>(() => loop_iteration_depth_hard, __v => loop_iteration_depth_hard = __v));
    }
    public ParsedIR.LoopLock create_loop_soft_lock()
    {
        return new ParsedIR.LoopLock(Ptr.Ref<uint>(() => loop_iteration_depth_soft, __v => loop_iteration_depth_soft = __v));
    }
    public void reset_all_of_type(Types type)
    {
        {
            var __r0 = ids_for_type[(int)type];
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone id = ref __r0[__i1];
                if (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) == unchecked((int)type))
                {
                    ids[unchecked((ulong)((uint)id))].reset();
                }
            }
        }
        ids_for_type[(int)type].clear();
    }
    public Meta find_meta(TypedID_TypeNone id)
    {
        var itr = meta.find(id);
        if (itr != Std.end(meta))
        {
            return itr.deref().second;
        }
        else
        {
            return null;
        }
    }
    public CppString get_empty_string()
    {
        return empty_string;
    }
    public void make_constant_null(uint id, uint type, bool add_to_typed_id_set)
    {
        var constant_type = get__SPIRType(type);
        if (constant_type.pointer)
        {
            if (add_to_typed_id_set)
            {
                add_typed_id(Types.TypeConstant, new TypedID_TypeNone(id));
            }
            var constant = Globals.variant_set__SPIRConstant_X(ids[unchecked((ulong)id)], type);
            constant.self = new TypedID_TypeNone(id);
            constant.make_null(constant_type);
        }
        else
        if (!constant_type.array.empty())
        {
            uint parent_id = increase_bound_by(1u);
            make_constant_null(parent_id, ((uint)constant_type.parent_type), add_to_typed_id_set);
            bool is_literal_array_size = constant_type.array_size_literal.back();
            uint count = is_literal_array_size ? constant_type.array.back() : 1u;
            CppVector<uint> elements = new CppVector<uint>(unchecked((ulong)count));
            {
                for (uint i = 0u; i < count; i++)
                {
                    elements[unchecked((ulong)i)] = parent_id;
                }
            }
            if (add_to_typed_id_set)
            {
                add_typed_id(Types.TypeConstant, new TypedID_TypeNone(id));
            }
            var constant = Globals.variant_set__SPIRConstant_X(ids[unchecked((ulong)id)], type, elements.data(), unchecked((uint)elements.size()), false);
            constant.self = new TypedID_TypeNone(id);
            constant.is_null_array_specialized_length = !is_literal_array_size;
        }
        else
        if (!constant_type.member_types.empty())
        {
            uint member_ids = increase_bound_by(unchecked((uint)constant_type.member_types.size()));
            CppVector<uint> elements = new CppVector<uint>(constant_type.member_types.size());
            {
                for (uint i = 0u; unchecked((ulong)i) < constant_type.member_types.size(); i++)
                {
                    make_constant_null(member_ids + i, ((uint)constant_type.member_types[unchecked((ulong)i)]), add_to_typed_id_set);
                    elements[unchecked((ulong)i)] = member_ids + i;
                }
            }
            if (add_to_typed_id_set)
            {
                add_typed_id(Types.TypeConstant, new TypedID_TypeNone(id));
            }
            Globals.variant_set__SPIRConstant_X(ids[unchecked((ulong)id)], type, elements.data(), unchecked((uint)elements.size()), false).self = new TypedID_TypeNone(id);
        }
        else
        {
            if (add_to_typed_id_set)
            {
                add_typed_id(Types.TypeConstant, new TypedID_TypeNone(id));
            }
            var constant = Globals.variant_set__SPIRConstant_X(ids[unchecked((ulong)id)], type);
            constant.self = new TypedID_TypeNone(id);
            constant.make_null(constant_type);
        }
    }
    public void fixup_reserved_names()
    {
        {
            foreach (uint id in meta_needing_name_fixup)
            {
                if (unchecked((int)ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeVariable) && get__SPIRVariable(id).remapped_variable)
                {
                    continue;
                }
                ref var m = ref meta[new TypedID_TypeNone(id)];
                ParsedIR.sanitize_identifier(ref m.decoration.alias, false, false);
                {
                    foreach (Meta.Decoration memb in m.members)
                    {
                        ParsedIR.sanitize_identifier(ref memb.alias, true, false);
                    }
                }
            }
        }
        meta_needing_name_fixup.clear();
    }
    public static void sanitize_identifier(ref CppString name, bool member, bool allow_reserved_prefixes)
    {
        if (!Globals.is_valid_identifier(name))
        {
            name = Globals.ensure_valid_identifier(name);
        }
        if (Globals.is_reserved_identifier(name, member, allow_reserved_prefixes))
        {
            name = Globals.make_unreserved_identifier(name);
        }
    }
    public static bool is_globally_reserved_identifier(ref CppString str, bool allow_reserved_prefixes)
    {
        return Globals.is_reserved_identifier(str, false, allow_reserved_prefixes);
    }
    public uint get_spirv_version()
    {
        return spirv[1UL];
    }
    public SPIRVariable get__SPIRVariable(uint id)
    {
        return Globals.variant_get__SPIRVariable(ids[unchecked((ulong)id)]);
    }
    public SPIRConstant get__SPIRConstant(uint id)
    {
        return Globals.variant_get__SPIRConstant(ids[unchecked((ulong)id)]);
    }
    public SPIRConstantOp get__SPIRConstantOp(uint id)
    {
        return Globals.variant_get__SPIRConstantOp(ids[unchecked((ulong)id)]);
    }
    public SPIRType get__SPIRType(uint id)
    {
        return Globals.variant_get__SPIRType(ids[unchecked((ulong)id)]);
    }
    public uint loop_iteration_depth_hard = 0u;
    public uint loop_iteration_depth_soft = 0u;
    public CppString empty_string;
    public Bitset cleared_bitset = new Bitset();
    public UnorderedSet<uint> meta_needing_name_fixup = new UnorderedSet<uint>();
    public void for_each_typed_id__SPIRFunction_lambda(Action<uint, SPIRFunction> op)
    {
        using var loop_lock = create_loop_hard_lock();
        {
            var __r0 = ids_for_type[SPIRFunction.type];
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone id = ref __r0[__i1];
                if (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) == unchecked((int)unchecked((Types)SPIRFunction.type)))
                {
                    op(((uint)id), get__SPIRFunction(((uint)id)));
                }
            }
        }
    }
    public void for_each_typed_id__SPIRVariable_lambda(Action<uint, SPIRVariable> op)
    {
        using var loop_lock = create_loop_hard_lock();
        {
            var __r0 = ids_for_type[SPIRVariable.type];
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone id = ref __r0[__i1];
                if (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) == unchecked((int)unchecked((Types)SPIRVariable.type)))
                {
                    op(((uint)id), get__SPIRVariable(((uint)id)));
                }
            }
        }
    }
    public void for_each_typed_id__SPIRType_lambda(Action<uint, SPIRType> op)
    {
        using var loop_lock = create_loop_hard_lock();
        {
            var __r0 = ids_for_type[SPIRType.type];
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone id = ref __r0[__i1];
                if (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) == unchecked((int)unchecked((Types)SPIRType.type)))
                {
                    op(((uint)id), get__SPIRType(((uint)id)));
                }
            }
        }
    }
    public void for_each_typed_id__SPIRFunction_lambda(object op)
    {
        throw new System.NotImplementedException();
    }
    public void for_each_typed_id__SPIRConstant_lambda(Action<uint, SPIRConstant> op)
    {
        using var loop_lock = create_loop_hard_lock();
        {
            var __r0 = ids_for_type[SPIRConstant.type];
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone id = ref __r0[__i1];
                if (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) == unchecked((int)unchecked((Types)SPIRConstant.type)))
                {
                    op(((uint)id), get__SPIRConstant(((uint)id)));
                }
            }
        }
    }
    public void for_each_typed_id__SPIRVariable_lambda(object op)
    {
        throw new System.NotImplementedException();
    }
    public void for_each_typed_id__SPIRType_lambda(object op)
    {
        throw new System.NotImplementedException();
    }
    public SPIRFunction get__SPIRFunction(uint id)
    {
        return Globals.variant_get__SPIRFunction(ids[unchecked((ulong)id)]);
    }
    public SPIRString get__SPIRString(uint id)
    {
        return Globals.variant_get__SPIRString(ids[unchecked((ulong)id)]);
    }
    public void for_each_typed_id__SPIRBlock_lambda(Action<uint, SPIRBlock> op)
    {
        using var loop_lock = create_loop_hard_lock();
        {
            var __r0 = ids_for_type[SPIRBlock.type];
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone id = ref __r0[__i1];
                if (unchecked((int)ids[unchecked((ulong)((uint)id))].get_type()) == unchecked((int)unchecked((Types)SPIRBlock.type)))
                {
                    op(((uint)id), get__SPIRBlock(((uint)id)));
                }
            }
        }
    }
    public void for_each_typed_id__SPIRBlock_lambda(object op)
    {
        throw new System.NotImplementedException();
    }
    public void reset_all_of_type__SPIRExpression()
    {
        reset_all_of_type(unchecked((Types)SPIRExpression.type));
    }
    public void reset_all_of_type__SPIRAccessChain()
    {
        reset_all_of_type(unchecked((Types)SPIRAccessChain.type));
    }
    public SPIRBlock get__SPIRBlock(uint id)
    {
        return Globals.variant_get__SPIRBlock(ids[unchecked((ulong)id)]);
    }
    public void for_each_typed_id__SPIRConstant_lambda(object op)
    {
        throw new System.NotImplementedException();
    }

    protected virtual void FixClone()
    {
        this.spirv = this.spirv.Clone();
        this.ids = this.ids.Clone(__e => __e.Clone());
        this.meta = this.meta.Clone(null, __e => __e.Clone());
        this.ids_for_type = Std.clone_array(this.ids_for_type, __e => __e.Clone());
        this.ids_for_constant_undef_or_type = this.ids_for_constant_undef_or_type.Clone();
        this.ids_for_constant_or_variable = this.ids_for_constant_or_variable.Clone();
        this.load_type_width = this.load_type_width.Clone();
        this.declared_capabilities = this.declared_capabilities.Clone();
        this.declared_extensions = this.declared_extensions.Clone();
        this.block_meta = this.block_meta.Clone();
        this.continue_block_to_loop_header = this.continue_block_to_loop_header.Clone();
        this.entry_points = this.entry_points.Clone(null, __e => __e.Clone());
        this.library_exports = this.library_exports.Clone();
        this.library_exported_functions = this.library_exported_functions.Clone();
        this.sources = this.sources.Clone(__e => __e.Clone());
        this.cleared_bitset = this.cleared_bitset.Clone();
        this.meta_needing_name_fixup = this.meta_needing_name_fixup.Clone();
    }

    public ParsedIR Clone()
    {
        var __c = (ParsedIR)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(ParsedIR o)
    {
        this.pool_group = o.pool_group;
        this.spirv = o.spirv.Clone();
        this.ids = o.ids.Clone(__e => __e.Clone());
        this.meta = o.meta.Clone(null, __e => __e.Clone());
        this.ids_for_type = Std.clone_array(o.ids_for_type, __e => __e.Clone());
        this.ids_for_constant_undef_or_type = o.ids_for_constant_undef_or_type.Clone();
        this.ids_for_constant_or_variable = o.ids_for_constant_or_variable.Clone();
        this.load_type_width = o.load_type_width.Clone();
        this.declared_capabilities = o.declared_capabilities.Clone();
        this.declared_extensions = o.declared_extensions.Clone();
        this.block_meta = o.block_meta.Clone();
        this.continue_block_to_loop_header = o.continue_block_to_loop_header.Clone();
        this.entry_points = o.entry_points.Clone(null, __e => __e.Clone());
        this.default_entry_point = o.default_entry_point;
        this.is_library_module = o.is_library_module;
        this.library_exports = o.library_exports.Clone();
        this.library_exported_functions = o.library_exported_functions.Clone();
        this.sources = o.sources.Clone(__e => __e.Clone());
        this.addressing_model = o.addressing_model;
        this.memory_model = o.memory_model;
        this.loop_iteration_depth_hard = o.loop_iteration_depth_hard;
        this.loop_iteration_depth_soft = o.loop_iteration_depth_soft;
        this.empty_string = o.empty_string;
        this.cleared_bitset = o.cleared_bitset.Clone();
        this.meta_needing_name_fixup = o.meta_needing_name_fixup.Clone();
    }

    public enum BlockMetaFlagBits : int
    {
        BLOCK_META_LOOP_HEADER_BIT = 1,
        BLOCK_META_CONTINUE_BIT = 2,
        BLOCK_META_LOOP_MERGE_BIT = 4,
        BLOCK_META_SELECTION_MERGE_BIT = 8,
        BLOCK_META_MULTISELECT_MERGE_BIT = 16,
    }

    public partial class LoopLock : System.IDisposable
    {
        public LoopLock(Ptr<uint> lock_)
        {
            this.@lock = lock_;
            if (@lock != null)
            {
                @lock.Value++;
            }
        }
        public LoopLock(ParsedIR.LoopLock other)
        {
            this.CopyFrom(other);
        }
        public ParsedIR.LoopLock operator_assign(ParsedIR.LoopLock other)
        {
            if (@lock != null)
            {
                @lock.Value--;
            }
            @lock = other.@lock;
            other.@lock = null;
            return this;
        }
        public Ptr<uint> @lock = null;
        public void Dispose()
        {
            if (@lock != null)
            {
                @lock.Value--;
            }
        }

        protected virtual void FixClone()
        {
        }

        public LoopLock Clone()
        {
            var __c = (LoopLock)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(LoopLock o)
        {
            this.@lock = o.@lock;
        }
    }

    public partial class Source
    {
        public Spv.SourceLanguage lang = Spv.SourceLanguage.SourceLanguageUnknown;
        public uint version = 0u;
        public bool es = false;
        public bool known = false;
        public bool hlsl = false;
        public TypedID_TypeNone file_id = new TypedID_TypeNone(0u);
        public TypedID_TypeNone define_id = new TypedID_TypeNone(0u);
        public CppString source;
        public CppVector<ParsedIR.Source.Marker> line_markers = new CppVector<ParsedIR.Source.Marker>();
        public Source() { }

        protected virtual void FixClone()
        {
            this.line_markers = this.line_markers.Clone(__e => __e.Clone());
        }

        public Source Clone()
        {
            var __c = (Source)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(Source o)
        {
            this.lang = o.lang;
            this.version = o.version;
            this.es = o.es;
            this.known = o.known;
            this.hlsl = o.hlsl;
            this.file_id = o.file_id;
            this.define_id = o.define_id;
            this.source = o.source;
            this.line_markers = o.line_markers.Clone(__e => __e.Clone());
        }

        public partial class Marker
        {
            public TypedID_TypeNone line;
            public TypedID_TypeNone col;
            public TypedID_TypeNone offset;
            public TypedID_TypeNone function_id;
            public TypedID_TypeNone block_id;

            protected virtual void FixClone()
            {
            }

            public Marker Clone()
            {
                var __c = (Marker)MemberwiseClone();
                __c.FixClone();
                return __c;
            }

            public void CopyFrom(Marker o)
            {
                this.line = o.line;
                this.col = o.col;
                this.offset = o.offset;
                this.function_id = o.function_id;
                this.block_id = o.block_id;
            }
        }
    }
}
