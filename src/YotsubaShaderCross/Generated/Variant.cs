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

public partial class Variant : System.IDisposable
{
    public Variant(ObjectPoolGroup group_)
    {
        this.group = group_;
    }
    public void Dispose()
    {
        if (holder != null)
        {
            group.pools[(int)type].deallocate_opaque(holder);
        }
    }
    public Variant(Variant other)
    {
        this.CopyFrom(other);
    }
    public Variant operator_assign(Variant other)
    {
        if (this != other)
        {
            if (holder != null)
            {
                group.pools[(int)type].deallocate_opaque(holder);
            }
            holder = other.holder;
            group = other.group;
            type = other.type;
            allow_type_rewrite = other.allow_type_rewrite;
            other.holder = null;
            other.type = Types.TypeNone;
        }
        return this;
    }
    public void set(IVariant val, Types new_type)
    {
        if (holder != null)
        {
            group.pools[(int)type].deallocate_opaque(holder);
        }
        holder = null;
        if (!allow_type_rewrite && unchecked((int)type) != unchecked((int)Types.TypeNone) && unchecked((int)type) != unchecked((int)new_type))
        {
            if (val != null)
            {
                group.pools[(int)new_type].deallocate_opaque(val);
            }
            throw new CompilerError("Overwriting a variant with new type.");
        }
        holder = val;
        type = new_type;
        allow_type_rewrite = false;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, uint ts)
    {
        SPIRConstant val = new SPIRConstant((uint)(ts));
        set(val, new_type);
        return val;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, uint ts, Ptr<uint> ts_1, uint ts_2, bool ts_3)
    {
        SPIRConstant val = new SPIRConstant(ts, ts_1, ts_2, ts_3);
        set(val, new_type);
        return val;
    }
    public SPIRVariable get__SPIRVariable()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRVariable.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRVariable)holder;
    }
    public SPIRConstant get__SPIRConstant()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRConstant.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRConstant)holder;
    }
    public SPIRConstantOp get__SPIRConstantOp()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRConstantOp.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRConstantOp)holder;
    }
    public SPIRType get__SPIRType()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRType.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRType)holder;
    }
    public Types get_type()
    {
        return type;
    }
    public TypedID_TypeNone get_id()
    {
        return holder != null ? holder.self : new TypedID_TypeNone(0u);
    }
    public bool empty()
    {
        return !(holder != null);
    }
    public void reset()
    {
        if (holder != null)
        {
            group.pools[(int)type].deallocate_opaque(holder);
        }
        holder = null;
        type = Types.TypeNone;
    }
    public void set_allow_type_rewrite()
    {
        allow_type_rewrite = true;
    }
    public ObjectPoolGroup group = null;
    public IVariant holder = null;
    public Types type = Types.TypeNone;
    public bool allow_type_rewrite = false;
    public SPIRBlock get__SPIRBlock()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRBlock.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRBlock)holder;
    }
    public SPIRType allocate_and_set__SPIRType_X(Types new_type, Spv.Op ts)
    {
        SPIRType val = new SPIRType(ts);
        set(val, new_type);
        return val;
    }
    public SPIRVariable allocate_and_set__SPIRVariable_X(Types new_type, uint ts, Spv.StorageClass ts_1, int ts_2)
    {
        SPIRVariable val = new SPIRVariable(ts, ts_1, ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRExpression allocate_and_set__SPIRExpression_X(Types new_type, string ts, uint ts_1, bool ts_2)
    {
        SPIRExpression val = new SPIRExpression(ts, ts_1, ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRFunction get__SPIRFunction()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRFunction.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRFunction)holder;
    }
    public SPIRExtension get__SPIRExtension()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRExtension.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRExtension)holder;
    }
    public SPIRAccessChain get__SPIRAccessChain()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRAccessChain.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRAccessChain)holder;
    }
    public SPIRExpression get__SPIRExpression()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRExpression.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRExpression)holder;
    }
    public SPIRUndef get__SPIRUndef()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRUndef.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRUndef)holder;
    }
    public SPIRCombinedImageSampler get__SPIRCombinedImageSampler()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRCombinedImageSampler.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRCombinedImageSampler)holder;
    }
    public SPIRConstantData get__SPIRConstantData()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRConstantData.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRConstantData)holder;
    }
    public SPIRString allocate_and_set__SPIRString_X(Types new_type, CppString ts)
    {
        SPIRString val = new SPIRString(ts);
        set(val, new_type);
        return val;
    }
    public SPIRUndef allocate_and_set__SPIRUndef_X(Types new_type, uint ts)
    {
        SPIRUndef val = new SPIRUndef((TypedID_TypeType)(ts));
        set(val, new_type);
        return val;
    }
    public SPIRExtension allocate_and_set__SPIRExtension_X(Types new_type, SPIRExtension.Extension ts)
    {
        SPIRExtension val = new SPIRExtension(ts);
        set(val, new_type);
        return val;
    }
    public SPIRDebugLocalVariable allocate_and_set__SPIRDebugLocalVariable_X(Types new_type)
    {
        SPIRDebugLocalVariable val = new SPIRDebugLocalVariable();
        set(val, new_type);
        return val;
    }
    public SPIRType allocate_and_set__SPIRType_X(Types new_type, SPIRType ts)
    {
        SPIRType val = ts.Clone();
        set(val, new_type);
        return val;
    }
    public SPIRFunctionPrototype allocate_and_set__SPIRFunctionPrototype_X(Types new_type, uint ts)
    {
        SPIRFunctionPrototype val = new SPIRFunctionPrototype((TypedID_TypeType)(ts));
        set(val, new_type);
        return val;
    }
    public SPIRVariable allocate_and_set__SPIRVariable_X(Types new_type, uint ts, Spv.StorageClass ts_1, uint ts_2)
    {
        SPIRVariable val = new SPIRVariable(ts, ts_1, ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRVariable allocate_and_set__SPIRVariable_X(Types new_type, uint ts, Spv.StorageClass ts_1)
    {
        SPIRVariable val = new SPIRVariable(ts, ts_1);
        set(val, new_type);
        return val;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, uint ts, Ptr<uint> ts_1, int ts_2, bool ts_3, bool ts_4)
    {
        SPIRConstant val = new SPIRConstant((TypedID_TypeType)(ts), Std.ptr_of<uint>(ts_1), (uint)(ts_2), ts_3, ts_4);
        set(val, new_type);
        return val;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, uint ts, ulong ts_1, bool ts_2)
    {
        SPIRConstant val = new SPIRConstant((TypedID_TypeType)(ts), (ulong)(ts_1), ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, uint ts, uint ts_1, bool ts_2)
    {
        SPIRConstant val = new SPIRConstant((TypedID_TypeType)(ts), (uint)(ts_1), ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, uint ts, SPIRConstant[] ts_1, uint ts_2, bool ts_3)
    {
        SPIRConstant val = new SPIRConstant((TypedID_TypeType)(ts), Std.ptr_of<SPIRConstant>(ts_1), (uint)(ts_2), ts_3);
        set(val, new_type);
        return val;
    }
    public SPIRConstantData allocate_and_set__SPIRConstantData_X(Types new_type, uint ts, Ptr<uint> ts_1, uint ts_2, bool ts_3)
    {
        SPIRConstantData val = new SPIRConstantData((TypedID_TypeType)(ts), Std.ptr_of<uint>(ts_1), (uint)(ts_2), ts_3);
        set(val, new_type);
        return val;
    }
    public SPIRFunction allocate_and_set__SPIRFunction_X(Types new_type, uint ts, uint ts_1, uint ts_2)
    {
        SPIRFunction val = new SPIRFunction((TypedID_TypeType)(ts), (uint)(ts_1), (TypedID_TypeType)(ts_2));
        set(val, new_type);
        return val;
    }
    public SPIRBlock allocate_and_set__SPIRBlock_X(Types new_type)
    {
        SPIRBlock val = new SPIRBlock();
        set(val, new_type);
        return val;
    }
    public SPIRConstantOp allocate_and_set__SPIRConstantOp_X(Types new_type, uint ts, Spv.Op ts_1, Ptr<uint> ts_2, uint ts_3)
    {
        SPIRConstantOp val = new SPIRConstantOp((TypedID_TypeType)(ts), ts_1, Std.ptr_of<uint>(ts_2), (uint)(ts_3));
        set(val, new_type);
        return val;
    }
    public SPIRString get__SPIRString()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRString.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRString)holder;
    }
    public SPIRDebugLocalVariable get__SPIRDebugLocalVariable()
    {
        if (!(holder != null))
        {
            throw new CompilerError("nullptr");
        }
        if (unchecked((int)unchecked((Types)SPIRDebugLocalVariable.type)) != unchecked((int)type))
        {
            throw new CompilerError("Bad cast");
        }
        return (SPIRDebugLocalVariable)holder;
    }
    public SPIRExpression allocate_and_set__SPIRExpression_X(Types new_type, CppString ts, uint ts_1, bool ts_2)
    {
        SPIRExpression val = new SPIRExpression(ts, (TypedID_TypeType)(ts_1), ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, TypedID_TypeType ts)
    {
        SPIRConstant val = new SPIRConstant((uint)(ts));
        set(val, new_type);
        return val;
    }
    public SPIRAccessChain allocate_and_set__SPIRAccessChain_X(Types new_type, SPIRAccessChain ts)
    {
        SPIRAccessChain val = ts.Clone();
        set(val, new_type);
        return val;
    }
    public SPIRCombinedImageSampler allocate_and_set__SPIRCombinedImageSampler_X(Types new_type, SPIRCombinedImageSampler ts)
    {
        SPIRCombinedImageSampler val = ts.Clone();
        set(val, new_type);
        return val;
    }
    public SPIRExpression allocate_and_set__SPIRExpression_X(Types new_type, CppString ts, TypedID_TypeType ts_1, bool ts_2)
    {
        SPIRExpression val = new SPIRExpression(ts, (TypedID_TypeType)(ts_1), ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRCombinedImageSampler allocate_and_set__SPIRCombinedImageSampler_X(Types new_type, uint ts, uint ts_1, uint ts_2)
    {
        SPIRCombinedImageSampler val = new SPIRCombinedImageSampler((TypedID_TypeType)(ts), (TypedID_TypeVariable)(ts_1), (TypedID_TypeVariable)(ts_2));
        set(val, new_type);
        return val;
    }
    public SPIRAccessChain allocate_and_set__SPIRAccessChain_X(Types new_type, uint ts, Spv.StorageClass ts_1, CppString ts_2, CppString ts_3, uint ts_4)
    {
        SPIRAccessChain val = new SPIRAccessChain((TypedID_TypeType)(ts), ts_1, ts_2, ts_3, (int)(ts_4));
        set(val, new_type);
        return val;
    }
    public SPIRConstant allocate_and_set__SPIRConstant_X(Types new_type, uint ts, SPIRConstant[] ts_1, int ts_2, bool ts_3)
    {
        SPIRConstant val = new SPIRConstant((TypedID_TypeType)(ts), Std.ptr_of<SPIRConstant>(ts_1), (uint)(ts_2), ts_3);
        set(val, new_type);
        return val;
    }
    public SPIRVariable allocate_and_set__SPIRVariable_X(Types new_type, uint ts, Spv.StorageClass ts_1, int ts_2, uint ts_3)
    {
        SPIRVariable val = new SPIRVariable((TypedID_TypeType)(ts), ts_1, (TypedID_TypeNone)(ts_2), (TypedID_TypeVariable)(ts_3));
        set(val, new_type);
        return val;
    }
    public SPIRVariable allocate_and_set__SPIRVariable_X(Types new_type, SPIRVariable ts)
    {
        SPIRVariable val = ts.Clone();
        set(val, new_type);
        return val;
    }
    public SPIRExpression allocate_and_set__SPIRExpression_X(Types new_type, string ts, TypedID_TypeType ts_1, bool ts_2)
    {
        SPIRExpression val = new SPIRExpression(ts, ts_1, ts_2);
        set(val, new_type);
        return val;
    }
    public SPIRFunction allocate_and_set__SPIRFunction_X(Types new_type, TypedID_TypeType ts, uint ts_1, TypedID_TypeType ts_2)
    {
        SPIRFunction val = new SPIRFunction((TypedID_TypeType)(ts), (uint)(ts_1), (TypedID_TypeType)(ts_2));
        set(val, new_type);
        return val;
    }

    protected virtual void FixClone()
    {
    }

    public Variant Clone()
    {
        var __c = (Variant)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(Variant o)
    {
        this.group = o.group;
        this.holder = o.holder;
        this.type = o.type;
        this.allow_type_rewrite = o.allow_type_rewrite;
    }
}
