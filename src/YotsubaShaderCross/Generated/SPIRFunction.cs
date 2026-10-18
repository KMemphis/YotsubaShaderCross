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
// Upstream sources: spirv_common.hpp
// Upstream copyright: Copyright 2015-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class SPIRFunction : IVariant
{
    public const int type = 4;
    public SPIRFunction(TypedID_TypeType return_type_, uint function_control_, TypedID_TypeType function_type_) : base()
    {
        this.return_type = return_type_;
        this.function_control = function_control_;
        this.function_type = function_type_;
        this.arguments = new CppVector<SPIRFunction.Parameter>();
        this.shadow_arguments = new CppVector<SPIRFunction.Parameter>();
        this.local_variables = new CppVector<TypedID_TypeVariable>();
        this.blocks = new CppVector<TypedID_TypeBlock>();
        this.combined_parameters = new CppVector<SPIRFunction.CombinedImageSamplerParameter>();
        this.entry_line = new SPIRFunction.EntryLine();
        this.fixup_hooks_out = new CppVector<Action>();
        this.fixup_hooks_in = new CppVector<Action>();
        this.constant_arrays_needed_on_stack = new CppVector<TypedID_TypeNone>();
    }
    public TypedID_TypeType return_type;
    public uint function_control;
    public TypedID_TypeType function_type;
    public CppVector<SPIRFunction.Parameter> arguments = new CppVector<SPIRFunction.Parameter>();
    public CppVector<SPIRFunction.Parameter> shadow_arguments = new CppVector<SPIRFunction.Parameter>();
    public CppVector<TypedID_TypeVariable> local_variables = new CppVector<TypedID_TypeVariable>();
    public TypedID_TypeBlock entry_block = new TypedID_TypeBlock(0u);
    public CppVector<TypedID_TypeBlock> blocks = new CppVector<TypedID_TypeBlock>();
    public CppVector<SPIRFunction.CombinedImageSamplerParameter> combined_parameters = new CppVector<SPIRFunction.CombinedImageSamplerParameter>();
    public SPIRFunction.EntryLine entry_line = new SPIRFunction.EntryLine();
    public void add_local_variable(TypedID_TypeVariable id)
    {
        local_variables.push_back(id);
    }
    public void add_parameter(TypedID_TypeType parameter_type, TypedID_TypeNone id, bool alias_global_variable = false)
    {
        arguments.push_back(new SPIRFunction.Parameter { type = parameter_type, id = id, read_count = 0u, write_count = 0u, alias_global_variable = alias_global_variable });
    }
    public CppVector<Action> fixup_hooks_out = new CppVector<Action>();
    public CppVector<Action> fixup_hooks_in = new CppVector<Action>();
    public CppVector<TypedID_TypeNone> constant_arrays_needed_on_stack = new CppVector<TypedID_TypeNone>();
    public bool emits_geometry = false;
    public bool active = false;
    public bool flush_undeclared = true;
    public bool do_combined_parameters = true;
    public override IVariant clone(ObjectPoolBase pool)
    {
        return this.Clone();
    }

    protected override void FixClone()
    {
        base.FixClone();
        this.arguments = this.arguments.Clone(__e => __e.Clone());
        this.shadow_arguments = this.shadow_arguments.Clone(__e => __e.Clone());
        this.local_variables = this.local_variables.Clone();
        this.blocks = this.blocks.Clone();
        this.combined_parameters = this.combined_parameters.Clone(__e => __e.Clone());
        this.entry_line = this.entry_line.Clone();
        this.fixup_hooks_out = this.fixup_hooks_out.Clone();
        this.fixup_hooks_in = this.fixup_hooks_in.Clone();
        this.constant_arrays_needed_on_stack = this.constant_arrays_needed_on_stack.Clone();
    }

    public new SPIRFunction Clone()
    {
        var __c = (SPIRFunction)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(SPIRFunction o)
    {
        base.CopyFrom(o);
        this.return_type = o.return_type;
        this.function_control = o.function_control;
        this.function_type = o.function_type;
        this.arguments = o.arguments.Clone(__e => __e.Clone());
        this.shadow_arguments = o.shadow_arguments.Clone(__e => __e.Clone());
        this.local_variables = o.local_variables.Clone();
        this.entry_block = o.entry_block;
        this.blocks = o.blocks.Clone();
        this.combined_parameters = o.combined_parameters.Clone(__e => __e.Clone());
        this.entry_line = o.entry_line.Clone();
        this.fixup_hooks_out = o.fixup_hooks_out.Clone();
        this.fixup_hooks_in = o.fixup_hooks_in.Clone();
        this.constant_arrays_needed_on_stack = o.constant_arrays_needed_on_stack.Clone();
        this.emits_geometry = o.emits_geometry;
        this.active = o.active;
        this.flush_undeclared = o.flush_undeclared;
        this.do_combined_parameters = o.do_combined_parameters;
    }

    public partial class CombinedImageSamplerParameter
    {
        public TypedID_TypeVariable id;
        public TypedID_TypeVariable image_id;
        public TypedID_TypeVariable sampler_id;
        public bool global_image;
        public bool global_sampler;
        public bool depth;

        protected virtual void FixClone()
        {
        }

        public CombinedImageSamplerParameter Clone()
        {
            var __c = (CombinedImageSamplerParameter)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(CombinedImageSamplerParameter o)
        {
            this.id = o.id;
            this.image_id = o.image_id;
            this.sampler_id = o.sampler_id;
            this.global_image = o.global_image;
            this.global_sampler = o.global_sampler;
            this.depth = o.depth;
        }
    }

    public partial class EntryLine
    {
        public uint file_id = 0u;
        public uint line_literal = 0u;

        protected virtual void FixClone()
        {
        }

        public EntryLine Clone()
        {
            var __c = (EntryLine)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(EntryLine o)
        {
            this.file_id = o.file_id;
            this.line_literal = o.line_literal;
        }
    }

    public partial class Parameter
    {
        public TypedID_TypeType type;
        public TypedID_TypeNone id;
        public uint read_count;
        public uint write_count;
        public bool alias_global_variable;

        protected virtual void FixClone()
        {
        }

        public Parameter Clone()
        {
            var __c = (Parameter)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(Parameter o)
        {
            this.type = o.type;
            this.id = o.id;
            this.read_count = o.read_count;
            this.write_count = o.write_count;
            this.alias_global_variable = o.alias_global_variable;
        }
    }
}
