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

public partial class SPIREntryPoint
{
    public SPIREntryPoint(TypedID_TypeFunction self_, Spv.ExecutionModel execution_model, CppString entry_name)
    {
        this.self = self_;
        this.name = entry_name;
        this.orig_name = entry_name;
        this.fp_fast_math_defaults = new UnorderedMap<uint, uint>();
        this.interface_variables = new CppVector<TypedID_TypeVariable>();
        this.flags = new Bitset();
        this.workgroup_size = new SPIREntryPoint.WorkgroupSize();
        this.model = execution_model;
    }
    public SPIREntryPoint() { }
    public TypedID_TypeFunction self = new TypedID_TypeFunction(0u);
    public CppString name;
    public CppString orig_name;
    public UnorderedMap<uint, uint> fp_fast_math_defaults = new UnorderedMap<uint, uint>();
    public bool signed_zero_inf_nan_preserve_8 = false;
    public bool signed_zero_inf_nan_preserve_16 = false;
    public bool signed_zero_inf_nan_preserve_32 = false;
    public bool signed_zero_inf_nan_preserve_64 = false;
    public CppVector<TypedID_TypeVariable> interface_variables = new CppVector<TypedID_TypeVariable>();
    public Bitset flags = new Bitset();
    public SPIREntryPoint.WorkgroupSize workgroup_size = new SPIREntryPoint.WorkgroupSize();
    public uint invocations = 0u;
    public uint output_vertices = 0u;
    public uint output_primitives = 0u;
    public Spv.ExecutionModel model = Spv.ExecutionModel.ExecutionModelMax;
    public bool geometry_passthrough = false;

    protected virtual void FixClone()
    {
        this.fp_fast_math_defaults = this.fp_fast_math_defaults.Clone();
        this.interface_variables = this.interface_variables.Clone();
        this.flags = this.flags.Clone();
        this.workgroup_size = this.workgroup_size.Clone();
    }

    public SPIREntryPoint Clone()
    {
        var __c = (SPIREntryPoint)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(SPIREntryPoint o)
    {
        this.self = o.self;
        this.name = o.name;
        this.orig_name = o.orig_name;
        this.fp_fast_math_defaults = o.fp_fast_math_defaults.Clone();
        this.signed_zero_inf_nan_preserve_8 = o.signed_zero_inf_nan_preserve_8;
        this.signed_zero_inf_nan_preserve_16 = o.signed_zero_inf_nan_preserve_16;
        this.signed_zero_inf_nan_preserve_32 = o.signed_zero_inf_nan_preserve_32;
        this.signed_zero_inf_nan_preserve_64 = o.signed_zero_inf_nan_preserve_64;
        this.interface_variables = o.interface_variables.Clone();
        this.flags = o.flags.Clone();
        this.workgroup_size = o.workgroup_size.Clone();
        this.invocations = o.invocations;
        this.output_vertices = o.output_vertices;
        this.output_primitives = o.output_primitives;
        this.model = o.model;
        this.geometry_passthrough = o.geometry_passthrough;
    }

    public partial class WorkgroupSize
    {
        public uint x = 0u;
        public uint y = 0u;
        public uint z = 0u;
        public uint id_x = 0u;
        public uint id_y = 0u;
        public uint id_z = 0u;
        public uint constant = 0u;

        protected virtual void FixClone()
        {
        }

        public WorkgroupSize Clone()
        {
            var __c = (WorkgroupSize)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(WorkgroupSize o)
        {
            this.x = o.x;
            this.y = o.y;
            this.z = o.z;
            this.id_x = o.id_x;
            this.id_y = o.id_y;
            this.id_z = o.id_z;
            this.constant = o.constant;
        }
    }
}
