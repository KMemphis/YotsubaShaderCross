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

public partial class SPIRBlock : IVariant
{
    public const int type = 6;
    public const uint NoDominator = 4294967295u;
    public SPIRBlock.Terminator terminator = SPIRBlock.Terminator.Unknown;
    public SPIRBlock.Merge merge = SPIRBlock.Merge.MergeNone;
    public SPIRBlock.Hints hint = SPIRBlock.Hints.HintNone;
    public TypedID_TypeBlock next_block = new TypedID_TypeBlock(0u);
    public TypedID_TypeBlock merge_block = new TypedID_TypeBlock(0u);
    public TypedID_TypeBlock continue_block = new TypedID_TypeBlock(0u);
    public TypedID_TypeNone return_value = new TypedID_TypeNone(0u);
    public TypedID_TypeNone condition = new TypedID_TypeNone(0u);
    public TypedID_TypeBlock true_block = new TypedID_TypeBlock(0u);
    public TypedID_TypeBlock false_block = new TypedID_TypeBlock(0u);
    public TypedID_TypeBlock default_block = new TypedID_TypeBlock(0u);
    public SPIRBlock.mesh_t mesh = new SPIRBlock.mesh_t { groups = new TypedID_TypeNone[3], payload = new TypedID_TypeNone() };
    public SPIRBlock.shader_abort_t shader_abort = new SPIRBlock.shader_abort_t { physical_type = new TypedID_TypeType(), payload = new TypedID_TypeNone() };
    public CppVector<Instruction> ops = new CppVector<Instruction>();
    public CppVector<SPIRBlock.Phi> phi_variables = new CppVector<SPIRBlock.Phi>();
    public CppVector<Pair<TypedID_TypeType, TypedID_TypeNone>> declare_temporary = new CppVector<Pair<TypedID_TypeType, TypedID_TypeNone>>();
    public CppVector<Pair<TypedID_TypeType, TypedID_TypeNone>> potential_declare_temporary = new CppVector<Pair<TypedID_TypeType, TypedID_TypeNone>>();
    public CppVector<SPIRBlock.Case> cases_32bit = new CppVector<SPIRBlock.Case>();
    public CppVector<SPIRBlock.Case> cases_64bit = new CppVector<SPIRBlock.Case>();
    public bool disable_block_optimization = false;
    public bool complex_continue = false;
    public bool need_ladder_break = false;
    public TypedID_TypeBlock ignore_phi_from_block = new TypedID_TypeBlock(0u);
    public TypedID_TypeBlock loop_dominator = new TypedID_TypeBlock(0u);
    public CppVector<TypedID_TypeVariable> dominated_variables = new CppVector<TypedID_TypeVariable>();
    public CppVector<bool> rearm_dominated_variables = new CppVector<bool>();
    public CppVector<TypedID_TypeVariable> loop_variables = new CppVector<TypedID_TypeVariable>();
    public CppVector<TypedID_TypeNone> invalidate_expressions = new CppVector<TypedID_TypeNone>();
    public override IVariant clone(ObjectPoolBase pool)
    {
        return this.Clone();
    }

    protected override void FixClone()
    {
        base.FixClone();
        this.mesh = this.mesh.Clone();
        this.shader_abort = this.shader_abort.Clone();
        this.ops = this.ops.Clone(__e => __e.Clone());
        this.phi_variables = this.phi_variables.Clone(__e => __e.Clone());
        this.declare_temporary = this.declare_temporary.Clone(__e => __e.Clone());
        this.potential_declare_temporary = this.potential_declare_temporary.Clone(__e => __e.Clone());
        this.cases_32bit = this.cases_32bit.Clone(__e => __e.Clone());
        this.cases_64bit = this.cases_64bit.Clone(__e => __e.Clone());
        this.dominated_variables = this.dominated_variables.Clone();
        this.rearm_dominated_variables = this.rearm_dominated_variables.Clone();
        this.loop_variables = this.loop_variables.Clone();
        this.invalidate_expressions = this.invalidate_expressions.Clone();
    }

