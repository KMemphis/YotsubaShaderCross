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
// Upstream sources: spirv_cfg.cpp, spirv_common.hpp, spirv_cross_parsed_ir.cpp, spirv_cross_util.cpp, spirv_cross.cpp, spirv_glsl.cpp, spirv_hlsl.cpp, spirv_msl.cpp, spirv_parser.cpp, spirv_reflect.cpp
// Upstream copyright: Copyright 2015-2021 Arm Limited
// Upstream copyright: Copyright 2016-2021 Arm Limited
// Upstream copyright: Copyright 2016-2021 Robert Konrad
// Upstream copyright: Copyright 2016-2021 The Brenwill Workshop Ltd.
// Upstream copyright: Copyright 2018-2021 Arm Limited
// Upstream copyright: Copyright 2018-2021 Bradley Austin Davis
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public static partial class Globals
{
    public static CppString merge(CppVector<CppString> list, string between = ", ")
    {
        StringStream stream = new StringStream();
        {
            var __r0 = list;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref readonly CppString elem = ref __r0[__i1];
                _ = stream << elem;
                if (__r0.ptr_at(__i1) != list.ptr_back())
                {
                    _ = stream << between;
                }
            }
        }
        return stream.str();
    }
    public static CppString convert_to_string(int value)
    {
        if (value == Std.numeric_min<int>())
        {
            return new CppString("int(0x80000000)");
        }
        else
        {
            return Std.to_string(value);
        }
    }
    public static CppString convert_to_string(long value, CppString int64_type, bool long_long_literal_suffix)
    {
        if (value == Std.numeric_min<long>())
        {
            return Std.join(int64_type, "(0x8000000000000000u", long_long_literal_suffix ? "ll" : "l", ")");
        }
        else
        {
            return Std.to_string(value) + (long_long_literal_suffix ? "ll" : "l");
        }
    }
    public static void fixup_radix_point(Ptr<char> str, char radix_point)
    {
        if (unchecked((int)radix_point) != 46)
        {
            while (unchecked((int)str.Value) != 0)
            {
                if (unchecked((int)str.Value) == unchecked((int)radix_point))
                {
                    str.Value = '.';
                }
                str++;
            }
        }
    }
    public static CppString convert_to_string(float t, char locale_radix_point)
    {
        char[] buf = new char[64];
        Std.sprintf(Ptr.From(buf), "%.32g", unchecked((double)t));
        Globals.fixup_radix_point(Ptr.From(buf), locale_radix_point);
        if (!(Std.strchr(Ptr.From(buf), 46) != null) && !(Std.strchr(Ptr.From(buf), 101) != null))
        {
            Std.strcat(Ptr.From(buf), ".0");
        }
        return new CppString(Ptr.From(buf));
    }
    public static CppString convert_to_string(double t, char locale_radix_point)
    {
        char[] buf = new char[64];
        Std.sprintf(Ptr.From(buf), "%.32g", t);
        Globals.fixup_radix_point(Ptr.From(buf), locale_radix_point);
        if (!(Std.strchr(Ptr.From(buf), 46) != null) && !(Std.strchr(Ptr.From(buf), 101) != null))
        {
            Std.strcat(Ptr.From(buf), ".0");
        }
        return new CppString(Ptr.From(buf));
    }
    public static SPIRVariable variant_get__SPIRVariable(Variant @var)
    {
        return @var.get__SPIRVariable();
    }
    public static SPIRConstant variant_get__SPIRConstant(Variant @var)
    {
        return @var.get__SPIRConstant();
    }
    public static SPIRConstantOp variant_get__SPIRConstantOp(Variant @var)
    {
        return @var.get__SPIRConstantOp();
    }
    public static SPIRType variant_get__SPIRType(Variant @var)
    {
        return @var.get__SPIRType();
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, uint args)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args);
        return ptr;
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, uint args, Ptr<uint> args_1, uint args_2, bool args_3)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args, args_1, args_2, args_3);
        return ptr;
    }
    public static bool type_is_floating_point(SPIRType type)
    {
        return unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Half) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Float) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Double) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.BFloat16) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.FloatE5M2) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.FloatE4M3);
    }
    public static bool type_is_integral(SPIRType type)
    {
        return unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.SByte) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.UByte) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Short) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.UShort) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Int) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.UInt) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Int64) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.UInt64);
    }
    public static SPIRType.BaseType to_signed_basetype(uint width)
    {
        {
            switch (width)
            {
                case 8u:
                {
                    return SPIRType.BaseType.SByte;
                }
                case 16u:
                {
                    return SPIRType.BaseType.Short;
                }
                case 32u:
                {
                    return SPIRType.BaseType.Int;
                }
                case 64u:
                {
                    return SPIRType.BaseType.Int64;
                }
                default:
                {
                    throw new CompilerError("Invalid bit width.");
                }
            }
        }
    }
    public static SPIRType.BaseType to_unsigned_basetype(uint width)
    {
        {
            switch (width)
            {
                case 8u:
                {
                    return SPIRType.BaseType.UByte;
                }
                case 16u:
                {
                    return SPIRType.BaseType.UShort;
                }
                case 32u:
                {
                    return SPIRType.BaseType.UInt;
                }
                case 64u:
                {
                    return SPIRType.BaseType.UInt64;
                }
                default:
                {
                    throw new CompilerError("Invalid bit width.");
                }
            }
        }
    }
    public static bool opcode_is_sign_invariant(Spv.Op opcode)
    {
        {
            switch (unchecked((int)opcode))
            {
                case unchecked((int)Spv.Op.OpIEqual):
                case unchecked((int)Spv.Op.OpINotEqual):
                case unchecked((int)Spv.Op.OpISub):
                case unchecked((int)Spv.Op.OpIAdd):
                case unchecked((int)Spv.Op.OpIMul):
                case unchecked((int)Spv.Op.OpShiftLeftLogical):
                case unchecked((int)Spv.Op.OpBitwiseOr):
                case unchecked((int)Spv.Op.OpBitwiseXor):
                case unchecked((int)Spv.Op.OpBitwiseAnd):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool opcode_can_promote_integer_implicitly(Spv.Op opcode)
    {
        {
            switch (unchecked((int)opcode))
            {
                case unchecked((int)Spv.Op.OpSNegate):
                case unchecked((int)Spv.Op.OpNot):
                case unchecked((int)Spv.Op.OpBitwiseAnd):
                case unchecked((int)Spv.Op.OpBitwiseOr):
                case unchecked((int)Spv.Op.OpBitwiseXor):
                case unchecked((int)Spv.Op.OpShiftLeftLogical):
                case unchecked((int)Spv.Op.OpShiftRightLogical):
                case unchecked((int)Spv.Op.OpShiftRightArithmetic):
                case unchecked((int)Spv.Op.OpIAdd):
                case unchecked((int)Spv.Op.OpISub):
                case unchecked((int)Spv.Op.OpIMul):
                case unchecked((int)Spv.Op.OpSDiv):
                case unchecked((int)Spv.Op.OpUDiv):
                case unchecked((int)Spv.Op.OpSRem):
                case unchecked((int)Spv.Op.OpUMod):
                case unchecked((int)Spv.Op.OpSMod):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static uint ResourceBindingPushConstantDescriptorSet = ~0u;
    public static uint ResourceBindingPushConstantBinding = 0u;
    public static bool is_alpha(char c)
    {
        return unchecked((int)c) >= 97 && unchecked((int)c) <= 122 || unchecked((int)c) >= 65 && unchecked((int)c) <= 90;
    }
    public static bool is_numeric(char c)
    {
        return unchecked((int)c) >= 48 && unchecked((int)c) <= 57;
    }
    public static bool is_alphanumeric(char c)
    {
        return Globals.is_alpha(c) || Globals.is_numeric(c);
    }
    public static bool is_valid_identifier(CppString name)
    {
        if (name.empty())
        {
            return true;
        }
        if (Globals.is_numeric(name[0UL]))
        {
            return false;
        }
        {
            foreach (char c in name)
            {
                if (!Globals.is_alphanumeric(c) && unchecked((int)c) != 95)
                {
                    return false;
                }
            }
        }
        bool saw_underscore = false;
        {
            foreach (char c in name)
            {
                bool is_underscore = unchecked((int)c) == 95;
                if (is_underscore && saw_underscore)
                {
                    return false;
                }
                saw_underscore = is_underscore;
            }
        }
        return true;
    }
    public static bool is_reserved_prefix(CppString name)
    {
        return name.compare(0UL, 3UL, "gl_", 3UL) == 0 || name.compare(0UL, 3UL, "spv", 3UL) == 0;
    }
    public static bool is_reserved_identifier(CppString name, bool member, bool allow_reserved_prefixes)
    {
        if (!allow_reserved_prefixes && Globals.is_reserved_prefix(name))
        {
            return true;
        }
        if (member)
        {
            if (name.size() < 3UL)
            {
                return false;
            }
            if (name.compare(0UL, 2UL, "_m", 2UL) != 0)
            {
                return false;
            }
            ulong index = 2UL;
            while (index < name.size() && Globals.is_numeric(name[index]))
            {
                index++;
            }
            return index == name.size();
        }
        else
        {
            if (name.size() < 2UL)
            {
                return false;
            }
            if (unchecked((int)name[0UL]) != 95 || !Globals.is_numeric(name[1UL]))
            {
                return false;
            }
            ulong index = 2UL;
            while (index < name.size() && Globals.is_numeric(name[index]))
            {
                index++;
            }
            return index == name.size() || index < name.size() && unchecked((int)name[index]) == 95;
        }
    }
    public static CppString make_unreserved_identifier(CppString name)
    {
        if (Globals.is_reserved_prefix(name))
        {
            return "_RESERVED_IDENTIFIER_FIXUP_" + name;
        }
        else
        {
            return "_RESERVED_IDENTIFIER_FIXUP" + name;
        }
    }
    public static CppString ensure_valid_identifier(CppString name)
    {
        var str = name.substr(0UL, name.find('(', 0UL));
        if (str.empty())
        {
            return str;
        }
        if (Globals.is_numeric(str[0UL]))
        {
            str[0UL] = '_';
        }
        {
            ref CppString __r0 = ref str;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                char c = __r0[__i1];
                try
                {
                    if (!Globals.is_alphanumeric(c) && unchecked((int)c) != 95)
                    {
                        c = '_';
                    }
                }
                finally
                {
                    __r0[__i1] = c;
                }
            }
        }
        ParsedIR.sanitize_underscores(ref str);
        return str;
    }
    public static CppString extract_string(Ptr<uint> spirv, ulong word_count)
    {
        CppString ret = default(CppString);
        {
            for (uint i = 0u; unchecked((ulong)i) < word_count; i++)
            {
                uint w = spirv[i];
                {
                    for (uint j = 0u; j < 4u; j++, w >>= 8)
                    {
                        char c = unchecked((char)(w & 255u));
                        if (unchecked((int)c) == 0)
                        {
                            return ret;
                        }
                        ret += c;
                    }
                }
            }
        }
        throw new CompilerError("String was not terminated before EOF");
    }
    public static SPIRBlock variant_get__SPIRBlock(Variant @var)
    {
        return @var.get__SPIRBlock();
    }
    public static void add_unique(CppVector<uint> l, uint value)
    {
        var itr = Std.find(Std.begin(l), Std.end(l), value);
        if (itr == Std.end(l))
        {
            l.push_back(value);
        }
    }
    public static CppString convert_to_string__uint__0(uint t)
    {
        return Std.to_string(t);
    }
    public static SPIRFunction variant_get__SPIRFunction(Variant @var)
    {
        return @var.get__SPIRFunction();
    }
    public static SPIRExtension variant_get__SPIRExtension(Variant @var)
    {
        return @var.get__SPIRExtension();
    }
    public static SPIRAccessChain variant_get__SPIRAccessChain(Variant @var)
    {
        return @var.get__SPIRAccessChain();
    }
    public static SPIRExpression variant_get__SPIRExpression(Variant @var)
    {
        return @var.get__SPIRExpression();
    }
    public static SPIRUndef variant_get__SPIRUndef(Variant @var)
    {
        return @var.get__SPIRUndef();
    }
    public static SPIRCombinedImageSampler variant_get__SPIRCombinedImageSampler(Variant @var)
    {
        return @var.get__SPIRCombinedImageSampler();
    }
    public static SPIRConstantData variant_get__SPIRConstantData(Variant @var)
    {
        return @var.get__SPIRConstantData();
    }
    public static SPIRType variant_set__SPIRType_X(Variant @var, Spv.Op args)
    {
        var ptr = @var.allocate_and_set__SPIRType_X(unchecked((Types)SPIRType.type), args);
        return ptr;
    }
    public static SPIRVariable variant_set__SPIRVariable_X(Variant @var, uint args, Spv.StorageClass args_1, int args_2)
    {
        var ptr = @var.allocate_and_set__SPIRVariable_X(unchecked((Types)SPIRVariable.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRExpression variant_set__SPIRExpression_X(Variant @var, string args, uint args_1, bool args_2)
    {
        var ptr = @var.allocate_and_set__SPIRExpression_X(unchecked((Types)SPIRExpression.type), args, args_1, args_2);
        return ptr;
    }
    public const int GLSLstd450Version = 100;
    public const int GLSLstd450Revision = 3;
    public static bool storage_class_is_interface(Spv.StorageClass storage)
    {
        {
            switch (unchecked((int)storage))
            {
                case unchecked((int)Spv.StorageClass.StorageClassInput):
                case unchecked((int)Spv.StorageClass.StorageClassOutput):
                case unchecked((int)Spv.StorageClass.StorageClassUniform):
                case unchecked((int)Spv.StorageClass.StorageClassUniformConstant):
                case unchecked((int)Spv.StorageClass.StorageClassAtomicCounter):
                case unchecked((int)Spv.StorageClass.StorageClassPushConstant):
                case unchecked((int)Spv.StorageClass.StorageClassStorageBuffer):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static uint get_default_extended_decoration(ExtendedDecorations decoration)
    {
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)ExtendedDecorations.SPIRVCrossDecorationResourceIndexPrimary):
                case unchecked((int)ExtendedDecorations.SPIRVCrossDecorationResourceIndexSecondary):
                case unchecked((int)ExtendedDecorations.SPIRVCrossDecorationResourceIndexTertiary):
                case unchecked((int)ExtendedDecorations.SPIRVCrossDecorationResourceIndexQuaternary):
                case unchecked((int)ExtendedDecorations.SPIRVCrossDecorationInterfaceMemberIndex):
                {
                    return ~0u;
                }
                default:
                {
                    return 0u;
                }
            }
        }
    }
    public static bool exists_unaccessed_path_to_return(CFG cfg, uint block, UnorderedSet<uint> blocks, UnorderedSet<uint> visit_cache)
    {
        if (blocks.find(block) != Std.end(blocks))
        {
            return false;
        }
        if (cfg.get_succeeding_edges(block).empty())
        {
            return true;
        }
        {
            foreach (uint succ in cfg.get_succeeding_edges(block))
            {
                if (visit_cache.count(succ) == 0UL)
                {
                    if (Globals.exists_unaccessed_path_to_return(cfg, succ, blocks, visit_cache))
                    {
                        return true;
                    }
                    visit_cache.insert(succ);
                }
            }
        }
        return false;
    }
    public static SPIRString variant_get__SPIRString(Variant @var)
    {
        return @var.get__SPIRString();
    }
    public static SPIRDebugLocalVariable variant_get__SPIRDebugLocalVariable(Variant @var)
    {
        return @var.get__SPIRDebugLocalVariable();
    }
    public static SPIRString variant_set__SPIRString_X(Variant @var, CppString args)
    {
        var ptr = @var.allocate_and_set__SPIRString_X(unchecked((Types)SPIRString.type), args);
        return ptr;
    }
    public static SPIRUndef variant_set__SPIRUndef_X(Variant @var, uint args)
    {
        var ptr = @var.allocate_and_set__SPIRUndef_X(unchecked((Types)SPIRUndef.type), args);
        return ptr;
    }
    public static SPIRExtension variant_set__SPIRExtension_X(Variant @var, SPIRExtension.Extension args)
    {
        var ptr = @var.allocate_and_set__SPIRExtension_X(unchecked((Types)SPIRExtension.type), args);
        return ptr;
    }
    public static SPIRDebugLocalVariable variant_set__SPIRDebugLocalVariable_X(Variant @var)
    {
        var ptr = @var.allocate_and_set__SPIRDebugLocalVariable_X(unchecked((Types)SPIRDebugLocalVariable.type));
        return ptr;
    }
    public static SPIRType variant_set__SPIRType_X(Variant @var, SPIRType args)
    {
        var ptr = @var.allocate_and_set__SPIRType_X(unchecked((Types)SPIRType.type), args);
        return ptr;
    }
    public static SPIRFunctionPrototype variant_set__SPIRFunctionPrototype_X(Variant @var, uint args)
    {
        var ptr = @var.allocate_and_set__SPIRFunctionPrototype_X(unchecked((Types)SPIRFunctionPrototype.type), args);
        return ptr;
    }
    public static SPIRVariable variant_set__SPIRVariable_X(Variant @var, uint args, Spv.StorageClass args_1, uint args_2)
    {
        var ptr = @var.allocate_and_set__SPIRVariable_X(unchecked((Types)SPIRVariable.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRVariable variant_set__SPIRVariable_X(Variant @var, uint args, Spv.StorageClass args_1)
    {
        var ptr = @var.allocate_and_set__SPIRVariable_X(unchecked((Types)SPIRVariable.type), args, args_1);
        return ptr;
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, uint args, Ptr<uint> args_1, int args_2, bool args_3, bool args_4)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args, args_1, args_2, args_3, args_4);
        return ptr;
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, uint args, ulong args_1, bool args_2)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, uint args, uint args_1, bool args_2)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, uint args, SPIRConstant[] args_1, uint args_2, bool args_3)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args, args_1, args_2, args_3);
        return ptr;
    }
    public static SPIRConstantData variant_set__SPIRConstantData_X(Variant @var, uint args, Ptr<uint> args_1, uint args_2, bool args_3)
    {
        var ptr = @var.allocate_and_set__SPIRConstantData_X(unchecked((Types)SPIRConstantData.type), args, args_1, args_2, args_3);
        return ptr;
    }
    public static SPIRFunction variant_set__SPIRFunction_X(Variant @var, uint args, uint args_1, uint args_2)
    {
        var ptr = @var.allocate_and_set__SPIRFunction_X(unchecked((Types)SPIRFunction.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRBlock variant_set__SPIRBlock_X(Variant @var)
    {
        var ptr = @var.allocate_and_set__SPIRBlock_X(unchecked((Types)SPIRBlock.type));
        return ptr;
    }
    public static SPIRConstantOp variant_set__SPIRConstantOp_X(Variant @var, uint args, Spv.Op args_1, Ptr<uint> args_2, uint args_3)
    {
        var ptr = @var.allocate_and_set__SPIRConstantOp_X(unchecked((Types)SPIRConstantOp.type), args, args_1, args_2, args_3);
        return ptr;
    }
    public static bool decoration_is_string(Spv.Decoration decoration)
    {
        {
            switch (unchecked((int)decoration))
            {
                case unchecked((int)Spv.Decoration.DecorationUserSemantic):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static uint swap_endian(uint v)
    {
        return v >> 24 & 255u | v >> 8 & 65280u | v << 8 & 16711680u | v << 24 & 4278190080u;
    }
    public static bool is_valid_spirv_version(uint version)
    {
        {
            switch (version)
            {
                case 99u:
                case 65536u:
                case 65792u:
                case 66048u:
                case 66304u:
                case 66560u:
                case 66816u:
                case 67072u:
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static CppString extract_string(CppVector<uint> spirv, uint offset)
    {
        return Globals.extract_string(spirv.data() + offset, spirv.size() - unchecked((ulong)offset));
    }
    public static CppString convert_to_string__ulong__0(ulong t)
    {
        return Std.to_string(t);
    }
    public static CppString convert_to_string__ushort__0(ushort t)
    {
        return Std.to_string(unchecked((int)t));
    }
    public static CppString convert_to_string__short__0(short t)
    {
        return Std.to_string(unchecked((int)t));
    }
    public static CppString convert_to_string__byte__0(byte t)
    {
        return Std.to_string(unchecked((int)t));
    }
    public static CppString convert_to_string__sbyte__0(sbyte t)
    {
        return Std.to_string(unchecked((int)t));
    }
    public static CppString convert_to_string__Spv_BuiltIn__0(Spv.BuiltIn t)
    {
        return Std.to_string(unchecked((int)t));
    }
    public static CppString convert_to_string__long__0(long t)
    {
        return Std.to_string(t);
    }
    public static SPIRExpression variant_set__SPIRExpression_X(Variant @var, CppString args, uint args_1, bool args_2)
    {
        var ptr = @var.allocate_and_set__SPIRExpression_X(unchecked((Types)SPIRExpression.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, TypedID_TypeType args)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args);
        return ptr;
    }
    public static SPIRAccessChain variant_set__SPIRAccessChain_X(Variant @var, SPIRAccessChain args)
    {
        var ptr = @var.allocate_and_set__SPIRAccessChain_X(unchecked((Types)SPIRAccessChain.type), args);
        return ptr;
    }
    public static SPIRCombinedImageSampler variant_set__SPIRCombinedImageSampler_X(Variant @var, SPIRCombinedImageSampler args)
    {
        var ptr = @var.allocate_and_set__SPIRCombinedImageSampler_X(unchecked((Types)SPIRCombinedImageSampler.type), args);
        return ptr;
    }
    public static SPIRExpression variant_set__SPIRExpression_X(Variant @var, CppString args, TypedID_TypeType args_1, bool args_2)
    {
        var ptr = @var.allocate_and_set__SPIRExpression_X(unchecked((Types)SPIRExpression.type), args, args_1, args_2);
        return ptr;
    }
    public static GlslConstantNameMapping[] CoopVecComponentTypeNames = new GlslConstantNameMapping[] { new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeFloat16NV), alias = "gl_ComponentTypeFloat16NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeFloat32NV), alias = "gl_ComponentTypeFloat32NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeFloat64NV), alias = "gl_ComponentTypeFloat64NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeSignedInt8NV), alias = "gl_ComponentTypeSignedInt8NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeSignedInt16NV), alias = "gl_ComponentTypeSignedInt16NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeSignedInt32NV), alias = "gl_ComponentTypeSignedInt32NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeSignedInt64NV), alias = "gl_ComponentTypeSignedInt64NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeUnsignedInt8NV), alias = "gl_ComponentTypeUnsignedInt8NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeUnsignedInt16NV), alias = "gl_ComponentTypeUnsignedInt16NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeUnsignedInt32NV), alias = "gl_ComponentTypeUnsignedInt32NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeUnsignedInt64NV), alias = "gl_ComponentTypeUnsignedInt64NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeSignedInt8PackedNV), alias = "gl_ComponentTypeSignedInt8PackedNV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeUnsignedInt8PackedNV), alias = "gl_ComponentTypeUnsignedInt8PackedNV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeFloatE4M3NV), alias = "gl_ComponentTypeFloatE4M3NV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.ComponentType.ComponentTypeFloatE5M2NV), alias = "gl_ComponentTypeFloatE5M2NV" } };
    public static GlslConstantNameMapping[] CoopVecMatrixLayoutNames = new GlslConstantNameMapping[] { new GlslConstantNameMapping { value = unchecked((uint)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutRowMajorNV), alias = "gl_CooperativeVectorMatrixLayoutRowMajorNV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutColumnMajorNV), alias = "gl_CooperativeVectorMatrixLayoutColumnMajorNV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutInferencingOptimalNV), alias = "gl_CooperativeVectorMatrixLayoutInferencingOptimalNV" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutTrainingOptimalNV), alias = "gl_CooperativeVectorMatrixLayoutTrainingOptimalNV" } };
    public static GlslConstantNameMapping[] CoopMatMatrixLayoutNames = new GlslConstantNameMapping[] { new GlslConstantNameMapping { value = unchecked((uint)Spv.CooperativeMatrixLayout.CooperativeMatrixLayoutRowMajorKHR), alias = "gl_CooperativeMatrixLayoutRowMajor" }, new GlslConstantNameMapping { value = unchecked((uint)Spv.CooperativeMatrixLayout.CooperativeMatrixLayoutColumnMajorKHR), alias = "gl_CooperativeMatrixLayoutColumnMajor" } };
    public static bool is_unsigned_opcode(Spv.Op op)
    {
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpShiftRightLogical):
                case unchecked((int)Spv.Op.OpUGreaterThan):
                case unchecked((int)Spv.Op.OpUGreaterThanEqual):
                case unchecked((int)Spv.Op.OpULessThan):
                case unchecked((int)Spv.Op.OpULessThanEqual):
                case unchecked((int)Spv.Op.OpUConvert):
                case unchecked((int)Spv.Op.OpUDiv):
                case unchecked((int)Spv.Op.OpUMod):
                case unchecked((int)Spv.Op.OpUMulExtended):
                case unchecked((int)Spv.Op.OpConvertUToF):
                case unchecked((int)Spv.Op.OpConvertFToU):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool is_unsigned_glsl_opcode(GLSLstd450 op)
    {
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)GLSLstd450.GLSLstd450UClamp):
                case unchecked((int)GLSLstd450.GLSLstd450UMin):
                case unchecked((int)GLSLstd450.GLSLstd450UMax):
                case unchecked((int)GLSLstd450.GLSLstd450FindUMsb):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool packing_is_vec4_padded(BufferPackingStandard packing)
    {
        {
            switch (unchecked((int)packing))
            {
                case unchecked((int)BufferPackingStandard.BufferPackingHLSLCbuffer):
                case unchecked((int)BufferPackingStandard.BufferPackingHLSLCbufferPackOffset):
                case unchecked((int)BufferPackingStandard.BufferPackingStd140):
                case unchecked((int)BufferPackingStandard.BufferPackingStd140EnhancedLayout):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool packing_is_hlsl(BufferPackingStandard packing)
    {
        {
            switch (unchecked((int)packing))
            {
                case unchecked((int)BufferPackingStandard.BufferPackingHLSLCbuffer):
                case unchecked((int)BufferPackingStandard.BufferPackingHLSLCbufferPackOffset):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool packing_has_flexible_offset(BufferPackingStandard packing)
    {
        {
            switch (unchecked((int)packing))
            {
                case unchecked((int)BufferPackingStandard.BufferPackingStd140):
                case unchecked((int)BufferPackingStandard.BufferPackingStd430):
                case unchecked((int)BufferPackingStandard.BufferPackingScalar):
                case unchecked((int)BufferPackingStandard.BufferPackingHLSLCbuffer):
                {
                    return false;
                }
                default:
                {
                    return true;
                }
            }
        }
    }
    public static bool packing_is_scalar(BufferPackingStandard packing)
    {
        {
            switch (unchecked((int)packing))
            {
                case unchecked((int)BufferPackingStandard.BufferPackingScalar):
                case unchecked((int)BufferPackingStandard.BufferPackingScalarEnhancedLayout):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static BufferPackingStandard packing_to_substruct_packing(BufferPackingStandard packing)
    {
        {
            switch (unchecked((int)packing))
            {
                case unchecked((int)BufferPackingStandard.BufferPackingStd140EnhancedLayout):
                {
                    return BufferPackingStandard.BufferPackingStd140;
                }
                case unchecked((int)BufferPackingStandard.BufferPackingStd430EnhancedLayout):
                {
                    return BufferPackingStandard.BufferPackingStd430;
                }
                case unchecked((int)BufferPackingStandard.BufferPackingHLSLCbufferPackOffset):
                {
                    return BufferPackingStandard.BufferPackingHLSLCbuffer;
                }
                case unchecked((int)BufferPackingStandard.BufferPackingScalarEnhancedLayout):
                {
                    return BufferPackingStandard.BufferPackingScalar;
                }
                default:
                {
                    return packing;
                }
            }
        }
    }
    public static string to_pls_layout(PlsFormat format)
    {
        {
            switch (unchecked((int)format))
            {
                case unchecked((int)PlsFormat.PlsR11FG11FB10F):
                {
                    return "layout(r11f_g11f_b10f) ";
                }
                case unchecked((int)PlsFormat.PlsR32F):
                {
                    return "layout(r32f) ";
                }
                case unchecked((int)PlsFormat.PlsRG16F):
                {
                    return "layout(rg16f) ";
                }
                case unchecked((int)PlsFormat.PlsRGB10A2):
                {
                    return "layout(rgb10_a2) ";
                }
                case unchecked((int)PlsFormat.PlsRGBA8):
                {
                    return "layout(rgba8) ";
                }
                case unchecked((int)PlsFormat.PlsRG16):
                {
                    return "layout(rg16) ";
                }
                case unchecked((int)PlsFormat.PlsRGBA8I):
                {
                    return "layout(rgba8i)";
                }
                case unchecked((int)PlsFormat.PlsRG16I):
                {
                    return "layout(rg16i) ";
                }
                case unchecked((int)PlsFormat.PlsRGB10A2UI):
                {
                    return "layout(rgb10_a2ui) ";
                }
                case unchecked((int)PlsFormat.PlsRGBA8UI):
                {
                    return "layout(rgba8ui) ";
                }
                case unchecked((int)PlsFormat.PlsRG16UI):
                {
                    return "layout(rg16ui) ";
                }
                case unchecked((int)PlsFormat.PlsR32UI):
                {
                    return "layout(r32ui) ";
                }
                default:
                {
                    return "";
                }
            }
        }
    }
    public static Pair<Spv.Op, SPIRType.BaseType> pls_format_to_basetype(PlsFormat format)
    {
        {
            switch (unchecked((int)format))
            {
                default:
                case unchecked((int)PlsFormat.PlsR11FG11FB10F):
                case unchecked((int)PlsFormat.PlsR32F):
                case unchecked((int)PlsFormat.PlsRG16F):
                case unchecked((int)PlsFormat.PlsRGB10A2):
                case unchecked((int)PlsFormat.PlsRGBA8):
                case unchecked((int)PlsFormat.PlsRG16):
                {
                    return Std.make_pair(Spv.Op.OpTypeFloat, SPIRType.BaseType.Float);
                }
                case unchecked((int)PlsFormat.PlsRGBA8I):
                case unchecked((int)PlsFormat.PlsRG16I):
                {
                    return Std.make_pair(Spv.Op.OpTypeInt, SPIRType.BaseType.Int);
                }
                case unchecked((int)PlsFormat.PlsRGB10A2UI):
                case unchecked((int)PlsFormat.PlsRGBA8UI):
                case unchecked((int)PlsFormat.PlsRG16UI):
                case unchecked((int)PlsFormat.PlsR32UI):
                {
                    return Std.make_pair(Spv.Op.OpTypeInt, SPIRType.BaseType.UInt);
                }
            }
        }
    }
    public static uint pls_format_to_components(PlsFormat format)
    {
        {
            switch (unchecked((int)format))
            {
                default:
                case unchecked((int)PlsFormat.PlsR32F):
                case unchecked((int)PlsFormat.PlsR32UI):
                {
                    return 1u;
                }
                case unchecked((int)PlsFormat.PlsRG16F):
                case unchecked((int)PlsFormat.PlsRG16):
                case unchecked((int)PlsFormat.PlsRG16UI):
                case unchecked((int)PlsFormat.PlsRG16I):
                {
                    return 2u;
                }
                case unchecked((int)PlsFormat.PlsR11FG11FB10F):
                {
                    return 3u;
                }
                case unchecked((int)PlsFormat.PlsRGB10A2):
                case unchecked((int)PlsFormat.PlsRGBA8):
                case unchecked((int)PlsFormat.PlsRGBA8I):
                case unchecked((int)PlsFormat.PlsRGB10A2UI):
                case unchecked((int)PlsFormat.PlsRGBA8UI):
                {
                    return 4u;
                }
            }
        }
    }
    public static bool is_block_builtin(Spv.BuiltIn builtin)
    {
        return unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPosition) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInPointSize) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInClipDistance) || unchecked((int)builtin) == unchecked((int)Spv.BuiltIn.BuiltInCullDistance);
    }
    public static bool image_opcode_is_sample_no_dref(Spv.Op op)
    {
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpImageSampleExplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjExplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                case unchecked((int)Spv.Op.OpImageFetch):
                case unchecked((int)Spv.Op.OpImageRead):
                case unchecked((int)Spv.Op.OpImageSparseSampleExplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleImplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleProjExplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleProjImplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseFetch):
                case unchecked((int)Spv.Op.OpImageSparseRead):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool opcode_is_precision_sensitive_operation(Spv.Op op)
    {
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpFAdd):
                case unchecked((int)Spv.Op.OpFSub):
                case unchecked((int)Spv.Op.OpFMul):
                case unchecked((int)Spv.Op.OpFNegate):
                case unchecked((int)Spv.Op.OpIAdd):
                case unchecked((int)Spv.Op.OpISub):
                case unchecked((int)Spv.Op.OpIMul):
                case unchecked((int)Spv.Op.OpSNegate):
                case unchecked((int)Spv.Op.OpFMod):
                case unchecked((int)Spv.Op.OpFDiv):
                case unchecked((int)Spv.Op.OpFRem):
                case unchecked((int)Spv.Op.OpSMod):
                case unchecked((int)Spv.Op.OpSDiv):
                case unchecked((int)Spv.Op.OpSRem):
                case unchecked((int)Spv.Op.OpUMod):
                case unchecked((int)Spv.Op.OpUDiv):
                case unchecked((int)Spv.Op.OpVectorTimesMatrix):
                case unchecked((int)Spv.Op.OpMatrixTimesVector):
                case unchecked((int)Spv.Op.OpMatrixTimesMatrix):
                case unchecked((int)Spv.Op.OpDPdx):
                case unchecked((int)Spv.Op.OpDPdy):
                case unchecked((int)Spv.Op.OpDPdxCoarse):
                case unchecked((int)Spv.Op.OpDPdyCoarse):
                case unchecked((int)Spv.Op.OpDPdxFine):
                case unchecked((int)Spv.Op.OpDPdyFine):
                case unchecked((int)Spv.Op.OpFwidth):
                case unchecked((int)Spv.Op.OpFwidthCoarse):
                case unchecked((int)Spv.Op.OpFwidthFine):
                case unchecked((int)Spv.Op.OpVectorTimesScalar):
                case unchecked((int)Spv.Op.OpMatrixTimesScalar):
                case unchecked((int)Spv.Op.OpOuterProduct):
                case unchecked((int)Spv.Op.OpFConvert):
                case unchecked((int)Spv.Op.OpSConvert):
                case unchecked((int)Spv.Op.OpUConvert):
                case unchecked((int)Spv.Op.OpConvertSToF):
                case unchecked((int)Spv.Op.OpConvertUToF):
                case unchecked((int)Spv.Op.OpConvertFToU):
                case unchecked((int)Spv.Op.OpConvertFToS):
                case unchecked((int)Spv.Op.OpShiftLeftLogical):
                case unchecked((int)Spv.Op.OpShiftRightLogical):
                case unchecked((int)Spv.Op.OpShiftRightArithmetic):
                case unchecked((int)Spv.Op.OpBitwiseOr):
                case unchecked((int)Spv.Op.OpBitwiseXor):
                case unchecked((int)Spv.Op.OpBitwiseAnd):
                case unchecked((int)Spv.Op.OpNot):
                case unchecked((int)Spv.Op.OpBitFieldInsert):
                case unchecked((int)Spv.Op.OpBitFieldSExtract):
                case unchecked((int)Spv.Op.OpBitFieldUExtract):
                case unchecked((int)Spv.Op.OpBitReverse):
                case unchecked((int)Spv.Op.OpBitCount):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool opcode_is_precision_forwarding_instruction(Spv.Op op, ref uint arg_count)
    {
        {
            switch (unchecked((int)op))
            {
                case unchecked((int)Spv.Op.OpLoad):
                case unchecked((int)Spv.Op.OpAccessChain):
                case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                case unchecked((int)Spv.Op.OpCompositeExtract):
                case unchecked((int)Spv.Op.OpVectorExtractDynamic):
                case unchecked((int)Spv.Op.OpSampledImage):
                case unchecked((int)Spv.Op.OpImage):
                case unchecked((int)Spv.Op.OpCopyObject):
                case unchecked((int)Spv.Op.OpImageRead):
                case unchecked((int)Spv.Op.OpImageFetch):
                case unchecked((int)Spv.Op.OpImageSampleImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleExplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjExplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleDrefExplicitLod):
                case unchecked((int)Spv.Op.OpImageSampleProjDrefExplicitLod):
                case unchecked((int)Spv.Op.OpImageGather):
                case unchecked((int)Spv.Op.OpImageDrefGather):
                case unchecked((int)Spv.Op.OpImageSparseRead):
                case unchecked((int)Spv.Op.OpImageSparseFetch):
                case unchecked((int)Spv.Op.OpImageSparseSampleImplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleProjImplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleDrefImplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefImplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleExplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleProjExplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleDrefExplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefExplicitLod):
                case unchecked((int)Spv.Op.OpImageSparseGather):
                case unchecked((int)Spv.Op.OpImageSparseDrefGather):
                {
                    arg_count = 1u;
                    return true;
                }
                case unchecked((int)Spv.Op.OpVectorShuffle):
                {
                    arg_count = 2u;
                    return true;
                }
                case unchecked((int)Spv.Op.OpCompositeConstruct):
                {
                    return true;
                }
                default:
                {
                    break;
                }
            }
        }
        return false;
    }
    public static Pair<CppString, CppString> split_coopmat_pointer(CppString expr)
    {
        var ptr_expr = expr;
        CppString index_expr = default(CppString);
        if (unchecked((int)ptr_expr.back()) != 93)
        {
            throw new CompilerError("Access chain for coopmat must be indexed into an array.");
        }
        ptr_expr.pop_back();
        uint counter = 1u;
        while (counter != 0u && !ptr_expr.empty())
        {
            if (unchecked((int)ptr_expr.back()) == 93)
            {
                counter++;
            }
            else
            if (unchecked((int)ptr_expr.back()) == 91)
            {
                counter--;
            }
            ptr_expr.pop_back();
        }
        if (ptr_expr.empty())
        {
            throw new CompilerError("Invalid pointer expression for coopmat.");
        }
        index_expr = expr.substr(ptr_expr.size() + 1UL, expr.size() - (ptr_expr.size() + 1UL) - 1UL);
        return new Pair<CppString, CppString>(ptr_expr, index_expr);
    }
    public static SPIRCombinedImageSampler variant_set__SPIRCombinedImageSampler_X(Variant @var, uint args, uint args_1, uint args_2)
    {
        var ptr = @var.allocate_and_set__SPIRCombinedImageSampler_X(unchecked((Types)SPIRCombinedImageSampler.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRAccessChain variant_set__SPIRAccessChain_X(Variant @var, uint args, Spv.StorageClass args_1, CppString args_2, CppString args_3, uint args_4)
    {
        var ptr = @var.allocate_and_set__SPIRAccessChain_X(unchecked((Types)SPIRAccessChain.type), args, args_1, args_2, args_3, args_4);
        return ptr;
    }
    public static ImageFormatNormalizedState image_format_to_normalized_state(Spv.ImageFormat fmt)
    {
        {
            switch (unchecked((int)fmt))
            {
                case unchecked((int)Spv.ImageFormat.ImageFormatR8):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10A2):
                {
                    return ImageFormatNormalizedState.Unorm;
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16Snorm):
                {
                    return ImageFormatNormalizedState.Snorm;
                }
                default:
                {
                    break;
                }
            }
        }
        return ImageFormatNormalizedState.None;
    }
    public static uint image_format_to_components(Spv.ImageFormat fmt)
    {
        {
            switch (unchecked((int)fmt))
            {
                case unchecked((int)Spv.ImageFormat.ImageFormatR8):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16):
                case unchecked((int)Spv.ImageFormat.ImageFormatR8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16f):
                case unchecked((int)Spv.ImageFormat.ImageFormatR32f):
                case unchecked((int)Spv.ImageFormat.ImageFormatR8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16i):
                case unchecked((int)Spv.ImageFormat.ImageFormatR32i):
                case unchecked((int)Spv.ImageFormat.ImageFormatR8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatR32ui):
                {
                    return 1u;
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16f):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32f):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32ui):
                {
                    return 2u;
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR11fG11fB10f):
                {
                    return 3u;
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10A2):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16f):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32f):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10a2ui):
                {
                    return 4u;
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatUnknown):
                {
                    return 4u;
                }
                default:
                {
                    throw new CompilerError("Unrecognized typed image format.");
                }
            }
        }
    }
    public static CppString image_format_to_type(Spv.ImageFormat fmt, SPIRType.BaseType basetype)
    {
        {
            switch (unchecked((int)fmt))
            {
                case unchecked((int)Spv.ImageFormat.ImageFormatR8):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("unorm float");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("unorm float2");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("unorm float4");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10A2):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("unorm float4");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16Snorm):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("snorm float");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16Snorm):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("snorm float2");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8Snorm):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16Snorm):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("snorm float4");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR16f):
                case unchecked((int)Spv.ImageFormat.ImageFormatR32f):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("float");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16f):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32f):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("float2");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16f):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32f):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("float4");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR11fG11fB10f):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Float))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("float3");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16i):
                case unchecked((int)Spv.ImageFormat.ImageFormatR32i):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Int))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("int");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32i):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Int))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("int2");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16i):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32i):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.Int))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("int4");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatR16ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatR32ui):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.UInt))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("uint");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32ui):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.UInt))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("uint2");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16ui):
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32ui):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.UInt))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("uint4");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10a2ui):
                {
                    if (unchecked((int)basetype) != unchecked((int)SPIRType.BaseType.UInt))
                    {
                        throw new CompilerError("Mismatch in image type and base type of image.");
                    }
                    return new CppString("uint4");
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatUnknown):
                {
                    {
                        switch (unchecked((int)basetype))
                        {
                            case unchecked((int)SPIRType.BaseType.Float):
                            {
                                return new CppString("float4");
                            }
                            case unchecked((int)SPIRType.BaseType.Int):
                            {
                                return new CppString("int4");
                            }
                            case unchecked((int)SPIRType.BaseType.UInt):
                            {
                                return new CppString("uint4");
                            }
                            default:
                            {
                                throw new CompilerError("Unsupported base type for image.");
                            }
                        }
                    }
                    goto default;
                }
                default:
                {
                    throw new CompilerError("Unrecognized typed image format.");
                }
            }
        }
    }
    public static SPIRConstant variant_set__SPIRConstant_X(Variant @var, uint args, SPIRConstant[] args_1, int args_2, bool args_3)
    {
        var ptr = @var.allocate_and_set__SPIRConstant_X(unchecked((Types)SPIRConstant.type), args, args_1, args_2, args_3);
        return ptr;
    }
    public static SPIRVariable variant_set__SPIRVariable_X(Variant @var, uint args, Spv.StorageClass args_1, int args_2, uint args_3)
    {
        var ptr = @var.allocate_and_set__SPIRVariable_X(unchecked((Types)SPIRVariable.type), args, args_1, args_2, args_3);
        return ptr;
    }
    public static SPIRVariable variant_set__SPIRVariable_X(Variant @var, SPIRVariable args)
    {
        var ptr = @var.allocate_and_set__SPIRVariable_X(unchecked((Types)SPIRVariable.type), args);
        return ptr;
    }
    public static SPIRExpression variant_set__SPIRExpression_X(Variant @var, string args, TypedID_TypeType args_1, bool args_2)
    {
        var ptr = @var.allocate_and_set__SPIRExpression_X(unchecked((Types)SPIRExpression.type), args, args_1, args_2);
        return ptr;
    }
    public static SPIRFunction variant_set__SPIRFunction_X(Variant @var, TypedID_TypeType args, uint args_1, TypedID_TypeType args_2)
    {
        var ptr = @var.allocate_and_set__SPIRFunction_X(unchecked((Types)SPIRFunction.type), args, args_1, args_2);
        return ptr;
    }
    public static uint kPushConstDescSet = Globals.ResourceBindingPushConstantDescriptorSet;
    public static uint kPushConstBinding = Globals.ResourceBindingPushConstantBinding;
    public static uint kSwizzleBufferBinding = ~1u;
    public static uint kBufferSizeBufferBinding = ~2u;
    public static uint kArgumentBufferBinding = ~3u;
    public static uint kMaxArgumentBuffers = 16u;
    public static uint k_unknown_location = ~0u;
    public static uint k_unknown_component = ~0u;
    public static string force_inline = "static inline __attribute__((always_inline))";
    public static CppString create_sampler_address(string prefix, MSLSamplerAddress addr)
    {
        {
            switch (unchecked((int)addr))
            {
                case unchecked((int)MSLSamplerAddress.MSL_SAMPLER_ADDRESS_CLAMP_TO_EDGE):
                {
                    return Std.join(prefix, "address::clamp_to_edge");
                }
                case unchecked((int)MSLSamplerAddress.MSL_SAMPLER_ADDRESS_CLAMP_TO_ZERO):
                {
                    return Std.join(prefix, "address::clamp_to_zero");
                }
                case unchecked((int)MSLSamplerAddress.MSL_SAMPLER_ADDRESS_CLAMP_TO_BORDER):
                {
                    return Std.join(prefix, "address::clamp_to_border");
                }
                case unchecked((int)MSLSamplerAddress.MSL_SAMPLER_ADDRESS_REPEAT):
                {
                    return Std.join(prefix, "address::repeat");
                }
                case unchecked((int)MSLSamplerAddress.MSL_SAMPLER_ADDRESS_MIRRORED_REPEAT):
                {
                    return Std.join(prefix, "address::mirrored_repeat");
                }
                default:
                {
                    throw new CompilerError("Invalid sampler addressing mode.");
                }
            }
        }
    }
    public static bool expression_ends_with(CppString expr_str, CppString ending)
    {
        if (expr_str.length() >= ending.length())
        {
            return expr_str.compare(expr_str.length() - ending.length(), ending.length(), ending) == 0;
        }
        else
        {
            return false;
        }
    }
    public static CppString inject_top_level_storage_qualifier(CppString expr, CppString qualifier)
    {
        ulong last_reference = expr.find_last_of('&', CppString.npos);
        ulong last_pointer = expr.find_last_of('*', CppString.npos);
        ulong last_significant = CppString.npos;
        if (last_reference == CppString.npos)
        {
            last_significant = last_pointer;
        }
        else
        if (last_pointer == CppString.npos)
        {
            last_significant = last_reference;
        }
        else
        {
            last_significant = Std.max(last_reference, last_pointer);
        }
        if (last_significant == CppString.npos)
        {
            return Std.join(qualifier, " ", expr);
        }
        else
        {
            return Std.join(expr.substr(0UL, last_significant + 1UL), " ", qualifier, expr.substr(last_significant + 1UL, CppString.npos));
        }
    }
    public static uint k_cooperative_matrix_components_per_thread = unchecked((uint)(8 * 8 / 32));
    public static bool storage_class_array_is_thread(Spv.StorageClass storage)
    {
        {
            switch (unchecked((int)storage))
            {
                case unchecked((int)Spv.StorageClass.StorageClassInput):
                case unchecked((int)Spv.StorageClass.StorageClassOutput):
                case unchecked((int)Spv.StorageClass.StorageClassGeneric):
                case unchecked((int)Spv.StorageClass.StorageClassFunction):
                case unchecked((int)Spv.StorageClass.StorageClassPrivate):
                {
                    return true;
                }
                default:
                {
                    return false;
                }
            }
        }
    }
    public static bool needs_chroma_reconstruction(MSLConstexprSampler constexpr_sampler)
    {
        return constexpr_sampler != null && constexpr_sampler.ycbcr_conversion_enable && constexpr_sampler.planes > 1u;
    }
    public static bool sampling_type_needs_f32_conversion(SPIRType type)
    {
        return unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Half) || unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Double);
    }
    public static CppString create_swizzle(MSLComponentSwizzle swizzle)
    {
        {
            switch (unchecked((int)swizzle))
            {
                case unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_IDENTITY):
                {
                    return new CppString("spvSwizzle::none");
                }
                case unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ZERO):
                {
                    return new CppString("spvSwizzle::zero");
                }
                case unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ONE):
                {
                    return new CppString("spvSwizzle::one");
                }
                case unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_R):
                {
                    return new CppString("spvSwizzle::red");
                }
                case unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_G):
                {
                    return new CppString("spvSwizzle::green");
                }
                case unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_B):
                {
                    return new CppString("spvSwizzle::blue");
                }
                case unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_A):
                {
                    return new CppString("spvSwizzle::alpha");
                }
                default:
                {
                    throw new CompilerError("Invalid component swizzle.");
                }
            }
        }
    }
    public static bool naturally_emit_type(SPIRType type)
    {
        return unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct) && !type.pointer && type.array.empty();
    }
    public static void rename_interface_variable(Compiler compiler, CppVector<Resource> resources, uint location, CppString name)
    {
        {
            foreach (Resource v in resources)
            {
                if (!compiler.has_decoration(v.id, Spv.Decoration.DecorationLocation))
                {
                    continue;
                }
                var loc = compiler.get_decoration(v.id, Spv.Decoration.DecorationLocation);
                if (loc != location)
                {
                    continue;
                }
                var type = compiler.get_type(v.base_type_id);
                if (unchecked((int)type.basetype) == unchecked((int)SPIRType.BaseType.Struct))
                {
                    compiler.set_name(new TypedID_TypeNone(v.base_type_id), Std.join("SPIRV_Cross_Interface_Location", location));
                    {
                        for (uint i = 0u; i < unchecked((uint)type.member_types.size()); i++)
                        {
                            compiler.set_member_name(v.base_type_id, i, Std.join("InterfaceMember", i));
                        }
                    }
                }
                compiler.set_name(v.id, name);
            }
        }
    }
    public static void inherit_combined_sampler_bindings(Compiler compiler)
    {
        var samplers = compiler.get_combined_image_samplers();
        {
            foreach (CombinedImageSampler s in samplers)
            {
                if (compiler.has_decoration(new TypedID_TypeNone(s.image_id), Spv.Decoration.DecorationDescriptorSet))
                {
                    uint set = compiler.get_decoration(new TypedID_TypeNone(s.image_id), Spv.Decoration.DecorationDescriptorSet);
                    compiler.set_decoration(new TypedID_TypeNone(s.combined_id), Spv.Decoration.DecorationDescriptorSet, set);
                }
                if (compiler.has_decoration(new TypedID_TypeNone(s.image_id), Spv.Decoration.DecorationBinding))
                {
                    uint binding = compiler.get_decoration(new TypedID_TypeNone(s.image_id), Spv.Decoration.DecorationBinding);
                    compiler.set_decoration(new TypedID_TypeNone(s.combined_id), Spv.Decoration.DecorationBinding, binding);
                }
            }
        }
    }
}
