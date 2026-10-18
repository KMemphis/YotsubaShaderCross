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
// Upstream sources: spirv_cross.cpp, spirv_cross.hpp
// Upstream copyright: Copyright 2015-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class Compiler
{
    public Compiler(CppVector<uint> ir_)
    {
        this.ir = new ParsedIR();
        this.global_variables = new CppVector<uint>();
        this.aliased_variables = new CppVector<uint>();
        this.buffer_pointer_variables = new CppVector<uint>();
        this.active_interface_variables = new UnorderedSet<TypedID_TypeVariable>();
        this.invalid_expressions = new UnorderedSet<uint>();
        this.combined_image_samplers = new CppVector<CombinedImageSampler>();
        this.global_struct_cache = new CppVector<uint>();
        this.variable_remap_callback = null;
        this.forced_temporaries = new UnorderedSet<uint>();
        this.forwarded_temporaries = new UnorderedSet<uint>();
        this.suppressed_usage_tracking = new UnorderedSet<uint>();
        this.hoisted_temporaries = new UnorderedSet<uint>();
        this.forced_invariant_temporaries = new UnorderedSet<uint>();
        this.active_input_builtins = new Bitset();
        this.active_output_builtins = new Bitset();
        this.comparison_ids = new UnorderedSet<uint>();
        this.function_cfgs = new UnorderedMap<uint, CFG>();
        this.physical_storage_non_block_pointer_types = new CppVector<uint>();
        this.physical_storage_type_to_alignment = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
        this.descriptor_heap_types = new CppVector<Compiler.DescriptorHeapMeta>();
        this.interlocked_resources = new UnorderedSet<uint>();
        this.abort_block_types = new UnorderedSet<uint>();
        this.abort_payloads = new UnorderedMap<uint, CppVector<uint>>();
        this.declared_block_names = new UnorderedMap<uint, CppString>();
        Parser parser = new Parser(ir_);
        parser.parse();
        set_ir(parser.get_parsed_ir());
    }
    public Compiler(Ptr<uint> ir_, ulong word_count)
    {
        this.ir = new ParsedIR();
        this.global_variables = new CppVector<uint>();
        this.aliased_variables = new CppVector<uint>();
        this.buffer_pointer_variables = new CppVector<uint>();
        this.active_interface_variables = new UnorderedSet<TypedID_TypeVariable>();
        this.invalid_expressions = new UnorderedSet<uint>();
        this.combined_image_samplers = new CppVector<CombinedImageSampler>();
        this.global_struct_cache = new CppVector<uint>();
        this.variable_remap_callback = null;
        this.forced_temporaries = new UnorderedSet<uint>();
        this.forwarded_temporaries = new UnorderedSet<uint>();
        this.suppressed_usage_tracking = new UnorderedSet<uint>();
        this.hoisted_temporaries = new UnorderedSet<uint>();
        this.forced_invariant_temporaries = new UnorderedSet<uint>();
        this.active_input_builtins = new Bitset();
        this.active_output_builtins = new Bitset();
        this.comparison_ids = new UnorderedSet<uint>();
        this.function_cfgs = new UnorderedMap<uint, CFG>();
        this.physical_storage_non_block_pointer_types = new CppVector<uint>();
        this.physical_storage_type_to_alignment = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
        this.descriptor_heap_types = new CppVector<Compiler.DescriptorHeapMeta>();
        this.interlocked_resources = new UnorderedSet<uint>();
        this.abort_block_types = new UnorderedSet<uint>();
        this.abort_payloads = new UnorderedMap<uint, CppVector<uint>>();
        this.declared_block_names = new UnorderedMap<uint, CppString>();
        Parser parser = new Parser(ir_, word_count);
        parser.parse();
        set_ir(parser.get_parsed_ir());
    }
    public Compiler(ParsedIR ir_)
    {
        this.ir = new ParsedIR();
        this.global_variables = new CppVector<uint>();
        this.aliased_variables = new CppVector<uint>();
        this.buffer_pointer_variables = new CppVector<uint>();
        this.active_interface_variables = new UnorderedSet<TypedID_TypeVariable>();
        this.invalid_expressions = new UnorderedSet<uint>();
        this.combined_image_samplers = new CppVector<CombinedImageSampler>();
        this.global_struct_cache = new CppVector<uint>();
        this.variable_remap_callback = null;
        this.forced_temporaries = new UnorderedSet<uint>();
        this.forwarded_temporaries = new UnorderedSet<uint>();
        this.suppressed_usage_tracking = new UnorderedSet<uint>();
        this.hoisted_temporaries = new UnorderedSet<uint>();
        this.forced_invariant_temporaries = new UnorderedSet<uint>();
        this.active_input_builtins = new Bitset();
        this.active_output_builtins = new Bitset();
        this.comparison_ids = new UnorderedSet<uint>();
        this.function_cfgs = new UnorderedMap<uint, CFG>();
        this.physical_storage_non_block_pointer_types = new CppVector<uint>();
        this.physical_storage_type_to_alignment = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
        this.descriptor_heap_types = new CppVector<Compiler.DescriptorHeapMeta>();
        this.interlocked_resources = new UnorderedSet<uint>();
        this.abort_block_types = new UnorderedSet<uint>();
        this.abort_payloads = new UnorderedMap<uint, CppVector<uint>>();
        this.declared_block_names = new UnorderedMap<uint, CppString>();
        set_ir(ir_);
    }
    public virtual CppString compile()
    {
        return new CppString("");
    }
    public CppString get_name(TypedID_TypeNone id)
    {
        return ir.get_name(id);
    }
    public void set_decoration(TypedID_TypeNone id, Spv.Decoration decoration, uint argument = 0u)
    {
        ir.set_decoration(id, decoration, argument);
    }
    public void set_decoration_string(TypedID_TypeNone id, Spv.Decoration decoration, CppString argument)
    {
        ir.set_decoration_string(id, decoration, argument);
    }
    public void set_name(TypedID_TypeNone id, CppString name)
    {
        ir.set_name(id, name);
    }
    public Bitset get_decoration_bitset(TypedID_TypeNone id)
    {
        return ir.get_decoration_bitset(id);
    }
    public bool has_decoration(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        return ir.has_decoration(id, decoration);
    }
    public uint get_decoration(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        return ir.get_decoration(id, decoration);
    }
    public CppString get_decoration_string(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        return ir.get_decoration_string(id, decoration);
    }
    public void unset_decoration(TypedID_TypeNone id, Spv.Decoration decoration)
    {
        ir.unset_decoration(id, decoration);
    }
    public SPIRType get_type(TypedID_TypeType id)
    {
        return get__SPIRType(((uint)id));
    }
    public SPIRType get_type_from_variable(TypedID_TypeVariable id)
    {
        return get__SPIRType(((uint)get__SPIRVariable(((uint)id)).basetype));
    }
    public Spv.StorageClass get_storage_class(TypedID_TypeVariable id)
    {
        return get__SPIRVariable(((uint)id)).storage;
    }
    public virtual CppString get_fallback_name(TypedID_TypeNone id)
    {
        return Std.join("_", (uint)id);
    }
    public virtual CppString get_block_fallback_name(TypedID_TypeVariable id)
    {
        var @var = get__SPIRVariable(((uint)id));
        if (get_name(new TypedID_TypeNone(id)).empty())
        {
            return Std.join("_", (uint)get__SPIRType(((uint)@var.basetype)).self, "_", (uint)id);
        }
        else
        {
            return get_name(new TypedID_TypeNone(id));
        }
    }
    public CppString get_member_name(TypedID_TypeType id, uint index)
    {
        return ir.get_member_name(id, index);
    }
    public uint get_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        return ir.get_member_decoration(id, index, decoration);
    }
    public CppString get_member_decoration_string(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        return ir.get_member_decoration_string(id, index, decoration);
    }
    public void set_member_name(TypedID_TypeType id, uint index, CppString name)
    {
        ir.set_member_name(id, index, name);
    }
    public CppString get_member_qualified_name(TypedID_TypeType type_id, uint index)
    {
        var m = ir.find_meta(new TypedID_TypeNone(type_id));
        if (m != null && unchecked((ulong)index) < m.members.size())
        {
            return m.members[unchecked((ulong)index)].qualified_alias;
        }
        else
        {
            return ir.get_empty_string();
        }
    }
    public Bitset get_member_decoration_bitset(TypedID_TypeType id, uint index)
    {
        return ir.get_member_decoration_bitset(id, index);
    }
    public bool has_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        return ir.has_member_decoration(id, index, decoration);
    }
    public void set_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration, uint argument = 0u)
    {
        ir.set_member_decoration(id, index, decoration, argument);
    }
    public void set_member_decoration_string(TypedID_TypeType id, uint index, Spv.Decoration decoration, CppString argument)
    {
        ir.set_member_decoration_string(id, index, decoration, argument);
    }
    public void unset_member_decoration(TypedID_TypeType id, uint index, Spv.Decoration decoration)
    {
        ir.unset_member_decoration(id, index, decoration);
    }
    public virtual CppString get_fallback_member_name(uint index)
    {
        return Std.join("_", index);
    }
    public CppVector<BufferRange> get_active_buffer_ranges(TypedID_TypeVariable id)
    {
        CppVector<BufferRange> ranges = new CppVector<BufferRange>();
        Compiler.BufferAccessHandler handler = new Compiler.BufferAccessHandler(this, ranges, ((uint)id));
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        return ranges;
    }
    public ulong get_declared_struct_size(SPIRType type)
    {
        if (type.member_types.empty())
        {
            throw new CompilerError("Declared struct in block cannot be empty.");
        }
        uint member_index = 0u;
        ulong highest_offset = 0UL;
        {
            for (uint i = 0u; i < unchecked((uint)type.member_types.size()); i++)
            {
                ulong offset = unchecked((ulong)type_struct_member_offset(type, i));
                if (offset > highest_offset)
                {
                    highest_offset = offset;
                    member_index = i;
                }
            }
        }
        ulong size = get_declared_struct_member_size(type, member_index);
        return highest_offset + size;
    }
    public ulong get_declared_struct_size_runtime_array(SPIRType type, ulong array_size)
    {
        if (type.member_types.empty())
        {
            throw new CompilerError("Declared struct in block cannot be empty.");
        }
        ulong size = get_declared_struct_size(type);
        var last_type = get__SPIRType(((uint)type.member_types.back()));
        if (!last_type.array.empty() && last_type.array_size_literal.back() && last_type.array.back() == 0u)
        {
            size += array_size * unchecked((ulong)type_struct_member_array_stride(type, unchecked((uint)(type.member_types.size() - 1UL))));
        }
        return size;
    }
    public ulong get_declared_struct_member_size(SPIRType struct_type, uint index)
    {
        if (struct_type.member_types.empty())
        {
            throw new CompilerError("Declared struct in block cannot be empty.");
        }
        var flags = get_member_decoration_bitset(((TypedID_TypeType)struct_type.self), index);
        var type = get__SPIRType(((uint)struct_type.member_types[unchecked((ulong)index)]));
        {
            switch (unchecked((int)type.basetype))
            {
                case unchecked((int)SPIRType.BaseType.Unknown):
                case unchecked((int)SPIRType.BaseType.Void):
                case unchecked((int)SPIRType.BaseType.Boolean):
                case unchecked((int)SPIRType.BaseType.AtomicCounter):
                case unchecked((int)SPIRType.BaseType.Image):
                case unchecked((int)SPIRType.BaseType.SampledImage):
                case unchecked((int)SPIRType.BaseType.Sampler):
                {
                    throw new CompilerError("Querying size for object with opaque size.");
                }
                default:
                {
                    break;
                }
            }
        }
        if (type.pointer && unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer))
        {
            if (type.pointer_depth > get__SPIRType(((uint)type.parent_type)).pointer_depth)
            {
                return 8UL;
            }
        }
        if (!type.array.empty())
        {
            bool array_size_literal = type.array_size_literal.back();
            uint array_size = array_size_literal ? type.array.back() : evaluate_constant_u32(type.array.back());
            return unchecked((ulong)(type_struct_member_array_stride(struct_type, index) * array_size));
        }
        else
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
        {
            return get_declared_struct_size(type);
        }
        else
        {
            uint vecsize = type.vecsize;
            uint columns = type.columns;
            if (columns == 1u)
            {
                ulong component_size = unchecked((ulong)(type.width / 8u));
                return unchecked((ulong)vecsize) * component_size;
            }
            else
            {
                uint matrix_stride = type_struct_member_matrix_stride(struct_type, index);
                if (flags.get(unchecked((uint)Spv.Decoration.DecorationRowMajor)))
                {
                    return unchecked((ulong)(matrix_stride * vecsize));
                }
                else
                if (flags.get(unchecked((uint)Spv.Decoration.DecorationColMajor)))
                {
                    return unchecked((ulong)(matrix_stride * columns));
                }
                else
                {
                    throw new CompilerError("Either row-major or column-major must be declared for matrices.");
                }
            }
        }
    }
    public UnorderedSet<TypedID_TypeVariable> get_active_interface_variables()
    {
        UnorderedSet<TypedID_TypeVariable> variables = new UnorderedSet<TypedID_TypeVariable>();
        Compiler.InterfaceVariableAccessHandler handler = new Compiler.InterfaceVariableAccessHandler(this, variables);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput))
            {
                return;
            }
            if (!this.interface_variable_exists_in_entry_point(((uint)@var.self)))
            {
                return;
            }
            if (((uint)@var.initializer) != ((uint)new TypedID_TypeNone(0u)) || unchecked((int)this.get_execution_model()) != unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
            {
                variables.insert(((TypedID_TypeVariable)@var.self));
            }
        });
        if (dummy_sampler_id != 0u)
        {
            variables.insert(new TypedID_TypeVariable(dummy_sampler_id));
        }
        return variables;
    }
    public void set_enabled_interface_variables(UnorderedSet<TypedID_TypeVariable> active_variables)
    {
        active_interface_variables.CopyFrom(active_variables);
        check_active_interface_variables = true;
    }
    public ShaderResources get_shader_resources()
    {
        return get_shader_resources_ptr(null);
    }
    public ShaderResources get_shader_resources(UnorderedSet<TypedID_TypeVariable> active_variables)
    {
        return get_shader_resources_ptr(active_variables);
    }
    public void set_remapped_variable_state(TypedID_TypeVariable id, bool remap_enable)
    {
        get__SPIRVariable(((uint)id)).remapped_variable = remap_enable;
    }
    public bool get_remapped_variable_state(TypedID_TypeVariable id)
    {
        return get__SPIRVariable(((uint)id)).remapped_variable;
    }
    public void set_subpass_input_remapped_components(TypedID_TypeVariable id, uint components)
    {
        get__SPIRVariable(((uint)id)).remapped_components = components;
    }
    public uint get_subpass_input_remapped_components(TypedID_TypeVariable id)
    {
        return get__SPIRVariable(((uint)id)).remapped_components;
    }
    public CppVector<EntryPoint> get_entry_points_and_stages()
    {
        CppVector<EntryPoint> entries = new CppVector<EntryPoint>();
        {
            foreach (Pair<TypedID_TypeFunction, SPIREntryPoint> entry in ir.entry_points)
            {
                entries.push_back(new EntryPoint { name = entry.second.orig_name, execution_model = entry.second.model });
            }
        }
        return entries;
    }
    public void set_entry_point(CppString name, Spv.ExecutionModel model)
    {
        var entry = get_entry_point(name, model);
        ir.default_entry_point = entry.self;
    }
    public void rename_entry_point(CppString old_name, CppString new_name, Spv.ExecutionModel model)
    {
        var entry = get_entry_point(old_name, model);
        entry.orig_name = new_name;
        entry.name = new_name;
    }
    public SPIREntryPoint get_entry_point(CppString name, Spv.ExecutionModel model)
    {
        var itr = Std.find_if(Std.begin(ir.entry_points), Std.end(ir.entry_points), (Pair<uint, SPIREntryPoint> entry) =>
        {
            return entry.second.orig_name == name && unchecked((int)entry.second.model) == unchecked((int)model);
        });
        if (itr == Std.end(ir.entry_points))
        {
            throw new CompilerError("Entry point does not exist.");
        }
        return itr.deref().second;
    }
    public CppString get_cleansed_entry_point_name(CppString name, Spv.ExecutionModel model)
    {
        return get_entry_point(name, model).name;
    }
    public void update_active_builtins()
    {
        active_input_builtins.reset();
        active_output_builtins.reset();
        cull_distance_count = 0u;
        clip_distance_count = 0u;
        Compiler.ActiveBuiltinHandler handler = new Compiler.ActiveBuiltinHandler(this);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput))
            {
                return;
            }
            if (!this.interface_variable_exists_in_entry_point(((uint)@var.self)))
            {
                return;
            }
            if (((uint)@var.initializer) != ((uint)new TypedID_TypeNone(0u)))
            {
                handler.add_if_builtin_or_block(((uint)@var.self));
            }
        });
    }
    public bool has_active_builtin(Spv.BuiltIn builtin, Spv.StorageClass storage)
    {
        Bitset flags = default;
        {
            switch (unchecked((int)storage))
            {
                case unchecked((int)Spv.StorageClass.StorageClassInput):
                {
                    flags = active_input_builtins;
                    break;
                }
                case unchecked((int)Spv.StorageClass.StorageClassOutput):
                {
                    flags = active_output_builtins;
                    break;
                }
                default:
                {
                    return false;
                }
            }
        }
        return flags.get(unchecked((uint)builtin));
    }
    public Bitset get_execution_mode_bitset()
    {
        return get_entry_point().flags;
    }
    public void unset_execution_mode(Spv.ExecutionMode mode)
    {
        var execution = get_entry_point();
        execution.flags.clear(unchecked((uint)mode));
    }
    public void set_execution_mode(Spv.ExecutionMode mode, uint arg0 = 0u, uint arg1 = 0u, uint arg2 = 0u)
    {
        var execution = get_entry_point();
        execution.flags.set(unchecked((uint)mode));
        {
            switch (unchecked((int)mode))
            {
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSize):
                {
                    execution.workgroup_size.x = arg0;
                    execution.workgroup_size.y = arg1;
                    execution.workgroup_size.z = arg2;
                    break;
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSizeId):
                {
                    execution.workgroup_size.id_x = arg0;
                    execution.workgroup_size.id_y = arg1;
                    execution.workgroup_size.id_z = arg2;
                    break;
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInvocations):
                {
                    execution.invocations = arg0;
                    break;
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputVertices):
                {
                    execution.output_vertices = arg0;
                    break;
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputPrimitivesEXT):
                {
                    execution.output_primitives = arg0;
                    break;
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeFPFastMathDefault):
                {
                    execution.fp_fast_math_defaults[arg0] = arg1;
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public uint get_execution_mode_argument(Spv.ExecutionMode mode, uint index = 0u)
    {
        var execution = get_entry_point();
        {
            switch (unchecked((int)mode))
            {
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSizeId):
                {
                    if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeLocalSizeId)))
                    {
                        {
                            switch (index)
                            {
                                case 0u:
                                {
                                    return execution.workgroup_size.id_x;
                                }
                                case 1u:
                                {
                                    return execution.workgroup_size.id_y;
                                }
                                case 2u:
                                {
                                    return execution.workgroup_size.id_z;
                                }
                                default:
                                {
                                    return 0u;
                                }
                            }
                        }
                    }
                    else
                    {
                        return 0u;
                    }
                    goto case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSize);
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSize):
                {
                    {
                        switch (index)
                        {
                            case 0u:
                            {
                                if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeLocalSizeId)) && execution.workgroup_size.id_x != 0u)
                                {
                                    return get__SPIRConstant(execution.workgroup_size.id_x).scalar(0u, 0u);
                                }
                                else
                                {
                                    return execution.workgroup_size.x;
                                }
                            }
                            case 1u:
                            {
                                if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeLocalSizeId)) && execution.workgroup_size.id_y != 0u)
                                {
                                    return get__SPIRConstant(execution.workgroup_size.id_y).scalar(0u, 0u);
                                }
                                else
                                {
                                    return execution.workgroup_size.y;
                                }
                            }
                            case 2u:
                            {
                                if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeLocalSizeId)) && execution.workgroup_size.id_z != 0u)
                                {
                                    return get__SPIRConstant(execution.workgroup_size.id_z).scalar(0u, 0u);
                                }
                                else
                                {
                                    return execution.workgroup_size.z;
                                }
                            }
                            default:
                            {
                                return 0u;
                            }
                        }
                    }
                    goto case unchecked((int)Spv.ExecutionMode.ExecutionModeInvocations);
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInvocations):
                {
                    return execution.invocations;
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputVertices):
                {
                    return execution.output_vertices;
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputPrimitivesEXT):
                {
                    return execution.output_primitives;
                }
                default:
                {
                    return 0u;
                }
            }
        }
    }
    public Spv.ExecutionModel get_execution_model()
    {
        var execution = get_entry_point();
        return execution.model;
    }
    public bool is_tessellation_shader()
    {
        return Compiler.is_tessellation_shader(get_execution_model());
    }
    public bool is_tessellating_triangles()
    {
        return get_execution_mode_bitset().get(unchecked((uint)Spv.ExecutionMode.ExecutionModeTriangles));
    }
    public uint get_work_group_size_specialization_constants(SpecializationConstant x, SpecializationConstant y, SpecializationConstant z)
    {
        var execution = get_entry_point();
        x.CopyFrom(new SpecializationConstant { id = new TypedID_TypeConstant(0u), constant_id = 0u });
        y.CopyFrom(new SpecializationConstant { id = new TypedID_TypeConstant(0u), constant_id = 0u });
        z.CopyFrom(new SpecializationConstant { id = new TypedID_TypeConstant(0u), constant_id = 0u });
        if (execution.workgroup_size.constant != 0u)
        {
            var c = get__SPIRConstant(execution.workgroup_size.constant);
            if (((uint)c.m.c[0].id[0]) != ((uint)new TypedID_TypeNone(0u)))
            {
                x.id = ((TypedID_TypeConstant)c.m.c[0].id[0]);
                x.constant_id = get_decoration(c.m.c[0].id[0], Spv.Decoration.DecorationSpecId);
            }
            if (((uint)c.m.c[0].id[1]) != ((uint)new TypedID_TypeNone(0u)))
            {
                y.id = ((TypedID_TypeConstant)c.m.c[0].id[1]);
                y.constant_id = get_decoration(c.m.c[0].id[1], Spv.Decoration.DecorationSpecId);
            }
            if (((uint)c.m.c[0].id[2]) != ((uint)new TypedID_TypeNone(0u)))
            {
                z.id = ((TypedID_TypeConstant)c.m.c[0].id[2]);
                z.constant_id = get_decoration(c.m.c[0].id[2], Spv.Decoration.DecorationSpecId);
            }
        }
        else
        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeLocalSizeId)))
        {
            var cx = get__SPIRConstant(execution.workgroup_size.id_x);
            if (cx.specialization)
            {
                x.id = new TypedID_TypeConstant(execution.workgroup_size.id_x);
                x.constant_id = get_decoration(new TypedID_TypeNone(execution.workgroup_size.id_x), Spv.Decoration.DecorationSpecId);
            }
            var cy = get__SPIRConstant(execution.workgroup_size.id_y);
            if (cy.specialization)
            {
                y.id = new TypedID_TypeConstant(execution.workgroup_size.id_y);
                y.constant_id = get_decoration(new TypedID_TypeNone(execution.workgroup_size.id_y), Spv.Decoration.DecorationSpecId);
            }
            var cz = get__SPIRConstant(execution.workgroup_size.id_z);
            if (cz.specialization)
            {
                z.id = new TypedID_TypeConstant(execution.workgroup_size.id_z);
                z.constant_id = get_decoration(new TypedID_TypeNone(execution.workgroup_size.id_z), Spv.Decoration.DecorationSpecId);
            }
        }
        return execution.workgroup_size.constant;
    }
    public TypedID_TypeVariable build_dummy_sampler_for_combined_images()
    {
        Compiler.DummySamplerForCombinedImageHandler handler = new Compiler.DummySamplerForCombinedImageHandler(this);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        if (handler.need_dummy_sampler)
        {
            uint offset = ir.increase_bound_by(3u);
            var type_id = offset + 0u;
            var ptr_type_id = offset + 1u;
            var var_id = offset + 2u;
            var sampler = set__SPIRType_X(type_id, Spv.Op.OpTypeSampler);
            sampler.basetype = SPIRType.BaseType.Sampler;
            var ptr_sampler = set__SPIRType_X(ptr_type_id, Spv.Op.OpTypePointer);
            ptr_sampler.CopyFrom(sampler);
            ptr_sampler.self = new TypedID_TypeNone(type_id);
            ptr_sampler.storage = Spv.StorageClass.StorageClassUniformConstant;
            ptr_sampler.pointer = true;
            ptr_sampler.parent_type = new TypedID_TypeType(type_id);
            set__SPIRVariable_X(var_id, ptr_type_id, Spv.StorageClass.StorageClassUniformConstant, 0);
            set_name(new TypedID_TypeNone(var_id), new CppString("SPIRV_Cross_DummySampler"));
            dummy_sampler_id = var_id;
            return new TypedID_TypeVariable(var_id);
        }
        else
        {
            return new TypedID_TypeVariable(0u);
        }
    }
    public void build_combined_image_samplers()
    {
        ir.for_each_typed_id__SPIRFunction_lambda((uint _p, SPIRFunction func) =>
        {
            func.combined_parameters.clear();
            func.shadow_arguments.clear();
            func.do_combined_parameters = true;
        });
        combined_image_samplers.clear();
        Compiler.CombinedImageSamplerHandler handler = new Compiler.CombinedImageSamplerHandler(this);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
    }
    public CppVector<CombinedImageSampler> get_combined_image_samplers()
    {
        return combined_image_samplers;
    }
    public void set_variable_type_remap_callback(Callback_126331 cb)
    {
        variable_remap_callback = cb;
    }
    public CppVector<SpecializationConstant> get_specialization_constants()
    {
        CppVector<SpecializationConstant> spec_consts = new CppVector<SpecializationConstant>();
        ir.for_each_typed_id__SPIRConstant_lambda((uint _p, SPIRConstant c) =>
        {
            if (c.specialization && this.has_decoration(c.self, Spv.Decoration.DecorationSpecId))
            {
                spec_consts.push_back(new SpecializationConstant { id = ((TypedID_TypeConstant)c.self), constant_id = this.get_decoration(c.self, Spv.Decoration.DecorationSpecId) });
            }
        });
        return spec_consts;
    }
    public SPIRConstant get_constant(TypedID_TypeConstant id)
    {
        return get__SPIRConstant(((uint)id));
    }
    public uint get_current_id_bound()
    {
        return unchecked((uint)ir.ids.size());
    }
    public uint type_struct_member_offset(SPIRType type, uint index)
    {
        var type_meta = ir.find_meta(type.self);
        if (type_meta != null)
        {
            var dec = type_meta.members[unchecked((ulong)index)];
            if (dec.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationOffset)))
            {
                return dec.offset;
            }
            else
            {
                throw new CompilerError("Struct member does not have Offset set.");
            }
        }
        else
        {
            throw new CompilerError("Struct member does not have Offset set.");
        }
    }
    public uint type_struct_member_array_stride(SPIRType type, uint index)
    {
        var type_meta = ir.find_meta(new TypedID_TypeNone(type.member_types[unchecked((ulong)index)]));
        if (type_meta != null)
        {
            var dec = type_meta.decoration;
            if (dec.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationArrayStride)))
            {
                return dec.array_stride;
            }
            else
            {
                throw new CompilerError("Struct member does not have ArrayStride set.");
            }
        }
        else
        {
            throw new CompilerError("Struct member does not have ArrayStride set.");
        }
    }
    public uint type_struct_member_matrix_stride(SPIRType type, uint index)
    {
        var type_meta = ir.find_meta(type.self);
        if (type_meta != null)
        {
            var dec = type_meta.members[unchecked((ulong)index)];
            if (dec.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationMatrixStride)))
            {
                return dec.matrix_stride;
            }
            else
            {
                throw new CompilerError("Struct member does not have MatrixStride set.");
            }
        }
        else
        {
            throw new CompilerError("Struct member does not have MatrixStride set.");
        }
    }
    public bool get_binary_offset_for_decoration(TypedID_TypeVariable id, Spv.Decoration decoration, ref uint word_offset)
    {
        var m = ir.find_meta(new TypedID_TypeNone(id));
        if (!(m != null))
        {
            return false;
        }
        var word_offsets = m.decoration_word_offset;
        var itr = word_offsets.find(unchecked((uint)decoration));
        if (itr == Std.end(word_offsets))
        {
            return false;
        }
        word_offset = itr.deref().second;
        return true;
    }
    public bool buffer_is_hlsl_counter_buffer(TypedID_TypeVariable id)
    {
        var m = ir.find_meta(new TypedID_TypeNone(id));
        return m != null && m.hlsl_is_magic_counter_buffer;
    }
    public bool buffer_get_hlsl_counter_buffer(TypedID_TypeVariable id, ref uint counter_id)
    {
        var m = ir.find_meta(new TypedID_TypeNone(id));
        if (m != null && m.hlsl_magic_counter_buffer != 0u)
        {
            counter_id = m.hlsl_magic_counter_buffer;
            return true;
        }
        else
        {
            return false;
        }
    }
    public CppVector<Spv.Capability> get_declared_capabilities()
    {
        return ir.declared_capabilities;
    }
    public CppVector<CppString> get_declared_extensions()
    {
        return ir.declared_extensions;
    }
    public CppString get_remapped_declared_block_name(TypedID_TypeVariable id)
    {
        return get_remapped_declared_block_name(((uint)id), false);
    }
    public Bitset get_buffer_block_flags(TypedID_TypeVariable id)
    {
        return ir.get_buffer_block_flags(get__SPIRVariable(((uint)id)));
    }
    public bool is_position_invariant()
    {
        return position_invariant;
    }
    public ParsedIR get_ir()
    {
        return ir;
    }
    public uint evaluate_constant_u32(uint id)
    {
        {
            var c = maybe_get__SPIRConstant(id);
            if (c != null)
            {
                return c.scalar(0u, 0u);
            }
            else
            {
                return evaluate_spec_constant_u32(get__SPIRConstantOp(id));
            }
        }
    }
    public Ptr<uint> stream(Instruction instr)
    {
        if (!(instr.length != 0u))
        {
            return null;
        }
        if (instr.is_embedded())
        {
            var embedded = (EmbeddedInstruction)instr;
            return embedded.ops.data();
        }
        else
        {
            if (unchecked((ulong)(instr.offset + instr.length)) > ir.spirv.size())
            {
                throw new CompilerError("Compiler::stream() out of range.");
            }
            return ir.spirv.ptr_at(unchecked((ulong)instr.offset));
        }
    }
    public Ptr<uint> stream_mutable(Instruction instr)
    {
        return stream(instr);
    }
    public ParsedIR ir = new ParsedIR();
    public CppVector<uint> global_variables = new CppVector<uint>();
    public CppVector<uint> aliased_variables = new CppVector<uint>();
    public CppVector<uint> buffer_pointer_variables = new CppVector<uint>();
    public SPIRFunction current_function = null;
    public SPIRBlock current_block = null;
    public uint current_loop_level = 0u;
    public UnorderedSet<TypedID_TypeVariable> active_interface_variables = new UnorderedSet<TypedID_TypeVariable>();
    public bool check_active_interface_variables = false;
    public void add_loop_level()
    {
        current_loop_level++;
    }
    public void set_initializers(SPIRExpression e)
    {
        e.emitted_loop_level = current_loop_level;
    }
    public SPIRBlock get__SPIRBlock(uint id)
    {
        return Globals.variant_get__SPIRBlock(ir.ids[unchecked((ulong)id)]);
    }
    public uint get_pointee_type_id(uint type_id)
    {
        var p_type = get__SPIRType(type_id);
        if (p_type.pointer)
        {
            type_id = ((uint)p_type.parent_type);
        }
        return type_id;
    }
    public SPIRType get_pointee_type(SPIRType type)
    {
        var p_type = type;
        if (p_type.pointer)
        {
            p_type = get__SPIRType(((uint)p_type.parent_type));
        }
        return p_type;
    }
    public SPIRType get_pointee_type(uint type_id)
    {
        return get_pointee_type(get__SPIRType(type_id));
    }
    public uint get_variable_data_type_id(SPIRVariable @var)
    {
        if (@var.phi_variable || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassAtomicCounter))
        {
            return ((uint)@var.basetype);
        }
        return get_pointee_type_id(((uint)@var.basetype));
    }
    public SPIRType get_variable_data_type(SPIRVariable @var)
    {
        return get__SPIRType(get_variable_data_type_id(@var));
    }
    public SPIRType get_variable_element_type(SPIRVariable @var)
    {
        SPIRType type = get_variable_data_type(@var);
        if (is_array(type))
        {
            type = get__SPIRType(((uint)type.parent_type));
        }
        return type;
    }
    public void set_member_qualified_name(uint type_id, uint index, CppString name)
    {
        ir.meta[new TypedID_TypeNone(type_id)].members.resize(Std.max(ir.meta[new TypedID_TypeNone(type_id)].members.size(), unchecked((ulong)index) + 1UL));
        ir.meta[new TypedID_TypeNone(type_id)].members[unchecked((ulong)index)].qualified_alias = name;
    }
    public void set_qualified_name(uint id, CppString name)
    {
        ir.meta[new TypedID_TypeNone(id)].decoration.qualified_alias = name;
    }
    public bool is_sampled_image_type(SPIRType type)
    {
        return (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.SampledImage)) && type.image.sampled == 1u && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimBuffer);
    }
    public SPIREntryPoint get_entry_point()
    {
        return ir.entry_points.find(ir.default_entry_point).deref().second;
    }
    public static bool is_tessellation_shader(Spv.ExecutionModel model)
    {
        return unchecked((int)model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl) || unchecked((int)model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation);
    }
    public virtual CppString to_name(uint id, bool allow_alias = true)
    {
        if (allow_alias && unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeType))
        {
            var type = get__SPIRType(id);
            if (((uint)type.type_alias) != 0u)
            {
                if (!has_extended_decoration(((uint)type.type_alias), ExtendedDecorations.SPIRVCrossDecorationBufferBlockRepacked))
                {
                    return to_name(((uint)type.type_alias), true);
                }
            }
        }
        var alias = ir.get_name(new TypedID_TypeNone(id));
        if (alias.empty())
        {
            return Std.join("_", id);
        }
        else
        {
            return alias;
        }
    }
    public bool is_builtin_variable(SPIRVariable @var)
    {
        var m = ir.find_meta(@var.self);
        if (@var.compat_builtin || m != null && m.decoration.builtin)
        {
            return true;
        }
        else
        {
            return is_builtin_type(get__SPIRType(((uint)@var.basetype)));
        }
    }
    public bool is_builtin_type(SPIRType type)
    {
        var type_meta = ir.find_meta(type.self);
        if (type_meta != null)
        {
            {
                foreach (Meta.Decoration m in type_meta.members)
                {
                    if (m.builtin)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public bool is_hidden_variable(SPIRVariable @var, bool include_builtins = false)
    {
        if (is_builtin_variable(@var) && !include_builtins || @var.remapped_variable)
        {
            return true;
        }
        if (Std.find_if(Std.begin(combined_image_samplers), Std.end(combined_image_samplers), (CombinedImageSampler samp) =>
        {
            return ((uint)samp.combined_id) == ((uint)@var.self);
        }) != Std.end(combined_image_samplers))
        {
            return false;
        }
        if (ir.get_spirv_version() >= 66560u && !ir.is_library_module && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassGeneric) && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && !interface_variable_exists_in_entry_point(((uint)@var.self)))
        {
            return true;
        }
        return check_active_interface_variables && Globals.storage_class_is_interface(@var.storage) && active_interface_variables.find(((TypedID_TypeVariable)@var.self)) == Std.end(active_interface_variables);
    }
    public bool is_immutable(uint id)
    {
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeVariable))
        {
            var @var = get__SPIRVariable(id);
            bool pointer_to_const = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant);
            return pointer_to_const || @var.phi_variable || !expression_is_lvalue(id);
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeAccessChain))
        {
            return get__SPIRAccessChain(id).immutable;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeExpression))
        {
            return get__SPIRExpression(id).immutable;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeConstant) || unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeConstantOp) || unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeUndef))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool is_member_builtin(SPIRType type, uint index, Ptr<Spv.BuiltIn> builtin)
    {
        var type_meta = ir.find_meta(type.self);
        if (type_meta != null)
        {
            var memb = type_meta.members;
            if (unchecked((ulong)index) < memb.size() && memb[unchecked((ulong)index)].builtin)
            {
                if (builtin != null)
                {
                    builtin.Value = memb[unchecked((ulong)index)].builtin_type;
                }
                return true;
            }
        }
        return false;
    }
    public bool is_scalar(SPIRType type)
    {
        return unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Struct) && type.vecsize == 1u && type.columns == 1u;
    }
    public bool is_vector(SPIRType type)
    {
        return type.vecsize > 1u && type.columns == 1u;
    }
    public bool is_matrix(SPIRType type)
    {
        return type.vecsize > 1u && type.columns > 1u;
    }
    public bool is_array(SPIRType type)
    {
        return unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypeArray) || unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypeRuntimeArray);
    }
    public bool is_pointer(SPIRType type)
    {
        return (unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypePointer) || unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypeUntypedPointerKHR)) && unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Unknown);
    }
    public bool is_physical_pointer(SPIRType type)
    {
        return (unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypePointer) || unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypeUntypedPointerKHR)) && unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer);
    }
    public bool is_physical_or_buffer_pointer(SPIRType type)
    {
        return (unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypePointer) || unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypeUntypedPointerKHR)) && (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassWorkgroup) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant));
    }
    public bool is_physical_pointer_to_buffer_block(SPIRType type)
    {
        return is_physical_pointer(type) && ((uint)get_pointee_type(type).self) == ((uint)type.parent_type) && (has_decoration(type.self, Spv.Decoration.DecorationBlock) || has_decoration(type.self, Spv.Decoration.DecorationBufferBlock));
    }
    public static bool is_runtime_size_array(SPIRType type)
    {
        return unchecked((int)type.op) == unchecked((int)Spv.Op.OpTypeRuntimeArray);
    }
    public bool is_struct_wrapped_opaque_descriptor_array(SPIRType type)
    {
        return unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct) && has_decoration(type.self, Spv.Decoration.DecorationBlock) && type.member_types.size() == 1UL && type_is_opaque_value(get__SPIRType(((uint)type.member_types.front()))) && Compiler.is_runtime_size_array(get__SPIRType(((uint)type.member_types.front())));
    }
    public uint expression_type_id(uint id)
    {
        {
            switch (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()))
            {
                case unchecked((int)Types.TypeVariable):
                {
                    return ((uint)get__SPIRVariable(id).basetype);
                }
                case unchecked((int)Types.TypeExpression):
                {
                    return ((uint)get__SPIRExpression(id).expression_type);
                }
                case unchecked((int)Types.TypeConstant):
                {
                    return ((uint)get__SPIRConstant(id).constant_type);
                }
                case unchecked((int)Types.TypeConstantOp):
                {
                    return ((uint)get__SPIRConstantOp(id).basetype);
                }
                case unchecked((int)Types.TypeUndef):
                {
                    return ((uint)get__SPIRUndef(id).basetype);
                }
                case unchecked((int)Types.TypeCombinedImageSampler):
                {
                    return ((uint)get__SPIRCombinedImageSampler(id).combined_type);
                }
                case unchecked((int)Types.TypeAccessChain):
                {
                    return ((uint)get__SPIRAccessChain(id).basetype);
                }
                case unchecked((int)Types.TypeConstantData):
                {
                    return ((uint)get__SPIRConstantData(id).type_id);
                }
                default:
                {
                    throw new CompilerError("Cannot resolve expression type.");
                }
            }
        }
    }
    public SPIRType expression_type(uint id)
    {
        return get__SPIRType(expression_type_id(id));
    }
    public bool expression_is_lvalue(uint id)
    {
        var type = expression_type(id);
        {
            switch (unchecked((int)type.basetype))
            {
                case unchecked((int)SPIRType.BaseType.SampledImage):
                case unchecked((int)SPIRType.BaseType.Image):
                case unchecked((int)SPIRType.BaseType.Sampler):
                {
                    return false;
                }
                default:
                {
                    return true;
                }
            }
        }
    }
    public bool variable_storage_is_aliased(SPIRVariable v)
    {
        var type = get__SPIRType(((uint)v.basetype));
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Void))
        {
            return true;
        }
        bool ssbo = unchecked((int)v.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || ir.meta[type.self].decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBufferBlock));
        bool image = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image);
        bool counter = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.AtomicCounter);
        bool buffer_reference = unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer);
        bool shared_block = unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassWorkgroup) && has_decoration(type.self, Spv.Decoration.DecorationBlock);
        bool is_restrict = default;
        if (ssbo)
        {
            is_restrict = ir.get_buffer_block_flags(v).get(unchecked((uint)Spv.Decoration.DecorationRestrict));
        }
        else
        if (shared_block)
        {
            is_restrict = !has_decoration(v.self, Spv.Decoration.DecorationAliased);
        }
        else
        {
            is_restrict = has_decoration(v.self, Spv.Decoration.DecorationRestrict);
        }
        return !is_restrict && (ssbo || image || counter || buffer_reference || shared_block);
    }
    public SPIRVariable maybe_get_backing_variable(uint chain)
    {
        var @var = maybe_get__SPIRVariable(chain);
        if (!(@var != null))
        {
            var cexpr = maybe_get__SPIRExpression(chain);
            if (cexpr != null)
            {
                @var = maybe_get__SPIRVariable(((uint)cexpr.loaded_from));
                if (!(@var != null) && ((uint)cexpr.loaded_from) != chain)
                {
                    @var = maybe_get_backing_variable(((uint)cexpr.loaded_from));
                }
            }
            var access_chain = maybe_get__SPIRAccessChain(chain);
            if (access_chain != null)
            {
                @var = maybe_get__SPIRVariable(((uint)access_chain.loaded_from));
                if (!(@var != null) && ((uint)access_chain.loaded_from) != chain)
                {
                    @var = maybe_get_backing_variable(((uint)access_chain.loaded_from));
                }
            }
        }
        return @var;
    }
    public SPIRExpression maybe_get_backing_buffer_pointer(uint chain)
    {
        var expr = maybe_get__SPIRExpression(chain);
        while (expr != null && !expr.buffer_pointer && ((uint)expr.loaded_from) != 0u)
        {
            expr = maybe_get__SPIRExpression(((uint)expr.loaded_from));
        }
        return expr != null && expr.buffer_pointer ? expr : null;
    }
    public void register_read(uint expr, uint chain, bool forwarded)
    {
        var e = get__SPIRExpression(expr);
        var @var = maybe_get_backing_variable(chain);
        var buffer_pointer = maybe_get_backing_buffer_pointer(chain);
        if (@var != null)
        {
            e.loaded_from = @var.self;
            if (forwarded && !is_immutable(((uint)@var.self)))
            {
                @var.dependees.push_back(e.self);
            }
            if (@var != null && @var.parameter != null)
            {
                @var.parameter.read_count++;
            }
        }
        else
        if (buffer_pointer != null)
        {
            e.loaded_from = buffer_pointer.self;
            if (forwarded && !is_immutable(((uint)buffer_pointer.self)))
            {
                buffer_pointer.buffer_pointer_dependees.push_back(e.self);
            }
        }
    }
    public void register_write(uint chain)
    {
        var @var = maybe_get__SPIRVariable(chain);
        if (!(@var != null))
        {
            var expr = maybe_get__SPIRExpression(chain);
            if (expr != null && ((uint)expr.loaded_from) != 0u)
            {
                @var = maybe_get__SPIRVariable(((uint)expr.loaded_from));
            }
            var access_chain = maybe_get__SPIRAccessChain(chain);
            if (access_chain != null && ((uint)access_chain.loaded_from) != 0u)
            {
                @var = maybe_get__SPIRVariable(((uint)access_chain.loaded_from));
            }
        }
        var buffer_pointer = maybe_get_backing_buffer_pointer(chain);
        var chain_type = expression_type(chain);
        if (@var != null)
        {
            bool check_argument_storage_qualifier = true;
            var type = expression_type(chain);
            if (get_variable_data_type(@var).pointer)
            {
                flush_all_active_variables();
                if (type.pointer_depth == 1u)
                {
                    check_argument_storage_qualifier = false;
                }
            }
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer) || variable_storage_is_aliased(@var))
            {
                flush_all_aliased_variables();
            }
            else
            if (@var != null)
            {
                flush_dependees(@var);
            }
            if (check_argument_storage_qualifier && @var.parameter != null && @var.parameter.write_count == 0u)
            {
                @var.parameter.write_count++;
                force_recompile();
            }
        }
        else
        if (buffer_pointer != null)
        {
            flush_dependees(buffer_pointer);
        }
        else
        if (chain_type.pointer)
        {
            flush_all_active_variables();
        }
    }
    public bool is_continue(uint next)
    {
        return (unchecked((int)ir.block_meta[unchecked((ulong)next)]) & unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_CONTINUE_BIT)) != 0;
    }
    public bool is_single_block_loop(uint next)
    {
        var block = get__SPIRBlock(next);
        return unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop) && ((uint)block.continue_block) == ((uint)new TypedID_TypeNone(next));
    }
    public bool is_break(uint next)
    {
        return (unchecked((int)ir.block_meta[unchecked((ulong)next)]) & (unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_LOOP_MERGE_BIT) | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_MULTISELECT_MERGE_BIT))) != 0;
    }
    public bool is_loop_break(uint next)
    {
        return (unchecked((int)ir.block_meta[unchecked((ulong)next)]) & unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_LOOP_MERGE_BIT)) != 0;
    }
    public bool is_conditional(uint next)
    {
        return (unchecked((int)ir.block_meta[unchecked((ulong)next)]) & (unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_SELECTION_MERGE_BIT) | unchecked((int)ParsedIR.BlockMetaFlagBits.BLOCK_META_MULTISELECT_MERGE_BIT))) != 0;
    }
    public void flush_dependees(SPIRVariable @var)
    {
        {
            foreach (TypedID_TypeNone expr in @var.dependees)
            {
                invalid_expressions.insert(((uint)expr));
            }
        }
        @var.dependees.clear();
    }
    public void flush_dependees(SPIRExpression expr)
    {
        {
            foreach (TypedID_TypeNone dep in expr.buffer_pointer_dependees)
            {
                invalid_expressions.insert(((uint)dep));
            }
        }
        expr.buffer_pointer_dependees.clear();
    }
    public void flush_all_active_variables()
    {
        {
            var __r0 = current_function.local_variables;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeVariable v = ref __r0[__i1];
                flush_dependees(get__SPIRVariable(((uint)v)));
            }
        }
        {
            foreach (SPIRFunction.Parameter arg in current_function.arguments)
            {
                flush_dependees(get__SPIRVariable(((uint)arg.id)));
            }
        }
        {
            foreach (uint global in global_variables)
            {
                flush_dependees(get__SPIRVariable(global));
            }
        }
        {
            foreach (uint global in buffer_pointer_variables)
            {
                flush_dependees(get__SPIRExpression(global));
            }
        }
        flush_all_aliased_variables();
    }
    public void flush_control_dependent_expressions(uint block_id)
    {
        var block = get__SPIRBlock(block_id);
        {
            var __r0 = block.invalidate_expressions;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone expr = ref __r0[__i1];
                invalid_expressions.insert(((uint)expr));
            }
        }
        block.invalidate_expressions.clear();
    }
    public void flush_all_atomic_capable_variables()
    {
        {
            foreach (uint global in global_variables)
            {
                flush_dependees(get__SPIRVariable(global));
            }
        }
        {
            foreach (uint global in buffer_pointer_variables)
            {
                flush_dependees(get__SPIRExpression(global));
            }
        }
        flush_all_aliased_variables();
    }
    public void flush_all_aliased_variables()
    {
        {
            foreach (uint aliased in aliased_variables)
            {
                flush_dependees(get__SPIRVariable(aliased));
            }
        }
    }
    public void register_global_read_dependencies(SPIRBlock block, uint id)
    {
        {
            foreach (Instruction i in block.ops)
            {
                var ops = stream(i);
                var op = unchecked((Spv.Op)i.op);
                {
                    switch (unchecked((int)op))
                    {
                        case unchecked((int)Spv.Op.OpFunctionCall):
                        {
                            {
                                uint func = ops[2];
                                register_global_read_dependencies(get__SPIRFunction(func), id);
                                break;
                            }
                        }
                        case unchecked((int)Spv.Op.OpLoad):
                        case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                        case unchecked((int)Spv.Op.OpCooperativeVectorLoadNV):
                        case unchecked((int)Spv.Op.OpImageRead):
                        {
                            {
                                var @var = maybe_get_backing_variable(ops[2]);
                                if (@var != null && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction))
                                {
                                    var type = get__SPIRType(((uint)@var.basetype));
                                    if (unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Image) && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimSubpassData))
                                    {
                                        @var.dependees.push_back(new TypedID_TypeNone(id));
                                    }
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
        }
    }
    public void register_global_read_dependencies(SPIRFunction func, uint id)
    {
        {
            foreach (TypedID_TypeBlock block in func.blocks)
            {
                register_global_read_dependencies(get__SPIRBlock(((uint)block)), id);
            }
        }
    }
    public UnorderedSet<uint> invalid_expressions = new UnorderedSet<uint>();
    public void update_name_cache(UnorderedSet<CppString> cache, ref CppString name)
    {
        update_name_cache(cache, cache, ref name);
    }
    public void update_name_cache(UnorderedSet<CppString> cache_primary, UnorderedSet<CppString> cache_secondary, ref CppString name)
    {
        if (name.empty())
        {
            return;
        }
        var find_name = (CppString n) =>
        {
            if (cache_primary.find(n) != Std.end(cache_primary))
            {
                return true;
            }
            if (cache_primary != cache_secondary)
            {
                if (cache_secondary.find(n) != Std.end(cache_secondary))
                {
                    return true;
                }
            }
            return false;
        };
        var insert_name = (CppString n) =>
        {
            cache_primary.insert(n);
        };
        if (!find_name(name))
        {
            insert_name(name);
            return;
        }
        uint counter = 0u;
        var tmpname = name;
        bool use_linked_underscore = true;
        if (tmpname == "_")
        {
            tmpname += "0";
        }
        else
        if (unchecked((int)tmpname.back()) == 95)
        {
            use_linked_underscore = false;
        }
        do
        {
            counter++;
            name = tmpname + (use_linked_underscore ? "_" : "") + Globals.convert_to_string__uint__0(counter);
        }
        while (find_name(name));
        insert_name(name);
    }
    public bool function_is_pure(SPIRFunction func)
    {
        {
            foreach (TypedID_TypeBlock block in func.blocks)
            {
                if (!block_is_pure(get__SPIRBlock(((uint)block))))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public bool block_is_pure(SPIRBlock block)
    {
        if (unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.Kill) || unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.TerminateRay) || unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.IgnoreIntersection) || unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.EmitMeshTasks) || unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.ShaderAbort))
        {
            return false;
        }
        {
            foreach (Instruction i in block.ops)
            {
                var ops = stream(i);
                var op = unchecked((Spv.Op)i.op);
                {
                    switch (unchecked((int)op))
                    {
                        case unchecked((int)Spv.Op.OpFunctionCall):
                        {
                            {
                                uint func = ops[2];
                                if (!function_is_pure(get__SPIRFunction(func)))
                                {
                                    return false;
                                }
                                break;
                            }
                        }
                        case unchecked((int)Spv.Op.OpCopyMemory):
                        case unchecked((int)Spv.Op.OpStore):
                        case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                        {
                            {
                                var type = expression_type(ops[0]);
                                if (unchecked((int)type.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction))
                                {
                                    return false;
                                }
                                break;
                            }
                        }
                        case unchecked((int)Spv.Op.OpImageWrite):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpAtomicLoad):
                        case unchecked((int)Spv.Op.OpAtomicStore):
                        case unchecked((int)Spv.Op.OpAtomicExchange):
                        case unchecked((int)Spv.Op.OpAtomicCompareExchange):
                        case unchecked((int)Spv.Op.OpAtomicCompareExchangeWeak):
                        case unchecked((int)Spv.Op.OpAtomicIIncrement):
                        case unchecked((int)Spv.Op.OpAtomicIDecrement):
                        case unchecked((int)Spv.Op.OpAtomicIAdd):
                        case unchecked((int)Spv.Op.OpAtomicISub):
                        case unchecked((int)Spv.Op.OpAtomicSMin):
                        case unchecked((int)Spv.Op.OpAtomicUMin):
                        case unchecked((int)Spv.Op.OpAtomicSMax):
                        case unchecked((int)Spv.Op.OpAtomicUMax):
                        case unchecked((int)Spv.Op.OpAtomicAnd):
                        case unchecked((int)Spv.Op.OpAtomicOr):
                        case unchecked((int)Spv.Op.OpAtomicXor):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpEndPrimitive):
                        case unchecked((int)Spv.Op.OpEmitStreamVertex):
                        case unchecked((int)Spv.Op.OpEndStreamPrimitive):
                        case unchecked((int)Spv.Op.OpEmitVertex):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpSetMeshOutputsEXT):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpControlBarrier):
                        case unchecked((int)Spv.Op.OpMemoryBarrier):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpReportIntersectionKHR):
                        case unchecked((int)Spv.Op.OpIgnoreIntersectionNV):
                        case unchecked((int)Spv.Op.OpTerminateRayNV):
                        case unchecked((int)Spv.Op.OpTraceNV):
                        case unchecked((int)Spv.Op.OpTraceRayKHR):
                        case unchecked((int)Spv.Op.OpExecuteCallableNV):
                        case unchecked((int)Spv.Op.OpExecuteCallableKHR):
                        case unchecked((int)Spv.Op.OpRayQueryInitializeKHR):
                        case unchecked((int)Spv.Op.OpRayQueryTerminateKHR):
                        case unchecked((int)Spv.Op.OpRayQueryGenerateIntersectionKHR):
                        case unchecked((int)Spv.Op.OpRayQueryConfirmIntersectionKHR):
                        case unchecked((int)Spv.Op.OpRayQueryProceedKHR):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpDemoteToHelperInvocationEXT):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpTensorReadARM):
                        {
                            return false;
                        }
                        case unchecked((int)Spv.Op.OpExtInst):
                        {
                            {
                                uint extension_set = ops[2];
                                if (unchecked((int)get__SPIRExtension(extension_set).ext) == unchecked((int)SPIRExtension.Extension.GLSL))
                                {
                                    var op_450 = unchecked((GLSLstd450)ops[3]);
                                    {
                                        switch (unchecked((int)op_450))
                                        {
                                            case unchecked((int)GLSLstd450.GLSLstd450Modf):
                                            case unchecked((int)GLSLstd450.GLSLstd450Frexp):
                                            {
                                                {
                                                    var type = expression_type(ops[5]);
                                                    if (unchecked((int)type.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction))
                                                    {
                                                        return false;
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
        }
        return true;
    }
    public bool function_is_control_dependent(SPIRFunction func)
    {
        {
            foreach (TypedID_TypeBlock block in func.blocks)
            {
                if (block_is_control_dependent(get__SPIRBlock(((uint)block))))
                {
                    return true;
                }
            }
        }
        return false;
    }
    public bool block_is_control_dependent(SPIRBlock block)
    {
        {
            foreach (Instruction i in block.ops)
            {
                var ops = stream(i);
                var op = unchecked((Spv.Op)i.op);
                {
                    switch (unchecked((int)op))
                    {
                        case unchecked((int)Spv.Op.OpFunctionCall):
                        {
                            {
                                uint func = ops[2];
                                if (function_is_control_dependent(get__SPIRFunction(func)))
                                {
                                    return true;
                                }
                                break;
                            }
                        }
                        case unchecked((int)Spv.Op.OpDPdx):
                        case unchecked((int)Spv.Op.OpDPdxCoarse):
                        case unchecked((int)Spv.Op.OpDPdxFine):
                        case unchecked((int)Spv.Op.OpDPdy):
                        case unchecked((int)Spv.Op.OpDPdyCoarse):
                        case unchecked((int)Spv.Op.OpDPdyFine):
                        case unchecked((int)Spv.Op.OpFwidth):
                        case unchecked((int)Spv.Op.OpFwidthCoarse):
                        case unchecked((int)Spv.Op.OpFwidthFine):
                        case unchecked((int)Spv.Op.OpImageSampleImplicitLod):
                        case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                        case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                        case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                        case unchecked((int)Spv.Op.OpImageSparseSampleImplicitLod):
                        case unchecked((int)Spv.Op.OpImageSparseSampleDrefImplicitLod):
                        case unchecked((int)Spv.Op.OpImageSparseSampleProjImplicitLod):
                        case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefImplicitLod):
                        case unchecked((int)Spv.Op.OpImageQueryLod):
                        case unchecked((int)Spv.Op.OpImageDrefGather):
                        case unchecked((int)Spv.Op.OpImageGather):
                        case unchecked((int)Spv.Op.OpImageSparseDrefGather):
                        case unchecked((int)Spv.Op.OpImageSparseGather):
                        case unchecked((int)Spv.Op.OpGroupNonUniformElect):
                        case unchecked((int)Spv.Op.OpGroupNonUniformAll):
                        case unchecked((int)Spv.Op.OpGroupNonUniformAny):
                        case unchecked((int)Spv.Op.OpGroupNonUniformAllEqual):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBroadcast):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBroadcastFirst):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBallot):
                        case unchecked((int)Spv.Op.OpGroupNonUniformInverseBallot):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitExtract):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitCount):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindLSB):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindMSB):
                        case unchecked((int)Spv.Op.OpGroupNonUniformShuffle):
                        case unchecked((int)Spv.Op.OpGroupNonUniformShuffleXor):
                        case unchecked((int)Spv.Op.OpGroupNonUniformShuffleUp):
                        case unchecked((int)Spv.Op.OpGroupNonUniformShuffleDown):
                        case unchecked((int)Spv.Op.OpGroupNonUniformIAdd):
                        case unchecked((int)Spv.Op.OpGroupNonUniformFAdd):
                        case unchecked((int)Spv.Op.OpGroupNonUniformIMul):
                        case unchecked((int)Spv.Op.OpGroupNonUniformFMul):
                        case unchecked((int)Spv.Op.OpGroupNonUniformSMin):
                        case unchecked((int)Spv.Op.OpGroupNonUniformUMin):
                        case unchecked((int)Spv.Op.OpGroupNonUniformFMin):
                        case unchecked((int)Spv.Op.OpGroupNonUniformSMax):
                        case unchecked((int)Spv.Op.OpGroupNonUniformUMax):
                        case unchecked((int)Spv.Op.OpGroupNonUniformFMax):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseAnd):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseOr):
                        case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseXor):
                        case unchecked((int)Spv.Op.OpGroupNonUniformLogicalAnd):
                        case unchecked((int)Spv.Op.OpGroupNonUniformLogicalOr):
                        case unchecked((int)Spv.Op.OpGroupNonUniformLogicalXor):
                        case unchecked((int)Spv.Op.OpGroupNonUniformQuadBroadcast):
                        case unchecked((int)Spv.Op.OpGroupNonUniformQuadSwap):
                        case unchecked((int)Spv.Op.OpGroupNonUniformRotateKHR):
                        case unchecked((int)Spv.Op.OpControlBarrier):
                        {
                            return true;
                        }
                        default:
                        {
                            break;
                        }
                    }
                }
            }
        }
        return false;
    }
    public bool execution_is_branchless(SPIRBlock from, SPIRBlock to)
    {
        var start = from;
        {
            for (; ; )
            {
                if (((uint)start.self) == ((uint)to.self))
                {
                    return true;
                }
                if (unchecked((int)start.terminator) == unchecked((int)SPIRBlock.Terminator.Direct) && unchecked((int)start.merge) == unchecked((int)SPIRBlock.Merge.MergeNone))
                {
                    start = get__SPIRBlock(((uint)start.next_block));
                }
                else
                {
                    return false;
                }
            }
        }
    }
    public bool execution_is_direct_branch(SPIRBlock from, SPIRBlock to)
    {
        return unchecked((int)from.terminator) == unchecked((int)SPIRBlock.Terminator.Direct) && unchecked((int)from.merge) == unchecked((int)SPIRBlock.Merge.MergeNone) && ((uint)from.next_block) == ((uint)to.self);
    }
    public bool execution_is_noop(SPIRBlock from, SPIRBlock to)
    {
        if (!execution_is_branchless(from, to))
        {
            return false;
        }
        var start = from;
        {
            for (; ; )
            {
                if (((uint)start.self) == ((uint)to.self))
                {
                    return true;
                }
                if (!block_is_noop(start))
                {
                    return false;
                }
                var next = get__SPIRBlock(((uint)start.next_block));
                start = next;
            }
        }
    }
    public SPIRBlock.ContinueBlockType continue_block_type(SPIRBlock block)
    {
        if (block.complex_continue)
        {
            return SPIRBlock.ContinueBlockType.ComplexLoop;
        }
        if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop))
        {
            return SPIRBlock.ContinueBlockType.WhileLoop;
        }
        if (((uint)block.loop_dominator) == ((uint)new TypedID_TypeBlock(4294967295u)))
        {
            return SPIRBlock.ContinueBlockType.ComplexLoop;
        }
        var dominator = get__SPIRBlock(((uint)block.loop_dominator));
        if (execution_is_noop(block, dominator))
        {
            return SPIRBlock.ContinueBlockType.WhileLoop;
        }
        else
        if (execution_is_branchless(block, dominator))
        {
            return SPIRBlock.ContinueBlockType.ForLoop;
        }
        else
        {
            var false_block = maybe_get__SPIRBlock(((uint)block.false_block));
            var true_block = maybe_get__SPIRBlock(((uint)block.true_block));
            var merge_block = maybe_get__SPIRBlock(((uint)dominator.merge_block));
            bool flush_phi_to_false = false_block != null && flush_phi_required(((TypedID_TypeBlock)block.self), block.false_block);
            bool flush_phi_to_true = true_block != null && flush_phi_required(((TypedID_TypeBlock)block.self), block.true_block);
            if (flush_phi_to_false || flush_phi_to_true)
            {
                return SPIRBlock.ContinueBlockType.ComplexLoop;
            }
            bool positive_do_while = ((uint)block.true_block) == ((uint)dominator.self) && (((uint)block.false_block) == ((uint)dominator.merge_block) || false_block != null && merge_block != null && execution_is_noop(false_block, merge_block));
            bool negative_do_while = ((uint)block.false_block) == ((uint)dominator.self) && (((uint)block.true_block) == ((uint)dominator.merge_block) || true_block != null && merge_block != null && execution_is_noop(true_block, merge_block));
            if (unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeNone) && unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.Select) && (positive_do_while || negative_do_while))
            {
                return SPIRBlock.ContinueBlockType.DoWhileLoop;
            }
            else
            {
                return SPIRBlock.ContinueBlockType.ComplexLoop;
            }
        }
    }
    public void force_recompile()
    {
        is_force_recompile = true;
    }
    public void force_recompile_guarantee_forward_progress()
    {
        force_recompile();
        is_force_recompile_forward_progress = true;
    }
    public void clear_force_recompile()
    {
        is_force_recompile = false;
        is_force_recompile_forward_progress = false;
    }
    public bool is_forcing_recompilation()
    {
        return is_force_recompile;
    }
    public bool is_force_recompile = false;
    public bool is_force_recompile_forward_progress = false;
    public bool block_is_noop(SPIRBlock block)
    {
        if (unchecked((int)block.terminator) != unchecked((int)SPIRBlock.Terminator.Direct))
        {
            return false;
        }
        var child = get__SPIRBlock(((uint)block.next_block));
        {
            foreach (SPIRBlock.Phi phi in block.phi_variables)
            {
                if (((uint)phi.parent) == ((uint)block.self) || ((uint)phi.parent) == ((uint)child.self))
                {
                    return false;
                }
            }
        }
        {
            foreach (SPIRBlock.Phi phi in child.phi_variables)
            {
                if (((uint)phi.parent) == ((uint)block.self))
                {
                    return false;
                }
            }
        }
        {
            foreach (Instruction i in block.ops)
            {
                var op = unchecked((Spv.Op)i.op);
                {
                    switch (unchecked((int)op))
                    {
                        case unchecked((int)Spv.Op.OpLine):
                        case unchecked((int)Spv.Op.OpNoLine):
                        {
                            break;
                        }
                        case unchecked((int)Spv.Op.OpExtInst):
                        {
                            {
                                var ops = stream(i);
                                var ext = get__SPIRExtension(ops[2]).ext;
                                bool ext_is_nonsemantic_only = unchecked((int)ext) == unchecked((int)SPIRExtension.Extension.NonSemanticShaderDebugInfo) || unchecked((int)ext) == unchecked((int)SPIRExtension.Extension.SPV_debug_info) || unchecked((int)ext) == unchecked((int)SPIRExtension.Extension.NonSemanticGeneric);
                                if (!ext_is_nonsemantic_only)
                                {
                                    return false;
                                }
                                break;
                            }
                        }
                        default:
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
    public bool block_is_loop_candidate(SPIRBlock block, SPIRBlock.Method method)
    {
        if (block.disable_block_optimization || block.complex_continue)
        {
            return false;
        }
        if (unchecked((int)method) == unchecked((int)SPIRBlock.Method.MergeToSelectForLoop) || unchecked((int)method) == unchecked((int)SPIRBlock.Method.MergeToSelectContinueForLoop))
        {
            var false_block = maybe_get__SPIRBlock(((uint)block.false_block));
            var true_block = maybe_get__SPIRBlock(((uint)block.true_block));
            var merge_block = maybe_get__SPIRBlock(((uint)block.merge_block));
            bool false_block_is_merge = ((uint)block.false_block) == ((uint)block.merge_block) || false_block != null && merge_block != null && execution_is_noop(false_block, merge_block);
            bool true_block_is_merge = ((uint)block.true_block) == ((uint)block.merge_block) || true_block != null && merge_block != null && execution_is_noop(true_block, merge_block);
            bool positive_candidate = ((uint)block.true_block) != ((uint)block.merge_block) && ((uint)block.true_block) != ((uint)block.self) && false_block_is_merge;
            bool negative_candidate = ((uint)block.false_block) != ((uint)block.merge_block) && ((uint)block.false_block) != ((uint)block.self) && true_block_is_merge;
            bool ret = unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.Select) && unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop) && (positive_candidate || negative_candidate);
            if (ret && positive_candidate && unchecked((int)method) == unchecked((int)SPIRBlock.Method.MergeToSelectContinueForLoop))
            {
                ret = ((uint)block.true_block) == ((uint)block.continue_block);
            }
            else
            if (ret && negative_candidate && unchecked((int)method) == unchecked((int)SPIRBlock.Method.MergeToSelectContinueForLoop))
            {
                ret = ((uint)block.false_block) == ((uint)block.continue_block);
            }
            if (ret)
            {
                {
                    foreach (SPIRBlock.Phi phi in block.phi_variables)
                    {
                        if (((uint)phi.parent) == ((uint)block.self))
                        {
                            return false;
                        }
                    }
                }
                var merge = maybe_get__SPIRBlock(((uint)block.merge_block));
                if (merge != null)
                {
                    {
                        foreach (SPIRBlock.Phi phi in merge.phi_variables)
                        {
                            if (((uint)phi.parent) == ((uint)block.self))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return ret;
        }
        else
        if (unchecked((int)method) == unchecked((int)SPIRBlock.Method.MergeToDirectForLoop))
        {
            bool ret = unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.Direct) && unchecked((int)block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop) && block_is_noop(block);
            if (!ret)
            {
                return false;
            }
            var child = get__SPIRBlock(((uint)block.next_block));
            var false_block = maybe_get__SPIRBlock(((uint)child.false_block));
            var true_block = maybe_get__SPIRBlock(((uint)child.true_block));
            var merge_block = maybe_get__SPIRBlock(((uint)block.merge_block));
            bool false_block_is_merge = ((uint)child.false_block) == ((uint)block.merge_block) || false_block != null && merge_block != null && execution_is_noop(false_block, merge_block);
            bool true_block_is_merge = ((uint)child.true_block) == ((uint)block.merge_block) || true_block != null && merge_block != null && execution_is_noop(true_block, merge_block);
            bool positive_candidate = ((uint)child.true_block) != ((uint)block.merge_block) && ((uint)child.true_block) != ((uint)block.self) && false_block_is_merge;
            bool negative_candidate = ((uint)child.false_block) != ((uint)block.merge_block) && ((uint)child.false_block) != ((uint)block.self) && true_block_is_merge;
            ret = unchecked((int)child.terminator) == unchecked((int)SPIRBlock.Terminator.Select) && unchecked((int)child.merge) == unchecked((int)SPIRBlock.Merge.MergeNone) && (positive_candidate || negative_candidate);
            if (ret)
            {
                var merge = maybe_get__SPIRBlock(((uint)block.merge_block));
                if (merge != null)
                {
                    {
                        foreach (SPIRBlock.Phi phi in merge.phi_variables)
                        {
                            if (((uint)phi.parent) == ((uint)block.self) || ((uint)phi.parent) == ((uint)child.false_block))
                            {
                                return false;
                            }
                        }
                    }
                }
            }
            return ret;
        }
        else
        {
            return false;
        }
    }
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
    public void inherit_expression_dependencies(uint dst, uint source_expression)
    {
        var ptr_e = maybe_get__SPIRExpression(dst);
        if (is_position_invariant() && ptr_e != null && maybe_get__SPIRExpression(source_expression) != null)
        {
            var deps = ptr_e.invariance_dependencies;
            if (Std.find(deps.begin(), deps.end(), source_expression) == deps.end())
            {
                deps.push_back(new TypedID_TypeNone(source_expression));
            }
        }
        if (forwarded_temporaries.find(dst) == Std.end(forwarded_temporaries) || forced_temporaries.find(dst) != Std.end(forced_temporaries))
        {
            return;
        }
        var e = ptr_e;
        var phi = maybe_get__SPIRVariable(source_expression);
        if (phi != null && phi.phi_variable)
        {
            phi.dependees.push_back(new TypedID_TypeNone(dst));
        }
        var s = maybe_get__SPIRExpression(source_expression);
        if (!(s != null))
        {
            return;
        }
        var e_deps = e.expression_dependencies;
        var s_deps = s.expression_dependencies;
        e_deps.push_back(new TypedID_TypeNone(source_expression));
        e_deps.insert(Std.end(e_deps), Std.begin(s_deps), Std.end(s_deps));
        Std.sort(Std.begin(e_deps), Std.end(e_deps));
        e_deps.erase(Std.unique(Std.begin(e_deps), Std.end(e_deps)), Std.end(e_deps));
    }
    public void add_implied_read_expression(SPIRExpression e, uint source)
    {
        var itr = Std.find(Std.begin(e.implied_read_expressions), Std.end(e.implied_read_expressions), new TypedID_TypeNone(source));
        if (itr == Std.end(e.implied_read_expressions))
        {
            e.implied_read_expressions.push_back(new TypedID_TypeNone(source));
        }
    }
    public void add_implied_read_expression(SPIRAccessChain e, uint source)
    {
        var itr = Std.find(Std.begin(e.implied_read_expressions), Std.end(e.implied_read_expressions), new TypedID_TypeNone(source));
        if (itr == Std.end(e.implied_read_expressions))
        {
            e.implied_read_expressions.push_back(new TypedID_TypeNone(source));
        }
    }
    public void add_active_interface_variable(uint var_id)
    {
        active_interface_variables.insert(new TypedID_TypeVariable(var_id));
        if (ir.get_spirv_version() >= 66560u)
        {
            var vars = get_entry_point().interface_variables;
            if (Std.find(Std.begin(vars), Std.end(vars), new TypedID_TypeVariable(var_id)) == Std.end(vars))
            {
                vars.push_back(new TypedID_TypeVariable(var_id));
            }
        }
    }
    public bool interface_variable_exists_in_entry_point(uint id)
    {
        var @var = get__SPIRVariable(id);
        if (ir.get_spirv_version() < 66560u)
        {
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassInput) && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput) && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassUniformConstant))
            {
                throw new CompilerError("Only Input, Output variables and Uniform constants are part of a shader linking interface.");
            }
            if (ir.entry_points.size() <= 1UL)
            {
                return true;
            }
        }
        var execution = get_entry_point();
        return Std.find(Std.begin(execution.interface_variables), Std.end(execution.interface_variables), new TypedID_TypeVariable(id)) != Std.end(execution.interface_variables);
    }
    public CppVector<CombinedImageSampler> combined_image_samplers = new CppVector<CombinedImageSampler>();
    public void remap_variable_type_name(SPIRType type, CppString var_name, ref CppString type_name)
    {
        if (variable_remap_callback != null)
        {
            variable_remap_callback(type, var_name, ref type_name);
        }
    }
    public void set_ir(ParsedIR ir_)
    {
        ir.CopyFrom(ir_);
        parse_fixup();
    }
    public void parse_fixup()
    {
        {
            foreach (TypedID_TypeNone id_ in ir.ids_for_constant_or_variable)
            {
                ref var id = ref ir.ids[unchecked((ulong)((uint)id_))];
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeConstant))
                {
                    var c = id.get__SPIRConstant();
                    if (has_decoration(c.self, Spv.Decoration.DecorationBuiltIn) && unchecked((int)unchecked((Spv.BuiltIn)get_decoration(c.self, Spv.Decoration.DecorationBuiltIn))) == unchecked((int)Spv.BuiltIn.BuiltInWorkgroupSize))
                    {
                        {
                            foreach (Pair<TypedID_TypeFunction, SPIREntryPoint> entry in ir.entry_points)
                            {
                                entry.second.workgroup_size.constant = ((uint)c.self);
                                entry.second.workgroup_size.x = c.scalar(0u, 0u);
                                entry.second.workgroup_size.y = c.scalar(0u, 1u);
                                entry.second.workgroup_size.z = c.scalar(0u, 2u);
                            }
                        }
                    }
                }
                else
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeVariable))
                {
                    var @var = id.get__SPIRVariable();
                    var type = get__SPIRType(((uint)@var.basetype));
                    if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassPrivate) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassWorkgroup) && !has_decoration(type.self, Spv.Decoration.DecorationBlock) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput))
                    {
                        global_variables.push_back(((uint)@var.self));
                    }
                    if (variable_storage_is_aliased(@var))
                    {
                        aliased_variables.push_back(((uint)@var.self));
                    }
                }
            }
        }
    }
    public bool traverse_all_reachable_opcodes(SPIRBlock block, Compiler.OpcodeHandler handler)
    {
        handler.set_current_block(block);
        handler.rearm_current_block(block);
        if (handler.enable_result_types)
        {
            {
                foreach (SPIRBlock.Phi phi in block.phi_variables)
                {
                    var v = get__SPIRVariable(((uint)phi.function_variable));
                    handler.result_types[((uint)phi.function_variable)] = ((uint)v.basetype);
                }
            }
        }
        {
            foreach (Instruction i in block.ops)
            {
                var ops = stream(i);
                var op = unchecked((Spv.Op)i.op);
                if (!handler.handle(op, ops, i.length))
                {
                    return false;
                }
                if (handler.enable_result_types)
                {
                    uint result_type = default;
                    uint result_id = default;
                    if (Compiler.instruction_to_result_type(ref result_type, ref result_id, op, ops, i.length))
                    {
                        handler.result_types[result_id] = result_type;
                    }
                }
                if (unchecked((int)op) == unchecked((int)Spv.Op.OpFunctionCall))
                {
                    var func = get__SPIRFunction(ops[2]);
                    if (handler.follow_function_call(func))
                    {
                        if (handler.enable_result_types)
                        {
                            {
                                foreach (SPIRFunction.Parameter arg in func.arguments)
                                {
                                    if (!arg.alias_global_variable)
                                    {
                                        handler.result_types[((uint)arg.id)] = ((uint)arg.type);
                                    }
                                }
                            }
                        }
                        if (!handler.begin_function_scope(ops, i.length))
                        {
                            return false;
                        }
                        if (!traverse_all_reachable_opcodes(get__SPIRFunction(ops[2]), handler))
                        {
                            return false;
                        }
                        if (!handler.end_function_scope(ops, i.length))
                        {
                            return false;
                        }
                        handler.rearm_current_block(block);
                    }
                }
            }
        }
        if (!handler.handle_terminator(block))
        {
            return false;
        }
        return true;
    }
    public bool traverse_all_reachable_opcodes(SPIRFunction func, Compiler.OpcodeHandler handler)
    {
        {
            foreach (TypedID_TypeBlock block in func.blocks)
            {
                if (!traverse_all_reachable_opcodes(get__SPIRBlock(((uint)block)), handler))
                {
                    return false;
                }
            }
        }
        return true;
    }
    public CppVector<uint> global_struct_cache = new CppVector<uint>();
    public ShaderResources get_shader_resources_ptr(UnorderedSet<TypedID_TypeVariable> active_variables)
    {
        ShaderResources res = new ShaderResources();
        bool ssbo_instance_name = reflection_ssbo_instance_name_is_significant();
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassFunction) || !type.pointer)
            {
                return;
            }
            if (active_variables != null && active_variables.find(((TypedID_TypeVariable)@var.self)) == Std.end(active_variables))
            {
                return;
            }
            bool active_in_entry_point = true;
            if (this.ir.get_spirv_version() < 66560u)
            {
                if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput))
                {
                    active_in_entry_point = this.interface_variable_exists_in_entry_point(((uint)@var.self));
                }
            }
            else
            {
                active_in_entry_point = this.interface_variable_exists_in_entry_point(((uint)@var.self));
            }
            if (!active_in_entry_point)
            {
                return;
            }
            bool is_builtin = this.is_builtin_variable(@var);
            if (is_builtin)
            {
                if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassInput) && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput))
                {
                    return;
                }
                var list = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) ? res.builtin_inputs : res.builtin_outputs;
                BuiltInResource resource = new BuiltInResource();
                if (this.has_decoration(type.self, Spv.Decoration.DecorationBlock))
                {
                    resource.resource.CopyFrom(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_remapped_declared_block_name(((uint)@var.self), false) });
                    {
                        for (uint i = 0u; i < unchecked((uint)type.member_types.size()); i++)
                        {
                            resource.value_type_id = type.member_types[unchecked((ulong)i)];
                            resource.builtin = unchecked((Spv.BuiltIn)this.get_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationBuiltIn));
                            list.push_back(resource.Clone());
                        }
                    }
                }
                else
                {
                    bool strip_array = !this.has_decoration(@var.self, Spv.Decoration.DecorationPatch) && (unchecked((int)this.get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl) || unchecked((int)this.get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation) && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput));
                    resource.resource.CopyFrom(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                    if (strip_array && !type.array.empty())
                    {
                        resource.value_type_id = this.get_variable_data_type(@var).parent_type;
                    }
                    else
                    {
                        resource.value_type_id = new TypedID_TypeType(this.get_variable_data_type_id(@var));
                    }
                    resource.builtin = unchecked((Spv.BuiltIn)this.get_decoration(@var.self, Spv.Decoration.DecorationBuiltIn));
                    list.push_back(resource);
                }
                return;
            }
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput))
            {
                if (this.has_decoration(type.self, Spv.Decoration.DecorationBlock))
                {
                    res.stage_inputs.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_remapped_declared_block_name(((uint)@var.self), false) });
                }
                else
                {
                    res.stage_inputs.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                }
            }
            else
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) && unchecked((int)type.image.dim) == unchecked((int)Spv.Dim.DimSubpassData))
            {
                res.subpass_inputs.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
            }
            else
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput))
            {
                if (this.has_decoration(type.self, Spv.Decoration.DecorationBlock))
                {
                    res.stage_outputs.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_remapped_declared_block_name(((uint)@var.self), false) });
                }
                else
                {
                    res.stage_outputs.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                }
            }
            else
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) && this.has_decoration(type.self, Spv.Decoration.DecorationBlock))
            {
                res.uniform_buffers.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_remapped_declared_block_name(((uint)@var.self), false) });
            }
            else
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) && this.has_decoration(type.self, Spv.Decoration.DecorationBufferBlock))
            {
                res.storage_buffers.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_remapped_declared_block_name(((uint)@var.self), ssbo_instance_name) });
            }
            else
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer))
            {
                res.storage_buffers.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_remapped_declared_block_name(((uint)@var.self), ssbo_instance_name) });
            }
            else
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant))
            {
                res.push_constant_buffers.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
            }
            else
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassShaderRecordBufferKHR))
            {
                res.shader_record_buffers.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_remapped_declared_block_name(((uint)@var.self), ssbo_instance_name) });
            }
            else
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassAtomicCounter))
            {
                res.atomic_counters.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
            }
            else
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant))
            {
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image))
                {
                    if (type.image.sampled == 2u)
                    {
                        res.storage_images.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                    }
                    else
                    if (type.image.sampled == 1u)
                    {
                        res.separate_images.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                    }
                }
                else
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Sampler))
                {
                    res.separate_samplers.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                }
                else
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.SampledImage))
                {
                    res.sampled_images.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                }
                else
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.AccelerationStructure))
                {
                    res.acceleration_structures.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                }
                else
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Tensor))
                {
                    res.tensors.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                }
                else
                {
                    res.gl_plain_uniforms.push_back(new Resource { id = @var.self, type_id = @var.basetype, base_type_id = ((TypedID_TypeType)type.self), name = this.get_name(@var.self) });
                }
            }
        });
        return res;
    }
    public Callback_126331 variable_remap_callback;
    public bool get_common_basic_type(SPIRType type, ref SPIRType.BaseType base_type)
    {
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
        {
            base_type = SPIRType.BaseType.Unknown;
            {
                foreach (TypedID_TypeType member_type in type.member_types)
                {
                    SPIRType.BaseType member_base = default;
                    if (!get_common_basic_type(get__SPIRType(((uint)member_type)), ref member_base))
                    {
                        return false;
                    }
                    if (unchecked((int)base_type) == unchecked((int)SPIRType.BaseType.Unknown))
                    {
                        base_type = member_base;
                    }
                    else
                    if (unchecked((int)base_type) != unchecked((int)member_base))
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        else
        {
            base_type = type.basetype;
            return true;
        }
    }
    public UnorderedSet<uint> forced_temporaries = new UnorderedSet<uint>();
    public UnorderedSet<uint> forwarded_temporaries = new UnorderedSet<uint>();
    public UnorderedSet<uint> suppressed_usage_tracking = new UnorderedSet<uint>();
    public UnorderedSet<uint> hoisted_temporaries = new UnorderedSet<uint>();
    public UnorderedSet<uint> forced_invariant_temporaries = new UnorderedSet<uint>();
    public Bitset active_input_builtins = new Bitset();
    public Bitset active_output_builtins = new Bitset();
    public uint clip_distance_count = 0u;
    public uint cull_distance_count = 0u;
    public bool position_invariant = false;
    public void analyze_parameter_preservation(SPIRFunction entry, CFG cfg, UnorderedMap<uint, UnorderedSet<uint>> variable_to_blocks, UnorderedMap<uint, UnorderedSet<uint>> complete_write_blocks)
    {
        {
            foreach (SPIRFunction.Parameter arg in entry.arguments)
            {
                var type = get__SPIRType(((uint)arg.type));
                if (!type.pointer)
                {
                    continue;
                }
                bool potential_preserve = default;
                {
                    switch (unchecked((int)type.basetype))
                    {
                        case unchecked((int)SPIRType.BaseType.Sampler):
                        case unchecked((int)SPIRType.BaseType.Image):
                        case unchecked((int)SPIRType.BaseType.SampledImage):
                        case unchecked((int)SPIRType.BaseType.AtomicCounter):
                        {
                            potential_preserve = false;
                            break;
                        }
                        default:
                        {
                            potential_preserve = true;
                            break;
                        }
                    }
                }
                if (!potential_preserve)
                {
                    continue;
                }
                var itr = variable_to_blocks.find(((uint)arg.id));
                if (itr == Std.end(variable_to_blocks))
                {
                    continue;
                }
                itr = complete_write_blocks.find(((uint)arg.id));
                if (itr == Std.end(complete_write_blocks))
                {
                    arg.read_count++;
                    continue;
                }
                UnorderedSet<uint> visit_cache = new UnorderedSet<uint>();
                if (Globals.exists_unaccessed_path_to_return(cfg, ((uint)entry.entry_block), itr.deref().second, visit_cache))
                {
                    arg.read_count++;
                }
            }
        }
    }
    public UnorderedSet<uint> comparison_ids = new UnorderedSet<uint>();
    public bool need_subpass_input = false;
    public bool need_subpass_input_ms = false;
    public uint dummy_sampler_id = 0u;
    public void analyze_image_and_sampler_usage()
    {
        Compiler.CombinedImageSamplerDrefHandler dref_handler = new Compiler.CombinedImageSamplerDrefHandler(this);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), dref_handler);
        Compiler.CombinedImageSamplerUsageHandler handler = new Compiler.CombinedImageSamplerUsageHandler(this, dref_handler.dref_combined_samplers);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        handler.dependency_hierarchy.clear();
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        comparison_ids.CopyFrom(handler.comparison_ids);
        need_subpass_input = handler.need_subpass_input;
        need_subpass_input_ms = handler.need_subpass_input_ms;
        {
            foreach (CombinedImageSampler combined in combined_image_samplers)
            {
                if (comparison_ids.count(((uint)combined.sampler_id)) != 0UL)
                {
                    comparison_ids.insert(((uint)combined.combined_id));
                }
            }
        }
    }
    public void build_function_control_flow_graphs_and_analyze()
    {
        Compiler.CFGBuilder handler = new Compiler.CFGBuilder(this);
        handler.function_cfgs[((uint)ir.default_entry_point)] = new CFG(this, get__SPIRFunction(((uint)ir.default_entry_point)));
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        if (ir.is_library_module)
        {
            {
                foreach (TypedID_TypeFunction export_id in ir.library_exported_functions)
                {
                    var func = get__SPIRFunction(((uint)export_id));
                    if (handler.follow_function_call(func))
                    {
                        traverse_all_reachable_opcodes(func, handler);
                    }
                }
            }
        }
        function_cfgs.CopyFrom(handler.function_cfgs);
        bool single_function = function_cfgs.size() <= 1UL;
        {
            foreach (Pair<uint, CFG> f in function_cfgs)
            {
                var func = get__SPIRFunction(f.first);
                Compiler.AnalyzeVariableScopeAccessHandler scope_handler = new Compiler.AnalyzeVariableScopeAccessHandler(this, func);
                analyze_variable_scope(func, scope_handler);
                find_function_local_luts(func, scope_handler, single_function);
                {
                    foreach (TypedID_TypeBlock block in func.blocks)
                    {
                        var b = get__SPIRBlock(((uint)block));
                        if (b.loop_variables.size() < 2UL)
                        {
                            continue;
                        }
                        var flags = get_decoration_bitset(new TypedID_TypeNone(b.loop_variables.front()));
                        uint type = ((uint)get__SPIRVariable(((uint)b.loop_variables.front())).basetype);
                        bool invalid_initializers = false;
                        {
                            foreach (TypedID_TypeVariable loop_variable in b.loop_variables)
                            {
                                if (flags.operator_ne(get_decoration_bitset(new TypedID_TypeNone(loop_variable))) || type != ((uint)get__SPIRVariable(((uint)b.loop_variables.front())).basetype))
                                {
                                    invalid_initializers = true;
                                    break;
                                }
                            }
                        }
                        if (invalid_initializers)
                        {
                            {
                                foreach (TypedID_TypeVariable loop_variable in b.loop_variables)
                                {
                                    get__SPIRVariable(((uint)loop_variable)).loop_variable = false;
                                }
                            }
                            b.loop_variables.clear();
                        }
                    }
                }
            }
        }
        if (!single_function)
        {
            {
                var __r0 = global_variables;
                for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
                {
                    ref uint id = ref __r0[__i1];
                    var @var = get__SPIRVariable(id);
                    var type = get_variable_data_type(@var);
                    if (is_array(type) && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassPrivate) && ((uint)@var.initializer) != 0u && !@var.is_written_to && unchecked((int)ir.ids[unchecked((ulong)((uint)@var.initializer))].get_type()) == unchecked((int)Types.TypeConstant))
                    {
                        get__SPIRConstant(((uint)@var.initializer)).is_used_as_lut = true;
                        @var.static_expression = @var.initializer;
                        @var.statically_assigned = true;
                        @var.remapped_variable = true;
                    }
                }
            }
        }
    }
    public UnorderedMap<uint, CFG> function_cfgs = new UnorderedMap<uint, CFG>();
    public CFG get_cfg_for_current_function()
    {
        return get_cfg_for_function(((uint)current_function.self));
    }
    public CFG get_cfg_for_function(uint id)
    {
        var cfg_itr = function_cfgs.find(id);
        return cfg_itr.deref().second;
    }
    public void analyze_non_block_pointer_types()
    {
        Compiler.PhysicalStorageBufferPointerHandler handler = new Compiler.PhysicalStorageBufferPointerHandler(this);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        ir.for_each_typed_id__SPIRType_lambda((uint id, SPIRType type) =>
        {
            if (((uint)type.self) == id && (this.has_decoration(type.self, Spv.Decoration.DecorationBlock) || this.has_decoration(type.self, Spv.Decoration.DecorationBufferBlock)))
            {
                handler.analyze_non_block_types_from_block(type);
            }
        });
        physical_storage_non_block_pointer_types.reserve(handler.non_block_types.size());
        {
            foreach (uint type in handler.non_block_types)
            {
                physical_storage_non_block_pointer_types.push_back(type);
            }
        }
        Std.sort(Std.begin(physical_storage_non_block_pointer_types), Std.end(physical_storage_non_block_pointer_types));
        physical_storage_type_to_alignment.CopyFrom(handler.physical_block_type_meta);
    }
    public CppVector<uint> physical_storage_non_block_pointer_types = new CppVector<uint>();
    public UnorderedMap<uint, Compiler.PhysicalBlockMeta> physical_storage_type_to_alignment = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
    public CppVector<Compiler.DescriptorHeapMeta> descriptor_heap_types = new CppVector<Compiler.DescriptorHeapMeta>();
    public void analyze_descriptor_heap_types()
    {
        Compiler.HeapHandler handler = new Compiler.HeapHandler(this);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
        descriptor_heap_types.CopyFrom(handler.heap_types);
    }
    public void analyze_variable_scope(SPIRFunction entry, Compiler.AnalyzeVariableScopeAccessHandler handler)
    {
        traverse_all_reachable_opcodes(entry, handler);
        var cfg = function_cfgs.find(((uint)entry.self)).deref().second;
        analyze_parameter_preservation(entry, cfg, handler.accessed_variables_to_block, handler.complete_write_variables_to_block);
        UnorderedMap<uint, uint> potential_loop_variables = new UnorderedMap<uint, uint>();
        {
            var __r0 = entry.blocks;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeBlock block_id = ref __r0[__i1];
                var block = get__SPIRBlock(((uint)block_id));
                var itr = ir.continue_block_to_loop_header.find(block_id);
                if (itr != Std.end(ir.continue_block_to_loop_header) && ((uint)itr.deref().second) != ((uint)block_id))
                {
                    block.loop_dominator = itr.deref().second;
                }
                else
                {
                    uint loop_dominator = cfg.find_loop_dominator(((uint)block_id));
                    if (loop_dominator != ((uint)block_id))
                    {
                        block.loop_dominator = new TypedID_TypeBlock(loop_dominator);
                    }
                    else
                    {
                        block.loop_dominator = new TypedID_TypeBlock(4294967295u);
                    }
                }
            }
        }
        {
            foreach (Pair<uint, UnorderedSet<uint>> @var in handler.accessed_variables_to_block)
            {
                if (Std.find(Std.begin(entry.local_variables), Std.end(entry.local_variables), new TypedID_TypeVariable(@var.first)) == Std.end(entry.local_variables))
                {
                    continue;
                }
                DominatorBuilder builder = new DominatorBuilder(cfg);
                var blocks = @var.second;
                var type = expression_type(@var.first);
                TypedID_TypeBlock potential_continue_block = new TypedID_TypeBlock(0u);
                {
                    foreach (uint block in blocks)
                    {
                        if (is_continue(block))
                        {
                            builder.add_block(((uint)ir.continue_block_to_loop_header[new TypedID_TypeBlock(block)]));
                            if (type.vecsize == 1u && type.columns == 1u && unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Struct) && type.array.empty())
                            {
                                if (((uint)potential_continue_block) == 0u)
                                {
                                    potential_continue_block = new TypedID_TypeBlock(block);
                                }
                                else
                                {
                                    potential_continue_block = new TypedID_TypeBlock(~0u);
                                }
                            }
                        }
                        builder.add_block(block);
                    }
                }
                builder.lift_continue_block_dominator();
                TypedID_TypeBlock dominating_block = new TypedID_TypeBlock(builder.get_dominator());
                if (((uint)dominating_block) != 0u && ((uint)potential_continue_block) != 0u && ((uint)potential_continue_block) != ~0u)
                {
                    var inner_block = get__SPIRBlock(((uint)dominating_block));
                    TypedID_TypeBlock merge_candidate = new TypedID_TypeBlock(0u);
                    if (unchecked((int)inner_block.merge) == unchecked((int)SPIRBlock.Merge.MergeLoop))
                    {
                        merge_candidate = inner_block.merge_block;
                    }
                    else
                    if (((uint)inner_block.loop_dominator) != 4294967295u)
                    {
                        merge_candidate = get__SPIRBlock(((uint)inner_block.loop_dominator)).merge_block;
                    }
                    if (((uint)merge_candidate) != 0u && cfg.is_reachable(((uint)merge_candidate)))
                    {
                        if (!cfg.is_reachable(((uint)potential_continue_block)) || cfg.get_visit_order(((uint)merge_candidate)) > cfg.get_visit_order(((uint)potential_continue_block)))
                        {
                            potential_continue_block = new TypedID_TypeBlock(0u);
                        }
                    }
                }
                if (((uint)potential_continue_block) != 0u && ((uint)potential_continue_block) != ~0u)
                {
                    potential_loop_variables[@var.first] = ((uint)potential_continue_block);
                }
                if (((uint)dominating_block) != 0u)
                {
                    var variable = get__SPIRVariable(@var.first);
                    if (!variable.phi_variable)
                    {
                        var block = get__SPIRBlock(((uint)dominating_block));
                        bool preserve = may_read_undefined_variable_in_block(block, @var.first);
                        if (preserve)
                        {
                            while (((uint)block.loop_dominator) != ((uint)new TypedID_TypeBlock(4294967295u)))
                            {
                                block = get__SPIRBlock(((uint)block.loop_dominator));
                            }
                            if (((uint)block.self) != ((uint)dominating_block))
                            {
                                builder.add_block(((uint)block.self));
                                dominating_block = new TypedID_TypeBlock(builder.get_dominator());
                            }
                        }
                    }
                }
                if (((uint)dominating_block) != 0u)
                {
                    var block = get__SPIRBlock(((uint)dominating_block));
                    block.dominated_variables.push_back(new TypedID_TypeVariable(@var.first));
                    get__SPIRVariable(@var.first).dominator = dominating_block;
                }
            }
        }
        {
            foreach (Pair<uint, UnorderedSet<uint>> @var in handler.accessed_temporaries_to_block)
            {
                var itr = handler.result_id_to_type.find(@var.first);
                if (itr == Std.end(handler.result_id_to_type))
                {
                    continue;
                }
                var type = get__SPIRType(itr.deref().second);
                if (type_is_opaque_value(type))
                {
                    continue;
                }
                DominatorBuilder builder = new DominatorBuilder(cfg);
                bool force_temporary = false;
                bool used_in_header_hoisted_continue_block = false;
                var blocks = @var.second;
                {
                    foreach (uint block in blocks)
                    {
                        builder.add_block(block);
                        if (blocks.size() != 1UL && is_continue(block))
                        {
                            var loop_header_block = get__SPIRBlock(((uint)ir.continue_block_to_loop_header[new TypedID_TypeBlock(block)]));
                            builder.add_block(((uint)loop_header_block.self));
                            used_in_header_hoisted_continue_block = true;
                        }
                    }
                }
                uint dominating_block = builder.get_dominator();
                if (blocks.size() != 1UL && is_single_block_loop(dominating_block))
                {
                    force_temporary = true;
                }
                if (dominating_block != 0u)
                {
                    bool first_use_is_dominator = blocks.count(dominating_block) != 0UL;
                    if (!first_use_is_dominator || force_temporary)
                    {
                        if (handler.access_chain_expressions.count(@var.first) != 0UL)
                        {
                            if (used_in_header_hoisted_continue_block)
                            {
                                var loop_header_block = get__SPIRBlock(dominating_block);
                                loop_header_block.complex_continue = true;
                            }
                        }
                        else
                        {
                            hoisted_temporaries.insert(@var.first);
                            forced_temporaries.insert(@var.first);
                            var block_temporaries = get__SPIRBlock(dominating_block).declare_temporary;
                            block_temporaries.push_back(new Pair<TypedID_TypeType, TypedID_TypeNone>(handler.result_id_to_type[@var.first], @var.first));
                        }
                    }
                    else
                    if (blocks.size() > 1UL)
                    {
                        var block_temporaries = get__SPIRBlock(dominating_block).potential_declare_temporary;
                        block_temporaries.push_back(new Pair<TypedID_TypeType, TypedID_TypeNone>(handler.result_id_to_type[@var.first], @var.first));
                    }
                }
            }
        }
        UnorderedSet<uint> seen_blocks = new UnorderedSet<uint>();
        {
            foreach (Pair<uint, uint> loop_variable in potential_loop_variables)
            {
                var @var = get__SPIRVariable(loop_variable.first);
                var dominator = @var.dominator;
                TypedID_TypeBlock block = new TypedID_TypeBlock(loop_variable.second);
                if (((uint)block) == ((uint)new TypedID_TypeBlock(~0u)) || ((uint)block) == ((uint)new TypedID_TypeBlock(0u)))
                {
                    continue;
                }
                if (((uint)dominator) == ((uint)new TypedID_TypeNone(0u)))
                {
                    continue;
                }
                TypedID_TypeBlock header = new TypedID_TypeBlock(0u);
                {
                    var itr = ir.continue_block_to_loop_header.find(block);
                    if (itr != Std.end(ir.continue_block_to_loop_header))
                    {
                        header = itr.deref().second;
                    }
                    else
                    if (((uint)get__SPIRBlock(((uint)block)).continue_block) == ((uint)block))
                    {
                        header = block;
                    }
                }
                var header_block = get__SPIRBlock(((uint)header));
                var blocks = handler.accessed_variables_to_block[loop_variable.first];
                bool has_accessed_variable = blocks.count(((uint)header)) != 0UL;
                bool static_loop_init = true;
                while (((uint)dominator) != ((uint)header))
                {
                    if (blocks.count(((uint)dominator)) != 0UL)
                    {
                        has_accessed_variable = true;
                    }
                    var succ = cfg.get_succeeding_edges(((uint)dominator));
                    if (succ.size() != 1UL)
                    {
                        static_loop_init = false;
                        break;
                    }
                    var pred = cfg.get_preceding_edges(succ.front());
                    if (pred.size() != 1UL || pred.front() != ((uint)dominator))
                    {
                        static_loop_init = false;
                        break;
                    }
                    dominator = new TypedID_TypeBlock(succ.front());
                }
                if (!static_loop_init || !has_accessed_variable)
                {
                    continue;
                }
                seen_blocks.clear();
                cfg.walk_from__lambda(seen_blocks, ((uint)header_block.merge_block), (uint walk_block) =>
                {
                    if (blocks.find(walk_block) != Std.end(blocks))
                    {
                        static_loop_init = false;
                    }
                    return true;
                });
                if (!static_loop_init)
                {
                    continue;
                }
                header_block.loop_variables.push_back(new TypedID_TypeVariable(loop_variable.first));
                Std.sort(Std.begin(header_block.loop_variables), Std.end(header_block.loop_variables));
                get__SPIRVariable(loop_variable.first).loop_variable = true;
            }
        }
    }
    public void find_function_local_luts(SPIRFunction entry, Compiler.AnalyzeVariableScopeAccessHandler handler, bool single_function)
    {
        var cfg = function_cfgs.find(((uint)entry.self)).deref().second;
        {
            foreach (Pair<uint, UnorderedSet<uint>> accessed_var in handler.accessed_variables_to_block)
            {
                var blocks = accessed_var.second;
                var @var = get__SPIRVariable(accessed_var.first);
                var type = expression_type(accessed_var.first);
                if (!@var.is_written_to)
                {
                    @var.is_written_to = handler.complete_write_variables_to_block.count(((uint)@var.self)) != 0UL || handler.partial_write_variables_to_block.count(((uint)@var.self)) != 0UL;
                }
                bool allow_lut = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassFunction) || single_function && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassPrivate);
                if (!allow_lut)
                {
                    continue;
                }
                if (@var.phi_variable)
                {
                    continue;
                }
                if (type.array.empty())
                {
                    continue;
                }
                uint static_constant_expression = 0u;
                if (((uint)@var.initializer) != 0u)
                {
                    if (unchecked((int)ir.ids[unchecked((ulong)((uint)@var.initializer))].get_type()) != unchecked((int)Types.TypeConstant))
                    {
                        continue;
                    }
                    static_constant_expression = ((uint)@var.initializer);
                    if (@var.is_written_to)
                    {
                        continue;
                    }
                }
                else
                {
                    if (handler.partial_write_variables_to_block.count(((uint)@var.self)) != 0UL)
                    {
                        continue;
                    }
                    var itr = handler.complete_write_variables_to_block.find(((uint)@var.self));
                    if (itr == Std.end(handler.complete_write_variables_to_block))
                    {
                        continue;
                    }
                    var write_blocks = itr.deref().second;
                    if (write_blocks.size() != 1UL)
                    {
                        continue;
                    }
                    DominatorBuilder builder = new DominatorBuilder(cfg);
                    {
                        foreach (uint block in blocks)
                        {
                            builder.add_block(block);
                        }
                    }
                    uint dominator = builder.get_dominator();
                    if (write_blocks.count(dominator) == 0UL)
                    {
                        continue;
                    }
                    Compiler.StaticExpressionAccessHandler static_expression_handler = new Compiler.StaticExpressionAccessHandler(this, ((uint)@var.self));
                    traverse_all_reachable_opcodes(get__SPIRBlock(dominator), static_expression_handler);
                    if (static_expression_handler.write_count != 1u || static_expression_handler.static_expression == 0u)
                    {
                        continue;
                    }
                    if (unchecked((int)ir.ids[unchecked((ulong)static_expression_handler.static_expression)].get_type()) != unchecked((int)Types.TypeConstant))
                    {
                        continue;
                    }
                    static_constant_expression = static_expression_handler.static_expression;
                }
                get__SPIRConstant(static_constant_expression).is_used_as_lut = true;
                @var.static_expression = new TypedID_TypeNone(static_constant_expression);
                @var.statically_assigned = true;
                @var.remapped_variable = true;
            }
        }
    }
    public bool may_read_undefined_variable_in_block(SPIRBlock block, uint @var)
    {
        {
            foreach (Instruction op in block.ops)
            {
                var ops = stream(op);
                {
                    switch (unchecked((int)op.op))
                    {
                        case unchecked((int)Spv.Op.OpStore):
                        case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                        case unchecked((int)Spv.Op.OpCopyMemory):
                        {
                            if (ops[0] == @var)
                            {
                                return false;
                            }
                            break;
                        }
                        case unchecked((int)Spv.Op.OpAccessChain):
                        case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                        case unchecked((int)Spv.Op.OpPtrAccessChain):
                        {
                            if (ops[2] == @var)
                            {
                                return true;
                            }
                            break;
                        }
                        case unchecked((int)Spv.Op.OpSelect):
                        {
                            if (ops[3] == @var || ops[4] == @var)
                            {
                                return true;
                            }
                            break;
                        }
                        case unchecked((int)Spv.Op.OpPhi):
                        {
                            {
                                if (op.length < 2u)
                                {
                                    break;
                                }
                                uint count = op.length - 2u;
                                {
                                    for (uint i = 0u; i < count; i += 2u)
                                    {
                                        if (ops[i + 2u] == @var)
                                        {
                                            return true;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                        case unchecked((int)Spv.Op.OpCopyObject):
                        case unchecked((int)Spv.Op.OpLoad):
                        case unchecked((int)Spv.Op.OpCooperativeVectorLoadNV):
                        case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                        {
                            if (ops[2] == @var)
                            {
                                return true;
                            }
                            break;
                        }
                        case unchecked((int)Spv.Op.OpFunctionCall):
                        {
                            {
                                if (op.length < 3u)
                                {
                                    break;
                                }
                                uint count = op.length - 3u;
                                {
                                    for (uint i = 0u; i < count; i++)
                                    {
                                        if (ops[i + 3u] == @var)
                                        {
                                            return true;
                                        }
                                    }
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
        }
        return true;
    }
    public void discover_geometry_emitters()
    {
        Compiler.GeometryEmitDisocveryHandler handler = new Compiler.GeometryEmitDisocveryHandler(this);
        traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
    }
    public void analyze_interlocked_resource_usage()
    {
        if (unchecked((int)get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelFragment) && (get_entry_point().flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModePixelInterlockOrderedEXT)) || get_entry_point().flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModePixelInterlockUnorderedEXT)) || get_entry_point().flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeSampleInterlockOrderedEXT)) || get_entry_point().flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeSampleInterlockUnorderedEXT))))
        {
            Compiler.InterlockedResourceAccessPrepassHandler prepass_handler = new Compiler.InterlockedResourceAccessPrepassHandler(this, ((uint)ir.default_entry_point));
            traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), prepass_handler);
            Compiler.InterlockedResourceAccessHandler handler = new Compiler.InterlockedResourceAccessHandler(this, ((uint)ir.default_entry_point));
            handler.interlock_function_id = prepass_handler.interlock_function_id;
            handler.split_function_case = prepass_handler.split_function_case;
            handler.control_flow_interlock = prepass_handler.control_flow_interlock;
            handler.use_critical_section = !handler.split_function_case && !handler.control_flow_interlock;
            traverse_all_reachable_opcodes(get__SPIRFunction(((uint)ir.default_entry_point)), handler);
            interlocked_is_complex = !handler.use_critical_section || handler.interlock_function_id != ((uint)ir.default_entry_point);
        }
    }
    public UnorderedSet<uint> interlocked_resources = new UnorderedSet<uint>();
    public bool interlocked_is_complex = false;
    public void make_constant_null(uint id, uint type)
    {
        var constant_type = get__SPIRType(type);
        if (constant_type.pointer)
        {
            var constant = set__SPIRConstant_X(id, type);
            constant.make_null(constant_type);
        }
        else
        if (!constant_type.array.empty())
        {
            uint parent_id = ir.increase_bound_by(1u);
            make_constant_null(parent_id, ((uint)constant_type.parent_type));
            bool is_literal_array_size = constant_type.array_size_literal.back();
            uint count = is_literal_array_size ? constant_type.array.back() : 1u;
            CppVector<uint> elements = new CppVector<uint>(unchecked((ulong)count));
            {
                for (uint i = 0u; i < count; i++)
                {
                    elements[unchecked((ulong)i)] = parent_id;
                }
            }
            var constant = set__SPIRConstant_X(id, type, elements.data(), unchecked((uint)elements.size()), false);
            constant.is_null_array_specialized_length = !is_literal_array_size;
        }
        else
        if (!constant_type.member_types.empty())
        {
            uint member_ids = ir.increase_bound_by(unchecked((uint)constant_type.member_types.size()));
            CppVector<uint> elements = new CppVector<uint>(constant_type.member_types.size());
            {
                for (uint i = 0u; unchecked((ulong)i) < constant_type.member_types.size(); i++)
                {
                    make_constant_null(member_ids + i, ((uint)constant_type.member_types[unchecked((ulong)i)]));
                    elements[unchecked((ulong)i)] = member_ids + i;
                }
            }
            set__SPIRConstant_X(id, type, elements.data(), unchecked((uint)elements.size()), false);
        }
        else
        {
            var constant = set__SPIRConstant_X(id, type);
            constant.make_null(constant_type);
        }
    }
    public void analyze_shader_abort_usage()
    {
        ir.for_each_typed_id__SPIRFunction_lambda((uint _p, SPIRFunction func) =>
        {
            {
                foreach (TypedID_TypeBlock block_id in func.blocks)
                {
                    var block = this.get__SPIRBlock(((uint)block_id));
                    if (unchecked((int)block.terminator) == unchecked((int)SPIRBlock.Terminator.ShaderAbort))
                    {
                        this.abort_block_types.insert(((uint)block.shader_abort.physical_type));
                        this.abort_payloads[((uint)block.shader_abort.payload)].CopyFrom(new CppVector<uint>(new uint[0]));
                    }
                }
            }
        });
    }
    public UnorderedSet<uint> abort_block_types = new UnorderedSet<uint>();
    public UnorderedMap<uint, CppVector<uint>> abort_payloads = new UnorderedMap<uint, CppVector<uint>>();
    public UnorderedMap<uint, CppString> declared_block_names = new UnorderedMap<uint, CppString>();
    public static bool instruction_to_result_type(ref uint result_type, ref uint result_id, Spv.Op op, Ptr<uint> args, uint length)
    {
        if (length < 2u)
        {
            return false;
        }
        bool has_result_id = false;
        bool has_result_type = false;
        Spv.Globals.HasResultAndType(op, Ptr.Ref<bool>(() => has_result_id, __v => has_result_id = __v), Ptr.Ref<bool>(() => has_result_type, __v => has_result_type = __v));
        if (has_result_id && has_result_type)
        {
            result_type = args[0];
            result_id = args[1];
            return true;
        }
        else
        {
            return false;
        }
    }
    public Bitset combined_decoration_for_member(SPIRType type, uint index)
    {
        Bitset flags = new Bitset();
        var type_meta = ir.find_meta(type.self);
        if (type_meta != null)
        {
            var members = type_meta.members;
            if (unchecked((ulong)index) >= members.size())
            {
                return flags;
            }
            var dec = members[unchecked((ulong)index)];
            flags.merge_or(dec.decoration_flags);
            var member_type = get__SPIRType(((uint)type.member_types[unchecked((ulong)index)]));
            var member_childs = member_type.member_types;
            {
                for (uint i = 0u; unchecked((ulong)i) < member_childs.size(); i++)
                {
                    var child_member_type = get__SPIRType(((uint)member_childs[unchecked((ulong)i)]));
                    if (!child_member_type.pointer)
                    {
                        flags.merge_or(combined_decoration_for_member(member_type, i));
                    }
                }
            }
        }
        return flags;
    }
    public static bool is_desktop_only_format(Spv.ImageFormat format)
    {
        {
            switch (unchecked((int)format))
            {
                case unchecked((int)Spv.ImageFormat.ImageFormatR11fG11fB10f):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16f):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10A2):
                case unchecked((int)Spv.ImageFormat.ImageFormatR8):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatR8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatR8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10a2ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatR8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16i):
                {
                    return true;
                }
                default:
                {
                    break;
                }
            }
        }
        return false;
    }
    public bool is_depth_image(SPIRType type, uint id)
    {
        return type.image.depth && unchecked((int)type.image.format) == unchecked((int)Spv.ImageFormat.ImageFormatUnknown) || comparison_ids.count(id) != 0UL;
    }
    public void set_extended_decoration(uint id, ExtendedDecorations decoration, uint value = 0u)
    {
        ref var dec = ref ir.meta[new TypedID_TypeNone(id)].decoration;
        dec.extended.flags.set(unchecked((uint)decoration));
        dec.extended.values[(int)decoration] = value;
    }
    public uint get_extended_decoration(uint id, ExtendedDecorations decoration)
    {
        var m = ir.find_meta(new TypedID_TypeNone(id));
        if (!(m != null))
        {
            return 0u;
        }
        var dec = m.decoration;
        if (!dec.extended.flags.get(unchecked((uint)decoration)))
        {
            return Globals.get_default_extended_decoration(decoration);
        }
        return dec.extended.values[(int)decoration];
    }
    public bool has_extended_decoration(uint id, ExtendedDecorations decoration)
    {
        var m = ir.find_meta(new TypedID_TypeNone(id));
        if (!(m != null))
        {
            return false;
        }
        var dec = m.decoration;
        return dec.extended.flags.get(unchecked((uint)decoration));
    }
    public void unset_extended_decoration(uint id, ExtendedDecorations decoration)
    {
        ref var dec = ref ir.meta[new TypedID_TypeNone(id)].decoration;
        dec.extended.flags.clear(unchecked((uint)decoration));
        dec.extended.values[(int)decoration] = 0u;
    }
    public void set_extended_member_decoration(uint type, uint index, ExtendedDecorations decoration, uint value = 0u)
    {
        ir.meta[new TypedID_TypeNone(type)].members.resize(Std.max(ir.meta[new TypedID_TypeNone(type)].members.size(), unchecked((ulong)index) + 1UL));
        ref var dec = ref ir.meta[new TypedID_TypeNone(type)].members[unchecked((ulong)index)];
        dec.extended.flags.set(unchecked((uint)decoration));
        dec.extended.values[(int)decoration] = value;
    }
    public uint get_extended_member_decoration(uint type, uint index, ExtendedDecorations decoration)
    {
        var m = ir.find_meta(new TypedID_TypeNone(type));
        if (!(m != null))
        {
            return 0u;
        }
        if (unchecked((ulong)index) >= m.members.size())
        {
            return 0u;
        }
        var dec = m.members[unchecked((ulong)index)];
        if (!dec.extended.flags.get(unchecked((uint)decoration)))
        {
            return Globals.get_default_extended_decoration(decoration);
        }
        return dec.extended.values[(int)decoration];
    }
    public bool has_extended_member_decoration(uint type, uint index, ExtendedDecorations decoration)
    {
        var m = ir.find_meta(new TypedID_TypeNone(type));
        if (!(m != null))
        {
            return false;
        }
        if (unchecked((ulong)index) >= m.members.size())
        {
            return false;
        }
        var dec = m.members[unchecked((ulong)index)];
        return dec.extended.flags.get(unchecked((uint)decoration));
    }
    public void unset_extended_member_decoration(uint type, uint index, ExtendedDecorations decoration)
    {
        ir.meta[new TypedID_TypeNone(type)].members.resize(Std.max(ir.meta[new TypedID_TypeNone(type)].members.size(), unchecked((ulong)index) + 1UL));
        ref var dec = ref ir.meta[new TypedID_TypeNone(type)].members[unchecked((ulong)index)];
        dec.extended.flags.clear(unchecked((uint)decoration));
        dec.extended.values[(int)decoration] = 0u;
    }
    public bool check_internal_recursion(SPIRType type, UnorderedSet<uint> checked_ids)
    {
        if (unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Struct))
        {
            return false;
        }
        if (checked_ids.count(((uint)type.self)) != 0UL)
        {
            return true;
        }
        bool is_recursive = false;
        checked_ids.insert(((uint)type.self));
        uint mbr_cnt = unchecked((uint)type.member_types.size());
        {
            for (uint mbr_idx = 0u; !is_recursive && mbr_idx < mbr_cnt; mbr_idx++)
            {
                uint mbr_type_id = ((uint)type.member_types[unchecked((ulong)mbr_idx)]);
                var mbr_type = get__SPIRType(mbr_type_id);
                is_recursive |= check_internal_recursion(mbr_type, checked_ids);
            }
        }
        checked_ids.erase(((uint)type.self));
        return is_recursive;
    }
    public bool type_contains_recursion(SPIRType type)
    {
        UnorderedSet<uint> checked_ids = new UnorderedSet<uint>();
        return check_internal_recursion(type, checked_ids);
    }
    public bool type_is_array_of_pointers(SPIRType type)
    {
        if (!is_array(type))
        {
            return false;
        }
        if (!(((uint)type.parent_type) != 0u))
        {
            return false;
        }
        var parent = get__SPIRType(((uint)type.parent_type));
        while (is_array(parent))
        {
            parent = get__SPIRType(((uint)parent.parent_type));
        }
        return is_pointer(parent);
    }
    public bool type_is_block_like(SPIRType type)
    {
        if (type_is_top_level_block(type))
        {
            return true;
        }
        else
        {
            return type_is_explicit_layout(type);
        }
    }
    public bool type_is_explicit_layout(SPIRType type)
    {
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
        {
            {
                for (uint i = 0u; i < unchecked((uint)type.member_types.size()); i++)
                {
                    if (has_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationOffset))
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
    public bool type_is_top_level_block(SPIRType type)
    {
        if (unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Struct))
        {
            return false;
        }
        return has_decoration(type.self, Spv.Decoration.DecorationBlock) || has_decoration(type.self, Spv.Decoration.DecorationBufferBlock);
    }
    public bool type_is_opaque_value(SPIRType type)
    {
        return !type.pointer && (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.SampledImage) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Sampler) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Tensor));
    }
    public bool reflection_ssbo_instance_name_is_significant()
    {
        if (!ir.sources.empty() && ir.sources[0UL].known)
        {
            return ir.sources[0UL].hlsl;
        }
        UnorderedSet<uint> ssbo_type_ids = new UnorderedSet<uint>();
        bool aliased_ssbo_types = false;
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            if (!type.pointer || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassFunction))
            {
                return;
            }
            bool ssbo = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) && this.has_decoration(type.self, Spv.Decoration.DecorationBufferBlock);
            if (ssbo)
            {
                if (ssbo_type_ids.count(((uint)type.self)) != 0UL)
                {
                    aliased_ssbo_types = true;
                }
                else
                {
                    ssbo_type_ids.insert(((uint)type.self));
                }
            }
        });
        return aliased_ssbo_types;
    }
    public CppString get_remapped_declared_block_name(uint id, bool fallback_prefer_instance_name)
    {
        var itr = declared_block_names.find(id);
        if (itr != Std.end(declared_block_names))
        {
            return itr.deref().second;
        }
        else
        {
            var @var = get__SPIRVariable(id);
            if (fallback_prefer_instance_name)
            {
                return to_name(((uint)@var.self), true);
            }
            else
            {
                var type = get__SPIRType(((uint)@var.basetype));
                var type_meta = ir.find_meta(type.self);
                var block_name = type_meta != null ? Ptr.Ref<CppString>(() => type_meta.decoration.alias, __v => type_meta.decoration.alias = __v) : null;
                return !(block_name != null) || block_name.Value.empty() ? get_block_fallback_name(new TypedID_TypeVariable(id)) : block_name.Value;
            }
        }
    }
    public bool flush_phi_required(TypedID_TypeBlock from, TypedID_TypeBlock to)
    {
        var child = get__SPIRBlock(((uint)to));
        {
            foreach (SPIRBlock.Phi phi in child.phi_variables)
            {
                if (((uint)phi.parent) == ((uint)from))
                {
                    return true;
                }
            }
        }
        return false;
    }
    public uint evaluate_spec_constant_u32(SPIRConstantOp spec)
    {
        var result_type = get__SPIRType(((uint)spec.basetype));
        if (unchecked((int)result_type.basetype) != unchecked((int)SPIRType.BaseType.UInt) && unchecked((int)result_type.basetype) != unchecked((int)SPIRType.BaseType.Int) && unchecked((int)result_type.basetype) != unchecked((int)SPIRType.BaseType.Boolean))
        {
            throw new CompilerError("Only 32-bit integers and booleans are currently supported when evaluating specialization constants.\n");
        }
        if (!is_scalar(result_type))
        {
            throw new CompilerError("Spec constant evaluation must be a scalar.\n");
        }
        uint value = 0u;
        var eval_u32 = (uint id) =>
        {
            var type = this.expression_type(id);
            if (unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.UInt) && unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Int) && unchecked((int)type.basetype) != unchecked((int)SPIRType.BaseType.Boolean))
            {
                throw new CompilerError("Only 32-bit integers and booleans are currently supported when evaluating specialization constants.\n");
            }
            if (!this.is_scalar(type))
            {
                throw new CompilerError("Spec constant evaluation must be a scalar.\n");
            }
            {
                var c = this.maybe_get__SPIRConstant(id);
                if (c != null)
                {
                    return c.scalar(0u, 0u);
                }
                else
                {
                    return this.evaluate_spec_constant_u32(this.get__SPIRConstantOp(id));
                }
            }
        };
        {
            switch (unchecked((int)spec.opcode))
            {
                case unchecked((int)Spv.Op.OpIAdd):
                {
                    value = eval_u32(spec.arguments[0UL]) + eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpISub):
                {
                    value = eval_u32(spec.arguments[0UL]) - eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpIMul):
                {
                    value = eval_u32(spec.arguments[0UL]) * eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpBitwiseAnd):
                {
                    value = eval_u32(spec.arguments[0UL]) & eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpBitwiseOr):
                {
                    value = eval_u32(spec.arguments[0UL]) | eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpBitwiseXor):
                {
                    value = eval_u32(spec.arguments[0UL]) ^ eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalAnd):
                {
                    value = eval_u32(spec.arguments[0UL]) & eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalOr):
                {
                    value = eval_u32(spec.arguments[0UL]) | eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpShiftLeftLogical):
                {
                    value = eval_u32(spec.arguments[0UL]) << (int)eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpShiftRightLogical):
                {
                    value = eval_u32(spec.arguments[0UL]) >> (int)eval_u32(spec.arguments[1UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpShiftRightArithmetic):
                {
                    value = unchecked((uint)(unchecked((int)eval_u32(spec.arguments[0UL])) >> unchecked((int)eval_u32(spec.arguments[1UL]))));
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalEqual):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) == eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalNotEqual):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) != eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpIEqual):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) == eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpINotEqual):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) != eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpULessThan):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) < eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpULessThanEqual):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) <= eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpUGreaterThan):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) > eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpUGreaterThanEqual):
                {
                    value = (uint)(eval_u32(spec.arguments[0UL]) >= eval_u32(spec.arguments[1UL]) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpSLessThan):
                {
                    value = (uint)(unchecked((int)eval_u32(spec.arguments[0UL])) < unchecked((int)eval_u32(spec.arguments[1UL])) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpSLessThanEqual):
                {
                    value = (uint)(unchecked((int)eval_u32(spec.arguments[0UL])) <= unchecked((int)eval_u32(spec.arguments[1UL])) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpSGreaterThan):
                {
                    value = (uint)(unchecked((int)eval_u32(spec.arguments[0UL])) > unchecked((int)eval_u32(spec.arguments[1UL])) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpSGreaterThanEqual):
                {
                    value = (uint)(unchecked((int)eval_u32(spec.arguments[0UL])) >= unchecked((int)eval_u32(spec.arguments[1UL])) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalNot):
                {
                    value = (uint)(!(eval_u32(spec.arguments[0UL]) != 0u) ? 1 : 0);
                    break;
                }
                case unchecked((int)Spv.Op.OpNot):
                {
                    value = ~eval_u32(spec.arguments[0UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpSNegate):
                {
                    value = unchecked((uint)-unchecked((int)eval_u32(spec.arguments[0UL])));
                    break;
                }
                case unchecked((int)Spv.Op.OpSelect):
                {
                    value = eval_u32(spec.arguments[0UL]) != 0u ? eval_u32(spec.arguments[1UL]) : eval_u32(spec.arguments[2UL]);
                    break;
                }
                case unchecked((int)Spv.Op.OpUMod):
                {
                    {
                        uint a = eval_u32(spec.arguments[0UL]);
                        uint b = eval_u32(spec.arguments[1UL]);
                        if (b == 0u)
                        {
                            throw new CompilerError("Undefined behavior in UMod, b == 0.\n");
                        }
                        value = a % b;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSRem):
                {
                    {
                        var a = unchecked((int)eval_u32(spec.arguments[0UL]));
                        var b = unchecked((int)eval_u32(spec.arguments[1UL]));
                        if (b == 0)
                        {
                            throw new CompilerError("Undefined behavior in SRem, b == 0.\n");
                        }
                        value = unchecked((uint)(a % b));
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSMod):
                {
                    {
                        var a = unchecked((int)eval_u32(spec.arguments[0UL]));
                        var b = unchecked((int)eval_u32(spec.arguments[1UL]));
                        if (b == 0)
                        {
                            throw new CompilerError("Undefined behavior in SMod, b == 0.\n");
                        }
                        var v = a % b;
                        if (b < 0 && v > 0 || b > 0 && v < 0)
                        {
                            v += b;
                        }
                        value = unchecked((uint)v);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpUDiv):
                {
                    {
                        uint a = eval_u32(spec.arguments[0UL]);
                        uint b = eval_u32(spec.arguments[1UL]);
                        if (b == 0u)
                        {
                            throw new CompilerError("Undefined behavior in UDiv, b == 0.\n");
                        }
                        value = a / b;
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSDiv):
                {
                    {
                        var a = unchecked((int)eval_u32(spec.arguments[0UL]));
                        var b = unchecked((int)eval_u32(spec.arguments[1UL]));
                        if (b == 0)
                        {
                            throw new CompilerError("Undefined behavior in SDiv, b == 0.\n");
                        }
                        value = unchecked((uint)(a / b));
                        break;
                    }
                }
                default:
                {
                    throw new CompilerError("Unsupported spec constant opcode for evaluation.\n");
                }
            }
        }
        return value;
    }
    public bool is_vertex_like_shader()
    {
        var model = get_execution_model();
        return unchecked((int)model) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex) || unchecked((int)model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry) || unchecked((int)model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl) || unchecked((int)model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation);
    }
    public CppVector<SPIRBlock.Case> get_case_list(SPIRBlock block)
    {
        uint width = 0u;
        {
            var constant = maybe_get__SPIRConstant(((uint)block.condition));
            if (constant != null)
            {
                var type = get__SPIRType(((uint)constant.constant_type));
                width = type.width;
            }
            else
            {
                {
                    var op = maybe_get__SPIRConstantOp(((uint)block.condition));
                    if (op != null)
                    {
                        var type = get__SPIRType(((uint)op.basetype));
                        width = type.width;
                    }
                    else
                    {
                        {
                            var @var = maybe_get__SPIRVariable(((uint)block.condition));
                            if (@var != null)
                            {
                                var type = get__SPIRType(((uint)@var.basetype));
                                width = type.width;
                            }
                            else
                            {
                                {
                                    var undef = maybe_get__SPIRUndef(((uint)block.condition));
                                    if (undef != null)
                                    {
                                        var type = get__SPIRType(((uint)undef.basetype));
                                        width = type.width;
                                    }
                                    else
                                    {
                                        var search = ir.load_type_width.find(block.condition);
                                        if (search == ir.load_type_width.end())
                                        {
                                            throw new CompilerError("Use of undeclared variable on a switch statement.");
                                        }
                                        width = search.deref().second;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        if (width > 32u)
        {
            return block.cases_64bit;
        }
        return block.cases_32bit;
    }
    public SPIREntryPoint get_first_entry_point(CppString name)
    {
        var itr = Std.find_if(Std.begin(ir.entry_points), Std.end(ir.entry_points), (Pair<uint, SPIREntryPoint> entry) =>
        {
            return entry.second.orig_name == name;
        });
        if (itr == Std.end(ir.entry_points))
        {
            throw new CompilerError("Entry point does not exist.");
        }
        return itr.deref().second;
    }
    public void set_initializers__SPIRType(SPIRType _p0)
    {
    }
    public void set_initializers__SPIRVariable(SPIRVariable _p0)
    {
    }
    public void set_initializers__SPIRConstant(SPIRConstant _p0)
    {
    }
    public SPIRType set__SPIRType_X(uint id, Spv.Op args)
    {
        ir.add_typed_id(unchecked((Types)SPIRType.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRType_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRType(@var);
        return @var;
    }
    public SPIRVariable set__SPIRVariable_X(uint id, uint args, Spv.StorageClass args_1, int args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRVariable_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRVariable(@var);
        return @var;
    }
    public SPIRExpression set__SPIRExpression_X(uint id, string args, uint args_1, bool args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRExpression.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRExpression_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers(@var);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRConstant(@var);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, Ptr<uint> args_1, uint args_2, bool args_3)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRConstant(@var);
        return @var;
    }
    public SPIRType get__SPIRType(uint id)
    {
        return Globals.variant_get__SPIRType(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRFunction get__SPIRFunction(uint id)
    {
        return Globals.variant_get__SPIRFunction(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRExtension get__SPIRExtension(uint id)
    {
        return Globals.variant_get__SPIRExtension(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRExpression get__SPIRExpression(uint id)
    {
        return Globals.variant_get__SPIRExpression(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRVariable get__SPIRVariable(uint id)
    {
        return Globals.variant_get__SPIRVariable(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRConstant get__SPIRConstant(uint id)
    {
        return Globals.variant_get__SPIRConstant(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRAccessChain get__SPIRAccessChain(uint id)
    {
        return Globals.variant_get__SPIRAccessChain(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRConstantOp get__SPIRConstantOp(uint id)
    {
        return Globals.variant_get__SPIRConstantOp(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRVariable maybe_get__SPIRVariable(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRVariable.type)))
        {
            return get__SPIRVariable(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRExpression maybe_get__SPIRExpression(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRExpression.type)))
        {
            return get__SPIRExpression(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRAccessChain maybe_get__SPIRAccessChain(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRAccessChain.type)))
        {
            return get__SPIRAccessChain(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRConstant maybe_get__SPIRConstant(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
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
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRConstantOp.type)))
        {
            return get__SPIRConstantOp(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRUndef get__SPIRUndef(uint id)
    {
        return Globals.variant_get__SPIRUndef(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRCombinedImageSampler get__SPIRCombinedImageSampler(uint id)
    {
        return Globals.variant_get__SPIRCombinedImageSampler(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRConstantData get__SPIRConstantData(uint id)
    {
        return Globals.variant_get__SPIRConstantData(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRBlock maybe_get__SPIRBlock(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRBlock.type)))
        {
            return get__SPIRBlock(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRUndef maybe_get__SPIRUndef(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRUndef.type)))
        {
            return get__SPIRUndef(id);
        }
        else
        {
            return null;
        }
    }
    public void set_initializers__SPIRAccessChain(SPIRAccessChain _p0)
    {
    }
    public void set_initializers__SPIRCombinedImageSampler(SPIRCombinedImageSampler _p0)
    {
    }
    public void set_initializers__SPIRString(SPIRString _p0)
    {
    }
    public SPIRExpression set__SPIRExpression_X(uint id, CppString args, uint args_1, bool args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRExpression.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRExpression_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers(@var);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, uint args_1, bool args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRConstant(@var);
        return @var;
    }
    public SPIRConstant set__SPIRConstant_X(uint id, TypedID_TypeType args)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRConstant(@var);
        return @var;
    }
    public SPIRType set__SPIRType_X(uint id, SPIRType args)
    {
        ir.add_typed_id(unchecked((Types)SPIRType.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRType_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRType(@var);
        return @var;
    }
    public SPIRAccessChain set__SPIRAccessChain_X(uint id, SPIRAccessChain args)
    {
        ir.add_typed_id(unchecked((Types)SPIRAccessChain.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRAccessChain_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRAccessChain(@var);
        return @var;
    }
    public SPIRCombinedImageSampler set__SPIRCombinedImageSampler_X(uint id, SPIRCombinedImageSampler args)
    {
        ir.add_typed_id(unchecked((Types)SPIRCombinedImageSampler.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRCombinedImageSampler_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRCombinedImageSampler(@var);
        return @var;
    }
    public SPIRExpression set__SPIRExpression_X(uint id, CppString args, TypedID_TypeType args_1, bool args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRExpression.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRExpression_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers(@var);
        return @var;
    }
    public SPIRString set__SPIRString_X(uint id, CppString args)
    {
        ir.add_typed_id(unchecked((Types)SPIRString.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRString_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRString(@var);
        return @var;
    }
    public SPIRString get__SPIRString(uint id)
    {
        return Globals.variant_get__SPIRString(ir.ids[unchecked((ulong)id)]);
    }
    public SPIRCombinedImageSampler maybe_get__SPIRCombinedImageSampler(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRCombinedImageSampler.type)))
        {
            return get__SPIRCombinedImageSampler(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRConstantData maybe_get__SPIRConstantData(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRConstantData.type)))
        {
            return get__SPIRConstantData(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRType maybe_get__SPIRType(uint id)
    {
        if (unchecked((ulong)id) >= ir.ids.size())
        {
            return null;
        }
        else
        if (unchecked((int)ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)unchecked((Types)SPIRType.type)))
        {
            return get__SPIRType(id);
        }
        else
        {
            return null;
        }
    }
    public SPIRVariable set__SPIRVariable_X(uint id, uint args, Spv.StorageClass args_1)
    {
        ir.add_typed_id(unchecked((Types)SPIRVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRVariable_X(ir.ids[unchecked((ulong)id)], args, args_1);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRVariable(@var);
        return @var;
    }
    public SPIRCombinedImageSampler set__SPIRCombinedImageSampler_X(uint id, uint args, uint args_1, uint args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRCombinedImageSampler.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRCombinedImageSampler_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRCombinedImageSampler(@var);
        return @var;
    }
    public SPIRAccessChain set__SPIRAccessChain_X(uint id, uint args, Spv.StorageClass args_1, CppString args_2, CppString args_3, uint args_4)
    {
        ir.add_typed_id(unchecked((Types)SPIRAccessChain.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRAccessChain_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3, args_4);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRAccessChain(@var);
        return @var;
    }
    public void set_initializers__SPIRFunction(SPIRFunction _p0)
    {
    }
    public void set_initializers__SPIRBlock(SPIRBlock _p0)
    {
    }
    public SPIRConstant set__SPIRConstant_X(uint id, uint args, SPIRConstant[] args_1, int args_2, bool args_3)
    {
        ir.add_typed_id(unchecked((Types)SPIRConstant.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRConstant_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRConstant(@var);
        return @var;
    }
    public SPIRVariable set__SPIRVariable_X(uint id, uint args, Spv.StorageClass args_1, int args_2, uint args_3)
    {
        ir.add_typed_id(unchecked((Types)SPIRVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRVariable_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2, args_3);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRVariable(@var);
        return @var;
    }
    public SPIRVariable set__SPIRVariable_X(uint id, uint args, Spv.StorageClass args_1, uint args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRVariable_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRVariable(@var);
        return @var;
    }
    public SPIRVariable set__SPIRVariable_X(uint id, SPIRVariable args)
    {
        ir.add_typed_id(unchecked((Types)SPIRVariable.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRVariable_X(ir.ids[unchecked((ulong)id)], args);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRVariable(@var);
        return @var;
    }
    public SPIRExpression set__SPIRExpression_X(uint id, string args, TypedID_TypeType args_1, bool args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRExpression.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRExpression_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers(@var);
        return @var;
    }
    public SPIRFunction set__SPIRFunction_X(uint id, TypedID_TypeType args, uint args_1, TypedID_TypeType args_2)
    {
        ir.add_typed_id(unchecked((Types)SPIRFunction.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRFunction_X(ir.ids[unchecked((ulong)id)], args, args_1, args_2);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRFunction(@var);
        return @var;
    }
    public SPIRBlock set__SPIRBlock_X(uint id)
    {
        ir.add_typed_id(unchecked((Types)SPIRBlock.type), new TypedID_TypeNone(id));
        var @var = Globals.variant_set__SPIRBlock_X(ir.ids[unchecked((ulong)id)]);
        @var.self = new TypedID_TypeNone(id);
        set_initializers__SPIRBlock(@var);
        return @var;
    }

    protected virtual void FixClone()
    {
        this.ir = this.ir.Clone();
        this.global_variables = this.global_variables.Clone();
        this.aliased_variables = this.aliased_variables.Clone();
        this.buffer_pointer_variables = this.buffer_pointer_variables.Clone();
        this.active_interface_variables = this.active_interface_variables.Clone();
        this.invalid_expressions = this.invalid_expressions.Clone();
        this.combined_image_samplers = this.combined_image_samplers.Clone(__e => __e.Clone());
        this.global_struct_cache = this.global_struct_cache.Clone();
        this.forced_temporaries = this.forced_temporaries.Clone();
        this.forwarded_temporaries = this.forwarded_temporaries.Clone();
        this.suppressed_usage_tracking = this.suppressed_usage_tracking.Clone();
        this.hoisted_temporaries = this.hoisted_temporaries.Clone();
        this.forced_invariant_temporaries = this.forced_invariant_temporaries.Clone();
        this.active_input_builtins = this.active_input_builtins.Clone();
        this.active_output_builtins = this.active_output_builtins.Clone();
        this.comparison_ids = this.comparison_ids.Clone();
        this.function_cfgs = this.function_cfgs.Clone();
        this.physical_storage_non_block_pointer_types = this.physical_storage_non_block_pointer_types.Clone();
        this.physical_storage_type_to_alignment = this.physical_storage_type_to_alignment.Clone(null, __e => __e.Clone());
        this.descriptor_heap_types = this.descriptor_heap_types.Clone(__e => __e.Clone());
        this.interlocked_resources = this.interlocked_resources.Clone();
        this.abort_block_types = this.abort_block_types.Clone();
        this.abort_payloads = this.abort_payloads.Clone(null, __e => __e.Clone());
        this.declared_block_names = this.declared_block_names.Clone();
    }

    public Compiler Clone()
    {
        var __c = (Compiler)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(Compiler o)
    {
        this.ir = o.ir.Clone();
        this.global_variables = o.global_variables.Clone();
        this.aliased_variables = o.aliased_variables.Clone();
        this.buffer_pointer_variables = o.buffer_pointer_variables.Clone();
        this.current_function = o.current_function;
        this.current_block = o.current_block;
        this.current_loop_level = o.current_loop_level;
        this.active_interface_variables = o.active_interface_variables.Clone();
        this.check_active_interface_variables = o.check_active_interface_variables;
        this.invalid_expressions = o.invalid_expressions.Clone();
        this.is_force_recompile = o.is_force_recompile;
        this.is_force_recompile_forward_progress = o.is_force_recompile_forward_progress;
        this.combined_image_samplers = o.combined_image_samplers.Clone(__e => __e.Clone());
        this.global_struct_cache = o.global_struct_cache.Clone();
        this.variable_remap_callback = o.variable_remap_callback;
        this.forced_temporaries = o.forced_temporaries.Clone();
        this.forwarded_temporaries = o.forwarded_temporaries.Clone();
        this.suppressed_usage_tracking = o.suppressed_usage_tracking.Clone();
        this.hoisted_temporaries = o.hoisted_temporaries.Clone();
        this.forced_invariant_temporaries = o.forced_invariant_temporaries.Clone();
        this.active_input_builtins = o.active_input_builtins.Clone();
        this.active_output_builtins = o.active_output_builtins.Clone();
        this.clip_distance_count = o.clip_distance_count;
        this.cull_distance_count = o.cull_distance_count;
        this.position_invariant = o.position_invariant;
        this.comparison_ids = o.comparison_ids.Clone();
        this.need_subpass_input = o.need_subpass_input;
        this.need_subpass_input_ms = o.need_subpass_input_ms;
        this.dummy_sampler_id = o.dummy_sampler_id;
        this.function_cfgs = o.function_cfgs.Clone();
        this.physical_storage_non_block_pointer_types = o.physical_storage_non_block_pointer_types.Clone();
        this.physical_storage_type_to_alignment = o.physical_storage_type_to_alignment.Clone(null, __e => __e.Clone());
        this.descriptor_heap_types = o.descriptor_heap_types.Clone(__e => __e.Clone());
        this.interlocked_resources = o.interlocked_resources.Clone();
        this.interlocked_is_complex = o.interlocked_is_complex;
        this.abort_block_types = o.abort_block_types.Clone();
        this.abort_payloads = o.abort_payloads.Clone(null, __e => __e.Clone());
        this.declared_block_names = o.declared_block_names.Clone();
    }

    public partial class ActiveBuiltinHandler : Compiler.OpcodeHandler
    {
        public ActiveBuiltinHandler(Compiler compiler_) : base(compiler_)
        {
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint length)
        {
            {
                switch (unchecked((int)opcode))
                {
                    case unchecked((int)Spv.Op.OpStore):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                    {
                        if (length < 1u)
                        {
                            return false;
                        }
                        add_if_builtin(args[0]);
                        break;
                    }
                    case unchecked((int)Spv.Op.OpCopyMemory):
                    {
                        if (length < 2u)
                        {
                            return false;
                        }
                        add_if_builtin(args[0]);
                        add_if_builtin(args[1]);
                        break;
                    }
                    case unchecked((int)Spv.Op.OpCopyObject):
                    case unchecked((int)Spv.Op.OpLoad):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                    {
                        if (length < 3u)
                        {
                            return false;
                        }
                        add_if_builtin(args[2]);
                        break;
                    }
                    case unchecked((int)Spv.Op.OpSelect):
                    {
                        if (length < 5u)
                        {
                            return false;
                        }
                        add_if_builtin(args[3]);
                        add_if_builtin(args[4]);
                        break;
                    }
                    case unchecked((int)Spv.Op.OpPhi):
                    {
                        {
                            if (length < 2u)
                            {
                                return false;
                            }
                            uint count = length - 2u;
                            args += 2;
                            {
                                for (uint i = 0u; i < count; i += 2u)
                                {
                                    add_if_builtin(args[i]);
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpFunctionCall):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint count = length - 3u;
                            args += 3;
                            {
                                for (uint i = 0u; i < count; i++)
                                {
                                    add_if_builtin(args[i]);
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    {
                        {
                            if (length < 4u)
                            {
                                return false;
                            }
                            var @var = compiler.maybe_get__SPIRVariable(args[2]);
                            if (!(@var != null))
                            {
                                break;
                            }
                            add_if_builtin(args[2]);
                            var type = compiler.get_variable_data_type(@var);
                            var flags = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) ? compiler.active_input_builtins : compiler.active_output_builtins;
                            uint count = length - 3u;
                            args += 3;
                            {
                                for (uint i = 0u; i < count; i++)
                                {
                                    if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpPtrAccessChain) && i == 0u)
                                    {
                                        continue;
                                    }
                                    if (!type.array.empty())
                                    {
                                        type = compiler.get__SPIRType(((uint)type.parent_type));
                                    }
                                    else
                                    if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
                                    {
                                        uint index = compiler.get__SPIRConstant(args[i]).scalar(0u, 0u);
                                        if (index < unchecked((uint)compiler.ir.meta[type.self].members.size()))
                                        {
                                            ref var decorations = ref compiler.ir.meta[type.self].members[unchecked((ulong)index)];
                                            if (decorations.builtin)
                                            {
                                                flags.set(unchecked((uint)decorations.builtin_type));
                                                handle_builtin(compiler.get__SPIRType(((uint)type.member_types[unchecked((ulong)index)])), decorations.builtin_type, decorations.decoration_flags);
                                            }
                                        }
                                        type = compiler.get__SPIRType(((uint)type.member_types[unchecked((ulong)index)]));
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
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
            return true;
        }
        public void handle_builtin(SPIRType type, Spv.BuiltIn builtin, Bitset decoration_flags)
        {
            if (unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInClipDistance))
            {
                if (!type.array_size_literal[0UL])
                {
                    throw new CompilerError("Array size for ClipDistance must be a literal.");
                }
                uint array_size = type.array[0UL];
                if (array_size == 0u)
                {
                    throw new CompilerError("Array size for ClipDistance must not be unsized.");
                }
                compiler.clip_distance_count = array_size;
            }
            else
            if (unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInCullDistance))
            {
                if (!type.array_size_literal[0UL])
                {
                    throw new CompilerError("Array size for CullDistance must be a literal.");
                }
                uint array_size = type.array[0UL];
                if (array_size == 0u)
                {
                    throw new CompilerError("Array size for CullDistance must not be unsized.");
                }
                compiler.cull_distance_count = array_size;
            }
            else
            if (unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPosition))
            {
                if (decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationInvariant)))
                {
                    compiler.position_invariant = true;
                }
            }
        }
        public void add_if_builtin(uint id)
        {
            add_if_builtin(id, false);
        }
        public void add_if_builtin_or_block(uint id)
        {
            add_if_builtin(id, true);
        }
        public void add_if_builtin(uint id, bool allow_blocks)
        {
            var @var = compiler.maybe_get__SPIRVariable(id);
            var m = compiler.ir.find_meta(new TypedID_TypeNone(id));
            if (@var != null && m != null)
            {
                var type = compiler.get__SPIRType(((uint)@var.basetype));
                ref var decorations = ref m.decoration;
                var flags = unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) ? compiler.active_input_builtins : compiler.active_output_builtins;
                if (decorations.builtin)
                {
                    flags.set(unchecked((uint)decorations.builtin_type));
                    handle_builtin(type, decorations.builtin_type, decorations.decoration_flags);
                }
                else
                if (allow_blocks && compiler.has_decoration(type.self, Spv.Decoration.DecorationBlock))
                {
                    uint member_count = unchecked((uint)type.member_types.size());
                    {
                        for (uint i = 0u; i < member_count; i++)
                        {
                            if (compiler.has_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationBuiltIn))
                            {
                                var member_type = compiler.get__SPIRType(((uint)type.member_types[unchecked((ulong)i)]));
                                Spv.BuiltIn builtin = unchecked((Spv.BuiltIn)compiler.get_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationBuiltIn));
                                flags.set(unchecked((uint)builtin));
                                handle_builtin(member_type, builtin, compiler.get_member_decoration_bitset(((TypedID_TypeType)type.self), i));
                            }
                        }
                    }
                }
            }
        }

        protected override void FixClone()
        {
            base.FixClone();
        }

        public new ActiveBuiltinHandler Clone()
        {
            var __c = (ActiveBuiltinHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(ActiveBuiltinHandler o)
        {
            base.CopyFrom(o);
        }
    }

    public partial class AnalyzeVariableScopeAccessHandler : Compiler.OpcodeHandler
    {
        public AnalyzeVariableScopeAccessHandler(Compiler compiler_, SPIRFunction entry_) : base(compiler_)
        {
            this.entry = entry_;
            this.accessed_variables_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
            this.accessed_temporaries_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
            this.result_id_to_type = new UnorderedMap<uint, uint>();
            this.complete_write_variables_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
            this.partial_write_variables_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
            this.access_chain_expressions = new UnorderedSet<uint>();
            this.rvalue_forward_children = new UnorderedMap<uint, UnorderedSet<uint>>();
        }
        public override bool follow_function_call(SPIRFunction _p0)
        {
            return false;
        }
        public override void set_current_block(SPIRBlock block)
        {
            current_block = block;
            var test_phi = (uint to) =>
            {
                var next = this.compiler.get__SPIRBlock(to);
                {
                    foreach (SPIRBlock.Phi phi in next.phi_variables)
                    {
                        if (((uint)phi.parent) == ((uint)block.self))
                        {
                            this.accessed_variables_to_block[((uint)phi.function_variable)].insert(((uint)block.self));
                            this.accessed_variables_to_block[((uint)phi.function_variable)].insert(((uint)next.self));
                            this.notify_variable_access(((uint)phi.local_variable), ((uint)block.self));
                        }
                    }
                }
            };
            {
                switch (unchecked((int)block.terminator))
                {
                    case unchecked((int)SPIRBlock.Terminator.Direct):
                    {
                        notify_variable_access(((uint)block.condition), ((uint)block.self));
                        test_phi(((uint)block.next_block));
                        break;
                    }
                    case unchecked((int)SPIRBlock.Terminator.Select):
                    {
                        notify_variable_access(((uint)block.condition), ((uint)block.self));
                        test_phi(((uint)block.true_block));
                        test_phi(((uint)block.false_block));
                        break;
                    }
                    case unchecked((int)SPIRBlock.Terminator.MultiSelect):
                    {
                        {
                            notify_variable_access(((uint)block.condition), ((uint)block.self));
                            var cases = compiler.get_case_list(block);
                            {
                                foreach (SPIRBlock.Case target in cases)
                                {
                                    test_phi(((uint)target.block));
                                }
                            }
                            if (((uint)block.default_block) != 0u)
                            {
                                test_phi(((uint)block.default_block));
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
        public void notify_variable_access(uint id, uint block)
        {
            if (id == 0u)
            {
                return;
            }
            var itr = rvalue_forward_children.find(id);
            if (itr != Std.end(rvalue_forward_children))
            {
                {
                    foreach (uint child_id in itr.deref().second)
                    {
                        notify_variable_access(child_id, block);
                    }
                }
            }
            if (id_is_phi_variable(id))
            {
                accessed_variables_to_block[id].insert(block);
            }
            else
            if (id_is_potential_temporary(id))
            {
                accessed_temporaries_to_block[id].insert(block);
            }
        }
        public bool id_is_phi_variable(uint id)
        {
            if (id >= compiler.get_current_id_bound())
            {
                return false;
            }
            var @var = compiler.maybe_get__SPIRVariable(id);
            return @var != null && @var.phi_variable;
        }
        public bool id_is_potential_temporary(uint id)
        {
            if (id >= compiler.get_current_id_bound())
            {
                return false;
            }
            return compiler.ir.ids[unchecked((ulong)id)].empty() || unchecked((int)compiler.ir.ids[unchecked((ulong)id)].get_type()) == unchecked((int)Types.TypeExpression);
        }
        public override bool handle(Spv.Op op, Ptr<uint> args, uint length)
        {
            uint result_type = 0u;
            uint result_id = 0u;
            if (Compiler.instruction_to_result_type(ref result_type, ref result_id, op, args, length))
            {
                if (unchecked((int)op) == unchecked((int)Spv.Op.OpConvertUToAccelerationStructureKHR))
                {
                    var itr = result_id_to_type.find(args[2]);
                    if (itr != result_id_to_type.end())
                    {
                        result_type = itr.deref().second;
                    }
                }
                result_id_to_type[result_id] = result_type;
            }
            {
                switch (unchecked((int)op))
                {
                    case unchecked((int)Spv.Op.OpStore):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                    {
                        {
                            if (length < 2u)
                            {
                                return false;
                            }
                            TypedID_TypeNone ptr = new TypedID_TypeNone(args[0]);
                            var @var = compiler.maybe_get_backing_variable(((uint)ptr));
                            if (@var != null)
                            {
                                accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                if (((uint)@var.self) == ((uint)ptr))
                                {
                                    complete_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                }
                                else
                                {
                                    partial_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                }
                            }
                            notify_variable_access(args[0], ((uint)current_block.self));
                            notify_variable_access(args[1], ((uint)current_block.self));
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint ptr = args[2];
                            var @var = compiler.maybe_get__SPIRVariable(ptr);
                            if (@var != null)
                            {
                                accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                rvalue_forward_children[args[1]].insert(((uint)@var.self));
                            }
                            {
                                for (uint i = 2u; i < length; i++)
                                {
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                    rvalue_forward_children[args[1]].insert(args[i]);
                                }
                            }
                            notify_variable_access(args[1], ((uint)current_block.self));
                            var e = compiler.set__SPIRExpression_X(args[1], "", args[0], true);
                            var backing_variable = compiler.maybe_get_backing_variable(ptr);
                            e.loaded_from = backing_variable != null ? new TypedID_TypeVariable(backing_variable.self) : new TypedID_TypeVariable(0u);
                            compiler.ir.ids[unchecked((ulong)args[1])].set_allow_type_rewrite();
                            access_chain_expressions.insert(args[1]);
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpCopyMemory):
                    {
                        {
                            if (length < 2u)
                            {
                                return false;
                            }
                            TypedID_TypeNone lhs = new TypedID_TypeNone(args[0]);
                            TypedID_TypeNone rhs = new TypedID_TypeNone(args[1]);
                            var @var = compiler.maybe_get_backing_variable(((uint)lhs));
                            if (@var != null)
                            {
                                accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                if (((uint)@var.self) == ((uint)lhs))
                                {
                                    complete_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                }
                                else
                                {
                                    partial_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                }
                            }
                            {
                                for (uint i = 0u; i < 2u; i++)
                                {
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                            @var = compiler.maybe_get_backing_variable(((uint)rhs));
                            if (@var != null)
                            {
                                accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpCopyObject):
                    {
                        {
                            var type = compiler.get__SPIRType(result_type);
                            if (type.pointer)
                            {
                                result_id_to_type[result_id] = ((uint)type.parent_type);
                            }
                            if (length < 3u)
                            {
                                return false;
                            }
                            var @var = compiler.maybe_get_backing_variable(args[2]);
                            if (@var != null)
                            {
                                accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                            }
                            notify_variable_access(args[1], ((uint)current_block.self));
                            if (access_chain_expressions.count(args[2]) != 0UL)
                            {
                                access_chain_expressions.insert(args[1]);
                            }
                            notify_variable_access(args[2], ((uint)current_block.self));
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpLoad):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint ptr = args[2];
                            var @var = compiler.maybe_get_backing_variable(ptr);
                            if (@var != null)
                            {
                                accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                            }
                            notify_variable_access(args[1], ((uint)current_block.self));
                            notify_variable_access(args[2], ((uint)current_block.self));
                            var type = compiler.get__SPIRType(args[0]);
                            if (compiler.type_is_opaque_value(type))
                            {
                                rvalue_forward_children[args[1]].insert(args[2]);
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpFunctionCall):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            if (unchecked((int)compiler.get_type(new TypedID_TypeType(args[0])).basetype) != unchecked((int)SPIRType.BaseType.Void))
                            {
                                notify_variable_access(args[1], ((uint)current_block.self));
                            }
                            length -= 3u;
                            args += 3;
                            {
                                for (uint i = 0u; i < length; i++)
                                {
                                    var @var = compiler.maybe_get_backing_variable(args[i]);
                                    if (@var != null)
                                    {
                                        accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                        partial_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                    }
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpSelect):
                    {
                        {
                            {
                                for (uint i = 1u; i < length; i++)
                                {
                                    if (i >= 3u)
                                    {
                                        var @var = compiler.maybe_get_backing_variable(args[i]);
                                        if (@var != null)
                                        {
                                            accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                            partial_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                        }
                                    }
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpExtInst):
                    {
                        {
                            {
                                for (uint i = 4u; i < length; i++)
                                {
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                            notify_variable_access(args[1], ((uint)current_block.self));
                            uint extension_set = args[2];
                            if (unchecked((int)compiler.get__SPIRExtension(extension_set).ext) == unchecked((int)SPIRExtension.Extension.GLSL))
                            {
                                var op_450 = unchecked((GLSLstd450)args[3]);
                                {
                                    switch (unchecked((int)op_450))
                                    {
                                        case unchecked((int)GLSLstd450.GLSLstd450Modf):
                                        case unchecked((int)GLSLstd450.GLSLstd450Frexp):
                                        {
                                            {
                                                uint ptr = args[5];
                                                var @var = compiler.maybe_get_backing_variable(ptr);
                                                if (@var != null)
                                                {
                                                    accessed_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                                    if (((uint)@var.self) == ptr)
                                                    {
                                                        complete_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                                    }
                                                    else
                                                    {
                                                        partial_write_variables_to_block[((uint)@var.self)].insert(((uint)current_block.self));
                                                    }
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
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpArrayLength):
                    {
                        notify_variable_access(args[1], ((uint)current_block.self));
                        break;
                    }
                    case unchecked((int)Spv.Op.OpLine):
                    case unchecked((int)Spv.Op.OpNoLine):
                    {
                        break;
                    }
                    case unchecked((int)Spv.Op.OpCompositeInsert):
                    case unchecked((int)Spv.Op.OpVectorShuffle):
                    {
                        {
                            for (uint i = 1u; i < 4u; i++)
                            {
                                notify_variable_access(args[i], ((uint)current_block.self));
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.Op.OpCompositeExtract):
                    {
                        {
                            for (uint i = 1u; i < 3u; i++)
                            {
                                notify_variable_access(args[i], ((uint)current_block.self));
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.Op.OpImageWrite):
                    {
                        {
                            for (uint i = 0u; i < length; i++)
                            {
                                if (i != 3u)
                                {
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.Op.OpImageSampleImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleProjExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleProjImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleProjExplicitLod):
                    case unchecked((int)Spv.Op.OpImageFetch):
                    case unchecked((int)Spv.Op.OpImageSparseFetch):
                    case unchecked((int)Spv.Op.OpImageRead):
                    case unchecked((int)Spv.Op.OpImageSparseRead):
                    {
                        {
                            for (uint i = 1u; i < length; i++)
                            {
                                if (i != 4u)
                                {
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleProjDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageGather):
                    case unchecked((int)Spv.Op.OpImageSparseGather):
                    case unchecked((int)Spv.Op.OpImageDrefGather):
                    case unchecked((int)Spv.Op.OpImageSparseDrefGather):
                    {
                        {
                            for (uint i = 1u; i < length; i++)
                            {
                                if (i != 5u)
                                {
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                        }
                        break;
                    }
                    default:
                    {
                        {
                            {
                                for (uint i = 0u; i < length; i++)
                                {
                                    notify_variable_access(args[i], ((uint)current_block.self));
                                }
                            }
                            break;
                        }
                    }
                }
            }
            return true;
        }
        public override bool handle_terminator(SPIRBlock block)
        {
            {
                switch (unchecked((int)block.terminator))
                {
                    case unchecked((int)SPIRBlock.Terminator.Return):
                    {
                        if (((uint)block.return_value) != 0u)
                        {
                            notify_variable_access(((uint)block.return_value), ((uint)block.self));
                        }
                        break;
                    }
                    case unchecked((int)SPIRBlock.Terminator.Select):
                    case unchecked((int)SPIRBlock.Terminator.MultiSelect):
                    {
                        notify_variable_access(((uint)block.condition), ((uint)block.self));
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            return true;
        }
        public SPIRFunction entry;
        public UnorderedMap<uint, UnorderedSet<uint>> accessed_variables_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
        public UnorderedMap<uint, UnorderedSet<uint>> accessed_temporaries_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
        public UnorderedMap<uint, uint> result_id_to_type = new UnorderedMap<uint, uint>();
        public UnorderedMap<uint, UnorderedSet<uint>> complete_write_variables_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
        public UnorderedMap<uint, UnorderedSet<uint>> partial_write_variables_to_block = new UnorderedMap<uint, UnorderedSet<uint>>();
        public UnorderedSet<uint> access_chain_expressions = new UnorderedSet<uint>();
        public UnorderedMap<uint, UnorderedSet<uint>> rvalue_forward_children = new UnorderedMap<uint, UnorderedSet<uint>>();
        public SPIRBlock current_block = null;

        protected override void FixClone()
        {
            base.FixClone();
            this.accessed_variables_to_block = this.accessed_variables_to_block.Clone(null, __e => __e.Clone());
            this.accessed_temporaries_to_block = this.accessed_temporaries_to_block.Clone(null, __e => __e.Clone());
            this.result_id_to_type = this.result_id_to_type.Clone();
            this.complete_write_variables_to_block = this.complete_write_variables_to_block.Clone(null, __e => __e.Clone());
            this.partial_write_variables_to_block = this.partial_write_variables_to_block.Clone(null, __e => __e.Clone());
            this.access_chain_expressions = this.access_chain_expressions.Clone();
            this.rvalue_forward_children = this.rvalue_forward_children.Clone(null, __e => __e.Clone());
        }

        public new AnalyzeVariableScopeAccessHandler Clone()
        {
            var __c = (AnalyzeVariableScopeAccessHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(AnalyzeVariableScopeAccessHandler o)
        {
            base.CopyFrom(o);
            this.entry = o.entry;
            this.accessed_variables_to_block = o.accessed_variables_to_block.Clone(null, __e => __e.Clone());
            this.accessed_temporaries_to_block = o.accessed_temporaries_to_block.Clone(null, __e => __e.Clone());
            this.result_id_to_type = o.result_id_to_type.Clone();
            this.complete_write_variables_to_block = o.complete_write_variables_to_block.Clone(null, __e => __e.Clone());
            this.partial_write_variables_to_block = o.partial_write_variables_to_block.Clone(null, __e => __e.Clone());
            this.access_chain_expressions = o.access_chain_expressions.Clone();
            this.rvalue_forward_children = o.rvalue_forward_children.Clone(null, __e => __e.Clone());
            this.current_block = o.current_block;
        }
    }

    public partial class BufferAccessHandler : Compiler.OpcodeHandler
    {
        public BufferAccessHandler(Compiler compiler_, CppVector<BufferRange> ranges_, uint id_) : base(compiler_)
        {
            this.ranges = ranges_;
            this.id = id_;
            this.seen = new UnorderedSet<uint>();
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint length)
        {
            if (unchecked((int)opcode) != unchecked((int)Spv.Op.OpAccessChain) && unchecked((int)opcode) != unchecked((int)Spv.Op.OpInBoundsAccessChain) && unchecked((int)opcode) != unchecked((int)Spv.Op.OpPtrAccessChain))
            {
                return true;
            }
            bool ptr_chain = unchecked((int)opcode) == unchecked((int)Spv.Op.OpPtrAccessChain);
            if (length < (ptr_chain ? 5u : 4u))
            {
                return false;
            }
            if (args[2] != id)
            {
                return true;
            }
            uint index = compiler.get__SPIRConstant(args[ptr_chain ? 4 : 3]).scalar(0u, 0u);
            if (seen.find(index) != Std.end(seen))
            {
                return true;
            }
            seen.insert(index);
            var type = compiler.expression_type(id);
            uint offset = compiler.type_struct_member_offset(type, index);
            ulong range = default;
            if (unchecked((ulong)(index + 1u)) < type.member_types.size())
            {
                range = unchecked((ulong)(compiler.type_struct_member_offset(type, index + 1u) - offset));
            }
            else
            {
                range = compiler.get_declared_struct_member_size(type, index);
            }
            ranges.push_back(new BufferRange { index = index, offset = unchecked((ulong)offset), range = range });
            return true;
        }
        public CppVector<BufferRange> ranges;
        public uint id;
        public UnorderedSet<uint> seen = new UnorderedSet<uint>();

        protected override void FixClone()
        {
            base.FixClone();
            this.seen = this.seen.Clone();
        }

        public new BufferAccessHandler Clone()
        {
            var __c = (BufferAccessHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(BufferAccessHandler o)
        {
            base.CopyFrom(o);
            this.ranges = o.ranges;
            this.id = o.id;
            this.seen = o.seen.Clone();
        }
    }

    public partial class CFGBuilder : Compiler.OpcodeHandler
    {
        public CFGBuilder(Compiler compiler_) : base(compiler_)
        {
            this.function_cfgs = new UnorderedMap<uint, CFG>();
        }
        public override bool follow_function_call(SPIRFunction func)
        {
            if (function_cfgs.find(((uint)func.self)) == Std.end(function_cfgs))
            {
                function_cfgs[((uint)func.self)] = new CFG(compiler, func);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override bool handle(Spv.Op _p0, Ptr<uint> _p1, uint _p2)
        {
            return true;
        }
        public UnorderedMap<uint, CFG> function_cfgs = new UnorderedMap<uint, CFG>();

        protected override void FixClone()
        {
            base.FixClone();
            this.function_cfgs = this.function_cfgs.Clone();
        }

        public new CFGBuilder Clone()
        {
            var __c = (CFGBuilder)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(CFGBuilder o)
        {
            base.CopyFrom(o);
            this.function_cfgs = o.function_cfgs.Clone();
        }
    }

    public partial class CombinedImageSamplerDrefHandler : Compiler.OpcodeHandler
    {
        public CombinedImageSamplerDrefHandler(Compiler compiler_) : base(compiler_)
        {
            this.dref_combined_samplers = new UnorderedSet<uint>();
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint _p0)
        {
            {
                switch (unchecked((int)opcode))
                {
                    case unchecked((int)Spv.Op.OpImageSampleDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleProjDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleDrefImplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageSparseSampleDrefExplicitLod):
                    case unchecked((int)Spv.Op.OpImageDrefGather):
                    case unchecked((int)Spv.Op.OpImageSparseDrefGather):
                    {
                        dref_combined_samplers.insert(args[2]);
                        return true;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            return true;
        }
        public UnorderedSet<uint> dref_combined_samplers = new UnorderedSet<uint>();

        protected override void FixClone()
        {
            base.FixClone();
            this.dref_combined_samplers = this.dref_combined_samplers.Clone();
        }

        public new CombinedImageSamplerDrefHandler Clone()
        {
            var __c = (CombinedImageSamplerDrefHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(CombinedImageSamplerDrefHandler o)
        {
            base.CopyFrom(o);
            this.dref_combined_samplers = o.dref_combined_samplers.Clone();
        }
    }

    public partial class CombinedImageSamplerHandler : Compiler.OpcodeHandler
    {
        public CombinedImageSamplerHandler(Compiler compiler_) : base(compiler_)
        {
            this.parameter_remapping = new CppStack<UnorderedMap<uint, uint>>();
            this.functions = new CppStack<SPIRFunction>();
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint length)
        {
            bool is_fetch = false;
            {
                switch (unchecked((int)opcode))
                {
                    case unchecked((int)Spv.Op.OpLoad):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint result_type = args[0];
                            var type = compiler.get__SPIRType(result_type);
                            bool separate_image = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 1u;
                            bool separate_sampler = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Sampler);
                            if (!separate_image && !separate_sampler)
                            {
                                return true;
                            }
                            uint id = args[1];
                            uint ptr = args[2];
                            compiler.set__SPIRExpression_X(id, "", result_type, true);
                            compiler.register_read(id, ptr, true);
                            return true;
                        }
                    }
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint result_type = args[0];
                            var type = compiler.get__SPIRType(result_type);
                            bool separate_image = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 1u;
                            bool separate_sampler = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Sampler);
                            if (separate_sampler)
                            {
                                throw new CompilerError("Attempting to use arrays or structs of separate samplers. This is not possible to statically remap to plain GLSL.");
                            }
                            if (separate_image)
                            {
                                uint id = args[1];
                                uint ptr = args[2];
                                compiler.set__SPIRExpression_X(id, "", result_type, true);
                                compiler.register_read(id, ptr, true);
                            }
                            return true;
                        }
                    }
                    case unchecked((int)Spv.Op.OpImageFetch):
                    case unchecked((int)Spv.Op.OpImageQuerySizeLod):
                    case unchecked((int)Spv.Op.OpImageQuerySize):
                    case unchecked((int)Spv.Op.OpImageQueryLevels):
                    case unchecked((int)Spv.Op.OpImageQuerySamples):
                    {
                        {
                            var @var = compiler.maybe_get_backing_variable(args[2]);
                            if (!(@var != null))
                            {
                                return true;
                            }
                            var type = compiler.get__SPIRType(((uint)@var.basetype));
                            if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 1u && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimBuffer))
                            {
                                if (compiler.dummy_sampler_id == 0u)
                                {
                                    throw new CompilerError("texelFetch without sampler was found, but no dummy sampler has been created with build_dummy_sampler_for_combined_images().");
                                }
                                is_fetch = true;
                                break;
                            }
                            return true;
                        }
                    }
                    case unchecked((int)Spv.Op.OpSampledImage):
                    {
                        break;
                    }
                    default:
                    {
                        return true;
                    }
                }
            }
            if (!functions.empty())
            {
                var callee = functions.top();
                if (callee.do_combined_parameters)
                {
                    uint image_id = args[2];
                    var image = compiler.maybe_get_backing_variable(image_id);
                    if (image != null)
                    {
                        image_id = ((uint)image.self);
                    }
                    uint sampler_id = is_fetch ? compiler.dummy_sampler_id : args[3];
                    var sampler = compiler.maybe_get_backing_variable(sampler_id);
                    if (sampler != null)
                    {
                        sampler_id = ((uint)sampler.self);
                    }
                    uint combined_id = args[1];
                    var combined_type = compiler.get__SPIRType(args[0]);
                    register_combined_image_sampler(callee, new TypedID_TypeVariable(combined_id), new TypedID_TypeVariable(image_id), new TypedID_TypeVariable(sampler_id), combined_type.image.depth);
                }
            }
            TypedID_TypeVariable image_id_1 = new TypedID_TypeVariable(remap_parameter(args[2]));
            TypedID_TypeVariable sampler_id_1 = new TypedID_TypeVariable(is_fetch ? compiler.dummy_sampler_id : remap_parameter(args[3]));
            var itr = Std.find_if(Std.begin(compiler.combined_image_samplers), Std.end(compiler.combined_image_samplers), (CombinedImageSampler combined) =>
            {
                return ((uint)combined.image_id) == ((uint)image_id_1) && ((uint)combined.sampler_id) == ((uint)sampler_id_1);
            });
            if (itr == Std.end(compiler.combined_image_samplers))
            {
                uint sampled_type = default;
                uint combined_module_id = default;
                if (is_fetch)
                {
                    sampled_type = compiler.ir.increase_bound_by(1u);
                    var type = compiler.set__SPIRType_X(sampled_type, Spv.Op.OpTypeSampledImage);
                    type.CopyFrom(compiler.expression_type(args[2]));
                    type.self = new TypedID_TypeNone(sampled_type);
                    type.basetype = SPIRType.BaseType.SampledImage;
                    type.image.depth = false;
                    combined_module_id = 0u;
                }
                else
                {
                    sampled_type = args[0];
                    combined_module_id = args[1];
                }
                var id = compiler.ir.increase_bound_by(2u);
                var type_id = id + 0u;
                var combined_id = id + 1u;
                var type_1 = compiler.set__SPIRType_X(type_id, Spv.Op.OpTypePointer);
                var @base = compiler.get__SPIRType(sampled_type);
                type_1.CopyFrom(@base);
                type_1.pointer = true;
                type_1.storage = Spv.StorageClass.StorageClassUniformConstant;
                type_1.parent_type = new TypedID_TypeType(type_id);
                compiler.set__SPIRVariable_X(combined_id, type_id, Spv.StorageClass.StorageClassUniformConstant, 0);
                bool relaxed_precision = ((uint)sampler_id_1) != 0u && compiler.has_decoration(new TypedID_TypeNone(sampler_id_1), Spv.Decoration.DecorationRelaxedPrecision) || ((uint)image_id_1) != 0u && compiler.has_decoration(new TypedID_TypeNone(image_id_1), Spv.Decoration.DecorationRelaxedPrecision) || combined_module_id != 0u && compiler.has_decoration(new TypedID_TypeNone(combined_module_id), Spv.Decoration.DecorationRelaxedPrecision);
                if (relaxed_precision)
                {
                    compiler.set_decoration(new TypedID_TypeNone(combined_id), Spv.Decoration.DecorationRelaxedPrecision, 0u);
                }
                var @var = compiler.maybe_get_backing_variable(((uint)image_id_1));
                if (@var != null)
                {
                    var parent_type = compiler.get__SPIRType(((uint)@var.basetype));
                    type_1.array.CopyFrom(parent_type.array.Clone());
                    type_1.array_size_literal.CopyFrom(parent_type.array_size_literal.Clone());
                }
                compiler.combined_image_samplers.push_back(new CombinedImageSampler { combined_id = new TypedID_TypeVariable(combined_id), image_id = image_id_1, sampler_id = sampler_id_1 });
            }
            return true;
        }
        public override bool begin_function_scope(Ptr<uint> args, uint length)
        {
            if (length < 3u)
            {
                return false;
            }
            var callee = compiler.get__SPIRFunction(args[2]);
            args += 3;
            length -= 3u;
            push_remap_parameters(callee, args, length);
            functions.push(callee);
            return true;
        }
        public override bool end_function_scope(Ptr<uint> args, uint length)
        {
            if (length < 3u)
            {
                return false;
            }
            var callee = compiler.get__SPIRFunction(args[2]);
            args += 3;
            pop_remap_parameters();
            callee.do_combined_parameters = false;
            var @params = functions.top().combined_parameters;
            functions.pop();
            if (functions.empty())
            {
                return true;
            }
            var caller = functions.top();
            if (caller.do_combined_parameters)
            {
                {
                    foreach (SPIRFunction.CombinedImageSamplerParameter param in @params)
                    {
                        TypedID_TypeVariable image_id = param.global_image ? param.image_id : new TypedID_TypeVariable(args[((uint)param.image_id)]);
                        TypedID_TypeVariable sampler_id = param.global_sampler ? param.sampler_id : new TypedID_TypeVariable(args[((uint)param.sampler_id)]);
                        var i = compiler.maybe_get_backing_variable(((uint)image_id));
                        var s = compiler.maybe_get_backing_variable(((uint)sampler_id));
                        if (i != null)
                        {
                            image_id = ((TypedID_TypeVariable)i.self);
                        }
                        if (s != null)
                        {
                            sampler_id = ((TypedID_TypeVariable)s.self);
                        }
                        register_combined_image_sampler(caller, new TypedID_TypeVariable(0u), image_id, sampler_id, param.depth);
                    }
                }
            }
            return true;
        }
        public CppStack<UnorderedMap<uint, uint>> parameter_remapping = new CppStack<UnorderedMap<uint, uint>>();
        public CppStack<SPIRFunction> functions = new CppStack<SPIRFunction>();
        public uint remap_parameter(uint id)
        {
            var @var = compiler.maybe_get_backing_variable(id);
            if (@var != null)
            {
                id = ((uint)@var.self);
            }
            if (parameter_remapping.empty())
            {
                return id;
            }
            ref var remapping = ref parameter_remapping.top();
            var itr = remapping.find(id);
            if (itr != Std.end(remapping))
            {
                return itr.deref().second;
            }
            else
            {
                return id;
            }
        }
        public void push_remap_parameters(SPIRFunction func, Ptr<uint> args, uint length)
        {
            UnorderedMap<uint, uint> remapping = new UnorderedMap<uint, uint>();
            {
                for (uint i = 0u; i < length; i++)
                {
                    remapping[((uint)func.arguments[unchecked((ulong)i)].id)] = remap_parameter(args[i]);
                }
            }
            parameter_remapping.push(remapping);
        }
        public void pop_remap_parameters()
        {
            parameter_remapping.pop();
        }
        public void register_combined_image_sampler(SPIRFunction caller, TypedID_TypeVariable combined_module_id, TypedID_TypeVariable image_id, TypedID_TypeVariable sampler_id, bool depth)
        {
            SPIRFunction.CombinedImageSamplerParameter param = new SPIRFunction.CombinedImageSamplerParameter { id = new TypedID_TypeVariable(0u), image_id = image_id, sampler_id = sampler_id, global_image = true, global_sampler = true, depth = depth };
            var texture_itr = Std.find_if(Std.begin(caller.arguments), Std.end(caller.arguments), (SPIRFunction.Parameter p) =>
            {
                return ((uint)p.id) == ((uint)image_id);
            });
            var sampler_itr = Std.find_if(Std.begin(caller.arguments), Std.end(caller.arguments), (SPIRFunction.Parameter p) =>
            {
                return ((uint)p.id) == ((uint)sampler_id);
            });
            if (texture_itr != Std.end(caller.arguments))
            {
                param.global_image = false;
                param.image_id = new TypedID_TypeVariable(unchecked((uint)(texture_itr - Std.begin(caller.arguments))));
            }
            if (sampler_itr != Std.end(caller.arguments))
            {
                param.global_sampler = false;
                param.sampler_id = new TypedID_TypeVariable(unchecked((uint)(sampler_itr - Std.begin(caller.arguments))));
            }
            if (param.global_image && param.global_sampler)
            {
                return;
            }
            var itr = Std.find_if(Std.begin(caller.combined_parameters), Std.end(caller.combined_parameters), (SPIRFunction.CombinedImageSamplerParameter p) =>
            {
                return ((uint)param.image_id) == ((uint)p.image_id) && ((uint)param.sampler_id) == ((uint)p.sampler_id) && (param.global_image ? 1 : 0) == (p.global_image ? 1 : 0) && (param.global_sampler ? 1 : 0) == (p.global_sampler ? 1 : 0);
            });
            if (itr == Std.end(caller.combined_parameters))
            {
                uint id = compiler.ir.increase_bound_by(3u);
                var type_id = id + 0u;
                var ptr_type_id = id + 1u;
                var combined_id = id + 2u;
                var @base = compiler.expression_type(((uint)image_id));
                var type = compiler.set__SPIRType_X(type_id, Spv.Op.OpTypeSampledImage);
                var ptr_type = compiler.set__SPIRType_X(ptr_type_id, Spv.Op.OpTypePointer);
                type.CopyFrom(@base);
                type.self = new TypedID_TypeNone(type_id);
                type.basetype = SPIRType.BaseType.SampledImage;
                type.pointer = false;
                type.storage = Spv.StorageClass.StorageClassGeneric;
                type.image.depth = depth;
                ptr_type.CopyFrom(type);
                ptr_type.pointer = true;
                ptr_type.storage = Spv.StorageClass.StorageClassUniformConstant;
                ptr_type.parent_type = new TypedID_TypeType(type_id);
                compiler.set__SPIRVariable_X(combined_id, ptr_type_id, Spv.StorageClass.StorageClassFunction, 0);
                bool relaxed_precision = compiler.has_decoration(new TypedID_TypeNone(sampler_id), Spv.Decoration.DecorationRelaxedPrecision) || compiler.has_decoration(new TypedID_TypeNone(image_id), Spv.Decoration.DecorationRelaxedPrecision) || ((uint)combined_module_id) != 0u && compiler.has_decoration(new TypedID_TypeNone(combined_module_id), Spv.Decoration.DecorationRelaxedPrecision);
                if (relaxed_precision)
                {
                    compiler.set_decoration(new TypedID_TypeNone(combined_id), Spv.Decoration.DecorationRelaxedPrecision, 0u);
                }
                param.id = new TypedID_TypeVariable(combined_id);
                compiler.set_name(new TypedID_TypeNone(combined_id), Std.join("SPIRV_Cross_Combined", compiler.to_name(((uint)image_id), true), compiler.to_name(((uint)sampler_id), true)));
                caller.combined_parameters.push_back(param.Clone());
                caller.shadow_arguments.push_back(new SPIRFunction.Parameter { type = new TypedID_TypeType(ptr_type_id), id = new TypedID_TypeNone(combined_id), read_count = 0u, write_count = 0u, alias_global_variable = true });
            }
        }

        protected override void FixClone()
        {
            base.FixClone();
            this.parameter_remapping = this.parameter_remapping.Clone(__e => __e.Clone());
            this.functions = this.functions.Clone();
        }

        public new CombinedImageSamplerHandler Clone()
        {
            var __c = (CombinedImageSamplerHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(CombinedImageSamplerHandler o)
        {
            base.CopyFrom(o);
            this.parameter_remapping = o.parameter_remapping.Clone(__e => __e.Clone());
            this.functions = o.functions.Clone();
        }
    }

    public partial class CombinedImageSamplerUsageHandler : Compiler.OpcodeHandler
    {
        public CombinedImageSamplerUsageHandler(Compiler compiler_, UnorderedSet<uint> dref_combined_samplers_) : base(compiler_)
        {
            this.dref_combined_samplers = dref_combined_samplers_;
            this.dependency_hierarchy = new UnorderedMap<uint, UnorderedSet<uint>>();
            this.comparison_ids = new UnorderedSet<uint>();
        }
        public override bool begin_function_scope(Ptr<uint> args, uint length)
        {
            if (length < 3u)
            {
                return false;
            }
            var func = compiler.get__SPIRFunction(args[2]);
            var arg = args + 3;
            length -= 3u;
            {
                for (uint i = 0u; i < length; i++)
                {
                    ref var argument = ref func.arguments[unchecked((ulong)i)];
                    add_dependency(((uint)argument.id), arg[i]);
                }
            }
            return true;
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint length)
        {
            {
                switch (unchecked((int)opcode))
                {
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    case unchecked((int)Spv.Op.OpLoad):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            add_dependency(args[1], args[2]);
                            var type = compiler.get__SPIRType(args[0]);
                            if (unchecked((int)type.image.dim) == unchecked((int)Spv.Dim.DimSubpassData))
                            {
                                need_subpass_input = true;
                                if (type.image.ms)
                                {
                                    need_subpass_input_ms = true;
                                }
                            }
                            if (dref_combined_samplers.count(args[1]) != 0UL)
                            {
                                add_hierarchy_to_comparison_ids(args[1]);
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpSampledImage):
                    {
                        {
                            if (length < 4u)
                            {
                                return false;
                            }
                            uint result_id = args[1];
                            uint image = args[2];
                            uint sampler = args[3];
                            if (dref_combined_samplers.count(result_id) != 0UL)
                            {
                                add_hierarchy_to_comparison_ids(image);
                                add_hierarchy_to_comparison_ids(sampler);
                                comparison_ids.insert(result_id);
                            }
                            return true;
                        }
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            return true;
        }
        public UnorderedSet<uint> dref_combined_samplers;
        public UnorderedMap<uint, UnorderedSet<uint>> dependency_hierarchy = new UnorderedMap<uint, UnorderedSet<uint>>();
        public UnorderedSet<uint> comparison_ids = new UnorderedSet<uint>();
        public void add_hierarchy_to_comparison_ids(uint id)
        {
            comparison_ids.insert(id);
            {
                foreach (uint dep_id in dependency_hierarchy[id])
                {
                    add_hierarchy_to_comparison_ids(dep_id);
                }
            }
        }
        public bool need_subpass_input = false;
        public bool need_subpass_input_ms = false;
        public void add_dependency(uint dst, uint src)
        {
            dependency_hierarchy[dst].insert(src);
            if (comparison_ids.count(src) != 0UL)
            {
                comparison_ids.insert(dst);
            }
        }

        protected override void FixClone()
        {
            base.FixClone();
            this.dependency_hierarchy = this.dependency_hierarchy.Clone(null, __e => __e.Clone());
            this.comparison_ids = this.comparison_ids.Clone();
        }

        public new CombinedImageSamplerUsageHandler Clone()
        {
            var __c = (CombinedImageSamplerUsageHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(CombinedImageSamplerUsageHandler o)
        {
            base.CopyFrom(o);
            this.dref_combined_samplers = o.dref_combined_samplers;
            this.dependency_hierarchy = o.dependency_hierarchy.Clone(null, __e => __e.Clone());
            this.comparison_ids = o.comparison_ids.Clone();
            this.need_subpass_input = o.need_subpass_input;
            this.need_subpass_input_ms = o.need_subpass_input_ms;
        }
    }

    public partial class DescriptorHeapMeta
    {
        public TypedID_TypeType data_type;
        public TypedID_TypeType name_type;
        public bool hlsl_style_stride;
        public TypedID_TypeNone buffer_pointer_id;
        public Spv.StorageClass storage;
        public bool nonwritable;
        public bool nonreadable;
        public bool coherent;
        public bool is_volatile;
        public bool is_restrict;

        protected virtual void FixClone()
        {
        }

        public DescriptorHeapMeta Clone()
        {
            var __c = (DescriptorHeapMeta)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(DescriptorHeapMeta o)
        {
            this.data_type = o.data_type;
            this.name_type = o.name_type;
            this.hlsl_style_stride = o.hlsl_style_stride;
            this.buffer_pointer_id = o.buffer_pointer_id;
            this.storage = o.storage;
            this.nonwritable = o.nonwritable;
            this.nonreadable = o.nonreadable;
            this.coherent = o.coherent;
            this.is_volatile = o.is_volatile;
            this.is_restrict = o.is_restrict;
        }
    }

    public partial class DummySamplerForCombinedImageHandler : Compiler.OpcodeHandler
    {
        public DummySamplerForCombinedImageHandler(Compiler compiler_) : base(compiler_)
        {
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint length)
        {
            if (need_dummy_sampler)
            {
                return false;
            }
            {
                switch (unchecked((int)opcode))
                {
                    case unchecked((int)Spv.Op.OpLoad):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint result_type = args[0];
                            var type = compiler.get__SPIRType(result_type);
                            bool separate_image = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 1u && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimBuffer);
                            if (!separate_image)
                            {
                                return true;
                            }
                            uint id = args[1];
                            uint ptr = args[2];
                            compiler.set__SPIRExpression_X(id, "", result_type, true);
                            compiler.register_read(id, ptr, true);
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpImageFetch):
                    case unchecked((int)Spv.Op.OpImageQuerySizeLod):
                    case unchecked((int)Spv.Op.OpImageQuerySize):
                    case unchecked((int)Spv.Op.OpImageQueryLevels):
                    case unchecked((int)Spv.Op.OpImageQuerySamples):
                    {
                        {
                            var @var = compiler.maybe_get_backing_variable(args[2]);
                            if (@var != null)
                            {
                                var type = compiler.get__SPIRType(((uint)@var.basetype));
                                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 1u && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimBuffer))
                                {
                                    need_dummy_sampler = true;
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint result_type = args[0];
                            var type = compiler.get__SPIRType(result_type);
                            bool separate_image = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 1u && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimBuffer);
                            if (!separate_image)
                            {
                                return true;
                            }
                            uint id = args[1];
                            uint ptr = args[2];
                            compiler.set__SPIRExpression_X(id, "", result_type, true);
                            compiler.register_read(id, ptr, true);
                            compiler.ir.ids[unchecked((ulong)id)].set_allow_type_rewrite();
                            break;
                        }
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            return true;
        }
        public bool need_dummy_sampler = false;

        protected override void FixClone()
        {
            base.FixClone();
        }

        public new DummySamplerForCombinedImageHandler Clone()
        {
            var __c = (DummySamplerForCombinedImageHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(DummySamplerForCombinedImageHandler o)
        {
            base.CopyFrom(o);
            this.need_dummy_sampler = o.need_dummy_sampler;
        }
    }

    public partial class GeometryEmitDisocveryHandler : Compiler.OpcodeHandler
    {
        public GeometryEmitDisocveryHandler(Compiler compiler_) : base(compiler_)
        {
            this.function_stack = new CppVector<SPIRFunction>();
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> _p0, uint _p1)
        {
            if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpEmitVertex) || unchecked((int)opcode) == unchecked((int)Spv.Op.OpEndPrimitive))
            {
                {
                    foreach (SPIRFunction func in function_stack)
                    {
                        func.emits_geometry = true;
                    }
                }
            }
            return true;
        }
        public override bool begin_function_scope(Ptr<uint> stream, uint _p0)
        {
            var callee = compiler.get__SPIRFunction(stream[2]);
            function_stack.push_back(callee);
            return true;
        }
        public override bool end_function_scope(Ptr<uint> stream, uint _p0)
        {
            _ = stream;
            function_stack.pop_back();
            return true;
        }
        public CppVector<SPIRFunction> function_stack = new CppVector<SPIRFunction>();

        protected override void FixClone()
        {
            base.FixClone();
            this.function_stack = this.function_stack.Clone();
        }

        public new GeometryEmitDisocveryHandler Clone()
        {
            var __c = (GeometryEmitDisocveryHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(GeometryEmitDisocveryHandler o)
        {
            base.CopyFrom(o);
            this.function_stack = o.function_stack.Clone();
        }
    }

    public partial class HeapHandler : Compiler.OpcodeHandler
    {
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint _p0)
        {
            {
                switch (unchecked((int)opcode))
                {
                    case unchecked((int)Spv.Op.OpBufferPointerEXT):
                    {
                        {
                            var ptr_type = compiler.get__SPIRType(args[0]);
                            if (unchecked((int)ptr_type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
                            {
                                Compiler.DescriptorHeapMeta meta = new Compiler.DescriptorHeapMeta { data_type = new TypedID_TypeType(), name_type = new TypedID_TypeType(), buffer_pointer_id = new TypedID_TypeNone() };
                                meta.data_type = ((TypedID_TypeType)ptr_type.self);
                                meta.hlsl_style_stride = hlsl_style_stride_access_chains.count(args[2]) != 0UL;
                                meta.buffer_pointer_id = new TypedID_TypeNone(args[1]);
                                meta.storage = ptr_type.storage;
                                meta.nonreadable = compiler.has_decoration(new TypedID_TypeNone(args[1]), Spv.Decoration.DecorationNonReadable);
                                meta.nonwritable = compiler.has_decoration(new TypedID_TypeNone(args[1]), Spv.Decoration.DecorationNonWritable);
                                meta.coherent = compiler.has_decoration(new TypedID_TypeNone(args[1]), Spv.Decoration.DecorationCoherent);
                                meta.is_restrict = compiler.has_decoration(new TypedID_TypeNone(args[1]), Spv.Decoration.DecorationRestrict);
                                meta.is_volatile = compiler.has_decoration(new TypedID_TypeNone(args[1]), Spv.Decoration.DecorationVolatile);
                                add_unique_type(meta);
                            }
                            buffer_pointers[args[1]].CopyFrom(new Compiler.HeapHandler.BufferPointerMeta { type = new TypedID_TypeType(args[0]), hlsl_style_stride = hlsl_style_stride_access_chains.count(args[2]) != 0UL });
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpUntypedAccessChainKHR):
                    case unchecked((int)Spv.Op.OpUntypedInBoundsAccessChainKHR):
                    case unchecked((int)Spv.Op.OpUntypedArrayLengthKHR):
                    {
                        {
                            var data_type = compiler.get__SPIRType(args[2]);
                            bool is_struct_wrapped_runtime_array = compiler.is_struct_wrapped_opaque_descriptor_array(data_type);
                            TypedID_TypeType descriptor_array_type_id = new TypedID_TypeType(args[2]);
                            if (is_struct_wrapped_runtime_array)
                            {
                                descriptor_array_type_id = data_type.member_types.front();
                                if (!compiler.has_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationOffset) && compiler.get_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationOffset) != 0u)
                                {
                                    TypedID_TypeNone offset_id = new TypedID_TypeNone(compiler.get_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationOffsetIdEXT));
                                    var c = compiler.maybe_get__SPIRConstant(((uint)offset_id));
                                    if (!(c != null) || c.specialization || c.scalar(0u, 0u) != 0u)
                                    {
                                        throw new CompilerError("Offset for resource heap must be constant 0.");
                                    }
                                }
                            }
                            if (compiler.is_pointer(data_type))
                            {
                                throw new CompilerError("pointer type not allowed.");
                            }
                            bool hlsl_style_stride = false;
                            if (unchecked((int)unchecked((Spv.BuiltIn)compiler.get_decoration(new TypedID_TypeNone(args[3]), Spv.Decoration.DecorationBuiltIn))) == unchecked((int)Spv.BuiltIn.BuiltInResourceHeapEXT))
                            {
                                if (!is_struct_wrapped_runtime_array && !Compiler.is_runtime_size_array(data_type))
                                {
                                    throw new CompilerError("Descriptor heap must be accessed as a runtime array.");
                                }
                                uint array_stride_id = compiler.get_decoration(new TypedID_TypeNone(descriptor_array_type_id), Spv.Decoration.DecorationArrayStrideIdEXT);
                                if (!(array_stride_id != 0u))
                                {
                                    throw new CompilerError("Expected ArrayStrideIdEXT to be set for resource heap.");
                                }
                                var spec_c = compiler.maybe_get__SPIRConstantOp(array_stride_id);
                                var c = compiler.maybe_get__SPIRConstant(array_stride_id);
                                if (!(spec_c != null) && !(c != null))
                                {
                                    throw new CompilerError("Array stride must be some constant expression.");
                                }
                                if (spec_c != null)
                                {
                                    if (unchecked((int)spec_c.opcode) == unchecked((int)Spv.Op.OpSelect))
                                    {
                                        var true_value = compiler.maybe_get__SPIRConstant(spec_c.arguments[1UL]);
                                        var false_value = compiler.maybe_get__SPIRConstant(spec_c.arguments[2UL]);
                                        hlsl_style_stride = true_value != null && ((uint)true_value.size_of_type) != 0u && false_value != null && ((uint)false_value.size_of_type) != 0u;
                                    }
                                    if (!hlsl_style_stride)
                                    {
                                        throw new CompilerError("Unusual pattern of descriptor stride detected. This probably cannot be expressed in current GLSL.");
                                    }
                                }
                                if (c != null && !(((uint)c.size_of_type) != 0u))
                                {
                                    throw new CompilerError("Resource heap array stride must be ConstantSizeOfEXT for high level languages.");
                                }
                                var descriptor_array_type = compiler.get__SPIRType(((uint)descriptor_array_type_id));
                                var element_type = compiler.get__SPIRType(((uint)descriptor_array_type.parent_type));
                                if (unchecked((int)element_type.basetype) == unchecked((int)SPIRType.BaseType.DescriptorHeapBuffer))
                                {
                                    if (c != null && unchecked((int)compiler.get__SPIRType(((uint)c.size_of_type)).basetype) != unchecked((int)SPIRType.BaseType.DescriptorHeapBuffer))
                                    {
                                        throw new CompilerError("Buffer descriptors in heap must be ConstantSizeOfEXT(OpTypeBufferEXT) for GLSL.");
                                    }
                                }
                                else
                                if (unchecked((int)element_type.basetype) == unchecked((int)SPIRType.BaseType.Image))
                                {
                                    if (c != null && unchecked((int)compiler.get__SPIRType(((uint)c.size_of_type)).basetype) != unchecked((int)SPIRType.BaseType.Image))
                                    {
                                        throw new CompilerError("Image descriptors in heap must be ConstantSizeOfEXT(OpTypeImage) for GLSL.");
                                    }
                                }
                                else
                                if (unchecked((int)element_type.basetype) == unchecked((int)SPIRType.BaseType.AccelerationStructure))
                                {
                                    if (c != null && unchecked((int)compiler.get__SPIRType(((uint)c.size_of_type)).basetype) != unchecked((int)SPIRType.BaseType.AccelerationStructure))
                                    {
                                        throw new CompilerError("RTAS descriptors in heap must be ConstantSizeOfEXT(OpTypeAccelerationStructure) for GLSL.");
                                    }
                                }
                            }
                            else
                            if (unchecked((int)unchecked((Spv.BuiltIn)compiler.get_decoration(new TypedID_TypeNone(args[3]), Spv.Decoration.DecorationBuiltIn))) == unchecked((int)Spv.BuiltIn.BuiltInSamplerHeapEXT))
                            {
                                if (!is_struct_wrapped_runtime_array && !Compiler.is_runtime_size_array(data_type))
                                {
                                    throw new CompilerError("Descriptor heap must be accessed as a runtime array.");
                                }
                                uint array_stride_id = compiler.get_decoration(new TypedID_TypeNone(descriptor_array_type_id), Spv.Decoration.DecorationArrayStrideIdEXT);
                                if (!(array_stride_id != 0u))
                                {
                                    throw new CompilerError("Expected ArrayStrideIdEXT to be set for sampler heap.");
                                }
                                var c = compiler.maybe_get__SPIRConstant(array_stride_id);
                                if (!(c != null) || !(((uint)c.size_of_type) != 0u) || unchecked((int)compiler.get__SPIRType(((uint)c.size_of_type)).basetype) != unchecked((int)SPIRType.BaseType.Sampler))
                                {
                                    throw new CompilerError("Sampler heap array stride must be ConstantSizeOfEXT(OpTypeSampler) for high level languages.");
                                }
                            }
                            if (hlsl_style_stride)
                            {
                                hlsl_style_stride_access_chains.insert(args[1]);
                            }
                            var element_type_1 = compiler.get__SPIRType(((uint)descriptor_array_type_id));
                            while (compiler.is_array(element_type_1))
                            {
                                element_type_1 = compiler.get__SPIRType(((uint)element_type_1.parent_type));
                            }
                            if (unchecked((int)element_type_1.basetype) == unchecked((int)SPIRType.BaseType.SampledImage))
                            {
                                throw new CompilerError("Attempting to access heap as combined sampler image. This does not make sense.");
                            }
                            else
                            if (unchecked((int)element_type_1.basetype) == unchecked((int)SPIRType.BaseType.Image) || unchecked((int)element_type_1.basetype) == unchecked((int)SPIRType.BaseType.AccelerationStructure) || unchecked((int)element_type_1.basetype) == unchecked((int)SPIRType.BaseType.Sampler))
                            {
                                Compiler.DescriptorHeapMeta meta = new Compiler.DescriptorHeapMeta { data_type = new TypedID_TypeType(), name_type = new TypedID_TypeType(), buffer_pointer_id = new TypedID_TypeNone() };
                                meta.data_type = ((TypedID_TypeType)element_type_1.self);
                                meta.name_type = ((TypedID_TypeType)data_type.self);
                                meta.hlsl_style_stride = hlsl_style_stride;
                                if (is_struct_wrapped_runtime_array)
                                {
                                    meta.nonreadable = compiler.has_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationNonReadable);
                                    meta.nonwritable = compiler.has_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationNonWritable);
                                    meta.coherent = compiler.has_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationCoherent);
                                    meta.is_volatile = compiler.has_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationVolatile);
                                    meta.is_restrict = compiler.has_member_decoration(((TypedID_TypeType)data_type.self), 0u, Spv.Decoration.DecorationRestrict);
                                }
                                add_unique_type(meta);
                            }
                            else
                            if (buffer_pointers.count(args[3]) != 0UL)
                            {
                                if (!compiler.has_decoration(element_type_1.self, Spv.Decoration.DecorationBlock) && !compiler.has_decoration(element_type_1.self, Spv.Decoration.DecorationBufferBlock))
                                {
                                    throw new CompilerError("BufferPointerEXT must reference a block type.");
                                }
                                ref var pointer_meta = ref buffer_pointers[args[3]];
                                var buffer_type = compiler.get__SPIRType(((uint)pointer_meta.type));
                                if (unchecked((int)buffer_type.basetype) == unchecked((int)SPIRType.BaseType.Void))
                                {
                                    Compiler.DescriptorHeapMeta meta = new Compiler.DescriptorHeapMeta { data_type = new TypedID_TypeType(), name_type = new TypedID_TypeType(), buffer_pointer_id = new TypedID_TypeNone() };
                                    meta.data_type = ((TypedID_TypeType)data_type.self);
                                    meta.hlsl_style_stride = pointer_meta.hlsl_style_stride;
                                    meta.buffer_pointer_id = new TypedID_TypeNone(args[3]);
                                    meta.storage = buffer_type.storage;
                                    meta.nonreadable = compiler.has_decoration(new TypedID_TypeNone(args[3]), Spv.Decoration.DecorationNonReadable);
                                    meta.nonwritable = compiler.has_decoration(new TypedID_TypeNone(args[3]), Spv.Decoration.DecorationNonWritable);
                                    meta.coherent = compiler.has_decoration(new TypedID_TypeNone(args[3]), Spv.Decoration.DecorationCoherent);
                                    meta.is_volatile = compiler.has_decoration(new TypedID_TypeNone(args[3]), Spv.Decoration.DecorationVolatile);
                                    meta.is_restrict = compiler.has_decoration(new TypedID_TypeNone(args[3]), Spv.Decoration.DecorationRestrict);
                                    add_unique_type(meta);
                                }
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
            return true;
        }
        public HeapHandler(Compiler compiler_) : base(compiler_)
        {
            this.heap_types = new CppVector<Compiler.DescriptorHeapMeta>();
            this.buffer_pointers = new UnorderedMap<uint, Compiler.HeapHandler.BufferPointerMeta>();
            this.hlsl_style_stride_access_chains = new UnorderedSet<uint>();
        }
        public CppVector<Compiler.DescriptorHeapMeta> heap_types = new CppVector<Compiler.DescriptorHeapMeta>();
        public UnorderedMap<uint, Compiler.HeapHandler.BufferPointerMeta> buffer_pointers = new UnorderedMap<uint, Compiler.HeapHandler.BufferPointerMeta>();
        public UnorderedSet<uint> hlsl_style_stride_access_chains = new UnorderedSet<uint>();
        public void add_unique_type(Compiler.DescriptorHeapMeta meta)
        {
            {
                foreach (Compiler.DescriptorHeapMeta type in heap_types)
                {
                    if (((uint)type.data_type) == ((uint)meta.data_type) && ((uint)type.name_type) == ((uint)meta.name_type) && unchecked((int)type.storage) == unchecked((int)meta.storage) && ((uint)type.buffer_pointer_id) == ((uint)meta.buffer_pointer_id) && (type.nonreadable ? 1 : 0) == (meta.nonreadable ? 1 : 0) && (type.nonwritable ? 1 : 0) == (meta.nonwritable ? 1 : 0) && (type.coherent ? 1 : 0) == (meta.coherent ? 1 : 0) && (type.is_restrict ? 1 : 0) == (meta.is_restrict ? 1 : 0) && (type.hlsl_style_stride ? 1 : 0) == (meta.hlsl_style_stride ? 1 : 0) && (type.is_volatile ? 1 : 0) == (meta.is_volatile ? 1 : 0))
                    {
                        return;
                    }
                }
            }
            heap_types.push_back(meta.Clone());
        }

        protected override void FixClone()
        {
            base.FixClone();
            this.heap_types = this.heap_types.Clone(__e => __e.Clone());
            this.buffer_pointers = this.buffer_pointers.Clone();
            this.hlsl_style_stride_access_chains = this.hlsl_style_stride_access_chains.Clone();
        }

        public new HeapHandler Clone()
        {
            var __c = (HeapHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(HeapHandler o)
        {
            base.CopyFrom(o);
            this.heap_types = o.heap_types.Clone(__e => __e.Clone());
            this.buffer_pointers = o.buffer_pointers.Clone();
            this.hlsl_style_stride_access_chains = o.hlsl_style_stride_access_chains.Clone();
        }

        public partial class BufferPointerMeta
        {
            public TypedID_TypeType type;
            public bool hlsl_style_stride;

            protected virtual void FixClone()
            {
            }

            public BufferPointerMeta Clone()
            {
                var __c = (BufferPointerMeta)MemberwiseClone();
                __c.FixClone();
                return __c;
            }

            public void CopyFrom(BufferPointerMeta o)
            {
                this.type = o.type;
                this.hlsl_style_stride = o.hlsl_style_stride;
            }
        }
    }

    public partial class InterfaceVariableAccessHandler : Compiler.OpcodeHandler
    {
        public InterfaceVariableAccessHandler(Compiler compiler_, UnorderedSet<TypedID_TypeVariable> variables_) : base(compiler_)
        {
            this.variables = variables_;
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint length)
        {
            uint variable = 0u;
            {
                switch (unchecked((int)opcode))
                {
                    default:
                    {
                        break;
                    }
                    case unchecked((int)Spv.Op.OpFunctionCall):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint count = length - 3u;
                            args += 3;
                            {
                                for (uint i = 0u; i < count; i++)
                                {
                                    var @var = compiler.maybe_get__SPIRVariable(args[i]);
                                    if (@var != null && Globals.storage_class_is_interface(@var.storage))
                                    {
                                        variables.insert(new TypedID_TypeVariable(args[i]));
                                    }
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpSelect):
                    {
                        {
                            if (length < 5u)
                            {
                                return false;
                            }
                            uint count = length - 3u;
                            args += 3;
                            {
                                for (uint i = 0u; i < count; i++)
                                {
                                    var @var = compiler.maybe_get__SPIRVariable(args[i]);
                                    if (@var != null && Globals.storage_class_is_interface(@var.storage))
                                    {
                                        variables.insert(new TypedID_TypeVariable(args[i]));
                                    }
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpPhi):
                    {
                        {
                            if (length < 2u)
                            {
                                return false;
                            }
                            uint count = length - 2u;
                            args += 2;
                            {
                                for (uint i = 0u; i < count; i += 2u)
                                {
                                    var @var = compiler.maybe_get__SPIRVariable(args[i]);
                                    if (@var != null && Globals.storage_class_is_interface(@var.storage))
                                    {
                                        variables.insert(new TypedID_TypeVariable(args[i]));
                                    }
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpAtomicStore):
                    case unchecked((int)Spv.Op.OpStore):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                    {
                        if (length < 1u)
                        {
                            return false;
                        }
                        variable = args[0];
                        break;
                    }
                    case unchecked((int)Spv.Op.OpCopyMemory):
                    {
                        {
                            if (length < 2u)
                            {
                                return false;
                            }
                            var @var = compiler.maybe_get__SPIRVariable(args[0]);
                            if (@var != null && Globals.storage_class_is_interface(@var.storage))
                            {
                                variables.insert(new TypedID_TypeVariable(args[0]));
                            }
                            @var = compiler.maybe_get__SPIRVariable(args[1]);
                            if (@var != null && Globals.storage_class_is_interface(@var.storage))
                            {
                                variables.insert(new TypedID_TypeVariable(args[1]));
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpExtInst):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            var extension_set = compiler.get__SPIRExtension(args[2]);
                            {
                                switch (unchecked((int)extension_set.ext))
                                {
                                    case unchecked((int)SPIRExtension.Extension.GLSL):
                                    {
                                        {
                                            var op = unchecked((GLSLstd450)args[3]);
                                            {
                                                switch (unchecked((int)op))
                                                {
                                                    case unchecked((int)GLSLstd450.GLSLstd450InterpolateAtCentroid):
                                                    case unchecked((int)GLSLstd450.GLSLstd450InterpolateAtSample):
                                                    case unchecked((int)GLSLstd450.GLSLstd450InterpolateAtOffset):
                                                    {
                                                        {
                                                            var @var = compiler.maybe_get__SPIRVariable(args[4]);
                                                            if (@var != null && Globals.storage_class_is_interface(@var.storage))
                                                            {
                                                                variables.insert(new TypedID_TypeVariable(args[4]));
                                                            }
                                                            break;
                                                        }
                                                    }
                                                    case unchecked((int)GLSLstd450.GLSLstd450Modf):
                                                    case unchecked((int)GLSLstd450.GLSLstd450Fract):
                                                    {
                                                        {
                                                            var @var = compiler.maybe_get__SPIRVariable(args[5]);
                                                            if (@var != null && Globals.storage_class_is_interface(@var.storage))
                                                            {
                                                                variables.insert(new TypedID_TypeVariable(args[5]));
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
                                            break;
                                        }
                                    }
                                    case unchecked((int)SPIRExtension.Extension.SPV_AMD_shader_explicit_vertex_parameter):
                                    {
                                        {
                                            var op = unchecked((Compiler.InterfaceVariableAccessHandler.AMDShaderExplicitVertexParameter)args[3]);
                                            {
                                                switch (unchecked((int)op))
                                                {
                                                    case unchecked((int)Compiler.InterfaceVariableAccessHandler.AMDShaderExplicitVertexParameter.InterpolateAtVertexAMD):
                                                    {
                                                        {
                                                            var @var = compiler.maybe_get__SPIRVariable(args[4]);
                                                            if (@var != null && Globals.storage_class_is_interface(@var.storage))
                                                            {
                                                                variables.insert(new TypedID_TypeVariable(args[4]));
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
                                            break;
                                        }
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
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    case unchecked((int)Spv.Op.OpLoad):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                    case unchecked((int)Spv.Op.OpCopyObject):
                    case unchecked((int)Spv.Op.OpImageTexelPointer):
                    case unchecked((int)Spv.Op.OpAtomicLoad):
                    case unchecked((int)Spv.Op.OpAtomicExchange):
                    case unchecked((int)Spv.Op.OpAtomicCompareExchange):
                    case unchecked((int)Spv.Op.OpAtomicCompareExchangeWeak):
                    case unchecked((int)Spv.Op.OpAtomicIIncrement):
                    case unchecked((int)Spv.Op.OpAtomicIDecrement):
                    case unchecked((int)Spv.Op.OpAtomicIAdd):
                    case unchecked((int)Spv.Op.OpAtomicISub):
                    case unchecked((int)Spv.Op.OpAtomicSMin):
                    case unchecked((int)Spv.Op.OpAtomicUMin):
                    case unchecked((int)Spv.Op.OpAtomicSMax):
                    case unchecked((int)Spv.Op.OpAtomicUMax):
                    case unchecked((int)Spv.Op.OpAtomicAnd):
                    case unchecked((int)Spv.Op.OpAtomicOr):
                    case unchecked((int)Spv.Op.OpAtomicXor):
                    case unchecked((int)Spv.Op.OpArrayLength):
                    {
                        if (length < 3u)
                        {
                            return false;
                        }
                        variable = args[2];
                        break;
                    }
                }
            }
            if (variable != 0u)
            {
                var @var = compiler.maybe_get__SPIRVariable(variable);
                if (@var != null && Globals.storage_class_is_interface(@var.storage))
                {
                    variables.insert(new TypedID_TypeVariable(variable));
                }
            }
            return true;
        }
        public UnorderedSet<TypedID_TypeVariable> variables;

        protected override void FixClone()
        {
            base.FixClone();
        }

        public new InterfaceVariableAccessHandler Clone()
        {
            var __c = (InterfaceVariableAccessHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(InterfaceVariableAccessHandler o)
        {
            base.CopyFrom(o);
            this.variables = o.variables;
        }

        public enum AMDShaderExplicitVertexParameter : int
        {
            InterpolateAtVertexAMD = 1,
        }
    }

    public partial class InterlockedResourceAccessHandler : Compiler.OpcodeHandler
    {
        public InterlockedResourceAccessHandler(Compiler compiler_, uint entry_point_id) : base(compiler_)
        {
            this.call_stack = new CppVector<uint>();
            call_stack.push_back(entry_point_id);
        }
        public override bool handle(Spv.Op opcode, Ptr<uint> args, uint length)
        {
            if (use_critical_section)
            {
                if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpBeginInvocationInterlockEXT))
                {
                    in_crit_sec = true;
                    return true;
                }
                if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpEndInvocationInterlockEXT))
                {
                    return false;
                }
            }
            {
                switch (unchecked((int)opcode))
                {
                    case unchecked((int)Spv.Op.OpLoad):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                    case unchecked((int)Spv.Op.OpCooperativeVectorLoadNV):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint ptr = args[2];
                            var @var = compiler.maybe_get_backing_variable(ptr);
                            if (!(@var != null))
                            {
                                break;
                            }
                            {
                                switch (unchecked((int)@var.storage))
                                {
                                    default:
                                    {
                                        break;
                                    }
                                    case unchecked((int)Spv.StorageClass.StorageClassUniformConstant):
                                    {
                                        {
                                            uint result_type = args[0];
                                            uint id = args[1];
                                            compiler.set__SPIRExpression_X(id, "", result_type, true);
                                            compiler.register_read(id, ptr, true);
                                            break;
                                        }
                                    }
                                    case unchecked((int)Spv.StorageClass.StorageClassUniform):
                                    {
                                        if (!compiler.has_decoration(compiler.get__SPIRType(((uint)@var.basetype)).self, Spv.Decoration.DecorationBufferBlock))
                                        {
                                            break;
                                        }
                                        goto case unchecked((int)Spv.StorageClass.StorageClassStorageBuffer);
                                    }
                                    case unchecked((int)Spv.StorageClass.StorageClassStorageBuffer):
                                    {
                                        access_potential_resource(((uint)@var.self));
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint result_type = args[0];
                            var type = compiler.get__SPIRType(result_type);
                            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer))
                            {
                                uint id = args[1];
                                uint ptr = args[2];
                                compiler.set__SPIRExpression_X(id, "", result_type, true);
                                compiler.register_read(id, ptr, true);
                                compiler.ir.ids[unchecked((ulong)id)].set_allow_type_rewrite();
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpImageTexelPointer):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint result_type = args[0];
                            uint id = args[1];
                            uint ptr = args[2];
                            var e = compiler.set__SPIRExpression_X(id, "", result_type, true);
                            var @var = compiler.maybe_get_backing_variable(ptr);
                            if (@var != null)
                            {
                                e.loaded_from = @var.self;
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpStore):
                    case unchecked((int)Spv.Op.OpImageWrite):
                    case unchecked((int)Spv.Op.OpAtomicStore):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                    case unchecked((int)Spv.Op.OpCooperativeVectorStoreNV):
                    {
                        {
                            if (length < 1u)
                            {
                                return false;
                            }
                            uint ptr = args[0];
                            var @var = compiler.maybe_get_backing_variable(ptr);
                            if (@var != null && (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer)))
                            {
                                access_potential_resource(((uint)@var.self));
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpCopyMemory):
                    {
                        {
                            if (length < 2u)
                            {
                                return false;
                            }
                            uint dst = args[0];
                            uint src = args[1];
                            var dst_var = compiler.maybe_get_backing_variable(dst);
                            var src_var = compiler.maybe_get_backing_variable(src);
                            if (dst_var != null && (unchecked((int)dst_var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)dst_var.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer)))
                            {
                                access_potential_resource(((uint)dst_var.self));
                            }
                            if (src_var != null)
                            {
                                if (unchecked((int)src_var.storage) != unchecked((int)Spv.StorageClass.StorageClassUniform) && unchecked((int)src_var.storage) != unchecked((int)Spv.StorageClass.StorageClassStorageBuffer))
                                {
                                    break;
                                }
                                if (unchecked((int)src_var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) && !compiler.has_decoration(compiler.get__SPIRType(((uint)src_var.basetype)).self, Spv.Decoration.DecorationBufferBlock))
                                {
                                    break;
                                }
                                access_potential_resource(((uint)src_var.self));
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpImageRead):
                    case unchecked((int)Spv.Op.OpAtomicLoad):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint ptr = args[2];
                            var @var = compiler.maybe_get_backing_variable(ptr);
                            if (!(@var != null))
                            {
                                break;
                            }
                            {
                                switch (unchecked((int)@var.storage))
                                {
                                    default:
                                    {
                                        break;
                                    }
                                    case unchecked((int)Spv.StorageClass.StorageClassUniform):
                                    {
                                        if (!compiler.has_decoration(compiler.get__SPIRType(((uint)@var.basetype)).self, Spv.Decoration.DecorationBufferBlock))
                                        {
                                            break;
                                        }
                                        goto case unchecked((int)Spv.StorageClass.StorageClassUniformConstant);
                                    }
                                    case unchecked((int)Spv.StorageClass.StorageClassUniformConstant):
                                    case unchecked((int)Spv.StorageClass.StorageClassStorageBuffer):
                                    {
                                        access_potential_resource(((uint)@var.self));
                                        break;
                                    }
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpAtomicExchange):
                    case unchecked((int)Spv.Op.OpAtomicCompareExchange):
                    case unchecked((int)Spv.Op.OpAtomicIIncrement):
                    case unchecked((int)Spv.Op.OpAtomicIDecrement):
                    case unchecked((int)Spv.Op.OpAtomicIAdd):
                    case unchecked((int)Spv.Op.OpAtomicISub):
                    case unchecked((int)Spv.Op.OpAtomicSMin):
                    case unchecked((int)Spv.Op.OpAtomicUMin):
                    case unchecked((int)Spv.Op.OpAtomicSMax):
                    case unchecked((int)Spv.Op.OpAtomicUMax):
                    case unchecked((int)Spv.Op.OpAtomicAnd):
                    case unchecked((int)Spv.Op.OpAtomicOr):
                    case unchecked((int)Spv.Op.OpAtomicXor):
                    {
                        {
                            if (length < 3u)
                            {
                                return false;
                            }
                            uint ptr = args[2];
                            var @var = compiler.maybe_get_backing_variable(ptr);
                            if (@var != null && (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer)))
                            {
                                access_potential_resource(((uint)@var.self));
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
            return true;
        }
        public override bool begin_function_scope(Ptr<uint> args, uint length)
        {
            if (length < 3u)
            {
                return false;
            }
            if (args[2] == interlock_function_id)
            {
                call_stack_is_interlocked = true;
            }
            call_stack.push_back(args[2]);
            return true;
        }
        public override bool end_function_scope(Ptr<uint> _p0, uint _p1)
        {
            if (call_stack.back() == interlock_function_id)
            {
                call_stack_is_interlocked = false;
            }
            call_stack.pop_back();
            return true;
        }
        public bool in_crit_sec = false;
        public uint interlock_function_id = 0u;
        public bool split_function_case = false;
        public bool control_flow_interlock = false;
        public bool use_critical_section = false;
        public bool call_stack_is_interlocked = false;
        public CppVector<uint> call_stack = new CppVector<uint>();
        public void access_potential_resource(uint id)
        {
            if (use_critical_section && in_crit_sec || control_flow_interlock && call_stack_is_interlocked || split_function_case)
            {
                compiler.interlocked_resources.insert(id);
            }
        }

        protected override void FixClone()
        {
            base.FixClone();
            this.call_stack = this.call_stack.Clone();
        }

        public new InterlockedResourceAccessHandler Clone()
        {
            var __c = (InterlockedResourceAccessHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(InterlockedResourceAccessHandler o)
        {
            base.CopyFrom(o);
            this.in_crit_sec = o.in_crit_sec;
            this.interlock_function_id = o.interlock_function_id;
            this.split_function_case = o.split_function_case;
            this.control_flow_interlock = o.control_flow_interlock;
            this.use_critical_section = o.use_critical_section;
            this.call_stack_is_interlocked = o.call_stack_is_interlocked;
            this.call_stack = o.call_stack.Clone();
        }
    }

    public partial class InterlockedResourceAccessPrepassHandler : Compiler.OpcodeHandler
    {
        public InterlockedResourceAccessPrepassHandler(Compiler compiler_, uint entry_point_id) : base(compiler_)
        {
            this.call_stack = new CppVector<uint>();
            call_stack.push_back(entry_point_id);
        }
        public override void rearm_current_block(SPIRBlock block)
        {
            current_block_id = ((uint)block.self);
        }
        public override bool handle(Spv.Op op, Ptr<uint> _p0, uint _p1)
        {
            if (unchecked((int)op) == unchecked((int)Spv.Op.OpBeginInvocationInterlockEXT) || unchecked((int)op) == unchecked((int)Spv.Op.OpEndInvocationInterlockEXT))
            {
                if (interlock_function_id != 0u && interlock_function_id != call_stack.back())
                {
                    split_function_case = true;
                    return false;
                }
                else
                {
                    interlock_function_id = call_stack.back();
                    var cfg = compiler.get_cfg_for_function(interlock_function_id);
                    uint from_block_id = ((uint)compiler.get__SPIRFunction(interlock_function_id).entry_block);
                    bool outside_control_flow = cfg.node_terminates_control_flow_in_sub_graph(new TypedID_TypeBlock(from_block_id), new TypedID_TypeBlock(current_block_id));
                    if (!outside_control_flow)
                    {
                        control_flow_interlock = true;
                    }
                }
            }
            return true;
        }
        public override bool begin_function_scope(Ptr<uint> args, uint length)
        {
            if (length < 3u)
            {
                return false;
            }
            call_stack.push_back(args[2]);
            return true;
        }
        public override bool end_function_scope(Ptr<uint> _p0, uint _p1)
        {
            call_stack.pop_back();
            return true;
        }
        public uint interlock_function_id = 0u;
        public uint current_block_id = 0u;
        public bool split_function_case = false;
        public bool control_flow_interlock = false;
        public CppVector<uint> call_stack = new CppVector<uint>();

        protected override void FixClone()
        {
            base.FixClone();
            this.call_stack = this.call_stack.Clone();
        }

        public new InterlockedResourceAccessPrepassHandler Clone()
        {
            var __c = (InterlockedResourceAccessPrepassHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(InterlockedResourceAccessPrepassHandler o)
        {
            base.CopyFrom(o);
            this.interlock_function_id = o.interlock_function_id;
            this.current_block_id = o.current_block_id;
            this.split_function_case = o.split_function_case;
            this.control_flow_interlock = o.control_flow_interlock;
            this.call_stack = o.call_stack.Clone();
        }
    }

    public abstract partial class OpcodeHandler
    {
        public OpcodeHandler(Compiler compiler_)
        {
            this.compiler = compiler_;
            this.result_types = new UnorderedMap<uint, uint>();
        }
        public abstract bool handle(Spv.Op opcode, Ptr<uint> args, uint length);
        public virtual bool handle_terminator(SPIRBlock _p0)
        {
            return true;
        }
        public virtual bool follow_function_call(SPIRFunction _p0)
        {
            return true;
        }
        public virtual void set_current_block(SPIRBlock _p0)
        {
        }
        public virtual void rearm_current_block(SPIRBlock _p0)
        {
        }
        public virtual bool begin_function_scope(Ptr<uint> _p0, uint _p1)
        {
            return true;
        }
        public virtual bool end_function_scope(Ptr<uint> _p0, uint _p1)
        {
            return true;
        }
        public Compiler compiler;
        public UnorderedMap<uint, uint> result_types = new UnorderedMap<uint, uint>();
        public SPIRType get_expression_result_type(uint id)
        {
            var itr = result_types.find(id);
            if (itr == result_types.end())
            {
                return null;
            }
            return compiler.get__SPIRType(itr.deref().second);
        }
        public bool enable_result_types = false;
        public SPIRType get__SPIRType(uint id)
        {
            return compiler.get__SPIRType(id);
        }
        public SPIRExtension get__SPIRExtension(uint id)
        {
            return compiler.get__SPIRExtension(id);
        }
        public SPIRVariable get__SPIRVariable(uint id)
        {
            return compiler.get__SPIRVariable(id);
        }
        public SPIRExpression set__SPIRExpression_X(uint id, string args, uint args_1, bool args_2)
        {
            return compiler.set__SPIRExpression_X(id, args, args_1, args_2);
        }

        protected virtual void FixClone()
        {
            this.result_types = this.result_types.Clone();
        }

        public void CopyFrom(OpcodeHandler o)
        {
            this.compiler = o.compiler;
            this.result_types = o.result_types.Clone();
            this.enable_result_types = o.enable_result_types;
        }
    }

    public partial class PhysicalBlockMeta
    {
        public uint alignment = 0u;

        protected virtual void FixClone()
        {
        }

        public PhysicalBlockMeta Clone()
        {
            var __c = (PhysicalBlockMeta)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(PhysicalBlockMeta o)
        {
            this.alignment = o.alignment;
        }
    }

    public partial class PhysicalStorageBufferPointerHandler : Compiler.OpcodeHandler
    {
        public PhysicalStorageBufferPointerHandler(Compiler compiler_) : base(compiler_)
        {
            this.non_block_types = new UnorderedSet<uint>();
            this.physical_block_type_meta = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
            this.access_chain_to_physical_block = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
            this.analyzed_type_ids = new UnorderedSet<uint>();
        }
        public override bool handle(Spv.Op op, Ptr<uint> args, uint length)
        {
            {
                switch (unchecked((int)op))
                {
                    case unchecked((int)Spv.Op.OpConvertUToPtr):
                    case unchecked((int)Spv.Op.OpBitcast):
                    case unchecked((int)Spv.Op.OpCompositeExtract):
                    {
                        setup_meta_chain(args[0], args[1]);
                        break;
                    }
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    case unchecked((int)Spv.Op.OpCopyObject):
                    {
                        {
                            var itr = access_chain_to_physical_block.find(args[2]);
                            if (itr != access_chain_to_physical_block.end())
                            {
                                access_chain_to_physical_block[args[1]] = itr.deref().second;
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpLoad):
                    {
                        {
                            setup_meta_chain(args[0], args[1]);
                            if (length >= 4u)
                            {
                                mark_aligned_access(args[2], args + 3, length - 3u);
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpStore):
                    {
                        {
                            if (length >= 3u)
                            {
                                mark_aligned_access(args[0], args + 2, length - 2u);
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                    {
                        {
                            break;
                        }
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            return true;
        }
        public UnorderedSet<uint> non_block_types = new UnorderedSet<uint>();
        public UnorderedMap<uint, Compiler.PhysicalBlockMeta> physical_block_type_meta = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
        public UnorderedMap<uint, Compiler.PhysicalBlockMeta> access_chain_to_physical_block = new UnorderedMap<uint, Compiler.PhysicalBlockMeta>();
        public UnorderedSet<uint> analyzed_type_ids = new UnorderedSet<uint>();
        public void mark_aligned_access(uint id, Ptr<uint> args, uint length)
        {
            uint mask = args.Value;
            args++;
            length--;
            if (length != 0u && (mask & unchecked((uint)Spv.MemoryAccessMask.MemoryAccessVolatileMask)) != 0u)
            {
                args++;
                length--;
            }
            if (length != 0u && (mask & unchecked((uint)Spv.MemoryAccessMask.MemoryAccessAlignedMask)) != 0u)
            {
                uint alignment = args.Value;
                var meta = find_block_meta(id);
                if (meta != null && alignment > meta.alignment)
                {
                    meta.alignment = alignment;
                }
            }
        }
        public Compiler.PhysicalBlockMeta find_block_meta(uint id)
        {
            var chain_itr = access_chain_to_physical_block.find(id);
            if (chain_itr != access_chain_to_physical_block.end())
            {
                return chain_itr.deref().second;
            }
            else
            {
                return null;
            }
        }
        public bool type_is_bda_block_entry(uint type_id)
        {
            var type = compiler.get__SPIRType(type_id);
            return compiler.is_physical_pointer(type);
        }
        public void setup_meta_chain(uint type_id, uint var_id)
        {
            if (type_is_bda_block_entry(type_id))
            {
                ref var meta = ref physical_block_type_meta[type_id];
                access_chain_to_physical_block[var_id] = meta;
                var type = compiler.get__SPIRType(type_id);
                if (!compiler.is_physical_pointer_to_buffer_block(type))
                {
                    non_block_types.insert(type_id);
                }
                if (meta.alignment == 0u)
                {
                    meta.alignment = get_minimum_scalar_alignment(compiler.get_pointee_type(type));
                }
            }
        }
        public uint get_minimum_scalar_alignment(SPIRType type)
        {
            if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer))
            {
                return 8u;
            }
            else
            if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
            {
                uint alignment = 0u;
                {
                    foreach (TypedID_TypeType member_type in type.member_types)
                    {
                        uint member_align = get_minimum_scalar_alignment(compiler.get__SPIRType(((uint)member_type)));
                        if (member_align > alignment)
                        {
                            alignment = member_align;
                        }
                    }
                }
                return alignment;
            }
            else
            {
                return type.width / 8u;
            }
        }
        public void analyze_non_block_types_from_block(SPIRType type)
        {
            if (analyzed_type_ids.count(((uint)type.self)) != 0UL)
            {
                return;
            }
            analyzed_type_ids.insert(((uint)type.self));
            {
                foreach (TypedID_TypeType member in type.member_types)
                {
                    var subtype = compiler.get__SPIRType(((uint)member));
                    if (compiler.is_physical_pointer(subtype) && !compiler.is_physical_pointer_to_buffer_block(subtype))
                    {
                        non_block_types.insert(get_base_non_block_type_id(((uint)member)));
                    }
                    else
                    if (unchecked((int)subtype.basetype) == unchecked((int)SPIRType.BaseType.Struct) && !compiler.is_pointer(subtype))
                    {
                        analyze_non_block_types_from_block(subtype);
                    }
                }
            }
        }
        public uint get_base_non_block_type_id(uint type_id)
        {
            var type = compiler.get__SPIRType(type_id);
            while (compiler.is_physical_pointer(type) && !type_is_bda_block_entry(type_id))
            {
                type_id = ((uint)type.parent_type);
                type = compiler.get__SPIRType(type_id);
            }
            return type_id;
        }

        protected override void FixClone()
        {
            base.FixClone();
            this.non_block_types = this.non_block_types.Clone();
            this.physical_block_type_meta = this.physical_block_type_meta.Clone(null, __e => __e.Clone());
            this.access_chain_to_physical_block = this.access_chain_to_physical_block.Clone();
            this.analyzed_type_ids = this.analyzed_type_ids.Clone();
        }

        public new PhysicalStorageBufferPointerHandler Clone()
        {
            var __c = (PhysicalStorageBufferPointerHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(PhysicalStorageBufferPointerHandler o)
        {
            base.CopyFrom(o);
            this.non_block_types = o.non_block_types.Clone();
            this.physical_block_type_meta = o.physical_block_type_meta.Clone(null, __e => __e.Clone());
            this.access_chain_to_physical_block = o.access_chain_to_physical_block.Clone();
            this.analyzed_type_ids = o.analyzed_type_ids.Clone();
        }
    }

    public partial class StaticExpressionAccessHandler : Compiler.OpcodeHandler
    {
        public StaticExpressionAccessHandler(Compiler compiler_, uint variable_id_) : base(compiler_)
        {
            this.variable_id = variable_id_;
        }
        public override bool follow_function_call(SPIRFunction _p0)
        {
            return false;
        }
        public override bool handle(Spv.Op op, Ptr<uint> args, uint length)
        {
            {
                switch (unchecked((int)op))
                {
                    case unchecked((int)Spv.Op.OpStore):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                    {
                        if (length < 2u)
                        {
                            return false;
                        }
                        if (args[0] == variable_id)
                        {
                            static_expression = args[1];
                            write_count++;
                        }
                        break;
                    }
                    case unchecked((int)Spv.Op.OpLoad):
                    case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                    {
                        if (length < 3u)
                        {
                            return false;
                        }
                        if (args[2] == variable_id && static_expression == 0u)
                        {
                            return false;
                        }
                        break;
                    }
                    case unchecked((int)Spv.Op.OpAccessChain):
                    case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                    case unchecked((int)Spv.Op.OpPtrAccessChain):
                    {
                        if (length < 3u)
                        {
                            return false;
                        }
                        if (args[2] == variable_id)
                        {
                            return false;
                        }
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            return true;
        }
        public uint variable_id;
        public uint static_expression = 0u;
        public uint write_count = 0u;

        protected override void FixClone()
        {
            base.FixClone();
        }

        public new StaticExpressionAccessHandler Clone()
        {
            var __c = (StaticExpressionAccessHandler)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(StaticExpressionAccessHandler o)
        {
            base.CopyFrom(o);
            this.variable_id = o.variable_id;
            this.static_expression = o.static_expression;
            this.write_count = o.write_count;
        }
    }
}
