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

public partial class Meta
{
    public Meta.Decoration decoration = new Meta.Decoration();
    public CppVector<Meta.Decoration> members = new CppVector<Meta.Decoration>();
    public UnorderedMap<uint, uint> decoration_word_offset = new UnorderedMap<uint, uint>();
    public bool hlsl_is_magic_counter_buffer = false;
    public uint hlsl_magic_counter_buffer = 0u;

    protected virtual void FixClone()
    {
        this.decoration = this.decoration.Clone();
        this.members = this.members.Clone(__e => __e.Clone());
        this.decoration_word_offset = this.decoration_word_offset.Clone();
    }

    public Meta Clone()
    {
        var __c = (Meta)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(Meta o)
    {
        this.decoration = o.decoration.Clone();
        this.members = o.members.Clone(__e => __e.Clone());
        this.decoration_word_offset = o.decoration_word_offset.Clone();
        this.hlsl_is_magic_counter_buffer = o.hlsl_is_magic_counter_buffer;
        this.hlsl_magic_counter_buffer = o.hlsl_magic_counter_buffer;
    }

    public partial class Decoration
    {
        public CppString alias;
        public CppString qualified_alias;
        public CppString user_semantic;
        public CppString user_type;
        public Bitset decoration_flags = new Bitset();
        public Spv.BuiltIn builtin_type = Spv.BuiltIn.BuiltInMax;
        public uint location = 0u;
        public uint component = 0u;
        public uint set = 0u;
        public uint binding = 0u;
        public uint offset = 0u;
        public uint offset_id = 0u;
        public uint xfb_buffer = 0u;
        public uint xfb_stride = 0u;
        public uint stream = 0u;
        public uint array_stride = 0u;
        public uint array_stride_id = 0u;
        public uint matrix_stride = 0u;
        public uint input_attachment = 0u;
        public uint spec_id = 0u;
        public uint index = 0u;
        public Spv.FPRoundingMode fp_rounding_mode = Spv.FPRoundingMode.FPRoundingModeMax;
        public Spv.FPFastMathModeMask fp_fast_math_mode = Spv.FPFastMathModeMask.FPFastMathModeMaskNone;
        public bool builtin = false;
        public bool qualified_alias_explicit_override = false;
        public Meta.Decoration.Extended extended = new Meta.Decoration.Extended();

        protected virtual void FixClone()
        {
            this.decoration_flags = this.decoration_flags.Clone();
            this.extended = this.extended.Clone();
        }

        public Decoration Clone()
        {
            var __c = (Decoration)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(Decoration o)
        {
            this.alias = o.alias;
            this.qualified_alias = o.qualified_alias;
            this.user_semantic = o.user_semantic;
            this.user_type = o.user_type;
            this.decoration_flags = o.decoration_flags.Clone();
            this.builtin_type = o.builtin_type;
            this.location = o.location;
            this.component = o.component;
            this.set = o.set;
            this.binding = o.binding;
            this.offset = o.offset;
            this.offset_id = o.offset_id;
            this.xfb_buffer = o.xfb_buffer;
            this.xfb_stride = o.xfb_stride;
            this.stream = o.stream;
            this.array_stride = o.array_stride;
            this.array_stride_id = o.array_stride_id;
            this.matrix_stride = o.matrix_stride;
            this.input_attachment = o.input_attachment;
            this.spec_id = o.spec_id;
            this.index = o.index;
            this.fp_rounding_mode = o.fp_rounding_mode;
            this.fp_fast_math_mode = o.fp_fast_math_mode;
            this.builtin = o.builtin;
            this.qualified_alias_explicit_override = o.qualified_alias_explicit_override;
            this.extended = o.extended.Clone();
        }

        public partial class Extended
        {
            public Extended()
            {
                this.flags = new Bitset();
                {
                    var __r0 = values;
                    for (int __i1 = 0; __i1 < __r0.Length; __i1++)
                    {
                        ref uint v = ref __r0[__i1];
                        v = 0u;
                    }
                }
            }
            public Bitset flags = new Bitset();
            public uint[] values = new uint[18];

            protected virtual void FixClone()
            {
                this.flags = this.flags.Clone();
                this.values = Std.clone_array(this.values);
            }

            public Extended Clone()
            {
                var __c = (Extended)MemberwiseClone();
                __c.FixClone();
                return __c;
            }

            public void CopyFrom(Extended o)
            {
                this.flags = o.flags.Clone();
                this.values = Std.clone_array(o.values);
            }
        }
    }
}
