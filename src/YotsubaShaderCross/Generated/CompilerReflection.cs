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
// Upstream sources: spirv_reflect.cpp, spirv_reflect.hpp
// Upstream copyright: Copyright 2018-2021 Bradley Austin Davis
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class CompilerReflection : CompilerGLSL
{
    public CompilerReflection(CppVector<uint> spirv_) : base(spirv_)
    {
        this.json_stream = null;
        options.vulkan_semantics = true;
    }
    public CompilerReflection(Ptr<uint> ir_, ulong word_count) : base(ir_, word_count)
    {
        this.json_stream = null;
        options.vulkan_semantics = true;
    }
    public CompilerReflection(ParsedIR ir_) : base(ir_)
    {
        this.json_stream = null;
        options.vulkan_semantics = true;
    }
    public void set_format(CppString format)
    {
        if (format != "json")
        {
            throw new CompilerError("Unsupported format");
        }
    }
    public override CppString compile()
    {
        json_stream = new Stream();
        json_stream.set_current_locale_radix_character(current_locale_radix_character);
        json_stream.begin_json_object();
        reorder_type_alias();
        emit_entry_points();
        emit_types();
        emit_resources();
        emit_specialization_constants();
        json_stream.end_json_object();
        return json_stream.str();
    }
    public static CppString execution_model_to_str(Spv.ExecutionModel model)
    {
        {
            switch (unchecked((int)model))
            {
                case unchecked((int)Spv.ExecutionModel.ExecutionModelVertex):
                {
                    return new CppString("vert");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl):
                {
                    return new CppString("tesc");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation):
                {
                    return new CppString("tese");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry):
                {
                    return new CppString("geom");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelFragment):
                {
                    return new CppString("frag");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute):
                {
                    return new CppString("comp");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelRayGenerationNV):
                {
                    return new CppString("rgen");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelIntersectionNV):
                {
                    return new CppString("rint");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelAnyHitNV):
                {
                    return new CppString("rahit");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelClosestHitNV):
                {
                    return new CppString("rchit");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMissNV):
                {
                    return new CppString("rmiss");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelCallableNV):
                {
                    return new CppString("rcall");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMeshNV):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT):
                {
                    return new CppString("mesh");
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTaskNV):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTaskEXT):
                {
                    return new CppString("task");
                }
                default:
                {
                    return new CppString("???");
                }
            }
        }
    }
    public void emit_entry_points()
    {
        var entries = get_entry_points_and_stages();
        if (!entries.empty())
        {
            Std.sort(Std.begin(entries), Std.end(entries), (EntryPoint a, EntryPoint b) =>
            {
                if (unchecked((int)a.execution_model) < unchecked((int)b.execution_model))
                {
                    return true;
                }
                else
                if (unchecked((int)a.execution_model) > unchecked((int)b.execution_model))
                {
                    return false;
                }
                else
                {
                    return a.name < b.name;
                }
            });
            json_stream.emit_json_key_array(new CppString("entryPoints"));
            {
                foreach (EntryPoint e in entries)
                {
                    json_stream.begin_json_object();
                    json_stream.emit_json_key_value(new CppString("name"), e.name);
                    json_stream.emit_json_key_value(new CppString("mode"), CompilerReflection.execution_model_to_str(e.execution_model));
                    if (unchecked((int)e.execution_model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute) || unchecked((int)e.execution_model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT) || unchecked((int)e.execution_model) == unchecked((int)Spv.ExecutionModel.ExecutionModelMeshNV) || unchecked((int)e.execution_model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTaskEXT) || unchecked((int)e.execution_model) == unchecked((int)Spv.ExecutionModel.ExecutionModelTaskNV))
                    {
                        var spv_entry = get_entry_point(e.name, e.execution_model);
                        SpecializationConstant spec_x = new SpecializationConstant();
                        SpecializationConstant spec_y = new SpecializationConstant();
                        SpecializationConstant spec_z = new SpecializationConstant();
                        get_work_group_size_specialization_constants(spec_x, spec_y, spec_z);
                        json_stream.emit_json_key_array(new CppString("workgroup_size"));
                        json_stream.emit_json_array_value(((uint)spec_x.id) != ((uint)new TypedID_TypeNone(0u)) ? spec_x.constant_id : spv_entry.workgroup_size.x);
                        json_stream.emit_json_array_value(((uint)spec_y.id) != ((uint)new TypedID_TypeNone(0u)) ? spec_y.constant_id : spv_entry.workgroup_size.y);
                        json_stream.emit_json_array_value(((uint)spec_z.id) != ((uint)new TypedID_TypeNone(0u)) ? spec_z.constant_id : spv_entry.workgroup_size.z);
                        json_stream.end_json_array();
                        json_stream.emit_json_key_array(new CppString("workgroup_size_is_spec_constant_id"));
                        json_stream.emit_json_array_value(((uint)spec_x.id) != ((uint)new TypedID_TypeNone(0u)));
                        json_stream.emit_json_array_value(((uint)spec_y.id) != ((uint)new TypedID_TypeNone(0u)));
                        json_stream.emit_json_array_value(((uint)spec_z.id) != ((uint)new TypedID_TypeNone(0u)));
                        json_stream.end_json_array();
                    }
                    json_stream.end_json_object();
                }
            }
            json_stream.end_json_array();
        }
    }
    public void emit_types()
    {
        bool emitted_open_tag = false;
        CppVector<uint> physical_pointee_types = new CppVector<uint>();
        ir.for_each_typed_id__SPIRType_lambda((uint self, SPIRType type) =>
        {
            if (Globals.naturally_emit_type(type))
            {
                this.emit_type(self, ref emitted_open_tag);
            }
            else
            if (this.type_is_reference(type))
            {
                if (!Globals.naturally_emit_type(this.get__SPIRType(((uint)type.parent_type))) && Std.find(physical_pointee_types.begin(), physical_pointee_types.end(), type.parent_type) == physical_pointee_types.end())
                {
                    physical_pointee_types.push_back(((uint)type.parent_type));
                }
            }
        });
        {
            foreach (uint pointee_type in physical_pointee_types)
            {
                emit_type(pointee_type, ref emitted_open_tag);
            }
        }
        if (emitted_open_tag)
        {
            json_stream.end_json_object();
        }
    }
    public new void emit_resources()
    {
        var res = get_shader_resources();
        emit_resources("subpass_inputs", res.subpass_inputs);
        emit_resources("inputs", res.stage_inputs);
        emit_resources("outputs", res.stage_outputs);
        emit_resources("textures", res.sampled_images);
        emit_resources("separate_images", res.separate_images);
        emit_resources("separate_samplers", res.separate_samplers);
        emit_resources("images", res.storage_images);
        emit_resources("ssbos", res.storage_buffers);
        emit_resources("ubos", res.uniform_buffers);
        emit_resources("push_constants", res.push_constant_buffers);
        emit_resources("counters", res.atomic_counters);
        emit_resources("acceleration_structures", res.acceleration_structures);
        emit_resources("tensors", res.tensors);
    }
    public void emit_specialization_constants()
    {
        var specialization_constants = get_specialization_constants();
        if (specialization_constants.empty())
        {
            return;
        }
        json_stream.emit_json_key_array(new CppString("specialization_constants"));
        {
            foreach (SpecializationConstant spec_const in specialization_constants)
            {
                var c = get__SPIRConstant(((uint)spec_const.id));
                var type = (get__SPIRType(((uint)c.constant_type))).Clone();
                json_stream.begin_json_object();
                json_stream.emit_json_key_value(new CppString("name"), get_name(new TypedID_TypeNone(spec_const.id)));
                json_stream.emit_json_key_value(new CppString("id"), spec_const.constant_id);
                json_stream.emit_json_key_value(new CppString("type"), type_to_glsl(type, 0u));
                json_stream.emit_json_key_value(new CppString("variable_id"), ((uint)spec_const.id));
                {
                    switch (unchecked((int)type.basetype))
                    {
                        case unchecked((int)SPIRType.BaseType.UInt):
                        {
                            json_stream.emit_json_key_value(new CppString("default_value"), c.scalar(0u, 0u));
                            break;
                        }
                        case unchecked((int)SPIRType.BaseType.Int):
                        {
                            json_stream.emit_json_key_value(new CppString("default_value"), c.scalar_i32(0u, 0u));
                            break;
                        }
                        case unchecked((int)SPIRType.BaseType.Float):
                        {
                            json_stream.emit_json_key_value(new CppString("default_value"), c.scalar_f32(0u, 0u));
                            break;
                        }
                        case unchecked((int)SPIRType.BaseType.Boolean):
                        {
                            json_stream.emit_json_key_value(new CppString("default_value"), c.scalar(0u, 0u) != 0u);
                            break;
                        }
                        default:
                        {
                            break;
                        }
                    }
                }
                json_stream.end_json_object();
            }
        }
        json_stream.end_json_array();
    }
    public void emit_type(uint type_id, ref bool emitted_open_tag)
    {
        var type = get__SPIRType(type_id);
        var name = type_to_glsl(type, 0u);
        if (!emitted_open_tag)
        {
            json_stream.emit_json_key_object(new CppString("types"));
            emitted_open_tag = true;
        }
        json_stream.emit_json_key_object("_" + Std.to_string(type_id));
        json_stream.emit_json_key_value(new CppString("name"), name);
        if (is_physical_pointer(type))
        {
            json_stream.emit_json_key_value(new CppString("type"), "_" + Std.to_string(((uint)type.parent_type)));
            json_stream.emit_json_key_value(new CppString("physical_pointer"), true);
        }
        else
        if (!type.array.empty())
        {
            emit_type_array(type);
            json_stream.emit_json_key_value(new CppString("type"), "_" + Std.to_string(((uint)type.parent_type)));
            json_stream.emit_json_key_value(new CppString("array_stride"), get_decoration(new TypedID_TypeNone(type_id), Spv.Decoration.DecorationArrayStride));
        }
        else
        {
            json_stream.emit_json_key_array(new CppString("members"));
            var size = type.member_types.size();
            {
                for (uint i = 0u; unchecked((ulong)i) < size; ++i)
                {
                    emit_type_member(type, i);
                }
            }
            json_stream.end_json_array();
        }
        json_stream.end_json_object();
    }
    public void emit_type_member(SPIRType type, uint index)
    {
        var membertype = get__SPIRType(((uint)type.member_types[unchecked((ulong)index)]));
        json_stream.begin_json_object();
        var name = to_member_name(type, index);
        json_stream.emit_json_key_value(new CppString("name"), name);
        if (type_is_reference(membertype))
        {
            json_stream.emit_json_key_value(new CppString("type"), "_" + Std.to_string(((uint)membertype.parent_type)));
        }
        else
        if (unchecked((int)membertype.basetype) == unchecked((int)SPIRType.BaseType.Struct))
        {
            json_stream.emit_json_key_value(new CppString("type"), "_" + Std.to_string(((uint)membertype.self)));
        }
        else
        {
            json_stream.emit_json_key_value(new CppString("type"), type_to_glsl(membertype, 0u));
        }
        emit_type_member_qualifiers(type, index);
        json_stream.end_json_object();
    }
    public void emit_type_member_qualifiers(SPIRType type, uint index)
    {
        var membertype = get__SPIRType(((uint)type.member_types[unchecked((ulong)index)]));
        emit_type_array(membertype);
        var memb = ir.meta[type.self].members;
        if (unchecked((ulong)index) < memb.size())
        {
            ref var dec = ref memb[unchecked((ulong)index)];
            if (dec.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationLocation)))
            {
                json_stream.emit_json_key_value(new CppString("location"), dec.location);
            }
            if (dec.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationOffset)))
            {
                json_stream.emit_json_key_value(new CppString("offset"), dec.offset);
            }
            if (has_decoration(new TypedID_TypeNone(type.member_types[unchecked((ulong)index)]), Spv.Decoration.DecorationArrayStride))
            {
                json_stream.emit_json_key_value(new CppString("array_stride"), get_decoration(new TypedID_TypeNone(type.member_types[unchecked((ulong)index)]), Spv.Decoration.DecorationArrayStride));
            }
            if (dec.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationMatrixStride)))
            {
                json_stream.emit_json_key_value(new CppString("matrix_stride"), dec.matrix_stride);
            }
            if (dec.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationRowMajor)))
            {
                json_stream.emit_json_key_value(new CppString("row_major"), true);
            }
            if (is_physical_pointer(membertype))
            {
                json_stream.emit_json_key_value(new CppString("physical_pointer"), true);
            }
        }
    }
    public void emit_type_array(SPIRType type)
    {
        if (!is_physical_pointer(type) && !type.array.empty())
        {
            json_stream.emit_json_key_array(new CppString("array"));
            {
                foreach (uint value in type.array)
                {
                    json_stream.emit_json_array_value(value);
                }
            }
            json_stream.end_json_array();
            json_stream.emit_json_key_array(new CppString("array_size_is_literal"));
            {
                foreach (var value in type.array_size_literal)
                {
                    json_stream.emit_json_array_value(value);
                }
            }
            json_stream.end_json_array();
        }
    }
    public void emit_resources(string tag, CppVector<Resource> resources)
    {
        if (resources.empty())
        {
            return;
        }
        json_stream.emit_json_key_array(new CppString(tag));
        {
            foreach (Resource res in resources)
            {
                var type = get_type(res.type_id);
                var typeflags = (ir.meta[type.self].decoration.decoration_flags).Clone();
                var mask = get_decoration_bitset(res.id);
                bool is_push_constant = unchecked((int)get_storage_class(((TypedID_TypeVariable)res.id))) == unchecked((int)Spv.StorageClass.StorageClassPushConstant);
                bool is_block = get_decoration_bitset(type.self).get(unchecked((uint)Spv.Decoration.DecorationBlock)) || get_decoration_bitset(type.self).get(unchecked((uint)Spv.Decoration.DecorationBufferBlock));
                TypedID_TypeNone fallback_id = !is_push_constant && is_block ? new TypedID_TypeNone(res.base_type_id) : res.id;
                json_stream.begin_json_object();
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
                {
                    json_stream.emit_json_key_value(new CppString("type"), "_" + Std.to_string(((uint)res.base_type_id)));
                }
                else
                {
                    json_stream.emit_json_key_value(new CppString("type"), type_to_glsl(type, 0u));
                }
                json_stream.emit_json_key_value(new CppString("name"), !res.name.empty() ? res.name : get_fallback_name(fallback_id));
                {
                    bool ssbo_block = unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) && typeflags.get(unchecked((uint)Spv.Decoration.DecorationBufferBlock));
                    Bitset qualifier_mask = ((ssbo_block ? (get_buffer_block_flags(((TypedID_TypeVariable)res.id))).Clone() : mask.Clone())).Clone();
                    if (qualifier_mask.get(unchecked((uint)Spv.Decoration.DecorationNonReadable)))
                    {
                        json_stream.emit_json_key_value(new CppString("writeonly"), true);
                    }
                    if (qualifier_mask.get(unchecked((uint)Spv.Decoration.DecorationNonWritable)))
                    {
                        json_stream.emit_json_key_value(new CppString("readonly"), true);
                    }
                    if (qualifier_mask.get(unchecked((uint)Spv.Decoration.DecorationRestrict)))
                    {
                        json_stream.emit_json_key_value(new CppString("restrict"), true);
                    }
                    if (qualifier_mask.get(unchecked((uint)Spv.Decoration.DecorationCoherent)))
                    {
                        json_stream.emit_json_key_value(new CppString("coherent"), true);
                    }
                    if (qualifier_mask.get(unchecked((uint)Spv.Decoration.DecorationVolatile)))
                    {
                        json_stream.emit_json_key_value(new CppString("volatile"), true);
                    }
                }
                emit_type_array(type);
                {
                    bool is_sized_block = is_block && (unchecked((int)get_storage_class(((TypedID_TypeVariable)res.id))) == unchecked((int)Spv.StorageClass.StorageClassUniform) || unchecked((int)get_storage_class(((TypedID_TypeVariable)res.id))) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) || unchecked((int)get_storage_class(((TypedID_TypeVariable)res.id))) == unchecked((int)Spv.StorageClass.StorageClassStorageBuffer));
                    if (is_sized_block)
                    {
                        uint block_size = unchecked((uint)get_declared_struct_size(get_type(res.base_type_id)));
                        json_stream.emit_json_key_value(new CppString("block_size"), block_size);
                    }
                }
                if (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant))
                {
                    json_stream.emit_json_key_value(new CppString("push_constant"), true);
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationLocation)))
                {
                    json_stream.emit_json_key_value(new CppString("location"), get_decoration(res.id, Spv.Decoration.DecorationLocation));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationRowMajor)))
                {
                    json_stream.emit_json_key_value(new CppString("row_major"), true);
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationColMajor)))
                {
                    json_stream.emit_json_key_value(new CppString("column_major"), true);
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationIndex)))
                {
                    json_stream.emit_json_key_value(new CppString("index"), get_decoration(res.id, Spv.Decoration.DecorationIndex));
                }
                if (unchecked((int)type.storage) != unchecked((int)Spv.StorageClass.StorageClassPushConstant) && mask.get(unchecked((uint)Spv.Decoration.DecorationDescriptorSet)))
                {
                    json_stream.emit_json_key_value(new CppString("set"), get_decoration(res.id, Spv.Decoration.DecorationDescriptorSet));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationBinding)))
                {
                    json_stream.emit_json_key_value(new CppString("binding"), get_decoration(res.id, Spv.Decoration.DecorationBinding));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationInputAttachmentIndex)))
                {
                    json_stream.emit_json_key_value(new CppString("input_attachment_index"), get_decoration(res.id, Spv.Decoration.DecorationInputAttachmentIndex));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationOffset)))
                {
                    json_stream.emit_json_key_value(new CppString("offset"), get_decoration(res.id, Spv.Decoration.DecorationOffset));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationWeightTextureQCOM)))
                {
                    json_stream.emit_json_key_value(new CppString("WeightTextureQCOM"), get_decoration(res.id, Spv.Decoration.DecorationWeightTextureQCOM));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationBlockMatchTextureQCOM)))
                {
                    json_stream.emit_json_key_value(new CppString("BlockMatchTextureQCOM"), get_decoration(res.id, Spv.Decoration.DecorationBlockMatchTextureQCOM));
                }
                if (mask.get(unchecked((uint)Spv.Decoration.DecorationBlockMatchSamplerQCOM)))
                {
                    json_stream.emit_json_key_value(new CppString("BlockMatchSamplerQCOM"), get_decoration(res.id, Spv.Decoration.DecorationBlockMatchSamplerQCOM));
                }
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) && type.image.sampled == 2u)
                {
                    string fmt = format_to_glsl(type.image.format);
                    if (fmt != null)
                    {
                        json_stream.emit_json_key_value(new CppString("format"), new CppString(fmt));
                    }
                }
                json_stream.end_json_object();
            }
        }
        json_stream.end_json_array();
    }
    public bool type_is_reference(SPIRType type)
    {
        return is_physical_pointer(type) || type_is_array_of_pointers(type) && unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer);
    }
    public new CppString to_member_name(SPIRType type, uint index)
    {
        var type_meta = ir.find_meta(type.self);
        if (type_meta != null)
        {
            var memb = type_meta.members;
            if (unchecked((ulong)index) < memb.size() && !memb[unchecked((ulong)index)].alias.empty())
            {
                return memb[unchecked((ulong)index)].alias;
            }
            else
            {
                return Std.join("_m", index);
            }
        }
        else
        {
            return Std.join("_m", index);
        }
    }
    public Stream json_stream;

    protected override void FixClone()
    {
        base.FixClone();
    }

    public new CompilerReflection Clone()
    {
        var __c = (CompilerReflection)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(CompilerReflection o)
    {
        base.CopyFrom(o);
        this.json_stream = o.json_stream;
    }
}