    public new SPIRBlock Clone()
    {
        var __c = (SPIRBlock)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(SPIRBlock o)
    {
        base.CopyFrom(o);
        this.terminator = o.terminator;
        this.merge = o.merge;
        this.hint = o.hint;
        this.next_block = o.next_block;
        this.merge_block = o.merge_block;
        this.continue_block = o.continue_block;
        this.return_value = o.return_value;
        this.condition = o.condition;
        this.true_block = o.true_block;
        this.false_block = o.false_block;
        this.default_block = o.default_block;
        this.mesh = o.mesh.Clone();
        this.shader_abort = o.shader_abort.Clone();
        this.ops = o.ops.Clone(__e => __e.Clone());
        this.phi_variables = o.phi_variables.Clone(__e => __e.Clone());
        this.declare_temporary = o.declare_temporary.Clone(__e => __e.Clone());
        this.potential_declare_temporary = o.potential_declare_temporary.Clone(__e => __e.Clone());
        this.cases_32bit = o.cases_32bit.Clone(__e => __e.Clone());
        this.cases_64bit = o.cases_64bit.Clone(__e => __e.Clone());
        this.disable_block_optimization = o.disable_block_optimization;
        this.complex_continue = o.complex_continue;
        this.need_ladder_break = o.need_ladder_break;
        this.ignore_phi_from_block = o.ignore_phi_from_block;
        this.loop_dominator = o.loop_dominator;
        this.dominated_variables = o.dominated_variables.Clone();
        this.rearm_dominated_variables = o.rearm_dominated_variables.Clone();
        this.loop_variables = o.loop_variables.Clone();
        this.invalidate_expressions = o.invalidate_expressions.Clone();
    }

    public partial class Case
    {
        public ulong value;
        public TypedID_TypeBlock block;

        protected virtual void FixClone()
        {
        }

        public Case Clone()
        {
            var __c = (Case)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(Case o)
        {
            this.value = o.value;
            this.block = o.block;
        }
    }

    public enum ContinueBlockType : int
    {
        ContinueNone = 0,
        ForLoop = 1,
        WhileLoop = 2,
        DoWhileLoop = 3,
        ComplexLoop = 4,
    }

    public enum Hints : int
    {
        HintNone = 0,
        HintUnroll = 1,
        HintDontUnroll = 2,
        HintFlatten = 3,
        HintDontFlatten = 4,
    }

    public enum Merge : int
    {
        MergeNone = 0,
        MergeLoop = 1,
        MergeSelection = 2,
    }

    public partial class mesh_t
    {
        public TypedID_TypeNone[] groups = new TypedID_TypeNone[3];
        public TypedID_TypeNone payload;

        protected virtual void FixClone()
        {
            this.groups = Std.clone_array(this.groups);
        }

        public mesh_t Clone()
        {
            var __c = (mesh_t)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(mesh_t o)
        {
            this.groups = Std.clone_array(o.groups);
            this.payload = o.payload;
        }
    }

    public enum Method : int
    {
        MergeToSelectForLoop = 0,
        MergeToDirectForLoop = 1,
        MergeToSelectContinueForLoop = 2,
    }

    public partial class Phi
    {
        public TypedID_TypeNone local_variable;
        public TypedID_TypeBlock parent;
        public TypedID_TypeVariable function_variable;

        protected virtual void FixClone()
        {
        }

        public Phi Clone()
        {
            var __c = (Phi)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(Phi o)
        {
            this.local_variable = o.local_variable;
            this.parent = o.parent;
            this.function_variable = o.function_variable;
        }
    }

    public partial class shader_abort_t
    {
        public TypedID_TypeType physical_type;
        public TypedID_TypeNone payload;

        protected virtual void FixClone()
        {
        }

        public shader_abort_t Clone()
        {
            var __c = (shader_abort_t)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(shader_abort_t o)
        {
            this.physical_type = o.physical_type;
            this.payload = o.payload;
        }
    }

    public enum Terminator : int
    {
        Unknown = 0,
        Direct = 1,
        Select = 2,
        MultiSelect = 3,
        Return = 4,
        Unreachable = 5,
        Kill = 6,
        IgnoreIntersection = 7,
        TerminateRay = 8,
        EmitMeshTasks = 9,
        ShaderAbort = 10,
    }
}
