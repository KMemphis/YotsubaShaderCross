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

public partial class SPIRType : IVariant
{
    public const int type = 1;
    public Spv.Op op = Spv.Op.OpNop;
    public SPIRType(Spv.Op op_) : base()
    {
        this.op = op_;
        this.array = new CppVector<uint>();
        this.array_size_literal = new CppVector<bool>();
        this.ext = new SPIRType.ext_t();
        this.member_types = new CppVector<TypedID_TypeType>();
        this.member_type_index_redirection = new CppVector<uint>();
        this.member_name_cache = new UnorderedSet<CppString>();
    }
    public SPIRType.BaseType basetype = SPIRType.BaseType.Unknown;
    public uint width = 0u;
    public uint vecsize = 1u;
    public uint columns = 1u;
    public CppVector<uint> array = new CppVector<uint>();
    public CppVector<bool> array_size_literal = new CppVector<bool>();
    public uint pointer_depth = 0u;
    public bool pointer = false;
    public bool forward_pointer = false;
    public SPIRType.ext_t ext = new SPIRType.ext_t();
    public Spv.StorageClass storage = Spv.StorageClass.StorageClassGeneric;
    public CppVector<TypedID_TypeType> member_types = new CppVector<TypedID_TypeType>();
    public CppVector<uint> member_type_index_redirection = new CppVector<uint>();
    public SPIRType.ImageType image = new SPIRType.ImageType { type = new TypedID_TypeType() };
    public TypedID_TypeType type_alias = new TypedID_TypeType(0u);
    public TypedID_TypeType parent_type = new TypedID_TypeType(0u);
    public UnorderedSet<CppString> member_name_cache = new UnorderedSet<CppString>();
    public override IVariant clone(ObjectPoolBase pool)
    {
        return this.Clone();
    }

    protected override void FixClone()
    {
        base.FixClone();
        this.array = this.array.Clone();
        this.array_size_literal = this.array_size_literal.Clone();
        this.ext = this.ext.Clone();
        this.member_types = this.member_types.Clone();
        this.member_type_index_redirection = this.member_type_index_redirection.Clone();
        this.image = this.image.Clone();
        this.member_name_cache = this.member_name_cache.Clone();
    }

    public new SPIRType Clone()
    {
        var __c = (SPIRType)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(SPIRType o)
    {
        base.CopyFrom(o);
        this.op = o.op;
        this.basetype = o.basetype;
        this.width = o.width;
        this.vecsize = o.vecsize;
        this.columns = o.columns;
        this.array = o.array.Clone();
        this.array_size_literal = o.array_size_literal.Clone();
        this.pointer_depth = o.pointer_depth;
        this.pointer = o.pointer;
        this.forward_pointer = o.forward_pointer;
        this.ext = o.ext.Clone();
        this.storage = o.storage;
        this.member_types = o.member_types.Clone();
        this.member_type_index_redirection = o.member_type_index_redirection.Clone();
        this.image = o.image.Clone();
        this.type_alias = o.type_alias;
        this.parent_type = o.parent_type;
        this.member_name_cache = o.member_name_cache.Clone();
    }

    public enum BaseType : int
    {
        Unknown = 0,
        Void = 1,
        Boolean = 2,
        SByte = 3,
        UByte = 4,
        Short = 5,
        UShort = 6,
        Int = 7,
        UInt = 8,
        Int64 = 9,
        UInt64 = 10,
        AtomicCounter = 11,
        Half = 12,
        Float = 13,
        Double = 14,
        Struct = 15,
        Image = 16,
        SampledImage = 17,
        Sampler = 18,
        AccelerationStructure = 19,
        RayQuery = 20,
        CoopVecNV = 21,
        ControlPointArray = 22,
        Interpolant = 23,
        Char = 24,
        MeshGridProperties = 25,
        BFloat16 = 26,
        FloatE4M3 = 27,
        FloatE5M2 = 28,
        Tensor = 29,
        DescriptorHeapBuffer = 30,
    }

    public partial class ext_t
    {
        public SPIRType.ext_t.cooperative_t cooperative = new SPIRType.ext_t.cooperative_t();
        public SPIRType.ext_t.coopVecNV_t coopVecNV = new SPIRType.ext_t.coopVecNV_t();
        public SPIRType.ext_t.tensor_t tensor = new SPIRType.ext_t.tensor_t();
        public SPIRType.ext_t.descriptor_heap_buffer_t descriptor_heap_buffer = new SPIRType.ext_t.descriptor_heap_buffer_t();

        protected virtual void FixClone()
        {
            this.cooperative = this.cooperative.Clone();
            this.coopVecNV = this.coopVecNV.Clone();
            this.tensor = this.tensor.Clone();
            this.descriptor_heap_buffer = this.descriptor_heap_buffer.Clone();
        }

        public ext_t Clone()
        {
            var __c = (ext_t)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(ext_t o)
        {
            this.cooperative = o.cooperative.Clone();
            this.coopVecNV = o.coopVecNV.Clone();
            this.tensor = o.tensor.Clone();
            this.descriptor_heap_buffer = o.descriptor_heap_buffer.Clone();
        }

        public partial class cooperative_t
        {
            public uint use_id;
            public uint rows_id;
            public uint columns_id;
            public uint scope_id;

            protected virtual void FixClone()
            {
            }

            public cooperative_t Clone()
            {
                var __c = (cooperative_t)MemberwiseClone();
                __c.FixClone();
                return __c;
            }

            public void CopyFrom(cooperative_t o)
            {
                this.use_id = o.use_id;
                this.rows_id = o.rows_id;
                this.columns_id = o.columns_id;
                this.scope_id = o.scope_id;
            }
        }

        public partial class coopVecNV_t
        {
            public uint component_type_id;
            public uint component_count_id;

            protected virtual void FixClone()
            {
            }

            public coopVecNV_t Clone()
            {
                var __c = (coopVecNV_t)MemberwiseClone();
                __c.FixClone();
                return __c;
            }

            public void CopyFrom(coopVecNV_t o)
            {
                this.component_type_id = o.component_type_id;
                this.component_count_id = o.component_count_id;
            }
        }

        public partial class descriptor_heap_buffer_t
        {
            public Spv.StorageClass storage;

            protected virtual void FixClone()
            {
            }

            public descriptor_heap_buffer_t Clone()
            {
                var __c = (descriptor_heap_buffer_t)MemberwiseClone();
                __c.FixClone();
                return __c;
            }

            public void CopyFrom(descriptor_heap_buffer_t o)
            {
                this.storage = o.storage;
            }
        }

        public partial class tensor_t
        {
            public uint type;
            public uint rank;
            public uint shape;

            protected virtual void FixClone()
            {
            }

            public tensor_t Clone()
            {
                var __c = (tensor_t)MemberwiseClone();
                __c.FixClone();
                return __c;
            }

            public void CopyFrom(tensor_t o)
            {
                this.type = o.type;
                this.rank = o.rank;
                this.shape = o.shape;
            }
        }
    }

    public partial class ImageType
    {
        public TypedID_TypeType type;
        public Spv.Dim dim;
        public bool depth;
        public bool arrayed;
        public bool ms;
        public uint sampled;
        public Spv.ImageFormat format;
        public Spv.AccessQualifier access;

        protected virtual void FixClone()
        {
        }

        public ImageType Clone()
        {
            var __c = (ImageType)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(ImageType o)
        {
            this.type = o.type;
            this.dim = o.dim;
            this.depth = o.depth;
            this.arrayed = o.arrayed;
            this.ms = o.ms;
            this.sampled = o.sampled;
            this.format = o.format;
            this.access = o.access;
        }
    }
}
