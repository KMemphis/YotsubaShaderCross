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
// Upstream sources: spirv_hlsl.cpp, spirv_hlsl.hpp
// Upstream copyright: Copyright 2016-2021 Robert Konrad
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class CompilerHLSL : CompilerGLSL
{
    public CompilerHLSL(CppVector<uint> spirv_) : base(spirv_)
    {
        this.hlsl_options = new CompilerHLSL.Options();
        this.required_texture_size_variants = new CompilerHLSL.TextureSizeVariants();
        this.remap_vertex_attributes = new CppVector<HLSLVertexAttributeRemap>();
        this.root_constants_layout = new CppVector<RootConstants>();
        this.resource_bindings = new UnorderedMap<StageSetBinding, Pair<HLSLResourceBinding, bool>>();
        this.force_uav_buffer_bindings = new UnorderedSet<SetBindingPair>();
        this.base_vertex_info = new CompilerHLSL.base_vertex_info_t();
        this.composite_selection_workaround_types = new CppVector<TypedID_TypeType>();
    }
    public CompilerHLSL(Ptr<uint> ir_, ulong size) : base(ir_, size)
    {
        this.hlsl_options = new CompilerHLSL.Options();
        this.required_texture_size_variants = new CompilerHLSL.TextureSizeVariants();
        this.remap_vertex_attributes = new CppVector<HLSLVertexAttributeRemap>();
        this.root_constants_layout = new CppVector<RootConstants>();
        this.resource_bindings = new UnorderedMap<StageSetBinding, Pair<HLSLResourceBinding, bool>>();
        this.force_uav_buffer_bindings = new UnorderedSet<SetBindingPair>();
        this.base_vertex_info = new CompilerHLSL.base_vertex_info_t();
        this.composite_selection_workaround_types = new CppVector<TypedID_TypeType>();
    }
    public CompilerHLSL(ParsedIR ir_) : base(ir_)
    {
        this.hlsl_options = new CompilerHLSL.Options();
        this.required_texture_size_variants = new CompilerHLSL.TextureSizeVariants();
        this.remap_vertex_attributes = new CppVector<HLSLVertexAttributeRemap>();
        this.root_constants_layout = new CppVector<RootConstants>();
        this.resource_bindings = new UnorderedMap<StageSetBinding, Pair<HLSLResourceBinding, bool>>();
        this.force_uav_buffer_bindings = new UnorderedSet<SetBindingPair>();
        this.base_vertex_info = new CompilerHLSL.base_vertex_info_t();
        this.composite_selection_workaround_types = new CppVector<TypedID_TypeType>();
    }
    public CompilerHLSL.Options get_hlsl_options()
    {
        return hlsl_options;
    }
    public void set_hlsl_options(CompilerHLSL.Options opts)
    {
        hlsl_options.CopyFrom(opts);
    }
    public void set_root_constant_layouts(CppVector<RootConstants> layout)
    {
        root_constants_layout.CopyFrom(layout);
    }
    public void add_vertex_attribute_remap(HLSLVertexAttributeRemap vertex_attributes)
    {
        remap_vertex_attributes.push_back(vertex_attributes.Clone());
    }
    public override CppString compile()
    {
        ir.fixup_reserved_names();
        options.es = false;
        options.version = 450u;
        options.vulkan_semantics = true;
        backend.float_literal_suffix = true;
        backend.double_literal_suffix = false;
        backend.long_long_literal_suffix = true;
        backend.uint32_t_literal_suffix = true;
        backend.int16_t_literal_suffix = "";
        backend.uint16_t_literal_suffix = "u";
        backend.basic_int_type = "int";
        backend.basic_uint_type = "uint";
        backend.demote_literal = "discard";
        backend.boolean_mix_function = "";
        backend.swizzle_is_function = false;
        backend.shared_is_implied = true;
        backend.unsized_array_supported = true;
        backend.explicit_struct_type = false;
        backend.use_initializer_list = true;
        backend.use_constructor_splatting = false;
        backend.can_swizzle_scalar = true;
        backend.can_declare_struct_inline = false;
        backend.can_declare_arrays_inline = false;
        backend.can_return_array = false;
        backend.nonuniform_qualifier = "NonUniformResourceIndex";
        backend.support_case_fallthrough = false;
        backend.requires_phi_undef_zero_init = true;
        backend.force_merged_mesh_block = unchecked((int)get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT);
        backend.force_gl_in_out_block = backend.force_merged_mesh_block;
        backend.supports_empty_struct = hlsl_options.shader_model <= 30u;
        backend.support_precise_qualifier = hlsl_options.shader_model >= 50u || hlsl_options.shader_model == 40u;
        fixup_anonymous_struct_names();
        fixup_type_alias();
        reorder_type_alias();
        build_function_control_flow_graphs_and_analyze();
        validate_shader_model();
        update_active_builtins();
        analyze_image_and_sampler_usage();
        analyze_interlocked_resource_usage();
        if (unchecked((int)get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT))
        {
            analyze_meshlet_writes();
        }
        if (unchecked((int)get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
        {
            discover_geometry_emitters();
        }
        if (need_subpass_input)
        {
            active_input_builtins.set(unchecked((uint)Spv.BuiltIn.BuiltInFragCoord));
        }
        if (hlsl_options.shader_model >= 68u)
        {
            if (active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInVertexIndex)))
            {
                active_input_builtins.set(unchecked((uint)Spv.BuiltIn.BuiltInBaseVertex));
            }
            if (active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInInstanceIndex)))
            {
                active_input_builtins.set(unchecked((uint)Spv.BuiltIn.BuiltInBaseInstance));
            }
        }
        uint pass_count = 0u;
        do
        {
            reset(pass_count);
            buffer.reset();
            emit_header();
            emit_resources();
            if (ir.is_library_module)
            {
                {
                    foreach (TypedID_TypeFunction export_id in ir.library_exported_functions)
                    {
                        emit_function(get__SPIRFunction(((uint)export_id)), new Bitset());
                    }
                }
            }
            else
            {
                emit_function(get__SPIRFunction(((uint)ir.default_entry_point)), new Bitset());
                emit_hlsl_entry_point();
            }
            pass_count++;
        }
        while (is_forcing_recompilation());
        if (!ir.is_library_module)
        {
            get_entry_point().name = "main";
        }
        return buffer.str();
    }
    public TypedID_TypeVariable remap_num_workgroups_builtin()
    {
        update_active_builtins();
        if (!active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInNumWorkgroups)))
        {
            return new TypedID_TypeVariable(0u);
        }
        uint offset = ir.increase_bound_by(4u);
        uint uint_type_id = offset;
        uint block_type_id = offset + 1u;
        uint block_pointer_type_id = offset + 2u;
        uint variable_id = offset + 3u;
        SPIRType uint_type = new SPIRType(Spv.Op.OpTypeVector);
        uint_type.basetype = SPIRType.BaseType.UInt;
        uint_type.width = 32u;
        uint_type.vecsize = 3u;
        uint_type.columns = 1u;
        set__SPIRType_X(uint_type_id, uint_type);
        SPIRType block_type = new SPIRType(Spv.Op.OpTypeStruct);
        block_type.basetype = SPIRType.BaseType.Struct;
        block_type.member_types.push_back(new TypedID_TypeType(uint_type_id));
        set__SPIRType_X(block_type_id, block_type);
        set_decoration(new TypedID_TypeNone(block_type_id), Spv.Decoration.DecorationBlock, 0u);
        set_member_name(new TypedID_TypeType(block_type_id), 0u, new CppString("count"));
        set_member_decoration(new TypedID_TypeType(block_type_id), 0u, Spv.Decoration.DecorationOffset, 0u);
        SPIRType block_pointer_type = block_type.Clone();
        block_pointer_type.pointer = true;
        block_pointer_type.storage = Spv.StorageClass.StorageClassUniform;
        block_pointer_type.parent_type = new TypedID_TypeType(block_type_id);
        var ptr_type = set__SPIRType_X(block_pointer_type_id, block_pointer_type);
        ptr_type.self = new TypedID_TypeNone(block_type_id);
        set__SPIRVariable_X(variable_id, block_pointer_type_id, Spv.StorageClass.StorageClassUniform);
        ir.meta[new TypedID_TypeNone(variable_id)].decoration.alias = "SPIRV_Cross_NumWorkgroups";
        num_workgroups_builtin = variable_id;
        get_entry_point().interface_variables.push_back(new TypedID_TypeVariable(num_workgroups_builtin));
        return new TypedID_TypeVariable(variable_id);
    }
    public void set_resource_binding_flags(uint flags)
    {
        resource_binding_flags = flags;
    }
    public void add_hlsl_resource_binding(HLSLResourceBinding binding)
    {
        StageSetBinding tuple = new StageSetBinding { model = binding.stage, desc_set = binding.desc_set, binding = binding.binding };
        resource_bindings[tuple].CopyFrom(new Pair<HLSLResourceBinding, bool>(binding.Clone(), false));
    }
    public bool is_hlsl_resource_binding_used(Spv.ExecutionModel model, uint desc_set, uint binding)
    {
        StageSetBinding tuple = new StageSetBinding { model = model, desc_set = desc_set, binding = binding };
        var itr = resource_bindings.find(tuple);
        return itr != Std.end(resource_bindings) && itr.deref().second.second;
    }
    public void set_hlsl_force_storage_buffer_as_uav(uint desc_set, uint binding)
    {
        SetBindingPair pair = new SetBindingPair { desc_set = desc_set, binding = binding };
        force_uav_buffer_bindings.insert(pair.Clone());
    }
    public void set_hlsl_aux_buffer_binding(HLSLAuxBinding binding, uint register_index, uint register_space)
    {
        if (unchecked((int)binding) == unchecked((int)HLSLAuxBinding.HLSL_AUX_BINDING_BASE_VERTEX_INSTANCE))
        {
            base_vertex_info.explicit_binding = true;
            base_vertex_info.register_space = register_space;
            base_vertex_info.register_index = register_index;
        }
    }
    public void unset_hlsl_aux_buffer_binding(HLSLAuxBinding binding)
    {
        if (unchecked((int)binding) == unchecked((int)HLSLAuxBinding.HLSL_AUX_BINDING_BASE_VERTEX_INSTANCE))
        {
            base_vertex_info.explicit_binding = false;
        }
    }
    public bool is_hlsl_aux_buffer_binding_used(HLSLAuxBinding binding)
    {
        if (unchecked((int)binding) == unchecked((int)HLSLAuxBinding.HLSL_AUX_BINDING_BASE_VERTEX_INSTANCE))
        {
            return base_vertex_info.used;
        }
        else
        {
            return false;
        }
    }
    public override CppString type_to_glsl(SPIRType type, uint id = 0u)
    {
        {
            switch (unchecked((int)type.basetype))
            {
                case unchecked((int)SPIRType.BaseType.Struct):
                {
                    if (backend.explicit_struct_type)
                    {
                        return Std.join("struct ", to_name(((uint)type.self), true));
                    }
                    else
                    {
                        return to_name(((uint)type.self), true);
                    }
                }
                case unchecked((int)SPIRType.BaseType.Image):
                case unchecked((int)SPIRType.BaseType.SampledImage):
                {
                    return image_type_hlsl(type, id);
                }
                case unchecked((int)SPIRType.BaseType.Sampler):
                {
                    return new CppString(comparison_ids.count(id) != 0UL ? "SamplerComparisonState" : "SamplerState");
                }
                case unchecked((int)SPIRType.BaseType.Void):
                {
                    return new CppString("void");
                }
                default:
                {
                    break;
                }
            }
        }
        if (type.vecsize == 1u && type.columns == 1u)
        {
            {
                switch (unchecked((int)type.basetype))
                {
                    case unchecked((int)SPIRType.BaseType.Boolean):
                    {
                        return new CppString("bool");
                    }
                    case unchecked((int)SPIRType.BaseType.Int):
                    {
                        return new CppString(backend.basic_int_type);
                    }
                    case unchecked((int)SPIRType.BaseType.UInt):
                    {
                        return new CppString(backend.basic_uint_type);
                    }
                    case unchecked((int)SPIRType.BaseType.AtomicCounter):
                    {
                        return new CppString("atomic_uint");
                    }
                    case unchecked((int)SPIRType.BaseType.Half):
                    {
                        if (hlsl_options.enable_16bit_types)
                        {
                            return new CppString("half");
                        }
                        else
                        {
                            return new CppString("min16float");
                        }
                    }
                    case unchecked((int)SPIRType.BaseType.Short):
                    {
                        if (hlsl_options.enable_16bit_types)
                        {
                            return new CppString("int16_t");
                        }
                        else
                        {
                            return new CppString("min16int");
                        }
                    }
                    case unchecked((int)SPIRType.BaseType.UShort):
                    {
                        if (hlsl_options.enable_16bit_types)
                        {
                            return new CppString("uint16_t");
                        }
                        else
                        {
                            return new CppString("min16uint");
                        }
                    }
                    case unchecked((int)SPIRType.BaseType.Float):
                    {
                        return new CppString("float");
                    }
                    case unchecked((int)SPIRType.BaseType.Double):
                    {
                        return new CppString("double");
                    }
                    case unchecked((int)SPIRType.BaseType.Int64):
                    {
                        if (hlsl_options.shader_model < 60u)
                        {
                            throw new CompilerError("64-bit integers only supported in SM 6.0.");
                        }
                        return new CppString("int64_t");
                    }
                    case unchecked((int)SPIRType.BaseType.UInt64):
                    {
                        if (hlsl_options.shader_model < 60u)
                        {
                            throw new CompilerError("64-bit integers only supported in SM 6.0.");
                        }
                        return new CppString("uint64_t");
                    }
                    case unchecked((int)SPIRType.BaseType.AccelerationStructure):
                    {
                        return new CppString("RaytracingAccelerationStructure");
                    }
                    case unchecked((int)SPIRType.BaseType.RayQuery):
                    {
                        return new CppString("RayQuery<RAY_FLAG_NONE>");
                    }
                    default:
                    {
                        return new CppString("???");
                    }
                }
            }
        }
        else
        if (type.vecsize > 1u && type.columns == 1u)
        {
            {
                switch (unchecked((int)type.basetype))
                {
                    case unchecked((int)SPIRType.BaseType.Boolean):
                    {
                        return Std.join("bool", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Int):
                    {
                        return Std.join("int", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.UInt):
                    {
                        return Std.join("uint", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Half):
                    {
                        return Std.join(hlsl_options.enable_16bit_types ? "half" : "min16float", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Short):
                    {
                        return Std.join(hlsl_options.enable_16bit_types ? "int16_t" : "min16int", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.UShort):
                    {
                        return Std.join(hlsl_options.enable_16bit_types ? "uint16_t" : "min16uint", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Float):
                    {
                        return Std.join("float", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Double):
                    {
                        return Std.join("double", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Int64):
                    {
                        return Std.join("int64_t", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.UInt64):
                    {
                        return Std.join("uint64_t", type.vecsize);
                    }
                    default:
                    {
                        return new CppString("???");
                    }
                }
            }
        }
        else
        {
            {
                switch (unchecked((int)type.basetype))
                {
                    case unchecked((int)SPIRType.BaseType.Boolean):
                    {
                        return Std.join("bool", type.columns, "x", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Int):
                    {
                        return Std.join("int", type.columns, "x", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.UInt):
                    {
                        return Std.join("uint", type.columns, "x", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Half):
                    {
                        return Std.join(hlsl_options.enable_16bit_types ? "half" : "min16float", type.columns, "x", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Short):
                    {
                        return Std.join(hlsl_options.enable_16bit_types ? "int16_t" : "min16int", type.columns, "x", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.UShort):
                    {
                        return Std.join(hlsl_options.enable_16bit_types ? "uint16_t" : "min16uint", type.columns, "x", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Float):
                    {
                        return Std.join("float", type.columns, "x", type.vecsize);
                    }
                    case unchecked((int)SPIRType.BaseType.Double):
                    {
                        return Std.join("double", type.columns, "x", type.vecsize);
                    }
                    default:
                    {
                        return new CppString("???");
                    }
                }
            }
        }
    }
    public CppString image_type_hlsl(SPIRType type, uint id)
    {
        if (hlsl_options.shader_model <= 30u)
        {
            return image_type_hlsl_legacy(type, id);
        }
        else
        {
            return image_type_hlsl_modern(type, id);
        }
    }
    public CppString image_type_hlsl_modern(SPIRType type, uint id)
    {
        var imagetype = get__SPIRType(((uint)type.image.type));
        string dim = null;
        bool typed_load = false;
        uint components = 4u;
        bool force_image_srv = hlsl_options.nonwritable_uav_texture_as_srv && has_decoration(new TypedID_TypeNone(id), Spv.Decoration.DecorationNonWritable);
        {
            switch (unchecked((int)type.image.dim))
            {
                case unchecked((int)Spv.Dim.Dim1D):
                {
                    typed_load = type.image.sampled == 2u;
                    dim = "1D";
                    break;
                }
                case unchecked((int)Spv.Dim.Dim2D):
                {
                    typed_load = type.image.sampled == 2u;
                    dim = "2D";
                    break;
                }
                case unchecked((int)Spv.Dim.Dim3D):
                {
                    typed_load = type.image.sampled == 2u;
                    dim = "3D";
                    break;
                }
                case unchecked((int)Spv.Dim.DimCube):
                {
                    if (type.image.sampled == 2u)
                    {
                        throw new CompilerError("RWTextureCube does not exist in HLSL.");
                    }
                    dim = "Cube";
                    break;
                }
                case unchecked((int)Spv.Dim.DimRect):
                {
                    throw new CompilerError("Rectangle texture support is not yet implemented for HLSL.");
                }
                case unchecked((int)Spv.Dim.DimBuffer):
                {
                    if (type.image.sampled == 1u)
                    {
                        return Std.join("Buffer<", type_to_glsl(imagetype, 0u), components, ">");
                    }
                    else
                    if (type.image.sampled == 2u)
                    {
                        if (interlocked_resources.count(id) != 0UL)
                        {
                            return Std.join("RasterizerOrderedBuffer<", Globals.image_format_to_type(type.image.format, imagetype.basetype), ">");
                        }
                        typed_load = !force_image_srv && type.image.sampled == 2u;
                        string rw = force_image_srv ? "" : "RW";
                        return Std.join(rw, "Buffer<", typed_load ? Globals.image_format_to_type(type.image.format, imagetype.basetype) : Std.join(type_to_glsl(imagetype, 0u), components), ">");
                    }
                    else
                    {
                        throw new CompilerError("Sampler buffers must be either sampled or unsampled. Cannot deduce in runtime.");
                    }
                }
                case unchecked((int)Spv.Dim.DimSubpassData):
                {
                    dim = "2D";
                    typed_load = false;
                    break;
                }
                default:
                {
                    throw new CompilerError("Invalid dimension.");
                }
            }
        }
        string arrayed = type.image.arrayed ? "Array" : "";
        string ms = type.image.ms ? "MS" : "";
        string rw_1 = typed_load && !force_image_srv ? "RW" : "";
        if (force_image_srv)
        {
            typed_load = false;
        }
        if (typed_load && interlocked_resources.count(id) != 0UL)
        {
            rw_1 = "RasterizerOrdered";
        }
        return Std.join(rw_1, "Texture", dim, ms, arrayed, "<", typed_load ? Globals.image_format_to_type(type.image.format, imagetype.basetype) : Std.join(type_to_glsl(imagetype, 0u), components), ">");
    }
    public CppString image_type_hlsl_legacy(SPIRType type, uint _p0)
    {
        var imagetype = get__SPIRType(((uint)type.image.type));
        CppString res = default(CppString);
        {
            switch (unchecked((int)imagetype.basetype))
            {
                case unchecked((int)SPIRType.BaseType.Int):
                {
                    res = "i";
                    break;
                }
                case unchecked((int)SPIRType.BaseType.UInt):
                {
                    res = "u";
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && unchecked((int)type.image.dim) == unchecked((int)Spv.Dim.DimSubpassData))
        {
            return res + "subpassInput" + (type.image.ms ? "MS" : "");
        }
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimSubpassData))
        {
            if (unchecked((int)type.image.dim) == unchecked((int)Spv.Dim.DimBuffer) && type.image.sampled == 1u)
            {
                res += "sampler";
            }
            else
            {
                res += type.image.sampled == 2u ? "image" : "texture";
            }
        }
        else
        {
            res += "sampler";
        }
        {
            switch (unchecked((int)type.image.dim))
            {
                case unchecked((int)Spv.Dim.Dim1D):
                {
                    res += "1D";
                    break;
                }
                case unchecked((int)Spv.Dim.Dim2D):
                {
                    res += "2D";
                    break;
                }
                case unchecked((int)Spv.Dim.Dim3D):
                {
                    res += "3D";
                    break;
                }
                case unchecked((int)Spv.Dim.DimCube):
                {
                    res += "CUBE";
                    break;
                }
                case unchecked((int)Spv.Dim.DimBuffer):
                {
                    res += "Buffer";
                    break;
                }
                case unchecked((int)Spv.Dim.DimSubpassData):
                {
                    res += "2D";
                    break;
                }
                default:
                {
                    throw new CompilerError("Only 1D, 2D, 3D, Buffer, InputTarget and Cube textures supported.");
                }
            }
        }
        if (type.image.ms)
        {
            res += "MS";
        }
        if (type.image.arrayed)
        {
            res += "Array";
        }
        return res;
    }
    public uint input_vertices_from_execution_mode(SPIREntryPoint execution)
    {
        uint input_vertices = 1u;
        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputLines)))
        {
            input_vertices = 2u;
        }
        else
        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputLinesAdjacency)))
        {
            input_vertices = 4u;
        }
        else
        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputTrianglesAdjacency)))
        {
            input_vertices = 6u;
        }
        else
        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeTriangles)))
        {
            input_vertices = 3u;
        }
        else
        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputPoints)))
        {
            input_vertices = 1u;
        }
        else
        {
            throw new CompilerError("Unsupported execution model.");
        }
        return input_vertices;
    }
    public override void emit_function_prototype(SPIRFunction func, Bitset return_flags)
    {
        bool is_entry_point = !ir.is_library_module && ((uint)func.self) == ((uint)ir.default_entry_point);
        if (!is_entry_point)
        {
            add_function_overload(func);
        }
        local_variable_names.CopyFrom(resource_names.Clone());
        CppString decl = default(CppString);
        var type = get__SPIRType(((uint)func.return_type));
        if (type.array.empty())
        {
            decl += flags_to_qualifiers_glsl(type, 0u, return_flags);
            decl += type_to_glsl(type, 0u);
            decl += " ";
        }
        else
        {
            decl = "void ";
        }
        if (is_entry_point)
        {
            decl += get_inner_entry_point_name();
            processing_entry_point = true;
        }
        else
        {
            decl += to_name(((uint)func.self), true);
        }
        decl += "(";
        CppVector<CppString> arglist = new CppVector<CppString>();
        if (!type.array.empty())
        {
            CppString out_argument = default(CppString);
            out_argument += "out ";
            out_argument += type_to_glsl(type, 0u);
            out_argument += " ";
            out_argument += "spvReturnValue";
            out_argument += type_to_array_glsl(type, 0u);
            arglist.push_back(out_argument);
        }
        {
            foreach (SPIRFunction.Parameter arg in func.arguments)
            {
                if (skip_argument(((uint)arg.id)))
                {
                    continue;
                }
                add_local_variable_name(((uint)arg.id));
                arglist.push_back(argument_decl(arg));
                var arg_type = get__SPIRType(((uint)arg.type));
                if (hlsl_options.shader_model > 30u && unchecked((int)arg_type.basetype) == unchecked((int)SPIRType.BaseType.SampledImage) && unchecked((int)arg_type.image.dim) != unchecked((int)Spv.Dim.DimBuffer))
                {
                    arglist.push_back(Std.join(is_depth_image(arg_type, ((uint)arg.id)) ? "SamplerComparisonState " : "SamplerState ", to_sampler_expression(((uint)arg.id)), type_to_array_glsl(arg_type, ((uint)arg.id))));
                }
                var @var = maybe_get__SPIRVariable(((uint)arg.id));
                if (@var != null)
                {
                    @var.parameter = arg;
                }
            }
        }
        {
            foreach (SPIRFunction.Parameter arg in func.shadow_arguments)
            {
                add_local_variable_name(((uint)arg.id));
                arglist.push_back(argument_decl(arg));
                var @var = maybe_get__SPIRVariable(((uint)arg.id));
                if (@var != null)
                {
                    @var.parameter = arg;
                }
            }
        }
        if ((((uint)func.self) == ((uint)ir.default_entry_point) || func.emits_geometry) && unchecked((int)get_entry_point().model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
        {
            var execution = get_entry_point();
            uint input_vertices = input_vertices_from_execution_mode(execution);
            string prim = default;
            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputLinesAdjacency)))
            {
                prim = "lineadj";
            }
            else
            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputLines)))
            {
                prim = "line";
            }
            else
            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputTrianglesAdjacency)))
            {
                prim = "triangleadj";
            }
            else
            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeTriangles)))
            {
                prim = "triangle";
            }
            else
            {
                prim = "point";
            }
            string stream_type = default;
            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputPoints)))
            {
                stream_type = "PointStream";
            }
            else
            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputLineStrip)))
            {
                stream_type = "LineStream";
            }
            else
            {
                stream_type = "TriangleStream";
            }
            if (((uint)func.self) == ((uint)ir.default_entry_point))
            {
                arglist.push_back(Std.join(prim, " SPIRV_Cross_Input stage_input[", input_vertices, "]"));
            }
            arglist.push_back(Std.join("inout ", stream_type, "<SPIRV_Cross_Output> ", "geometry_stream"));
        }
        decl += Globals.merge(arglist, ", ");
        decl += ")";
        statement(decl);
    }
    public void emit_hlsl_entry_point()
    {
        CppVector<CppString> arguments = new CppVector<CppString>();
        if (require_input && unchecked((int)get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
        {
            arguments.push_back(new CppString("SPIRV_Cross_Input stage_input"));
        }
        var execution = get_entry_point();
        uint input_vertices = 1u;
        {
            switch (unchecked((int)execution.model))
            {
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry):
                {
                    {
                        input_vertices = input_vertices_from_execution_mode(execution);
                        CppString prim = default(CppString);
                        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputLinesAdjacency)))
                        {
                            prim = "lineadj";
                        }
                        else
                        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputLines)))
                        {
                            prim = "line";
                        }
                        else
                        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeInputTrianglesAdjacency)))
                        {
                            prim = "triangleadj";
                        }
                        else
                        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeTriangles)))
                        {
                            prim = "triangle";
                        }
                        else
                        {
                            prim = "point";
                        }
                        CppString stream_type = default(CppString);
                        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputPoints)))
                        {
                            stream_type = "PointStream";
                        }
                        else
                        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputLineStrip)))
                        {
                            stream_type = "LineStream";
                        }
                        else
                        {
                            stream_type = "TriangleStream";
                        }
                        statement("[maxvertexcount(", execution.output_vertices, ")]");
                        arguments.push_back(Std.join(prim, " SPIRV_Cross_Input stage_input[", input_vertices, "]"));
                        if (active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInPrimitiveId)))
                        {
                            arguments.push_back(new CppString("uint gl_PrimitiveID : SV_PrimitiveID"));
                        }
                        arguments.push_back(Std.join("inout ", stream_type, "<SPIRV_Cross_Output> ", "geometry_stream"));
                        break;
                    }
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTaskEXT):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute):
                {
                    {
                        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT))
                        {
                            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputTrianglesEXT)))
                            {
                                statement("[outputtopology(\"triangle\")]");
                            }
                            else
                            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputLinesEXT)))
                            {
                                statement("[outputtopology(\"line\")]");
                            }
                            else
                            if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputPoints)))
                            {
                                throw new CompilerError("Topology mode \"points\" is not supported in DirectX");
                            }
                            var func = get__SPIRFunction(((uint)ir.default_entry_point));
                            {
                                foreach (SPIRFunction.Parameter arg in func.arguments)
                                {
                                    var @var = get__SPIRVariable(((uint)arg.id));
                                    var base_type = get__SPIRType(((uint)@var.basetype));
                                    bool block = has_decoration(base_type.self, Spv.Decoration.DecorationBlock);
                                    if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT))
                                    {
                                        arguments.push_back("in payload " + variable_decl(@var));
                                    }
                                    else
                                    if (block)
                                    {
                                        var flags = get_buffer_block_flags(((TypedID_TypeVariable)@var.self));
                                        if (flags.get(unchecked((uint)Spv.Decoration.DecorationPerPrimitiveEXT)) || has_decoration(arg.id, Spv.Decoration.DecorationPerPrimitiveEXT))
                                        {
                                            arguments.push_back("out primitives gl_MeshPerPrimitiveEXT gl_MeshPrimitivesEXT[" + Std.to_string(execution.output_primitives) + "]");
                                        }
                                        else
                                        {
                                            arguments.push_back("out vertices gl_MeshPerVertexEXT gl_MeshVerticesEXT[" + Std.to_string(execution.output_vertices) + "]");
                                        }
                                    }
                                    else
                                    {
                                        if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeOutputTrianglesEXT)))
                                        {
                                            arguments.push_back("out indices uint3 gl_PrimitiveTriangleIndicesEXT[" + Std.to_string(execution.output_primitives) + "]");
                                        }
                                        else
                                        {
                                            arguments.push_back("out indices uint2 gl_PrimitiveLineIndicesEXT[" + Std.to_string(execution.output_primitives) + "]");
                                        }
                                    }
                                }
                            }
                        }
                        SpecializationConstant wg_x = new SpecializationConstant();
                        SpecializationConstant wg_y = new SpecializationConstant();
                        SpecializationConstant wg_z = new SpecializationConstant();
                        get_work_group_size_specialization_constants(wg_x, wg_y, wg_z);
                        uint x = execution.workgroup_size.x;
                        uint y = execution.workgroup_size.y;
                        uint z = execution.workgroup_size.z;
                        if (!(execution.workgroup_size.constant != 0u) && execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeLocalSizeId)))
                        {
                            if (execution.workgroup_size.id_x != 0u)
                            {
                                x = get__SPIRConstant(execution.workgroup_size.id_x).scalar(0u, 0u);
                            }
                            if (execution.workgroup_size.id_y != 0u)
                            {
                                y = get__SPIRConstant(execution.workgroup_size.id_y).scalar(0u, 0u);
                            }
                            if (execution.workgroup_size.id_z != 0u)
                            {
                                z = get__SPIRConstant(execution.workgroup_size.id_z).scalar(0u, 0u);
                            }
                        }
                        var x_expr = ((uint)wg_x.id) != 0u ? get__SPIRConstant(((uint)wg_x.id)).specialization_constant_macro_name : Std.to_string(x);
                        var y_expr = ((uint)wg_y.id) != 0u ? get__SPIRConstant(((uint)wg_y.id)).specialization_constant_macro_name : Std.to_string(y);
                        var z_expr = ((uint)wg_z.id) != 0u ? get__SPIRConstant(((uint)wg_z.id)).specialization_constant_macro_name : Std.to_string(z);
                        statement("[numthreads(", x_expr, ", ", y_expr, ", ", z_expr, ")]");
                        break;
                    }
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelFragment):
                {
                    if (execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeEarlyFragmentTests)))
                    {
                        statement("[earlydepthstencil]");
                    }
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
        string entry_point_name = default;
        if (hlsl_options.use_entry_point_name)
        {
            entry_point_name = get_entry_point().name.c_str();
        }
        else
        {
            entry_point_name = "main";
        }
        statement(require_output ? "SPIRV_Cross_Output " : "void ", entry_point_name, "(", Globals.merge(arguments, ", "), ")");
        begin_scope();
        bool legacy = hlsl_options.shader_model <= 30u;
        active_input_builtins.for_each_bit__lambda((uint i) =>
        {
            var builtin = this.builtin_to_glsl(unchecked((Spv.BuiltIn)i), Spv.StorageClass.StorageClassInput);
            {
                switch (unchecked((int)unchecked((Spv.BuiltIn)i)))
                {
                    case unchecked((int)Spv.BuiltIn.BuiltInPosition):
                    {
                        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
                        {
                            statement("for (int i = 0; i < ", input_vertices, "; i++)");
                            this.begin_scope();
                            statement(builtin, "[i] = stage_input[i].", builtin, ";");
                            this.end_scope();
                        }
                        else
                        {
                            statement(builtin, " = stage_input.", builtin, ";");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInFragCoord):
                    {
                        if (legacy)
                        {
                            statement(builtin, " = stage_input.", builtin, " + float4(0.5f, 0.5f, 0.0f, 0.0f);");
                        }
                        else
                        {
                            statement(builtin, " = stage_input.", builtin, ";");
                            statement(builtin, ".w = 1.0 / ", builtin, ".w;");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInVertexId):
                    case unchecked((int)Spv.BuiltIn.BuiltInVertexIndex):
                    case unchecked((int)Spv.BuiltIn.BuiltInInstanceIndex):
                    {
                        if (this.hlsl_options.support_nonzero_base_vertex_base_instance || this.hlsl_options.shader_model >= 68u)
                        {
                            if (this.hlsl_options.shader_model >= 68u)
                            {
                                if (unchecked((int)unchecked((Spv.BuiltIn)i)) == unchecked((int)Spv.BuiltIn.BuiltInInstanceIndex))
                                {
                                    statement(builtin, " = int(stage_input.", builtin, " + stage_input.gl_BaseInstanceARB);");
                                }
                                else
                                {
                                    statement(builtin, " = int(stage_input.", builtin, " + stage_input.gl_BaseVertexARB);");
                                }
                            }
                            else
                            {
                                if (unchecked((int)unchecked((Spv.BuiltIn)i)) == unchecked((int)Spv.BuiltIn.BuiltInInstanceIndex))
                                {
                                    statement(builtin, " = int(stage_input.", builtin, ") + SPIRV_Cross_BaseInstance;");
                                }
                                else
                                {
                                    statement(builtin, " = int(stage_input.", builtin, ") + SPIRV_Cross_BaseVertex;");
                                }
                            }
                        }
                        else
                        {
                            statement(builtin, " = int(stage_input.", builtin, ");");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInBaseVertex):
                    {
                        if (this.hlsl_options.shader_model >= 68u)
                        {
                            statement(builtin, " = stage_input.gl_BaseVertexARB;");
                        }
                        else
                        {
                            statement(builtin, " = SPIRV_Cross_BaseVertex;");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInBaseInstance):
                    {
                        if (this.hlsl_options.shader_model >= 68u)
                        {
                            statement(builtin, " = stage_input.gl_BaseInstanceARB;");
                        }
                        else
                        {
                            statement(builtin, " = SPIRV_Cross_BaseInstance;");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInInstanceId):
                    {
                        statement(builtin, " = int(stage_input.", builtin, ");");
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                    {
                        statement(builtin, "[0] = stage_input.", builtin, ";");
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInNumWorkgroups):
                    case unchecked((int)Spv.BuiltIn.BuiltInPointCoord):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupSize):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLocalInvocationId):
                    case unchecked((int)Spv.BuiltIn.BuiltInHelperInvocation):
                    {
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveId):
                    {
                        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
                        {
                            statement(builtin, " = gl_PrimitiveID;");
                        }
                        else
                        {
                            statement(builtin, " = stage_input.", builtin, ";");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInInvocationId):
                    {
                        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl))
                        {
                            statement(builtin, " = uCPID;");
                        }
                        else
                        {
                            statement(builtin, " = stage_input[0].", builtin, ";");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupEqMask):
                    {
                        statement("gl_SubgroupEqMask = 1u << (WaveGetLaneIndex() - uint4(0, 32, 64, 96));");
                        statement("if (WaveGetLaneIndex() >= 32) gl_SubgroupEqMask.x = 0;");
                        statement("if (WaveGetLaneIndex() >= 64 || WaveGetLaneIndex() < 32) gl_SubgroupEqMask.y = 0;");
                        statement("if (WaveGetLaneIndex() >= 96 || WaveGetLaneIndex() < 64) gl_SubgroupEqMask.z = 0;");
                        statement("if (WaveGetLaneIndex() < 96) gl_SubgroupEqMask.w = 0;");
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGeMask):
                    {
                        statement("gl_SubgroupGeMask = ~((1u << (WaveGetLaneIndex() - uint4(0, 32, 64, 96))) - 1u);");
                        statement("if (WaveGetLaneIndex() >= 32) gl_SubgroupGeMask.x = 0u;");
                        statement("if (WaveGetLaneIndex() >= 64) gl_SubgroupGeMask.y = 0u;");
                        statement("if (WaveGetLaneIndex() >= 96) gl_SubgroupGeMask.z = 0u;");
                        statement("if (WaveGetLaneIndex() < 32) gl_SubgroupGeMask.y = ~0u;");
                        statement("if (WaveGetLaneIndex() < 64) gl_SubgroupGeMask.z = ~0u;");
                        statement("if (WaveGetLaneIndex() < 96) gl_SubgroupGeMask.w = ~0u;");
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGtMask):
                    {
                        statement("uint gt_lane_index = WaveGetLaneIndex() + 1;");
                        statement("gl_SubgroupGtMask = ~((1u << (gt_lane_index - uint4(0, 32, 64, 96))) - 1u);");
                        statement("if (gt_lane_index >= 32) gl_SubgroupGtMask.x = 0u;");
                        statement("if (gt_lane_index >= 64) gl_SubgroupGtMask.y = 0u;");
                        statement("if (gt_lane_index >= 96) gl_SubgroupGtMask.z = 0u;");
                        statement("if (gt_lane_index >= 128) gl_SubgroupGtMask.w = 0u;");
                        statement("if (gt_lane_index < 32) gl_SubgroupGtMask.y = ~0u;");
                        statement("if (gt_lane_index < 64) gl_SubgroupGtMask.z = ~0u;");
                        statement("if (gt_lane_index < 96) gl_SubgroupGtMask.w = ~0u;");
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLeMask):
                    {
                        statement("uint le_lane_index = WaveGetLaneIndex() + 1;");
                        statement("gl_SubgroupLeMask = (1u << (le_lane_index - uint4(0, 32, 64, 96))) - 1u;");
                        statement("if (le_lane_index >= 32) gl_SubgroupLeMask.x = ~0u;");
                        statement("if (le_lane_index >= 64) gl_SubgroupLeMask.y = ~0u;");
                        statement("if (le_lane_index >= 96) gl_SubgroupLeMask.z = ~0u;");
                        statement("if (le_lane_index >= 128) gl_SubgroupLeMask.w = ~0u;");
                        statement("if (le_lane_index < 32) gl_SubgroupLeMask.y = 0u;");
                        statement("if (le_lane_index < 64) gl_SubgroupLeMask.z = 0u;");
                        statement("if (le_lane_index < 96) gl_SubgroupLeMask.w = 0u;");
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLtMask):
                    {
                        statement("gl_SubgroupLtMask = (1u << (WaveGetLaneIndex() - uint4(0, 32, 64, 96))) - 1u;");
                        statement("if (WaveGetLaneIndex() >= 32) gl_SubgroupLtMask.x = ~0u;");
                        statement("if (WaveGetLaneIndex() >= 64) gl_SubgroupLtMask.y = ~0u;");
                        statement("if (WaveGetLaneIndex() >= 96) gl_SubgroupLtMask.z = ~0u;");
                        statement("if (WaveGetLaneIndex() < 32) gl_SubgroupLtMask.y = 0u;");
                        statement("if (WaveGetLaneIndex() < 64) gl_SubgroupLtMask.z = 0u;");
                        statement("if (WaveGetLaneIndex() < 96) gl_SubgroupLtMask.w = 0u;");
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                    {
                        {
                            for (uint clip = 0u; clip < this.clip_distance_count; clip++)
                            {
                                statement("gl_ClipDistance[", clip, "] = stage_input.gl_ClipDistance", clip / 4u, ".", "xyzw"[(int)(clip & 3u)], ";");
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                    {
                        {
                            for (uint cull = 0u; cull < this.cull_distance_count; cull++)
                            {
                                statement("gl_CullDistance[", cull, "] = stage_input.gl_CullDistance", cull / 4u, ".", "xyzw"[(int)(cull & 3u)], ";");
                            }
                        }
                        break;
                    }
                    default:
                    {
                        statement(builtin, " = stage_input.", builtin, ";");
                        break;
                    }
                }
            }
        });
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            bool block = this.has_decoration(type.self, Spv.Decoration.DecorationBlock);
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassInput))
            {
                return;
            }
            bool is_hidden = this.is_hidden_io_variable(@var);
            bool need_matrix_unroll = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) && unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex);
            if (!@var.remapped_variable && type.pointer && !this.is_builtin_variable(@var) && this.interface_variable_exists_in_entry_point(((uint)@var.self)) && !is_hidden)
            {
                if (block)
                {
                    var type_name = this.to_name(((uint)type.self), true);
                    var var_name = this.to_name(((uint)@var.self), true);
                    bool is_per_vertex = this.has_decoration(@var.self, Spv.Decoration.DecorationPerVertexKHR);
                    uint array_size = is_per_vertex ? this.to_array_size_literal(type) : 0u;
                    {
                        for (uint mbr_idx = 0u; mbr_idx < unchecked((uint)type.member_types.size()); mbr_idx++)
                        {
                            var mbr_name = this.to_member_name(type, mbr_idx);
                            var flat_name = Std.join(type_name, "_", mbr_name);
                            if (is_per_vertex)
                            {
                                {
                                    for (uint i = 0u; i < array_size; i++)
                                    {
                                        statement(var_name, "[", i, "].", mbr_name, " = GetAttributeAtVertex(stage_input.", flat_name, ", ", i, ");");
                                    }
                                }
                            }
                            else
                            {
                                statement(var_name, ".", mbr_name, " = stage_input.", flat_name, ";");
                            }
                        }
                    }
                }
                else
                {
                    var name = this.to_name(((uint)@var.self), true);
                    var mtype = this.get__SPIRType(((uint)@var.basetype));
                    if (need_matrix_unroll && mtype.columns > 1u)
                    {
                        {
                            for (uint col = 0u; col < mtype.columns; col++)
                            {
                                statement(name, "[", col, "] = stage_input.", name, "_", col, ";");
                            }
                        }
                    }
                    else
                    if (this.has_decoration(@var.self, Spv.Decoration.DecorationPerVertexKHR))
                    {
                        uint array_size = this.to_array_size_literal(type);
                        {
                            for (uint i = 0u; i < array_size; i++)
                            {
                                statement(name, "[", i, "]", " = GetAttributeAtVertex(stage_input.", name, ", ", i, ");");
                            }
                        }
                    }
                    else
                    {
                        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
                        {
                            statement("for (int i = 0; i < ", input_vertices, "; i++)");
                            this.begin_scope();
                            statement(name, "[i] = stage_input[i].", name, ";");
                            this.end_scope();
                        }
                        else
                        {
                            statement(name, " = stage_input.", name, ";");
                        }
                    }
                }
            }
        });
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex) || unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelFragment) || unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute) || unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT) || unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry) || unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTaskEXT))
        {
            CppVector<CppString> arglist = new CppVector<CppString>();
            var func = get__SPIRFunction(((uint)ir.default_entry_point));
            {
                foreach (SPIRFunction.Parameter arg in func.arguments)
                {
                    arglist.push_back(to_expression(((uint)arg.id), false));
                }
            }
            if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
            {
                arglist.push_back(new CppString("stage_input"));
                arglist.push_back(new CppString("geometry_stream"));
            }
            statement(get_inner_entry_point_name(), "(", Globals.merge(arglist, ", "), ");");
        }
        else
        {
            throw new CompilerError("Unsupported shader stage.");
        }
        if (require_output)
        {
            statement("SPIRV_Cross_Output stage_output;");
            active_output_builtins.for_each_bit__lambda((uint i) =>
            {
                if (i == unchecked((uint)Spv.BuiltIn.BuiltInPointSize) && !legacy)
                {
                    return;
                }
                {
                    switch (unchecked((int)unchecked((Spv.BuiltIn)i)))
                    {
                        case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                        {
                            {
                                for (uint clip = 0u; clip < this.clip_distance_count; clip++)
                                {
                                    statement("stage_output.gl_ClipDistance", clip / 4u, ".", "xyzw"[(int)(clip & 3u)], " = gl_ClipDistance[", clip, "];");
                                }
                            }
                            break;
                        }
                        case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                        {
                            {
                                for (uint cull = 0u; cull < this.cull_distance_count; cull++)
                                {
                                    statement("stage_output.gl_CullDistance", cull / 4u, ".", "xyzw"[(int)(cull & 3u)], " = gl_CullDistance[", cull, "];");
                                }
                            }
                            break;
                        }
                        case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                        {
                            statement("stage_output.gl_SampleMask = gl_SampleMask[0];");
                            break;
                        }
                        default:
                        {
                            {
                                var builtin_expr = this.builtin_to_glsl(unchecked((Spv.BuiltIn)i), Spv.StorageClass.StorageClassOutput);
                                statement("stage_output.", builtin_expr, " = ", builtin_expr, ";");
                                break;
                            }
                        }
                    }
                }
            });
            ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
            {
                var type = this.get__SPIRType(((uint)@var.basetype));
                bool block = this.has_decoration(type.self, Spv.Decoration.DecorationBlock);
                if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput))
                {
                    return;
                }
                if (!@var.remapped_variable && type.pointer && !this.is_builtin_variable(@var) && this.interface_variable_exists_in_entry_point(((uint)@var.self)))
                {
                    if (block)
                    {
                        var type_name = this.to_name(((uint)type.self), true);
                        var var_name = this.to_name(((uint)@var.self), true);
                        {
                            for (uint mbr_idx = 0u; mbr_idx < unchecked((uint)type.member_types.size()); mbr_idx++)
                            {
                                var mbr_name = this.to_member_name(type, mbr_idx);
                                var flat_name = Std.join(type_name, "_", mbr_name);
                                statement("stage_output.", flat_name, " = ", var_name, ".", mbr_name, ";");
                            }
                        }
                    }
                    else
                    {
                        var name = this.to_name(((uint)@var.self), true);
                        if (legacy && unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                        {
                            CppString output_filler = default(CppString);
                            {
                                for (uint size = type.vecsize; size < 4u; ++size)
                                {
                                    output_filler += ", 0.0";
                                }
                            }
                            statement("stage_output.", name, " = float4(", name, output_filler, ");");
                        }
                        else
                        {
                            statement("stage_output.", name, " = ", name, ";");
                        }
                    }
                }
            });
            statement("return stage_output;");
        }
        end_scope();
    }
    public override void emit_header()
    {
        {
            var __r0 = header_lines;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref CppString header = ref __r0[__i1];
                statement(header);
            }
        }
        if (header_lines.size() > 0UL)
        {
            statement("");
        }
    }
    private static string[] types_static19 = new string[] { "float", "float2", "float3", "float4" };
    private static string[] qualifiers_static20 = new string[] { "", "unorm ", "snorm " };
    private static string[] vecsizes_static21 = new string[] { "", "2", "3", "4" };
    private static string[] types_static22 = new string[] { "uint", "uint2", "uint3", "uint4" };
    private static string[] unsigned_types_static23 = new string[] { "uint", "uint2", "uint3", "uint4" };
    private static string[] signed_types_static24 = new string[] { "int", "int2", "int3", "int4" };
    public new void emit_resources()
    {
        var execution = get_entry_point();
        replace_illegal_names();
        {
            switch (unchecked((int)execution.model))
            {
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT):
                {
                    fixup_implicit_builtin_block_names(execution.model);
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
        emit_specialization_constants_and_structs();
        emit_composite_constants();
        bool emitted = false;
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            bool is_block_storage = unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform);
            bool has_block_flags = this.ir.meta[type.self].decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBlock)) || this.ir.meta[type.self].decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBufferBlock));
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && type.pointer && is_block_storage && !this.is_hidden_variable(@var, false) && has_block_flags)
            {
                this.emit_buffer_block(@var);
                emitted = true;
            }
        });
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && type.pointer && unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant) && !this.is_hidden_variable(@var, false))
            {
                this.emit_push_constant_block(@var);
                emitted = true;
            }
        });
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex) && hlsl_options.shader_model <= 30u && active_output_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInPosition)))
        {
            statement("uniform float4 gl_HalfPixel;");
            emitted = true;
        }
        bool skip_separate_image_sampler = !combined_image_samplers.empty() || hlsl_options.shader_model <= 30u;
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            if (skip_separate_image_sampler)
            {
                bool sampler_buffer = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && unchecked((int)type.image.dim) == unchecked((int)Spv.Dim.DimBuffer);
                bool separate_image = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 1u;
                bool separate_sampler = unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Sampler);
                if (!sampler_buffer && (separate_image || separate_sampler))
                {
                    return;
                }
            }
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && !this.is_builtin_variable(@var) && !@var.remapped_variable && type.pointer && (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassAtomicCounter)) && !this.is_hidden_variable(@var, false))
            {
                this.emit_uniform(@var);
                emitted = true;
            }
        });
        if (emitted)
        {
            statement("");
        }
        emitted = false;
        emit_builtin_variables();
        if (unchecked((int)execution.model) != unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT))
        {
            ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
            {
                var type = this.get__SPIRType(((uint)@var.basetype));
                bool is_hidden = this.is_hidden_io_variable(@var);
                if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && !@var.remapped_variable && type.pointer && (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput)) && !this.is_builtin_variable(@var) && this.interface_variable_exists_in_entry_point(((uint)@var.self)) && !is_hidden)
                {
                    this.emit_interface_block_globally(@var);
                    emitted = true;
                }
            });
        }
        if (emitted)
        {
            statement("");
        }
        emitted = false;
        require_input = false;
        require_output = false;
        UnorderedSet<uint> active_inputs = new UnorderedSet<uint>();
        UnorderedSet<uint> active_outputs = new UnorderedSet<uint>();
        CppVector<CompilerHLSL.IOVariable> input_variables = new CppVector<CompilerHLSL.IOVariable>();
        CppVector<CompilerHLSL.IOVariable> output_variables = new CppVector<CompilerHLSL.IOVariable>();
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            bool block = this.has_decoration(type.self, Spv.Decoration.DecorationBlock);
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassInput) && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput))
            {
                return;
            }
            bool is_hidden = this.is_hidden_io_variable(@var);
            if (!@var.remapped_variable && type.pointer && !this.is_builtin_variable(@var) && this.interface_variable_exists_in_entry_point(((uint)@var.self)) && !is_hidden)
            {
                if (block)
                {
                    {
                        for (uint i = 0u; i < unchecked((uint)type.member_types.size()); i++)
                        {
                            uint location = this.get_declared_member_location(@var, i, false);
                            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput))
                            {
                                input_variables.push_back(new CompilerHLSL.IOVariable { @var = @var, location = location, block_member_index = i, block = true });
                            }
                            else
                            {
                                output_variables.push_back(new CompilerHLSL.IOVariable { @var = @var, location = location, block_member_index = i, block = true });
                            }
                        }
                    }
                }
                else
                {
                    uint location = this.get_decoration(@var.self, Spv.Decoration.DecorationLocation);
                    if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput))
                    {
                        input_variables.push_back(new CompilerHLSL.IOVariable { @var = @var, location = location, block_member_index = 0u, block = false });
                    }
                    else
                    {
                        output_variables.push_back(new CompilerHLSL.IOVariable { @var = @var, location = location, block_member_index = 0u, block = false });
                    }
                }
            }
        });
        var variable_compare = (CompilerHLSL.IOVariable a, CompilerHLSL.IOVariable b) =>
        {
            bool has_location_a = a.block || this.has_decoration(a.@var.self, Spv.Decoration.DecorationLocation);
            bool has_location_b = b.block || this.has_decoration(b.@var.self, Spv.Decoration.DecorationLocation);
            if (has_location_a && has_location_b)
            {
                return a.location < b.location;
            }
            else
            if (has_location_a && !has_location_b)
            {
                return true;
            }
            else
            if (!has_location_a && has_location_b)
            {
                return false;
            }
            var name1 = this.to_name(((uint)a.@var.self), true);
            var name2 = this.to_name(((uint)b.@var.self), true);
            if (name1.empty() && name2.empty())
            {
                return ((uint)a.@var.self) < ((uint)b.@var.self);
            }
            else
            if (name1.empty())
            {
                return true;
            }
            else
            if (name2.empty())
            {
                return false;
            }
            return name1.compare(name2) < 0;
        };
        var input_builtins = active_input_builtins.Clone();
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInNumWorkgroups));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInPointCoord));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupSize));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupLocalInvocationId));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupEqMask));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupLtMask));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupLeMask));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupGtMask));
        input_builtins.clear(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupGeMask));
        if (!input_variables.empty() || !input_builtins.empty())
        {
            require_input = true;
            statement("struct SPIRV_Cross_Input");
            begin_scope();
            Std.sort(input_variables.begin(), input_variables.end(), variable_compare);
            {
                foreach (CompilerHLSL.IOVariable @var in input_variables)
                {
                    if (@var.block)
                    {
                        emit_interface_block_member_in_struct(@var.@var, @var.block_member_index, @var.location, active_inputs);
                    }
                    else
                    {
                        emit_interface_block_in_struct(@var.@var, active_inputs);
                    }
                }
            }
            emit_builtin_inputs_in_struct();
            end_scope_decl();
            statement("");
        }
        bool is_mesh_shader = unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT);
        if (!output_variables.empty() || !active_output_builtins.empty())
        {
            Std.sort(output_variables.begin(), output_variables.end(), variable_compare);
            require_output = !(is_mesh_shader || unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry));
            statement(is_mesh_shader ? "struct gl_MeshPerVertexEXT" : "struct SPIRV_Cross_Output");
            begin_scope();
            {
                foreach (CompilerHLSL.IOVariable @var in output_variables)
                {
                    if (is_per_primitive_variable(@var.@var))
                    {
                        continue;
                    }
                    if (@var.block && is_mesh_shader && @var.block_member_index != 0u)
                    {
                        continue;
                    }
                    if (@var.block && !is_mesh_shader)
                    {
                        emit_interface_block_member_in_struct(@var.@var, @var.block_member_index, @var.location, active_outputs);
                    }
                    else
                    {
                        emit_interface_block_in_struct(@var.@var, active_outputs);
                    }
                }
            }
            emit_builtin_outputs_in_struct();
            if (!is_mesh_shader)
            {
                emit_builtin_primitive_outputs_in_struct();
            }
            end_scope_decl();
            statement("");
            if (is_mesh_shader)
            {
                statement("struct gl_MeshPerPrimitiveEXT");
                begin_scope();
                {
                    foreach (CompilerHLSL.IOVariable @var in output_variables)
                    {
                        if (!is_per_primitive_variable(@var.@var))
                        {
                            continue;
                        }
                        if (@var.block && @var.block_member_index != 0u)
                        {
                            continue;
                        }
                        emit_interface_block_in_struct(@var.@var, active_outputs);
                    }
                }
                emit_builtin_primitive_outputs_in_struct();
                end_scope_decl();
                statement("");
            }
        }
        {
            foreach (uint global in global_variables)
            {
                var @var = get__SPIRVariable(global);
                if (is_hidden_variable(@var, true))
                {
                    continue;
                }
                if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT) && is_mesh_shader)
                {
                    continue;
                }
                if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput))
                {
                    if (!variable_is_lut(@var))
                    {
                        add_resource_name(((uint)@var.self));
                        string storage = null;
                        {
                            switch (unchecked((int)@var.storage))
                            {
                                case unchecked((int)Spv.StorageClass.StorageClassWorkgroup):
                                case unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT):
                                {
                                    storage = "groupshared";
                                    break;
                                }
                                default:
                                {
                                    storage = "static";
                                    break;
                                }
                            }
                        }
                        CppString initializer = default(CppString);
                        if (options.force_zero_initialized_variables && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassPrivate) && !(((uint)@var.initializer) != 0u) && !(((uint)@var.static_expression) != 0u) && type_can_zero_initialize(get_variable_data_type(@var)))
                        {
                            initializer = Std.join(" = ", to_zero_initialized_expression(get_variable_data_type_id(@var)));
                        }
                        statement(storage, " ", variable_decl(@var), initializer, ";");
                        emitted = true;
                    }
                }
            }
        }
        if (emitted)
        {
            statement("");
        }
        if (requires_op_fmod)
        {
            {
                var __r0 = types_static19;
                for (int __i1 = 0; __i1 < __r0.Length; __i1++)
                {
                    ref string type = ref __r0[__i1];
                    statement(type, " mod(", type, " x, ", type, " y)");
                    begin_scope();
                    statement("return x - y * floor(x / y);");
                    end_scope();
                    statement("");
                }
            }
        }
        emit_texture_size_variants(required_texture_size_variants.srv, "4", false, "");
        {
            for (uint norm = 0u; norm < 3u; norm++)
            {
                {
                    for (uint comp = 0u; comp < 4u; comp++)
                    {
                        emit_texture_size_variants(required_texture_size_variants.uav[norm][comp], vecsizes_static21[comp], true, qualifiers_static20[norm]);
                    }
                }
            }
        }
        if (requires_fp16_packing)
        {
            statement("uint spvPackHalf2x16(float2 value)");
            begin_scope();
            statement("uint2 Packed = f32tof16(value);");
            statement("return Packed.x | (Packed.y << 16);");
            end_scope();
            statement("");
            statement("float2 spvUnpackHalf2x16(uint value)");
            begin_scope();
            statement("return f16tof32(uint2(value & 0xffff, value >> 16));");
            end_scope();
            statement("");
        }
        if (requires_uint2_packing)
        {
            statement("uint64_t spvPackUint2x32(uint2 value)");
            begin_scope();
            statement("return (uint64_t(value.y) << 32) | uint64_t(value.x);");
            end_scope();
            statement("");
            statement("uint2 spvUnpackUint2x32(uint64_t value)");
            begin_scope();
            statement("uint2 Unpacked;");
            statement("Unpacked.x = uint(value & 0xffffffff);");
            statement("Unpacked.y = uint(value >> 32);");
            statement("return Unpacked;");
            end_scope();
            statement("");
        }
        if (requires_explicit_fp16_packing)
        {
            statement("uint spvPackFloat2x16(min16float2 value)");
            begin_scope();
            statement("uint2 Packed = f32tof16(value);");
            statement("return Packed.x | (Packed.y << 16);");
            end_scope();
            statement("");
            statement("min16float2 spvUnpackFloat2x16(uint value)");
            begin_scope();
            statement("return min16float2(f16tof32(uint2(value & 0xffff, value >> 16)));");
            end_scope();
            statement("");
        }
        if (requires_unorm8_packing)
        {
            statement("uint spvPackUnorm4x8(float4 value)");
            begin_scope();
            statement("uint4 Packed = uint4(round(saturate(value) * 255.0));");
            statement("return Packed.x | (Packed.y << 8) | (Packed.z << 16) | (Packed.w << 24);");
            end_scope();
            statement("");
            statement("float4 spvUnpackUnorm4x8(uint value)");
            begin_scope();
            statement("uint4 Packed = uint4(value & 0xff, (value >> 8) & 0xff, (value >> 16) & 0xff, value >> 24);");
            statement("return float4(Packed) / 255.0;");
            end_scope();
            statement("");
        }
        if (requires_snorm8_packing)
        {
            statement("uint spvPackSnorm4x8(float4 value)");
            begin_scope();
            statement("int4 Packed = int4(round(clamp(value, -1.0, 1.0) * 127.0)) & 0xff;");
            statement("return uint(Packed.x | (Packed.y << 8) | (Packed.z << 16) | (Packed.w << 24));");
            end_scope();
            statement("");
            statement("float4 spvUnpackSnorm4x8(uint value)");
            begin_scope();
            statement("int SignedValue = int(value);");
            statement("int4 Packed = int4(SignedValue << 24, SignedValue << 16, SignedValue << 8, SignedValue) >> 24;");
            statement("return clamp(float4(Packed) / 127.0, -1.0, 1.0);");
            end_scope();
            statement("");
        }
        if (requires_unorm16_packing)
        {
            statement("uint spvPackUnorm2x16(float2 value)");
            begin_scope();
            statement("uint2 Packed = uint2(round(saturate(value) * 65535.0));");
            statement("return Packed.x | (Packed.y << 16);");
            end_scope();
            statement("");
            statement("float2 spvUnpackUnorm2x16(uint value)");
            begin_scope();
            statement("uint2 Packed = uint2(value & 0xffff, value >> 16);");
            statement("return float2(Packed) / 65535.0;");
            end_scope();
            statement("");
        }
        if (requires_snorm16_packing)
        {
            statement("uint spvPackSnorm2x16(float2 value)");
            begin_scope();
            statement("int2 Packed = int2(round(clamp(value, -1.0, 1.0) * 32767.0)) & 0xffff;");
            statement("return uint(Packed.x | (Packed.y << 16));");
            end_scope();
            statement("");
            statement("float2 spvUnpackSnorm2x16(uint value)");
            begin_scope();
            statement("int SignedValue = int(value);");
            statement("int2 Packed = int2(SignedValue << 16, SignedValue) >> 16;");
            statement("return clamp(float2(Packed) / 32767.0, -1.0, 1.0);");
            end_scope();
            statement("");
        }
        if (requires_bitfield_insert)
        {
            {
                var __r2 = types_static22;
                for (int __i3 = 0; __i3 < __r2.Length; __i3++)
                {
                    ref string type = ref __r2[__i3];
                    statement(type, " spvBitfieldInsert(", type, " Base, ", type, " Insert, uint Offset, uint Count)");
                    begin_scope();
                    statement("uint Mask = Count == 32 ? 0xffffffff : (((1u << Count) - 1) << (Offset & 31));");
                    statement("return (Base & ~Mask) | ((Insert << Offset) & Mask);");
                    end_scope();
                    statement("");
                }
            }
        }
        if (requires_bitfield_extract)
        {
            {
                var __r4 = unsigned_types_static23;
                for (int __i5 = 0; __i5 < __r4.Length; __i5++)
                {
                    ref string type = ref __r4[__i5];
                    statement(type, " spvBitfieldUExtract(", type, " Base, uint Offset, uint Count)");
                    begin_scope();
                    statement("uint Mask = Count == 32 ? 0xffffffff : ((1 << Count) - 1);");
                    statement("return (Base >> Offset) & Mask;");
                    end_scope();
                    statement("");
                }
            }
            {
                var __r6 = signed_types_static24;
                for (int __i7 = 0; __i7 < __r6.Length; __i7++)
                {
                    ref string type = ref __r6[__i7];
                    statement(type, " spvBitfieldSExtract(", type, " Base, int Offset, int Count)");
                    begin_scope();
                    statement("int Mask = Count == 32 ? -1 : ((1 << Count) - 1);");
                    statement(type, " Masked = (Base >> Offset) & Mask;");
                    statement("int ExtendShift = (32 - Count) & 31;");
                    statement("return (Masked << ExtendShift) >> ExtendShift;");
                    end_scope();
                    statement("");
                }
            }
        }
        if (requires_inverse_2x2)
        {
            statement("// Returns the inverse of a matrix, by using the algorithm of calculating the classical");
            statement("// adjoint and dividing by the determinant. The contents of the matrix are changed.");
            statement("float2x2 spvInverse(float2x2 m)");
            begin_scope();
            statement("float2x2 adj;\t// The adjoint matrix (inverse after dividing by determinant)");
            statement_no_indent("");
            statement("// Create the transpose of the cofactors, as the classical adjoint of the matrix.");
            statement("adj[0][0] =  m[1][1];");
            statement("adj[0][1] = -m[0][1];");
            statement_no_indent("");
            statement("adj[1][0] = -m[1][0];");
            statement("adj[1][1] =  m[0][0];");
            statement_no_indent("");
            statement("// Calculate the determinant as a combination of the cofactors of the first row.");
            statement("float det = (adj[0][0] * m[0][0]) + (adj[0][1] * m[1][0]);");
            statement_no_indent("");
            statement("// Divide the classical adjoint matrix by the determinant.");
            statement("// If determinant is zero, matrix is not invertable, so leave it unchanged.");
            statement("return (det != 0.0f) ? (adj * (1.0f / det)) : m;");
            end_scope();
            statement("");
        }
        if (requires_inverse_3x3)
        {
            statement("// Returns the determinant of a 2x2 matrix.");
            statement("float spvDet2x2(float a1, float a2, float b1, float b2)");
            begin_scope();
            statement("return a1 * b2 - b1 * a2;");
            end_scope();
            statement_no_indent("");
            statement("// Returns the inverse of a matrix, by using the algorithm of calculating the classical");
            statement("// adjoint and dividing by the determinant. The contents of the matrix are changed.");
            statement("float3x3 spvInverse(float3x3 m)");
            begin_scope();
            statement("float3x3 adj;\t// The adjoint matrix (inverse after dividing by determinant)");
            statement_no_indent("");
            statement("// Create the transpose of the cofactors, as the classical adjoint of the matrix.");
            statement("adj[0][0] =  spvDet2x2(m[1][1], m[1][2], m[2][1], m[2][2]);");
            statement("adj[0][1] = -spvDet2x2(m[0][1], m[0][2], m[2][1], m[2][2]);");
            statement("adj[0][2] =  spvDet2x2(m[0][1], m[0][2], m[1][1], m[1][2]);");
            statement_no_indent("");
            statement("adj[1][0] = -spvDet2x2(m[1][0], m[1][2], m[2][0], m[2][2]);");
            statement("adj[1][1] =  spvDet2x2(m[0][0], m[0][2], m[2][0], m[2][2]);");
            statement("adj[1][2] = -spvDet2x2(m[0][0], m[0][2], m[1][0], m[1][2]);");
            statement_no_indent("");
            statement("adj[2][0] =  spvDet2x2(m[1][0], m[1][1], m[2][0], m[2][1]);");
            statement("adj[2][1] = -spvDet2x2(m[0][0], m[0][1], m[2][0], m[2][1]);");
            statement("adj[2][2] =  spvDet2x2(m[0][0], m[0][1], m[1][0], m[1][1]);");
            statement_no_indent("");
            statement("// Calculate the determinant as a combination of the cofactors of the first row.");
            statement("float det = (adj[0][0] * m[0][0]) + (adj[0][1] * m[1][0]) + (adj[0][2] * m[2][0]);");
            statement_no_indent("");
            statement("// Divide the classical adjoint matrix by the determinant.");
            statement("// If determinant is zero, matrix is not invertable, so leave it unchanged.");
            statement("return (det != 0.0f) ? (adj * (1.0f / det)) : m;");
            end_scope();
            statement("");
        }
        if (requires_inverse_4x4)
        {
            if (!requires_inverse_3x3)
            {
                statement("// Returns the determinant of a 2x2 matrix.");
                statement("float spvDet2x2(float a1, float a2, float b1, float b2)");
                begin_scope();
                statement("return a1 * b2 - b1 * a2;");
                end_scope();
                statement("");
            }
            statement("// Returns the determinant of a 3x3 matrix.");
            statement("float spvDet3x3(float a1, float a2, float a3, float b1, float b2, float b3, float c1, float c2, float c3)");
            begin_scope();
            statement("return a1 * spvDet2x2(b2, b3, c2, c3) - b1 * spvDet2x2(a2, a3, c2, c3) + c1 * spvDet2x2(a2, a3, b2, b3);");
            end_scope();
            statement_no_indent("");
            statement("// Returns the inverse of a matrix, by using the algorithm of calculating the classical");
            statement("// adjoint and dividing by the determinant. The contents of the matrix are changed.");
            statement("float4x4 spvInverse(float4x4 m)");
            begin_scope();
            statement("float4x4 adj;\t// The adjoint matrix (inverse after dividing by determinant)");
            statement_no_indent("");
            statement("// Create the transpose of the cofactors, as the classical adjoint of the matrix.");
            statement("adj[0][0] =  spvDet3x3(m[1][1], m[1][2], m[1][3], m[2][1], m[2][2], m[2][3], m[3][1], m[3][2], m[3][3]);");
            statement("adj[0][1] = -spvDet3x3(m[0][1], m[0][2], m[0][3], m[2][1], m[2][2], m[2][3], m[3][1], m[3][2], m[3][3]);");
            statement("adj[0][2] =  spvDet3x3(m[0][1], m[0][2], m[0][3], m[1][1], m[1][2], m[1][3], m[3][1], m[3][2], m[3][3]);");
            statement("adj[0][3] = -spvDet3x3(m[0][1], m[0][2], m[0][3], m[1][1], m[1][2], m[1][3], m[2][1], m[2][2], m[2][3]);");
            statement_no_indent("");
            statement("adj[1][0] = -spvDet3x3(m[1][0], m[1][2], m[1][3], m[2][0], m[2][2], m[2][3], m[3][0], m[3][2], m[3][3]);");
            statement("adj[1][1] =  spvDet3x3(m[0][0], m[0][2], m[0][3], m[2][0], m[2][2], m[2][3], m[3][0], m[3][2], m[3][3]);");
            statement("adj[1][2] = -spvDet3x3(m[0][0], m[0][2], m[0][3], m[1][0], m[1][2], m[1][3], m[3][0], m[3][2], m[3][3]);");
            statement("adj[1][3] =  spvDet3x3(m[0][0], m[0][2], m[0][3], m[1][0], m[1][2], m[1][3], m[2][0], m[2][2], m[2][3]);");
            statement_no_indent("");
            statement("adj[2][0] =  spvDet3x3(m[1][0], m[1][1], m[1][3], m[2][0], m[2][1], m[2][3], m[3][0], m[3][1], m[3][3]);");
            statement("adj[2][1] = -spvDet3x3(m[0][0], m[0][1], m[0][3], m[2][0], m[2][1], m[2][3], m[3][0], m[3][1], m[3][3]);");
            statement("adj[2][2] =  spvDet3x3(m[0][0], m[0][1], m[0][3], m[1][0], m[1][1], m[1][3], m[3][0], m[3][1], m[3][3]);");
            statement("adj[2][3] = -spvDet3x3(m[0][0], m[0][1], m[0][3], m[1][0], m[1][1], m[1][3], m[2][0], m[2][1], m[2][3]);");
            statement_no_indent("");
            statement("adj[3][0] = -spvDet3x3(m[1][0], m[1][1], m[1][2], m[2][0], m[2][1], m[2][2], m[3][0], m[3][1], m[3][2]);");
            statement("adj[3][1] =  spvDet3x3(m[0][0], m[0][1], m[0][2], m[2][0], m[2][1], m[2][2], m[3][0], m[3][1], m[3][2]);");
            statement("adj[3][2] = -spvDet3x3(m[0][0], m[0][1], m[0][2], m[1][0], m[1][1], m[1][2], m[3][0], m[3][1], m[3][2]);");
            statement("adj[3][3] =  spvDet3x3(m[0][0], m[0][1], m[0][2], m[1][0], m[1][1], m[1][2], m[2][0], m[2][1], m[2][2]);");
            statement_no_indent("");
            statement("// Calculate the determinant as a combination of the cofactors of the first row.");
            statement("float det = (adj[0][0] * m[0][0]) + (adj[0][1] * m[1][0]) + (adj[0][2] * m[2][0]) + (adj[0][3] * m[3][0]);");
            statement_no_indent("");
            statement("// Divide the classical adjoint matrix by the determinant.");
            statement("// If determinant is zero, matrix is not invertable, so leave it unchanged.");
            statement("return (det != 0.0f) ? (adj * (1.0f / det)) : m;");
            end_scope();
            statement("");
        }
        if (requires_scalar_reflect)
        {
            statement("float spvReflect(float i, float n)");
            begin_scope();
            statement("return i - 2.0 * dot(n, i) * n;");
            end_scope();
            statement("");
        }
        if (requires_scalar_refract)
        {
            statement("float spvRefract(float i, float n, float eta)");
            begin_scope();
            statement("float NoI = n * i;");
            statement("float NoI2 = NoI * NoI;");
            statement("float k = 1.0 - eta * eta * (1.0 - NoI2);");
            statement("if (k < 0.0)");
            begin_scope();
            statement("return 0.0;");
            end_scope();
            statement("else");
            begin_scope();
            statement("return eta * i - (eta * NoI + sqrt(k)) * n;");
            end_scope();
            end_scope();
            statement("");
        }
        if (requires_scalar_faceforward)
        {
            statement("float spvFaceForward(float n, float i, float nref)");
            begin_scope();
            statement("return i * nref < 0.0 ? n : -n;");
            end_scope();
            statement("");
        }
        {
            foreach (TypedID_TypeType type_id in composite_selection_workaround_types)
            {
                var type = get__SPIRType(((uint)type_id));
                var type_str = type_to_glsl(type, 0u);
                var type_arr_str = type_to_array_glsl(type, 0u);
                statement("void spvSelectComposite(out ", type_str, " out_value", type_arr_str, ", bool cond, ", type_str, " true_val", type_arr_str, ", ", type_str, " false_val", type_arr_str, ")");
                begin_scope();
                statement("if (cond)");
                begin_scope();
                statement("out_value = true_val;");
                end_scope();
                statement("else");
                begin_scope();
                statement("out_value = false_val;");
                end_scope();
                end_scope();
                statement("");
            }
        }
        if (is_mesh_shader && options.vertex.flip_vert_y)
        {
            statement("float4 spvFlipVertY(float4 v)");
            begin_scope();
            statement("return float4(v.x, -v.y, v.z, v.w);");
            end_scope();
            statement("");
            statement("float spvFlipVertY(float v)");
            begin_scope();
            statement("return -v;");
            end_scope();
            statement("");
        }
    }
    public void emit_interface_block_globally(SPIRVariable @var)
    {
        add_resource_name(((uint)@var.self));
        var flags = ir.meta[@var.self].decoration.decoration_flags;
        var old_flags = flags.Clone();
        flags.reset();
        statement("static ", variable_decl(@var), ";");
        flags.CopyFrom(old_flags);
    }
    public void emit_interface_block_in_struct(SPIRVariable @var, UnorderedSet<uint> active_locations)
    {
        var execution = get_entry_point();
        var type = (get__SPIRType(((uint)@var.basetype))).Clone();
        CppString binding = default(CppString);
        bool use_location_number = true;
        bool need_matrix_unroll = false;
        bool legacy = hlsl_options.shader_model <= 30u;
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelFragment) && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput))
        {
            uint index = get_decoration(@var.self, Spv.Decoration.DecorationIndex);
            uint location = get_decoration(@var.self, Spv.Decoration.DecorationLocation);
            if (index != 0u && location != 0u)
            {
                throw new CompilerError("Dual-source blending is only supported on MRT #0 in HLSL.");
            }
            binding = Std.join(legacy ? "COLOR" : "SV_Target", location + index);
            use_location_number = false;
            if (legacy)
            {
                type.vecsize = 4u;
            }
        }
        else
        if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) && unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex))
        {
            need_matrix_unroll = true;
            if (legacy)
            {
                type.basetype = SPIRType.BaseType.Float;
            }
        }
        var get_vacant_location = () =>
        {
            {
                for (uint i = 0u; i < 64u; i++)
                {
                    if (!(active_locations.count(i) != 0UL))
                    {
                        return i;
                    }
                }
            }
            throw new CompilerError("All locations from 0 to 63 are exhausted.");
        };
        var name = to_name(((uint)@var.self), true);
        if (use_location_number)
        {
            uint location_number = 4294967295u;
            CppString semantic = default(CppString);
            bool has_user_semantic = false;
            if (hlsl_options.user_semantic && has_decoration(@var.self, Spv.Decoration.DecorationUserSemantic))
            {
                semantic = get_decoration_string(@var.self, Spv.Decoration.DecorationUserSemantic);
                has_user_semantic = true;
            }
            else
            {
                if (has_decoration(@var.self, Spv.Decoration.DecorationLocation))
                {
                    location_number = get_decoration(@var.self, Spv.Decoration.DecorationLocation);
                }
                else
                {
                    location_number = get_vacant_location();
                }
                semantic = to_semantic(location_number, execution.model, @var.storage);
            }
            if (need_matrix_unroll && type.columns > 1u)
            {
                if (!type.array.empty())
                {
                    throw new CompilerError("Arrays of matrices used as input/output. This is not supported.");
                }
                {
                    for (uint i = 0u; i < type.columns; i++)
                    {
                        SPIRType newtype = type.Clone();
                        newtype.columns = 1u;
                        CppString effective_semantic = default(CppString);
                        if (hlsl_options.flatten_matrix_vertex_input_semantics && !has_user_semantic)
                        {
                            effective_semantic = to_semantic(location_number, execution.model, @var.storage);
                        }
                        else
                        {
                            effective_semantic = Std.join(semantic, "_", i);
                        }
                        statement(to_interpolation_qualifiers(get_decoration_bitset(@var.self)), variable_decl(newtype, Std.join(name, "_", i), 0u), " : ", effective_semantic, ";");
                        if (location_number != 4294967295u)
                        {
                            active_locations.insert(location_number++);
                        }
                    }
                }
            }
            else
            {
                var decl_type = type.Clone();
                if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT) || unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry) && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) || has_decoration(@var.self, Spv.Decoration.DecorationPerVertexKHR))
                {
                    decl_type.array.pop_back();
                    decl_type.array_size_literal.pop_back();
                }
                statement(to_interpolation_qualifiers(get_decoration_bitset(@var.self)), variable_decl(decl_type, name, 0u), " : ", semantic, ";");
                if (location_number != 4294967295u)
                {
                    uint consumed_locations = type_to_consumed_locations(decl_type);
                    {
                        for (uint i = 0u; i < consumed_locations; i++)
                        {
                            active_locations.insert(location_number + i);
                        }
                    }
                }
            }
        }
        else
        {
            statement(variable_decl(type, name, 0u), " : ", binding, ";");
        }
    }
    public void emit_interface_block_member_in_struct(SPIRVariable @var, uint member_index, uint location, UnorderedSet<uint> active_locations)
    {
        var execution = get_entry_point();
        var type = (get__SPIRType(((uint)@var.basetype))).Clone();
        CppString semantic = default(CppString);
        if (hlsl_options.user_semantic && has_member_decoration(((TypedID_TypeType)@var.self), member_index, Spv.Decoration.DecorationUserSemantic))
        {
            semantic = get_member_decoration_string(((TypedID_TypeType)@var.self), member_index, Spv.Decoration.DecorationUserSemantic);
        }
        else
        {
            semantic = to_semantic(location, execution.model, @var.storage);
        }
        var mbr_name = Std.join(to_name(((uint)type.self), true), "_", to_member_name(type, member_index));
        var mbr_type = get__SPIRType(((uint)type.member_types[unchecked((ulong)member_index)]));
        Bitset member_decorations = (get_member_decoration_bitset(((TypedID_TypeType)type.self), member_index)).Clone();
        if (has_decoration(@var.self, Spv.Decoration.DecorationPerVertexKHR))
        {
            member_decorations.set(unchecked((uint)Spv.Decoration.DecorationPerVertexKHR));
        }
        statement(to_interpolation_qualifiers(member_decorations), type_to_glsl(mbr_type, 0u), " ", mbr_name, type_to_array_glsl(mbr_type, ((uint)@var.self)), " : ", semantic, ";");
        uint consumed_locations = type_to_consumed_locations(mbr_type);
        {
            for (uint i = 0u; i < consumed_locations; i++)
            {
                active_locations.insert(location + i);
            }
        }
    }
    private static string[] types_static16 = new string[] { "float", "float2", "float3", "float4" };
    private static string[] types_static17 = new string[] { "float", "float2", "float3", "float4" };
    public void emit_builtin_inputs_in_struct()
    {
        bool legacy = hlsl_options.shader_model <= 30u;
        active_input_builtins.for_each_bit__lambda((uint i) =>
        {
            string type = null;
            string semantic = null;
            var builtin = unchecked((Spv.BuiltIn)i);
            {
                switch (unchecked((int)builtin))
                {
                    case unchecked((int)Spv.BuiltIn.BuiltInPosition):
                    {
                        type = "float4";
                        semantic = legacy ? "POSITION" : "SV_Position";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInFragCoord):
                    {
                        type = "float4";
                        semantic = legacy ? "VPOS" : "SV_Position";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInVertexId):
                    case unchecked((int)Spv.BuiltIn.BuiltInVertexIndex):
                    {
                        if (legacy)
                        {
                            throw new CompilerError("Vertex index not supported in SM 3.0 or lower.");
                        }
                        type = "uint";
                        semantic = "SV_VertexID";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveId):
                    {
                        if (unchecked((int)this.get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
                        {
                            type = "uint";
                            semantic = "SV_PrimitiveID";
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInInvocationId):
                    {
                        if (unchecked((int)this.get_entry_point().model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
                        {
                            type = "uint";
                            semantic = "SV_GSInstanceID";
                        }
                        else
                        if (unchecked((int)this.get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl))
                        {
                            throw new CompilerError("InvocationId is only supported in geometry and tessellation control shaders.");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInInstanceId):
                    case unchecked((int)Spv.BuiltIn.BuiltInInstanceIndex):
                    {
                        if (legacy)
                        {
                            throw new CompilerError("Instance index not supported in SM 3.0 or lower.");
                        }
                        type = "uint";
                        semantic = "SV_InstanceID";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSampleId):
                    {
                        if (legacy)
                        {
                            throw new CompilerError("Sample ID not supported in SM 3.0 or lower.");
                        }
                        type = "uint";
                        semantic = "SV_SampleIndex";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                    {
                        if (this.hlsl_options.shader_model < 50u || unchecked((int)this.get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                        {
                            throw new CompilerError("Sample Mask input is only supported in PS 5.0 or higher.");
                        }
                        type = "uint";
                        semantic = "SV_Coverage";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInGlobalInvocationId):
                    {
                        type = "uint3";
                        semantic = "SV_DispatchThreadID";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInLocalInvocationId):
                    {
                        type = "uint3";
                        semantic = "SV_GroupThreadID";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInLocalInvocationIndex):
                    {
                        type = "uint";
                        semantic = "SV_GroupIndex";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInWorkgroupId):
                    {
                        type = "uint3";
                        semantic = "SV_GroupID";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInFrontFacing):
                    {
                        type = "bool";
                        semantic = "SV_IsFrontFace";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInViewIndex):
                    {
                        if (this.hlsl_options.shader_model < 61u || unchecked((int)this.get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelVertex) && unchecked((int)this.get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                        {
                            throw new CompilerError("View Index input is only supported in VS and PS 6.1 or higher.");
                        }
                        type = "uint";
                        semantic = "SV_ViewID";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInNumWorkgroups):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupSize):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLocalInvocationId):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupEqMask):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLtMask):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLeMask):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGtMask):
                    case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGeMask):
                    {
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInBaseVertex):
                    {
                        if (this.hlsl_options.shader_model >= 68u)
                        {
                            type = "uint";
                            semantic = "SV_StartVertexLocation";
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInBaseInstance):
                    {
                        if (this.hlsl_options.shader_model >= 68u)
                        {
                            type = "uint";
                            semantic = "SV_StartInstanceLocation";
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInHelperInvocation):
                    {
                        if (this.hlsl_options.shader_model < 50u || unchecked((int)this.get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                        {
                            throw new CompilerError("Helper Invocation input is only supported in PS 5.0 or higher.");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                    {
                        {
                            for (uint clip = 0u; clip < this.clip_distance_count; clip += 4u)
                            {
                                uint to_declare = this.clip_distance_count - clip;
                                if (to_declare > 4u)
                                {
                                    to_declare = 4u;
                                }
                                uint semantic_index = clip / 4u;
                                statement(types_static16[to_declare - 1u], " ", this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassInput), semantic_index, " : SV_ClipDistance", semantic_index, ";");
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                    {
                        {
                            for (uint cull = 0u; cull < this.cull_distance_count; cull += 4u)
                            {
                                uint to_declare = this.cull_distance_count - cull;
                                if (to_declare > 4u)
                                {
                                    to_declare = 4u;
                                }
                                uint semantic_index = cull / 4u;
                                statement(types_static17[to_declare - 1u], " ", this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassInput), semantic_index, " : SV_CullDistance", semantic_index, ";");
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInPointCoord):
                    {
                        if (this.hlsl_options.point_coord_compat)
                        {
                            break;
                        }
                        else
                        {
                            throw new CompilerError("Unsupported builtin in HLSL.");
                        }
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInLayer):
                    {
                        if (this.hlsl_options.shader_model < 50u || unchecked((int)this.get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                        {
                            throw new CompilerError("Render target array index input is only supported in PS 5.0 or higher.");
                        }
                        type = "uint";
                        semantic = "SV_RenderTargetArrayIndex";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordKHR):
                    case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordNoPerspKHR):
                    {
                        if (this.hlsl_options.shader_model < 61u)
                        {
                            throw new CompilerError("SM 6.1 is required for barycentrics.");
                        }
                        type = unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInBaryCoordNoPerspKHR) ? "noperspective float3" : "float3";
                        if (this.active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInBaryCoordKHR)) && this.active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInBaryCoordNoPerspKHR)))
                        {
                            semantic = unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInBaryCoordKHR) ? "SV_Barycentrics0" : "SV_Barycentrics1";
                        }
                        else
                        {
                            semantic = "SV_Barycentrics";
                        }
                        break;
                    }
                    default:
                    {
                        throw new CompilerError("Unsupported builtin in HLSL.");
                    }
                }
            }
            if (type != null && semantic != null)
            {
                statement(type, " ", this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassInput), " : ", semantic, ";");
            }
        });
    }
    private static string[] types_static14 = new string[] { "float", "float2", "float3", "float4" };
    private static string[] types_static15 = new string[] { "float", "float2", "float3", "float4" };
    public void emit_builtin_outputs_in_struct()
    {
        var execution = get_entry_point();
        bool legacy = hlsl_options.shader_model <= 30u;
        active_output_builtins.for_each_bit__lambda((uint i) =>
        {
            string type = null;
            string semantic = null;
            var builtin = unchecked((Spv.BuiltIn)i);
            {
                switch (unchecked((int)builtin))
                {
                    case unchecked((int)Spv.BuiltIn.BuiltInPosition):
                    {
                        type = this.is_position_invariant() && this.backend.support_precise_qualifier ? "precise float4" : "float4";
                        semantic = legacy ? "POSITION" : "SV_Position";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                    {
                        if (this.hlsl_options.shader_model < 41u || unchecked((int)execution.model) != unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                        {
                            throw new CompilerError("Sample Mask output is only supported in PS 4.1 or higher.");
                        }
                        type = "uint";
                        semantic = "SV_Coverage";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInFragDepth):
                    {
                        type = "float";
                        if (legacy)
                        {
                            semantic = "DEPTH";
                        }
                        else
                        {
                            if (this.hlsl_options.shader_model >= 50u && execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeDepthGreater)))
                            {
                                semantic = "SV_DepthGreaterEqual";
                            }
                            else
                            if (this.hlsl_options.shader_model >= 50u && execution.flags.get(unchecked((uint)Spv.ExecutionMode.ExecutionModeDepthLess)))
                            {
                                semantic = "SV_DepthLessEqual";
                            }
                            else
                            {
                                semantic = "SV_Depth";
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                    {
                        {
                            if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT))
                            {
                                if (this.clip_distance_count > 4u)
                                {
                                    throw new CompilerError("Clip distance count > 4 not supported for mesh shaders.");
                                }
                                if (this.clip_distance_count == 1u)
                                {
                                    statement("float gl_ClipDistance[1] : SV_ClipDistance;");
                                }
                                else
                                {
                                    statement(types_static14[this.clip_distance_count - 1u], " gl_ClipDistance : SV_ClipDistance;");
                                }
                            }
                            else
                            {
                                {
                                    for (uint clip = 0u; clip < this.clip_distance_count; clip += 4u)
                                    {
                                        uint to_declare = this.clip_distance_count - clip;
                                        if (to_declare > 4u)
                                        {
                                            to_declare = 4u;
                                        }
                                        uint semantic_index = clip / 4u;
                                        statement(types_static14[to_declare - 1u], " ", this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassOutput), semantic_index, " : SV_ClipDistance", semantic_index, ";");
                                    }
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                    {
                        {
                            if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT))
                            {
                                if (this.cull_distance_count > 4u)
                                {
                                    throw new CompilerError("Cull distance count > 4 not supported for mesh shaders.");
                                }
                                if (this.cull_distance_count == 1u)
                                {
                                    statement("float gl_CullDistance[1] : SV_CullDistance;");
                                }
                                else
                                {
                                    statement(types_static15[this.cull_distance_count - 1u], " gl_CullDistance : SV_CullDistance;");
                                }
                            }
                            else
                            {
                                {
                                    for (uint cull = 0u; cull < this.cull_distance_count; cull += 4u)
                                    {
                                        uint to_declare = this.cull_distance_count - cull;
                                        if (to_declare > 4u)
                                        {
                                            to_declare = 4u;
                                        }
                                        uint semantic_index = cull / 4u;
                                        statement(types_static15[to_declare - 1u], " ", this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassOutput), semantic_index, " : SV_CullDistance", semantic_index, ";");
                                    }
                                }
                            }
                            break;
                        }
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInPointSize):
                    {
                        if (legacy)
                        {
                            type = "float";
                            semantic = "PSIZE";
                        }
                        else
                        if (!this.hlsl_options.point_size_compat)
                        {
                            throw new CompilerError("Unsupported builtin in HLSL.");
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInLayer):
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveId):
                    case unchecked((int)Spv.BuiltIn.BuiltInViewportIndex):
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveShadingRateKHR):
                    case unchecked((int)Spv.BuiltIn.BuiltInCullPrimitiveEXT):
                    {
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitivePointIndicesEXT):
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveLineIndicesEXT):
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveTriangleIndicesEXT):
                    {
                        break;
                    }
                    default:
                    {
                        throw new CompilerError("Unsupported builtin in HLSL.");
                    }
                }
            }
            if (type != null && semantic != null)
            {
                statement(type, " ", this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassOutput), " : ", semantic, ";");
            }
        });
    }
    public void emit_builtin_primitive_outputs_in_struct()
    {
        active_output_builtins.for_each_bit__lambda((uint i) =>
        {
            string type = null;
            string semantic = null;
            var builtin = unchecked((Spv.BuiltIn)i);
            {
                switch (unchecked((int)builtin))
                {
                    case unchecked((int)Spv.BuiltIn.BuiltInLayer):
                    {
                        {
                            if (this.hlsl_options.shader_model < 50u)
                            {
                                throw new CompilerError("Render target array index output is only supported in SM 5.0 or higher.");
                            }
                            type = "uint";
                            semantic = "SV_RenderTargetArrayIndex";
                            break;
                        }
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveId):
                    {
                        type = "uint";
                        semantic = "SV_PrimitiveID";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInViewportIndex):
                    {
                        type = "uint";
                        semantic = "SV_ViewportArrayIndex";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveShadingRateKHR):
                    {
                        type = "uint";
                        semantic = "SV_ShadingRate";
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInCullPrimitiveEXT):
                    {
                        type = "bool";
                        semantic = "SV_CullPrimitive";
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
            if (type != null && semantic != null)
            {
                statement(type, " ", this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassOutput), " : ", semantic, ";");
            }
        });
    }
    public override void emit_texture_op(Instruction i, bool sparse)
    {
        if (sparse)
        {
            throw new CompilerError("Sparse feedback not yet supported in HLSL.");
        }
        var ops = stream(i);
        var op = unchecked((Spv.Op)i.op);
        uint length = i.length;
        CppVector<uint> inherited_expressions = new CppVector<uint>();
        uint result_type = ops[0];
        uint id = ops[1];
        TypedID_TypeVariable img = new TypedID_TypeVariable(ops[2]);
        uint coord = ops[3];
        uint dref = 0u;
        uint comp = 0u;
        bool gather = false;
        bool proj = false;
        Ptr<uint> opt = null;
        var combined_image = maybe_get__SPIRCombinedImageSampler(((uint)img));
        if (combined_image != null && has_decoration(new TypedID_TypeNone(img), Spv.Decoration.DecorationNonUniform))
        {
            set_decoration(new TypedID_TypeNone(combined_image.image), Spv.Decoration.DecorationNonUniform, 0u);
            set_decoration(new TypedID_TypeNone(combined_image.sampler), Spv.Decoration.DecorationNonUniform, 0u);
        }
        var img_expr = to_non_uniform_aware_expression(((uint)(combined_image != null ? combined_image.image : img)));
        inherited_expressions.push_back(coord);
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleDrefExplicitLod):
                {
                    dref = ops[4];
                    opt = ops + 5;
                    length -= 5u;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjDrefExplicitLod):
                {
                    dref = ops[4];
                    proj = true;
                    opt = ops + 5;
                    length -= 5u;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageDrefGather):
                {
                    dref = ops[4];
                    opt = ops + 5;
                    gather = true;
                    length -= 5u;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageGather):
                {
                    comp = ops[4];
                    opt = ops + 5;
                    gather = true;
                    length -= 5u;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjExplicitLod):
                {
                    opt = ops + 4;
                    length -= 4u;
                    proj = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQueryLod):
                {
                    opt = ops + 4;
                    length -= 4u;
                    break;
                }
                default:
                {
                    opt = ops + 4;
                    length -= 4u;
                    break;
                }
            }
        }
        var imgtype = expression_type(((uint)img));
        uint coord_components = 0u;
        {
            switch (unchecked((int)imgtype.image.dim))
            {
                case unchecked((int)Spv.Dim.Dim1D):
                {
                    coord_components = 1u;
                    break;
                }
                case unchecked((int)Spv.Dim.Dim2D):
                {
                    coord_components = 2u;
                    break;
                }
                case unchecked((int)Spv.Dim.Dim3D):
                {
                    coord_components = 3u;
                    break;
                }
                case unchecked((int)Spv.Dim.DimCube):
                {
                    coord_components = 3u;
                    break;
                }
                case unchecked((int)Spv.Dim.DimBuffer):
                {
                    coord_components = 1u;
                    break;
                }
                default:
                {
                    coord_components = 2u;
                    break;
                }
            }
        }
        if (dref != 0u)
        {
            inherited_expressions.push_back(dref);
        }
        if (imgtype.image.arrayed && unchecked((int)op) != unchecked((int)Spv.Op.OpImageQueryLod))
        {
            coord_components++;
        }
        uint bias = 0u;
        uint lod = 0u;
        uint grad_x = 0u;
        uint grad_y = 0u;
        uint coffset = 0u;
        uint offset = 0u;
        uint coffsets = 0u;
        uint sample = 0u;
        uint minlod = 0u;
        uint flags = 0u;
        if (length != 0u)
        {
            flags = opt[0];
            opt++;
            length--;
        }
        Callback_196313 test = (ref uint v, uint flag) =>
        {
            if (length != 0u && (flags & flag) != 0u)
            {
                v = opt++.Value;
                inherited_expressions.push_back(v);
                length--;
            }
        };
        test(ref bias, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsBiasMask));
        test(ref lod, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsLodMask));
        test(ref grad_x, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsGradMask));
        test(ref grad_y, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsGradMask));
        test(ref coffset, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsConstOffsetMask));
        test(ref offset, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsOffsetMask));
        test(ref coffsets, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsConstOffsetsMask));
        test(ref sample, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsSampleMask));
        test(ref minlod, unchecked((uint)Spv.ImageOperandsMask.ImageOperandsMinLodMask));
        CppString expr = default(CppString);
        CppString texop = default(CppString);
        if (minlod != 0u)
        {
            throw new CompilerError("MinLod texture operand not supported in HLSL.");
        }
        if (unchecked((int)op) == unchecked((int)Spv.Op.OpImageFetch))
        {
            if (hlsl_options.shader_model < 40u)
            {
                throw new CompilerError("texelFetch is not supported in HLSL shader model 2/3.");
            }
            texop += img_expr;
            texop += ".Load";
        }
        else
        if (unchecked((int)op) == unchecked((int)Spv.Op.OpImageQueryLod))
        {
            texop += img_expr;
            texop += ".CalculateLevelOfDetail";
        }
        else
        {
            var imgformat = get__SPIRType(((uint)imgtype.image.type));
            if (hlsl_options.shader_model < 67u && unchecked((int)imgformat.basetype) != unchecked((int)SPIRType.BaseType.Float) && !gather)
            {
                throw new CompilerError("Sampling non-float textures is not supported in HLSL SM < 6.7.");
            }
            if (hlsl_options.shader_model >= 40u)
            {
                texop += img_expr;
                if (is_depth_image(imgtype, ((uint)img)))
                {
                    if (gather)
                    {
                        texop += ".GatherCmp";
                    }
                    else
                    if (lod != 0u || grad_x != 0u || grad_y != 0u)
                    {
                        texop += ".SampleCmpLevelZero";
                    }
                    else
                    {
                        texop += ".SampleCmp";
                    }
                }
                else
                if (gather)
                {
                    uint comp_num = evaluate_constant_u32(comp);
                    if (hlsl_options.shader_model >= 50u)
                    {
                        {
                            switch (comp_num)
                            {
                                case 0u:
                                {
                                    texop += ".GatherRed";
                                    break;
                                }
                                case 1u:
                                {
                                    texop += ".GatherGreen";
                                    break;
                                }
                                case 2u:
                                {
                                    texop += ".GatherBlue";
                                    break;
                                }
                                case 3u:
                                {
                                    texop += ".GatherAlpha";
                                    break;
                                }
                                default:
                                {
                                    throw new CompilerError("Invalid component.");
                                }
                            }
                        }
                    }
                    else
                    {
                        if (comp_num == 0u)
                        {
                            texop += ".Gather";
                        }
                        else
                        {
                            throw new CompilerError("HLSL shader model 4 can only gather from the red component.");
                        }
                    }
                }
                else
                if (bias != 0u)
                {
                    texop += ".SampleBias";
                }
                else
                if (grad_x != 0u || grad_y != 0u)
                {
                    texop += ".SampleGrad";
                }
                else
                if (lod != 0u)
                {
                    texop += ".SampleLevel";
                }
                else
                {
                    texop += ".Sample";
                }
            }
            else
            {
                {
                    switch (unchecked((int)imgtype.image.dim))
                    {
                        case unchecked((int)Spv.Dim.Dim1D):
                        {
                            texop += "tex1D";
                            break;
                        }
                        case unchecked((int)Spv.Dim.Dim2D):
                        {
                            texop += "tex2D";
                            break;
                        }
                        case unchecked((int)Spv.Dim.Dim3D):
                        {
                            texop += "tex3D";
                            break;
                        }
                        case unchecked((int)Spv.Dim.DimCube):
                        {
                            texop += "texCUBE";
                            break;
                        }
                        case unchecked((int)Spv.Dim.DimRect):
                        case unchecked((int)Spv.Dim.DimBuffer):
                        case unchecked((int)Spv.Dim.DimSubpassData):
                        {
                            throw new CompilerError("Buffer texture support is not yet implemented for HLSL");
                        }
                        default:
                        {
                            throw new CompilerError("Invalid dimension.");
                        }
                    }
                }
                if (gather)
                {
                    throw new CompilerError("textureGather is not supported in HLSL shader model 2/3.");
                }
                if (offset != 0u || coffset != 0u)
                {
                    throw new CompilerError("textureOffset is not supported in HLSL shader model 2/3.");
                }
                if (grad_x != 0u || grad_y != 0u)
                {
                    texop += "grad";
                }
                else
                if (lod != 0u)
                {
                    texop += "lod";
                }
                else
                if (bias != 0u)
                {
                    texop += "bias";
                }
                else
                if (proj || dref != 0u)
                {
                    texop += "proj";
                }
            }
        }
        expr += texop;
        expr += "(";
        if (hlsl_options.shader_model < 40u)
        {
            if (combined_image != null)
            {
                throw new CompilerError("Separate images/samplers are not supported in HLSL shader model 2/3.");
            }
            expr += to_expression(((uint)img), true);
        }
        else
        if (unchecked((int)op) != unchecked((int)Spv.Op.OpImageFetch))
        {
            CppString sampler_expr = default(CppString);
            if (combined_image != null)
            {
                sampler_expr = to_non_uniform_aware_expression(((uint)combined_image.sampler));
            }
            else
            {
                sampler_expr = to_sampler_expression(((uint)img));
            }
            expr += sampler_expr;
        }
        var swizzle = (uint comps, uint in_comps) =>
        {
            if (comps == in_comps)
            {
                return "";
            }
            {
                switch (comps)
                {
                    case 1u:
                    {
                        return ".x";
                    }
                    case 2u:
                    {
                        return ".xy";
                    }
                    case 3u:
                    {
                        return ".xyz";
                    }
                    default:
                    {
                        return "";
                    }
                }
            }
        };
        bool forward = should_forward(coord);
        CppString coord_expr = default(CppString);
        var coord_type = expression_type(coord);
        if (coord_components != coord_type.vecsize)
        {
            coord_expr = to_enclosed_expression(coord, true) + swizzle(coord_components, expression_type(coord).vecsize);
        }
        else
        {
            coord_expr = to_expression(coord, true);
        }
        if (proj && hlsl_options.shader_model >= 40u)
        {
            coord_expr = coord_expr + " / " + to_extract_component_expression(coord, coord_components);
        }
        if (hlsl_options.shader_model < 40u)
        {
            if (dref != 0u)
            {
                if (unchecked((int)imgtype.image.dim) != unchecked((int)Spv.Dim.Dim1D) && unchecked((int)imgtype.image.dim) != unchecked((int)Spv.Dim.Dim2D))
                {
                    throw new CompilerError("Depth comparison is only supported for 1D and 2D textures in HLSL shader model 2/3.");
                }
                if (grad_x != 0u || grad_y != 0u)
                {
                    throw new CompilerError("Depth comparison is not supported for grad sampling in HLSL shader model 2/3.");
                }
                {
                    for (uint size = coord_components; size < 2u; ++size)
                    {
                        coord_expr += ", 0.0";
                    }
                }
                forward = forward && should_forward(dref);
                coord_expr += ", " + to_expression(dref, true);
            }
            else
            if (lod != 0u || bias != 0u || proj)
            {
                {
                    for (uint size = coord_components; size < 3u; ++size)
                    {
                        coord_expr += ", 0.0";
                    }
                }
            }
            if (lod != 0u)
            {
                coord_expr = "float4(" + coord_expr + ", " + to_expression(lod, true) + ")";
            }
            else
            if (bias != 0u)
            {
                coord_expr = "float4(" + coord_expr + ", " + to_expression(bias, true) + ")";
            }
            else
            if (proj)
            {
                coord_expr = "float4(" + coord_expr + ", " + to_extract_component_expression(coord, coord_components) + ")";
            }
            else
            if (dref != 0u)
            {
                coord_expr = "float4(" + coord_expr + ", 1.0)";
            }
            if ((!!(lod != 0u) ? 1 : 0) + (!!(bias != 0u) ? 1 : 0) + (!!proj ? 1 : 0) > 1)
            {
                throw new CompilerError("Legacy HLSL can only use one of lod/bias/proj modifiers.");
            }
        }
        if (unchecked((int)op) == unchecked((int)Spv.Op.OpImageFetch))
        {
            if (unchecked((int)imgtype.image.dim) != unchecked((int)Spv.Dim.DimBuffer) && !imgtype.image.ms)
            {
                coord_expr = Std.join("int", coord_components + 1u, "(", coord_expr, ", ", lod != 0u ? to_expression(lod, true) : new CppString("0"), ")");
            }
        }
        else
        {
            expr += ", ";
        }
        expr += coord_expr;
        if (dref != 0u && hlsl_options.shader_model >= 40u)
        {
            forward = forward && should_forward(dref);
            expr += ", ";
            if (proj)
            {
                expr += to_enclosed_expression(dref, true) + " / " + to_extract_component_expression(coord, coord_components);
            }
            else
            {
                expr += to_expression(dref, true);
            }
        }
        if (!(dref != 0u) && (grad_x != 0u || grad_y != 0u))
        {
            forward = forward && should_forward(grad_x);
            forward = forward && should_forward(grad_y);
            expr += ", ";
            expr += to_expression(grad_x, true);
            expr += ", ";
            expr += to_expression(grad_y, true);
        }
        if (!(dref != 0u) && lod != 0u && hlsl_options.shader_model >= 40u && unchecked((int)op) != unchecked((int)Spv.Op.OpImageFetch))
        {
            forward = forward && should_forward(lod);
            expr += ", ";
            expr += to_expression(lod, true);
        }
        if (!(dref != 0u) && bias != 0u && hlsl_options.shader_model >= 40u)
        {
            forward = forward && should_forward(bias);
            expr += ", ";
            expr += to_expression(bias, true);
        }
        if (coffset != 0u)
        {
            forward = forward && should_forward(coffset);
            expr += ", ";
            expr += to_expression(coffset, true);
        }
        else
        if (offset != 0u)
        {
            forward = forward && should_forward(offset);
            expr += ", ";
            expr += to_expression(offset, true);
        }
        if (sample != 0u)
        {
            expr += ", ";
            expr += to_expression(sample, true);
        }
        expr += ")";
        if (dref != 0u && hlsl_options.shader_model < 40u)
        {
            expr += ".x";
        }
        if (unchecked((int)op) == unchecked((int)Spv.Op.OpImageQueryLod))
        {
            statement("float _", id, "_tmp = ", expr, ";");
            statement("float2 _", id, " = _", id, "_tmp.xx;");
            set__SPIRExpression_X(id, Std.join("_", id), result_type, true);
        }
        else
        {
            emit_op(result_type, id, expr, forward, false);
        }
        {
            var __r0 = inherited_expressions;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref uint inherit = ref __r0[__i1];
                inherit_expression_dependencies(id, inherit);
            }
        }
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                {
                    register_control_dependent_expression(id);
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    public override void emit_instruction(Instruction instruction)
    {
        var ops = stream(instruction);
        var opcode = unchecked((Spv.Op)instruction.op);
        uint length = instruction.length;
        uint integer_width = get_integer_width_for_instruction(instruction);
        var int_type = Globals.to_signed_basetype(integer_width);
        var uint_type = Globals.to_unsigned_basetype(integer_width);
        opcode = get_remapped_spirv_op(opcode);
        {
            switch (unchecked((int)opcode))
            {
                case unchecked((int)Spv.Op.OpAccessChain):
                case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                {
                    {
                        emit_access_chain(instruction);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpBitcast):
                {
                    {
                        var bitcast_type = get_bitcast_type(ops[0], ops[2]);
                        if (unchecked((int)bitcast_type) == unchecked((int)CompilerHLSL.BitcastType.TypeNormal))
                        {
                            base.emit_instruction(instruction);
                        }
                        else
                        {
                            if (!requires_uint2_packing)
                            {
                                requires_uint2_packing = true;
                                force_recompile();
                            }
                            if (unchecked((int)bitcast_type) == unchecked((int)CompilerHLSL.BitcastType.TypePackUint2x32))
                            {
                                emit_unary_func_op(ops[0], ops[1], ops[2], "spvPackUint2x32");
                            }
                            else
                            {
                                emit_unary_func_op(ops[0], ops[1], ops[2], "spvUnpackUint2x32");
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSelect):
                {
                    {
                        var value_type = expression_type(ops[3]);
                        if (unchecked((int)value_type.basetype) == unchecked((int)SPIRType.BaseType.Struct) || is_array(value_type))
                        {
                            TypedID_TypeType value_type_id = new TypedID_TypeType(expression_type_id(ops[3]));
                            var itr = Std.find(composite_selection_workaround_types.begin(), composite_selection_workaround_types.end(), value_type_id);
                            if (itr == composite_selection_workaround_types.end())
                            {
                                composite_selection_workaround_types.push_back(value_type_id);
                                force_recompile();
                            }
                            emit_uninitialized_temporary_expression(ops[0], ops[1]);
                            statement("spvSelectComposite(", to_expression(ops[1], true), ", ", to_expression(ops[2], true), ", ", to_expression(ops[3], true), ", ", to_expression(ops[4], true), ");");
                        }
                        else
                        {
                            base.emit_instruction(instruction);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpStore):
                {
                    {
                        emit_store(instruction);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpLoad):
                {
                    {
                        emit_load(instruction);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpMatrixTimesVector):
                {
                    {
                        emit_binary_func_op(ops[0], ops[1], ops[3], ops[2], "mul");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpVectorTimesMatrix):
                {
                    {
                        emit_binary_func_op(ops[0], ops[1], ops[3], ops[2], "mul");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpMatrixTimesMatrix):
                {
                    {
                        emit_binary_func_op(ops[0], ops[1], ops[3], ops[2], "mul");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpOuterProduct):
                {
                    {
                        uint result_type = ops[0];
                        uint id = ops[1];
                        uint a = ops[2];
                        uint b = ops[3];
                        var type = get__SPIRType(result_type);
                        CppString expr = type_to_glsl_constructor(type);
                        expr += "(";
                        {
                            for (uint col = 0u; col < type.columns; col++)
                            {
                                expr += to_enclosed_expression(a, true);
                                expr += " * ";
                                expr += to_extract_component_expression(b, col);
                                if (col + 1u < type.columns)
                                {
                                    expr += ", ";
                                }
                            }
                        }
                        expr += ")";
                        emit_op(result_type, id, expr, should_forward(a) && should_forward(b), false);
                        inherit_expression_dependencies(id, a);
                        inherit_expression_dependencies(id, b);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFMod):
                {
                    {
                        if (!requires_op_fmod)
                        {
                            requires_op_fmod = true;
                            force_recompile();
                        }
                        base.emit_instruction(instruction);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFRem):
                {
                    emit_binary_func_op(ops[0], ops[1], ops[2], ops[3], "fmod");
                    break;
                }
                case unchecked((int)Spv.Op.OpImage):
                {
                    {
                        uint result_type = ops[0];
                        uint id = ops[1];
                        var combined = maybe_get__SPIRCombinedImageSampler(ops[2]);
                        if (combined != null)
                        {
                            var e = emit_op(result_type, id, to_expression(((uint)combined.image), true), true, true);
                            var @var = maybe_get_backing_variable(((uint)combined.image));
                            if (@var != null)
                            {
                                e.loaded_from = @var.self;
                            }
                        }
                        else
                        {
                            var e = emit_op(result_type, id, to_expression(ops[2], true), true, true);
                            var @var = maybe_get_backing_variable(ops[2]);
                            if (@var != null)
                            {
                                e.loaded_from = @var.self;
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpDPdx):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "ddx");
                    register_control_dependent_expression(ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdy):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "ddy");
                    register_control_dependent_expression(ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdxFine):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "ddx_fine");
                    register_control_dependent_expression(ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdyFine):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "ddy_fine");
                    register_control_dependent_expression(ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdxCoarse):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "ddx_coarse");
                    register_control_dependent_expression(ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdyCoarse):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "ddy_coarse");
                    register_control_dependent_expression(ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpFwidth):
                case unchecked((int)Spv.Op.OpFwidthCoarse):
                case unchecked((int)Spv.Op.OpFwidthFine):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "fwidth");
                    register_control_dependent_expression(ops[1]);
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalNot):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        var type = get__SPIRType(result_type);
                        if (type.vecsize > 1u)
                        {
                            emit_unrolled_unary_op(result_type, id, ops[2], "!");
                        }
                        else
                        {
                            emit_unary_op(ops[0], ops[1], ops[2], "!");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpIEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "==", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op_cast(ops[0], ops[1], ops[2], ops[3], "==", int_type, Globals.opcode_is_sign_invariant(opcode), false);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpLogicalEqual):
                case unchecked((int)Spv.Op.OpFOrdEqual):
                case unchecked((int)Spv.Op.OpFUnordEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "==", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op(ops[0], ops[1], ops[2], ops[3], "==");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpINotEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "!=", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op_cast(ops[0], ops[1], ops[2], ops[3], "!=", int_type, Globals.opcode_is_sign_invariant(opcode), false);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpLogicalNotEqual):
                case unchecked((int)Spv.Op.OpFOrdNotEqual):
                case unchecked((int)Spv.Op.OpFUnordNotEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "!=", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op(ops[0], ops[1], ops[2], ops[3], "!=");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpUGreaterThan):
                case unchecked((int)Spv.Op.OpSGreaterThan):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        var type = unchecked((int)opcode) == unchecked((int)Spv.Op.OpUGreaterThan) ? uint_type : int_type;
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], ">", false, type);
                        }
                        else
                        {
                            emit_binary_op_cast(ops[0], ops[1], ops[2], ops[3], ">", type, Globals.opcode_is_sign_invariant(opcode), false);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFOrdGreaterThan):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], ">", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op(ops[0], ops[1], ops[2], ops[3], ">");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFUnordGreaterThan):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "<=", true, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            base.emit_instruction(instruction);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpUGreaterThanEqual):
                case unchecked((int)Spv.Op.OpSGreaterThanEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        var type = unchecked((int)opcode) == unchecked((int)Spv.Op.OpUGreaterThanEqual) ? uint_type : int_type;
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], ">=", false, type);
                        }
                        else
                        {
                            emit_binary_op_cast(ops[0], ops[1], ops[2], ops[3], ">=", type, Globals.opcode_is_sign_invariant(opcode), false);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFOrdGreaterThanEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], ">=", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op(ops[0], ops[1], ops[2], ops[3], ">=");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFUnordGreaterThanEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "<", true, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            base.emit_instruction(instruction);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpULessThan):
                case unchecked((int)Spv.Op.OpSLessThan):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        var type = unchecked((int)opcode) == unchecked((int)Spv.Op.OpULessThan) ? uint_type : int_type;
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "<", false, type);
                        }
                        else
                        {
                            emit_binary_op_cast(ops[0], ops[1], ops[2], ops[3], "<", type, Globals.opcode_is_sign_invariant(opcode), false);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFOrdLessThan):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "<", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op(ops[0], ops[1], ops[2], ops[3], "<");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFUnordLessThan):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], ">=", true, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            base.emit_instruction(instruction);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpULessThanEqual):
                case unchecked((int)Spv.Op.OpSLessThanEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        var type = unchecked((int)opcode) == unchecked((int)Spv.Op.OpULessThanEqual) ? uint_type : int_type;
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "<=", false, type);
                        }
                        else
                        {
                            emit_binary_op_cast(ops[0], ops[1], ops[2], ops[3], "<=", type, Globals.opcode_is_sign_invariant(opcode), false);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFOrdLessThanEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], "<=", false, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            emit_binary_op(ops[0], ops[1], ops[2], ops[3], "<=");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpFUnordLessThanEqual):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        if (expression_type(ops[2]).vecsize > 1u)
                        {
                            emit_unrolled_binary_op(result_type, id, ops[2], ops[3], ">", true, SPIRType.BaseType.Unknown);
                        }
                        else
                        {
                            base.emit_instruction(instruction);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpImageQueryLod):
                {
                    emit_texture_op(instruction, false);
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQuerySizeLod):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        require_texture_query_variant(ops[2]);
                        var dummy_samples_levels = Std.join(get_fallback_name(new TypedID_TypeNone(id)), "_dummy_parameter");
                        statement("uint ", dummy_samples_levels, ";");
                        var expr = Std.join("spvTextureSize(", to_non_uniform_aware_expression(ops[2]), ", ", bitcast_expression(SPIRType.BaseType.UInt, ops[3]), ", ", dummy_samples_levels, ")");
                        var restype = get__SPIRType(ops[0]);
                        expr = bitcast_expression(restype, SPIRType.BaseType.UInt, expr);
                        emit_op(result_type, id, expr, true, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpImageQuerySize):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        require_texture_query_variant(ops[2]);
                        bool uav = expression_type(ops[2]).image.sampled == 2u;
                        {
                            var @var = maybe_get_backing_variable(ops[2]);
                            if (@var != null)
                            {
                                if (hlsl_options.nonwritable_uav_texture_as_srv && has_decoration(@var.self, Spv.Decoration.DecorationNonWritable))
                                {
                                    uav = false;
                                }
                            }
                        }
                        var dummy_samples_levels = Std.join(get_fallback_name(new TypedID_TypeNone(id)), "_dummy_parameter");
                        statement("uint ", dummy_samples_levels, ";");
                        CppString expr = default(CppString);
                        if (uav)
                        {
                            expr = Std.join("spvImageSize(", to_non_uniform_aware_expression(ops[2]), ", ", dummy_samples_levels, ")");
                        }
                        else
                        {
                            expr = Std.join("spvTextureSize(", to_non_uniform_aware_expression(ops[2]), ", 0u, ", dummy_samples_levels, ")");
                        }
                        var restype = get__SPIRType(ops[0]);
                        expr = bitcast_expression(restype, SPIRType.BaseType.UInt, expr);
                        emit_op(result_type, id, expr, true, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpImageQuerySamples):
                case unchecked((int)Spv.Op.OpImageQueryLevels):
                {
                    {
                        var result_type = ops[0];
                        var id = ops[1];
                        require_texture_query_variant(ops[2]);
                        bool uav = expression_type(ops[2]).image.sampled == 2u;
                        if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpImageQueryLevels) && uav)
                        {
                            throw new CompilerError("Cannot query levels for UAV images.");
                        }
                        {
                            var @var = maybe_get_backing_variable(ops[2]);
                            if (@var != null)
                            {
                                if (hlsl_options.nonwritable_uav_texture_as_srv && has_decoration(@var.self, Spv.Decoration.DecorationNonWritable))
                                {
                                    uav = false;
                                }
                            }
                        }
                        forced_temporaries.insert(id);
                        var type = get__SPIRType(result_type);
                        statement(variable_decl(type, to_name(id, true), 0u), ";");
                        if (uav)
                        {
                            statement("spvImageSize(", to_non_uniform_aware_expression(ops[2]), ", ", to_name(id, true), ");");
                        }
                        else
                        {
                            statement("spvTextureSize(", to_non_uniform_aware_expression(ops[2]), ", 0u, ", to_name(id, true), ");");
                        }
                        var restype = get__SPIRType(ops[0]);
                        var expr = bitcast_expression(restype, SPIRType.BaseType.UInt, to_name(id, true));
                        set__SPIRExpression_X(id, expr, result_type, true);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpImageRead):
                {
                    {
                        uint result_type = ops[0];
                        uint id = ops[1];
                        var @var = maybe_get_backing_variable(ops[2]);
                        var type = expression_type(ops[2]);
                        bool subpass_data = unchecked((int)type.image.dim) == unchecked((int)Spv.Dim.DimSubpassData);
                        bool pure = false;
                        CppString imgexpr = default(CppString);
                        if (subpass_data)
                        {
                            if (hlsl_options.shader_model < 40u)
                            {
                                throw new CompilerError("Subpass loads are not supported in HLSL shader model 2/3.");
                            }
                            if (type.image.ms)
                            {
                                uint operands = ops[4];
                                if (operands != unchecked((uint)Spv.ImageOperandsMask.ImageOperandsSampleMask) || instruction.length != 6u)
                                {
                                    throw new CompilerError("Multisampled image used in OpImageRead, but unexpected operand mask was used.");
                                }
                                uint sample = ops[5];
                                imgexpr = Std.join(to_non_uniform_aware_expression(ops[2]), ".Load(int2(gl_FragCoord.xy), ", to_expression(sample, true), ")");
                            }
                            else
                            {
                                imgexpr = Std.join(to_non_uniform_aware_expression(ops[2]), ".Load(int3(int2(gl_FragCoord.xy), 0))");
                            }
                            pure = true;
                        }
                        else
                        {
                            imgexpr = Std.join(to_non_uniform_aware_expression(ops[2]), "[", to_expression(ops[3], true), "]");
                            bool force_srv = hlsl_options.nonwritable_uav_texture_as_srv && @var != null && has_decoration(@var.self, Spv.Decoration.DecorationNonWritable);
                            pure = force_srv;
                            if (@var != null && !subpass_data && !force_srv)
                            {
                                imgexpr = remap_swizzle(get__SPIRType(result_type), Globals.image_format_to_components(get__SPIRType(((uint)@var.basetype)).image.format), imgexpr);
                            }
                        }
                        if (@var != null)
                        {
                            bool forward = forced_temporaries.find(id) == Std.end(forced_temporaries);
                            var e = emit_op(result_type, id, imgexpr, forward, false);
                            if (!pure)
                            {
                                e.loaded_from = @var.self;
                                if (forward)
                                {
                                    @var.dependees.push_back(new TypedID_TypeNone(id));
                                }
                            }
                        }
                        else
                        {
                            emit_op(result_type, id, imgexpr, false, false);
                        }
                        inherit_expression_dependencies(id, ops[2]);
                        if (type.image.ms)
                        {
                            inherit_expression_dependencies(id, ops[5]);
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpImageWrite):
                {
                    {
                        var @var = maybe_get_backing_variable(ops[0]);
                        var value_expr = to_expression(ops[2], true);
                        if (@var != null)
                        {
                            var type = get__SPIRType(((uint)@var.basetype));
                            var narrowed_type = (get__SPIRType(((uint)type.image.type))).Clone();
                            narrowed_type.vecsize = Globals.image_format_to_components(type.image.format);
                            value_expr = remap_swizzle(narrowed_type, expression_type(ops[2]).vecsize, value_expr);
                        }
                        statement(to_non_uniform_aware_expression(ops[0]), "[", to_expression(ops[1], true), "] = ", value_expr, ";");
                        if (@var != null && variable_storage_is_aliased(@var))
                        {
                            flush_all_aliased_variables();
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpImageTexelPointer):
                {
                    {
                        uint result_type = ops[0];
                        uint id = ops[1];
                        var expr = to_expression(ops[2], true);
                        expr += Std.join("[", to_expression(ops[3], true), "]");
                        var e = set__SPIRExpression_X(id, expr, result_type, true);
                        var @var = maybe_get_backing_variable(ops[2]);
                        e.loaded_from = @var != null ? @var.self : new TypedID_TypeNone(0u);
                        inherit_expression_dependencies(id, ops[3]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpAtomicFAddEXT):
                case unchecked((int)Spv.Op.OpAtomicFMinEXT):
                case unchecked((int)Spv.Op.OpAtomicFMaxEXT):
                {
                    throw new CompilerError("Floating-point atomics are not supported in HLSL.");
                }
                case unchecked((int)Spv.Op.OpAtomicCompareExchange):
                case unchecked((int)Spv.Op.OpAtomicExchange):
                case unchecked((int)Spv.Op.OpAtomicISub):
                case unchecked((int)Spv.Op.OpAtomicSMin):
                case unchecked((int)Spv.Op.OpAtomicUMin):
                case unchecked((int)Spv.Op.OpAtomicSMax):
                case unchecked((int)Spv.Op.OpAtomicUMax):
                case unchecked((int)Spv.Op.OpAtomicAnd):
                case unchecked((int)Spv.Op.OpAtomicOr):
                case unchecked((int)Spv.Op.OpAtomicXor):
                case unchecked((int)Spv.Op.OpAtomicIAdd):
                case unchecked((int)Spv.Op.OpAtomicIIncrement):
                case unchecked((int)Spv.Op.OpAtomicIDecrement):
                case unchecked((int)Spv.Op.OpAtomicLoad):
                case unchecked((int)Spv.Op.OpAtomicStore):
                {
                    {
                        emit_atomic(ops, instruction.length, opcode);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpControlBarrier):
                case unchecked((int)Spv.Op.OpMemoryBarrier):
                {
                    {
                        uint memory = default;
                        uint semantics = default;
                        if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpMemoryBarrier))
                        {
                            memory = evaluate_constant_u32(ops[0]);
                            semantics = evaluate_constant_u32(ops[1]);
                        }
                        else
                        {
                            memory = evaluate_constant_u32(ops[1]);
                            semantics = evaluate_constant_u32(ops[2]);
                        }
                        if (memory == unchecked((uint)Spv.Scope.ScopeSubgroup))
                        {
                            break;
                        }
                        semantics = CompilerGLSL.mask_relevant_memory_semantics(semantics);
                        if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpMemoryBarrier))
                        {
                            Instruction next = get_next_instruction_in_block(instruction);
                            if (next != null && unchecked((int)next.op) == unchecked((int)Spv.Op.OpControlBarrier))
                            {
                                var next_ops = stream(next);
                                uint next_memory = evaluate_constant_u32(next_ops[1]);
                                uint next_semantics = evaluate_constant_u32(next_ops[2]);
                                next_semantics = CompilerGLSL.mask_relevant_memory_semantics(next_semantics);
                                if (next_semantics == 0u)
                                {
                                    next_semantics = unchecked((uint)Spv.MemorySemanticsMask.MemorySemanticsWorkgroupMemoryMask);
                                }
                                bool memory_scope_covered = false;
                                if (next_memory == memory)
                                {
                                    memory_scope_covered = true;
                                }
                                else
                                if (next_semantics == unchecked((uint)Spv.MemorySemanticsMask.MemorySemanticsWorkgroupMemoryMask))
                                {
                                    if ((next_memory == unchecked((uint)Spv.Scope.ScopeDevice) || next_memory == unchecked((uint)Spv.Scope.ScopeWorkgroup)) && (memory == unchecked((uint)Spv.Scope.ScopeDevice) || memory == unchecked((uint)Spv.Scope.ScopeWorkgroup)))
                                    {
                                        memory_scope_covered = true;
                                    }
                                }
                                else
                                if (memory == unchecked((uint)Spv.Scope.ScopeWorkgroup) && next_memory == unchecked((uint)Spv.Scope.ScopeDevice))
                                {
                                    memory_scope_covered = true;
                                }
                                if (memory_scope_covered && (semantics & next_semantics) == semantics)
                                {
                                    break;
                                }
                            }
                        }
                        if (semantics != 0u || unchecked((int)opcode) == unchecked((int)Spv.Op.OpControlBarrier))
                        {
                            flush_control_dependent_expressions(((uint)current_emitting_block.self));
                            flush_all_active_variables();
                        }
                        if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpControlBarrier))
                        {
                            if (semantics == unchecked((uint)Spv.MemorySemanticsMask.MemorySemanticsWorkgroupMemoryMask) || semantics == 0u)
                            {
                                statement("GroupMemoryBarrierWithGroupSync();");
                            }
                            else
                            if (semantics != 0u && (semantics & unchecked((uint)Spv.MemorySemanticsMask.MemorySemanticsWorkgroupMemoryMask)) == 0u)
                            {
                                statement("DeviceMemoryBarrierWithGroupSync();");
                            }
                            else
                            {
                                statement("AllMemoryBarrierWithGroupSync();");
                            }
                        }
                        else
                        {
                            if (semantics == unchecked((uint)Spv.MemorySemanticsMask.MemorySemanticsWorkgroupMemoryMask))
                            {
                                statement("GroupMemoryBarrier();");
                            }
                            else
                            if (semantics != 0u && (semantics & unchecked((uint)Spv.MemorySemanticsMask.MemorySemanticsWorkgroupMemoryMask)) == 0u)
                            {
                                statement("DeviceMemoryBarrier();");
                            }
                            else
                            {
                                statement("AllMemoryBarrier();");
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpBitFieldInsert):
                {
                    {
                        if (!requires_bitfield_insert)
                        {
                            requires_bitfield_insert = true;
                            force_recompile();
                        }
                        var expr = Std.join("spvBitfieldInsert(", to_expression(ops[2], true), ", ", to_expression(ops[3], true), ", ", to_expression(ops[4], true), ", ", to_expression(ops[5], true), ")");
                        bool forward = should_forward(ops[2]) && should_forward(ops[3]) && should_forward(ops[4]) && should_forward(ops[5]);
                        var restype = get__SPIRType(ops[0]);
                        expr = bitcast_expression(restype, SPIRType.BaseType.UInt, expr);
                        emit_op(ops[0], ops[1], expr, forward, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpBitFieldSExtract):
                case unchecked((int)Spv.Op.OpBitFieldUExtract):
                {
                    {
                        if (!requires_bitfield_extract)
                        {
                            requires_bitfield_extract = true;
                            force_recompile();
                        }
                        if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpBitFieldSExtract))
                        {
                            emit_trinary_func_op(ops[0], ops[1], ops[2], ops[3], ops[4], "spvBitfieldSExtract");
                        }
                        else
                        {
                            emit_trinary_func_op(ops[0], ops[1], ops[2], ops[3], ops[4], "spvBitfieldUExtract");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpBitCount):
                {
                    {
                        var basetype = expression_type(ops[2]).basetype;
                        emit_unary_func_op_cast(ops[0], ops[1], ops[2], "countbits", basetype, basetype);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpBitReverse):
                {
                    emit_unary_func_op(ops[0], ops[1], ops[2], "reversebits");
                    break;
                }
                case unchecked((int)Spv.Op.OpArrayLength):
                {
                    {
                        var @var = maybe_get_backing_variable(ops[2]);
                        if (!(@var != null))
                        {
                            throw new CompilerError("Array length must point directly to an SSBO block.");
                        }
                        var type = get__SPIRType(((uint)@var.basetype));
                        if (!has_decoration(type.self, Spv.Decoration.DecorationBlock) && !has_decoration(type.self, Spv.Decoration.DecorationBufferBlock))
                        {
                            throw new CompilerError("Array length expression must point to a block type.");
                        }
                        emit_uninitialized_temporary_expression(ops[0], ops[1]);
                        statement(to_non_uniform_aware_expression(ops[2]), ".GetDimensions(", to_expression(ops[1], true), ");");
                        uint offset = type_struct_member_offset(type, ops[3]);
                        uint stride = type_struct_member_array_stride(type, ops[3]);
                        statement(to_expression(ops[1], true), " = (", to_expression(ops[1], true), " - ", offset, ") / ", stride, ";");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpIsHelperInvocationEXT):
                {
                    if (hlsl_options.shader_model < 50u || unchecked((int)get_entry_point().model) != unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                    {
                        throw new CompilerError("Helper Invocation input is only supported in PS 5.0 or higher.");
                    }
                    emit_op(ops[0], ops[1], new CppString("IsHelperLane()"), false, false);
                    break;
                }
                case unchecked((int)Spv.Op.OpBeginInvocationInterlockEXT):
                case unchecked((int)Spv.Op.OpEndInvocationInterlockEXT):
                {
                    if (hlsl_options.shader_model < 51u)
                    {
                        throw new CompilerError("Rasterizer order views require Shader Model 5.1.");
                    }
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryInitializeKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        CppString ray_desc_name = get_unique_identifier();
                        statement("RayDesc ", ray_desc_name, " = {", to_expression(ops[4], true), ", ", to_expression(ops[5], true), ", ", to_expression(ops[6], true), ", ", to_expression(ops[7], true), "};");
                        statement(to_expression(ops[0], true), ".TraceRayInline(", to_expression(ops[1], true), ", ", to_expression(ops[2], true), ", ", to_expression(ops[3], true), ", ", ray_desc_name, ");");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryProceedKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        emit_op(ops[0], ops[1], Std.join(to_expression(ops[2], true), ".Proceed()"), false, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryTerminateKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        statement(to_expression(ops[0], true), ".Abort();");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGenerateIntersectionKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        statement(to_expression(ops[0], true), ".CommitProceduralPrimitiveHit(", to_expression(ops[1], true), ");");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryConfirmIntersectionKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        statement(to_expression(ops[0], true), ".CommitNonOpaqueTriangleHit();");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTypeKHR):
                {
                    {
                        emit_rayquery_function(".CommittedStatus()", ".CandidateType()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTKHR):
                {
                    {
                        emit_rayquery_function(".CommittedRayT()", ".CandidateTriangleRayT()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceCustomIndexKHR):
                {
                    {
                        emit_rayquery_function(".CommittedInstanceID()", ".CandidateInstanceID()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceIdKHR):
                {
                    {
                        emit_rayquery_function(".CommittedInstanceIndex()", ".CandidateInstanceIndex()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR):
                {
                    {
                        emit_rayquery_function(".CommittedInstanceContributionToHitGroupIndex()", ".CandidateInstanceContributionToHitGroupIndex()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionGeometryIndexKHR):
                {
                    {
                        emit_rayquery_function(".CommittedGeometryIndex()", ".CandidateGeometryIndex()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionPrimitiveIndexKHR):
                {
                    {
                        emit_rayquery_function(".CommittedPrimitiveIndex()", ".CandidatePrimitiveIndex()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionBarycentricsKHR):
                {
                    {
                        emit_rayquery_function(".CommittedTriangleBarycentrics()", ".CandidateTriangleBarycentrics()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionFrontFaceKHR):
                {
                    {
                        emit_rayquery_function(".CommittedTriangleFrontFace()", ".CandidateTriangleFrontFace()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        emit_op(ops[0], ops[1], Std.join(to_expression(ops[2], true), ".CandidateProceduralPrimitiveNonOpaque()"), false, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectRayDirectionKHR):
                {
                    {
                        emit_rayquery_function(".CommittedObjectRayDirection()", ".CandidateObjectRayDirection()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectRayOriginKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        emit_rayquery_function(".CommittedObjectRayOrigin()", ".CandidateObjectRayOrigin()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectToWorldKHR):
                {
                    {
                        emit_rayquery_function(".CommittedObjectToWorld4x3()", ".CandidateObjectToWorld4x3()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionWorldToObjectKHR):
                {
                    {
                        emit_rayquery_function(".CommittedWorldToObject4x3()", ".CandidateWorldToObject4x3()", ops);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetRayFlagsKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        emit_op(ops[0], ops[1], Std.join(to_expression(ops[2], true), ".RayFlags()"), false, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetRayTMinKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        emit_op(ops[0], ops[1], Std.join(to_expression(ops[2], true), ".RayTMin()"), false, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetWorldRayOriginKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        emit_op(ops[0], ops[1], Std.join(to_expression(ops[2], true), ".WorldRayOrigin()"), false, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpRayQueryGetWorldRayDirectionKHR):
                {
                    {
                        flush_variable_declaration(ops[0]);
                        emit_op(ops[0], ops[1], Std.join(to_expression(ops[2], true), ".WorldRayDirection()"), false, false);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSetMeshOutputsEXT):
                {
                    {
                        statement("SetMeshOutputCounts(", to_unpacked_expression(ops[0], true), ", ", to_unpacked_expression(ops[1], true), ");");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpEmitVertex):
                {
                    {
                        emit_geometry_stream_append();
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpEndPrimitive):
                {
                    {
                        statement("geometry_stream.RestartStrip();");
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpSDot):
                case unchecked((int)Spv.Op.OpUDot):
                case unchecked((int)Spv.Op.OpSUDot):
                case unchecked((int)Spv.Op.OpSDotAccSat):
                case unchecked((int)Spv.Op.OpUDotAccSat):
                case unchecked((int)Spv.Op.OpSUDotAccSat):
                {
                    {
                        uint result_type = ops[0];
                        uint id = ops[1];
                        bool is_acc_sat = unchecked((int)opcode) == unchecked((int)Spv.Op.OpSDotAccSat) || unchecked((int)opcode) == unchecked((int)Spv.Op.OpUDotAccSat) || unchecked((int)opcode) == unchecked((int)Spv.Op.OpSUDotAccSat);
                        if (length == unchecked((uint)(is_acc_sat ? 6 : 5)))
                        {
                            if (ops[length - 1u] != unchecked((uint)Spv.PackedVectorFormat.PackedVectorFormatPackedVectorFormat4x8Bit))
                            {
                                throw new CompilerError("Only 4x8bit packing is supported.");
                            }
                        }
                        if (hlsl_options.shader_model < 64u)
                        {
                            throw new CompilerError("Integer dot product requires SM 6.4.");
                        }
                        if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpSUDotAccSat) || unchecked((int)opcode) == unchecked((int)Spv.Op.OpSUDot))
                        {
                            throw new CompilerError("Mixed signed dot product not supported.");
                        }
                        if (expression_type(ops[2]).vecsize != 1u)
                        {
                            throw new CompilerError("HLSL dot products must be 4x8bit packed.");
                        }
                        if (integer_width != 32u)
                        {
                            throw new CompilerError("HLSL dot products must be 32-bit accumulator.");
                        }
                        string intrinsic = default;
                        if (unchecked((int)opcode) == unchecked((int)Spv.Op.OpSDot) || unchecked((int)opcode) == unchecked((int)Spv.Op.OpSDotAccSat))
                        {
                            intrinsic = "dot4add_i8packed";
                        }
                        else
                        {
                            intrinsic = "dot4add_u8packed";
                        }
                        var expr = Std.join(intrinsic, "(", to_expression(ops[2], true), ", ", to_expression(ops[3], true), ", ");
                        if (is_acc_sat)
                        {
                            expr += to_expression(ops[4], true) + " /* WARN: HLSL will not saturate */)";
                        }
                        else
                        {
                            expr += "0)";
                        }
                        if ((unchecked((int)opcode) == unchecked((int)Spv.Op.OpSDot) || unchecked((int)opcode) == unchecked((int)Spv.Op.OpSDotAccSat)) && unchecked((int)get__SPIRType(result_type).basetype) != unchecked((int)SPIRType.BaseType.Int) || (unchecked((int)opcode) == unchecked((int)Spv.Op.OpUDot) || unchecked((int)opcode) == unchecked((int)Spv.Op.OpUDotAccSat)) && unchecked((int)get__SPIRType(result_type).basetype) != unchecked((int)SPIRType.BaseType.UInt))
                        {
                            expr = Std.join(type_to_glsl(get__SPIRType(result_type), 0u), "(", expr, ")");
                        }
                        bool forward = should_forward(ops[2]) && should_forward(ops[3]);
                        if (is_acc_sat && forward)
                        {
                            forward = should_forward(ops[4]);
                        }
                        emit_op(result_type, id, expr, forward, false);
                        inherit_expression_dependencies(id, ops[2]);
                        inherit_expression_dependencies(id, ops[3]);
                        if (is_acc_sat)
                        {
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        break;
                    }
                }
                default:
                {
                    base.emit_instruction(instruction);
                    break;
                }
            }
        }
    }
    public override void emit_glsl_op(uint result_type, uint id, uint eop, Ptr<uint> args, uint count)
    {
        var op = unchecked((GLSLstd450)eop);
        uint integer_width = get_integer_width_for_glsl_instruction(op, args, count);
        var int_type = Globals.to_signed_basetype(integer_width);
        var uint_type = Globals.to_unsigned_basetype(integer_width);
        op = get_remapped_glsl_op(op);
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)GLSLstd450.GLSLstd450InverseSqrt):
                {
                    emit_unary_func_op(result_type, id, args[0], "rsqrt");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450Fract):
                {
                    emit_unary_func_op(result_type, id, args[0], "frac");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450RoundEven):
                {
                    if (hlsl_options.shader_model < 40u)
                    {
                        throw new CompilerError("roundEven is not supported in HLSL shader model 2/3.");
                    }
                    emit_unary_func_op(result_type, id, args[0], "round");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450Trunc):
                {
                    emit_unary_func_op(result_type, id, args[0], "trunc");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450Acosh):
                case unchecked((int)GLSLstd450.GLSLstd450Asinh):
                case unchecked((int)GLSLstd450.GLSLstd450Atanh):
                {
                    emit_emulated_ahyper_op(result_type, id, args[0], op);
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450FMix):
                case unchecked((int)GLSLstd450.GLSLstd450IMix):
                {
                    emit_trinary_func_op(result_type, id, args[0], args[1], args[2], "lerp");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450Atan2):
                {
                    emit_binary_func_op(result_type, id, args[0], args[1], "atan2");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450Fma):
                {
                    emit_trinary_func_op(result_type, id, args[0], args[1], args[2], "mad");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450InterpolateAtCentroid):
                {
                    emit_unary_func_op(result_type, id, args[0], "EvaluateAttributeAtCentroid");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450InterpolateAtSample):
                {
                    emit_binary_func_op(result_type, id, args[0], args[1], "EvaluateAttributeAtSample");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450InterpolateAtOffset):
                {
                    emit_binary_func_op(result_type, id, args[0], args[1], "EvaluateAttributeSnapped");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450PackHalf2x16):
                {
                    if (!requires_fp16_packing)
                    {
                        requires_fp16_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvPackHalf2x16");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450UnpackHalf2x16):
                {
                    if (!requires_fp16_packing)
                    {
                        requires_fp16_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvUnpackHalf2x16");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450PackSnorm4x8):
                {
                    if (!requires_snorm8_packing)
                    {
                        requires_snorm8_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvPackSnorm4x8");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450UnpackSnorm4x8):
                {
                    if (!requires_snorm8_packing)
                    {
                        requires_snorm8_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvUnpackSnorm4x8");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450PackUnorm4x8):
                {
                    if (!requires_unorm8_packing)
                    {
                        requires_unorm8_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvPackUnorm4x8");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450UnpackUnorm4x8):
                {
                    if (!requires_unorm8_packing)
                    {
                        requires_unorm8_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvUnpackUnorm4x8");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450PackSnorm2x16):
                {
                    if (!requires_snorm16_packing)
                    {
                        requires_snorm16_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvPackSnorm2x16");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450UnpackSnorm2x16):
                {
                    if (!requires_snorm16_packing)
                    {
                        requires_snorm16_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvUnpackSnorm2x16");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450PackUnorm2x16):
                {
                    if (!requires_unorm16_packing)
                    {
                        requires_unorm16_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvPackUnorm2x16");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450UnpackUnorm2x16):
                {
                    if (!requires_unorm16_packing)
                    {
                        requires_unorm16_packing = true;
                        force_recompile();
                    }
                    emit_unary_func_op(result_type, id, args[0], "spvUnpackUnorm2x16");
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450PackDouble2x32):
                case unchecked((int)GLSLstd450.GLSLstd450UnpackDouble2x32):
                {
                    throw new CompilerError("packDouble2x32/unpackDouble2x32 not supported in HLSL.");
                }
                case unchecked((int)GLSLstd450.GLSLstd450FindILsb):
                {
                    {
                        var basetype = expression_type(args[0]).basetype;
                        emit_unary_func_op_cast(result_type, id, args[0], "firstbitlow", basetype, basetype);
                        break;
                    }
                }
                case unchecked((int)GLSLstd450.GLSLstd450FindSMsb):
                {
                    emit_unary_func_op_cast(result_type, id, args[0], "firstbithigh", int_type, int_type);
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450FindUMsb):
                {
                    emit_unary_func_op_cast(result_type, id, args[0], "firstbithigh", uint_type, uint_type);
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450MatrixInverse):
                {
                    {
                        var type = get__SPIRType(result_type);
                        if (type.vecsize == 2u && type.columns == 2u)
                        {
                            if (!requires_inverse_2x2)
                            {
                                requires_inverse_2x2 = true;
                                force_recompile();
                            }
                        }
                        else
                        if (type.vecsize == 3u && type.columns == 3u)
                        {
                            if (!requires_inverse_3x3)
                            {
                                requires_inverse_3x3 = true;
                                force_recompile();
                            }
                        }
                        else
                        if (type.vecsize == 4u && type.columns == 4u)
                        {
                            if (!requires_inverse_4x4)
                            {
                                requires_inverse_4x4 = true;
                                force_recompile();
                            }
                        }
                        emit_unary_func_op(result_type, id, args[0], "spvInverse");
                        break;
                    }
                }
                case unchecked((int)GLSLstd450.GLSLstd450Normalize):
                {
                    if (expression_type(args[0]).vecsize == 1u)
                    {
                        emit_unary_func_op(result_type, id, args[0], "sign");
                    }
                    else
                    {
                        base.emit_glsl_op(result_type, id, eop, args, count);
                    }
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450Reflect):
                {
                    if (get__SPIRType(result_type).vecsize == 1u)
                    {
                        if (!requires_scalar_reflect)
                        {
                            requires_scalar_reflect = true;
                            force_recompile();
                        }
                        emit_binary_func_op(result_type, id, args[0], args[1], "spvReflect");
                    }
                    else
                    {
                        base.emit_glsl_op(result_type, id, eop, args, count);
                    }
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450Refract):
                {
                    if (get__SPIRType(result_type).vecsize == 1u)
                    {
                        if (!requires_scalar_refract)
                        {
                            requires_scalar_refract = true;
                            force_recompile();
                        }
                        emit_trinary_func_op(result_type, id, args[0], args[1], args[2], "spvRefract");
                    }
                    else
                    {
                        base.emit_glsl_op(result_type, id, eop, args, count);
                    }
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450FaceForward):
                {
                    if (get__SPIRType(result_type).vecsize == 1u)
                    {
                        if (!requires_scalar_faceforward)
                        {
                            requires_scalar_faceforward = true;
                            force_recompile();
                        }
                        emit_trinary_func_op(result_type, id, args[0], args[1], args[2], "spvFaceForward");
                    }
                    else
                    {
                        base.emit_glsl_op(result_type, id, eop, args, count);
                    }
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450NMin):
                {
                    base.emit_glsl_op(result_type, id, unchecked((uint)GLSLstd450.GLSLstd450FMin), args, count);
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450NMax):
                {
                    base.emit_glsl_op(result_type, id, unchecked((uint)GLSLstd450.GLSLstd450FMax), args, count);
                    break;
                }
                case unchecked((int)GLSLstd450.GLSLstd450NClamp):
                {
                    base.emit_glsl_op(result_type, id, unchecked((uint)GLSLstd450.GLSLstd450FClamp), args, count);
                    break;
                }
                default:
                {
                    base.emit_glsl_op(result_type, id, eop, args, count);
                    break;
                }
            }
        }
    }
    public override void emit_buffer_block(SPIRVariable @var)
    {
        var type = get__SPIRType(((uint)@var.basetype));
        bool is_uav = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || has_decoration(type.self, Spv.Decoration.DecorationBufferBlock);
        if (flattened_buffer_blocks.count(((uint)@var.self)) != 0UL)
        {
            emit_buffer_block_flattened(@var);
        }
        else
        if (is_uav)
        {
            Bitset flags = ir.get_buffer_block_flags(@var);
            bool is_readonly = flags.get(unchecked((uint)Spv.Decoration.DecorationNonWritable)) && !is_hlsl_force_storage_buffer_as_uav(@var.self);
            bool is_coherent = flags.get(unchecked((uint)Spv.Decoration.DecorationCoherent)) && !is_readonly;
            bool is_interlocked = interlocked_resources.count(((uint)@var.self)) > 0UL;
            var to_structuredbuffer_subtype_name = (SPIRType parent_type) =>
            {
                if (unchecked((int)parent_type.basetype) == unchecked((int)SPIRType.BaseType.Struct) && parent_type.member_types.size() == 1UL)
                {
                    var member0_type = this.get__SPIRType(((uint)parent_type.member_types.front()));
                    return this.type_to_glsl(member0_type, 0u);
                }
                else
                {
                    return this.type_to_glsl(parent_type, 0u);
                }
            };
            CppString type_name = default(CppString);
            if (is_user_type_structured(((uint)@var.self)))
            {
                type_name = Std.join(is_readonly ? "" : is_interlocked ? "RasterizerOrdered" : "RW", "StructuredBuffer<", to_structuredbuffer_subtype_name(type), ">");
            }
            else
            {
                type_name = is_readonly ? "ByteAddressBuffer" : is_interlocked ? "RasterizerOrderedByteAddressBuffer" : "RWByteAddressBuffer";
            }
            add_resource_name(((uint)@var.self));
            statement(is_coherent ? "globallycoherent " : "", type_name, " ", to_name(((uint)@var.self), true), type_to_array_glsl(type, ((uint)@var.self)), to_resource_binding(@var), ";");
        }
        else
        {
            if (type.array.empty())
            {
                flattened_structs[((uint)@var.self)] = false;
                var buffer_name = to_name(((uint)type.self), false);
                if (ir.meta[type.self].decoration.alias.empty() || resource_names.find(buffer_name) != Std.end(resource_names) || block_names.find(buffer_name) != Std.end(block_names))
                {
                    buffer_name = get_block_fallback_name(((TypedID_TypeVariable)@var.self));
                }
                add_variable(block_names, resource_names, ref buffer_name);
                if (buffer_name.empty())
                {
                    buffer_name = Std.join("_", (uint)get__SPIRType(((uint)@var.basetype)).self, "_", (uint)@var.self);
                }
                uint failed_index = 0u;
                if (buffer_is_packing_standard(type, BufferPackingStandard.BufferPackingHLSLCbufferPackOffset, Ptr.Ref<uint>(() => failed_index, __v => failed_index = __v), 0u, ~0u))
                {
                    set_extended_decoration(((uint)type.self), ExtendedDecorations.SPIRVCrossDecorationExplicitOffset, 0u);
                }
                else
                {
                    throw new CompilerError(Std.join("cbuffer ID ", (uint)@var.self, " (name: ", buffer_name, "), member index ", failed_index, " (name: ", to_member_name(type, failed_index), ") cannot be expressed with either HLSL packing layout or packoffset."));
                }
                block_names.insert(buffer_name);
                declared_block_names[((uint)@var.self)] = buffer_name;
                type.member_name_cache.clear();
                preserve_alias_on_reset(((uint)@var.self));
                add_resource_name(((uint)@var.self));
                statement("cbuffer ", buffer_name, to_resource_binding(@var));
                begin_scope();
                uint i = 0u;
                {
                    var __r0 = type.member_types;
                    for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
                    {
                        ref TypedID_TypeType member = ref __r0[__i1];
                        add_member_name(type, i);
                        var backup_name = get_member_name(((TypedID_TypeType)type.self), i);
                        var member_name = to_member_name(type, i);
                        member_name = Std.join(to_name(((uint)@var.self), true), "_", member_name);
                        ParsedIR.sanitize_underscores(ref member_name);
                        set_member_name(((TypedID_TypeType)type.self), i, member_name);
                        emit_struct_member(type, ((uint)member), i, new CppString(""), 0u);
                        set_member_name(((TypedID_TypeType)type.self), i, backup_name);
                        i++;
                    }
                }
                end_scope_decl();
                statement("");
            }
            else
            {
                if (hlsl_options.shader_model < 51u)
                {
                    throw new CompilerError("Need ConstantBuffer<T> to use arrays of UBOs, but this is only supported in SM 5.1.");
                }
                add_resource_name(((uint)type.self));
                add_resource_name(((uint)@var.self));
                uint failed_index = 0u;
                if (!buffer_is_packing_standard(type, BufferPackingStandard.BufferPackingHLSLCbuffer, Ptr.Ref<uint>(() => failed_index, __v => failed_index = __v), 0u, ~0u))
                {
                    throw new CompilerError(Std.join("HLSL ConstantBuffer<T> ID ", (uint)@var.self, " (name: ", to_name(((uint)type.self), true), "), member index ", failed_index, " (name: ", to_member_name(type, failed_index), ") cannot be expressed with normal HLSL packing rules."));
                }
                emit_struct(get__SPIRType(((uint)type.self)));
                statement("ConstantBuffer<", to_name(((uint)type.self), true), "> ", to_name(((uint)@var.self), true), type_to_array_glsl(type, ((uint)@var.self)), to_resource_binding(@var), ";");
            }
        }
    }
    public override void emit_push_constant_block(SPIRVariable @var)
    {
        if (flattened_buffer_blocks.count(((uint)@var.self)) != 0UL)
        {
            emit_buffer_block_flattened(@var);
        }
        else
        if (root_constants_layout.empty())
        {
            emit_buffer_block(@var);
        }
        else
        {
            {
                foreach (RootConstants layout in root_constants_layout)
                {
                    var type = get__SPIRType(((uint)@var.basetype));
                    uint failed_index = 0u;
                    if (buffer_is_packing_standard(type, BufferPackingStandard.BufferPackingHLSLCbufferPackOffset, Ptr.Ref<uint>(() => failed_index, __v => failed_index = __v), layout.start, layout.end))
                    {
                        set_extended_decoration(((uint)type.self), ExtendedDecorations.SPIRVCrossDecorationExplicitOffset, 0u);
                    }
                    else
                    {
                        throw new CompilerError(Std.join("Root constant cbuffer ID ", (uint)@var.self, " (name: ", to_name(((uint)type.self), true), ")", ", member index ", failed_index, " (name: ", to_member_name(type, failed_index), ") cannot be expressed with either HLSL packing layout or packoffset."));
                    }
                    flattened_structs[((uint)@var.self)] = false;
                    type.member_name_cache.clear();
                    add_resource_name(((uint)@var.self));
                    var memb = ir.meta[type.self].members;
                    statement("cbuffer SPIRV_CROSS_RootConstant_", to_name(((uint)@var.self), true), to_resource_register(HLSLBindingFlagBits.HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT, 'b', layout.binding, layout.space));
                    begin_scope();
                    var constant_index = 0u;
                    {
                        for (uint i = 0u; unchecked((ulong)i) < memb.size(); i++)
                        {
                            var offset = memb[unchecked((ulong)i)].offset;
                            if (layout.start <= offset && offset < layout.end)
                            {
                                var member = type.member_types[unchecked((ulong)i)];
                                add_member_name(type, constant_index);
                                var backup_name = get_member_name(((TypedID_TypeType)type.self), i);
                                var member_name = to_member_name(type, i);
                                member_name = Std.join(to_name(((uint)@var.self), true), "_", member_name);
                                ParsedIR.sanitize_underscores(ref member_name);
                                set_member_name(((TypedID_TypeType)type.self), constant_index, member_name);
                                emit_struct_member(type, ((uint)member), i, new CppString(""), layout.start);
                                set_member_name(((TypedID_TypeType)type.self), constant_index, backup_name);
                                constant_index++;
                            }
                        }
                    }
                    end_scope_decl();
                }
            }
        }
    }
    public override void emit_uniform(SPIRVariable @var)
    {
        add_resource_name(((uint)@var.self));
        if (hlsl_options.shader_model >= 40u)
        {
            emit_modern_uniform(@var);
        }
        else
        {
            emit_legacy_uniform(@var);
        }
    }
    public void emit_modern_uniform(SPIRVariable @var)
    {
        var type = get__SPIRType(((uint)@var.basetype));
        {
            switch (unchecked((int)type.basetype))
            {
                case unchecked((int)SPIRType.BaseType.SampledImage):
                case unchecked((int)SPIRType.BaseType.Image):
                {
                    {
                        bool is_coherent = false;
                        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 2u)
                        {
                            is_coherent = has_decoration(@var.self, Spv.Decoration.DecorationCoherent);
                        }
                        statement(is_coherent ? "globallycoherent " : "", image_type_hlsl_modern(type, ((uint)@var.self)), " ", to_name(((uint)@var.self), true), type_to_array_glsl(type, ((uint)@var.self)), to_resource_binding(@var), ";");
                        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.SampledImage) && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimBuffer))
                        {
                            if (is_depth_image(type, ((uint)@var.self)))
                            {
                                statement("SamplerComparisonState ", to_sampler_expression(((uint)@var.self)), type_to_array_glsl(type, ((uint)@var.self)), to_resource_binding_sampler(@var), ";");
                            }
                            else
                            {
                                statement("SamplerState ", to_sampler_expression(((uint)@var.self)), type_to_array_glsl(type, ((uint)@var.self)), to_resource_binding_sampler(@var), ";");
                            }
                        }
                        break;
                    }
                }
                case unchecked((int)SPIRType.BaseType.Sampler):
                {
                    if (comparison_ids.count(((uint)@var.self)) != 0UL)
                    {
                        statement("SamplerComparisonState ", to_name(((uint)@var.self), true), type_to_array_glsl(type, ((uint)@var.self)), to_resource_binding(@var), ";");
                    }
                    else
                    {
                        statement("SamplerState ", to_name(((uint)@var.self), true), type_to_array_glsl(type, ((uint)@var.self)), to_resource_binding(@var), ";");
                    }
                    break;
                }
                default:
                {
                    statement(variable_decl(@var), to_resource_binding(@var), ";");
                    break;
                }
            }
        }
    }
    public void emit_legacy_uniform(SPIRVariable @var)
    {
        var type = get__SPIRType(((uint)@var.basetype));
        {
            switch (unchecked((int)type.basetype))
            {
                case unchecked((int)SPIRType.BaseType.Sampler):
                case unchecked((int)SPIRType.BaseType.Image):
                {
                    throw new CompilerError("Separate image and samplers not supported in legacy HLSL.");
                }
                default:
                {
                    statement(variable_decl(@var), ";");
                    break;
                }
            }
        }
    }
    public void emit_specialization_constants_and_structs()
    {
        bool emitted = false;
        SpecializationConstant wg_x = new SpecializationConstant();
        SpecializationConstant wg_y = new SpecializationConstant();
        SpecializationConstant wg_z = new SpecializationConstant();
        TypedID_TypeNone workgroup_size_id = new TypedID_TypeNone(get_work_group_size_specialization_constants(wg_x, wg_y, wg_z));
        UnorderedSet<TypedID_TypeType> io_block_types = new UnorderedSet<TypedID_TypeType>();
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            if ((unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput)) && !@var.remapped_variable && type.pointer && !this.is_builtin_variable(@var) && this.interface_variable_exists_in_entry_point(((uint)@var.self)) && this.has_decoration(type.self, Spv.Decoration.DecorationBlock))
            {
                io_block_types.insert(((TypedID_TypeType)type.self));
            }
        });
        using var loop_lock = ir.create_loop_hard_lock();
        {
            var __r0 = ir.ids_for_constant_undef_or_type;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeNone id_ = ref __r0[__i1];
                ref var id = ref ir.ids[unchecked((ulong)((uint)id_))];
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeConstant))
                {
                    var c = id.get__SPIRConstant();
                    if (((uint)c.self) == ((uint)workgroup_size_id))
                    {
                        statement("static const uint3 gl_WorkGroupSize = ", constant_expression(get__SPIRConstant(((uint)workgroup_size_id)), false, false), ";");
                        emitted = true;
                    }
                    else
                    if (c.specialization)
                    {
                        var type = get__SPIRType(((uint)c.constant_type));
                        add_resource_name(((uint)c.self));
                        var name = to_name(((uint)c.self), true);
                        if (has_decoration(c.self, Spv.Decoration.DecorationSpecId))
                        {
                            c.specialization_constant_macro_name = constant_value_macro_name(get_decoration(c.self, Spv.Decoration.DecorationSpecId));
                            statement("#ifndef ", c.specialization_constant_macro_name);
                            statement("#define ", c.specialization_constant_macro_name, " ", constant_expression(c, false, false));
                            statement("#endif");
                            statement("static const ", variable_decl(type, name, 0u), " = ", c.specialization_constant_macro_name, ";");
                        }
                        else
                        {
                            statement("static const ", variable_decl(type, name, 0u), " = ", constant_expression(c, false, false), ";");
                        }
                        emitted = true;
                    }
                }
                else
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeConstantOp))
                {
                    var c = id.get__SPIRConstantOp();
                    var type = get__SPIRType(((uint)c.basetype));
                    add_resource_name(((uint)c.self));
                    var name = to_name(((uint)c.self), true);
                    statement("static const ", variable_decl(type, name, 0u), " = ", constant_op_expression(c), ";");
                    emitted = true;
                }
                else
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeType))
                {
                    var type = id.get__SPIRType();
                    bool is_non_io_block = has_decoration(type.self, Spv.Decoration.DecorationBlock) && io_block_types.count(((TypedID_TypeType)type.self)) == 0UL;
                    bool is_buffer_block = has_decoration(type.self, Spv.Decoration.DecorationBufferBlock);
                    if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct) && type.array.empty() && !type.pointer && !is_non_io_block && !is_buffer_block)
                    {
                        if (emitted)
                        {
                            statement("");
                        }
                        emitted = false;
                        emit_struct(type);
                    }
                }
                else
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeUndef))
                {
                    var undef = id.get__SPIRUndef();
                    var type = this.get__SPIRType(((uint)undef.basetype));
                    if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Void) || type_is_top_level_block(type))
                    {
                        return;
                    }
                    CppString initializer = default(CppString);
                    if (options.force_zero_initialized_variables && type_can_zero_initialize(type))
                    {
                        initializer = Std.join(" = ", to_zero_initialized_expression(((uint)undef.basetype)));
                    }
                    statement("static ", variable_decl(type, to_name(((uint)undef.self), true), ((uint)undef.self)), initializer, ";");
                    emitted = true;
                }
            }
        }
        if (emitted)
        {
            statement("");
        }
    }
    public void emit_composite_constants()
    {
        bool emitted = false;
        ir.for_each_typed_id__SPIRConstant_lambda((uint _p, SPIRConstant c) =>
        {
            if (c.specialization)
            {
                return;
            }
            var type = this.get__SPIRType(((uint)c.constant_type));
            if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct) && this.is_builtin_type(type))
            {
                return;
            }
            if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct) || !type.array.empty())
            {
                this.add_resource_name(((uint)c.self));
                var name = this.to_name(((uint)c.self), true);
                statement("static const ", this.variable_decl(type, name, 0u), " = ", this.constant_expression(c, false, false), ";");
                emitted = true;
            }
        });
        if (emitted)
        {
            statement("");
        }
    }
    public override void emit_fixup()
    {
        if (is_vertex_like_shader() && active_output_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInPosition)))
        {
            if (hlsl_options.shader_model <= 30u)
            {
                statement("gl_Position.x = gl_Position.x - gl_HalfPixel.x * gl_Position.w;");
                statement("gl_Position.y = gl_Position.y + gl_HalfPixel.y * gl_Position.w;");
            }
            if (options.vertex.flip_vert_y)
            {
                statement("gl_Position.y = -gl_Position.y;");
            }
            if (options.vertex.fixup_clipspace)
            {
                statement("gl_Position.z = (gl_Position.z + gl_Position.w) * 0.5;");
            }
        }
    }
    public override CppString builtin_to_glsl(Spv.BuiltIn builtin, Spv.StorageClass storage)
    {
        {
            switch (unchecked((int)builtin))
            {
                case unchecked((int)Spv.BuiltIn.BuiltInPosition):
                {
                    return new CppString(unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassInput) ? "gl_PositionIn" : "gl_Position");
                }
                case unchecked((int)Spv.BuiltIn.BuiltInVertexId):
                {
                    return new CppString("gl_VertexID");
                }
                case unchecked((int)Spv.BuiltIn.BuiltInInstanceId):
                {
                    return new CppString("gl_InstanceID");
                }
                case unchecked((int)Spv.BuiltIn.BuiltInNumWorkgroups):
                {
                    {
                        if (!(num_workgroups_builtin != 0u))
                        {
                            throw new CompilerError("NumWorkgroups builtin is used, but remap_num_workgroups_builtin() was not called. Cannot emit code for this builtin.");
                        }
                        var @var = get__SPIRVariable(num_workgroups_builtin);
                        var type = get__SPIRType(((uint)@var.basetype));
                        var ret = Std.join(to_name(num_workgroups_builtin, true), "_", get_member_name(((TypedID_TypeType)type.self), 0u));
                        ParsedIR.sanitize_underscores(ref ret);
                        return ret;
                    }
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPointCoord):
                {
                    return new CppString("float2(0.5f, 0.5f)");
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLocalInvocationId):
                {
                    return new CppString("WaveGetLaneIndex()");
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupSize):
                {
                    return new CppString("WaveGetLaneCount()");
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHelperInvocation):
                {
                    return new CppString("IsHelperLane()");
                }
                default:
                {
                    return base.builtin_to_glsl(builtin, storage);
                }
            }
        }
    }
    public override CppString layout_for_member(SPIRType type, uint index)
    {
        var flags = get_member_decoration_bitset(((TypedID_TypeType)type.self), index);
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationColMajor)))
        {
            return new CppString("row_major ");
        }
        else
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationRowMajor)))
        {
            return new CppString("column_major ");
        }
        return new CppString("");
    }
    public override CppString to_interpolation_qualifiers(Bitset flags)
    {
        CppString res = default(CppString);
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationFlat)) || flags.get(unchecked((uint)Spv.Decoration.DecorationPerVertexKHR)))
        {
            res += "nointerpolation ";
        }
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationNoPerspective)))
        {
            res += "noperspective ";
        }
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationCentroid)))
        {
            res += "centroid ";
        }
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationPatch)))
        {
            res += "patch ";
        }
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationSample)))
        {
            res += "sample ";
        }
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationInvariant)) && backend.support_precise_qualifier)
        {
            res += "precise ";
        }
        return res;
    }
    public override CppString bitcast_glsl_op(SPIRType out_type, SPIRType in_type)
    {
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.UInt) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Int))
        {
            return type_to_glsl(out_type, 0u);
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.UInt64) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Int64))
        {
            return type_to_glsl(out_type, 0u);
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.UInt) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Float))
        {
            return new CppString("asuint");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Int) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.UInt))
        {
            return type_to_glsl(out_type, 0u);
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Int64) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.UInt64))
        {
            return type_to_glsl(out_type, 0u);
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Int) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Float))
        {
            return new CppString("asint");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Float) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.UInt))
        {
            return new CppString("asfloat");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Float) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Int))
        {
            return new CppString("asfloat");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Int64) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Double))
        {
            throw new CompilerError("Double to Int64 is not supported in HLSL.");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.UInt64) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Double))
        {
            throw new CompilerError("Double to UInt64 is not supported in HLSL.");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Double) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Int64))
        {
            return new CppString("asdouble");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Double) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.UInt64))
        {
            return new CppString("asdouble");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Half) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.UInt) && in_type.vecsize == 1u)
        {
            if (!requires_explicit_fp16_packing)
            {
                requires_explicit_fp16_packing = true;
                force_recompile();
            }
            return new CppString("spvUnpackFloat2x16");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.UInt) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Half) && in_type.vecsize == 2u)
        {
            if (!requires_explicit_fp16_packing)
            {
                requires_explicit_fp16_packing = true;
                force_recompile();
            }
            return new CppString("spvPackFloat2x16");
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.UShort) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.Half))
        {
            if (hlsl_options.shader_model < 40u)
            {
                throw new CompilerError("Half to UShort requires Shader Model 4.");
            }
            return "(" + type_to_glsl(out_type, 0u) + ")f32tof16";
        }
        else
        if (unchecked((int)out_type.basetype) == unchecked((int)SPIRType.BaseType.Half) && unchecked((int)in_type.basetype) == unchecked((int)SPIRType.BaseType.UShort))
        {
            if (hlsl_options.shader_model < 40u)
            {
                throw new CompilerError("UShort to Half requires Shader Model 4.");
            }
            return "(" + type_to_glsl(out_type, 0u) + ")f16tof32";
        }
        else
        {
            return new CppString("");
        }
    }
    public override bool emit_complex_bitcast(uint _p0, uint _p1, uint _p2)
    {
        return false;
    }
    public override void append_global_func_args(SPIRFunction func, uint index, CppVector<CppString> arglist)
    {
        base.append_global_func_args(func, index, arglist);
        if (func.emits_geometry)
        {
            arglist.push_back(new CppString("geometry_stream"));
        }
    }
    public override CppString to_func_call_arg(SPIRFunction.Parameter arg, uint id)
    {
        CppString arg_str = base.to_func_call_arg(arg, id);
        if (hlsl_options.shader_model <= 30u)
        {
            return arg_str;
        }
        var type = expression_type(id);
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.SampledImage) && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimBuffer))
        {
            arg_str += ", " + to_sampler_expression(id);
        }
        return arg_str;
    }
    public CppString to_sampler_expression(uint id)
    {
        var expr = Std.join("_", to_non_uniform_aware_expression(id));
        var index = expr.find_first_of('[', 0UL);
        if (index == CppString.npos)
        {
            return expr + "_sampler";
        }
        else
        {
            return expr.insert(index, "_sampler");
        }
    }
    public CppString to_resource_binding(SPIRVariable @var)
    {
        var type = get__SPIRType(((uint)@var.basetype));
        if (unchecked((int)type.storage) != unchecked((int)Spv.StorageClass.StorageClassPushConstant) && !has_decoration(@var.self, Spv.Decoration.DecorationBinding))
        {
            return new CppString("");
        }
        char space = '\0';
        HLSLBindingFlagBits resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_NONE_BIT;
        {
            switch (unchecked((int)type.basetype))
            {
                case unchecked((int)SPIRType.BaseType.SampledImage):
                {
                    space = 't';
                    resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT;
                    break;
                }
                case unchecked((int)SPIRType.BaseType.Image):
                {
                    if (type.image.sampled == 2u && unchecked((int)type.image.dim) != unchecked((int)Spv.Dim.DimSubpassData))
                    {
                        if (has_decoration(@var.self, Spv.Decoration.DecorationNonWritable) && hlsl_options.nonwritable_uav_texture_as_srv)
                        {
                            space = 't';
                            resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT;
                        }
                        else
                        {
                            space = 'u';
                            resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_UAV_BIT;
                        }
                    }
                    else
                    {
                        space = 't';
                        resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT;
                    }
                    break;
                }
                case unchecked((int)SPIRType.BaseType.Sampler):
                {
                    space = 's';
                    resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_SAMPLER_BIT;
                    break;
                }
                case unchecked((int)SPIRType.BaseType.AccelerationStructure):
                {
                    space = 't';
                    resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT;
                    break;
                }
                case unchecked((int)SPIRType.BaseType.Struct):
                {
                    {
                        var storage = type.storage;
                        if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassUniform))
                        {
                            if (has_decoration(type.self, Spv.Decoration.DecorationBufferBlock))
                            {
                                Bitset flags = ir.get_buffer_block_flags(@var);
                                bool is_readonly = flags.get(unchecked((uint)Spv.Decoration.DecorationNonWritable)) && !is_hlsl_force_storage_buffer_as_uav(@var.self);
                                space = is_readonly ? 't' : 'u';
                                resource_flags = is_readonly ? HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT : HLSLBindingFlagBits.HLSL_BINDING_AUTO_UAV_BIT;
                            }
                            else
                            if (has_decoration(type.self, Spv.Decoration.DecorationBlock))
                            {
                                space = 'b';
                                resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_CBV_BIT;
                            }
                        }
                        else
                        if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant))
                        {
                            space = 'b';
                            resource_flags = HLSLBindingFlagBits.HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT;
                        }
                        else
                        if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer))
                        {
                            Bitset flags = ir.get_buffer_block_flags(@var);
                            bool is_readonly = flags.get(unchecked((uint)Spv.Decoration.DecorationNonWritable)) && !is_hlsl_force_storage_buffer_as_uav(@var.self);
                            space = is_readonly ? 't' : 'u';
                            resource_flags = is_readonly ? HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT : HLSLBindingFlagBits.HLSL_BINDING_AUTO_UAV_BIT;
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
        if (!(space != '\0'))
        {
            return new CppString("");
        }
        uint desc_set = unchecked((int)resource_flags) == unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT) ? Globals.ResourceBindingPushConstantDescriptorSet : 0u;
        uint binding = unchecked((int)resource_flags) == unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT) ? Globals.ResourceBindingPushConstantBinding : 0u;
        if (has_decoration(@var.self, Spv.Decoration.DecorationBinding))
        {
            binding = get_decoration(@var.self, Spv.Decoration.DecorationBinding);
        }
        if (has_decoration(@var.self, Spv.Decoration.DecorationDescriptorSet))
        {
            desc_set = get_decoration(@var.self, Spv.Decoration.DecorationDescriptorSet);
        }
        return to_resource_register(resource_flags, space, binding, desc_set);
    }
    public CppString to_resource_binding_sampler(SPIRVariable @var)
    {
        if (!has_decoration(@var.self, Spv.Decoration.DecorationBinding))
        {
            return new CppString("");
        }
        return to_resource_register(HLSLBindingFlagBits.HLSL_BINDING_AUTO_SAMPLER_BIT, 's', get_decoration(@var.self, Spv.Decoration.DecorationBinding), get_decoration(@var.self, Spv.Decoration.DecorationDescriptorSet));
    }
    public CppString to_resource_register(HLSLBindingFlagBits flag, char space, uint binding, uint space_set)
    {
        if ((unchecked((uint)flag) & resource_binding_flags) == 0u)
        {
            remap_hlsl_resource_binding(flag, ref space_set, ref binding);
            if (unchecked((int)flag) == unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT) && space_set == Globals.ResourceBindingPushConstantDescriptorSet)
            {
                return new CppString("");
            }
            if (hlsl_options.shader_model >= 51u)
            {
                return Std.join(" : register(", space, binding, ", space", space_set, ")");
            }
            else
            {
                return Std.join(" : register(", space, binding, ")");
            }
        }
        else
        {
            return new CppString("");
        }
    }
    public override CppString to_initializer_expression(SPIRVariable @var)
    {
        var type = get__SPIRType(((uint)@var.basetype));
        bool is_block = has_decoration(type.self, Spv.Decoration.DecorationBlock);
        var c = maybe_get__SPIRConstant(((uint)@var.initializer));
        if (is_block && c != null)
        {
            return constant_expression(c, false, false);
        }
        else
        {
            return base.to_initializer_expression(@var);
        }
    }
    public override void emit_sampled_image_op(uint result_type, uint result_id, uint image_id, uint samp_id)
    {
        if (hlsl_options.shader_model >= 40u && combined_image_samplers.empty())
        {
            set__SPIRCombinedImageSampler_X(result_id, result_type, image_id, samp_id);
        }
        else
        {
            emit_op(result_type, result_id, to_combined_image_sampler(new TypedID_TypeVariable(image_id), new TypedID_TypeVariable(samp_id)), true, true);
        }
    }
    public void emit_access_chain(Instruction instruction)
    {
        var ops = stream(instruction);
        uint length = instruction.length;
        bool need_byte_access_chain = false;
        var type = expression_type(ops[2]);
        var chain = maybe_get__SPIRAccessChain(ops[2]);
        if (chain != null)
        {
            need_byte_access_chain = true;
        }
        else
        if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || has_decoration(type.self, Spv.Decoration.DecorationBufferBlock))
        {
            uint chain_arguments = length - 3u;
            if (unchecked((ulong)chain_arguments) > type.array.size())
            {
                need_byte_access_chain = true;
            }
        }
        if (need_byte_access_chain)
        {
            uint to_plain_buffer_length = chain != null ? 0u : unchecked((uint)type.array.size());
            var backing_variable = maybe_get_backing_variable(ops[2]);
            if (backing_variable != null && is_user_type_structured(((uint)backing_variable.self)))
            {
                base.emit_instruction(instruction);
                return;
            }
            CppString @base = default(CppString);
            if (to_plain_buffer_length != 0u)
            {
                @base = access_chain(ops[2], ops + 3, to_plain_buffer_length, get__SPIRType(ops[0]), null, false, null);
            }
            else
            if (chain != null)
            {
                @base = chain.@base;
            }
            else
            {
                @base = to_expression(ops[2], true);
            }
            var basetype = get_pointee_type(type);
            {
                for (uint i = 0u; i < to_plain_buffer_length; i++)
                {
                    basetype = get__SPIRType(((uint)basetype.parent_type));
                }
            }
            uint matrix_stride = 0u;
            uint array_stride = 0u;
            bool row_major_matrix = false;
            if (chain != null)
            {
                matrix_stride = chain.matrix_stride;
                row_major_matrix = chain.row_major_matrix;
                array_stride = chain.array_stride;
            }
            var offsets = flattened_access_chain_offset(basetype, ops + (3u + to_plain_buffer_length), length - 3u - to_plain_buffer_length, 0u, 1u, Ptr.Ref<bool>(() => row_major_matrix, __v => row_major_matrix = __v), Ptr.Ref<uint>(() => matrix_stride, __v => matrix_stride = __v), Ptr.Ref<uint>(() => array_stride, __v => array_stride = __v), false);
            var e = set__SPIRAccessChain_X(ops[1], ops[0], type.storage, @base, offsets.first, offsets.second);
            e.row_major_matrix = row_major_matrix;
            e.matrix_stride = matrix_stride;
            e.array_stride = array_stride;
            e.immutable = should_forward(ops[2]);
            e.loaded_from = ((TypedID_TypeVariable)(backing_variable != null ? backing_variable.self : new TypedID_TypeNone(0u)));
            if (chain != null)
            {
                e.dynamic_index += chain.dynamic_index;
                e.static_index += chain.static_index;
            }
            {
                for (uint i = 2u; i < length; i++)
                {
                    inherit_expression_dependencies(ops[1], ops[i]);
                    add_implied_read_expression(e, ops[i]);
                }
            }
        }
        else
        {
            base.emit_instruction(instruction);
        }
    }
    public void emit_load(Instruction instruction)
    {
        var ops = stream(instruction);
        uint result_type = ops[0];
        uint id = ops[1];
        uint ptr = ops[2];
        var chain = maybe_get__SPIRAccessChain(ptr);
        if (chain != null)
        {
            var type = get__SPIRType(result_type);
            bool composite_load = !type.array.empty() || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct);
            if (composite_load)
            {
                emit_uninitialized_temporary_expression(result_type, id);
                read_access_chain(null, to_expression(id, true), chain);
                track_expression_read(((uint)chain.self));
            }
            else
            {
                CppString load_expr = default(CppString);
                read_access_chain(Ptr.Ref<CppString>(() => load_expr, __v => load_expr = __v), new CppString(""), chain);
                bool forward = should_forward(ptr) && forced_temporaries.find(id) == Std.end(forced_temporaries);
                if (!forward)
                {
                    track_expression_read(((uint)chain.self));
                }
                if (type.columns > 1u)
                {
                    forward = false;
                }
                var e = emit_op(result_type, id, load_expr, forward, true);
                e.need_transpose = false;
                register_read(id, ptr, forward);
                inherit_expression_dependencies(id, ptr);
                if (forward)
                {
                    add_implied_read_expression(e, ((uint)chain.self));
                }
            }
        }
        else
        {
            var res_type = get__SPIRType(result_type);
            if (unchecked((int)get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT) && has_decoration(new TypedID_TypeNone(ptr), Spv.Decoration.DecorationBuiltIn) && (get_decoration(new TypedID_TypeNone(ptr), Spv.Decoration.DecorationBuiltIn) == unchecked((uint)Spv.BuiltIn.BuiltInClipDistance) || get_decoration(new TypedID_TypeNone(ptr), Spv.Decoration.DecorationBuiltIn) == unchecked((uint)Spv.BuiltIn.BuiltInCullDistance)) && is_array(res_type) && !is_array(get__SPIRType(((uint)res_type.parent_type))) && to_array_size_literal(res_type) > 1u)
            {
                track_expression_read(ptr);
                CppString load_expr = new CppString("{ ");
                uint num_elements = to_array_size_literal(res_type);
                {
                    for (uint i = 0u; i < num_elements; i++)
                    {
                        load_expr += Std.join(to_expression(ptr, true), ".", index_to_swizzle(i));
                        if (i + 1u < num_elements)
                        {
                            load_expr += ", ";
                        }
                    }
                }
                load_expr += " }";
                emit_op(result_type, id, load_expr, false, false);
                register_read(id, ptr, false);
                inherit_expression_dependencies(id, ptr);
            }
            else
            {
                base.emit_instruction(instruction);
            }
        }
    }
    public void read_access_chain(Ptr<CppString> expr, CppString lhs, SPIRAccessChain chain)
    {
        var type = get__SPIRType(((uint)chain.basetype));
        SPIRType target_type = new SPIRType(is_scalar(type) ? Spv.Op.OpTypeInt : type.op);
        target_type.basetype = SPIRType.BaseType.UInt;
        target_type.vecsize = type.vecsize;
        target_type.columns = type.columns;
        if (!type.array.empty())
        {
            read_access_chain_array(lhs, chain);
            return;
        }
        else
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
        {
            read_access_chain_struct(lhs, chain);
            return;
        }
        else
        if (type.width != 32u && !hlsl_options.enable_16bit_types)
        {
            throw new CompilerError("Reading types other than 32-bit from ByteAddressBuffer not yet supported, unless SM 6.2 and native 16-bit types are enabled.");
        }
        CppString @base = chain.@base;
        if (has_decoration(chain.self, Spv.Decoration.DecorationNonUniform))
        {
            convert_non_uniform_expression(ref @base, ((uint)chain.self));
        }
        bool templated_load = hlsl_options.shader_model >= 62u;
        CppString load_expr = default(CppString);
        CppString template_expr = default(CppString);
        if (templated_load)
        {
            template_expr = Std.join("<", type_to_glsl(type, 0u), ">");
        }
        if (type.columns == 1u && !chain.row_major_matrix)
        {
            string load_op = null;
            {
                switch (type.vecsize)
                {
                    case 1u:
                    {
                        load_op = "Load";
                        break;
                    }
                    case 2u:
                    {
                        load_op = "Load2";
                        break;
                    }
                    case 3u:
                    {
                        load_op = "Load3";
                        break;
                    }
                    case 4u:
                    {
                        load_op = "Load4";
                        break;
                    }
                    default:
                    {
                        throw new CompilerError("Unknown vector size.");
                    }
                }
            }
            if (templated_load)
            {
                load_op = "Load";
            }
            load_expr = Std.join(@base, ".", load_op, template_expr, "(", chain.dynamic_index, chain.static_index, ")");
        }
        else
        if (type.columns == 1u)
        {
            if (templated_load)
            {
                var scalar_type = type.Clone();
                scalar_type.vecsize = 1u;
                scalar_type.columns = 1u;
                template_expr = Std.join("<", type_to_glsl(scalar_type, 0u), ">");
                if (type.vecsize > 1u)
                {
                    load_expr += type_to_glsl(type, 0u) + "(";
                }
            }
            else
            if (type.vecsize > 1u)
            {
                load_expr = type_to_glsl(target_type, 0u);
                load_expr += "(";
            }
            {
                for (uint r = 0u; r < type.vecsize; r++)
                {
                    load_expr += Std.join(@base, ".Load", template_expr, "(", chain.dynamic_index, unchecked((uint)chain.static_index) + r * chain.matrix_stride, ")");
                    if (r + 1u < type.vecsize)
                    {
                        load_expr += ", ";
                    }
                }
            }
            if (type.vecsize > 1u)
            {
                load_expr += ")";
            }
        }
        else
        if (!chain.row_major_matrix)
        {
            string load_op = null;
            {
                switch (type.vecsize)
                {
                    case 1u:
                    {
                        load_op = "Load";
                        break;
                    }
                    case 2u:
                    {
                        load_op = "Load2";
                        break;
                    }
                    case 3u:
                    {
                        load_op = "Load3";
                        break;
                    }
                    case 4u:
                    {
                        load_op = "Load4";
                        break;
                    }
                    default:
                    {
                        throw new CompilerError("Unknown vector size.");
                    }
                }
            }
            if (templated_load)
            {
                var vector_type = type.Clone();
                vector_type.columns = 1u;
                template_expr = Std.join("<", type_to_glsl(vector_type, 0u), ">");
                load_expr = type_to_glsl(type, 0u);
                load_op = "Load";
            }
            else
            {
                load_expr = type_to_glsl(target_type, 0u);
            }
            load_expr += "(";
            {
                for (uint c = 0u; c < type.columns; c++)
                {
                    load_expr += Std.join(@base, ".", load_op, template_expr, "(", chain.dynamic_index, unchecked((uint)chain.static_index) + c * chain.matrix_stride, ")");
                    if (c + 1u < type.columns)
                    {
                        load_expr += ", ";
                    }
                }
            }
            load_expr += ")";
        }
        else
        {
            if (templated_load)
            {
                load_expr = type_to_glsl(type, 0u);
                var scalar_type = type.Clone();
                scalar_type.vecsize = 1u;
                scalar_type.columns = 1u;
                template_expr = Std.join("<", type_to_glsl(scalar_type, 0u), ">");
            }
            else
            {
                load_expr = type_to_glsl(target_type, 0u);
            }
            load_expr += "(";
            {
                for (uint c = 0u; c < type.columns; c++)
                {
                    {
                        for (uint r = 0u; r < type.vecsize; r++)
                        {
                            load_expr += Std.join(@base, ".Load", template_expr, "(", chain.dynamic_index, unchecked((uint)chain.static_index) + c * (type.width / 8u) + r * chain.matrix_stride, ")");
                            if (r + 1u < type.vecsize || c + 1u < type.columns)
                            {
                                load_expr += ", ";
                            }
                        }
                    }
                }
            }
            load_expr += ")";
        }
        if (!templated_load)
        {
            var bitcast_op = bitcast_glsl_op(type, target_type);
            if (!bitcast_op.empty())
            {
                load_expr = Std.join(bitcast_op, "(", load_expr, ")");
            }
        }
        if (lhs.empty())
        {
            expr.Value = load_expr;
        }
        else
        {
            statement(lhs, " = ", load_expr, ";");
        }
    }
    public void read_access_chain_struct(CppString lhs, SPIRAccessChain chain)
    {
        var type = get__SPIRType(((uint)chain.basetype));
        var subchain = chain.Clone();
        uint member_count = unchecked((uint)type.member_types.size());
        {
            for (uint i = 0u; i < member_count; i++)
            {
                uint offset = type_struct_member_offset(type, i);
                subchain.static_index = unchecked((int)(unchecked((uint)chain.static_index) + offset));
                subchain.basetype = type.member_types[unchecked((ulong)i)];
                subchain.matrix_stride = 0u;
                subchain.array_stride = 0u;
                subchain.row_major_matrix = false;
                var member_type = get__SPIRType(((uint)subchain.basetype));
                if (member_type.columns > 1u)
                {
                    subchain.matrix_stride = type_struct_member_matrix_stride(type, i);
                    subchain.row_major_matrix = has_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationRowMajor);
                }
                if (!member_type.array.empty())
                {
                    subchain.array_stride = type_struct_member_array_stride(type, i);
                }
                read_access_chain(null, Std.join(lhs, ".", to_member_name(type, i)), subchain);
            }
        }
    }
    public void read_access_chain_array(CppString lhs, SPIRAccessChain chain)
    {
        var type = get__SPIRType(((uint)chain.basetype));
        var ident = get_unique_identifier();
        statement("[unroll]");
        statement("for (int ", ident, " = 0; ", ident, " < ", to_array_size(type, unchecked((uint)(type.array.size() - 1UL))), "; ", ident, "++)");
        begin_scope();
        var subchain = chain.Clone();
        subchain.dynamic_index = Std.join(ident, " * ", chain.array_stride, " + ", chain.dynamic_index);
        subchain.basetype = type.parent_type;
        if (!get__SPIRType(((uint)subchain.basetype)).array.empty())
        {
            subchain.array_stride = get_decoration(new TypedID_TypeNone(subchain.basetype), Spv.Decoration.DecorationArrayStride);
        }
        read_access_chain(null, Std.join(lhs, "[", ident, "]"), subchain);
        end_scope();
    }
    public void write_access_chain(SPIRAccessChain chain, uint value, CppVector<uint> composite_chain)
    {
        var type = get__SPIRType(((uint)chain.basetype));
        track_expression_read(((uint)chain.self));
        SPIRType target_type = new SPIRType(is_scalar(type) ? Spv.Op.OpTypeInt : type.op);
        target_type.basetype = SPIRType.BaseType.UInt;
        target_type.vecsize = type.vecsize;
        target_type.columns = type.columns;
        if (!type.array.empty())
        {
            write_access_chain_array(chain, value, composite_chain);
            register_write(((uint)chain.self));
            return;
        }
        else
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
        {
            write_access_chain_struct(chain, value, composite_chain);
            register_write(((uint)chain.self));
            return;
        }
        else
        if (type.width != 32u && !hlsl_options.enable_16bit_types)
        {
            throw new CompilerError("Writing types other than 32-bit to RWByteAddressBuffer not yet supported, unless SM 6.2 and native 16-bit types are enabled.");
        }
        bool templated_store = hlsl_options.shader_model >= 62u;
        var @base = chain.@base;
        if (has_decoration(chain.self, Spv.Decoration.DecorationNonUniform))
        {
            convert_non_uniform_expression(ref @base, ((uint)chain.self));
        }
        CppString template_expr = default(CppString);
        if (templated_store)
        {
            template_expr = Std.join("<", type_to_glsl(type, 0u), ">");
        }
        if (type.columns == 1u && !chain.row_major_matrix)
        {
            string store_op = null;
            {
                switch (type.vecsize)
                {
                    case 1u:
                    {
                        store_op = "Store";
                        break;
                    }
                    case 2u:
                    {
                        store_op = "Store2";
                        break;
                    }
                    case 3u:
                    {
                        store_op = "Store3";
                        break;
                    }
                    case 4u:
                    {
                        store_op = "Store4";
                        break;
                    }
                    default:
                    {
                        throw new CompilerError("Unknown vector size.");
                    }
                }
            }
            var store_expr = write_access_chain_value(value, composite_chain, false);
            if (!templated_store)
            {
                var bitcast_op = bitcast_glsl_op(target_type, type);
                if (!bitcast_op.empty())
                {
                    store_expr = Std.join(bitcast_op, "(", store_expr, ")");
                }
            }
            else
            {
                store_op = "Store";
            }
            statement(@base, ".", store_op, template_expr, "(", chain.dynamic_index, chain.static_index, ", ", store_expr, ");");
        }
        else
        if (type.columns == 1u)
        {
            if (templated_store)
            {
                var scalar_type = type.Clone();
                scalar_type.vecsize = 1u;
                scalar_type.columns = 1u;
                template_expr = Std.join("<", type_to_glsl(scalar_type, 0u), ">");
            }
            {
                for (uint r = 0u; r < type.vecsize; r++)
                {
                    var store_expr = write_access_chain_value(value, composite_chain, true);
                    if (type.vecsize > 1u)
                    {
                        store_expr += ".";
                        store_expr += index_to_swizzle(r);
                    }
                    remove_duplicate_swizzle(ref store_expr);
                    if (!templated_store)
                    {
                        var bitcast_op = bitcast_glsl_op(target_type, type);
                        if (!bitcast_op.empty())
                        {
                            store_expr = Std.join(bitcast_op, "(", store_expr, ")");
                        }
                    }
                    statement(@base, ".Store", template_expr, "(", chain.dynamic_index, unchecked((uint)chain.static_index) + chain.matrix_stride * r, ", ", store_expr, ");");
                }
            }
        }
        else
        if (!chain.row_major_matrix)
        {
            string store_op = null;
            {
                switch (type.vecsize)
                {
                    case 1u:
                    {
                        store_op = "Store";
                        break;
                    }
                    case 2u:
                    {
                        store_op = "Store2";
                        break;
                    }
                    case 3u:
                    {
                        store_op = "Store3";
                        break;
                    }
                    case 4u:
                    {
                        store_op = "Store4";
                        break;
                    }
                    default:
                    {
                        throw new CompilerError("Unknown vector size.");
                    }
                }
            }
            if (templated_store)
            {
                store_op = "Store";
                var vector_type = type.Clone();
                vector_type.columns = 1u;
                template_expr = Std.join("<", type_to_glsl(vector_type, 0u), ">");
            }
            {
                for (uint c = 0u; c < type.columns; c++)
                {
                    var store_expr = Std.join(write_access_chain_value(value, composite_chain, true), "[", c, "]");
                    if (!templated_store)
                    {
                        var bitcast_op = bitcast_glsl_op(target_type, type);
                        if (!bitcast_op.empty())
                        {
                            store_expr = Std.join(bitcast_op, "(", store_expr, ")");
                        }
                    }
                    statement(@base, ".", store_op, template_expr, "(", chain.dynamic_index, unchecked((uint)chain.static_index) + c * chain.matrix_stride, ", ", store_expr, ");");
                }
            }
        }
        else
        {
            if (templated_store)
            {
                var scalar_type = type.Clone();
                scalar_type.vecsize = 1u;
                scalar_type.columns = 1u;
                template_expr = Std.join("<", type_to_glsl(scalar_type, 0u), ">");
            }
            {
                for (uint r = 0u; r < type.vecsize; r++)
                {
                    {
                        for (uint c = 0u; c < type.columns; c++)
                        {
                            var store_expr = Std.join(write_access_chain_value(value, composite_chain, true), "[", c, "].", index_to_swizzle(r));
                            remove_duplicate_swizzle(ref store_expr);
                            var bitcast_op = bitcast_glsl_op(target_type, type);
                            if (!bitcast_op.empty())
                            {
                                store_expr = Std.join(bitcast_op, "(", store_expr, ")");
                            }
                            statement(@base, ".Store", template_expr, "(", chain.dynamic_index, unchecked((uint)chain.static_index) + c * (type.width / 8u) + r * chain.matrix_stride, ", ", store_expr, ");");
                        }
                    }
                }
            }
        }
        register_write(((uint)chain.self));
    }
    public void write_access_chain_struct(SPIRAccessChain chain, uint value, CppVector<uint> composite_chain)
    {
        var type = get__SPIRType(((uint)chain.basetype));
        uint member_count = unchecked((uint)type.member_types.size());
        var subchain = chain.Clone();
        var subcomposite_chain = composite_chain.Clone();
        subcomposite_chain.push_back(0u);
        {
            for (uint i = 0u; i < member_count; i++)
            {
                uint offset = type_struct_member_offset(type, i);
                subchain.static_index = unchecked((int)(unchecked((uint)chain.static_index) + offset));
                subchain.basetype = type.member_types[unchecked((ulong)i)];
                subchain.matrix_stride = 0u;
                subchain.array_stride = 0u;
                subchain.row_major_matrix = false;
                var member_type = get__SPIRType(((uint)subchain.basetype));
                if (member_type.columns > 1u)
                {
                    subchain.matrix_stride = type_struct_member_matrix_stride(type, i);
                    subchain.row_major_matrix = has_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationRowMajor);
                }
                if (!member_type.array.empty())
                {
                    subchain.array_stride = type_struct_member_array_stride(type, i);
                }
                subcomposite_chain.back() = i;
                write_access_chain(subchain, value, subcomposite_chain);
            }
        }
    }
    public void write_access_chain_array(SPIRAccessChain chain, uint value, CppVector<uint> composite_chain)
    {
        var ptype = get__SPIRType(((uint)chain.basetype));
        while (ptype.pointer)
        {
            ptype = get__SPIRType(unchecked((uint)ptype.basetype));
        }
        var type = ptype;
        var ident = get_unique_identifier();
        uint id = ir.increase_bound_by(2u);
        uint int_type_id = id + 1u;
        SPIRType int_type = new SPIRType(Spv.Op.OpTypeInt);
        int_type.basetype = SPIRType.BaseType.Int;
        int_type.width = 32u;
        set__SPIRType_X(int_type_id, int_type);
        set__SPIRExpression_X(id, ident, int_type_id, true);
        set_name(new TypedID_TypeNone(id), ident);
        suppressed_usage_tracking.insert(id);
        statement("[unroll]");
        statement("for (int ", ident, " = 0; ", ident, " < ", to_array_size(type, unchecked((uint)(type.array.size() - 1UL))), "; ", ident, "++)");
        begin_scope();
        var subchain = chain.Clone();
        subchain.dynamic_index = Std.join(ident, " * ", chain.array_stride, " + ", chain.dynamic_index);
        subchain.basetype = type.parent_type;
        var subcomposite_chain = composite_chain.Clone();
        subcomposite_chain.push_back(2147483648u | id);
        if (!get__SPIRType(((uint)subchain.basetype)).array.empty())
        {
            subchain.array_stride = get_decoration(new TypedID_TypeNone(subchain.basetype), Spv.Decoration.DecorationArrayStride);
        }
        write_access_chain(subchain, value, subcomposite_chain);
        end_scope();
    }
    public CppString write_access_chain_value(uint value, CppVector<uint> composite_chain, bool enclose)
    {
        CppString ret = default(CppString);
        if (composite_chain.empty())
        {
            ret = to_expression(value, true);
        }
        else
        {
            AccessChainMeta meta = new AccessChainMeta();
            ret = access_chain_internal(value, composite_chain.data(), unchecked((uint)composite_chain.size()), unchecked((uint)(unchecked((int)AccessChainFlagBits.ACCESS_CHAIN_INDEX_IS_LITERAL_BIT) | unchecked((int)AccessChainFlagBits.ACCESS_CHAIN_LITERAL_MSB_FORCE_ID))), meta, null);
        }
        if (enclose)
        {
            ret = enclose_expression(ret);
        }
        return ret;
    }
    public void emit_store(Instruction instruction)
    {
        var ops = stream(instruction);
        if (options.vertex.flip_vert_y)
        {
            var expr = maybe_get__SPIRExpression(ops[0]);
            if (expr != null && expr.access_meshlet_position_y)
            {
                var lhs = to_dereferenced_expression(ops[0], true);
                var rhs = to_unpacked_expression(ops[1], true);
                statement(lhs, " = spvFlipVertY(", rhs, ");");
                register_write(ops[0]);
                return;
            }
        }
        var chain = maybe_get__SPIRAccessChain(ops[0]);
        if (chain != null)
        {
            write_access_chain(chain, ops[1], new CppVector<uint>());
        }
        else
        {
            base.emit_instruction(instruction);
        }
    }
    public void emit_atomic(Ptr<uint> ops, uint length, Spv.Op op)
    {
        string atomic_op = null;
        CppString value_expr = default(CppString);
        if (unchecked((int)op) != unchecked((int)Spv.Op.OpAtomicIDecrement) && unchecked((int)op) != unchecked((int)Spv.Op.OpAtomicIIncrement) && unchecked((int)op) != unchecked((int)Spv.Op.OpAtomicLoad) && unchecked((int)op) != unchecked((int)Spv.Op.OpAtomicStore))
        {
            value_expr = to_expression(ops[unchecked((int)op) == unchecked((int)Spv.Op.OpAtomicCompareExchange) ? 6 : 5], true);
        }
        bool is_atomic_store = false;
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpAtomicIIncrement):
                {
                    atomic_op = "InterlockedAdd";
                    value_expr = "1";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicIDecrement):
                {
                    atomic_op = "InterlockedAdd";
                    value_expr = "-1";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicLoad):
                {
                    atomic_op = "InterlockedAdd";
                    value_expr = "0";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicISub):
                {
                    atomic_op = "InterlockedAdd";
                    value_expr = Std.join("-", enclose_expression(value_expr));
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicSMin):
                case unchecked((int)Spv.Op.OpAtomicUMin):
                {
                    atomic_op = "InterlockedMin";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicSMax):
                case unchecked((int)Spv.Op.OpAtomicUMax):
                {
                    atomic_op = "InterlockedMax";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicAnd):
                {
                    atomic_op = "InterlockedAnd";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicOr):
                {
                    atomic_op = "InterlockedOr";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicXor):
                {
                    atomic_op = "InterlockedXor";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicIAdd):
                {
                    atomic_op = "InterlockedAdd";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicExchange):
                {
                    atomic_op = "InterlockedExchange";
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicStore):
                {
                    atomic_op = "InterlockedExchange";
                    is_atomic_store = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicCompareExchange):
                {
                    if (length < 8u)
                    {
                        throw new CompilerError("Not enough data for opcode.");
                    }
                    atomic_op = "InterlockedCompareExchange";
                    value_expr = Std.join(to_expression(ops[7], true), ", ", value_expr);
                    break;
                }
                default:
                {
                    throw new CompilerError("Unknown atomic opcode.");
                }
            }
        }
        if (is_atomic_store)
        {
            var data_type = expression_type(ops[0]);
            var chain = maybe_get__SPIRAccessChain(ops[0]);
            ref var tmp_id = ref extra_sub_expressions[ops[0]];
            if (!(tmp_id != 0u))
            {
                tmp_id = ir.increase_bound_by(1u);
                emit_uninitialized_temporary_expression(((uint)get_pointee_type(data_type).self), tmp_id);
            }
            if (unchecked((int)data_type.storage) == unchecked((int)Spv.StorageClass.StorageClassImage) || !(chain != null))
            {
                statement(atomic_op, "(", to_non_uniform_aware_expression(ops[0]), ", ", to_expression(ops[3], true), ", ", to_expression(tmp_id, true), ");");
            }
            else
            {
                CppString @base = chain.@base;
                if (has_decoration(chain.self, Spv.Decoration.DecorationNonUniform))
                {
                    convert_non_uniform_expression(ref @base, ((uint)chain.self));
                }
                statement(@base, ".", atomic_op, "(", chain.dynamic_index, chain.static_index, ", ", to_expression(ops[3], true), ", ", to_expression(tmp_id, true), ");");
            }
        }
        else
        {
            uint result_type = ops[0];
            uint id = ops[1];
            forced_temporaries.insert(ops[1]);
            var type = get__SPIRType(result_type);
            statement(variable_decl(type, to_name(id, true), 0u), ";");
            var data_type = expression_type(ops[2]);
            var chain = maybe_get__SPIRAccessChain(ops[2]);
            SPIRType.BaseType expr_type = default;
            if (unchecked((int)data_type.storage) == unchecked((int)Spv.StorageClass.StorageClassImage) || !(chain != null))
            {
                statement(atomic_op, "(", to_non_uniform_aware_expression(ops[2]), ", ", value_expr, ", ", to_name(id, true), ");");
                expr_type = data_type.basetype;
            }
            else
            {
                CppString @base = chain.@base;
                if (has_decoration(chain.self, Spv.Decoration.DecorationNonUniform))
                {
                    convert_non_uniform_expression(ref @base, ((uint)chain.self));
                }
                expr_type = SPIRType.BaseType.UInt;
                statement(@base, ".", atomic_op, "(", chain.dynamic_index, chain.static_index, ", ", value_expr, ", ", to_name(id, true), ");");
            }
            var expr = bitcast_expression(type, expr_type, to_name(id, true));
            set__SPIRExpression_X(id, expr, result_type, true);
        }
        flush_all_atomic_capable_variables();
    }
    public override void emit_subgroup_op(Instruction i)
    {
        if (hlsl_options.shader_model < 60u)
        {
            throw new CompilerError("Wave ops requires SM 6.0 or higher.");
        }
        Ptr<uint> ops = stream(i);
        var op = unchecked((Spv.Op)i.op);
        uint result_type = ops[0];
        uint id = ops[1];
        var scope = unchecked((Spv.Scope)evaluate_constant_u32(ops[2]));
        if (unchecked((int)scope) != unchecked((int)Spv.Scope.ScopeSubgroup))
        {
            throw new CompilerError("Only subgroup scope is supported.");
        }
        var make_inclusive_Sum = (CppString expr) =>
        {
            return Std.join(expr, " + ", this.to_expression(ops[4], true));
        };
        var make_inclusive_Product = (CppString expr) =>
        {
            return Std.join(expr, " * ", this.to_expression(ops[4], true));
        };
        uint integer_width = get_integer_width_for_instruction(i);
        var int_type = Globals.to_signed_basetype(integer_width);
        var uint_type = Globals.to_unsigned_basetype(integer_width);
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpGroupNonUniformElect):
                {
                    emit_op(result_type, id, new CppString("WaveIsFirstLane()"), true, false);
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBroadcast):
                {
                    emit_binary_func_op(result_type, id, ops[3], ops[4], "WaveReadLaneAt");
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBroadcastFirst):
                {
                    emit_unary_func_op(result_type, id, ops[3], "WaveReadLaneFirst");
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallot):
                {
                    emit_unary_func_op(result_type, id, ops[3], "WaveActiveBallot");
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformInverseBallot):
                {
                    throw new CompilerError("Cannot trivially implement InverseBallot in HLSL.");
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitExtract):
                {
                    throw new CompilerError("Cannot trivially implement BallotBitExtract in HLSL.");
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindLSB):
                {
                    throw new CompilerError("Cannot trivially implement BallotFindLSB in HLSL.");
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindMSB):
                {
                    throw new CompilerError("Cannot trivially implement BallotFindMSB in HLSL.");
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitCount):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        bool forward = should_forward(ops[4]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            var left = Std.join("countbits(", to_enclosed_expression(ops[4], true), ".x) + countbits(", to_enclosed_expression(ops[4], true), ".y)");
                            var right = Std.join("countbits(", to_enclosed_expression(ops[4], true), ".z) + countbits(", to_enclosed_expression(ops[4], true), ".w)");
                            emit_op(result_type, id, Std.join(left, " + ", right), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan))
                        {
                            var left = Std.join("countbits(", to_enclosed_expression(ops[4], true), ".x & gl_SubgroupLeMask.x) + countbits(", to_enclosed_expression(ops[4], true), ".y & gl_SubgroupLeMask.y)");
                            var right = Std.join("countbits(", to_enclosed_expression(ops[4], true), ".z & gl_SubgroupLeMask.z) + countbits(", to_enclosed_expression(ops[4], true), ".w & gl_SubgroupLeMask.w)");
                            emit_op(result_type, id, Std.join(left, " + ", right), forward, false);
                            if (!active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupLeMask)))
                            {
                                active_input_builtins.set(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupLeMask));
                                force_recompile_guarantee_forward_progress();
                            }
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan))
                        {
                            var left = Std.join("countbits(", to_enclosed_expression(ops[4], true), ".x & gl_SubgroupLtMask.x) + countbits(", to_enclosed_expression(ops[4], true), ".y & gl_SubgroupLtMask.y)");
                            var right = Std.join("countbits(", to_enclosed_expression(ops[4], true), ".z & gl_SubgroupLtMask.z) + countbits(", to_enclosed_expression(ops[4], true), ".w & gl_SubgroupLtMask.w)");
                            emit_op(result_type, id, Std.join(left, " + ", right), forward, false);
                            if (!active_input_builtins.get(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupLtMask)))
                            {
                                active_input_builtins.set(unchecked((uint)Spv.BuiltIn.BuiltInSubgroupLtMask));
                                force_recompile_guarantee_forward_progress();
                            }
                        }
                        else
                        {
                            throw new CompilerError("Invalid BitCount operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffle):
                {
                    emit_binary_func_op(result_type, id, ops[3], ops[4], "WaveReadLaneAt");
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleXor):
                {
                    {
                        bool forward = should_forward(ops[3]);
                        emit_op(ops[0], ops[1], Std.join("WaveReadLaneAt(", to_unpacked_expression(ops[3], true), ", ", "WaveGetLaneIndex() ^ ", to_enclosed_expression(ops[4], true), ")"), forward, false);
                        inherit_expression_dependencies(ops[1], ops[3]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleUp):
                {
                    {
                        bool forward = should_forward(ops[3]);
                        emit_op(ops[0], ops[1], Std.join("WaveReadLaneAt(", to_unpacked_expression(ops[3], true), ", ", "WaveGetLaneIndex() - ", to_enclosed_expression(ops[4], true), ")"), forward, false);
                        inherit_expression_dependencies(ops[1], ops[3]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleDown):
                {
                    {
                        bool forward = should_forward(ops[3]);
                        emit_op(ops[0], ops[1], Std.join("WaveReadLaneAt(", to_unpacked_expression(ops[3], true), ", ", "WaveGetLaneIndex() + ", to_enclosed_expression(ops[4], true), ")"), forward, false);
                        inherit_expression_dependencies(ops[1], ops[3]);
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAll):
                {
                    emit_unary_func_op(result_type, id, ops[3], "WaveActiveAllTrue");
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAny):
                {
                    emit_unary_func_op(result_type, id, ops[3], "WaveActiveAnyTrue");
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAllEqual):
                {
                    emit_unary_func_op(result_type, id, ops[3], "WaveActiveAllEqual");
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFAdd):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveSum");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && true)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, make_inclusive_Sum(Std.join("WavePrefixSum", "(", to_expression(ops[4], true), ")")), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && true)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixSum");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMul):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveProduct");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && true)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, make_inclusive_Product(Std.join("WavePrefixProduct", "(", to_expression(ops[4], true), ")")), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && true)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixProduct");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMin):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveMin");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && false)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, new CppString(""), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && false)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixMin");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMax):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveMax");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && false)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, new CppString(""), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && false)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixMax");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformIAdd):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveSum");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && true)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, make_inclusive_Sum(Std.join("WavePrefixSum", "(", to_expression(ops[4], true), ")")), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && true)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixSum");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformIMul):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveProduct");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && true)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, make_inclusive_Product(Std.join("WavePrefixProduct", "(", to_expression(ops[4], true), ")")), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && true)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixProduct");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformSMin):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op_cast(result_type, id, ops[4], "WaveActiveMin", int_type, int_type);
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformSMax):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op_cast(result_type, id, ops[4], "WaveActiveMax", int_type, int_type);
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformUMin):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op_cast(result_type, id, ops[4], "WaveActiveMin", uint_type, uint_type);
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformUMax):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op_cast(result_type, id, ops[4], "WaveActiveMax", uint_type, uint_type);
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseAnd):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveBitAnd");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && false)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, new CppString(""), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && false)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixBitAnd");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseOr):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveBitOr");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && false)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, new CppString(""), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && false)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixBitOr");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseXor):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WaveActiveBitXor");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan) && false)
                        {
                            bool forward = should_forward(ops[4]);
                            emit_op(result_type, id, new CppString(""), forward, false);
                            inherit_expression_dependencies(id, ops[4]);
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan) && false)
                        {
                            emit_unary_func_op(result_type, id, ops[4], "WavePrefixBitXor");
                        }
                        else
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce))
                        {
                            throw new CompilerError("Cannot trivially implement ClusteredReduce in HLSL.");
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalAnd):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op_cast(result_type, id, ops[4], "WaveActiveBitAnd", uint_type, uint_type);
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalOr):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op_cast(result_type, id, ops[4], "WaveActiveBitOr", uint_type, uint_type);
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalXor):
                {
                    {
                        var operation = unchecked((Spv.GroupOperation)ops[3]);
                        if (unchecked((int)operation) == unchecked((int)Spv.GroupOperation.GroupOperationReduce))
                        {
                            emit_unary_func_op_cast(result_type, id, ops[4], "WaveActiveBitXor", uint_type, uint_type);
                        }
                        else
                        {
                            throw new CompilerError("Invalid group operation.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadSwap):
                {
                    {
                        uint direction = evaluate_constant_u32(ops[4]);
                        if (direction == 0u)
                        {
                            emit_unary_func_op(result_type, id, ops[3], "QuadReadAcrossX");
                        }
                        else
                        if (direction == 1u)
                        {
                            emit_unary_func_op(result_type, id, ops[3], "QuadReadAcrossY");
                        }
                        else
                        if (direction == 2u)
                        {
                            emit_unary_func_op(result_type, id, ops[3], "QuadReadAcrossDiagonal");
                        }
                        else
                        {
                            throw new CompilerError("Invalid quad swap direction.");
                        }
                        break;
                    }
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadBroadcast):
                {
                    {
                        emit_binary_func_op(result_type, id, ops[3], ops[4], "QuadReadLaneAt");
                        break;
                    }
                }
                default:
                {
                    throw new CompilerError("Invalid opcode for subgroup.");
                }
            }
        }
        register_control_dependent_expression(id);
    }
    public override void emit_block_hints(SPIRBlock block)
    {
        {
            switch (unchecked((int)block.hint))
            {
                case unchecked((int)SPIRBlock.Hints.HintFlatten):
                {
                    statement("[flatten]");
                    break;
                }
                case unchecked((int)SPIRBlock.Hints.HintDontFlatten):
                {
                    statement("[branch]");
                    break;
                }
                case unchecked((int)SPIRBlock.Hints.HintUnroll):
                {
                    statement("[unroll]");
                    break;
                }
                case unchecked((int)SPIRBlock.Hints.HintDontUnroll):
                {
                    statement("[loop]");
                    break;
                }
                default:
                {
                    break;
                }
            }
        }
    }
    private static string[] packing_swizzle_static30 = new string[] { "", ".y", ".z", ".w" };
    public override void emit_struct_member(SPIRType type, uint member_type_id, uint index, CppString qualifier, uint base_offset = 0u)
    {
        var membertype = get__SPIRType(member_type_id);
        Bitset memberflags = new Bitset();
        var memb = ir.meta[type.self].members;
        if (unchecked((ulong)index) < memb.size())
        {
            memberflags.CopyFrom(memb[unchecked((ulong)index)].decoration_flags);
        }
        CppString packing_offset = default(CppString);
        bool is_push_constant = unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant);
        if ((has_extended_decoration(((uint)type.self), ExtendedDecorations.SPIRVCrossDecorationExplicitOffset) || is_push_constant) && has_member_decoration(((TypedID_TypeType)type.self), index, Spv.Decoration.DecorationOffset))
        {
            uint offset = memb[unchecked((ulong)index)].offset - base_offset;
            if ((offset & 3u) != 0u)
            {
                throw new CompilerError("Cannot pack on tighter bounds than 4 bytes in HLSL.");
            }
            packing_offset = Std.join(" : packoffset(c", offset / 16u, packing_swizzle_static30[(offset & 15u) >> 2], ")");
        }
        statement(layout_for_member(type, index), qualifier, variable_decl(membertype, to_member_name(type, index), 0u), packing_offset, ";");
    }
    public void emit_rayquery_function(string commited, string candidate, Ptr<uint> ops)
    {
        flush_variable_declaration(ops[0]);
        uint is_commited = evaluate_constant_u32(ops[3]);
        emit_op(ops[0], ops[1], Std.join(to_expression(ops[2], true), is_commited != 0u ? commited : candidate), false, false);
    }
    public override void emit_mesh_tasks(SPIRBlock block)
    {
        if (((uint)block.mesh.payload) != 0u)
        {
            statement("DispatchMesh(", to_unpacked_expression(((uint)block.mesh.groups[0]), true), ", ", to_unpacked_expression(((uint)block.mesh.groups[1]), true), ", ", to_unpacked_expression(((uint)block.mesh.groups[2]), true), ", ", to_unpacked_expression(((uint)block.mesh.payload), true), ");");
        }
        else
        {
            throw new CompilerError("Amplification shader in HLSL must have payload");
        }
    }
    public void emit_geometry_stream_append()
    {
        begin_scope();
        statement("SPIRV_Cross_Output stage_output;");
        active_output_builtins.for_each_bit__lambda((uint i) =>
        {
            if (i == unchecked((uint)Spv.BuiltIn.BuiltInPointSize) && this.hlsl_options.shader_model > 30u)
            {
                return;
            }
            {
                switch (unchecked((int)unchecked((Spv.BuiltIn)i)))
                {
                    case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                    {
                        {
                            for (uint clip = 0u; clip < this.clip_distance_count; clip++)
                            {
                                statement("stage_output.gl_ClipDistance", clip / 4u, ".", "xyzw"[(int)(clip & 3u)], " = gl_ClipDistance[", clip, "];");
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                    {
                        {
                            for (uint cull = 0u; cull < this.cull_distance_count; cull++)
                            {
                                statement("stage_output.gl_CullDistance", cull / 4u, ".", "xyzw"[(int)(cull & 3u)], " = gl_CullDistance[", cull, "];");
                            }
                        }
                        break;
                    }
                    case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                    {
                        statement("stage_output.gl_SampleMask = gl_SampleMask[0];");
                        break;
                    }
                    default:
                    {
                        {
                            var builtin_expr = this.builtin_to_glsl(unchecked((Spv.BuiltIn)i), Spv.StorageClass.StorageClassOutput);
                            statement("stage_output.", builtin_expr, " = ", builtin_expr, ";");
                        }
                        break;
                    }
                }
            }
        });
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            bool block = this.has_decoration(type.self, Spv.Decoration.DecorationBlock);
            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassOutput))
            {
                return;
            }
            if (!@var.remapped_variable && type.pointer && !this.is_builtin_variable(@var) && this.interface_variable_exists_in_entry_point(((uint)@var.self)))
            {
                if (block)
                {
                    var type_name = this.to_name(((uint)type.self), true);
                    var var_name = this.to_name(((uint)@var.self), true);
                    {
                        for (uint mbr_idx = 0u; mbr_idx < unchecked((uint)type.member_types.size()); mbr_idx++)
                        {
                            var mbr_name = this.to_member_name(type, mbr_idx);
                            var flat_name = Std.join(type_name, "_", mbr_name);
                            statement("stage_output.", flat_name, " = ", var_name, ".", mbr_name, ";");
                        }
                    }
                }
                else
                {
                    var name = this.to_name(((uint)@var.self), true);
                    if (this.hlsl_options.shader_model <= 30u && unchecked((int)this.get_entry_point().model) == unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
                    {
                        CppString output_filler = default(CppString);
                        {
                            for (uint size = type.vecsize; size < 4u; ++size)
                            {
                                output_filler += ", 0.0";
                            }
                        }
                        statement("stage_output.", name, " = float4(", name, output_filler, ");");
                    }
                    else
                    {
                        statement("stage_output.", name, " = ", name, ";");
                    }
                }
            }
        });
        statement("geometry_stream.Append(stage_output);");
        end_scope();
    }
    public override string to_storage_qualifiers_glsl(SPIRVariable @var)
    {
        if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant))
        {
            return "uniform ";
        }
        return "";
    }
    private static UnorderedSet<CppString> keywords_static18 = new UnorderedSet<CppString>(new CppString[] { new CppString("AppendStructuredBuffer"), new CppString("asm"), new CppString("asm_fragment"), new CppString("BlendState"), new CppString("bool"), new CppString("break"), new CppString("Buffer"), new CppString("ByteAddressBuffer"), new CppString("case"), new CppString("cbuffer"), new CppString("centroid"), new CppString("class"), new CppString("column_major"), new CppString("compile"), new CppString("compile_fragment"), new CppString("CompileShader"), new CppString("const"), new CppString("continue"), new CppString("ComputeShader"), new CppString("ConsumeStructuredBuffer"), new CppString("default"), new CppString("DepthStencilState"), new CppString("DepthStencilView"), new CppString("discard"), new CppString("do"), new CppString("double"), new CppString("DomainShader"), new CppString("dword"), new CppString("else"), new CppString("export"), new CppString("false"), new CppString("float"), new CppString("for"), new CppString("fxgroup"), new CppString("GeometryShader"), new CppString("groupshared"), new CppString("half"), new CppString("HullShader"), new CppString("indices"), new CppString("if"), new CppString("in"), new CppString("inline"), new CppString("inout"), new CppString("InputPatch"), new CppString("int"), new CppString("interface"), new CppString("line"), new CppString("lineadj"), new CppString("linear"), new CppString("LineStream"), new CppString("matrix"), new CppString("min16float"), new CppString("min10float"), new CppString("min16int"), new CppString("min16uint"), new CppString("namespace"), new CppString("nointerpolation"), new CppString("noperspective"), new CppString("NULL"), new CppString("out"), new CppString("OutputPatch"), new CppString("payload"), new CppString("packoffset"), new CppString("pass"), new CppString("pixelfragment"), new CppString("PixelShader"), new CppString("point"), new CppString("PointStream"), new CppString("precise"), new CppString("RasterizerState"), new CppString("RenderTargetView"), new CppString("return"), new CppString("register"), new CppString("row_major"), new CppString("RWBuffer"), new CppString("RWByteAddressBuffer"), new CppString("RWStructuredBuffer"), new CppString("RWTexture1D"), new CppString("RWTexture1DArray"), new CppString("RWTexture2D"), new CppString("RWTexture2DArray"), new CppString("RWTexture3D"), new CppString("sample"), new CppString("sampler"), new CppString("SamplerState"), new CppString("SamplerComparisonState"), new CppString("shared"), new CppString("snorm"), new CppString("stateblock"), new CppString("stateblock_state"), new CppString("static"), new CppString("string"), new CppString("struct"), new CppString("switch"), new CppString("StructuredBuffer"), new CppString("tbuffer"), new CppString("technique"), new CppString("technique10"), new CppString("technique11"), new CppString("texture"), new CppString("Texture1D"), new CppString("Texture1DArray"), new CppString("Texture2D"), new CppString("Texture2DArray"), new CppString("Texture2DMS"), new CppString("Texture2DMSArray"), new CppString("Texture3D"), new CppString("TextureCube"), new CppString("TextureCubeArray"), new CppString("true"), new CppString("typedef"), new CppString("triangle"), new CppString("triangleadj"), new CppString("TriangleStream"), new CppString("uint"), new CppString("uniform"), new CppString("unorm"), new CppString("unsigned"), new CppString("vector"), new CppString("vertexfragment"), new CppString("VertexShader"), new CppString("vertices"), new CppString("void"), new CppString("volatile"), new CppString("while"), new CppString("signed") });
    public override void replace_illegal_names()
    {
        base.replace_illegal_names(keywords_static18);
        base.replace_illegal_names();
    }
    public override SPIRType.BaseType get_builtin_basetype(Spv.BuiltIn builtin, SPIRType.BaseType default_type)
    {
        {
            switch (unchecked((int)builtin))
            {
                case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                {
                    return default_type;
                }
                default:
                {
                    return base.get_builtin_basetype(builtin, default_type);
                }
            }
        }
    }
    public bool is_hlsl_force_storage_buffer_as_uav(TypedID_TypeNone id)
    {
        if (hlsl_options.force_storage_buffer_as_uav)
        {
            return true;
        }
        uint desc_set = get_decoration(id, Spv.Decoration.DecorationDescriptorSet);
        uint binding = get_decoration(id, Spv.Decoration.DecorationBinding);
        return force_uav_buffer_bindings.find(new SetBindingPair { desc_set = desc_set, binding = binding }) != force_uav_buffer_bindings.end();
    }
    public bool is_hidden_io_variable(SPIRVariable @var)
    {
        if (!is_hidden_variable(@var, false))
        {
            return false;
        }
        bool is_external_linkage = unchecked((int)get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex) && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) || unchecked((int)get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelFragment) && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput);
        if (!is_external_linkage)
        {
            return false;
        }
        if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput) && !is_legacy() && (location_is_framebuffer_fetch(get_decoration(@var.self, Spv.Decoration.DecorationLocation)) ? 1 : 0) != 0)
        {
            return false;
        }
        return true;
    }
    public CompilerHLSL.Options hlsl_options = new CompilerHLSL.Options();
    public bool requires_op_fmod = false;
    public bool requires_fp16_packing = false;
    public bool requires_uint2_packing = false;
    public bool requires_explicit_fp16_packing = false;
    public bool requires_unorm8_packing = false;
    public bool requires_snorm8_packing = false;
    public bool requires_unorm16_packing = false;
    public bool requires_snorm16_packing = false;
    public bool requires_bitfield_insert = false;
    public bool requires_bitfield_extract = false;
    public bool requires_inverse_2x2 = false;
    public bool requires_inverse_3x3 = false;
    public bool requires_inverse_4x4 = false;
    public bool requires_scalar_reflect = false;
    public bool requires_scalar_refract = false;
    public bool requires_scalar_faceforward = false;
    public CompilerHLSL.TextureSizeVariants required_texture_size_variants = new CompilerHLSL.TextureSizeVariants();
    public void require_texture_query_variant(uint var_id)
    {
        {
            var @var = maybe_get_backing_variable(var_id);
            if (@var != null)
            {
                var_id = ((uint)@var.self);
            }
        }
        var type = expression_type(var_id);
        bool uav = type.image.sampled == 2u;
        if (hlsl_options.nonwritable_uav_texture_as_srv && has_decoration(new TypedID_TypeNone(var_id), Spv.Decoration.DecorationNonWritable))
        {
            uav = false;
        }
        uint bit = 0u;
        {
            switch (unchecked((int)type.image.dim))
            {
                case unchecked((int)Spv.Dim.Dim1D):
                {
                    bit = unchecked((uint)(type.image.arrayed ? CompilerHLSL.TextureQueryVariantDim.Query1DArray : CompilerHLSL.TextureQueryVariantDim.Query1D));
                    break;
                }
                case unchecked((int)Spv.Dim.Dim2D):
                {
                    if (type.image.ms)
                    {
                        bit = unchecked((uint)(type.image.arrayed ? CompilerHLSL.TextureQueryVariantDim.Query2DMSArray : CompilerHLSL.TextureQueryVariantDim.Query2DMS));
                    }
                    else
                    {
                        bit = unchecked((uint)(type.image.arrayed ? CompilerHLSL.TextureQueryVariantDim.Query2DArray : CompilerHLSL.TextureQueryVariantDim.Query2D));
                    }
                    break;
                }
                case unchecked((int)Spv.Dim.Dim3D):
                {
                    bit = unchecked((uint)CompilerHLSL.TextureQueryVariantDim.Query3D);
                    break;
                }
                case unchecked((int)Spv.Dim.DimCube):
                {
                    bit = unchecked((uint)(type.image.arrayed ? CompilerHLSL.TextureQueryVariantDim.QueryCubeArray : CompilerHLSL.TextureQueryVariantDim.QueryCube));
                    break;
                }
                case unchecked((int)Spv.Dim.DimBuffer):
                {
                    bit = unchecked((uint)CompilerHLSL.TextureQueryVariantDim.QueryBuffer);
                    break;
                }
                default:
                {
                    throw new CompilerError("Unsupported query type.");
                }
            }
        }
        {
            switch (unchecked((int)get__SPIRType(((uint)type.image.type)).basetype))
            {
                case unchecked((int)SPIRType.BaseType.Float):
                {
                    bit += unchecked((uint)CompilerHLSL.TextureQueryVariantType.QueryTypeFloat);
                    break;
                }
                case unchecked((int)SPIRType.BaseType.Int):
                {
                    bit += unchecked((uint)CompilerHLSL.TextureQueryVariantType.QueryTypeInt);
                    break;
                }
                case unchecked((int)SPIRType.BaseType.UInt):
                {
                    bit += unchecked((uint)CompilerHLSL.TextureQueryVariantType.QueryTypeUInt);
                    break;
                }
                default:
                {
                    throw new CompilerError("Unsupported query type.");
                }
            }
        }
        var norm_state = Globals.image_format_to_normalized_state(type.image.format);
        ref var variant = ref (uav ? ref required_texture_size_variants.uav[unchecked((uint)norm_state)][Globals.image_format_to_components(type.image.format) - 1u] : ref required_texture_size_variants.srv);
        ulong mask = 1UL << (int)bit;
        if ((variant & mask) == 0UL)
        {
            force_recompile();
            variant |= mask;
        }
    }
    private static string[] types_static25 = new string[] { "float", "int", "uint" };
    private static string[] dims_static26 = new string[] { "Texture1D", "Texture1DArray", "Texture2D", "Texture2DArray", "Texture3D", "Buffer", "TextureCube", "TextureCubeArray", "Texture2DMS", "Texture2DMSArray" };
    private static bool[] has_lod_static27 = new bool[] { true, true, true, true, true, false, true, true, false, false };
    private static string[] ret_types_static28 = new string[] { "uint", "uint2", "uint2", "uint3", "uint3", "uint", "uint2", "uint3", "uint2", "uint3" };
    private static uint[] return_arguments_static29 = new uint[] { 1u, 2u, 2u, 3u, 3u, 1u, 2u, 3u, 2u, 3u };
    public void emit_texture_size_variants(ulong variant_mask, string vecsize_qualifier, bool uav, string type_qualifier)
    {
        if (variant_mask == 0UL)
        {
            return;
        }
        {
            for (uint index = 0u; index < unchecked((uint)CompilerHLSL.TextureQueryVariantDim.QueryDimCount); index++)
            {
                {
                    for (uint type_index = 0u; type_index < unchecked((uint)CompilerHLSL.TextureQueryVariantType.QueryTypeCount); type_index++)
                    {
                        uint bit = 16u * type_index + index;
                        ulong mask = 1UL << (int)bit;
                        if ((variant_mask & mask) == 0UL)
                        {
                            continue;
                        }
                        statement(ret_types_static28[index], " spv", uav ? "Image" : "Texture", "Size(", uav ? "RW" : "", dims_static26[index], "<", type_qualifier, types_static25[type_index], vecsize_qualifier, "> Tex, ", uav ? "" : "uint Level, ", "out uint Param)");
                        begin_scope();
                        statement(ret_types_static28[index], " ret;");
                        {
                            switch (return_arguments_static29[index])
                            {
                                case 1u:
                                {
                                    if (has_lod_static27[index] && !uav)
                                    {
                                        statement("Tex.GetDimensions(Level, ret.x, Param);");
                                    }
                                    else
                                    {
                                        statement("Tex.GetDimensions(ret.x);");
                                        statement("Param = 0u;");
                                    }
                                    break;
                                }
                                case 2u:
                                {
                                    if (has_lod_static27[index] && !uav)
                                    {
                                        statement("Tex.GetDimensions(Level, ret.x, ret.y, Param);");
                                    }
                                    else
                                    if (!uav)
                                    {
                                        statement("Tex.GetDimensions(ret.x, ret.y, Param);");
                                    }
                                    else
                                    {
                                        statement("Tex.GetDimensions(ret.x, ret.y);");
                                        statement("Param = 0u;");
                                    }
                                    break;
                                }
                                case 3u:
                                {
                                    if (has_lod_static27[index] && !uav)
                                    {
                                        statement("Tex.GetDimensions(Level, ret.x, ret.y, ret.z, Param);");
                                    }
                                    else
                                    if (!uav)
                                    {
                                        statement("Tex.GetDimensions(ret.x, ret.y, ret.z, Param);");
                                    }
                                    else
                                    {
                                        statement("Tex.GetDimensions(ret.x, ret.y, ret.z);");
                                        statement("Param = 0u;");
                                    }
                                    break;
                                }
                            }
                        }
                        statement("return ret;");
                        end_scope();
                        statement("");
                    }
                }
            }
        }
    }
    public void analyze_meshlet_writes()
    {
        uint id_per_vertex = 0u;
        uint id_per_primitive = 0u;
        bool need_per_primitive = false;
        bool need_per_vertex = false;
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            var type = this.get__SPIRType(((uint)@var.basetype));
            bool block = this.has_decoration(type.self, Spv.Decoration.DecorationBlock);
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput) && block && this.is_builtin_variable(@var))
            {
                var flags = this.get_buffer_block_flags(((TypedID_TypeVariable)@var.self));
                if (flags.get(unchecked((uint)Spv.Decoration.DecorationPerPrimitiveEXT)))
                {
                    id_per_primitive = ((uint)@var.self);
                }
                else
                {
                    id_per_vertex = ((uint)@var.self);
                }
            }
            else
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput))
            {
                Bitset flags = new Bitset();
                if (block)
                {
                    flags.CopyFrom(this.get_buffer_block_flags(((TypedID_TypeVariable)@var.self)));
                }
                else
                {
                    flags.CopyFrom(this.get_decoration_bitset(@var.self));
                }
                if (flags.get(unchecked((uint)Spv.Decoration.DecorationPerPrimitiveEXT)))
                {
                    need_per_primitive = true;
                }
                else
                {
                    need_per_vertex = true;
                }
            }
        });
        var generate_block = (string block_name, string instance_name, bool per_primitive) =>
        {
            var execution = this.get_entry_point();
            uint op_type = this.ir.increase_bound_by(4u);
            uint op_arr = op_type + 1u;
            uint op_ptr = op_type + 2u;
            uint op_var = op_type + 3u;
            var type = this.set__SPIRType_X(op_type, Spv.Op.OpTypeStruct);
            type.basetype = SPIRType.BaseType.Struct;
            this.set_name(new TypedID_TypeNone(op_type), new CppString(block_name));
            this.set_decoration(new TypedID_TypeNone(op_type), Spv.Decoration.DecorationBlock, 0u);
            if (per_primitive)
            {
                this.set_decoration(new TypedID_TypeNone(op_type), Spv.Decoration.DecorationPerPrimitiveEXT, 0u);
            }
            var arr = this.set__SPIRType_X(op_arr, type);
            arr.op = Spv.Op.OpTypeArray;
            arr.parent_type = ((TypedID_TypeType)type.self);
            arr.array.push_back(per_primitive ? execution.output_primitives : execution.output_vertices);
            arr.array_size_literal.push_back(true);
            var ptr = this.set__SPIRType_X(op_ptr, arr);
            ptr.parent_type = ((TypedID_TypeType)arr.self);
            ptr.op = Spv.Op.OpTypePointer;
            ptr.pointer = true;
            ptr.pointer_depth++;
            ptr.storage = Spv.StorageClass.StorageClassOutput;
            this.set_decoration(new TypedID_TypeNone(op_ptr), Spv.Decoration.DecorationBlock, 0u);
            this.set_name(new TypedID_TypeNone(op_ptr), new CppString(block_name));
            var @var = this.set__SPIRVariable_X(op_var, op_ptr, Spv.StorageClass.StorageClassOutput);
            if (per_primitive)
            {
                this.set_decoration(new TypedID_TypeNone(op_var), Spv.Decoration.DecorationPerPrimitiveEXT, 0u);
            }
            this.set_name(new TypedID_TypeNone(op_var), new CppString(instance_name));
            execution.interface_variables.push_back(((TypedID_TypeVariable)@var.self));
            return op_var;
        };
        if (id_per_vertex == 0u && need_per_vertex)
        {
            id_per_vertex = generate_block("gl_MeshPerVertexEXT", "gl_MeshVerticesEXT", false);
        }
        if (id_per_primitive == 0u && need_per_primitive)
        {
            id_per_primitive = generate_block("gl_MeshPerPrimitiveEXT", "gl_MeshPrimitivesEXT", true);
        }
        UnorderedSet<uint> processed_func_ids = new UnorderedSet<uint>();
        analyze_meshlet_writes(((uint)ir.default_entry_point), id_per_vertex, id_per_primitive, processed_func_ids);
    }
    public void analyze_meshlet_writes(uint func_id, uint id_per_vertex, uint id_per_primitive, UnorderedSet<uint> processed_func_ids)
    {
        if (processed_func_ids.find(func_id) != processed_func_ids.end())
        {
            return;
        }
        processed_func_ids.insert(func_id);
        var func = get__SPIRFunction(func_id);
        {
            var __r0 = func.blocks;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref TypedID_TypeBlock block = ref __r0[__i1];
                var b = get__SPIRBlock(((uint)block));
                {
                    foreach (Instruction i in b.ops)
                    {
                        var ops = stream(i);
                        var op = unchecked((Spv.Op)i.op);
                        {
                            switch (unchecked((int)op))
                            {
                                case unchecked((int)Spv.Op.OpFunctionCall):
                                {
                                    {
                                        uint inner_func_id = ops[2];
                                        analyze_meshlet_writes(inner_func_id, id_per_vertex, id_per_primitive, processed_func_ids);
                                        var inner_func = get__SPIRFunction(inner_func_id);
                                        {
                                            foreach (SPIRFunction.Parameter iarg in inner_func.arguments)
                                            {
                                                if (!iarg.alias_global_variable)
                                                {
                                                    continue;
                                                }
                                                bool already_declared = false;
                                                {
                                                    foreach (SPIRFunction.Parameter arg in func.arguments)
                                                    {
                                                        if (((uint)arg.id) == ((uint)iarg.id))
                                                        {
                                                            already_declared = true;
                                                            break;
                                                        }
                                                    }
                                                }
                                                if (!already_declared)
                                                {
                                                    func.arguments.push_back(new SPIRFunction.Parameter { type = new TypedID_TypeType(expression_type_id(((uint)iarg.id))), id = iarg.id, read_count = iarg.read_count, write_count = iarg.write_count, alias_global_variable = true });
                                                }
                                            }
                                        }
                                        break;
                                    }
                                }
                                case unchecked((int)Spv.Op.OpStore):
                                case unchecked((int)Spv.Op.OpLoad):
                                case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                                case unchecked((int)Spv.Op.OpAccessChain):
                                case unchecked((int)Spv.Op.OpPtrAccessChain):
                                case unchecked((int)Spv.Op.OpInBoundsPtrAccessChain):
                                case unchecked((int)Spv.Op.OpArrayLength):
                                {
                                    {
                                        var @var = maybe_get__SPIRVariable(ops[unchecked((int)op) == unchecked((int)Spv.Op.OpStore) ? 0 : 2]);
                                        if (@var != null && (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT)))
                                        {
                                            bool already_declared = false;
                                            var builtin_type = unchecked((Spv.BuiltIn)get_decoration(@var.self, Spv.Decoration.DecorationBuiltIn));
                                            uint var_id = ((uint)@var.self);
                                            if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT) && unchecked((int)builtin_type) != unchecked((int)Spv.BuiltIn.BuiltInPrimitivePointIndicesEXT) && unchecked((int)builtin_type) != unchecked((int)Spv.BuiltIn.BuiltInPrimitiveLineIndicesEXT) && unchecked((int)builtin_type) != unchecked((int)Spv.BuiltIn.BuiltInPrimitiveTriangleIndicesEXT))
                                            {
                                                var_id = is_per_primitive_variable(@var) ? id_per_primitive : id_per_vertex;
                                            }
                                            {
                                                foreach (SPIRFunction.Parameter arg in func.arguments)
                                                {
                                                    if (((uint)arg.id) == var_id)
                                                    {
                                                        already_declared = true;
                                                        break;
                                                    }
                                                }
                                            }
                                            if (!already_declared)
                                            {
                                                uint type_id = expression_type_id(var_id);
                                                if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT))
                                                {
                                                    func.arguments.push_back(new SPIRFunction.Parameter { type = new TypedID_TypeType(type_id), id = new TypedID_TypeNone(var_id), read_count = 1u, write_count = 0u, alias_global_variable = true });
                                                }
                                                else
                                                {
                                                    func.arguments.push_back(new SPIRFunction.Parameter { type = new TypedID_TypeType(type_id), id = new TypedID_TypeNone(var_id), read_count = 1u, write_count = 1u, alias_global_variable = true });
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
            }
        }
    }
    public CompilerHLSL.BitcastType get_bitcast_type(uint result_type, uint op0)
    {
        var rslt_type = get__SPIRType(result_type);
        var expr_type = expression_type(op0);
        if (unchecked((int)rslt_type.basetype) == unchecked((int)SPIRType.BaseType.UInt64) && unchecked((int)expr_type.basetype) == unchecked((int)SPIRType.BaseType.UInt) && expr_type.vecsize == 2u)
        {
            return CompilerHLSL.BitcastType.TypePackUint2x32;
        }
        else
        if (unchecked((int)rslt_type.basetype) == unchecked((int)SPIRType.BaseType.UInt) && rslt_type.vecsize == 2u && unchecked((int)expr_type.basetype) == unchecked((int)SPIRType.BaseType.UInt64))
        {
            return CompilerHLSL.BitcastType.TypeUnpackUint64;
        }
        return CompilerHLSL.BitcastType.TypeNormal;
    }
    public void emit_builtin_variables()
    {
        Bitset builtins = active_input_builtins.Clone();
        builtins.merge_or(active_output_builtins);
        UnorderedMap<uint, TypedID_TypeNone> builtin_to_initializer = new UnorderedMap<uint, TypedID_TypeNone>();
        SPIRType.BaseType sample_mask_in_basetype = SPIRType.BaseType.Void;
        SPIRType.BaseType sample_mask_out_basetype = SPIRType.BaseType.Void;
        ir.for_each_typed_id__SPIRVariable_lambda((uint _p, SPIRVariable @var) =>
        {
            if (!this.is_builtin_variable(@var))
            {
                return;
            }
            var type = this.get__SPIRType(((uint)@var.basetype));
            var builtin = unchecked((Spv.BuiltIn)this.get_decoration(@var.self, Spv.Decoration.DecorationBuiltIn));
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) && unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInSampleMask))
            {
                sample_mask_in_basetype = type.basetype;
            }
            else
            if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput) && unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInSampleMask))
            {
                sample_mask_out_basetype = type.basetype;
            }
            if (((uint)@var.initializer) != 0u && unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput))
            {
                var c = this.maybe_get__SPIRConstant(((uint)@var.initializer));
                if (!(c != null))
                {
                    return;
                }
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
                {
                    uint member_count = unchecked((uint)type.member_types.size());
                    {
                        for (uint i = 0u; i < member_count; i++)
                        {
                            if (this.has_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationBuiltIn))
                            {
                                builtin_to_initializer[this.get_member_decoration(((TypedID_TypeType)type.self), i, Spv.Decoration.DecorationBuiltIn)] = c.subconstants[unchecked((ulong)i)];
                            }
                        }
                    }
                }
                else
                if (this.has_decoration(@var.self, Spv.Decoration.DecorationBuiltIn))
                {
                    builtin_to_initializer[unchecked((uint)builtin)] = @var.initializer;
                }
            }
        });
        builtins.for_each_bit__lambda((uint i) =>
        {
            var builtin = unchecked((Spv.BuiltIn)i);
            CppString init_expr = default(CppString);
            var init_itr = builtin_to_initializer.find(unchecked((uint)builtin));
            if (init_itr != builtin_to_initializer.end())
            {
                init_expr = Std.join(" = ", this.to_expression(((uint)init_itr.deref().second), true));
            }
            if (unchecked((int)this.get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT))
            {
                if (unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPosition) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPointSize) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInClipDistance) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInCullDistance) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInLayer) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPrimitiveId) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInViewportIndex) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInCullPrimitiveEXT) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPrimitiveShadingRateKHR) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPrimitivePointIndicesEXT) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPrimitiveLineIndicesEXT) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPrimitiveTriangleIndicesEXT))
                {
                    return;
                }
            }
            bool has_separate_input_output = false;
            {
                for (int variable_index = 0; variable_index < (has_separate_input_output ? 2 : 1); variable_index++)
                {
                    uint array_size = 0u;
                    Spv.StorageClass storage = this.active_input_builtins.get(i) && variable_index == 0 ? Spv.StorageClass.StorageClassInput : Spv.StorageClass.StorageClassOutput;
                    string type = null;
                    {
                        switch (unchecked((int)builtin))
                        {
                            case unchecked((int)Spv.BuiltIn.BuiltInFragCoord):
                            {
                                type = "float4";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInPosition):
                            {
                                type = "float4";
                                if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassInput) && (unchecked((int)this.get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry) || unchecked((int)this.get_execution_model()) == unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl)))
                                {
                                    array_size = this.input_vertices_from_execution_mode(this.get_entry_point());
                                }
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInFragDepth):
                            {
                                type = "float";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInVertexId):
                            case unchecked((int)Spv.BuiltIn.BuiltInVertexIndex):
                            case unchecked((int)Spv.BuiltIn.BuiltInInstanceIndex):
                            {
                                type = "int";
                                if (this.hlsl_options.support_nonzero_base_vertex_base_instance || this.hlsl_options.shader_model >= 68u)
                                {
                                    this.base_vertex_info.used = true;
                                }
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInBaseVertex):
                            case unchecked((int)Spv.BuiltIn.BuiltInBaseInstance):
                            {
                                type = "int";
                                this.base_vertex_info.used = true;
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInInstanceId):
                            case unchecked((int)Spv.BuiltIn.BuiltInSampleId):
                            {
                                type = "int";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInPointSize):
                            {
                                if (this.hlsl_options.point_size_compat || this.hlsl_options.shader_model <= 30u)
                                {
                                    type = "float";
                                    break;
                                }
                                else
                                {
                                    throw new CompilerError(Std.join("Unsupported builtin in HLSL: ", unchecked((uint)builtin)));
                                }
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInGlobalInvocationId):
                            case unchecked((int)Spv.BuiltIn.BuiltInLocalInvocationId):
                            case unchecked((int)Spv.BuiltIn.BuiltInWorkgroupId):
                            {
                                type = "uint3";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInLocalInvocationIndex):
                            {
                                type = "uint";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInFrontFacing):
                            {
                                type = "bool";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInNumWorkgroups):
                            case unchecked((int)Spv.BuiltIn.BuiltInPointCoord):
                            {
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLocalInvocationId):
                            case unchecked((int)Spv.BuiltIn.BuiltInSubgroupSize):
                            {
                                if (this.hlsl_options.shader_model < 60u)
                                {
                                    throw new CompilerError("Need SM 6.0 for Wave ops.");
                                }
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInSubgroupEqMask):
                            case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLtMask):
                            case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLeMask):
                            case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGtMask):
                            case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGeMask):
                            {
                                if (this.hlsl_options.shader_model < 60u)
                                {
                                    throw new CompilerError("Need SM 6.0 for Wave ops.");
                                }
                                type = "uint4";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInHelperInvocation):
                            {
                                if (this.hlsl_options.shader_model < 50u)
                                {
                                    throw new CompilerError("Need SM 5.0 for Helper Invocation.");
                                }
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                            {
                                array_size = this.clip_distance_count;
                                type = "float";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                            {
                                array_size = this.cull_distance_count;
                                type = "float";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                            {
                                if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassInput))
                                {
                                    type = unchecked((int)sample_mask_in_basetype) == unchecked((int)SPIRType.BaseType.UInt) ? "uint" : "int";
                                }
                                else
                                {
                                    type = unchecked((int)sample_mask_out_basetype) == unchecked((int)SPIRType.BaseType.UInt) ? "uint" : "int";
                                }
                                array_size = 1u;
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveId):
                            case unchecked((int)Spv.BuiltIn.BuiltInViewIndex):
                            case unchecked((int)Spv.BuiltIn.BuiltInLayer):
                            {
                                type = "uint";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInViewportIndex):
                            case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveShadingRateKHR):
                            case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveLineIndicesEXT):
                            case unchecked((int)Spv.BuiltIn.BuiltInCullPrimitiveEXT):
                            {
                                type = "uint";
                                break;
                            }
                            case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordKHR):
                            case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordNoPerspKHR):
                            {
                                if (this.hlsl_options.shader_model < 61u)
                                {
                                    throw new CompilerError("Need SM 6.1 for barycentrics.");
                                }
                                type = "float3";
                                break;
                            }
                            default:
                            {
                                throw new CompilerError(Std.join("Unsupported builtin in HLSL: ", unchecked((uint)builtin)));
                            }
                        }
                    }
                    if (type != null)
                    {
                        var builtin_name = this.builtin_to_glsl(builtin, storage);
                        if (array_size != 0u)
                        {
                            statement("static ", type, " ", builtin_name, "[", array_size, "]", init_expr, ";");
                        }
                        else
                        {
                            statement("static ", type, " ", builtin_name, init_expr, ";");
                        }
                        if (unchecked((int)storage) == unchecked((int)Spv.StorageClass.StorageClassInput) && this.active_output_builtins.get(i))
                        {
                            var out_builtin_name = this.builtin_to_glsl(builtin, Spv.StorageClass.StorageClassOutput);
                            if (out_builtin_name != builtin_name)
                            {
                                has_separate_input_output = true;
                            }
                        }
                    }
                }
            }
        });
        if (base_vertex_info.used && hlsl_options.shader_model < 68u)
        {
            CppString binding_info = default(CppString);
            if (base_vertex_info.explicit_binding)
            {
                binding_info = Std.join(" : register(b", base_vertex_info.register_index);
                if (base_vertex_info.register_space != 0u)
                {
                    binding_info += Std.join(", space", base_vertex_info.register_space);
                }
                binding_info += ")";
            }
            statement("cbuffer SPIRV_Cross_VertexInfo", binding_info);
            begin_scope();
            statement("int SPIRV_Cross_BaseVertex;");
            statement("int SPIRV_Cross_BaseInstance;");
            end_scope_decl();
            statement("");
        }
    }
    public bool require_output = false;
    public bool require_input = false;
    public CppVector<HLSLVertexAttributeRemap> remap_vertex_attributes = new CppVector<HLSLVertexAttributeRemap>();
    public uint type_to_consumed_locations(SPIRType type)
    {
        uint elements = 0u;
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
        {
            {
                for (uint i = 0u; i < unchecked((uint)type.member_types.size()); i++)
                {
                    elements += type_to_consumed_locations(get__SPIRType(((uint)type.member_types[unchecked((ulong)i)])));
                }
            }
        }
        else
        {
            uint array_multiplier = 1u;
            {
                for (uint i = 0u; i < unchecked((uint)type.array.size()); i++)
                {
                    if (type.array_size_literal[unchecked((ulong)i)])
                    {
                        array_multiplier *= type.array[unchecked((ulong)i)];
                    }
                    else
                    {
                        array_multiplier *= evaluate_constant_u32(type.array[unchecked((ulong)i)]);
                    }
                }
            }
            elements += array_multiplier * type.columns;
        }
        return elements;
    }
    public CppString to_semantic(uint location, Spv.ExecutionModel em, Spv.StorageClass sc)
    {
        if (unchecked((int)em) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex) && unchecked((int)sc) == unchecked((int)Spv.StorageClass.StorageClassInput))
        {
            {
                foreach (HLSLVertexAttributeRemap attribute in remap_vertex_attributes)
                {
                    if (attribute.location == location)
                    {
                        return attribute.semantic;
                    }
                }
            }
        }
        return Std.join("TEXCOORD", location);
    }
    public uint num_workgroups_builtin = 0u;
    public uint resource_binding_flags = 0u;
    public CppVector<RootConstants> root_constants_layout = new CppVector<RootConstants>();
    public void validate_shader_model()
    {
        {
            var __r0 = ir.declared_capabilities;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref Spv.Capability cap = ref __r0[__i1];
                {
                    switch (unchecked((int)cap))
                    {
                        case unchecked((int)Spv.Capability.CapabilityShaderNonUniformEXT):
                        case unchecked((int)Spv.Capability.CapabilityRuntimeDescriptorArrayEXT):
                        {
                            if (hlsl_options.shader_model < 51u)
                            {
                                throw new CompilerError("Shader model 5.1 or higher is required to use bindless resources or NonUniformResourceIndex.");
                            }
                            break;
                        }
                        case unchecked((int)Spv.Capability.CapabilityVariablePointers):
                        case unchecked((int)Spv.Capability.CapabilityVariablePointersStorageBuffer):
                        {
                            throw new CompilerError("VariablePointers capability is not supported in HLSL.");
                        }
                        default:
                        {
                            break;
                        }
                    }
                }
            }
        }
        if (unchecked((int)ir.addressing_model) != unchecked((int)Spv.AddressingModel.AddressingModelLogical))
        {
            throw new CompilerError("Only Logical addressing model can be used with HLSL.");
        }
        if (hlsl_options.enable_16bit_types && hlsl_options.shader_model < 62u)
        {
            throw new CompilerError("Need at least shader model 6.2 when enabling native 16-bit type support.");
        }
    }
    public CppString get_unique_identifier()
    {
        return Std.join("_", unique_identifier_count++, "ident");
    }
    public uint unique_identifier_count = 0u;
    public UnorderedMap<StageSetBinding, Pair<HLSLResourceBinding, bool>> resource_bindings = new UnorderedMap<StageSetBinding, Pair<HLSLResourceBinding, bool>>();
    public void remap_hlsl_resource_binding(HLSLBindingFlagBits type, ref uint desc_set, ref uint binding)
    {
        var itr = resource_bindings.find(new StageSetBinding { model = get_execution_model(), desc_set = desc_set, binding = binding });
        if (itr != Std.end(resource_bindings))
        {
            var remap = itr.deref().second;
            remap.second = true;
            {
                switch (unchecked((int)type))
                {
                    case unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_PUSH_CONSTANT_BIT):
                    case unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_CBV_BIT):
                    {
                        desc_set = remap.first.cbv.register_space;
                        binding = remap.first.cbv.register_binding;
                        break;
                    }
                    case unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_SRV_BIT):
                    {
                        desc_set = remap.first.srv.register_space;
                        binding = remap.first.srv.register_binding;
                        break;
                    }
                    case unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_SAMPLER_BIT):
                    {
                        desc_set = remap.first.sampler.register_space;
                        binding = remap.first.sampler.register_binding;
                        break;
                    }
                    case unchecked((int)HLSLBindingFlagBits.HLSL_BINDING_AUTO_UAV_BIT):
                    {
                        desc_set = remap.first.uav.register_space;
                        binding = remap.first.uav.register_binding;
                        break;
                    }
                    default:
                    {
                        break;
                    }
                }
            }
        }
    }
    public UnorderedSet<SetBindingPair> force_uav_buffer_bindings = new UnorderedSet<SetBindingPair>();
    public CompilerHLSL.base_vertex_info_t base_vertex_info = new CompilerHLSL.base_vertex_info_t();
    public override bool is_user_type_structured(uint id)
    {
        if (hlsl_options.preserve_structured_buffers)
        {
            CppString user_type = get_decoration_string(new TypedID_TypeNone(id), Spv.Decoration.DecorationUserTypeGOOGLE);
            return user_type.compare(0UL, 16UL, "structuredbuffer") == 0 || user_type.compare(0UL, 18UL, "rwstructuredbuffer") == 0 || user_type.compare(0UL, 35UL, "globallycoherent rwstructuredbuffer") == 0 || user_type.compare(0UL, 33UL, "rasterizerorderedstructuredbuffer") == 0;
        }
        return false;
    }
    public CppVector<TypedID_TypeType> composite_selection_workaround_types = new CppVector<TypedID_TypeType>();
    public CppString get_inner_entry_point_name()
    {
        var execution = get_entry_point();
        if (hlsl_options.use_entry_point_name)
        {
            var name = Std.join(execution.name, "_inner");
            ParsedIR.sanitize_underscores(ref name);
            return name;
        }
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelVertex))
        {
            return new CppString("vert_main");
        }
        else
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelFragment))
        {
            return new CppString("frag_main");
        }
        else
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute))
        {
            return new CppString("comp_main");
        }
        else
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry))
        {
            return new CppString("geom_main");
        }
        else
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT))
        {
            return new CppString("mesh_main");
        }
        else
        if (unchecked((int)execution.model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTaskEXT))
        {
            return new CppString("task_main");
        }
        else
        {
            throw new CompilerError("Unsupported execution model.");
        }
    }
    public override void cast_to_variable_store(uint target_id, ref CppString expr, SPIRType expr_type)
    {
        if (unchecked((int)get_execution_model()) != unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT) || !has_decoration(new TypedID_TypeNone(target_id), Spv.Decoration.DecorationBuiltIn) || !is_array(expr_type))
        {
            base.cast_to_variable_store(target_id, ref expr, expr_type);
            return;
        }
        var builtin = unchecked((Spv.BuiltIn)get_decoration(new TypedID_TypeNone(target_id), Spv.Decoration.DecorationBuiltIn));
        if (unchecked((int)builtin) != unchecked((int)Spv.BuiltIn.BuiltInClipDistance) && unchecked((int)builtin) != unchecked((int)Spv.BuiltIn.BuiltInCullDistance))
        {
            base.cast_to_variable_store(target_id, ref expr, expr_type);
            return;
        }
        if (is_array(get__SPIRType(((uint)expr_type.parent_type))))
        {
            throw new CompilerError("Attempting to store all mesh vertices in one go. This is not supported.");
        }
        uint num_clip = to_array_size_literal(expr_type);
        if (num_clip > 4u)
        {
            throw new CompilerError("Number of clip or cull distances exceeds 4, this will not work with mesh shaders.");
        }
        if (num_clip == 1u)
        {
            base.cast_to_variable_store(target_id, ref expr, expr_type);
            return;
        }
        var unrolled_expr = Std.join("float", num_clip, "(");
        {
            for (uint i = 0u; i < num_clip; i++)
            {
                unrolled_expr += Std.join(expr, "[", i, "]");
                if (i + 1u < num_clip)
                {
                    unrolled_expr += ", ";
                }
            }
        }
        unrolled_expr += ")";
        expr = unrolled_expr;
    }

    protected override void FixClone()
    {
        base.FixClone();
        this.hlsl_options = this.hlsl_options.Clone();
        this.required_texture_size_variants = this.required_texture_size_variants.Clone();
        this.remap_vertex_attributes = this.remap_vertex_attributes.Clone(__e => __e.Clone());
        this.root_constants_layout = this.root_constants_layout.Clone(__e => __e.Clone());
        this.resource_bindings = this.resource_bindings.Clone(__e => __e.Clone(), __e => __e.Clone(__e => __e.Clone(), null));
        this.force_uav_buffer_bindings = this.force_uav_buffer_bindings.Clone(__e => __e.Clone());
        this.base_vertex_info = this.base_vertex_info.Clone();
        this.composite_selection_workaround_types = this.composite_selection_workaround_types.Clone();
    }

    public new CompilerHLSL Clone()
    {
        var __c = (CompilerHLSL)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(CompilerHLSL o)
    {
        base.CopyFrom(o);
        this.hlsl_options = o.hlsl_options.Clone();
        this.requires_op_fmod = o.requires_op_fmod;
        this.requires_fp16_packing = o.requires_fp16_packing;
        this.requires_uint2_packing = o.requires_uint2_packing;
        this.requires_explicit_fp16_packing = o.requires_explicit_fp16_packing;
        this.requires_unorm8_packing = o.requires_unorm8_packing;
        this.requires_snorm8_packing = o.requires_snorm8_packing;
        this.requires_unorm16_packing = o.requires_unorm16_packing;
        this.requires_snorm16_packing = o.requires_snorm16_packing;
        this.requires_bitfield_insert = o.requires_bitfield_insert;
        this.requires_bitfield_extract = o.requires_bitfield_extract;
        this.requires_inverse_2x2 = o.requires_inverse_2x2;
        this.requires_inverse_3x3 = o.requires_inverse_3x3;
        this.requires_inverse_4x4 = o.requires_inverse_4x4;
        this.requires_scalar_reflect = o.requires_scalar_reflect;
        this.requires_scalar_refract = o.requires_scalar_refract;
        this.requires_scalar_faceforward = o.requires_scalar_faceforward;
        this.required_texture_size_variants = o.required_texture_size_variants.Clone();
        this.require_output = o.require_output;
        this.require_input = o.require_input;
        this.remap_vertex_attributes = o.remap_vertex_attributes.Clone(__e => __e.Clone());
        this.num_workgroups_builtin = o.num_workgroups_builtin;
        this.resource_binding_flags = o.resource_binding_flags;
        this.root_constants_layout = o.root_constants_layout.Clone(__e => __e.Clone());
        this.unique_identifier_count = o.unique_identifier_count;
        this.resource_bindings = o.resource_bindings.Clone(__e => __e.Clone(), __e => __e.Clone(__e => __e.Clone(), null));
        this.force_uav_buffer_bindings = o.force_uav_buffer_bindings.Clone(__e => __e.Clone());
        this.base_vertex_info = o.base_vertex_info.Clone();
        this.composite_selection_workaround_types = o.composite_selection_workaround_types.Clone();
    }

    public partial class base_vertex_info_t
    {
        public uint register_index = 0u;
        public uint register_space = 0u;
        public bool explicit_binding = false;
        public bool used = false;

        protected virtual void FixClone()
        {
        }

        public base_vertex_info_t Clone()
        {
            var __c = (base_vertex_info_t)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(base_vertex_info_t o)
        {
            this.register_index = o.register_index;
            this.register_space = o.register_space;
            this.explicit_binding = o.explicit_binding;
            this.used = o.used;
        }
    }

    public enum BitcastType : int
    {
        TypeNormal = 0,
        TypePackUint2x32 = 1,
        TypeUnpackUint64 = 2,
    }

    public partial class IOVariable
    {
        public SPIRVariable @var;
        public uint location;
        public uint block_member_index;
        public bool block;

        protected virtual void FixClone()
        {
        }

        public IOVariable Clone()
        {
            var __c = (IOVariable)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(IOVariable o)
        {
            this.@var = o.@var;
            this.location = o.location;
            this.block_member_index = o.block_member_index;
            this.block = o.block;
        }
    }

    public partial class Options
    {
        public uint shader_model = 30u;
        public bool point_size_compat = false;
        public bool point_coord_compat = false;
        public bool support_nonzero_base_vertex_base_instance = false;
        public bool force_storage_buffer_as_uav = false;
        public bool nonwritable_uav_texture_as_srv = false;
        public bool enable_16bit_types = false;
        public bool flatten_matrix_vertex_input_semantics = false;
        public bool use_entry_point_name = false;
        public bool preserve_structured_buffers = false;
        public bool user_semantic = false;

        protected virtual void FixClone()
        {
        }

        public Options Clone()
        {
            var __c = (Options)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(Options o)
        {
            this.shader_model = o.shader_model;
            this.point_size_compat = o.point_size_compat;
            this.point_coord_compat = o.point_coord_compat;
            this.support_nonzero_base_vertex_base_instance = o.support_nonzero_base_vertex_base_instance;
            this.force_storage_buffer_as_uav = o.force_storage_buffer_as_uav;
            this.nonwritable_uav_texture_as_srv = o.nonwritable_uav_texture_as_srv;
            this.enable_16bit_types = o.enable_16bit_types;
            this.flatten_matrix_vertex_input_semantics = o.flatten_matrix_vertex_input_semantics;
            this.use_entry_point_name = o.use_entry_point_name;
            this.preserve_structured_buffers = o.preserve_structured_buffers;
            this.user_semantic = o.user_semantic;
        }
    }

    public enum TextureQueryVariantDim : int
    {
        Query1D = 0,
        Query1DArray = 1,
        Query2D = 2,
        Query2DArray = 3,
        Query3D = 4,
        QueryBuffer = 5,
        QueryCube = 6,
        QueryCubeArray = 7,
        Query2DMS = 8,
        Query2DMSArray = 9,
        QueryDimCount = 10,
    }

    public enum TextureQueryVariantType : int
    {
        QueryTypeFloat = 0,
        QueryTypeInt = 16,
        QueryTypeUInt = 32,
        QueryTypeCount = 3,
    }

    public partial class TextureSizeVariants
    {
        public TextureSizeVariants()
        {
            srv = 0UL;
            {
                foreach (ulong[] unorm in uav)
                {
                    {
                        var __r0 = unorm;
                        for (int __i1 = 0; __i1 < __r0.Length; __i1++)
                        {
                            ref ulong u = ref __r0[__i1];
                            u = 0UL;
                        }
                    }
                }
            }
        }
        public ulong srv;
        public ulong[][] uav = Std.new_jagged<ulong>(3, () => new ulong[4]);

        protected virtual void FixClone()
        {
            this.uav = Std.clone_array(this.uav, __e => Std.clone_array(__e));
        }

        public TextureSizeVariants Clone()
        {
            var __c = (TextureSizeVariants)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(TextureSizeVariants o)
        {
            this.srv = o.srv;
            this.uav = Std.clone_array(o.uav, __e => Std.clone_array(__e));
        }
    }
}
