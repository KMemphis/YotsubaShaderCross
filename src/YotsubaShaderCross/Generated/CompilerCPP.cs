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
// Upstream sources: spirv_cpp.cpp, spirv_cpp.hpp
// Upstream copyright: Copyright 2015-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class CompilerCPP : CompilerGLSL
{
    public CompilerCPP(CppVector<uint> spirv_) : base(spirv_)
    {
        this.resource_registrations = new CppVector<CppString>();
        this.impl_type = default(CppString);
        this.resource_type = default(CppString);
        this.interface_name = default(CppString);
    }
    public CompilerCPP(Ptr<uint> ir_, ulong word_count) : base(ir_, word_count)
    {
        this.resource_registrations = new CppVector<CppString>();
        this.impl_type = default(CppString);
        this.resource_type = default(CppString);
        this.interface_name = default(CppString);
    }
    public CompilerCPP(ParsedIR ir_) : base(ir_)
    {
        this.resource_registrations = new CppVector<CppString>();
        this.impl_type = default(CppString);
        this.resource_type = default(CppString);
        this.interface_name = default(CppString);
    }
    public new CppString compile()
    {
        ir.fixup_reserved_names();
        options.es = false;
        options.version = 450u;
        backend.float_literal_suffix = true;
        backend.double_literal_suffix = false;
        backend.long_long_literal_suffix = true;
        backend.uint32_t_literal_suffix = true;
        backend.basic_int_type = "int32_t";
        backend.basic_uint_type = "uint32_t";
        backend.swizzle_is_function = true;
        backend.shared_is_implied = true;
        backend.unsized_array_supported = false;
        backend.explicit_struct_type = true;
        backend.use_initializer_list = true;
        fixup_type_alias();
        reorder_type_alias();
        build_function_control_flow_graphs_and_analyze();
        update_active_builtins();
        uint pass_count = 0u;
        do
        {
            resource_registrations.clear();
            reset(pass_count);
            buffer.reset();
            emit_header();
            emit_resources();
            emit_function(get__SPIRFunction(((uint)ir.default_entry_point)), new Bitset());
            pass_count++;
        }
        while (is_forcing_recompilation());
        end_scope_decl();
        end_scope();
        emit_c_linkage();
        get_entry_point().name = "main";
        return buffer.str();
    }
    public void set_interface_name(CppString name)
    {
        interface_name = name;
    }
    public override void emit_header()
    {
        var execution = get_entry_point();
        statement("// This C++ shader is autogenerated by spirv-cross.");
        statement("#include \"spirv_cross/internal_interface.hpp\"");
        statement("#include \"spirv_cross/external_interface.h\"");
        statement("#include <array>");
        statement("#include <stdint.h>");
        statement("");
        statement("using namespace spirv_cross;");
        statement("using namespace glm;");
        statement("");
        statement("namespace Impl");
        begin_scope();
        {
            switch (unchecked((int)execution.model))
            {
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelFragment):
                case unchecked((int)Spv.ExecutionModel.ExecutionModelVertex):
                {
                    statement("struct Shader");
                    begin_scope();
                    break;
                }
                default:
                {
                    throw new CompilerError("Unsupported execution model.");
                }
            }
        }
        {
            switch (unchecked((int)execution.model))
            {
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry):
                {
                    impl_type = "GeometryShader<Impl::Shader, Impl::Shader::Resources>";
                    resource_type = "GeometryResources";
                    break;
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelVertex):
                {
                    impl_type = "VertexShader<Impl::Shader, Impl::Shader::Resources>";
                    resource_type = "VertexResources";
                    break;
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelFragment):
                {
                    impl_type = "FragmentShader<Impl::Shader, Impl::Shader::Resources>";
                    resource_type = "FragmentResources";
                    break;
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute):
                {
                    impl_type = Std.join("ComputeShader<Impl::Shader, Impl::Shader::Resources, ", execution.workgroup_size.x, ", ", execution.workgroup_size.y, ", ", execution.workgroup_size.z, ">");
                    resource_type = "ComputeResources";
                    break;
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl):
                {
                    impl_type = "TessControlShader<Impl::Shader, Impl::Shader::Resources>";
                    resource_type = "TessControlResources";
                    break;
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation):
                {
                    impl_type = "TessEvaluationShader<Impl::Shader, Impl::Shader::Resources>";
                    resource_type = "TessEvaluationResources";
                    break;
                }
                default:
                {
                    throw new CompilerError("Unsupported execution model.");
                }
            }
        }
    }
    public void emit_c_linkage()
    {
        statement("");
        statement("spirv_cross_shader_t *spirv_cross_construct(void)");
        begin_scope();
        statement("return new ", impl_type, "();");
        end_scope();
        statement("");
        statement("void spirv_cross_destruct(spirv_cross_shader_t *shader)");
        begin_scope();
        statement("delete static_cast<", impl_type, "*>(shader);");
        end_scope();
        statement("");
        statement("void spirv_cross_invoke(spirv_cross_shader_t *shader)");
        begin_scope();
        statement("static_cast<", impl_type, "*>(shader)->invoke();");
        end_scope();
        statement("");
        statement("static const struct spirv_cross_interface vtable =");
        begin_scope();
        statement("spirv_cross_construct,");
        statement("spirv_cross_destruct,");
        statement("spirv_cross_invoke,");
        end_scope_decl();
        statement("");
        statement("const struct spirv_cross_interface *", interface_name.empty() ? new CppString("spirv_cross_get_interface") : interface_name, "(void)");
        begin_scope();
        statement("return &vtable;");
        end_scope();
    }
    public override void emit_function_prototype(SPIRFunction func, Bitset _p0)
    {
        if (((uint)func.self) != ((uint)ir.default_entry_point))
        {
            add_function_overload(func);
        }
        local_variable_names.CopyFrom(resource_names.Clone());
        CppString decl = default(CppString);
        var type = get__SPIRType(((uint)func.return_type));
        decl += "inline ";
        decl += type_to_glsl(type, 0u);
        decl += " ";
        if (((uint)func.self) == ((uint)ir.default_entry_point))
        {
            decl += "main";
            processing_entry_point = true;
        }
        else
        {
            decl += to_name(((uint)func.self), true);
        }
        decl += "(";
        {
            foreach (SPIRFunction.Parameter arg in func.arguments)
            {
                add_local_variable_name(((uint)arg.id));
                decl += argument_decl(arg);
                if (arg != func.arguments.back())
                {
                    decl += ", ";
                }
                var @var = maybe_get__SPIRVariable(((uint)arg.id));
                if (@var != null)
                {
                    @var.parameter = arg;
                }
            }
        }
        decl += ")";
        statement(decl);
    }
    public new void emit_resources()
    {
        {
            foreach (Variant id in ir.ids)
            {
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeConstant))
                {
                    var c = id.get__SPIRConstant();
                    bool needs_declaration = c.specialization || c.is_used_as_lut;
                    if (needs_declaration)
                    {
                        if (!options.vulkan_semantics && c.specialization)
                        {
                            c.specialization_constant_macro_name = constant_value_macro_name(get_decoration(c.self, Spv.Decoration.DecorationSpecId));
                        }
                        emit_constant(c);
                    }
                }
                else
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeConstantOp))
                {
                    emit_specialization_constant_op(id.get__SPIRConstantOp());
                }
            }
        }
        {
            foreach (Variant id in ir.ids)
            {
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeType))
                {
                    var type = id.get__SPIRType();
                    if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct) && type.array.empty() && !type.pointer && (!ir.meta[type.self].decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBlock)) && !ir.meta[type.self].decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBufferBlock))))
                    {
                        emit_struct(type);
                    }
                }
            }
        }
        statement("struct Resources : ", resource_type);
        begin_scope();
        {
            foreach (Variant id in ir.ids)
            {
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeVariable))
                {
                    var @var = id.get__SPIRVariable();
                    var type = get__SPIRType(((uint)@var.basetype));
                    if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && type.pointer && unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniform) && !is_hidden_variable(@var, false) && (ir.meta[type.self].decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBlock)) || ir.meta[type.self].decoration.decoration_flags.get(unchecked((uint)Spv.Decoration.DecorationBufferBlock))))
                    {
                        emit_buffer_block(@var);
                    }
                }
            }
        }
        {
            foreach (Variant id in ir.ids)
            {
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeVariable))
                {
                    var @var = id.get__SPIRVariable();
                    var type = get__SPIRType(((uint)@var.basetype));
                    if (!is_hidden_variable(@var, false) && unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && type.pointer && unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassPushConstant))
                    {
                        emit_push_constant_block(@var);
                    }
                }
            }
        }
        {
            foreach (Variant id in ir.ids)
            {
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeVariable))
                {
                    var @var = id.get__SPIRVariable();
                    var type = get__SPIRType(((uint)@var.basetype));
                    if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && !is_hidden_variable(@var, false) && type.pointer && (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) || unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassOutput)) && interface_variable_exists_in_entry_point(((uint)@var.self)))
                    {
                        emit_interface_block(@var);
                    }
                }
            }
        }
        {
            foreach (Variant id in ir.ids)
            {
                if (unchecked((int)id.get_type()) == unchecked((int)Types.TypeVariable))
                {
                    var @var = id.get__SPIRVariable();
                    var type = get__SPIRType(((uint)@var.basetype));
                    if (unchecked((int)@var.storage) != unchecked((int)Spv.StorageClass.StorageClassFunction) && !is_hidden_variable(@var, false) && type.pointer && (unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassUniformConstant) || unchecked((int)type.storage) == unchecked((int)Spv.StorageClass.StorageClassAtomicCounter)))
                    {
                        emit_uniform(@var);
                    }
                }
            }
        }
        bool emitted = false;
        {
            foreach (uint global in global_variables)
            {
                var @var = get__SPIRVariable(global);
                if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassWorkgroup))
                {
                    emit_shared(@var);
                    emitted = true;
                }
            }
        }
        if (emitted)
        {
            statement("");
        }
        statement("inline void init(spirv_cross_shader& s)");
        begin_scope();
        statement(resource_type, "::init(s);");
        {
            var __r0 = resource_registrations;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref CppString reg = ref __r0[__i1];
                statement(reg);
            }
        }
        end_scope();
        resource_registrations.clear();
        end_scope_decl();
        statement("");
        statement("Resources* __res;");
        if (unchecked((int)get_entry_point().model) == unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute))
        {
            statement("ComputePrivateResources __priv_res;");
        }
        statement("");
        emitted = false;
        {
            foreach (uint global in global_variables)
            {
                var @var = get__SPIRVariable(global);
                if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassPrivate))
                {
                    if (unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassWorkgroup))
                    {
                        emit_shared(@var);
                    }
                    else
                    {
                        statement(base.variable_decl(@var), ";");
                    }
                    emitted = true;
                }
            }
        }
        if (emitted)
        {
            statement("");
        }
    }
    public override void emit_buffer_block(SPIRVariable @var)
    {
        add_resource_name(((uint)@var.self));
        var type = get__SPIRType(((uint)@var.basetype));
        var instance_name = to_name(((uint)@var.self), true);
        uint descriptor_set = ir.meta[@var.self].decoration.set;
        uint binding = ir.meta[@var.self].decoration.binding;
        emit_block_struct(type);
        var buffer_name = to_name(((uint)type.self), true);
        statement("internal::Resource<", buffer_name, type_to_array_glsl(type, ((uint)@var.self)), "> ", instance_name, "__;");
        statement_no_indent("#define ", instance_name, " __res->", instance_name, "__.get()");
        resource_registrations.push_back(Std.join("s.register_resource(", instance_name, "__", ", ", descriptor_set, ", ", binding, ");"));
        statement("");
    }
    public override void emit_push_constant_block(SPIRVariable @var)
    {
        add_resource_name(((uint)@var.self));
        var type = get__SPIRType(((uint)@var.basetype));
        var flags = ir.meta[@var.self].decoration.decoration_flags;
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationBinding)) || flags.get(unchecked((uint)Spv.Decoration.DecorationDescriptorSet)))
        {
            throw new CompilerError("Push constant blocks cannot be compiled to GLSL with Binding or Set syntax. Remap to location with reflection API first or disable these decorations.");
        }
        emit_block_struct(type);
        var buffer_name = to_name(((uint)type.self), true);
        var instance_name = to_name(((uint)@var.self), true);
        statement("internal::PushConstant<", buffer_name, type_to_array_glsl(type, ((uint)@var.self)), "> ", instance_name, ";");
        statement_no_indent("#define ", instance_name, " __res->", instance_name, ".get()");
        resource_registrations.push_back(Std.join("s.register_push_constant(", instance_name, "__", ");"));
        statement("");
    }
    public new void emit_interface_block(SPIRVariable @var)
    {
        add_resource_name(((uint)@var.self));
        var type = get__SPIRType(((uint)@var.basetype));
        string qual = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) ? "StageInput" : "StageOutput";
        string lowerqual = unchecked((int)@var.storage) == unchecked((int)Spv.StorageClass.StorageClassInput) ? "stage_input" : "stage_output";
        var instance_name = to_name(((uint)@var.self), true);
        uint location = ir.meta[@var.self].decoration.location;
        CppString buffer_name = default(CppString);
        var flags = (ir.meta[type.self].decoration.decoration_flags).Clone();
        if (flags.get(unchecked((uint)Spv.Decoration.DecorationBlock)))
        {
            emit_block_struct(type);
            buffer_name = to_name(((uint)type.self), true);
        }
        else
        {
            buffer_name = type_to_glsl(type, 0u);
        }
        statement("internal::", qual, "<", buffer_name, type_to_array_glsl(type, ((uint)@var.self)), "> ", instance_name, "__;");
        statement_no_indent("#define ", instance_name, " __res->", instance_name, "__.get()");
        resource_registrations.push_back(Std.join("s.register_", lowerqual, "(", instance_name, "__", ", ", location, ");"));
        statement("");
    }
    public new void emit_block_chain(SPIRBlock block)
    {
        throw new System.NotImplementedException();
    }
    public override void emit_uniform(SPIRVariable @var)
    {
        add_resource_name(((uint)@var.self));
        var type = get__SPIRType(((uint)@var.basetype));
        var instance_name = to_name(((uint)@var.self), true);
        uint descriptor_set = ir.meta[@var.self].decoration.set;
        uint binding = ir.meta[@var.self].decoration.binding;
        uint location = ir.meta[@var.self].decoration.location;
        CppString type_name = type_to_glsl(type, 0u);
        remap_variable_type_name(type, instance_name, ref type_name);
        if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Image) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.SampledImage) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.AtomicCounter))
        {
            statement("internal::Resource<", type_name, type_to_array_glsl(type, ((uint)@var.self)), "> ", instance_name, "__;");
            statement_no_indent("#define ", instance_name, " __res->", instance_name, "__.get()");
            resource_registrations.push_back(Std.join("s.register_resource(", instance_name, "__", ", ", descriptor_set, ", ", binding, ");"));
        }
        else
        {
            statement("internal::UniformConstant<", type_name, type_to_array_glsl(type, ((uint)@var.self)), "> ", instance_name, "__;");
            statement_no_indent("#define ", instance_name, " __res->", instance_name, "__.get()");
            resource_registrations.push_back(Std.join("s.register_uniform_constant(", instance_name, "__", ", ", location, ");"));
        }
        statement("");
    }
    public void emit_shared(SPIRVariable @var)
    {
        add_resource_name(((uint)@var.self));
        var instance_name = to_name(((uint)@var.self), true);
        statement(base.variable_decl(@var), ";");
        statement_no_indent("#define ", instance_name, " __res->", instance_name);
    }
    public void emit_block_struct(SPIRType type)
    {
        var self = get__SPIRType(((uint)type.self));
        self.type_alias = new TypedID_TypeType(0u);
        emit_struct(self);
    }
    public override CppString variable_decl(SPIRType type, CppString name, uint _p0)
    {
        CppString @base = type_to_glsl(type, 0u);
        remap_variable_type_name(type, name, ref @base);
        bool runtime = false;
        {
            for (uint i = 0u; unchecked((ulong)i) < type.array.size(); i++)
            {
                var array = type.array[unchecked((ulong)i)];
                if (!(array != 0u) && type.array_size_literal[unchecked((ulong)i)])
                {
                    runtime = true;
                }
                else
                {
                    @base = Std.join("std::array<", @base, ", ", to_array_size(type, i), ">");
                }
            }
        }
        @base += ' ';
        return @base + name + (runtime ? "[1]" : "");
    }
    public new CppString argument_decl(SPIRFunction.Parameter arg)
    {
        var type = expression_type(((uint)arg.id));
        bool constref = !type.pointer || arg.write_count == 0u;
        var @var = get__SPIRVariable(((uint)arg.id));
        CppString @base = type_to_glsl(type, 0u);
        CppString variable_name = to_name(((uint)@var.self), true);
        remap_variable_type_name(type, variable_name, ref @base);
        {
            for (uint i = 0u; unchecked((ulong)i) < type.array.size(); i++)
            {
                @base = Std.join("std::array<", @base, ", ", to_array_size(type, i), ">");
            }
        }
        return Std.join(constref ? "const " : "", @base, " &", variable_name);
    }
    public CppVector<CppString> resource_registrations = new CppVector<CppString>();
    public CppString impl_type;
    public CppString resource_type;
    public uint shared_counter = 0u;
    public CppString interface_name;

    protected override void FixClone()
    {
        base.FixClone();
        this.resource_registrations = this.resource_registrations.Clone();
    }

    public new CompilerCPP Clone()
    {
        var __c = (CompilerCPP)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(CompilerCPP o)
    {
        base.CopyFrom(o);
        this.resource_registrations = o.resource_registrations.Clone();
        this.impl_type = o.impl_type;
        this.resource_type = o.resource_type;
        this.shared_counter = o.shared_counter;
        this.interface_name = o.interface_name;
    }
}
