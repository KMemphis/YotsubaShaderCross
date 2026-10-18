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

public partial class SPIRConstant : IVariant
{
    public const int type = 3;
    public static float f16_to_f32(ushort u16_value)
    {
        int s = unchecked((int)u16_value) >> 15 & 1;
        int e = unchecked((int)u16_value) >> 10 & 31;
        int m = unchecked((int)u16_value) >> 0 & 1023;
        SPIRConstant.u_t u = new SPIRConstant.u_t();
        if (e == 0)
        {
            if (m == 0)
            {
                u.u32 = unchecked((uint)s) << 31;
                return u.f32;
            }
            else
            {
                while ((m & 1024) == 0)
                {
                    m <<= 1;
                    e--;
                }
                e++;
                m &= ~1024;
            }
        }
        else
        if (e == 31)
        {
            if (m == 0)
            {
                u.u32 = unchecked((uint)s) << 31 | 2139095040u;
                return u.f32;
            }
            else
            {
                u.u32 = unchecked((uint)s) << 31 | 2139095040u | unchecked((uint)(m << 13));
                return u.f32;
            }
        }
        e += 127 - 15;
        m <<= 13;
        u.u32 = unchecked((uint)s) << 31 | unchecked((uint)(e << 23)) | unchecked((uint)m);
        return u.f32;
    }
    public static float fe4m3_to_f32(byte v)
    {
        if ((unchecked((int)v) & 127) == 127)
        {
            SPIRConstant.u_t_2 u = new SPIRConstant.u_t_2();
            u.u32 = (unchecked((int)v) & 128) != 0 ? 4294967295u : 2147483647u;
            return u.f32;
        }
        else
        {
            return SPIRConstant.f16_to_f32(unchecked((ushort)(unchecked((int)unchecked((short)unchecked((sbyte)v))) << 7 & (65535 ^ 16384)))) * 256.0f;
        }
    }
    public uint specialization_constant_id(uint col, uint row)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return ((uint)m.c[col].id[row]);
    }
    public uint specialization_constant_id(uint col)
    {
        if (col >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return ((uint)m.id[col]);
    }
    public uint scalar(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return m.c[col].r[row].u32;
    }
    public short scalar_i16(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return unchecked((short)(m.c[col].r[row].u32 & 65535u));
    }
    public ushort scalar_u16(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return unchecked((ushort)(m.c[col].r[row].u32 & 65535u));
    }
    public sbyte scalar_i8(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return unchecked((sbyte)(m.c[col].r[row].u32 & 255u));
    }
    public byte scalar_u8(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return unchecked((byte)(m.c[col].r[row].u32 & 255u));
    }
    public float scalar_f16(uint col = 0u, uint row = 0u)
    {
        return SPIRConstant.f16_to_f32(scalar_u16(col, row));
    }
    public float scalar_bf16(uint col = 0u, uint row = 0u)
    {
        uint v = unchecked((uint)(unchecked((int)scalar_u16(col, row)) << 16));
        float fp32 = default;
        Std.memcpy(Ptr.Ref<float>(() => fp32, __v => fp32 = __v), Ptr.Ref<uint>(() => v, __v => v = __v), 4);
        return fp32;
    }
    public float scalar_floate4m3(uint col = 0u, uint row = 0u)
    {
        return SPIRConstant.fe4m3_to_f32(scalar_u8(col, row));
    }
    public float scalar_bf8(uint col = 0u, uint row = 0u)
    {
        return SPIRConstant.f16_to_f32(unchecked((ushort)(unchecked((int)scalar_u8(col, row)) << 8)));
    }
    public float scalar_f32(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return m.c[col].r[row].f32;
    }
    public int scalar_i32(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return m.c[col].r[row].i32;
    }
    public double scalar_f64(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return m.c[col].r[row].f64;
    }
    public long scalar_i64(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return m.c[col].r[row].i64;
    }
    public ulong scalar_u64(uint col = 0u, uint row = 0u)
    {
        if (col >= 4u || row >= 4u)
        {
            throw new CompilerError("Out of bounds col/row. Long vector bug.");
        }
        return m.c[col].r[row].u64;
    }
    public SPIRConstant.ConstantVector vector()
    {
        return m.c[0];
    }
    public uint vector_size()
    {
        return m.c[0].vecsize;
    }
    public uint columns()
    {
        return m.columns;
    }
    public void make_null(SPIRType constant_type_)
    {
        m.CopyFrom(new SPIRConstant.ConstantMatrix());
        m.columns = constant_type_.columns;
        {
            foreach (SPIRConstant.ConstantVector c in m.c)
            {
                c.vecsize = constant_type_.vecsize;
            }
        }
    }
    public bool constant_is_null()
    {
        if (specialization)
        {
            return false;
        }
        if (!subconstants.empty())
        {
            return false;
        }
        {
            for (uint col = 0u; col < columns(); col++)
            {
                {
                    for (uint row = 0u; row < vector_size(); row++)
                    {
                        if (scalar_u64(col, row) != 0UL)
                        {
                            return false;
                        }
                    }
                }
            }
        }
        return true;
    }
    public SPIRConstant(uint constant_type_) : base()
    {
        this.constant_type = new TypedID_TypeType(constant_type_);
        this.m = new SPIRConstant.ConstantMatrix();
        this.subconstants = new CppVector<TypedID_TypeConstant>();
        this.specialization_constant_macro_name = default(CppString);
    }
    public SPIRConstant() { }
    public SPIRConstant(TypedID_TypeType constant_type_, Ptr<uint> elements, uint num_elements, bool specialized, bool replicated_ = false) : base()
    {
        this.constant_type = constant_type_;
        this.m = new SPIRConstant.ConstantMatrix();
        this.specialization = specialized;
        this.subconstants = new CppVector<TypedID_TypeConstant>();
        this.replicated = replicated_;
        this.specialization_constant_macro_name = default(CppString);
        subconstants.reserve(unchecked((ulong)num_elements));
        {
            for (uint i = 0u; i < num_elements; i++)
            {
                subconstants.push_back(new TypedID_TypeConstant(elements[i]));
            }
        }
        specialization = specialized;
    }
    public SPIRConstant(TypedID_TypeType constant_type_, uint v0, bool specialized) : base()
    {
        this.constant_type = constant_type_;
        this.m = new SPIRConstant.ConstantMatrix();
        this.specialization = specialized;
        this.subconstants = new CppVector<TypedID_TypeConstant>();
        this.specialization_constant_macro_name = default(CppString);
        m.c[0].r[0].u32 = v0;
        m.c[0].vecsize = 1u;
        m.columns = 1u;
    }
    public SPIRConstant(TypedID_TypeType constant_type_, ulong v0, bool specialized) : base()
    {
        this.constant_type = constant_type_;
        this.m = new SPIRConstant.ConstantMatrix();
        this.specialization = specialized;
        this.subconstants = new CppVector<TypedID_TypeConstant>();
        this.specialization_constant_macro_name = default(CppString);
        m.c[0].r[0].u64 = v0;
        m.c[0].vecsize = 1u;
        m.columns = 1u;
    }
    public SPIRConstant(TypedID_TypeType constant_type_, Ptr<SPIRConstant> vector_elements, uint num_elements, bool specialized) : base()
    {
        this.constant_type = constant_type_;
        this.m = new SPIRConstant.ConstantMatrix();
        this.specialization = specialized;
        this.subconstants = new CppVector<TypedID_TypeConstant>();
        this.specialization_constant_macro_name = default(CppString);
        bool matrix = vector_elements[0].m.c[0].vecsize > 1u;
        if (num_elements > 4u)
        {
            throw new CompilerError("Invalid constant. Long vector bug.");
        }
        if (matrix)
        {
            m.columns = num_elements;
            {
                for (uint i = 0u; i < num_elements; i++)
                {
                    m.c[i].CopyFrom(vector_elements[i].m.c[0]);
                    if (vector_elements[i].specialization)
                    {
                        m.id[i] = vector_elements[i].self;
                    }
                }
            }
        }
        else
        {
            m.c[0].vecsize = num_elements;
            m.columns = 1u;
            {
                for (uint i = 0u; i < num_elements; i++)
                {
                    m.c[0].r[i] = vector_elements[i].m.c[0].r[0];
                    if (vector_elements[i].specialization)
                    {
                        m.c[0].id[i] = vector_elements[i].self;
                    }
                }
            }
        }
    }
    public TypedID_TypeType constant_type = new TypedID_TypeType(0u);
    public SPIRConstant.ConstantMatrix m = new SPIRConstant.ConstantMatrix();
    public bool specialization = false;
    public bool is_used_as_array_length = false;
    public bool is_used_as_lut = false;
    public bool is_null_array_specialized_length = false;
    public CppVector<TypedID_TypeConstant> subconstants = new CppVector<TypedID_TypeConstant>();
    public bool replicated = false;
    public CppString specialization_constant_macro_name;
    public TypedID_TypeNone size_of_type = new TypedID_TypeNone(0u);
    public override IVariant clone(ObjectPoolBase pool)
    {
        return this.Clone();
    }

    protected override void FixClone()
    {
        base.FixClone();
        this.m = this.m.Clone();
        this.subconstants = this.subconstants.Clone();
    }

    public new SPIRConstant Clone()
    {
        var __c = (SPIRConstant)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(SPIRConstant o)
    {
        base.CopyFrom(o);
        this.constant_type = o.constant_type;
        this.m = o.m.Clone();
        this.specialization = o.specialization;
        this.is_used_as_array_length = o.is_used_as_array_length;
        this.is_used_as_lut = o.is_used_as_lut;
        this.is_null_array_specialized_length = o.is_null_array_specialized_length;
        this.subconstants = o.subconstants.Clone();
        this.replicated = o.replicated;
        this.specialization_constant_macro_name = o.specialization_constant_macro_name;
        this.size_of_type = o.size_of_type;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public partial struct Constant
    {
        [System.Runtime.InteropServices.FieldOffset(0)] public uint u32;
        [System.Runtime.InteropServices.FieldOffset(0)] public int i32;
        [System.Runtime.InteropServices.FieldOffset(0)] public float f32;
        [System.Runtime.InteropServices.FieldOffset(0)] public ulong u64;
        [System.Runtime.InteropServices.FieldOffset(0)] public long i64;
        [System.Runtime.InteropServices.FieldOffset(0)] public double f64;
    }

    public partial class ConstantMatrix
    {
        public SPIRConstant.ConstantVector[] c = Std.new_array<SPIRConstant.ConstantVector>(4);
        public TypedID_TypeNone[] id = new TypedID_TypeNone[4];
        public uint columns = 1u;

        protected virtual void FixClone()
        {
            this.c = Std.clone_array(this.c, __e => __e.Clone());
            this.id = Std.clone_array(this.id);
        }

        public ConstantMatrix Clone()
        {
            var __c = (ConstantMatrix)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(ConstantMatrix o)
        {
            this.c = Std.clone_array(o.c, __e => __e.Clone());
            this.id = Std.clone_array(o.id);
            this.columns = o.columns;
        }
    }

    public partial class ConstantVector
    {
        public SPIRConstant.Constant[] r = new SPIRConstant.Constant[4];
        public TypedID_TypeNone[] id = new TypedID_TypeNone[4];
        public uint vecsize = 1u;
        public ConstantVector()
        {
            this.r = new SPIRConstant.Constant[4];
            this.id = new TypedID_TypeNone[4];
            Std.memset(Ptr.From(r), 0, Std.sizeof_expr(r));
        }

        protected virtual void FixClone()
        {
            this.r = Std.clone_array(this.r);
            this.id = Std.clone_array(this.id);
        }

        public ConstantVector Clone()
        {
            var __c = (ConstantVector)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(ConstantVector o)
        {
            this.r = Std.clone_array(o.r);
            this.id = Std.clone_array(o.id);
            this.vecsize = o.vecsize;
        }
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public partial struct u_t
    {
        [System.Runtime.InteropServices.FieldOffset(0)] public float f32;
        [System.Runtime.InteropServices.FieldOffset(0)] public uint u32;
    }

    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Explicit)]
    public partial struct u_t_2
    {
        [System.Runtime.InteropServices.FieldOffset(0)] public float f32;
        [System.Runtime.InteropServices.FieldOffset(0)] public uint u32;
    }
}
