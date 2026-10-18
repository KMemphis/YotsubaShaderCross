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

public partial class SPIRExpression : IVariant
{
    public const int type = 8;
    public SPIRExpression(CppString expr, TypedID_TypeType expression_type_, bool immutable_) : base()
    {
        this.expression = expr;
        this.expression_type = expression_type_;
        this.immutable = immutable_;
        this.buffer_pointer_dependees = new CppVector<TypedID_TypeNone>();
        this.expression_dependencies = new CppVector<TypedID_TypeNone>();
        this.invariance_dependencies = new CppVector<TypedID_TypeNone>();
        this.implied_read_expressions = new CppVector<TypedID_TypeNone>();
    }
    public TypedID_TypeNone base_expression = new TypedID_TypeNone(0u);
    public CppString expression;
    public TypedID_TypeType expression_type = new TypedID_TypeType(0u);
    public TypedID_TypeNone loaded_from = new TypedID_TypeNone(0u);
    public bool immutable = false;
    public bool need_transpose = false;
    public bool access_chain = false;
    public bool access_meshlet_position_y = false;
    public bool buffer_pointer = false;
    public CppVector<TypedID_TypeNone> buffer_pointer_dependees = new CppVector<TypedID_TypeNone>();
    public CppVector<TypedID_TypeNone> expression_dependencies = new CppVector<TypedID_TypeNone>();
    public CppVector<TypedID_TypeNone> invariance_dependencies = new CppVector<TypedID_TypeNone>();
    public CppVector<TypedID_TypeNone> implied_read_expressions = new CppVector<TypedID_TypeNone>();
    public uint emitted_loop_level = 0u;
    public override IVariant clone(ObjectPoolBase pool)
    {
        return this.Clone();
    }

    protected override void FixClone()
    {
        base.FixClone();
        this.buffer_pointer_dependees = this.buffer_pointer_dependees.Clone();
        this.expression_dependencies = this.expression_dependencies.Clone();
        this.invariance_dependencies = this.invariance_dependencies.Clone();
        this.implied_read_expressions = this.implied_read_expressions.Clone();
    }

    public new SPIRExpression Clone()
    {
        var __c = (SPIRExpression)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(SPIRExpression o)
    {
        base.CopyFrom(o);
        this.base_expression = o.base_expression;
        this.expression = o.expression;
        this.expression_type = o.expression_type;
        this.loaded_from = o.loaded_from;
        this.immutable = o.immutable;
        this.need_transpose = o.need_transpose;
        this.access_chain = o.access_chain;
        this.access_meshlet_position_y = o.access_meshlet_position_y;
        this.buffer_pointer = o.buffer_pointer;
        this.buffer_pointer_dependees = o.buffer_pointer_dependees.Clone();
        this.expression_dependencies = o.expression_dependencies.Clone();
        this.invariance_dependencies = o.invariance_dependencies.Clone();
        this.implied_read_expressions = o.implied_read_expressions.Clone();
        this.emitted_loop_level = o.emitted_loop_level;
    }
}
