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

public partial class SPIRVariable : IVariant
{
    public const int type = 2;
    public SPIRVariable() { }
    public SPIRVariable(TypedID_TypeType basetype_, Spv.StorageClass storage_, TypedID_TypeNone initializer_, TypedID_TypeVariable basevariable_) : base()
    {
        this.basetype = basetype_;
        this.storage = storage_;
        this.initializer = initializer_;
        this.basevariable = basevariable_;
        this.dereference_chain = new CppVector<uint>();
        this.dependees = new CppVector<TypedID_TypeNone>();
        this.debug_local_variables = new CppVector<TypedID_TypeNone>();
    }
    public SPIRVariable(TypedID_TypeType basetype_, Spv.StorageClass storage_, TypedID_TypeNone initializer_) : this(basetype_, storage_, initializer_, new TypedID_TypeVariable(0u))
    {
    }
    public SPIRVariable(TypedID_TypeType basetype_, Spv.StorageClass storage_) : this(basetype_, storage_, new TypedID_TypeNone(0u), new TypedID_TypeVariable(0u))
    {
    }
    public TypedID_TypeType basetype = new TypedID_TypeType(0u);
    public Spv.StorageClass storage = Spv.StorageClass.StorageClassGeneric;
    public uint decoration = 0u;
    public TypedID_TypeNone initializer = new TypedID_TypeNone(0u);
    public TypedID_TypeVariable basevariable = new TypedID_TypeVariable(0u);
    public CppVector<uint> dereference_chain = new CppVector<uint>();
    public bool compat_builtin = false;
    public bool statically_assigned = false;
    public TypedID_TypeNone static_expression = new TypedID_TypeNone(0u);
    public CppVector<TypedID_TypeNone> dependees = new CppVector<TypedID_TypeNone>();
    public CppVector<TypedID_TypeNone> debug_local_variables = new CppVector<TypedID_TypeNone>();
    public bool deferred_declaration = false;
    public bool phi_variable = false;
    public bool allocate_temporary_copy = false;
    public bool remapped_variable = false;
    public uint remapped_components = 0u;
    public TypedID_TypeBlock dominator = new TypedID_TypeBlock(0u);
    public bool loop_variable = false;
    public bool loop_variable_enable = false;
    public bool is_written_to = false;
    public bool untyped = false;
    public TypedID_TypeNone untyped_alloca_type = new TypedID_TypeNone(0u);
    public SPIRFunction.Parameter parameter = null;
    public override IVariant clone(ObjectPoolBase pool)
    {
        return this.Clone();
    }

    protected override void FixClone()
    {
        base.FixClone();
        this.dereference_chain = this.dereference_chain.Clone();
        this.dependees = this.dependees.Clone();
        this.debug_local_variables = this.debug_local_variables.Clone();
    }

    public new SPIRVariable Clone()
    {
        var __c = (SPIRVariable)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(SPIRVariable o)
    {
        base.CopyFrom(o);
        this.basetype = o.basetype;
        this.storage = o.storage;
        this.decoration = o.decoration;
        this.initializer = o.initializer;
        this.basevariable = o.basevariable;
        this.dereference_chain = o.dereference_chain.Clone();
        this.compat_builtin = o.compat_builtin;
        this.statically_assigned = o.statically_assigned;
        this.static_expression = o.static_expression;
        this.dependees = o.dependees.Clone();
        this.debug_local_variables = o.debug_local_variables.Clone();
        this.deferred_declaration = o.deferred_declaration;
        this.phi_variable = o.phi_variable;
        this.allocate_temporary_copy = o.allocate_temporary_copy;
        this.remapped_variable = o.remapped_variable;
        this.remapped_components = o.remapped_components;
        this.dominator = o.dominator;
        this.loop_variable = o.loop_variable;
        this.loop_variable_enable = o.loop_variable_enable;
        this.is_written_to = o.is_written_to;
        this.untyped = o.untyped;
        this.untyped_alloca_type = o.untyped_alloca_type;
        this.parameter = o.parameter;
    }
}
