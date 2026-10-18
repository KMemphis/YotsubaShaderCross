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
// Upstream sources: spirv.hpp
// Upstream copyright: Copyright 2014-2024 The Khronos Group Inc.
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross.Spv;

public static partial class Globals
{
    public static uint MagicNumber = 119734787u;
    public static uint Version = 67072u;
    public static uint Revision = 1u;
    public static uint OpCodeMask = 65535u;
    public static uint WordCountShift = 16u;
    public static void HasResultAndType(Spv.Op opcode, Ptr<bool> hasResult, Ptr<bool> hasResultType)
    {
        hasResult.Value = hasResultType.Value = false;
        {
            switch (unchecked((int)opcode))
            {
                default:
                {
                    break;
                }
                case unchecked((int)Spv.Op.OpNop):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpUndef):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSourceContinued):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSource):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSourceExtension):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpName):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpMemberName):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpString):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpLine):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExtension):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExtInstImport):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExtInst):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMemoryModel):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpEntryPoint):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExecutionMode):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCapability):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeVoid):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeBool):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeInt):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeFloat):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeVector):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeMatrix):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeImage):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeSampler):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeSampledImage):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeArray):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeRuntimeArray):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeStruct):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeOpaque):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypePointer):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeFunction):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeEvent):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeDeviceEvent):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeReserveId):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeQueue):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypePipe):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeForwardPointer):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantTrue):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantFalse):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstant):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantComposite):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantSampler):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantNull):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantTrue):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantFalse):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstant):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantComposite):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantOp):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFunction):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFunctionParameter):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFunctionEnd):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpFunctionCall):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpVariable):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageTexelPointer):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLoad):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpStore):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCopyMemory):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCopyMemorySized):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAccessChain):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPtrAccessChain):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArrayLength):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGenericPtrMemSemantics):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpInBoundsPtrAccessChain):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDecorate):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpMemberDecorate):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpDecorationGroup):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupDecorate):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupMemberDecorate):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpVectorExtractDynamic):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpVectorInsertDynamic):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpVectorShuffle):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCompositeConstruct):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCompositeExtract):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCompositeInsert):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCopyObject):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTranspose):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSampledImage):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleDrefExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleProjExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleProjDrefExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageFetch):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageGather):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageDrefGather):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageRead):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageWrite):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpImage):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQueryFormat):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQueryOrder):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQuerySizeLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQuerySize):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQueryLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQueryLevels):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageQuerySamples):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertFToU):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertFToS):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertSToF):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertUToF):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUConvert):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSConvert):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFConvert):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpQuantizeToF16):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertPtrToU):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSatConvertSToU):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSatConvertUToS):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertUToPtr):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPtrCastToGeneric):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGenericCastToPtr):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGenericCastToPtrExplicit):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitcast):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSNegate):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFNegate):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIAdd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFAdd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpISub):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFSub):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIMul):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFMul):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUDiv):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSDiv):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFDiv):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUMod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSRem):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSMod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFRem):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFMod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpVectorTimesScalar):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMatrixTimesScalar):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpVectorTimesMatrix):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMatrixTimesVector):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMatrixTimesMatrix):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpOuterProduct):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIAddCarry):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpISubBorrow):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUMulExtended):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSMulExtended):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAny):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAll):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsNan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsInf):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsFinite):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsNormal):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSignBitSet):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLessOrGreater):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpOrdered):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUnordered):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalNotEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalOr):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalAnd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLogicalNot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSelect):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpINotEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUGreaterThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSGreaterThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUGreaterThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSGreaterThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpULessThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSLessThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpULessThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSLessThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFOrdEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFUnordEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFOrdNotEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFUnordNotEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFOrdLessThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFUnordLessThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFOrdGreaterThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFUnordGreaterThan):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFOrdLessThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFUnordLessThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFOrdGreaterThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFUnordGreaterThanEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpShiftRightLogical):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpShiftRightArithmetic):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpShiftLeftLogical):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitwiseOr):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitwiseXor):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitwiseAnd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpNot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitFieldInsert):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitFieldSExtract):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitFieldUExtract):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitReverse):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitCount):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdx):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdy):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFwidth):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdxFine):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdyFine):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFwidthFine):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdxCoarse):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDPdyCoarse):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFwidthCoarse):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpEmitVertex):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpEndPrimitive):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpEmitStreamVertex):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpEndStreamPrimitive):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpControlBarrier):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpMemoryBarrier):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicLoad):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicStore):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicExchange):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicCompareExchange):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicCompareExchangeWeak):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicIIncrement):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicIDecrement):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicIAdd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicISub):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicSMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicUMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicSMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicUMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicAnd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicOr):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicXor):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPhi):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLoopMerge):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSelectionMerge):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpLabel):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpBranch):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpBranchConditional):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSwitch):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpKill):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpReturn):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpReturnValue):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpUnreachable):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpLifetimeStart):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpLifetimeStop):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupAsyncCopy):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupWaitEvents):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupAll):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupAny):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupBroadcast):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupIAdd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupFAdd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupFMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupUMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupSMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupFMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupUMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupSMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReadPipe):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpWritePipe):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReservedReadPipe):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReservedWritePipe):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReserveReadPipePackets):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReserveWritePipePackets):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCommitReadPipe):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCommitWritePipe):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsValidReserveId):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetNumPipePackets):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetMaxPipePackets):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupReserveReadPipePackets):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupReserveWritePipePackets):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupCommitReadPipe):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupCommitWritePipe):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpEnqueueMarker):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpEnqueueKernel):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetKernelNDrangeSubGroupCount):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetKernelNDrangeMaxSubGroupSize):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetKernelWorkGroupSize):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetKernelPreferredWorkGroupSizeMultiple):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRetainEvent):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpReleaseEvent):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCreateUserEvent):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsValidEvent):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSetUserEventStatus):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCaptureEventProfilingInfo):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetDefaultQueue):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBuildNDRange):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleDrefImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleDrefExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefImplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefExplicitLod):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseFetch):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseGather):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseDrefGather):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseTexelsResident):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpNoLine):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicFlagTestAndSet):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicFlagClear):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSparseRead):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSizeOf):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypePipeStorage):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantPipeStorage):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCreatePipeFromPipeStorage):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetKernelLocalSizeForSubgroupCount):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGetKernelMaxNumSubgroups):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeNamedBarrier):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpNamedBarrierInitialize):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMemoryNamedBarrier):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpModuleProcessed):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExecutionModeId):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpDecorateId):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformElect):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAll):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAny):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAllEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBroadcast):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBroadcastFirst):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformInverseBallot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitExtract):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitCount):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindLSB):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindMSB):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffle):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleXor):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleUp):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleDown):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformIAdd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFAdd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformIMul):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMul):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformSMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformUMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMin):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformSMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformUMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMax):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseAnd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseOr):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseXor):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalAnd):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalOr):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalXor):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadBroadcast):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadSwap):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCopyLogical):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPtrEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPtrNotEqual):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPtrDiff):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpColorAttachmentReadEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDepthAttachmentReadEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpStencilAttachmentReadEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeTensorARM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorReadARM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorWriteARM):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorQuerySizeARM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGraphConstantARM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGraphEntryPointARM):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGraphARM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGraphInputARM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGraphSetOutputARM):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGraphEndARM):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeGraphARM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTerminateInvocation):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeUntypedPointerKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedVariableKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedAccessChainKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedInBoundsAccessChainKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupBallotKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupFirstInvocationKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedPtrAccessChainKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedInBoundsPtrAccessChainKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedArrayLengthKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedPrefetchKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpFmaKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAllKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAnyKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAllEqualKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformRotateKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupReadInvocationKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpExtInstWithForwardRefsKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedGroupAsyncCopyKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTraceRayKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExecuteCallableKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertUToAccelerationStructureKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIgnoreIntersectionKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTerminateRayKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSDot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUDot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSUDot):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSDotAccSat):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUDotAccSat):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSUDotAccSat):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeCooperativeMatrixKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixMulAddKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLengthKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantCompositeReplicateEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantCompositeReplicateEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCompositeConstructReplicateEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeRayQueryKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryInitializeKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryTerminateKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGenerateIntersectionKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryConfirmIntersectionKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryProceedKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTypeKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleWeightedQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageBoxFilterQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchSSDQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchSADQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitCastArrayQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchWindowSSDQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchWindowSADQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchGatherSSDQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchGatherSADQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCompositeConstructCoopMatQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCompositeExtractCoopMatQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpExtractSubArrayQCOM):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupIAddNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupFAddNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupFMinNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupUMinNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupSMinNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupFMaxNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupUMaxNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupSMaxNonUniformAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFragmentMaskFetchAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFragmentFetchAMD):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReadClockKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAllocateNodePayloadsAMDX):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpEnqueueNodePayloadsAMDX):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeNodePayloadArrayAMDX):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpFinishWritingNodePayloadAMDX):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpNodePayloadArrayLengthAMDX):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsNodePayloadValidAMDX):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantStringAMDX):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantStringAMDX):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadAllKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadAnyKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeBufferEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpBufferPointerEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAbortKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedImageTexelPointerEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMemberDecorateIdEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantSizeOfEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantDataKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantDataKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPoisonKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFreezeKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitMotionNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitWithIndexMotionNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissMotionNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldToObjectNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectToWorldNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayDirectionNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayOriginNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayMotionNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderRecordBufferHandleNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderBindingTableRecordIndexNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordEmptyNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitWithIndexNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectExecuteShaderNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetCurrentTimeNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetAttributesNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetHitKindNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetPrimitiveIndexNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetGeometryIndexNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceIdNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceCustomIndexNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayDirectionNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayOriginNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMaxNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMinNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsEmptyNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsHitNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsMissNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHitObjectNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHintNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeHitObjectNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpImageSampleFootprintNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeVectorIdEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorMatrixMulNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorOuterProductAccumulateNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorReduceSumAccumulateNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorMatrixMulAddNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixConvertNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpEmitMeshTasksEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSetMeshOutputsEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformPartitionEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpWritePackedPrimitiveIndices4x8NV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpFetchMicroTriangleVertexPositionNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFetchMicroTriangleVertexBarycentricNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorLoadNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorStoreNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordFromQueryEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissMotionEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetIntersectionTriangleVertexPositionsEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayFlagsEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectSetShaderBindingTableRecordIndexEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectReorderExecuteShaderEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceReorderExecuteEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceMotionReorderExecuteEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeHitObjectEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHintEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHitObjectEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayMotionEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordEmptyEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectExecuteShaderEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetCurrentTimeEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetAttributesEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetHitKindEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetPrimitiveIndexEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetGeometryIndexEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceIdEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceCustomIndexEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayOriginEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayDirectionEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayDirectionEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayOriginEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectToWorldEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldToObjectEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMaxEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReportIntersectionKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIgnoreIntersectionNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTerminateRayNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTraceNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTraceMotionNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTraceRayMotionNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTriangleVertexPositionsKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAccelerationStructureKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExecuteCallableNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionClusterIdNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetClusterIdNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMinEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderBindingTableRecordIndexEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderRecordBufferHandleEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsEmptyEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsHitEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsMissEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeCooperativeMatrixNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLoadNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixStoreNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixMulAddNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLengthNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBeginInvocationInterlockEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpEndInvocationInterlockEXT):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixReduceNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLoadTensorNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixStoreTensorNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixPerElementOpNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeTensorLayoutNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeTensorViewNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCreateTensorLayoutNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetDimensionNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetStrideNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSliceNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetClampValueNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCreateTensorViewNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorViewSetDimensionNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorViewSetStrideNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDemoteToHelperInvocation):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpIsHelperInvocationEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorViewSetClipNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetBlockSizeNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixTransposeNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertUToImageNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertUToSamplerNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertImageToUNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertSamplerToUNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertUToSampledImageNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertSampledImageToUNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSamplerImageAddressingModeNV):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpRawAccessChainNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionSpherePositionNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionSphereRadiusNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionLSSPositionsNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionLSSRadiiNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionLSSHitValueNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetSpherePositionNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetSphereRadiusNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetLSSPositionsNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectGetLSSRadiiNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsSphereHitNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpHitObjectIsLSSHitNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryIsSphereHitNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryIsLSSHitNV):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleDownINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleUpINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleXorINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupBlockReadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupBlockWriteINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupImageBlockReadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupImageBlockWriteINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupImageMediaBlockReadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupImageMediaBlockWriteINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpUCountLeadingZerosINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUCountTrailingZerosINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAbsISubINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAbsUSubINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIAddSatINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUAddSatINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIAverageINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUAverageINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIAverageRoundedINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUAverageRoundedINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpISubSatINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUSubSatINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpIMul32x16INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUMul32x16INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantFunctionPointerINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFunctionPointerCallINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAsmTargetINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAsmINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAsmCallINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicFMinEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicFMaxEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAssumeTrueKHR):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpExpectKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpDecorateString):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpMemberDecorateString):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpVmeImageINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeVmeImageINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcImePayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcRefPayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcSicPayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcMcePayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcMceResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeResultSingleReferenceStreamoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeResultDualReferenceStreamoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeSingleReferenceStreaminINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeDualReferenceStreaminINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcRefResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeAvcSicResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetInterShapePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetAcOnlyHaarINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToImePayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToImeResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToRefPayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToRefResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToSicPayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToSicResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetMotionVectorsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterDistortionsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetBestInterDistortionsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterMajorShapeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterMinorShapeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterDirectionsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterMotionVectorCountINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterReferenceIdsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeInitializeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetSingleReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetDualReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeRefWindowSizeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeAdjustRefOffsetINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeConvertToMcePayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetWeightedSadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeConvertToMceResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetDualReferenceStreaminINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetBorderReachedINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcFmeInitializeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcBmeInitializeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefConvertToMcePayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefSetBilinearFilterEnableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefConvertToMceResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicInitializeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConfigureSkcINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConfigureIpeLumaINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetMotionVectorMaskINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConvertToMcePayloadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetBilinearFilterEnableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateIpeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConvertToMceResultINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetIpeLumaShapeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetIpeChromaModeINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetInterRawSadsINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpVariableLengthArrayINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSaveMemoryINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRestoreMemoryINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinCosPiALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCastALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCastFromIntALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCastToIntALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatAddALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSubALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatMulALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatDivALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatGTALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatGEALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLTALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLEALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatEQALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatRecipALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatRSqrtALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCbrtALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatHypotALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSqrtALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLogINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLog2INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLog10INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLog1pINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExpINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExp2INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExp10INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExpm1INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCosINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinCosINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinPiINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCosPiINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatASinINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatASinPiINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatACosINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatACosPiINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatATanINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatATanPiINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatATan2INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatPowINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatPowRINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatPowNINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpLoopControlINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAliasDomainDeclINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAliasScopeDeclINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpAliasScopeListDeclINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedSqrtALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedRecipALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedRsqrtALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedSinALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedCosALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedSinCosALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedSinPiALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedCosPiALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedSinCosPiALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedLogALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFixedExpALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpPtrCastToCrossWorkgroupALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpCrossWorkgroupCastToPtrALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpReadPipeBlockingALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpWritePipeBlockingALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFPGARegALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetRayTMinKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetRayFlagsKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceCustomIndexKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceIdKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionGeometryIndexKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionPrimitiveIndexKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionBarycentricsKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionFrontFaceKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectRayDirectionKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectRayOriginKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetWorldRayDirectionKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetWorldRayOriginKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectToWorldKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionWorldToObjectKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpAtomicFAddEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeBufferSurfaceINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeStructContinuedINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConstantCompositeContinuedINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantCompositeContinuedINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpCompositeConstructContinuedINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertFToBF16INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertBF16ToFINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpControlBarrierArriveINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpControlBarrierWaitINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpArithmeticFenceEXT):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTaskSequenceCreateALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTaskSequenceAsyncALTERA):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTaskSequenceGetALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpTaskSequenceReleaseALTERA):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpTypeTaskSequenceALTERA):
                {
                    hasResult.Value = true;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupBlockPrefetchINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockLoadINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockLoadTransformINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockLoadTransposeINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockPrefetchINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockStoreINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSubgroupMatrixMultiplyAccumulateINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpBitwiseFunctionINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpUntypedVariableLengthArrayINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConditionalExtensionINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConditionalEntryPointINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConditionalCapabilityINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantTargetINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantArchitectureINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpSpecConstantCapabilitiesINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConditionalCopyObjectINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupIMulKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupFMulKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupBitwiseAndKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupBitwiseOrKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupBitwiseXorKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupLogicalAndKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupLogicalOrKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpGroupLogicalXorKHR):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpRoundFToTF32INTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMaskedGatherINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpMaskedScatterINTEL):
                {
                    hasResult.Value = false;
                    hasResultType.Value = false;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertHandleToImageINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertHandleToSamplerINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpConvertHandleToSampledImageINTEL):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFDot2MixAcc32VALVE):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFDot2MixAcc16VALVE):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
                case unchecked((int)Spv.Op.OpFDot4MixAcc32VALVE):
                {
                    hasResult.Value = true;
                    hasResultType.Value = true;
                    break;
                }
            }
        }
    }
    public static string SourceLanguageToString(Spv.SourceLanguage value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.SourceLanguage.SourceLanguageUnknown):
                {
                    return "Unknown";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageESSL):
                {
                    return "ESSL";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageGLSL):
                {
                    return "GLSL";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageOpenCL_C):
                {
                    return "OpenCL_C";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageOpenCL_CPP):
                {
                    return "OpenCL_CPP";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageHLSL):
                {
                    return "HLSL";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageCPP_for_OpenCL):
                {
                    return "CPP_for_OpenCL";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageSYCL):
                {
                    return "SYCL";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageHERO_C):
                {
                    return "HERO_C";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageNZSL):
                {
                    return "NZSL";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageWGSL):
                {
                    return "WGSL";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageSlang):
                {
                    return "Slang";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageZig):
                {
                    return "Zig";
                }
                case unchecked((int)Spv.SourceLanguage.SourceLanguageRust):
                {
                    return "Rust";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string ExecutionModelToString(Spv.ExecutionModel value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.ExecutionModel.ExecutionModelVertex):
                {
                    return "Vertex";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationControl):
                {
                    return "TessellationControl";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTessellationEvaluation):
                {
                    return "TessellationEvaluation";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGeometry):
                {
                    return "Geometry";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelFragment):
                {
                    return "Fragment";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelGLCompute):
                {
                    return "GLCompute";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelKernel):
                {
                    return "Kernel";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTaskNV):
                {
                    return "TaskNV";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMeshNV):
                {
                    return "MeshNV";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelRayGenerationKHR):
                {
                    return "RayGenerationKHR";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelIntersectionKHR):
                {
                    return "IntersectionKHR";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelAnyHitKHR):
                {
                    return "AnyHitKHR";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelClosestHitKHR):
                {
                    return "ClosestHitKHR";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMissKHR):
                {
                    return "MissKHR";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelCallableKHR):
                {
                    return "CallableKHR";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelTaskEXT):
                {
                    return "TaskEXT";
                }
                case unchecked((int)Spv.ExecutionModel.ExecutionModelMeshEXT):
                {
                    return "MeshEXT";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string AddressingModelToString(Spv.AddressingModel value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.AddressingModel.AddressingModelLogical):
                {
                    return "Logical";
                }
                case unchecked((int)Spv.AddressingModel.AddressingModelPhysical32):
                {
                    return "Physical32";
                }
                case unchecked((int)Spv.AddressingModel.AddressingModelPhysical64):
                {
                    return "Physical64";
                }
                case unchecked((int)Spv.AddressingModel.AddressingModelPhysicalStorageBuffer64):
                {
                    return "PhysicalStorageBuffer64";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string MemoryModelToString(Spv.MemoryModel value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.MemoryModel.MemoryModelSimple):
                {
                    return "Simple";
                }
                case unchecked((int)Spv.MemoryModel.MemoryModelGLSL450):
                {
                    return "GLSL450";
                }
                case unchecked((int)Spv.MemoryModel.MemoryModelOpenCL):
                {
                    return "OpenCL";
                }
                case unchecked((int)Spv.MemoryModel.MemoryModelVulkan):
                {
                    return "Vulkan";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string ExecutionModeToString(Spv.ExecutionMode value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInvocations):
                {
                    return "Invocations";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSpacingEqual):
                {
                    return "SpacingEqual";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSpacingFractionalEven):
                {
                    return "SpacingFractionalEven";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSpacingFractionalOdd):
                {
                    return "SpacingFractionalOdd";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeVertexOrderCw):
                {
                    return "VertexOrderCw";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeVertexOrderCcw):
                {
                    return "VertexOrderCcw";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModePixelCenterInteger):
                {
                    return "PixelCenterInteger";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOriginUpperLeft):
                {
                    return "OriginUpperLeft";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOriginLowerLeft):
                {
                    return "OriginLowerLeft";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeEarlyFragmentTests):
                {
                    return "EarlyFragmentTests";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModePointMode):
                {
                    return "PointMode";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeXfb):
                {
                    return "Xfb";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthReplacing):
                {
                    return "DepthReplacing";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthGreater):
                {
                    return "DepthGreater";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthLess):
                {
                    return "DepthLess";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDepthUnchanged):
                {
                    return "DepthUnchanged";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSize):
                {
                    return "LocalSize";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSizeHint):
                {
                    return "LocalSizeHint";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInputPoints):
                {
                    return "InputPoints";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInputLines):
                {
                    return "InputLines";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInputLinesAdjacency):
                {
                    return "InputLinesAdjacency";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeTriangles):
                {
                    return "Triangles";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInputTrianglesAdjacency):
                {
                    return "InputTrianglesAdjacency";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeQuads):
                {
                    return "Quads";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeIsolines):
                {
                    return "Isolines";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputVertices):
                {
                    return "OutputVertices";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputPoints):
                {
                    return "OutputPoints";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputLineStrip):
                {
                    return "OutputLineStrip";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputTriangleStrip):
                {
                    return "OutputTriangleStrip";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeVecTypeHint):
                {
                    return "VecTypeHint";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeContractionOff):
                {
                    return "ContractionOff";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeInitializer):
                {
                    return "Initializer";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeFinalizer):
                {
                    return "Finalizer";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSubgroupSize):
                {
                    return "SubgroupSize";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSubgroupsPerWorkgroup):
                {
                    return "SubgroupsPerWorkgroup";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSubgroupsPerWorkgroupId):
                {
                    return "SubgroupsPerWorkgroupId";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSizeId):
                {
                    return "LocalSizeId";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeLocalSizeHintId):
                {
                    return "LocalSizeHintId";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNonCoherentColorAttachmentReadEXT):
                {
                    return "NonCoherentColorAttachmentReadEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNonCoherentDepthAttachmentReadEXT):
                {
                    return "NonCoherentDepthAttachmentReadEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNonCoherentStencilAttachmentReadEXT):
                {
                    return "NonCoherentStencilAttachmentReadEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSubgroupUniformControlFlowKHR):
                {
                    return "SubgroupUniformControlFlowKHR";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModePostDepthCoverage):
                {
                    return "PostDepthCoverage";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDenormPreserve):
                {
                    return "DenormPreserve";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDenormFlushToZero):
                {
                    return "DenormFlushToZero";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSignedZeroInfNanPreserve):
                {
                    return "SignedZeroInfNanPreserve";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeRoundingModeRTE):
                {
                    return "RoundingModeRTE";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeRoundingModeRTZ):
                {
                    return "RoundingModeRTZ";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNonCoherentTileAttachmentReadQCOM):
                {
                    return "NonCoherentTileAttachmentReadQCOM";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeTileShadingRateQCOM):
                {
                    return "TileShadingRateQCOM";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeEarlyAndLateFragmentTestsAMD):
                {
                    return "EarlyAndLateFragmentTestsAMD";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStencilRefReplacingEXT):
                {
                    return "StencilRefReplacingEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeCoalescingAMDX):
                {
                    return "CoalescingAMDX";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeIsApiEntryAMDX):
                {
                    return "IsApiEntryAMDX";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeMaxNodeRecursionAMDX):
                {
                    return "MaxNodeRecursionAMDX";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStaticNumWorkgroupsAMDX):
                {
                    return "StaticNumWorkgroupsAMDX";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeShaderIndexAMDX):
                {
                    return "ShaderIndexAMDX";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeMaxNumWorkgroupsAMDX):
                {
                    return "MaxNumWorkgroupsAMDX";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStencilRefUnchangedFrontAMD):
                {
                    return "StencilRefUnchangedFrontAMD";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStencilRefGreaterFrontAMD):
                {
                    return "StencilRefGreaterFrontAMD";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStencilRefLessFrontAMD):
                {
                    return "StencilRefLessFrontAMD";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStencilRefUnchangedBackAMD):
                {
                    return "StencilRefUnchangedBackAMD";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStencilRefGreaterBackAMD):
                {
                    return "StencilRefGreaterBackAMD";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStencilRefLessBackAMD):
                {
                    return "StencilRefLessBackAMD";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeQuadDerivativesKHR):
                {
                    return "QuadDerivativesKHR";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeRequireFullQuadsKHR):
                {
                    return "RequireFullQuadsKHR";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSharesInputWithAMDX):
                {
                    return "SharesInputWithAMDX";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeArithmeticPoisonKHR):
                {
                    return "ArithmeticPoisonKHR";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputLinesEXT):
                {
                    return "OutputLinesEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputPrimitivesEXT):
                {
                    return "OutputPrimitivesEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDerivativeGroupQuadsKHR):
                {
                    return "DerivativeGroupQuadsKHR";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeDerivativeGroupLinearKHR):
                {
                    return "DerivativeGroupLinearKHR";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeOutputTrianglesEXT):
                {
                    return "OutputTrianglesEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModePixelInterlockOrderedEXT):
                {
                    return "PixelInterlockOrderedEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModePixelInterlockUnorderedEXT):
                {
                    return "PixelInterlockUnorderedEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSampleInterlockOrderedEXT):
                {
                    return "SampleInterlockOrderedEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSampleInterlockUnorderedEXT):
                {
                    return "SampleInterlockUnorderedEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeShadingRateInterlockOrderedEXT):
                {
                    return "ShadingRateInterlockOrderedEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeShadingRateInterlockUnorderedEXT):
                {
                    return "ShadingRateInterlockUnorderedEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeShader64BitIndexingEXT):
                {
                    return "Shader64BitIndexingEXT";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSharedLocalMemorySizeINTEL):
                {
                    return "SharedLocalMemorySizeINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeRoundingModeRTPINTEL):
                {
                    return "RoundingModeRTPINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeRoundingModeRTNINTEL):
                {
                    return "RoundingModeRTNINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeFloatingPointModeALTINTEL):
                {
                    return "FloatingPointModeALTINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeFloatingPointModeIEEEINTEL):
                {
                    return "FloatingPointModeIEEEINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeMaxWorkgroupSizeINTEL):
                {
                    return "MaxWorkgroupSizeINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeMaxWorkDimINTEL):
                {
                    return "MaxWorkDimINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNoGlobalOffsetINTEL):
                {
                    return "NoGlobalOffsetINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNumSIMDWorkitemsINTEL):
                {
                    return "NumSIMDWorkitemsINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeSchedulerTargetFmaxMhzINTEL):
                {
                    return "SchedulerTargetFmaxMhzINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeMaximallyReconvergesKHR):
                {
                    return "MaximallyReconvergesKHR";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeFPFastMathDefault):
                {
                    return "FPFastMathDefault";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeStreamingInterfaceINTEL):
                {
                    return "StreamingInterfaceINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeRegisterMapInterfaceINTEL):
                {
                    return "RegisterMapInterfaceINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNamedBarrierCountINTEL):
                {
                    return "NamedBarrierCountINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeMaximumRegistersINTEL):
                {
                    return "MaximumRegistersINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeMaximumRegistersIdINTEL):
                {
                    return "MaximumRegistersIdINTEL";
                }
                case unchecked((int)Spv.ExecutionMode.ExecutionModeNamedMaximumRegistersINTEL):
                {
                    return "NamedMaximumRegistersINTEL";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string StorageClassToString(Spv.StorageClass value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.StorageClass.StorageClassUniformConstant):
                {
                    return "UniformConstant";
                }
                case unchecked((int)Spv.StorageClass.StorageClassInput):
                {
                    return "Input";
                }
                case unchecked((int)Spv.StorageClass.StorageClassUniform):
                {
                    return "Uniform";
                }
                case unchecked((int)Spv.StorageClass.StorageClassOutput):
                {
                    return "Output";
                }
                case unchecked((int)Spv.StorageClass.StorageClassWorkgroup):
                {
                    return "Workgroup";
                }
                case unchecked((int)Spv.StorageClass.StorageClassCrossWorkgroup):
                {
                    return "CrossWorkgroup";
                }
                case unchecked((int)Spv.StorageClass.StorageClassPrivate):
                {
                    return "Private";
                }
                case unchecked((int)Spv.StorageClass.StorageClassFunction):
                {
                    return "Function";
                }
                case unchecked((int)Spv.StorageClass.StorageClassGeneric):
                {
                    return "Generic";
                }
                case unchecked((int)Spv.StorageClass.StorageClassPushConstant):
                {
                    return "PushConstant";
                }
                case unchecked((int)Spv.StorageClass.StorageClassAtomicCounter):
                {
                    return "AtomicCounter";
                }
                case unchecked((int)Spv.StorageClass.StorageClassImage):
                {
                    return "Image";
                }
                case unchecked((int)Spv.StorageClass.StorageClassStorageBuffer):
                {
                    return "StorageBuffer";
                }
                case unchecked((int)Spv.StorageClass.StorageClassTileImageEXT):
                {
                    return "TileImageEXT";
                }
                case unchecked((int)Spv.StorageClass.StorageClassTileAttachmentQCOM):
                {
                    return "TileAttachmentQCOM";
                }
                case unchecked((int)Spv.StorageClass.StorageClassNodePayloadAMDX):
                {
                    return "NodePayloadAMDX";
                }
                case unchecked((int)Spv.StorageClass.StorageClassCallableDataKHR):
                {
                    return "CallableDataKHR";
                }
                case unchecked((int)Spv.StorageClass.StorageClassIncomingCallableDataKHR):
                {
                    return "IncomingCallableDataKHR";
                }
                case unchecked((int)Spv.StorageClass.StorageClassRayPayloadKHR):
                {
                    return "RayPayloadKHR";
                }
                case unchecked((int)Spv.StorageClass.StorageClassHitAttributeKHR):
                {
                    return "HitAttributeKHR";
                }
                case unchecked((int)Spv.StorageClass.StorageClassIncomingRayPayloadKHR):
                {
                    return "IncomingRayPayloadKHR";
                }
                case unchecked((int)Spv.StorageClass.StorageClassShaderRecordBufferKHR):
                {
                    return "ShaderRecordBufferKHR";
                }
                case unchecked((int)Spv.StorageClass.StorageClassPhysicalStorageBuffer):
                {
                    return "PhysicalStorageBuffer";
                }
                case unchecked((int)Spv.StorageClass.StorageClassHitObjectAttributeNV):
                {
                    return "HitObjectAttributeNV";
                }
                case unchecked((int)Spv.StorageClass.StorageClassTaskPayloadWorkgroupEXT):
                {
                    return "TaskPayloadWorkgroupEXT";
                }
                case unchecked((int)Spv.StorageClass.StorageClassHitObjectAttributeEXT):
                {
                    return "HitObjectAttributeEXT";
                }
                case unchecked((int)Spv.StorageClass.StorageClassCodeSectionINTEL):
                {
                    return "CodeSectionINTEL";
                }
                case unchecked((int)Spv.StorageClass.StorageClassDeviceOnlyALTERA):
                {
                    return "DeviceOnlyALTERA";
                }
                case unchecked((int)Spv.StorageClass.StorageClassHostOnlyALTERA):
                {
                    return "HostOnlyALTERA";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string DimToString(Spv.Dim value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.Dim.Dim1D):
                {
                    return "1D";
                }
                case unchecked((int)Spv.Dim.Dim2D):
                {
                    return "2D";
                }
                case unchecked((int)Spv.Dim.Dim3D):
                {
                    return "3D";
                }
                case unchecked((int)Spv.Dim.DimCube):
                {
                    return "Cube";
                }
                case unchecked((int)Spv.Dim.DimRect):
                {
                    return "Rect";
                }
                case unchecked((int)Spv.Dim.DimBuffer):
                {
                    return "Buffer";
                }
                case unchecked((int)Spv.Dim.DimSubpassData):
                {
                    return "SubpassData";
                }
                case unchecked((int)Spv.Dim.DimTileImageDataEXT):
                {
                    return "TileImageDataEXT";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string SamplerAddressingModeToString(Spv.SamplerAddressingMode value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.SamplerAddressingMode.SamplerAddressingModeNone):
                {
                    return "None";
                }
                case unchecked((int)Spv.SamplerAddressingMode.SamplerAddressingModeClampToEdge):
                {
                    return "ClampToEdge";
                }
                case unchecked((int)Spv.SamplerAddressingMode.SamplerAddressingModeClamp):
                {
                    return "Clamp";
                }
                case unchecked((int)Spv.SamplerAddressingMode.SamplerAddressingModeRepeat):
                {
                    return "Repeat";
                }
                case unchecked((int)Spv.SamplerAddressingMode.SamplerAddressingModeRepeatMirrored):
                {
                    return "RepeatMirrored";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string SamplerFilterModeToString(Spv.SamplerFilterMode value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.SamplerFilterMode.SamplerFilterModeNearest):
                {
                    return "Nearest";
                }
                case unchecked((int)Spv.SamplerFilterMode.SamplerFilterModeLinear):
                {
                    return "Linear";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string ImageFormatToString(Spv.ImageFormat value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.ImageFormat.ImageFormatUnknown):
                {
                    return "Unknown";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32f):
                {
                    return "Rgba32f";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16f):
                {
                    return "Rgba16f";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR32f):
                {
                    return "R32f";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8):
                {
                    return "Rgba8";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8Snorm):
                {
                    return "Rgba8Snorm";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32f):
                {
                    return "Rg32f";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16f):
                {
                    return "Rg16f";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR11fG11fB10f):
                {
                    return "R11fG11fB10f";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR16f):
                {
                    return "R16f";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16):
                {
                    return "Rgba16";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10A2):
                {
                    return "Rgb10A2";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16):
                {
                    return "Rg16";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8):
                {
                    return "Rg8";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR16):
                {
                    return "R16";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8):
                {
                    return "R8";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16Snorm):
                {
                    return "Rgba16Snorm";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16Snorm):
                {
                    return "Rg16Snorm";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8Snorm):
                {
                    return "Rg8Snorm";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR16Snorm):
                {
                    return "R16Snorm";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8Snorm):
                {
                    return "R8Snorm";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32i):
                {
                    return "Rgba32i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16i):
                {
                    return "Rgba16i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8i):
                {
                    return "Rgba8i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR32i):
                {
                    return "R32i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32i):
                {
                    return "Rg32i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16i):
                {
                    return "Rg16i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8i):
                {
                    return "Rg8i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR16i):
                {
                    return "R16i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8i):
                {
                    return "R8i";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba32ui):
                {
                    return "Rgba32ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba16ui):
                {
                    return "Rgba16ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgba8ui):
                {
                    return "Rgba8ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR32ui):
                {
                    return "R32ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRgb10a2ui):
                {
                    return "Rgb10a2ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg32ui):
                {
                    return "Rg32ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg16ui):
                {
                    return "Rg16ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatRg8ui):
                {
                    return "Rg8ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR16ui):
                {
                    return "R16ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR8ui):
                {
                    return "R8ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR64ui):
                {
                    return "R64ui";
                }
                case unchecked((int)Spv.ImageFormat.ImageFormatR64i):
                {
                    return "R64i";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string ImageChannelOrderToString(Spv.ImageChannelOrder value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderR):
                {
                    return "R";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderA):
                {
                    return "A";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderRG):
                {
                    return "RG";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderRA):
                {
                    return "RA";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderRGB):
                {
                    return "RGB";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderRGBA):
                {
                    return "RGBA";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderBGRA):
                {
                    return "BGRA";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderARGB):
                {
                    return "ARGB";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderIntensity):
                {
                    return "Intensity";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderLuminance):
                {
                    return "Luminance";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderRx):
                {
                    return "Rx";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderRGx):
                {
                    return "RGx";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderRGBx):
                {
                    return "RGBx";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderDepth):
                {
                    return "Depth";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderDepthStencil):
                {
                    return "DepthStencil";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrdersRGB):
                {
                    return "sRGB";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrdersRGBx):
                {
                    return "sRGBx";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrdersRGBA):
                {
                    return "sRGBA";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrdersBGRA):
                {
                    return "sBGRA";
                }
                case unchecked((int)Spv.ImageChannelOrder.ImageChannelOrderABGR):
                {
                    return "ABGR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string ImageChannelDataTypeToString(Spv.ImageChannelDataType value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeSnormInt8):
                {
                    return "SnormInt8";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeSnormInt16):
                {
                    return "SnormInt16";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt8):
                {
                    return "UnormInt8";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt16):
                {
                    return "UnormInt16";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormShort565):
                {
                    return "UnormShort565";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormShort555):
                {
                    return "UnormShort555";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt101010):
                {
                    return "UnormInt101010";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeSignedInt8):
                {
                    return "SignedInt8";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeSignedInt16):
                {
                    return "SignedInt16";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeSignedInt32):
                {
                    return "SignedInt32";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedInt8):
                {
                    return "UnsignedInt8";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedInt16):
                {
                    return "UnsignedInt16";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedInt32):
                {
                    return "UnsignedInt32";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeHalfFloat):
                {
                    return "HalfFloat";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeFloat):
                {
                    return "Float";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt24):
                {
                    return "UnormInt24";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt101010_2):
                {
                    return "UnormInt101010_2";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt10X6EXT):
                {
                    return "UnormInt10X6EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedIntRaw10EXT):
                {
                    return "UnsignedIntRaw10EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedIntRaw12EXT):
                {
                    return "UnsignedIntRaw12EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt2_101010EXT):
                {
                    return "UnormInt2_101010EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedInt10X6EXT):
                {
                    return "UnsignedInt10X6EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedInt12X4EXT):
                {
                    return "UnsignedInt12X4EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnsignedInt14X2EXT):
                {
                    return "UnsignedInt14X2EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt12X4EXT):
                {
                    return "UnormInt12X4EXT";
                }
                case unchecked((int)Spv.ImageChannelDataType.ImageChannelDataTypeUnormInt14X2EXT):
                {
                    return "UnormInt14X2EXT";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string FPRoundingModeToString(Spv.FPRoundingMode value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.FPRoundingMode.FPRoundingModeRTE):
                {
                    return "RTE";
                }
                case unchecked((int)Spv.FPRoundingMode.FPRoundingModeRTZ):
                {
                    return "RTZ";
                }
                case unchecked((int)Spv.FPRoundingMode.FPRoundingModeRTP):
                {
                    return "RTP";
                }
                case unchecked((int)Spv.FPRoundingMode.FPRoundingModeRTN):
                {
                    return "RTN";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string LinkageTypeToString(Spv.LinkageType value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.LinkageType.LinkageTypeExport):
                {
                    return "Export";
                }
                case unchecked((int)Spv.LinkageType.LinkageTypeImport):
                {
                    return "Import";
                }
                case unchecked((int)Spv.LinkageType.LinkageTypeLinkOnceODR):
                {
                    return "LinkOnceODR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string AccessQualifierToString(Spv.AccessQualifier value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.AccessQualifier.AccessQualifierReadOnly):
                {
                    return "ReadOnly";
                }
                case unchecked((int)Spv.AccessQualifier.AccessQualifierWriteOnly):
                {
                    return "WriteOnly";
                }
                case unchecked((int)Spv.AccessQualifier.AccessQualifierReadWrite):
                {
                    return "ReadWrite";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string FunctionParameterAttributeToString(Spv.FunctionParameterAttribute value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeZext):
                {
                    return "Zext";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeSext):
                {
                    return "Sext";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeByVal):
                {
                    return "ByVal";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeSret):
                {
                    return "Sret";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeNoAlias):
                {
                    return "NoAlias";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeNoCapture):
                {
                    return "NoCapture";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeNoWrite):
                {
                    return "NoWrite";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeNoReadWrite):
                {
                    return "NoReadWrite";
                }
                case unchecked((int)Spv.FunctionParameterAttribute.FunctionParameterAttributeRuntimeAlignedALTERA):
                {
                    return "RuntimeAlignedALTERA";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string DecorationToString(Spv.Decoration value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.Decoration.DecorationRelaxedPrecision):
                {
                    return "RelaxedPrecision";
                }
                case unchecked((int)Spv.Decoration.DecorationSpecId):
                {
                    return "SpecId";
                }
                case unchecked((int)Spv.Decoration.DecorationBlock):
                {
                    return "Block";
                }
                case unchecked((int)Spv.Decoration.DecorationBufferBlock):
                {
                    return "BufferBlock";
                }
                case unchecked((int)Spv.Decoration.DecorationRowMajor):
                {
                    return "RowMajor";
                }
                case unchecked((int)Spv.Decoration.DecorationColMajor):
                {
                    return "ColMajor";
                }
                case unchecked((int)Spv.Decoration.DecorationArrayStride):
                {
                    return "ArrayStride";
                }
                case unchecked((int)Spv.Decoration.DecorationMatrixStride):
                {
                    return "MatrixStride";
                }
                case unchecked((int)Spv.Decoration.DecorationGLSLShared):
                {
                    return "GLSLShared";
                }
                case unchecked((int)Spv.Decoration.DecorationGLSLPacked):
                {
                    return "GLSLPacked";
                }
                case unchecked((int)Spv.Decoration.DecorationCPacked):
                {
                    return "CPacked";
                }
                case unchecked((int)Spv.Decoration.DecorationBuiltIn):
                {
                    return "BuiltIn";
                }
                case unchecked((int)Spv.Decoration.DecorationNoPerspective):
                {
                    return "NoPerspective";
                }
                case unchecked((int)Spv.Decoration.DecorationFlat):
                {
                    return "Flat";
                }
                case unchecked((int)Spv.Decoration.DecorationPatch):
                {
                    return "Patch";
                }
                case unchecked((int)Spv.Decoration.DecorationCentroid):
                {
                    return "Centroid";
                }
                case unchecked((int)Spv.Decoration.DecorationSample):
                {
                    return "Sample";
                }
                case unchecked((int)Spv.Decoration.DecorationInvariant):
                {
                    return "Invariant";
                }
                case unchecked((int)Spv.Decoration.DecorationRestrict):
                {
                    return "Restrict";
                }
                case unchecked((int)Spv.Decoration.DecorationAliased):
                {
                    return "Aliased";
                }
                case unchecked((int)Spv.Decoration.DecorationVolatile):
                {
                    return "Volatile";
                }
                case unchecked((int)Spv.Decoration.DecorationConstant):
                {
                    return "Constant";
                }
                case unchecked((int)Spv.Decoration.DecorationCoherent):
                {
                    return "Coherent";
                }
                case unchecked((int)Spv.Decoration.DecorationNonWritable):
                {
                    return "NonWritable";
                }
                case unchecked((int)Spv.Decoration.DecorationNonReadable):
                {
                    return "NonReadable";
                }
                case unchecked((int)Spv.Decoration.DecorationUniform):
                {
                    return "Uniform";
                }
                case unchecked((int)Spv.Decoration.DecorationUniformId):
                {
                    return "UniformId";
                }
                case unchecked((int)Spv.Decoration.DecorationSaturatedConversion):
                {
                    return "SaturatedConversion";
                }
                case unchecked((int)Spv.Decoration.DecorationStream):
                {
                    return "Stream";
                }
                case unchecked((int)Spv.Decoration.DecorationLocation):
                {
                    return "Location";
                }
                case unchecked((int)Spv.Decoration.DecorationComponent):
                {
                    return "Component";
                }
                case unchecked((int)Spv.Decoration.DecorationIndex):
                {
                    return "Index";
                }
                case unchecked((int)Spv.Decoration.DecorationBinding):
                {
                    return "Binding";
                }
                case unchecked((int)Spv.Decoration.DecorationDescriptorSet):
                {
                    return "DescriptorSet";
                }
                case unchecked((int)Spv.Decoration.DecorationOffset):
                {
                    return "Offset";
                }
                case unchecked((int)Spv.Decoration.DecorationXfbBuffer):
                {
                    return "XfbBuffer";
                }
                case unchecked((int)Spv.Decoration.DecorationXfbStride):
                {
                    return "XfbStride";
                }
                case unchecked((int)Spv.Decoration.DecorationFuncParamAttr):
                {
                    return "FuncParamAttr";
                }
                case unchecked((int)Spv.Decoration.DecorationFPRoundingMode):
                {
                    return "FPRoundingMode";
                }
                case unchecked((int)Spv.Decoration.DecorationFPFastMathMode):
                {
                    return "FPFastMathMode";
                }
                case unchecked((int)Spv.Decoration.DecorationLinkageAttributes):
                {
                    return "LinkageAttributes";
                }
                case unchecked((int)Spv.Decoration.DecorationNoContraction):
                {
                    return "NoContraction";
                }
                case unchecked((int)Spv.Decoration.DecorationInputAttachmentIndex):
                {
                    return "InputAttachmentIndex";
                }
                case unchecked((int)Spv.Decoration.DecorationAlignment):
                {
                    return "Alignment";
                }
                case unchecked((int)Spv.Decoration.DecorationMaxByteOffset):
                {
                    return "MaxByteOffset";
                }
                case unchecked((int)Spv.Decoration.DecorationAlignmentId):
                {
                    return "AlignmentId";
                }
                case unchecked((int)Spv.Decoration.DecorationMaxByteOffsetId):
                {
                    return "MaxByteOffsetId";
                }
                case unchecked((int)Spv.Decoration.DecorationSaturatedToLargestFloat8NormalConversionEXT):
                {
                    return "SaturatedToLargestFloat8NormalConversionEXT";
                }
                case unchecked((int)Spv.Decoration.DecorationNoSignedWrap):
                {
                    return "NoSignedWrap";
                }
                case unchecked((int)Spv.Decoration.DecorationNoUnsignedWrap):
                {
                    return "NoUnsignedWrap";
                }
                case unchecked((int)Spv.Decoration.DecorationWeightTextureQCOM):
                {
                    return "WeightTextureQCOM";
                }
                case unchecked((int)Spv.Decoration.DecorationBlockMatchTextureQCOM):
                {
                    return "BlockMatchTextureQCOM";
                }
                case unchecked((int)Spv.Decoration.DecorationBlockMatchSamplerQCOM):
                {
                    return "BlockMatchSamplerQCOM";
                }
                case unchecked((int)Spv.Decoration.DecorationExplicitInterpAMD):
                {
                    return "ExplicitInterpAMD";
                }
                case unchecked((int)Spv.Decoration.DecorationNodeSharesPayloadLimitsWithAMDX):
                {
                    return "NodeSharesPayloadLimitsWithAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationNodeMaxPayloadsAMDX):
                {
                    return "NodeMaxPayloadsAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationTrackFinishWritingAMDX):
                {
                    return "TrackFinishWritingAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationPayloadNodeNameAMDX):
                {
                    return "PayloadNodeNameAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationPayloadNodeBaseIndexAMDX):
                {
                    return "PayloadNodeBaseIndexAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationPayloadNodeSparseArrayAMDX):
                {
                    return "PayloadNodeSparseArrayAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationPayloadNodeArraySizeAMDX):
                {
                    return "PayloadNodeArraySizeAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationPayloadDispatchIndirectAMDX):
                {
                    return "PayloadDispatchIndirectAMDX";
                }
                case unchecked((int)Spv.Decoration.DecorationArrayStrideIdEXT):
                {
                    return "ArrayStrideIdEXT";
                }
                case unchecked((int)Spv.Decoration.DecorationOffsetIdEXT):
                {
                    return "OffsetIdEXT";
                }
                case unchecked((int)Spv.Decoration.DecorationUTFEncodedKHR):
                {
                    return "UTFEncodedKHR";
                }
                case unchecked((int)Spv.Decoration.DecorationOverrideCoverageNV):
                {
                    return "OverrideCoverageNV";
                }
                case unchecked((int)Spv.Decoration.DecorationPassthroughNV):
                {
                    return "PassthroughNV";
                }
                case unchecked((int)Spv.Decoration.DecorationViewportRelativeNV):
                {
                    return "ViewportRelativeNV";
                }
                case unchecked((int)Spv.Decoration.DecorationSecondaryViewportRelativeNV):
                {
                    return "SecondaryViewportRelativeNV";
                }
                case unchecked((int)Spv.Decoration.DecorationPerPrimitiveEXT):
                {
                    return "PerPrimitiveEXT";
                }
                case unchecked((int)Spv.Decoration.DecorationPerViewNV):
                {
                    return "PerViewNV";
                }
                case unchecked((int)Spv.Decoration.DecorationPerTaskNV):
                {
                    return "PerTaskNV";
                }
                case unchecked((int)Spv.Decoration.DecorationPerVertexKHR):
                {
                    return "PerVertexKHR";
                }
                case unchecked((int)Spv.Decoration.DecorationNonUniform):
                {
                    return "NonUniform";
                }
                case unchecked((int)Spv.Decoration.DecorationRestrictPointer):
                {
                    return "RestrictPointer";
                }
                case unchecked((int)Spv.Decoration.DecorationAliasedPointer):
                {
                    return "AliasedPointer";
                }
                case unchecked((int)Spv.Decoration.DecorationMemberOffsetNV):
                {
                    return "MemberOffsetNV";
                }
                case unchecked((int)Spv.Decoration.DecorationHitObjectShaderRecordBufferNV):
                {
                    return "HitObjectShaderRecordBufferNV";
                }
                case unchecked((int)Spv.Decoration.DecorationHitObjectShaderRecordBufferEXT):
                {
                    return "HitObjectShaderRecordBufferEXT";
                }
                case unchecked((int)Spv.Decoration.DecorationBankNV):
                {
                    return "BankNV";
                }
                case unchecked((int)Spv.Decoration.DecorationBindlessSamplerNV):
                {
                    return "BindlessSamplerNV";
                }
                case unchecked((int)Spv.Decoration.DecorationBindlessImageNV):
                {
                    return "BindlessImageNV";
                }
                case unchecked((int)Spv.Decoration.DecorationBoundSamplerNV):
                {
                    return "BoundSamplerNV";
                }
                case unchecked((int)Spv.Decoration.DecorationBoundImageNV):
                {
                    return "BoundImageNV";
                }
                case unchecked((int)Spv.Decoration.DecorationSIMTCallINTEL):
                {
                    return "SIMTCallINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationReferencedIndirectlyINTEL):
                {
                    return "ReferencedIndirectlyINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationClobberINTEL):
                {
                    return "ClobberINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationSideEffectsINTEL):
                {
                    return "SideEffectsINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationVectorComputeVariableINTEL):
                {
                    return "VectorComputeVariableINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationFuncParamIOKindINTEL):
                {
                    return "FuncParamIOKindINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationVectorComputeFunctionINTEL):
                {
                    return "VectorComputeFunctionINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationStackCallINTEL):
                {
                    return "StackCallINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationGlobalVariableOffsetINTEL):
                {
                    return "GlobalVariableOffsetINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationCounterBuffer):
                {
                    return "CounterBuffer";
                }
                case unchecked((int)Spv.Decoration.DecorationHlslSemanticGOOGLE):
                {
                    return "HlslSemanticGOOGLE";
                }
                case unchecked((int)Spv.Decoration.DecorationUserTypeGOOGLE):
                {
                    return "UserTypeGOOGLE";
                }
                case unchecked((int)Spv.Decoration.DecorationFunctionRoundingModeINTEL):
                {
                    return "FunctionRoundingModeINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationFunctionDenormModeINTEL):
                {
                    return "FunctionDenormModeINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationRegisterALTERA):
                {
                    return "RegisterALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMemoryALTERA):
                {
                    return "MemoryALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationNumbanksALTERA):
                {
                    return "NumbanksALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationBankwidthALTERA):
                {
                    return "BankwidthALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMaxPrivateCopiesALTERA):
                {
                    return "MaxPrivateCopiesALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationSinglepumpALTERA):
                {
                    return "SinglepumpALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationDoublepumpALTERA):
                {
                    return "DoublepumpALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMaxReplicatesALTERA):
                {
                    return "MaxReplicatesALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationSimpleDualPortALTERA):
                {
                    return "SimpleDualPortALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMergeALTERA):
                {
                    return "MergeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationBankBitsALTERA):
                {
                    return "BankBitsALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationForcePow2DepthALTERA):
                {
                    return "ForcePow2DepthALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationStridesizeALTERA):
                {
                    return "StridesizeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationWordsizeALTERA):
                {
                    return "WordsizeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationTrueDualPortALTERA):
                {
                    return "TrueDualPortALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationBurstCoalesceALTERA):
                {
                    return "BurstCoalesceALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationCacheSizeALTERA):
                {
                    return "CacheSizeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationDontStaticallyCoalesceALTERA):
                {
                    return "DontStaticallyCoalesceALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationPrefetchALTERA):
                {
                    return "PrefetchALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationStallEnableALTERA):
                {
                    return "StallEnableALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationFuseLoopsInFunctionALTERA):
                {
                    return "FuseLoopsInFunctionALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMathOpDSPModeALTERA):
                {
                    return "MathOpDSPModeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationAliasScopeINTEL):
                {
                    return "AliasScopeINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationNoAliasINTEL):
                {
                    return "NoAliasINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationInitiationIntervalALTERA):
                {
                    return "InitiationIntervalALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMaxConcurrencyALTERA):
                {
                    return "MaxConcurrencyALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationPipelineEnableALTERA):
                {
                    return "PipelineEnableALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationBufferLocationALTERA):
                {
                    return "BufferLocationALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationIOPipeStorageALTERA):
                {
                    return "IOPipeStorageALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationFunctionFloatingPointModeINTEL):
                {
                    return "FunctionFloatingPointModeINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationSingleElementVectorINTEL):
                {
                    return "SingleElementVectorINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationVectorComputeCallableFunctionINTEL):
                {
                    return "VectorComputeCallableFunctionINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationMediaBlockIOINTEL):
                {
                    return "MediaBlockIOINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationStallFreeALTERA):
                {
                    return "StallFreeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationFPMaxErrorDecorationINTEL):
                {
                    return "FPMaxErrorDecorationINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationLatencyControlLabelALTERA):
                {
                    return "LatencyControlLabelALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationLatencyControlConstraintALTERA):
                {
                    return "LatencyControlConstraintALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationConduitKernelArgumentALTERA):
                {
                    return "ConduitKernelArgumentALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationRegisterMapKernelArgumentALTERA):
                {
                    return "RegisterMapKernelArgumentALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMMHostInterfaceAddressWidthALTERA):
                {
                    return "MMHostInterfaceAddressWidthALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMMHostInterfaceDataWidthALTERA):
                {
                    return "MMHostInterfaceDataWidthALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMMHostInterfaceLatencyALTERA):
                {
                    return "MMHostInterfaceLatencyALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMMHostInterfaceReadWriteModeALTERA):
                {
                    return "MMHostInterfaceReadWriteModeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMMHostInterfaceMaxBurstALTERA):
                {
                    return "MMHostInterfaceMaxBurstALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationMMHostInterfaceWaitRequestALTERA):
                {
                    return "MMHostInterfaceWaitRequestALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationStableKernelArgumentALTERA):
                {
                    return "StableKernelArgumentALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationHostAccessINTEL):
                {
                    return "HostAccessINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationInitModeALTERA):
                {
                    return "InitModeALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationImplementInRegisterMapALTERA):
                {
                    return "ImplementInRegisterMapALTERA";
                }
                case unchecked((int)Spv.Decoration.DecorationConditionalINTEL):
                {
                    return "ConditionalINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationCacheControlLoadINTEL):
                {
                    return "CacheControlLoadINTEL";
                }
                case unchecked((int)Spv.Decoration.DecorationCacheControlStoreINTEL):
                {
                    return "CacheControlStoreINTEL";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string BuiltInToString(Spv.BuiltIn value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.BuiltIn.BuiltInPosition):
                {
                    return "Position";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPointSize):
                {
                    return "PointSize";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInClipDistance):
                {
                    return "ClipDistance";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCullDistance):
                {
                    return "CullDistance";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInVertexId):
                {
                    return "VertexId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInInstanceId):
                {
                    return "InstanceId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveId):
                {
                    return "PrimitiveId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInInvocationId):
                {
                    return "InvocationId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInLayer):
                {
                    return "Layer";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInViewportIndex):
                {
                    return "ViewportIndex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInTessLevelOuter):
                {
                    return "TessLevelOuter";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInTessLevelInner):
                {
                    return "TessLevelInner";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInTessCoord):
                {
                    return "TessCoord";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPatchVertices):
                {
                    return "PatchVertices";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInFragCoord):
                {
                    return "FragCoord";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPointCoord):
                {
                    return "PointCoord";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInFrontFacing):
                {
                    return "FrontFacing";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSampleId):
                {
                    return "SampleId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSamplePosition):
                {
                    return "SamplePosition";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSampleMask):
                {
                    return "SampleMask";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInFragDepth):
                {
                    return "FragDepth";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHelperInvocation):
                {
                    return "HelperInvocation";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInNumWorkgroups):
                {
                    return "NumWorkgroups";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWorkgroupSize):
                {
                    return "WorkgroupSize";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWorkgroupId):
                {
                    return "WorkgroupId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInLocalInvocationId):
                {
                    return "LocalInvocationId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInGlobalInvocationId):
                {
                    return "GlobalInvocationId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInLocalInvocationIndex):
                {
                    return "LocalInvocationIndex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWorkDim):
                {
                    return "WorkDim";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInGlobalSize):
                {
                    return "GlobalSize";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInEnqueuedWorkgroupSize):
                {
                    return "EnqueuedWorkgroupSize";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInGlobalOffset):
                {
                    return "GlobalOffset";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInGlobalLinearId):
                {
                    return "GlobalLinearId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupSize):
                {
                    return "SubgroupSize";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupMaxSize):
                {
                    return "SubgroupMaxSize";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInNumSubgroups):
                {
                    return "NumSubgroups";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInNumEnqueuedSubgroups):
                {
                    return "NumEnqueuedSubgroups";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupId):
                {
                    return "SubgroupId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLocalInvocationId):
                {
                    return "SubgroupLocalInvocationId";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInVertexIndex):
                {
                    return "VertexIndex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInInstanceIndex):
                {
                    return "InstanceIndex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCoreIDARM):
                {
                    return "CoreIDARM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCoreCountARM):
                {
                    return "CoreCountARM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCoreMaxIDARM):
                {
                    return "CoreMaxIDARM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWarpIDARM):
                {
                    return "WarpIDARM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWarpMaxIDARM):
                {
                    return "WarpMaxIDARM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupEqMask):
                {
                    return "SubgroupEqMask";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGeMask):
                {
                    return "SubgroupGeMask";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupGtMask):
                {
                    return "SubgroupGtMask";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLeMask):
                {
                    return "SubgroupLeMask";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSubgroupLtMask):
                {
                    return "SubgroupLtMask";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaseVertex):
                {
                    return "BaseVertex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaseInstance):
                {
                    return "BaseInstance";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInDrawIndex):
                {
                    return "DrawIndex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveShadingRateKHR):
                {
                    return "PrimitiveShadingRateKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInDeviceIndex):
                {
                    return "DeviceIndex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInViewIndex):
                {
                    return "ViewIndex";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInShadingRateKHR):
                {
                    return "ShadingRateKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInTileOffsetQCOM):
                {
                    return "TileOffsetQCOM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInTileDimensionQCOM):
                {
                    return "TileDimensionQCOM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInTileApronSizeQCOM):
                {
                    return "TileApronSizeQCOM";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordNoPerspAMD):
                {
                    return "BaryCoordNoPerspAMD";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordNoPerspCentroidAMD):
                {
                    return "BaryCoordNoPerspCentroidAMD";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordNoPerspSampleAMD):
                {
                    return "BaryCoordNoPerspSampleAMD";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordSmoothAMD):
                {
                    return "BaryCoordSmoothAMD";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordSmoothCentroidAMD):
                {
                    return "BaryCoordSmoothCentroidAMD";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordSmoothSampleAMD):
                {
                    return "BaryCoordSmoothSampleAMD";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordPullModelAMD):
                {
                    return "BaryCoordPullModelAMD";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInFragStencilRefEXT):
                {
                    return "FragStencilRefEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInRemainingRecursionLevelsAMDX):
                {
                    return "RemainingRecursionLevelsAMDX";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInShaderIndexAMDX):
                {
                    return "ShaderIndexAMDX";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSamplerHeapEXT):
                {
                    return "SamplerHeapEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInResourceHeapEXT):
                {
                    return "ResourceHeapEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInViewportMaskNV):
                {
                    return "ViewportMaskNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSecondaryPositionNV):
                {
                    return "SecondaryPositionNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSecondaryViewportMaskNV):
                {
                    return "SecondaryViewportMaskNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPositionPerViewNV):
                {
                    return "PositionPerViewNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInViewportMaskPerViewNV):
                {
                    return "ViewportMaskPerViewNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInFullyCoveredEXT):
                {
                    return "FullyCoveredEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInTaskCountNV):
                {
                    return "TaskCountNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveCountNV):
                {
                    return "PrimitiveCountNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveIndicesNV):
                {
                    return "PrimitiveIndicesNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInClipDistancePerViewNV):
                {
                    return "ClipDistancePerViewNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCullDistancePerViewNV):
                {
                    return "CullDistancePerViewNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInLayerPerViewNV):
                {
                    return "LayerPerViewNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInMeshViewCountNV):
                {
                    return "MeshViewCountNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInMeshViewIndicesNV):
                {
                    return "MeshViewIndicesNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordKHR):
                {
                    return "BaryCoordKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInBaryCoordNoPerspKHR):
                {
                    return "BaryCoordNoPerspKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInFragSizeEXT):
                {
                    return "FragSizeEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInFragInvocationCountEXT):
                {
                    return "FragInvocationCountEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPrimitivePointIndicesEXT):
                {
                    return "PrimitivePointIndicesEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveLineIndicesEXT):
                {
                    return "PrimitiveLineIndicesEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInPrimitiveTriangleIndicesEXT):
                {
                    return "PrimitiveTriangleIndicesEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCullPrimitiveEXT):
                {
                    return "CullPrimitiveEXT";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInLaunchIdKHR):
                {
                    return "LaunchIdKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInLaunchSizeKHR):
                {
                    return "LaunchSizeKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWorldRayOriginKHR):
                {
                    return "WorldRayOriginKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWorldRayDirectionKHR):
                {
                    return "WorldRayDirectionKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInObjectRayOriginKHR):
                {
                    return "ObjectRayOriginKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInObjectRayDirectionKHR):
                {
                    return "ObjectRayDirectionKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInRayTminKHR):
                {
                    return "RayTminKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInRayTmaxKHR):
                {
                    return "RayTmaxKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInInstanceCustomIndexKHR):
                {
                    return "InstanceCustomIndexKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInObjectToWorldKHR):
                {
                    return "ObjectToWorldKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWorldToObjectKHR):
                {
                    return "WorldToObjectKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitTNV):
                {
                    return "HitTNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitKindKHR):
                {
                    return "HitKindKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCurrentRayTimeNV):
                {
                    return "CurrentRayTimeNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitTriangleVertexPositionsKHR):
                {
                    return "HitTriangleVertexPositionsKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitMicroTriangleVertexPositionsNV):
                {
                    return "HitMicroTriangleVertexPositionsNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitMicroTriangleVertexBarycentricsNV):
                {
                    return "HitMicroTriangleVertexBarycentricsNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInIncomingRayFlagsKHR):
                {
                    return "IncomingRayFlagsKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInRayGeometryIndexKHR):
                {
                    return "RayGeometryIndexKHR";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitIsSphereNV):
                {
                    return "HitIsSphereNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitIsLSSNV):
                {
                    return "HitIsLSSNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitSpherePositionNV):
                {
                    return "HitSpherePositionNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWarpsPerSMNV):
                {
                    return "WarpsPerSMNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSMCountNV):
                {
                    return "SMCountNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInWarpIDNV):
                {
                    return "WarpIDNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInSMIDNV):
                {
                    return "SMIDNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitLSSPositionsNV):
                {
                    return "HitLSSPositionsNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitKindFrontFacingMicroTriangleNV):
                {
                    return "HitKindFrontFacingMicroTriangleNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitKindBackFacingMicroTriangleNV):
                {
                    return "HitKindBackFacingMicroTriangleNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitSphereRadiusNV):
                {
                    return "HitSphereRadiusNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInHitLSSRadiiNV):
                {
                    return "HitLSSRadiiNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInClusterIDNV):
                {
                    return "ClusterIDNV";
                }
                case unchecked((int)Spv.BuiltIn.BuiltInCullMaskKHR):
                {
                    return "CullMaskKHR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string ScopeToString(Spv.Scope value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.Scope.ScopeCrossDevice):
                {
                    return "CrossDevice";
                }
                case unchecked((int)Spv.Scope.ScopeDevice):
                {
                    return "Device";
                }
                case unchecked((int)Spv.Scope.ScopeWorkgroup):
                {
                    return "Workgroup";
                }
                case unchecked((int)Spv.Scope.ScopeSubgroup):
                {
                    return "Subgroup";
                }
                case unchecked((int)Spv.Scope.ScopeInvocation):
                {
                    return "Invocation";
                }
                case unchecked((int)Spv.Scope.ScopeQueueFamily):
                {
                    return "QueueFamily";
                }
                case unchecked((int)Spv.Scope.ScopeShaderCallKHR):
                {
                    return "ShaderCallKHR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string GroupOperationToString(Spv.GroupOperation value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.GroupOperation.GroupOperationReduce):
                {
                    return "Reduce";
                }
                case unchecked((int)Spv.GroupOperation.GroupOperationInclusiveScan):
                {
                    return "InclusiveScan";
                }
                case unchecked((int)Spv.GroupOperation.GroupOperationExclusiveScan):
                {
                    return "ExclusiveScan";
                }
                case unchecked((int)Spv.GroupOperation.GroupOperationClusteredReduce):
                {
                    return "ClusteredReduce";
                }
                case unchecked((int)Spv.GroupOperation.GroupOperationPartitionedReduceEXT):
                {
                    return "PartitionedReduceEXT";
                }
                case unchecked((int)Spv.GroupOperation.GroupOperationPartitionedInclusiveScanEXT):
                {
                    return "PartitionedInclusiveScanEXT";
                }
                case unchecked((int)Spv.GroupOperation.GroupOperationPartitionedExclusiveScanEXT):
                {
                    return "PartitionedExclusiveScanEXT";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string KernelEnqueueFlagsToString(Spv.KernelEnqueueFlags value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.KernelEnqueueFlags.KernelEnqueueFlagsNoWait):
                {
                    return "NoWait";
                }
                case unchecked((int)Spv.KernelEnqueueFlags.KernelEnqueueFlagsWaitKernel):
                {
                    return "WaitKernel";
                }
                case unchecked((int)Spv.KernelEnqueueFlags.KernelEnqueueFlagsWaitWorkGroup):
                {
                    return "WaitWorkGroup";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string CapabilityToString(Spv.Capability value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.Capability.CapabilityMatrix):
                {
                    return "Matrix";
                }
                case unchecked((int)Spv.Capability.CapabilityShader):
                {
                    return "Shader";
                }
                case unchecked((int)Spv.Capability.CapabilityGeometry):
                {
                    return "Geometry";
                }
                case unchecked((int)Spv.Capability.CapabilityTessellation):
                {
                    return "Tessellation";
                }
                case unchecked((int)Spv.Capability.CapabilityAddresses):
                {
                    return "Addresses";
                }
                case unchecked((int)Spv.Capability.CapabilityLinkage):
                {
                    return "Linkage";
                }
                case unchecked((int)Spv.Capability.CapabilityKernel):
                {
                    return "Kernel";
                }
                case unchecked((int)Spv.Capability.CapabilityVector16):
                {
                    return "Vector16";
                }
                case unchecked((int)Spv.Capability.CapabilityFloat16Buffer):
                {
                    return "Float16Buffer";
                }
                case unchecked((int)Spv.Capability.CapabilityFloat16):
                {
                    return "Float16";
                }
                case unchecked((int)Spv.Capability.CapabilityFloat64):
                {
                    return "Float64";
                }
                case unchecked((int)Spv.Capability.CapabilityInt64):
                {
                    return "Int64";
                }
                case unchecked((int)Spv.Capability.CapabilityInt64Atomics):
                {
                    return "Int64Atomics";
                }
                case unchecked((int)Spv.Capability.CapabilityImageBasic):
                {
                    return "ImageBasic";
                }
                case unchecked((int)Spv.Capability.CapabilityImageReadWrite):
                {
                    return "ImageReadWrite";
                }
                case unchecked((int)Spv.Capability.CapabilityImageMipmap):
                {
                    return "ImageMipmap";
                }
                case unchecked((int)Spv.Capability.CapabilityPipes):
                {
                    return "Pipes";
                }
                case unchecked((int)Spv.Capability.CapabilityGroups):
                {
                    return "Groups";
                }
                case unchecked((int)Spv.Capability.CapabilityDeviceEnqueue):
                {
                    return "DeviceEnqueue";
                }
                case unchecked((int)Spv.Capability.CapabilityLiteralSampler):
                {
                    return "LiteralSampler";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicStorage):
                {
                    return "AtomicStorage";
                }
                case unchecked((int)Spv.Capability.CapabilityInt16):
                {
                    return "Int16";
                }
                case unchecked((int)Spv.Capability.CapabilityTessellationPointSize):
                {
                    return "TessellationPointSize";
                }
                case unchecked((int)Spv.Capability.CapabilityGeometryPointSize):
                {
                    return "GeometryPointSize";
                }
                case unchecked((int)Spv.Capability.CapabilityImageGatherExtended):
                {
                    return "ImageGatherExtended";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageImageMultisample):
                {
                    return "StorageImageMultisample";
                }
                case unchecked((int)Spv.Capability.CapabilityUniformBufferArrayDynamicIndexing):
                {
                    return "UniformBufferArrayDynamicIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilitySampledImageArrayDynamicIndexing):
                {
                    return "SampledImageArrayDynamicIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageBufferArrayDynamicIndexing):
                {
                    return "StorageBufferArrayDynamicIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageImageArrayDynamicIndexing):
                {
                    return "StorageImageArrayDynamicIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityClipDistance):
                {
                    return "ClipDistance";
                }
                case unchecked((int)Spv.Capability.CapabilityCullDistance):
                {
                    return "CullDistance";
                }
                case unchecked((int)Spv.Capability.CapabilityImageCubeArray):
                {
                    return "ImageCubeArray";
                }
                case unchecked((int)Spv.Capability.CapabilitySampleRateShading):
                {
                    return "SampleRateShading";
                }
                case unchecked((int)Spv.Capability.CapabilityImageRect):
                {
                    return "ImageRect";
                }
                case unchecked((int)Spv.Capability.CapabilitySampledRect):
                {
                    return "SampledRect";
                }
                case unchecked((int)Spv.Capability.CapabilityGenericPointer):
                {
                    return "GenericPointer";
                }
                case unchecked((int)Spv.Capability.CapabilityInt8):
                {
                    return "Int8";
                }
                case unchecked((int)Spv.Capability.CapabilityInputAttachment):
                {
                    return "InputAttachment";
                }
                case unchecked((int)Spv.Capability.CapabilitySparseResidency):
                {
                    return "SparseResidency";
                }
                case unchecked((int)Spv.Capability.CapabilityMinLod):
                {
                    return "MinLod";
                }
                case unchecked((int)Spv.Capability.CapabilitySampled1D):
                {
                    return "Sampled1D";
                }
                case unchecked((int)Spv.Capability.CapabilityImage1D):
                {
                    return "Image1D";
                }
                case unchecked((int)Spv.Capability.CapabilitySampledCubeArray):
                {
                    return "SampledCubeArray";
                }
                case unchecked((int)Spv.Capability.CapabilitySampledBuffer):
                {
                    return "SampledBuffer";
                }
                case unchecked((int)Spv.Capability.CapabilityImageBuffer):
                {
                    return "ImageBuffer";
                }
                case unchecked((int)Spv.Capability.CapabilityImageMSArray):
                {
                    return "ImageMSArray";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageImageExtendedFormats):
                {
                    return "StorageImageExtendedFormats";
                }
                case unchecked((int)Spv.Capability.CapabilityImageQuery):
                {
                    return "ImageQuery";
                }
                case unchecked((int)Spv.Capability.CapabilityDerivativeControl):
                {
                    return "DerivativeControl";
                }
                case unchecked((int)Spv.Capability.CapabilityInterpolationFunction):
                {
                    return "InterpolationFunction";
                }
                case unchecked((int)Spv.Capability.CapabilityTransformFeedback):
                {
                    return "TransformFeedback";
                }
                case unchecked((int)Spv.Capability.CapabilityGeometryStreams):
                {
                    return "GeometryStreams";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageImageReadWithoutFormat):
                {
                    return "StorageImageReadWithoutFormat";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageImageWriteWithoutFormat):
                {
                    return "StorageImageWriteWithoutFormat";
                }
                case unchecked((int)Spv.Capability.CapabilityMultiViewport):
                {
                    return "MultiViewport";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupDispatch):
                {
                    return "SubgroupDispatch";
                }
                case unchecked((int)Spv.Capability.CapabilityNamedBarrier):
                {
                    return "NamedBarrier";
                }
                case unchecked((int)Spv.Capability.CapabilityPipeStorage):
                {
                    return "PipeStorage";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniform):
                {
                    return "GroupNonUniform";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformVote):
                {
                    return "GroupNonUniformVote";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformArithmetic):
                {
                    return "GroupNonUniformArithmetic";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformBallot):
                {
                    return "GroupNonUniformBallot";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformShuffle):
                {
                    return "GroupNonUniformShuffle";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformShuffleRelative):
                {
                    return "GroupNonUniformShuffleRelative";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformClustered):
                {
                    return "GroupNonUniformClustered";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformQuad):
                {
                    return "GroupNonUniformQuad";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderLayer):
                {
                    return "ShaderLayer";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderViewportIndex):
                {
                    return "ShaderViewportIndex";
                }
                case unchecked((int)Spv.Capability.CapabilityUniformDecoration):
                {
                    return "UniformDecoration";
                }
                case unchecked((int)Spv.Capability.CapabilityCoreBuiltinsARM):
                {
                    return "CoreBuiltinsARM";
                }
                case unchecked((int)Spv.Capability.CapabilityTileImageColorReadAccessEXT):
                {
                    return "TileImageColorReadAccessEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityTileImageDepthReadAccessEXT):
                {
                    return "TileImageDepthReadAccessEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityTileImageStencilReadAccessEXT):
                {
                    return "TileImageStencilReadAccessEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityTensorsARM):
                {
                    return "TensorsARM";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageTensorArrayDynamicIndexingARM):
                {
                    return "StorageTensorArrayDynamicIndexingARM";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageTensorArrayNonUniformIndexingARM):
                {
                    return "StorageTensorArrayNonUniformIndexingARM";
                }
                case unchecked((int)Spv.Capability.CapabilityGraphARM):
                {
                    return "GraphARM";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixLayoutsARM):
                {
                    return "CooperativeMatrixLayoutsARM";
                }
                case unchecked((int)Spv.Capability.CapabilityFloat8EXT):
                {
                    return "Float8EXT";
                }
                case unchecked((int)Spv.Capability.CapabilityFloat8CooperativeMatrixEXT):
                {
                    return "Float8CooperativeMatrixEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentShadingRateKHR):
                {
                    return "FragmentShadingRateKHR";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupBallotKHR):
                {
                    return "SubgroupBallotKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityDrawParameters):
                {
                    return "DrawParameters";
                }
                case unchecked((int)Spv.Capability.CapabilityWorkgroupMemoryExplicitLayoutKHR):
                {
                    return "WorkgroupMemoryExplicitLayoutKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityWorkgroupMemoryExplicitLayout8BitAccessKHR):
                {
                    return "WorkgroupMemoryExplicitLayout8BitAccessKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityWorkgroupMemoryExplicitLayout16BitAccessKHR):
                {
                    return "WorkgroupMemoryExplicitLayout16BitAccessKHR";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupVoteKHR):
                {
                    return "SubgroupVoteKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageBuffer16BitAccess):
                {
                    return "StorageBuffer16BitAccess";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageUniform16):
                {
                    return "StorageUniform16";
                }
                case unchecked((int)Spv.Capability.CapabilityStoragePushConstant16):
                {
                    return "StoragePushConstant16";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageInputOutput16):
                {
                    return "StorageInputOutput16";
                }
                case unchecked((int)Spv.Capability.CapabilityDeviceGroup):
                {
                    return "DeviceGroup";
                }
                case unchecked((int)Spv.Capability.CapabilityMultiView):
                {
                    return "MultiView";
                }
                case unchecked((int)Spv.Capability.CapabilityVariablePointersStorageBuffer):
                {
                    return "VariablePointersStorageBuffer";
                }
                case unchecked((int)Spv.Capability.CapabilityVariablePointers):
                {
                    return "VariablePointers";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicStorageOps):
                {
                    return "AtomicStorageOps";
                }
                case unchecked((int)Spv.Capability.CapabilitySampleMaskPostDepthCoverage):
                {
                    return "SampleMaskPostDepthCoverage";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageBuffer8BitAccess):
                {
                    return "StorageBuffer8BitAccess";
                }
                case unchecked((int)Spv.Capability.CapabilityUniformAndStorageBuffer8BitAccess):
                {
                    return "UniformAndStorageBuffer8BitAccess";
                }
                case unchecked((int)Spv.Capability.CapabilityStoragePushConstant8):
                {
                    return "StoragePushConstant8";
                }
                case unchecked((int)Spv.Capability.CapabilityDenormPreserve):
                {
                    return "DenormPreserve";
                }
                case unchecked((int)Spv.Capability.CapabilityDenormFlushToZero):
                {
                    return "DenormFlushToZero";
                }
                case unchecked((int)Spv.Capability.CapabilitySignedZeroInfNanPreserve):
                {
                    return "SignedZeroInfNanPreserve";
                }
                case unchecked((int)Spv.Capability.CapabilityRoundingModeRTE):
                {
                    return "RoundingModeRTE";
                }
                case unchecked((int)Spv.Capability.CapabilityRoundingModeRTZ):
                {
                    return "RoundingModeRTZ";
                }
                case unchecked((int)Spv.Capability.CapabilityRayQueryProvisionalKHR):
                {
                    return "RayQueryProvisionalKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityRayQueryKHR):
                {
                    return "RayQueryKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityUntypedPointersKHR):
                {
                    return "UntypedPointersKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTraversalPrimitiveCullingKHR):
                {
                    return "RayTraversalPrimitiveCullingKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingKHR):
                {
                    return "RayTracingKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityTextureSampleWeightedQCOM):
                {
                    return "TextureSampleWeightedQCOM";
                }
                case unchecked((int)Spv.Capability.CapabilityTextureBoxFilterQCOM):
                {
                    return "TextureBoxFilterQCOM";
                }
                case unchecked((int)Spv.Capability.CapabilityTextureBlockMatchQCOM):
                {
                    return "TextureBlockMatchQCOM";
                }
                case unchecked((int)Spv.Capability.CapabilityTileShadingQCOM):
                {
                    return "TileShadingQCOM";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixConversionQCOM):
                {
                    return "CooperativeMatrixConversionQCOM";
                }
                case unchecked((int)Spv.Capability.CapabilityTextureBlockMatch2QCOM):
                {
                    return "TextureBlockMatch2QCOM";
                }
                case unchecked((int)Spv.Capability.CapabilityFloat16ImageAMD):
                {
                    return "Float16ImageAMD";
                }
                case unchecked((int)Spv.Capability.CapabilityImageGatherBiasLodAMD):
                {
                    return "ImageGatherBiasLodAMD";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentMaskAMD):
                {
                    return "FragmentMaskAMD";
                }
                case unchecked((int)Spv.Capability.CapabilityStencilExportEXT):
                {
                    return "StencilExportEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityImageReadWriteLodAMD):
                {
                    return "ImageReadWriteLodAMD";
                }
                case unchecked((int)Spv.Capability.CapabilityInt64ImageEXT):
                {
                    return "Int64ImageEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderClockKHR):
                {
                    return "ShaderClockKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderEnqueueAMDX):
                {
                    return "ShaderEnqueueAMDX";
                }
                case unchecked((int)Spv.Capability.CapabilityQuadControlKHR):
                {
                    return "QuadControlKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityInt4TypeINTEL):
                {
                    return "Int4TypeINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityInt4CooperativeMatrixINTEL):
                {
                    return "Int4CooperativeMatrixINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityBFloat16TypeKHR):
                {
                    return "BFloat16TypeKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityBFloat16DotProductKHR):
                {
                    return "BFloat16DotProductKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityBFloat16CooperativeMatrixKHR):
                {
                    return "BFloat16CooperativeMatrixKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityAbortKHR):
                {
                    return "AbortKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityDescriptorHeapEXT):
                {
                    return "DescriptorHeapEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityConstantDataKHR):
                {
                    return "ConstantDataKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityPoisonFreezeKHR):
                {
                    return "PoisonFreezeKHR";
                }
                case unchecked((int)Spv.Capability.CapabilitySampleMaskOverrideCoverageNV):
                {
                    return "SampleMaskOverrideCoverageNV";
                }
                case unchecked((int)Spv.Capability.CapabilityGeometryShaderPassthroughNV):
                {
                    return "GeometryShaderPassthroughNV";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderViewportIndexLayerEXT):
                {
                    return "ShaderViewportIndexLayerEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderViewportMaskNV):
                {
                    return "ShaderViewportMaskNV";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderStereoViewNV):
                {
                    return "ShaderStereoViewNV";
                }
                case unchecked((int)Spv.Capability.CapabilityPerViewAttributesNV):
                {
                    return "PerViewAttributesNV";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentFullyCoveredEXT):
                {
                    return "FragmentFullyCoveredEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityMeshShadingNV):
                {
                    return "MeshShadingNV";
                }
                case unchecked((int)Spv.Capability.CapabilityImageFootprintNV):
                {
                    return "ImageFootprintNV";
                }
                case unchecked((int)Spv.Capability.CapabilityMeshShadingEXT):
                {
                    return "MeshShadingEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentBarycentricKHR):
                {
                    return "FragmentBarycentricKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityComputeDerivativeGroupQuadsKHR):
                {
                    return "ComputeDerivativeGroupQuadsKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentDensityEXT):
                {
                    return "FragmentDensityEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformPartitionedEXT):
                {
                    return "GroupNonUniformPartitionedEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderNonUniform):
                {
                    return "ShaderNonUniform";
                }
                case unchecked((int)Spv.Capability.CapabilityRuntimeDescriptorArray):
                {
                    return "RuntimeDescriptorArray";
                }
                case unchecked((int)Spv.Capability.CapabilityInputAttachmentArrayDynamicIndexing):
                {
                    return "InputAttachmentArrayDynamicIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityUniformTexelBufferArrayDynamicIndexing):
                {
                    return "UniformTexelBufferArrayDynamicIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageTexelBufferArrayDynamicIndexing):
                {
                    return "StorageTexelBufferArrayDynamicIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityUniformBufferArrayNonUniformIndexing):
                {
                    return "UniformBufferArrayNonUniformIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilitySampledImageArrayNonUniformIndexing):
                {
                    return "SampledImageArrayNonUniformIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageBufferArrayNonUniformIndexing):
                {
                    return "StorageBufferArrayNonUniformIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageImageArrayNonUniformIndexing):
                {
                    return "StorageImageArrayNonUniformIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityInputAttachmentArrayNonUniformIndexing):
                {
                    return "InputAttachmentArrayNonUniformIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityUniformTexelBufferArrayNonUniformIndexing):
                {
                    return "UniformTexelBufferArrayNonUniformIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityStorageTexelBufferArrayNonUniformIndexing):
                {
                    return "StorageTexelBufferArrayNonUniformIndexing";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingPositionFetchKHR):
                {
                    return "RayTracingPositionFetchKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingNV):
                {
                    return "RayTracingNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingMotionBlurNV):
                {
                    return "RayTracingMotionBlurNV";
                }
                case unchecked((int)Spv.Capability.CapabilityVulkanMemoryModel):
                {
                    return "VulkanMemoryModel";
                }
                case unchecked((int)Spv.Capability.CapabilityVulkanMemoryModelDeviceScope):
                {
                    return "VulkanMemoryModelDeviceScope";
                }
                case unchecked((int)Spv.Capability.CapabilityPhysicalStorageBufferAddresses):
                {
                    return "PhysicalStorageBufferAddresses";
                }
                case unchecked((int)Spv.Capability.CapabilityComputeDerivativeGroupLinearKHR):
                {
                    return "ComputeDerivativeGroupLinearKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingProvisionalKHR):
                {
                    return "RayTracingProvisionalKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixNV):
                {
                    return "CooperativeMatrixNV";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentShaderSampleInterlockEXT):
                {
                    return "FragmentShaderSampleInterlockEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentShaderShadingRateInterlockEXT):
                {
                    return "FragmentShaderShadingRateInterlockEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderSMBuiltinsNV):
                {
                    return "ShaderSMBuiltinsNV";
                }
                case unchecked((int)Spv.Capability.CapabilityFragmentShaderPixelInterlockEXT):
                {
                    return "FragmentShaderPixelInterlockEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityDemoteToHelperInvocation):
                {
                    return "DemoteToHelperInvocation";
                }
                case unchecked((int)Spv.Capability.CapabilityDisplacementMicromapNV):
                {
                    return "DisplacementMicromapNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingOpacityMicromapEXT):
                {
                    return "RayTracingOpacityMicromapEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderInvocationReorderNV):
                {
                    return "ShaderInvocationReorderNV";
                }
                case unchecked((int)Spv.Capability.CapabilityShaderInvocationReorderEXT):
                {
                    return "ShaderInvocationReorderEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityBindlessTextureNV):
                {
                    return "BindlessTextureNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRayQueryPositionFetchKHR):
                {
                    return "RayQueryPositionFetchKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeVectorNV):
                {
                    return "CooperativeVectorNV";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicFloat16VectorNV):
                {
                    return "AtomicFloat16VectorNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingDisplacementMicromapNV):
                {
                    return "RayTracingDisplacementMicromapNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRawAccessChainsNV):
                {
                    return "RawAccessChainsNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingSpheresGeometryNV):
                {
                    return "RayTracingSpheresGeometryNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingLinearSweptSpheresGeometryNV):
                {
                    return "RayTracingLinearSweptSpheresGeometryNV";
                }
                case unchecked((int)Spv.Capability.CapabilityPushConstantBanksNV):
                {
                    return "PushConstantBanksNV";
                }
                case unchecked((int)Spv.Capability.CapabilityLongVectorEXT):
                {
                    return "LongVectorEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityShader64BitIndexingEXT):
                {
                    return "Shader64BitIndexingEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixReductionsNV):
                {
                    return "CooperativeMatrixReductionsNV";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixConversionsNV):
                {
                    return "CooperativeMatrixConversionsNV";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixPerElementOperationsNV):
                {
                    return "CooperativeMatrixPerElementOperationsNV";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixTensorAddressingNV):
                {
                    return "CooperativeMatrixTensorAddressingNV";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixBlockLoadsNV):
                {
                    return "CooperativeMatrixBlockLoadsNV";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeVectorTrainingNV):
                {
                    return "CooperativeVectorTrainingNV";
                }
                case unchecked((int)Spv.Capability.CapabilityRayTracingClusterAccelerationStructureNV):
                {
                    return "RayTracingClusterAccelerationStructureNV";
                }
                case unchecked((int)Spv.Capability.CapabilityTensorAddressingNV):
                {
                    return "TensorAddressingNV";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupShuffleINTEL):
                {
                    return "SubgroupShuffleINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupBufferBlockIOINTEL):
                {
                    return "SubgroupBufferBlockIOINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupImageBlockIOINTEL):
                {
                    return "SubgroupImageBlockIOINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupImageMediaBlockIOINTEL):
                {
                    return "SubgroupImageMediaBlockIOINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityRoundToInfinityINTEL):
                {
                    return "RoundToInfinityINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFloatingPointModeINTEL):
                {
                    return "FloatingPointModeINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityIntegerFunctions2INTEL):
                {
                    return "IntegerFunctions2INTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFunctionPointersINTEL):
                {
                    return "FunctionPointersINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityIndirectReferencesINTEL):
                {
                    return "IndirectReferencesINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityAsmINTEL):
                {
                    return "AsmINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicFloat32MinMaxEXT):
                {
                    return "AtomicFloat32MinMaxEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicFloat64MinMaxEXT):
                {
                    return "AtomicFloat64MinMaxEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicFloat16MinMaxEXT):
                {
                    return "AtomicFloat16MinMaxEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityVectorComputeINTEL):
                {
                    return "VectorComputeINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityVectorAnyINTEL):
                {
                    return "VectorAnyINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityExpectAssumeKHR):
                {
                    return "ExpectAssumeKHR";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupAvcMotionEstimationINTEL):
                {
                    return "SubgroupAvcMotionEstimationINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupAvcMotionEstimationIntraINTEL):
                {
                    return "SubgroupAvcMotionEstimationIntraINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupAvcMotionEstimationChromaINTEL):
                {
                    return "SubgroupAvcMotionEstimationChromaINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityVariableLengthArrayINTEL):
                {
                    return "VariableLengthArrayINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFunctionFloatControlINTEL):
                {
                    return "FunctionFloatControlINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAMemoryAttributesALTERA):
                {
                    return "FPGAMemoryAttributesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPFastMathModeINTEL):
                {
                    return "FPFastMathModeINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityArbitraryPrecisionIntegersALTERA):
                {
                    return "ArbitraryPrecisionIntegersALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityArbitraryPrecisionFloatingPointALTERA):
                {
                    return "ArbitraryPrecisionFloatingPointALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityUnstructuredLoopControlsINTEL):
                {
                    return "UnstructuredLoopControlsINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGALoopControlsALTERA):
                {
                    return "FPGALoopControlsALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityKernelAttributesINTEL):
                {
                    return "KernelAttributesINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAKernelAttributesINTEL):
                {
                    return "FPGAKernelAttributesINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAMemoryAccessesALTERA):
                {
                    return "FPGAMemoryAccessesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAClusterAttributesALTERA):
                {
                    return "FPGAClusterAttributesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityLoopFuseALTERA):
                {
                    return "LoopFuseALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGADSPControlALTERA):
                {
                    return "FPGADSPControlALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityMemoryAccessAliasingINTEL):
                {
                    return "MemoryAccessAliasingINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAInvocationPipeliningAttributesALTERA):
                {
                    return "FPGAInvocationPipeliningAttributesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGABufferLocationALTERA):
                {
                    return "FPGABufferLocationALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityArbitraryPrecisionFixedPointALTERA):
                {
                    return "ArbitraryPrecisionFixedPointALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityUSMStorageClassesALTERA):
                {
                    return "USMStorageClassesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityRuntimeAlignedAttributeALTERA):
                {
                    return "RuntimeAlignedAttributeALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityIOPipesALTERA):
                {
                    return "IOPipesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityBlockingPipesALTERA):
                {
                    return "BlockingPipesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGARegALTERA):
                {
                    return "FPGARegALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProductInputAll):
                {
                    return "DotProductInputAll";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProductInput4x8Bit):
                {
                    return "DotProductInput4x8Bit";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProductInput4x8BitPacked):
                {
                    return "DotProductInput4x8BitPacked";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProduct):
                {
                    return "DotProduct";
                }
                case unchecked((int)Spv.Capability.CapabilityRayCullMaskKHR):
                {
                    return "RayCullMaskKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityCooperativeMatrixKHR):
                {
                    return "CooperativeMatrixKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityReplicatedCompositesEXT):
                {
                    return "ReplicatedCompositesEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityBitInstructions):
                {
                    return "BitInstructions";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupNonUniformRotateKHR):
                {
                    return "GroupNonUniformRotateKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityFloatControls2):
                {
                    return "FloatControls2";
                }
                case unchecked((int)Spv.Capability.CapabilityFMAKHR):
                {
                    return "FMAKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicFloat32AddEXT):
                {
                    return "AtomicFloat32AddEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicFloat64AddEXT):
                {
                    return "AtomicFloat64AddEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityLongCompositesINTEL):
                {
                    return "LongCompositesINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityOptNoneEXT):
                {
                    return "OptNoneEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityAtomicFloat16AddEXT):
                {
                    return "AtomicFloat16AddEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityDebugInfoModuleINTEL):
                {
                    return "DebugInfoModuleINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityBFloat16ConversionINTEL):
                {
                    return "BFloat16ConversionINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySplitBarrierINTEL):
                {
                    return "SplitBarrierINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityArithmeticFenceEXT):
                {
                    return "ArithmeticFenceEXT";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAClusterAttributesV2ALTERA):
                {
                    return "FPGAClusterAttributesV2ALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAKernelAttributesv2INTEL):
                {
                    return "FPGAKernelAttributesv2INTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityTaskSequenceALTERA):
                {
                    return "TaskSequenceALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPMaxErrorINTEL):
                {
                    return "FPMaxErrorINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGALatencyControlALTERA):
                {
                    return "FPGALatencyControlALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityFPGAArgumentInterfacesALTERA):
                {
                    return "FPGAArgumentInterfacesALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilityGlobalVariableHostAccessINTEL):
                {
                    return "GlobalVariableHostAccessINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityGlobalVariableFPGADecorationsALTERA):
                {
                    return "GlobalVariableFPGADecorationsALTERA";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupBufferPrefetchINTEL):
                {
                    return "SubgroupBufferPrefetchINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroup2DBlockIOINTEL):
                {
                    return "Subgroup2DBlockIOINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroup2DBlockTransformINTEL):
                {
                    return "Subgroup2DBlockTransformINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroup2DBlockTransposeINTEL):
                {
                    return "Subgroup2DBlockTransposeINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySubgroupMatrixMultiplyAccumulateINTEL):
                {
                    return "SubgroupMatrixMultiplyAccumulateINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityTernaryBitwiseFunctionINTEL):
                {
                    return "TernaryBitwiseFunctionINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityUntypedVariableLengthArrayINTEL):
                {
                    return "UntypedVariableLengthArrayINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilitySpecConditionalINTEL):
                {
                    return "SpecConditionalINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityFunctionVariantsINTEL):
                {
                    return "FunctionVariantsINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityGroupUniformArithmeticKHR):
                {
                    return "GroupUniformArithmeticKHR";
                }
                case unchecked((int)Spv.Capability.CapabilityTensorFloat32RoundingINTEL):
                {
                    return "TensorFloat32RoundingINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityMaskedGatherScatterINTEL):
                {
                    return "MaskedGatherScatterINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityCacheControlsINTEL):
                {
                    return "CacheControlsINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityRegisterLimitsINTEL):
                {
                    return "RegisterLimitsINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityBindlessImagesINTEL):
                {
                    return "BindlessImagesINTEL";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProductFloat16AccFloat32VALVE):
                {
                    return "DotProductFloat16AccFloat32VALVE";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProductFloat16AccFloat16VALVE):
                {
                    return "DotProductFloat16AccFloat16VALVE";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProductBFloat16AccVALVE):
                {
                    return "DotProductBFloat16AccVALVE";
                }
                case unchecked((int)Spv.Capability.CapabilityDotProductFloat8AccFloat32VALVE):
                {
                    return "DotProductFloat8AccFloat32VALVE";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string RayQueryIntersectionToString(Spv.RayQueryIntersection value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.RayQueryIntersection.RayQueryIntersectionRayQueryCandidateIntersectionKHR):
                {
                    return "RayQueryCandidateIntersectionKHR";
                }
                case unchecked((int)Spv.RayQueryIntersection.RayQueryIntersectionRayQueryCommittedIntersectionKHR):
                {
                    return "RayQueryCommittedIntersectionKHR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string RayQueryCommittedIntersectionTypeToString(Spv.RayQueryCommittedIntersectionType value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.RayQueryCommittedIntersectionType.RayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionNoneKHR):
                {
                    return "RayQueryCommittedIntersectionNoneKHR";
                }
                case unchecked((int)Spv.RayQueryCommittedIntersectionType.RayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionTriangleKHR):
                {
                    return "RayQueryCommittedIntersectionTriangleKHR";
                }
                case unchecked((int)Spv.RayQueryCommittedIntersectionType.RayQueryCommittedIntersectionTypeRayQueryCommittedIntersectionGeneratedKHR):
                {
                    return "RayQueryCommittedIntersectionGeneratedKHR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string RayQueryCandidateIntersectionTypeToString(Spv.RayQueryCandidateIntersectionType value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.RayQueryCandidateIntersectionType.RayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionTriangleKHR):
                {
                    return "RayQueryCandidateIntersectionTriangleKHR";
                }
                case unchecked((int)Spv.RayQueryCandidateIntersectionType.RayQueryCandidateIntersectionTypeRayQueryCandidateIntersectionAABBKHR):
                {
                    return "RayQueryCandidateIntersectionAABBKHR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string FPDenormModeToString(Spv.FPDenormMode value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.FPDenormMode.FPDenormModePreserve):
                {
                    return "Preserve";
                }
                case unchecked((int)Spv.FPDenormMode.FPDenormModeFlushToZero):
                {
                    return "FlushToZero";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string FPOperationModeToString(Spv.FPOperationMode value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.FPOperationMode.FPOperationModeIEEE):
                {
                    return "IEEE";
                }
                case unchecked((int)Spv.FPOperationMode.FPOperationModeALT):
                {
                    return "ALT";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string QuantizationModesToString(Spv.QuantizationModes value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.QuantizationModes.QuantizationModesTRN):
                {
                    return "TRN";
                }
                case unchecked((int)Spv.QuantizationModes.QuantizationModesTRN_ZERO):
                {
                    return "TRN_ZERO";
                }
                case unchecked((int)Spv.QuantizationModes.QuantizationModesRND):
                {
                    return "RND";
                }
                case unchecked((int)Spv.QuantizationModes.QuantizationModesRND_ZERO):
                {
                    return "RND_ZERO";
                }
                case unchecked((int)Spv.QuantizationModes.QuantizationModesRND_INF):
                {
                    return "RND_INF";
                }
                case unchecked((int)Spv.QuantizationModes.QuantizationModesRND_MIN_INF):
                {
                    return "RND_MIN_INF";
                }
                case unchecked((int)Spv.QuantizationModes.QuantizationModesRND_CONV):
                {
                    return "RND_CONV";
                }
                case unchecked((int)Spv.QuantizationModes.QuantizationModesRND_CONV_ODD):
                {
                    return "RND_CONV_ODD";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string OverflowModesToString(Spv.OverflowModes value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.OverflowModes.OverflowModesWRAP):
                {
                    return "WRAP";
                }
                case unchecked((int)Spv.OverflowModes.OverflowModesSAT):
                {
                    return "SAT";
                }
                case unchecked((int)Spv.OverflowModes.OverflowModesSAT_ZERO):
                {
                    return "SAT_ZERO";
                }
                case unchecked((int)Spv.OverflowModes.OverflowModesSAT_SYM):
                {
                    return "SAT_SYM";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string PackedVectorFormatToString(Spv.PackedVectorFormat value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.PackedVectorFormat.PackedVectorFormatPackedVectorFormat4x8Bit):
                {
                    return "PackedVectorFormat4x8Bit";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string CooperativeMatrixLayoutToString(Spv.CooperativeMatrixLayout value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.CooperativeMatrixLayout.CooperativeMatrixLayoutRowMajorKHR):
                {
                    return "RowMajorKHR";
                }
                case unchecked((int)Spv.CooperativeMatrixLayout.CooperativeMatrixLayoutColumnMajorKHR):
                {
                    return "ColumnMajorKHR";
                }
                case unchecked((int)Spv.CooperativeMatrixLayout.CooperativeMatrixLayoutRowBlockedInterleavedARM):
                {
                    return "RowBlockedInterleavedARM";
                }
                case unchecked((int)Spv.CooperativeMatrixLayout.CooperativeMatrixLayoutColumnBlockedInterleavedARM):
                {
                    return "ColumnBlockedInterleavedARM";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string CooperativeMatrixUseToString(Spv.CooperativeMatrixUse value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.CooperativeMatrixUse.CooperativeMatrixUseMatrixAKHR):
                {
                    return "MatrixAKHR";
                }
                case unchecked((int)Spv.CooperativeMatrixUse.CooperativeMatrixUseMatrixBKHR):
                {
                    return "MatrixBKHR";
                }
                case unchecked((int)Spv.CooperativeMatrixUse.CooperativeMatrixUseMatrixAccumulatorKHR):
                {
                    return "MatrixAccumulatorKHR";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string TensorClampModeToString(Spv.TensorClampMode value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.TensorClampMode.TensorClampModeUndefined):
                {
                    return "Undefined";
                }
                case unchecked((int)Spv.TensorClampMode.TensorClampModeConstant):
                {
                    return "Constant";
                }
                case unchecked((int)Spv.TensorClampMode.TensorClampModeClampToEdge):
                {
                    return "ClampToEdge";
                }
                case unchecked((int)Spv.TensorClampMode.TensorClampModeRepeat):
                {
                    return "Repeat";
                }
                case unchecked((int)Spv.TensorClampMode.TensorClampModeRepeatMirrored):
                {
                    return "RepeatMirrored";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string InitializationModeQualifierToString(Spv.InitializationModeQualifier value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.InitializationModeQualifier.InitializationModeQualifierInitOnDeviceReprogramALTERA):
                {
                    return "InitOnDeviceReprogramALTERA";
                }
                case unchecked((int)Spv.InitializationModeQualifier.InitializationModeQualifierInitOnDeviceResetALTERA):
                {
                    return "InitOnDeviceResetALTERA";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string HostAccessQualifierToString(Spv.HostAccessQualifier value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.HostAccessQualifier.HostAccessQualifierNoneINTEL):
                {
                    return "NoneINTEL";
                }
                case unchecked((int)Spv.HostAccessQualifier.HostAccessQualifierReadINTEL):
                {
                    return "ReadINTEL";
                }
                case unchecked((int)Spv.HostAccessQualifier.HostAccessQualifierWriteINTEL):
                {
                    return "WriteINTEL";
                }
                case unchecked((int)Spv.HostAccessQualifier.HostAccessQualifierReadWriteINTEL):
                {
                    return "ReadWriteINTEL";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string LoadCacheControlToString(Spv.LoadCacheControl value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.LoadCacheControl.LoadCacheControlUncachedINTEL):
                {
                    return "UncachedINTEL";
                }
                case unchecked((int)Spv.LoadCacheControl.LoadCacheControlCachedINTEL):
                {
                    return "CachedINTEL";
                }
                case unchecked((int)Spv.LoadCacheControl.LoadCacheControlStreamingINTEL):
                {
                    return "StreamingINTEL";
                }
                case unchecked((int)Spv.LoadCacheControl.LoadCacheControlInvalidateAfterReadINTEL):
                {
                    return "InvalidateAfterReadINTEL";
                }
                case unchecked((int)Spv.LoadCacheControl.LoadCacheControlConstCachedINTEL):
                {
                    return "ConstCachedINTEL";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string StoreCacheControlToString(Spv.StoreCacheControl value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.StoreCacheControl.StoreCacheControlUncachedINTEL):
                {
                    return "UncachedINTEL";
                }
                case unchecked((int)Spv.StoreCacheControl.StoreCacheControlWriteThroughINTEL):
                {
                    return "WriteThroughINTEL";
                }
                case unchecked((int)Spv.StoreCacheControl.StoreCacheControlWriteBackINTEL):
                {
                    return "WriteBackINTEL";
                }
                case unchecked((int)Spv.StoreCacheControl.StoreCacheControlStreamingINTEL):
                {
                    return "StreamingINTEL";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string NamedMaximumNumberOfRegistersToString(Spv.NamedMaximumNumberOfRegisters value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.NamedMaximumNumberOfRegisters.NamedMaximumNumberOfRegistersAutoINTEL):
                {
                    return "AutoINTEL";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string FPEncodingToString(Spv.FPEncoding value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.FPEncoding.FPEncodingBFloat16KHR):
                {
                    return "BFloat16KHR";
                }
                case unchecked((int)Spv.FPEncoding.FPEncodingFloat8E4M3EXT):
                {
                    return "Float8E4M3EXT";
                }
                case unchecked((int)Spv.FPEncoding.FPEncodingFloat8E5M2EXT):
                {
                    return "Float8E5M2EXT";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string CooperativeVectorMatrixLayoutToString(Spv.CooperativeVectorMatrixLayout value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutRowMajorNV):
                {
                    return "RowMajorNV";
                }
                case unchecked((int)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutColumnMajorNV):
                {
                    return "ColumnMajorNV";
                }
                case unchecked((int)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutInferencingOptimalNV):
                {
                    return "InferencingOptimalNV";
                }
                case unchecked((int)Spv.CooperativeVectorMatrixLayout.CooperativeVectorMatrixLayoutTrainingOptimalNV):
                {
                    return "TrainingOptimalNV";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string ComponentTypeToString(Spv.ComponentType value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.ComponentType.ComponentTypeFloat16NV):
                {
                    return "Float16NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeFloat32NV):
                {
                    return "Float32NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeFloat64NV):
                {
                    return "Float64NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeSignedInt8NV):
                {
                    return "SignedInt8NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeSignedInt16NV):
                {
                    return "SignedInt16NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeSignedInt32NV):
                {
                    return "SignedInt32NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeSignedInt64NV):
                {
                    return "SignedInt64NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeUnsignedInt8NV):
                {
                    return "UnsignedInt8NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeUnsignedInt16NV):
                {
                    return "UnsignedInt16NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeUnsignedInt32NV):
                {
                    return "UnsignedInt32NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeUnsignedInt64NV):
                {
                    return "UnsignedInt64NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeSignedInt8PackedNV):
                {
                    return "SignedInt8PackedNV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeUnsignedInt8PackedNV):
                {
                    return "UnsignedInt8PackedNV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeFloatE4M3NV):
                {
                    return "FloatE4M3NV";
                }
                case unchecked((int)Spv.ComponentType.ComponentTypeFloatE5M2NV):
                {
                    return "FloatE5M2NV";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static string OpToString(Spv.Op value)
    {
        {
            switch (unchecked((int)value))
            {
                case unchecked((int)Spv.Op.OpNop):
                {
                    return "OpNop";
                }
                case unchecked((int)Spv.Op.OpUndef):
                {
                    return "OpUndef";
                }
                case unchecked((int)Spv.Op.OpSourceContinued):
                {
                    return "OpSourceContinued";
                }
                case unchecked((int)Spv.Op.OpSource):
                {
                    return "OpSource";
                }
                case unchecked((int)Spv.Op.OpSourceExtension):
                {
                    return "OpSourceExtension";
                }
                case unchecked((int)Spv.Op.OpName):
                {
                    return "OpName";
                }
                case unchecked((int)Spv.Op.OpMemberName):
                {
                    return "OpMemberName";
                }
                case unchecked((int)Spv.Op.OpString):
                {
                    return "OpString";
                }
                case unchecked((int)Spv.Op.OpLine):
                {
                    return "OpLine";
                }
                case unchecked((int)Spv.Op.OpExtension):
                {
                    return "OpExtension";
                }
                case unchecked((int)Spv.Op.OpExtInstImport):
                {
                    return "OpExtInstImport";
                }
                case unchecked((int)Spv.Op.OpExtInst):
                {
                    return "OpExtInst";
                }
                case unchecked((int)Spv.Op.OpMemoryModel):
                {
                    return "OpMemoryModel";
                }
                case unchecked((int)Spv.Op.OpEntryPoint):
                {
                    return "OpEntryPoint";
                }
                case unchecked((int)Spv.Op.OpExecutionMode):
                {
                    return "OpExecutionMode";
                }
                case unchecked((int)Spv.Op.OpCapability):
                {
                    return "OpCapability";
                }
                case unchecked((int)Spv.Op.OpTypeVoid):
                {
                    return "OpTypeVoid";
                }
                case unchecked((int)Spv.Op.OpTypeBool):
                {
                    return "OpTypeBool";
                }
                case unchecked((int)Spv.Op.OpTypeInt):
                {
                    return "OpTypeInt";
                }
                case unchecked((int)Spv.Op.OpTypeFloat):
                {
                    return "OpTypeFloat";
                }
                case unchecked((int)Spv.Op.OpTypeVector):
                {
                    return "OpTypeVector";
                }
                case unchecked((int)Spv.Op.OpTypeMatrix):
                {
                    return "OpTypeMatrix";
                }
                case unchecked((int)Spv.Op.OpTypeImage):
                {
                    return "OpTypeImage";
                }
                case unchecked((int)Spv.Op.OpTypeSampler):
                {
                    return "OpTypeSampler";
                }
                case unchecked((int)Spv.Op.OpTypeSampledImage):
                {
                    return "OpTypeSampledImage";
                }
                case unchecked((int)Spv.Op.OpTypeArray):
                {
                    return "OpTypeArray";
                }
                case unchecked((int)Spv.Op.OpTypeRuntimeArray):
                {
                    return "OpTypeRuntimeArray";
                }
                case unchecked((int)Spv.Op.OpTypeStruct):
                {
                    return "OpTypeStruct";
                }
                case unchecked((int)Spv.Op.OpTypeOpaque):
                {
                    return "OpTypeOpaque";
                }
                case unchecked((int)Spv.Op.OpTypePointer):
                {
                    return "OpTypePointer";
                }
                case unchecked((int)Spv.Op.OpTypeFunction):
                {
                    return "OpTypeFunction";
                }
                case unchecked((int)Spv.Op.OpTypeEvent):
                {
                    return "OpTypeEvent";
                }
                case unchecked((int)Spv.Op.OpTypeDeviceEvent):
                {
                    return "OpTypeDeviceEvent";
                }
                case unchecked((int)Spv.Op.OpTypeReserveId):
                {
                    return "OpTypeReserveId";
                }
                case unchecked((int)Spv.Op.OpTypeQueue):
                {
                    return "OpTypeQueue";
                }
                case unchecked((int)Spv.Op.OpTypePipe):
                {
                    return "OpTypePipe";
                }
                case unchecked((int)Spv.Op.OpTypeForwardPointer):
                {
                    return "OpTypeForwardPointer";
                }
                case unchecked((int)Spv.Op.OpConstantTrue):
                {
                    return "OpConstantTrue";
                }
                case unchecked((int)Spv.Op.OpConstantFalse):
                {
                    return "OpConstantFalse";
                }
                case unchecked((int)Spv.Op.OpConstant):
                {
                    return "OpConstant";
                }
                case unchecked((int)Spv.Op.OpConstantComposite):
                {
                    return "OpConstantComposite";
                }
                case unchecked((int)Spv.Op.OpConstantSampler):
                {
                    return "OpConstantSampler";
                }
                case unchecked((int)Spv.Op.OpConstantNull):
                {
                    return "OpConstantNull";
                }
                case unchecked((int)Spv.Op.OpSpecConstantTrue):
                {
                    return "OpSpecConstantTrue";
                }
                case unchecked((int)Spv.Op.OpSpecConstantFalse):
                {
                    return "OpSpecConstantFalse";
                }
                case unchecked((int)Spv.Op.OpSpecConstant):
                {
                    return "OpSpecConstant";
                }
                case unchecked((int)Spv.Op.OpSpecConstantComposite):
                {
                    return "OpSpecConstantComposite";
                }
                case unchecked((int)Spv.Op.OpSpecConstantOp):
                {
                    return "OpSpecConstantOp";
                }
                case unchecked((int)Spv.Op.OpFunction):
                {
                    return "OpFunction";
                }
                case unchecked((int)Spv.Op.OpFunctionParameter):
                {
                    return "OpFunctionParameter";
                }
                case unchecked((int)Spv.Op.OpFunctionEnd):
                {
                    return "OpFunctionEnd";
                }
                case unchecked((int)Spv.Op.OpFunctionCall):
                {
                    return "OpFunctionCall";
                }
                case unchecked((int)Spv.Op.OpVariable):
                {
                    return "OpVariable";
                }
                case unchecked((int)Spv.Op.OpImageTexelPointer):
                {
                    return "OpImageTexelPointer";
                }
                case unchecked((int)Spv.Op.OpLoad):
                {
                    return "OpLoad";
                }
                case unchecked((int)Spv.Op.OpStore):
                {
                    return "OpStore";
                }
                case unchecked((int)Spv.Op.OpCopyMemory):
                {
                    return "OpCopyMemory";
                }
                case unchecked((int)Spv.Op.OpCopyMemorySized):
                {
                    return "OpCopyMemorySized";
                }
                case unchecked((int)Spv.Op.OpAccessChain):
                {
                    return "OpAccessChain";
                }
                case unchecked((int)Spv.Op.OpInBoundsAccessChain):
                {
                    return "OpInBoundsAccessChain";
                }
                case unchecked((int)Spv.Op.OpPtrAccessChain):
                {
                    return "OpPtrAccessChain";
                }
                case unchecked((int)Spv.Op.OpArrayLength):
                {
                    return "OpArrayLength";
                }
                case unchecked((int)Spv.Op.OpGenericPtrMemSemantics):
                {
                    return "OpGenericPtrMemSemantics";
                }
                case unchecked((int)Spv.Op.OpInBoundsPtrAccessChain):
                {
                    return "OpInBoundsPtrAccessChain";
                }
                case unchecked((int)Spv.Op.OpDecorate):
                {
                    return "OpDecorate";
                }
                case unchecked((int)Spv.Op.OpMemberDecorate):
                {
                    return "OpMemberDecorate";
                }
                case unchecked((int)Spv.Op.OpDecorationGroup):
                {
                    return "OpDecorationGroup";
                }
                case unchecked((int)Spv.Op.OpGroupDecorate):
                {
                    return "OpGroupDecorate";
                }
                case unchecked((int)Spv.Op.OpGroupMemberDecorate):
                {
                    return "OpGroupMemberDecorate";
                }
                case unchecked((int)Spv.Op.OpVectorExtractDynamic):
                {
                    return "OpVectorExtractDynamic";
                }
                case unchecked((int)Spv.Op.OpVectorInsertDynamic):
                {
                    return "OpVectorInsertDynamic";
                }
                case unchecked((int)Spv.Op.OpVectorShuffle):
                {
                    return "OpVectorShuffle";
                }
                case unchecked((int)Spv.Op.OpCompositeConstruct):
                {
                    return "OpCompositeConstruct";
                }
                case unchecked((int)Spv.Op.OpCompositeExtract):
                {
                    return "OpCompositeExtract";
                }
                case unchecked((int)Spv.Op.OpCompositeInsert):
                {
                    return "OpCompositeInsert";
                }
                case unchecked((int)Spv.Op.OpCopyObject):
                {
                    return "OpCopyObject";
                }
                case unchecked((int)Spv.Op.OpTranspose):
                {
                    return "OpTranspose";
                }
                case unchecked((int)Spv.Op.OpSampledImage):
                {
                    return "OpSampledImage";
                }
                case unchecked((int)Spv.Op.OpImageSampleImplicitLod):
                {
                    return "OpImageSampleImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSampleExplicitLod):
                {
                    return "OpImageSampleExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSampleDrefImplicitLod):
                {
                    return "OpImageSampleDrefImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSampleDrefExplicitLod):
                {
                    return "OpImageSampleDrefExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSampleProjImplicitLod):
                {
                    return "OpImageSampleProjImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSampleProjExplicitLod):
                {
                    return "OpImageSampleProjExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSampleProjDrefImplicitLod):
                {
                    return "OpImageSampleProjDrefImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSampleProjDrefExplicitLod):
                {
                    return "OpImageSampleProjDrefExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageFetch):
                {
                    return "OpImageFetch";
                }
                case unchecked((int)Spv.Op.OpImageGather):
                {
                    return "OpImageGather";
                }
                case unchecked((int)Spv.Op.OpImageDrefGather):
                {
                    return "OpImageDrefGather";
                }
                case unchecked((int)Spv.Op.OpImageRead):
                {
                    return "OpImageRead";
                }
                case unchecked((int)Spv.Op.OpImageWrite):
                {
                    return "OpImageWrite";
                }
                case unchecked((int)Spv.Op.OpImage):
                {
                    return "OpImage";
                }
                case unchecked((int)Spv.Op.OpImageQueryFormat):
                {
                    return "OpImageQueryFormat";
                }
                case unchecked((int)Spv.Op.OpImageQueryOrder):
                {
                    return "OpImageQueryOrder";
                }
                case unchecked((int)Spv.Op.OpImageQuerySizeLod):
                {
                    return "OpImageQuerySizeLod";
                }
                case unchecked((int)Spv.Op.OpImageQuerySize):
                {
                    return "OpImageQuerySize";
                }
                case unchecked((int)Spv.Op.OpImageQueryLod):
                {
                    return "OpImageQueryLod";
                }
                case unchecked((int)Spv.Op.OpImageQueryLevels):
                {
                    return "OpImageQueryLevels";
                }
                case unchecked((int)Spv.Op.OpImageQuerySamples):
                {
                    return "OpImageQuerySamples";
                }
                case unchecked((int)Spv.Op.OpConvertFToU):
                {
                    return "OpConvertFToU";
                }
                case unchecked((int)Spv.Op.OpConvertFToS):
                {
                    return "OpConvertFToS";
                }
                case unchecked((int)Spv.Op.OpConvertSToF):
                {
                    return "OpConvertSToF";
                }
                case unchecked((int)Spv.Op.OpConvertUToF):
                {
                    return "OpConvertUToF";
                }
                case unchecked((int)Spv.Op.OpUConvert):
                {
                    return "OpUConvert";
                }
                case unchecked((int)Spv.Op.OpSConvert):
                {
                    return "OpSConvert";
                }
                case unchecked((int)Spv.Op.OpFConvert):
                {
                    return "OpFConvert";
                }
                case unchecked((int)Spv.Op.OpQuantizeToF16):
                {
                    return "OpQuantizeToF16";
                }
                case unchecked((int)Spv.Op.OpConvertPtrToU):
                {
                    return "OpConvertPtrToU";
                }
                case unchecked((int)Spv.Op.OpSatConvertSToU):
                {
                    return "OpSatConvertSToU";
                }
                case unchecked((int)Spv.Op.OpSatConvertUToS):
                {
                    return "OpSatConvertUToS";
                }
                case unchecked((int)Spv.Op.OpConvertUToPtr):
                {
                    return "OpConvertUToPtr";
                }
                case unchecked((int)Spv.Op.OpPtrCastToGeneric):
                {
                    return "OpPtrCastToGeneric";
                }
                case unchecked((int)Spv.Op.OpGenericCastToPtr):
                {
                    return "OpGenericCastToPtr";
                }
                case unchecked((int)Spv.Op.OpGenericCastToPtrExplicit):
                {
                    return "OpGenericCastToPtrExplicit";
                }
                case unchecked((int)Spv.Op.OpBitcast):
                {
                    return "OpBitcast";
                }
                case unchecked((int)Spv.Op.OpSNegate):
                {
                    return "OpSNegate";
                }
                case unchecked((int)Spv.Op.OpFNegate):
                {
                    return "OpFNegate";
                }
                case unchecked((int)Spv.Op.OpIAdd):
                {
                    return "OpIAdd";
                }
                case unchecked((int)Spv.Op.OpFAdd):
                {
                    return "OpFAdd";
                }
                case unchecked((int)Spv.Op.OpISub):
                {
                    return "OpISub";
                }
                case unchecked((int)Spv.Op.OpFSub):
                {
                    return "OpFSub";
                }
                case unchecked((int)Spv.Op.OpIMul):
                {
                    return "OpIMul";
                }
                case unchecked((int)Spv.Op.OpFMul):
                {
                    return "OpFMul";
                }
                case unchecked((int)Spv.Op.OpUDiv):
                {
                    return "OpUDiv";
                }
                case unchecked((int)Spv.Op.OpSDiv):
                {
                    return "OpSDiv";
                }
                case unchecked((int)Spv.Op.OpFDiv):
                {
                    return "OpFDiv";
                }
                case unchecked((int)Spv.Op.OpUMod):
                {
                    return "OpUMod";
                }
                case unchecked((int)Spv.Op.OpSRem):
                {
                    return "OpSRem";
                }
                case unchecked((int)Spv.Op.OpSMod):
                {
                    return "OpSMod";
                }
                case unchecked((int)Spv.Op.OpFRem):
                {
                    return "OpFRem";
                }
                case unchecked((int)Spv.Op.OpFMod):
                {
                    return "OpFMod";
                }
                case unchecked((int)Spv.Op.OpVectorTimesScalar):
                {
                    return "OpVectorTimesScalar";
                }
                case unchecked((int)Spv.Op.OpMatrixTimesScalar):
                {
                    return "OpMatrixTimesScalar";
                }
                case unchecked((int)Spv.Op.OpVectorTimesMatrix):
                {
                    return "OpVectorTimesMatrix";
                }
                case unchecked((int)Spv.Op.OpMatrixTimesVector):
                {
                    return "OpMatrixTimesVector";
                }
                case unchecked((int)Spv.Op.OpMatrixTimesMatrix):
                {
                    return "OpMatrixTimesMatrix";
                }
                case unchecked((int)Spv.Op.OpOuterProduct):
                {
                    return "OpOuterProduct";
                }
                case unchecked((int)Spv.Op.OpDot):
                {
                    return "OpDot";
                }
                case unchecked((int)Spv.Op.OpIAddCarry):
                {
                    return "OpIAddCarry";
                }
                case unchecked((int)Spv.Op.OpISubBorrow):
                {
                    return "OpISubBorrow";
                }
                case unchecked((int)Spv.Op.OpUMulExtended):
                {
                    return "OpUMulExtended";
                }
                case unchecked((int)Spv.Op.OpSMulExtended):
                {
                    return "OpSMulExtended";
                }
                case unchecked((int)Spv.Op.OpAny):
                {
                    return "OpAny";
                }
                case unchecked((int)Spv.Op.OpAll):
                {
                    return "OpAll";
                }
                case unchecked((int)Spv.Op.OpIsNan):
                {
                    return "OpIsNan";
                }
                case unchecked((int)Spv.Op.OpIsInf):
                {
                    return "OpIsInf";
                }
                case unchecked((int)Spv.Op.OpIsFinite):
                {
                    return "OpIsFinite";
                }
                case unchecked((int)Spv.Op.OpIsNormal):
                {
                    return "OpIsNormal";
                }
                case unchecked((int)Spv.Op.OpSignBitSet):
                {
                    return "OpSignBitSet";
                }
                case unchecked((int)Spv.Op.OpLessOrGreater):
                {
                    return "OpLessOrGreater";
                }
                case unchecked((int)Spv.Op.OpOrdered):
                {
                    return "OpOrdered";
                }
                case unchecked((int)Spv.Op.OpUnordered):
                {
                    return "OpUnordered";
                }
                case unchecked((int)Spv.Op.OpLogicalEqual):
                {
                    return "OpLogicalEqual";
                }
                case unchecked((int)Spv.Op.OpLogicalNotEqual):
                {
                    return "OpLogicalNotEqual";
                }
                case unchecked((int)Spv.Op.OpLogicalOr):
                {
                    return "OpLogicalOr";
                }
                case unchecked((int)Spv.Op.OpLogicalAnd):
                {
                    return "OpLogicalAnd";
                }
                case unchecked((int)Spv.Op.OpLogicalNot):
                {
                    return "OpLogicalNot";
                }
                case unchecked((int)Spv.Op.OpSelect):
                {
                    return "OpSelect";
                }
                case unchecked((int)Spv.Op.OpIEqual):
                {
                    return "OpIEqual";
                }
                case unchecked((int)Spv.Op.OpINotEqual):
                {
                    return "OpINotEqual";
                }
                case unchecked((int)Spv.Op.OpUGreaterThan):
                {
                    return "OpUGreaterThan";
                }
                case unchecked((int)Spv.Op.OpSGreaterThan):
                {
                    return "OpSGreaterThan";
                }
                case unchecked((int)Spv.Op.OpUGreaterThanEqual):
                {
                    return "OpUGreaterThanEqual";
                }
                case unchecked((int)Spv.Op.OpSGreaterThanEqual):
                {
                    return "OpSGreaterThanEqual";
                }
                case unchecked((int)Spv.Op.OpULessThan):
                {
                    return "OpULessThan";
                }
                case unchecked((int)Spv.Op.OpSLessThan):
                {
                    return "OpSLessThan";
                }
                case unchecked((int)Spv.Op.OpULessThanEqual):
                {
                    return "OpULessThanEqual";
                }
                case unchecked((int)Spv.Op.OpSLessThanEqual):
                {
                    return "OpSLessThanEqual";
                }
                case unchecked((int)Spv.Op.OpFOrdEqual):
                {
                    return "OpFOrdEqual";
                }
                case unchecked((int)Spv.Op.OpFUnordEqual):
                {
                    return "OpFUnordEqual";
                }
                case unchecked((int)Spv.Op.OpFOrdNotEqual):
                {
                    return "OpFOrdNotEqual";
                }
                case unchecked((int)Spv.Op.OpFUnordNotEqual):
                {
                    return "OpFUnordNotEqual";
                }
                case unchecked((int)Spv.Op.OpFOrdLessThan):
                {
                    return "OpFOrdLessThan";
                }
                case unchecked((int)Spv.Op.OpFUnordLessThan):
                {
                    return "OpFUnordLessThan";
                }
                case unchecked((int)Spv.Op.OpFOrdGreaterThan):
                {
                    return "OpFOrdGreaterThan";
                }
                case unchecked((int)Spv.Op.OpFUnordGreaterThan):
                {
                    return "OpFUnordGreaterThan";
                }
                case unchecked((int)Spv.Op.OpFOrdLessThanEqual):
                {
                    return "OpFOrdLessThanEqual";
                }
                case unchecked((int)Spv.Op.OpFUnordLessThanEqual):
                {
                    return "OpFUnordLessThanEqual";
                }
                case unchecked((int)Spv.Op.OpFOrdGreaterThanEqual):
                {
                    return "OpFOrdGreaterThanEqual";
                }
                case unchecked((int)Spv.Op.OpFUnordGreaterThanEqual):
                {
                    return "OpFUnordGreaterThanEqual";
                }
                case unchecked((int)Spv.Op.OpShiftRightLogical):
                {
                    return "OpShiftRightLogical";
                }
                case unchecked((int)Spv.Op.OpShiftRightArithmetic):
                {
                    return "OpShiftRightArithmetic";
                }
                case unchecked((int)Spv.Op.OpShiftLeftLogical):
                {
                    return "OpShiftLeftLogical";
                }
                case unchecked((int)Spv.Op.OpBitwiseOr):
                {
                    return "OpBitwiseOr";
                }
                case unchecked((int)Spv.Op.OpBitwiseXor):
                {
                    return "OpBitwiseXor";
                }
                case unchecked((int)Spv.Op.OpBitwiseAnd):
                {
                    return "OpBitwiseAnd";
                }
                case unchecked((int)Spv.Op.OpNot):
                {
                    return "OpNot";
                }
                case unchecked((int)Spv.Op.OpBitFieldInsert):
                {
                    return "OpBitFieldInsert";
                }
                case unchecked((int)Spv.Op.OpBitFieldSExtract):
                {
                    return "OpBitFieldSExtract";
                }
                case unchecked((int)Spv.Op.OpBitFieldUExtract):
                {
                    return "OpBitFieldUExtract";
                }
                case unchecked((int)Spv.Op.OpBitReverse):
                {
                    return "OpBitReverse";
                }
                case unchecked((int)Spv.Op.OpBitCount):
                {
                    return "OpBitCount";
                }
                case unchecked((int)Spv.Op.OpDPdx):
                {
                    return "OpDPdx";
                }
                case unchecked((int)Spv.Op.OpDPdy):
                {
                    return "OpDPdy";
                }
                case unchecked((int)Spv.Op.OpFwidth):
                {
                    return "OpFwidth";
                }
                case unchecked((int)Spv.Op.OpDPdxFine):
                {
                    return "OpDPdxFine";
                }
                case unchecked((int)Spv.Op.OpDPdyFine):
                {
                    return "OpDPdyFine";
                }
                case unchecked((int)Spv.Op.OpFwidthFine):
                {
                    return "OpFwidthFine";
                }
                case unchecked((int)Spv.Op.OpDPdxCoarse):
                {
                    return "OpDPdxCoarse";
                }
                case unchecked((int)Spv.Op.OpDPdyCoarse):
                {
                    return "OpDPdyCoarse";
                }
                case unchecked((int)Spv.Op.OpFwidthCoarse):
                {
                    return "OpFwidthCoarse";
                }
                case unchecked((int)Spv.Op.OpEmitVertex):
                {
                    return "OpEmitVertex";
                }
                case unchecked((int)Spv.Op.OpEndPrimitive):
                {
                    return "OpEndPrimitive";
                }
                case unchecked((int)Spv.Op.OpEmitStreamVertex):
                {
                    return "OpEmitStreamVertex";
                }
                case unchecked((int)Spv.Op.OpEndStreamPrimitive):
                {
                    return "OpEndStreamPrimitive";
                }
                case unchecked((int)Spv.Op.OpControlBarrier):
                {
                    return "OpControlBarrier";
                }
                case unchecked((int)Spv.Op.OpMemoryBarrier):
                {
                    return "OpMemoryBarrier";
                }
                case unchecked((int)Spv.Op.OpAtomicLoad):
                {
                    return "OpAtomicLoad";
                }
                case unchecked((int)Spv.Op.OpAtomicStore):
                {
                    return "OpAtomicStore";
                }
                case unchecked((int)Spv.Op.OpAtomicExchange):
                {
                    return "OpAtomicExchange";
                }
                case unchecked((int)Spv.Op.OpAtomicCompareExchange):
                {
                    return "OpAtomicCompareExchange";
                }
                case unchecked((int)Spv.Op.OpAtomicCompareExchangeWeak):
                {
                    return "OpAtomicCompareExchangeWeak";
                }
                case unchecked((int)Spv.Op.OpAtomicIIncrement):
                {
                    return "OpAtomicIIncrement";
                }
                case unchecked((int)Spv.Op.OpAtomicIDecrement):
                {
                    return "OpAtomicIDecrement";
                }
                case unchecked((int)Spv.Op.OpAtomicIAdd):
                {
                    return "OpAtomicIAdd";
                }
                case unchecked((int)Spv.Op.OpAtomicISub):
                {
                    return "OpAtomicISub";
                }
                case unchecked((int)Spv.Op.OpAtomicSMin):
                {
                    return "OpAtomicSMin";
                }
                case unchecked((int)Spv.Op.OpAtomicUMin):
                {
                    return "OpAtomicUMin";
                }
                case unchecked((int)Spv.Op.OpAtomicSMax):
                {
                    return "OpAtomicSMax";
                }
                case unchecked((int)Spv.Op.OpAtomicUMax):
                {
                    return "OpAtomicUMax";
                }
                case unchecked((int)Spv.Op.OpAtomicAnd):
                {
                    return "OpAtomicAnd";
                }
                case unchecked((int)Spv.Op.OpAtomicOr):
                {
                    return "OpAtomicOr";
                }
                case unchecked((int)Spv.Op.OpAtomicXor):
                {
                    return "OpAtomicXor";
                }
                case unchecked((int)Spv.Op.OpPhi):
                {
                    return "OpPhi";
                }
                case unchecked((int)Spv.Op.OpLoopMerge):
                {
                    return "OpLoopMerge";
                }
                case unchecked((int)Spv.Op.OpSelectionMerge):
                {
                    return "OpSelectionMerge";
                }
                case unchecked((int)Spv.Op.OpLabel):
                {
                    return "OpLabel";
                }
                case unchecked((int)Spv.Op.OpBranch):
                {
                    return "OpBranch";
                }
                case unchecked((int)Spv.Op.OpBranchConditional):
                {
                    return "OpBranchConditional";
                }
                case unchecked((int)Spv.Op.OpSwitch):
                {
                    return "OpSwitch";
                }
                case unchecked((int)Spv.Op.OpKill):
                {
                    return "OpKill";
                }
                case unchecked((int)Spv.Op.OpReturn):
                {
                    return "OpReturn";
                }
                case unchecked((int)Spv.Op.OpReturnValue):
                {
                    return "OpReturnValue";
                }
                case unchecked((int)Spv.Op.OpUnreachable):
                {
                    return "OpUnreachable";
                }
                case unchecked((int)Spv.Op.OpLifetimeStart):
                {
                    return "OpLifetimeStart";
                }
                case unchecked((int)Spv.Op.OpLifetimeStop):
                {
                    return "OpLifetimeStop";
                }
                case unchecked((int)Spv.Op.OpGroupAsyncCopy):
                {
                    return "OpGroupAsyncCopy";
                }
                case unchecked((int)Spv.Op.OpGroupWaitEvents):
                {
                    return "OpGroupWaitEvents";
                }
                case unchecked((int)Spv.Op.OpGroupAll):
                {
                    return "OpGroupAll";
                }
                case unchecked((int)Spv.Op.OpGroupAny):
                {
                    return "OpGroupAny";
                }
                case unchecked((int)Spv.Op.OpGroupBroadcast):
                {
                    return "OpGroupBroadcast";
                }
                case unchecked((int)Spv.Op.OpGroupIAdd):
                {
                    return "OpGroupIAdd";
                }
                case unchecked((int)Spv.Op.OpGroupFAdd):
                {
                    return "OpGroupFAdd";
                }
                case unchecked((int)Spv.Op.OpGroupFMin):
                {
                    return "OpGroupFMin";
                }
                case unchecked((int)Spv.Op.OpGroupUMin):
                {
                    return "OpGroupUMin";
                }
                case unchecked((int)Spv.Op.OpGroupSMin):
                {
                    return "OpGroupSMin";
                }
                case unchecked((int)Spv.Op.OpGroupFMax):
                {
                    return "OpGroupFMax";
                }
                case unchecked((int)Spv.Op.OpGroupUMax):
                {
                    return "OpGroupUMax";
                }
                case unchecked((int)Spv.Op.OpGroupSMax):
                {
                    return "OpGroupSMax";
                }
                case unchecked((int)Spv.Op.OpReadPipe):
                {
                    return "OpReadPipe";
                }
                case unchecked((int)Spv.Op.OpWritePipe):
                {
                    return "OpWritePipe";
                }
                case unchecked((int)Spv.Op.OpReservedReadPipe):
                {
                    return "OpReservedReadPipe";
                }
                case unchecked((int)Spv.Op.OpReservedWritePipe):
                {
                    return "OpReservedWritePipe";
                }
                case unchecked((int)Spv.Op.OpReserveReadPipePackets):
                {
                    return "OpReserveReadPipePackets";
                }
                case unchecked((int)Spv.Op.OpReserveWritePipePackets):
                {
                    return "OpReserveWritePipePackets";
                }
                case unchecked((int)Spv.Op.OpCommitReadPipe):
                {
                    return "OpCommitReadPipe";
                }
                case unchecked((int)Spv.Op.OpCommitWritePipe):
                {
                    return "OpCommitWritePipe";
                }
                case unchecked((int)Spv.Op.OpIsValidReserveId):
                {
                    return "OpIsValidReserveId";
                }
                case unchecked((int)Spv.Op.OpGetNumPipePackets):
                {
                    return "OpGetNumPipePackets";
                }
                case unchecked((int)Spv.Op.OpGetMaxPipePackets):
                {
                    return "OpGetMaxPipePackets";
                }
                case unchecked((int)Spv.Op.OpGroupReserveReadPipePackets):
                {
                    return "OpGroupReserveReadPipePackets";
                }
                case unchecked((int)Spv.Op.OpGroupReserveWritePipePackets):
                {
                    return "OpGroupReserveWritePipePackets";
                }
                case unchecked((int)Spv.Op.OpGroupCommitReadPipe):
                {
                    return "OpGroupCommitReadPipe";
                }
                case unchecked((int)Spv.Op.OpGroupCommitWritePipe):
                {
                    return "OpGroupCommitWritePipe";
                }
                case unchecked((int)Spv.Op.OpEnqueueMarker):
                {
                    return "OpEnqueueMarker";
                }
                case unchecked((int)Spv.Op.OpEnqueueKernel):
                {
                    return "OpEnqueueKernel";
                }
                case unchecked((int)Spv.Op.OpGetKernelNDrangeSubGroupCount):
                {
                    return "OpGetKernelNDrangeSubGroupCount";
                }
                case unchecked((int)Spv.Op.OpGetKernelNDrangeMaxSubGroupSize):
                {
                    return "OpGetKernelNDrangeMaxSubGroupSize";
                }
                case unchecked((int)Spv.Op.OpGetKernelWorkGroupSize):
                {
                    return "OpGetKernelWorkGroupSize";
                }
                case unchecked((int)Spv.Op.OpGetKernelPreferredWorkGroupSizeMultiple):
                {
                    return "OpGetKernelPreferredWorkGroupSizeMultiple";
                }
                case unchecked((int)Spv.Op.OpRetainEvent):
                {
                    return "OpRetainEvent";
                }
                case unchecked((int)Spv.Op.OpReleaseEvent):
                {
                    return "OpReleaseEvent";
                }
                case unchecked((int)Spv.Op.OpCreateUserEvent):
                {
                    return "OpCreateUserEvent";
                }
                case unchecked((int)Spv.Op.OpIsValidEvent):
                {
                    return "OpIsValidEvent";
                }
                case unchecked((int)Spv.Op.OpSetUserEventStatus):
                {
                    return "OpSetUserEventStatus";
                }
                case unchecked((int)Spv.Op.OpCaptureEventProfilingInfo):
                {
                    return "OpCaptureEventProfilingInfo";
                }
                case unchecked((int)Spv.Op.OpGetDefaultQueue):
                {
                    return "OpGetDefaultQueue";
                }
                case unchecked((int)Spv.Op.OpBuildNDRange):
                {
                    return "OpBuildNDRange";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleImplicitLod):
                {
                    return "OpImageSparseSampleImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleExplicitLod):
                {
                    return "OpImageSparseSampleExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleDrefImplicitLod):
                {
                    return "OpImageSparseSampleDrefImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleDrefExplicitLod):
                {
                    return "OpImageSparseSampleDrefExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjImplicitLod):
                {
                    return "OpImageSparseSampleProjImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjExplicitLod):
                {
                    return "OpImageSparseSampleProjExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefImplicitLod):
                {
                    return "OpImageSparseSampleProjDrefImplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseSampleProjDrefExplicitLod):
                {
                    return "OpImageSparseSampleProjDrefExplicitLod";
                }
                case unchecked((int)Spv.Op.OpImageSparseFetch):
                {
                    return "OpImageSparseFetch";
                }
                case unchecked((int)Spv.Op.OpImageSparseGather):
                {
                    return "OpImageSparseGather";
                }
                case unchecked((int)Spv.Op.OpImageSparseDrefGather):
                {
                    return "OpImageSparseDrefGather";
                }
                case unchecked((int)Spv.Op.OpImageSparseTexelsResident):
                {
                    return "OpImageSparseTexelsResident";
                }
                case unchecked((int)Spv.Op.OpNoLine):
                {
                    return "OpNoLine";
                }
                case unchecked((int)Spv.Op.OpAtomicFlagTestAndSet):
                {
                    return "OpAtomicFlagTestAndSet";
                }
                case unchecked((int)Spv.Op.OpAtomicFlagClear):
                {
                    return "OpAtomicFlagClear";
                }
                case unchecked((int)Spv.Op.OpImageSparseRead):
                {
                    return "OpImageSparseRead";
                }
                case unchecked((int)Spv.Op.OpSizeOf):
                {
                    return "OpSizeOf";
                }
                case unchecked((int)Spv.Op.OpTypePipeStorage):
                {
                    return "OpTypePipeStorage";
                }
                case unchecked((int)Spv.Op.OpConstantPipeStorage):
                {
                    return "OpConstantPipeStorage";
                }
                case unchecked((int)Spv.Op.OpCreatePipeFromPipeStorage):
                {
                    return "OpCreatePipeFromPipeStorage";
                }
                case unchecked((int)Spv.Op.OpGetKernelLocalSizeForSubgroupCount):
                {
                    return "OpGetKernelLocalSizeForSubgroupCount";
                }
                case unchecked((int)Spv.Op.OpGetKernelMaxNumSubgroups):
                {
                    return "OpGetKernelMaxNumSubgroups";
                }
                case unchecked((int)Spv.Op.OpTypeNamedBarrier):
                {
                    return "OpTypeNamedBarrier";
                }
                case unchecked((int)Spv.Op.OpNamedBarrierInitialize):
                {
                    return "OpNamedBarrierInitialize";
                }
                case unchecked((int)Spv.Op.OpMemoryNamedBarrier):
                {
                    return "OpMemoryNamedBarrier";
                }
                case unchecked((int)Spv.Op.OpModuleProcessed):
                {
                    return "OpModuleProcessed";
                }
                case unchecked((int)Spv.Op.OpExecutionModeId):
                {
                    return "OpExecutionModeId";
                }
                case unchecked((int)Spv.Op.OpDecorateId):
                {
                    return "OpDecorateId";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformElect):
                {
                    return "OpGroupNonUniformElect";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAll):
                {
                    return "OpGroupNonUniformAll";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAny):
                {
                    return "OpGroupNonUniformAny";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformAllEqual):
                {
                    return "OpGroupNonUniformAllEqual";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBroadcast):
                {
                    return "OpGroupNonUniformBroadcast";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBroadcastFirst):
                {
                    return "OpGroupNonUniformBroadcastFirst";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallot):
                {
                    return "OpGroupNonUniformBallot";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformInverseBallot):
                {
                    return "OpGroupNonUniformInverseBallot";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitExtract):
                {
                    return "OpGroupNonUniformBallotBitExtract";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotBitCount):
                {
                    return "OpGroupNonUniformBallotBitCount";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindLSB):
                {
                    return "OpGroupNonUniformBallotFindLSB";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBallotFindMSB):
                {
                    return "OpGroupNonUniformBallotFindMSB";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffle):
                {
                    return "OpGroupNonUniformShuffle";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleXor):
                {
                    return "OpGroupNonUniformShuffleXor";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleUp):
                {
                    return "OpGroupNonUniformShuffleUp";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformShuffleDown):
                {
                    return "OpGroupNonUniformShuffleDown";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformIAdd):
                {
                    return "OpGroupNonUniformIAdd";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFAdd):
                {
                    return "OpGroupNonUniformFAdd";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformIMul):
                {
                    return "OpGroupNonUniformIMul";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMul):
                {
                    return "OpGroupNonUniformFMul";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformSMin):
                {
                    return "OpGroupNonUniformSMin";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformUMin):
                {
                    return "OpGroupNonUniformUMin";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMin):
                {
                    return "OpGroupNonUniformFMin";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformSMax):
                {
                    return "OpGroupNonUniformSMax";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformUMax):
                {
                    return "OpGroupNonUniformUMax";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformFMax):
                {
                    return "OpGroupNonUniformFMax";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseAnd):
                {
                    return "OpGroupNonUniformBitwiseAnd";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseOr):
                {
                    return "OpGroupNonUniformBitwiseOr";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformBitwiseXor):
                {
                    return "OpGroupNonUniformBitwiseXor";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalAnd):
                {
                    return "OpGroupNonUniformLogicalAnd";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalOr):
                {
                    return "OpGroupNonUniformLogicalOr";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformLogicalXor):
                {
                    return "OpGroupNonUniformLogicalXor";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadBroadcast):
                {
                    return "OpGroupNonUniformQuadBroadcast";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadSwap):
                {
                    return "OpGroupNonUniformQuadSwap";
                }
                case unchecked((int)Spv.Op.OpCopyLogical):
                {
                    return "OpCopyLogical";
                }
                case unchecked((int)Spv.Op.OpPtrEqual):
                {
                    return "OpPtrEqual";
                }
                case unchecked((int)Spv.Op.OpPtrNotEqual):
                {
                    return "OpPtrNotEqual";
                }
                case unchecked((int)Spv.Op.OpPtrDiff):
                {
                    return "OpPtrDiff";
                }
                case unchecked((int)Spv.Op.OpColorAttachmentReadEXT):
                {
                    return "OpColorAttachmentReadEXT";
                }
                case unchecked((int)Spv.Op.OpDepthAttachmentReadEXT):
                {
                    return "OpDepthAttachmentReadEXT";
                }
                case unchecked((int)Spv.Op.OpStencilAttachmentReadEXT):
                {
                    return "OpStencilAttachmentReadEXT";
                }
                case unchecked((int)Spv.Op.OpTypeTensorARM):
                {
                    return "OpTypeTensorARM";
                }
                case unchecked((int)Spv.Op.OpTensorReadARM):
                {
                    return "OpTensorReadARM";
                }
                case unchecked((int)Spv.Op.OpTensorWriteARM):
                {
                    return "OpTensorWriteARM";
                }
                case unchecked((int)Spv.Op.OpTensorQuerySizeARM):
                {
                    return "OpTensorQuerySizeARM";
                }
                case unchecked((int)Spv.Op.OpGraphConstantARM):
                {
                    return "OpGraphConstantARM";
                }
                case unchecked((int)Spv.Op.OpGraphEntryPointARM):
                {
                    return "OpGraphEntryPointARM";
                }
                case unchecked((int)Spv.Op.OpGraphARM):
                {
                    return "OpGraphARM";
                }
                case unchecked((int)Spv.Op.OpGraphInputARM):
                {
                    return "OpGraphInputARM";
                }
                case unchecked((int)Spv.Op.OpGraphSetOutputARM):
                {
                    return "OpGraphSetOutputARM";
                }
                case unchecked((int)Spv.Op.OpGraphEndARM):
                {
                    return "OpGraphEndARM";
                }
                case unchecked((int)Spv.Op.OpTypeGraphARM):
                {
                    return "OpTypeGraphARM";
                }
                case unchecked((int)Spv.Op.OpTerminateInvocation):
                {
                    return "OpTerminateInvocation";
                }
                case unchecked((int)Spv.Op.OpTypeUntypedPointerKHR):
                {
                    return "OpTypeUntypedPointerKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedVariableKHR):
                {
                    return "OpUntypedVariableKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedAccessChainKHR):
                {
                    return "OpUntypedAccessChainKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedInBoundsAccessChainKHR):
                {
                    return "OpUntypedInBoundsAccessChainKHR";
                }
                case unchecked((int)Spv.Op.OpSubgroupBallotKHR):
                {
                    return "OpSubgroupBallotKHR";
                }
                case unchecked((int)Spv.Op.OpSubgroupFirstInvocationKHR):
                {
                    return "OpSubgroupFirstInvocationKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedPtrAccessChainKHR):
                {
                    return "OpUntypedPtrAccessChainKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedInBoundsPtrAccessChainKHR):
                {
                    return "OpUntypedInBoundsPtrAccessChainKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedArrayLengthKHR):
                {
                    return "OpUntypedArrayLengthKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedPrefetchKHR):
                {
                    return "OpUntypedPrefetchKHR";
                }
                case unchecked((int)Spv.Op.OpFmaKHR):
                {
                    return "OpFmaKHR";
                }
                case unchecked((int)Spv.Op.OpSubgroupAllKHR):
                {
                    return "OpSubgroupAllKHR";
                }
                case unchecked((int)Spv.Op.OpSubgroupAnyKHR):
                {
                    return "OpSubgroupAnyKHR";
                }
                case unchecked((int)Spv.Op.OpSubgroupAllEqualKHR):
                {
                    return "OpSubgroupAllEqualKHR";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformRotateKHR):
                {
                    return "OpGroupNonUniformRotateKHR";
                }
                case unchecked((int)Spv.Op.OpSubgroupReadInvocationKHR):
                {
                    return "OpSubgroupReadInvocationKHR";
                }
                case unchecked((int)Spv.Op.OpExtInstWithForwardRefsKHR):
                {
                    return "OpExtInstWithForwardRefsKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedGroupAsyncCopyKHR):
                {
                    return "OpUntypedGroupAsyncCopyKHR";
                }
                case unchecked((int)Spv.Op.OpTraceRayKHR):
                {
                    return "OpTraceRayKHR";
                }
                case unchecked((int)Spv.Op.OpExecuteCallableKHR):
                {
                    return "OpExecuteCallableKHR";
                }
                case unchecked((int)Spv.Op.OpConvertUToAccelerationStructureKHR):
                {
                    return "OpConvertUToAccelerationStructureKHR";
                }
                case unchecked((int)Spv.Op.OpIgnoreIntersectionKHR):
                {
                    return "OpIgnoreIntersectionKHR";
                }
                case unchecked((int)Spv.Op.OpTerminateRayKHR):
                {
                    return "OpTerminateRayKHR";
                }
                case unchecked((int)Spv.Op.OpSDot):
                {
                    return "OpSDot";
                }
                case unchecked((int)Spv.Op.OpUDot):
                {
                    return "OpUDot";
                }
                case unchecked((int)Spv.Op.OpSUDot):
                {
                    return "OpSUDot";
                }
                case unchecked((int)Spv.Op.OpSDotAccSat):
                {
                    return "OpSDotAccSat";
                }
                case unchecked((int)Spv.Op.OpUDotAccSat):
                {
                    return "OpUDotAccSat";
                }
                case unchecked((int)Spv.Op.OpSUDotAccSat):
                {
                    return "OpSUDotAccSat";
                }
                case unchecked((int)Spv.Op.OpTypeCooperativeMatrixKHR):
                {
                    return "OpTypeCooperativeMatrixKHR";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLoadKHR):
                {
                    return "OpCooperativeMatrixLoadKHR";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixStoreKHR):
                {
                    return "OpCooperativeMatrixStoreKHR";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixMulAddKHR):
                {
                    return "OpCooperativeMatrixMulAddKHR";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLengthKHR):
                {
                    return "OpCooperativeMatrixLengthKHR";
                }
                case unchecked((int)Spv.Op.OpConstantCompositeReplicateEXT):
                {
                    return "OpConstantCompositeReplicateEXT";
                }
                case unchecked((int)Spv.Op.OpSpecConstantCompositeReplicateEXT):
                {
                    return "OpSpecConstantCompositeReplicateEXT";
                }
                case unchecked((int)Spv.Op.OpCompositeConstructReplicateEXT):
                {
                    return "OpCompositeConstructReplicateEXT";
                }
                case unchecked((int)Spv.Op.OpTypeRayQueryKHR):
                {
                    return "OpTypeRayQueryKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryInitializeKHR):
                {
                    return "OpRayQueryInitializeKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryTerminateKHR):
                {
                    return "OpRayQueryTerminateKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGenerateIntersectionKHR):
                {
                    return "OpRayQueryGenerateIntersectionKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryConfirmIntersectionKHR):
                {
                    return "OpRayQueryConfirmIntersectionKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryProceedKHR):
                {
                    return "OpRayQueryProceedKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTypeKHR):
                {
                    return "OpRayQueryGetIntersectionTypeKHR";
                }
                case unchecked((int)Spv.Op.OpImageSampleWeightedQCOM):
                {
                    return "OpImageSampleWeightedQCOM";
                }
                case unchecked((int)Spv.Op.OpImageBoxFilterQCOM):
                {
                    return "OpImageBoxFilterQCOM";
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchSSDQCOM):
                {
                    return "OpImageBlockMatchSSDQCOM";
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchSADQCOM):
                {
                    return "OpImageBlockMatchSADQCOM";
                }
                case unchecked((int)Spv.Op.OpBitCastArrayQCOM):
                {
                    return "OpBitCastArrayQCOM";
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchWindowSSDQCOM):
                {
                    return "OpImageBlockMatchWindowSSDQCOM";
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchWindowSADQCOM):
                {
                    return "OpImageBlockMatchWindowSADQCOM";
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchGatherSSDQCOM):
                {
                    return "OpImageBlockMatchGatherSSDQCOM";
                }
                case unchecked((int)Spv.Op.OpImageBlockMatchGatherSADQCOM):
                {
                    return "OpImageBlockMatchGatherSADQCOM";
                }
                case unchecked((int)Spv.Op.OpCompositeConstructCoopMatQCOM):
                {
                    return "OpCompositeConstructCoopMatQCOM";
                }
                case unchecked((int)Spv.Op.OpCompositeExtractCoopMatQCOM):
                {
                    return "OpCompositeExtractCoopMatQCOM";
                }
                case unchecked((int)Spv.Op.OpExtractSubArrayQCOM):
                {
                    return "OpExtractSubArrayQCOM";
                }
                case unchecked((int)Spv.Op.OpGroupIAddNonUniformAMD):
                {
                    return "OpGroupIAddNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpGroupFAddNonUniformAMD):
                {
                    return "OpGroupFAddNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpGroupFMinNonUniformAMD):
                {
                    return "OpGroupFMinNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpGroupUMinNonUniformAMD):
                {
                    return "OpGroupUMinNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpGroupSMinNonUniformAMD):
                {
                    return "OpGroupSMinNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpGroupFMaxNonUniformAMD):
                {
                    return "OpGroupFMaxNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpGroupUMaxNonUniformAMD):
                {
                    return "OpGroupUMaxNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpGroupSMaxNonUniformAMD):
                {
                    return "OpGroupSMaxNonUniformAMD";
                }
                case unchecked((int)Spv.Op.OpFragmentMaskFetchAMD):
                {
                    return "OpFragmentMaskFetchAMD";
                }
                case unchecked((int)Spv.Op.OpFragmentFetchAMD):
                {
                    return "OpFragmentFetchAMD";
                }
                case unchecked((int)Spv.Op.OpReadClockKHR):
                {
                    return "OpReadClockKHR";
                }
                case unchecked((int)Spv.Op.OpAllocateNodePayloadsAMDX):
                {
                    return "OpAllocateNodePayloadsAMDX";
                }
                case unchecked((int)Spv.Op.OpEnqueueNodePayloadsAMDX):
                {
                    return "OpEnqueueNodePayloadsAMDX";
                }
                case unchecked((int)Spv.Op.OpTypeNodePayloadArrayAMDX):
                {
                    return "OpTypeNodePayloadArrayAMDX";
                }
                case unchecked((int)Spv.Op.OpFinishWritingNodePayloadAMDX):
                {
                    return "OpFinishWritingNodePayloadAMDX";
                }
                case unchecked((int)Spv.Op.OpNodePayloadArrayLengthAMDX):
                {
                    return "OpNodePayloadArrayLengthAMDX";
                }
                case unchecked((int)Spv.Op.OpIsNodePayloadValidAMDX):
                {
                    return "OpIsNodePayloadValidAMDX";
                }
                case unchecked((int)Spv.Op.OpConstantStringAMDX):
                {
                    return "OpConstantStringAMDX";
                }
                case unchecked((int)Spv.Op.OpSpecConstantStringAMDX):
                {
                    return "OpSpecConstantStringAMDX";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadAllKHR):
                {
                    return "OpGroupNonUniformQuadAllKHR";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformQuadAnyKHR):
                {
                    return "OpGroupNonUniformQuadAnyKHR";
                }
                case unchecked((int)Spv.Op.OpTypeBufferEXT):
                {
                    return "OpTypeBufferEXT";
                }
                case unchecked((int)Spv.Op.OpBufferPointerEXT):
                {
                    return "OpBufferPointerEXT";
                }
                case unchecked((int)Spv.Op.OpAbortKHR):
                {
                    return "OpAbortKHR";
                }
                case unchecked((int)Spv.Op.OpUntypedImageTexelPointerEXT):
                {
                    return "OpUntypedImageTexelPointerEXT";
                }
                case unchecked((int)Spv.Op.OpMemberDecorateIdEXT):
                {
                    return "OpMemberDecorateIdEXT";
                }
                case unchecked((int)Spv.Op.OpConstantSizeOfEXT):
                {
                    return "OpConstantSizeOfEXT";
                }
                case unchecked((int)Spv.Op.OpConstantDataKHR):
                {
                    return "OpConstantDataKHR";
                }
                case unchecked((int)Spv.Op.OpSpecConstantDataKHR):
                {
                    return "OpSpecConstantDataKHR";
                }
                case unchecked((int)Spv.Op.OpPoisonKHR):
                {
                    return "OpPoisonKHR";
                }
                case unchecked((int)Spv.Op.OpFreezeKHR):
                {
                    return "OpFreezeKHR";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitMotionNV):
                {
                    return "OpHitObjectRecordHitMotionNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitWithIndexMotionNV):
                {
                    return "OpHitObjectRecordHitWithIndexMotionNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissMotionNV):
                {
                    return "OpHitObjectRecordMissMotionNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldToObjectNV):
                {
                    return "OpHitObjectGetWorldToObjectNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectToWorldNV):
                {
                    return "OpHitObjectGetObjectToWorldNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayDirectionNV):
                {
                    return "OpHitObjectGetObjectRayDirectionNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayOriginNV):
                {
                    return "OpHitObjectGetObjectRayOriginNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayMotionNV):
                {
                    return "OpHitObjectTraceRayMotionNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderRecordBufferHandleNV):
                {
                    return "OpHitObjectGetShaderRecordBufferHandleNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderBindingTableRecordIndexNV):
                {
                    return "OpHitObjectGetShaderBindingTableRecordIndexNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordEmptyNV):
                {
                    return "OpHitObjectRecordEmptyNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayNV):
                {
                    return "OpHitObjectTraceRayNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitNV):
                {
                    return "OpHitObjectRecordHitNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordHitWithIndexNV):
                {
                    return "OpHitObjectRecordHitWithIndexNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissNV):
                {
                    return "OpHitObjectRecordMissNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectExecuteShaderNV):
                {
                    return "OpHitObjectExecuteShaderNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetCurrentTimeNV):
                {
                    return "OpHitObjectGetCurrentTimeNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetAttributesNV):
                {
                    return "OpHitObjectGetAttributesNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetHitKindNV):
                {
                    return "OpHitObjectGetHitKindNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetPrimitiveIndexNV):
                {
                    return "OpHitObjectGetPrimitiveIndexNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetGeometryIndexNV):
                {
                    return "OpHitObjectGetGeometryIndexNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceIdNV):
                {
                    return "OpHitObjectGetInstanceIdNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceCustomIndexNV):
                {
                    return "OpHitObjectGetInstanceCustomIndexNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayDirectionNV):
                {
                    return "OpHitObjectGetWorldRayDirectionNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayOriginNV):
                {
                    return "OpHitObjectGetWorldRayOriginNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMaxNV):
                {
                    return "OpHitObjectGetRayTMaxNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMinNV):
                {
                    return "OpHitObjectGetRayTMinNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsEmptyNV):
                {
                    return "OpHitObjectIsEmptyNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsHitNV):
                {
                    return "OpHitObjectIsHitNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsMissNV):
                {
                    return "OpHitObjectIsMissNV";
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHitObjectNV):
                {
                    return "OpReorderThreadWithHitObjectNV";
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHintNV):
                {
                    return "OpReorderThreadWithHintNV";
                }
                case unchecked((int)Spv.Op.OpTypeHitObjectNV):
                {
                    return "OpTypeHitObjectNV";
                }
                case unchecked((int)Spv.Op.OpImageSampleFootprintNV):
                {
                    return "OpImageSampleFootprintNV";
                }
                case unchecked((int)Spv.Op.OpTypeCooperativeVectorNV):
                {
                    return "OpTypeCooperativeVectorNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorMatrixMulNV):
                {
                    return "OpCooperativeVectorMatrixMulNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorOuterProductAccumulateNV):
                {
                    return "OpCooperativeVectorOuterProductAccumulateNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorReduceSumAccumulateNV):
                {
                    return "OpCooperativeVectorReduceSumAccumulateNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorMatrixMulAddNV):
                {
                    return "OpCooperativeVectorMatrixMulAddNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixConvertNV):
                {
                    return "OpCooperativeMatrixConvertNV";
                }
                case unchecked((int)Spv.Op.OpEmitMeshTasksEXT):
                {
                    return "OpEmitMeshTasksEXT";
                }
                case unchecked((int)Spv.Op.OpSetMeshOutputsEXT):
                {
                    return "OpSetMeshOutputsEXT";
                }
                case unchecked((int)Spv.Op.OpGroupNonUniformPartitionEXT):
                {
                    return "OpGroupNonUniformPartitionEXT";
                }
                case unchecked((int)Spv.Op.OpWritePackedPrimitiveIndices4x8NV):
                {
                    return "OpWritePackedPrimitiveIndices4x8NV";
                }
                case unchecked((int)Spv.Op.OpFetchMicroTriangleVertexPositionNV):
                {
                    return "OpFetchMicroTriangleVertexPositionNV";
                }
                case unchecked((int)Spv.Op.OpFetchMicroTriangleVertexBarycentricNV):
                {
                    return "OpFetchMicroTriangleVertexBarycentricNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorLoadNV):
                {
                    return "OpCooperativeVectorLoadNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeVectorStoreNV):
                {
                    return "OpCooperativeVectorStoreNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordFromQueryEXT):
                {
                    return "OpHitObjectRecordFromQueryEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissEXT):
                {
                    return "OpHitObjectRecordMissEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordMissMotionEXT):
                {
                    return "OpHitObjectRecordMissMotionEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetIntersectionTriangleVertexPositionsEXT):
                {
                    return "OpHitObjectGetIntersectionTriangleVertexPositionsEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayFlagsEXT):
                {
                    return "OpHitObjectGetRayFlagsEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectSetShaderBindingTableRecordIndexEXT):
                {
                    return "OpHitObjectSetShaderBindingTableRecordIndexEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectReorderExecuteShaderEXT):
                {
                    return "OpHitObjectReorderExecuteShaderEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceReorderExecuteEXT):
                {
                    return "OpHitObjectTraceReorderExecuteEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceMotionReorderExecuteEXT):
                {
                    return "OpHitObjectTraceMotionReorderExecuteEXT";
                }
                case unchecked((int)Spv.Op.OpTypeHitObjectEXT):
                {
                    return "OpTypeHitObjectEXT";
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHintEXT):
                {
                    return "OpReorderThreadWithHintEXT";
                }
                case unchecked((int)Spv.Op.OpReorderThreadWithHitObjectEXT):
                {
                    return "OpReorderThreadWithHitObjectEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayEXT):
                {
                    return "OpHitObjectTraceRayEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectTraceRayMotionEXT):
                {
                    return "OpHitObjectTraceRayMotionEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectRecordEmptyEXT):
                {
                    return "OpHitObjectRecordEmptyEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectExecuteShaderEXT):
                {
                    return "OpHitObjectExecuteShaderEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetCurrentTimeEXT):
                {
                    return "OpHitObjectGetCurrentTimeEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetAttributesEXT):
                {
                    return "OpHitObjectGetAttributesEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetHitKindEXT):
                {
                    return "OpHitObjectGetHitKindEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetPrimitiveIndexEXT):
                {
                    return "OpHitObjectGetPrimitiveIndexEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetGeometryIndexEXT):
                {
                    return "OpHitObjectGetGeometryIndexEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceIdEXT):
                {
                    return "OpHitObjectGetInstanceIdEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetInstanceCustomIndexEXT):
                {
                    return "OpHitObjectGetInstanceCustomIndexEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayOriginEXT):
                {
                    return "OpHitObjectGetObjectRayOriginEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectRayDirectionEXT):
                {
                    return "OpHitObjectGetObjectRayDirectionEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayDirectionEXT):
                {
                    return "OpHitObjectGetWorldRayDirectionEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldRayOriginEXT):
                {
                    return "OpHitObjectGetWorldRayOriginEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetObjectToWorldEXT):
                {
                    return "OpHitObjectGetObjectToWorldEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetWorldToObjectEXT):
                {
                    return "OpHitObjectGetWorldToObjectEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMaxEXT):
                {
                    return "OpHitObjectGetRayTMaxEXT";
                }
                case unchecked((int)Spv.Op.OpReportIntersectionKHR):
                {
                    return "OpReportIntersectionKHR";
                }
                case unchecked((int)Spv.Op.OpIgnoreIntersectionNV):
                {
                    return "OpIgnoreIntersectionNV";
                }
                case unchecked((int)Spv.Op.OpTerminateRayNV):
                {
                    return "OpTerminateRayNV";
                }
                case unchecked((int)Spv.Op.OpTraceNV):
                {
                    return "OpTraceNV";
                }
                case unchecked((int)Spv.Op.OpTraceMotionNV):
                {
                    return "OpTraceMotionNV";
                }
                case unchecked((int)Spv.Op.OpTraceRayMotionNV):
                {
                    return "OpTraceRayMotionNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTriangleVertexPositionsKHR):
                {
                    return "OpRayQueryGetIntersectionTriangleVertexPositionsKHR";
                }
                case unchecked((int)Spv.Op.OpTypeAccelerationStructureKHR):
                {
                    return "OpTypeAccelerationStructureKHR";
                }
                case unchecked((int)Spv.Op.OpExecuteCallableNV):
                {
                    return "OpExecuteCallableNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetClusterIdNV):
                {
                    return "OpRayQueryGetClusterIdNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetClusterIdNV):
                {
                    return "OpHitObjectGetClusterIdNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetRayTMinEXT):
                {
                    return "OpHitObjectGetRayTMinEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderBindingTableRecordIndexEXT):
                {
                    return "OpHitObjectGetShaderBindingTableRecordIndexEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetShaderRecordBufferHandleEXT):
                {
                    return "OpHitObjectGetShaderRecordBufferHandleEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsEmptyEXT):
                {
                    return "OpHitObjectIsEmptyEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsHitEXT):
                {
                    return "OpHitObjectIsHitEXT";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsMissEXT):
                {
                    return "OpHitObjectIsMissEXT";
                }
                case unchecked((int)Spv.Op.OpTypeCooperativeMatrixNV):
                {
                    return "OpTypeCooperativeMatrixNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLoadNV):
                {
                    return "OpCooperativeMatrixLoadNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixStoreNV):
                {
                    return "OpCooperativeMatrixStoreNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixMulAddNV):
                {
                    return "OpCooperativeMatrixMulAddNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLengthNV):
                {
                    return "OpCooperativeMatrixLengthNV";
                }
                case unchecked((int)Spv.Op.OpBeginInvocationInterlockEXT):
                {
                    return "OpBeginInvocationInterlockEXT";
                }
                case unchecked((int)Spv.Op.OpEndInvocationInterlockEXT):
                {
                    return "OpEndInvocationInterlockEXT";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixReduceNV):
                {
                    return "OpCooperativeMatrixReduceNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixLoadTensorNV):
                {
                    return "OpCooperativeMatrixLoadTensorNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixStoreTensorNV):
                {
                    return "OpCooperativeMatrixStoreTensorNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixPerElementOpNV):
                {
                    return "OpCooperativeMatrixPerElementOpNV";
                }
                case unchecked((int)Spv.Op.OpTypeTensorLayoutNV):
                {
                    return "OpTypeTensorLayoutNV";
                }
                case unchecked((int)Spv.Op.OpTypeTensorViewNV):
                {
                    return "OpTypeTensorViewNV";
                }
                case unchecked((int)Spv.Op.OpCreateTensorLayoutNV):
                {
                    return "OpCreateTensorLayoutNV";
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetDimensionNV):
                {
                    return "OpTensorLayoutSetDimensionNV";
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetStrideNV):
                {
                    return "OpTensorLayoutSetStrideNV";
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSliceNV):
                {
                    return "OpTensorLayoutSliceNV";
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetClampValueNV):
                {
                    return "OpTensorLayoutSetClampValueNV";
                }
                case unchecked((int)Spv.Op.OpCreateTensorViewNV):
                {
                    return "OpCreateTensorViewNV";
                }
                case unchecked((int)Spv.Op.OpTensorViewSetDimensionNV):
                {
                    return "OpTensorViewSetDimensionNV";
                }
                case unchecked((int)Spv.Op.OpTensorViewSetStrideNV):
                {
                    return "OpTensorViewSetStrideNV";
                }
                case unchecked((int)Spv.Op.OpDemoteToHelperInvocation):
                {
                    return "OpDemoteToHelperInvocation";
                }
                case unchecked((int)Spv.Op.OpIsHelperInvocationEXT):
                {
                    return "OpIsHelperInvocationEXT";
                }
                case unchecked((int)Spv.Op.OpTensorViewSetClipNV):
                {
                    return "OpTensorViewSetClipNV";
                }
                case unchecked((int)Spv.Op.OpTensorLayoutSetBlockSizeNV):
                {
                    return "OpTensorLayoutSetBlockSizeNV";
                }
                case unchecked((int)Spv.Op.OpCooperativeMatrixTransposeNV):
                {
                    return "OpCooperativeMatrixTransposeNV";
                }
                case unchecked((int)Spv.Op.OpConvertUToImageNV):
                {
                    return "OpConvertUToImageNV";
                }
                case unchecked((int)Spv.Op.OpConvertUToSamplerNV):
                {
                    return "OpConvertUToSamplerNV";
                }
                case unchecked((int)Spv.Op.OpConvertImageToUNV):
                {
                    return "OpConvertImageToUNV";
                }
                case unchecked((int)Spv.Op.OpConvertSamplerToUNV):
                {
                    return "OpConvertSamplerToUNV";
                }
                case unchecked((int)Spv.Op.OpConvertUToSampledImageNV):
                {
                    return "OpConvertUToSampledImageNV";
                }
                case unchecked((int)Spv.Op.OpConvertSampledImageToUNV):
                {
                    return "OpConvertSampledImageToUNV";
                }
                case unchecked((int)Spv.Op.OpSamplerImageAddressingModeNV):
                {
                    return "OpSamplerImageAddressingModeNV";
                }
                case unchecked((int)Spv.Op.OpRawAccessChainNV):
                {
                    return "OpRawAccessChainNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionSpherePositionNV):
                {
                    return "OpRayQueryGetIntersectionSpherePositionNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionSphereRadiusNV):
                {
                    return "OpRayQueryGetIntersectionSphereRadiusNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionLSSPositionsNV):
                {
                    return "OpRayQueryGetIntersectionLSSPositionsNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionLSSRadiiNV):
                {
                    return "OpRayQueryGetIntersectionLSSRadiiNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionLSSHitValueNV):
                {
                    return "OpRayQueryGetIntersectionLSSHitValueNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetSpherePositionNV):
                {
                    return "OpHitObjectGetSpherePositionNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetSphereRadiusNV):
                {
                    return "OpHitObjectGetSphereRadiusNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetLSSPositionsNV):
                {
                    return "OpHitObjectGetLSSPositionsNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectGetLSSRadiiNV):
                {
                    return "OpHitObjectGetLSSRadiiNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsSphereHitNV):
                {
                    return "OpHitObjectIsSphereHitNV";
                }
                case unchecked((int)Spv.Op.OpHitObjectIsLSSHitNV):
                {
                    return "OpHitObjectIsLSSHitNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryIsSphereHitNV):
                {
                    return "OpRayQueryIsSphereHitNV";
                }
                case unchecked((int)Spv.Op.OpRayQueryIsLSSHitNV):
                {
                    return "OpRayQueryIsLSSHitNV";
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleINTEL):
                {
                    return "OpSubgroupShuffleINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleDownINTEL):
                {
                    return "OpSubgroupShuffleDownINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleUpINTEL):
                {
                    return "OpSubgroupShuffleUpINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupShuffleXorINTEL):
                {
                    return "OpSubgroupShuffleXorINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupBlockReadINTEL):
                {
                    return "OpSubgroupBlockReadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupBlockWriteINTEL):
                {
                    return "OpSubgroupBlockWriteINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupImageBlockReadINTEL):
                {
                    return "OpSubgroupImageBlockReadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupImageBlockWriteINTEL):
                {
                    return "OpSubgroupImageBlockWriteINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupImageMediaBlockReadINTEL):
                {
                    return "OpSubgroupImageMediaBlockReadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupImageMediaBlockWriteINTEL):
                {
                    return "OpSubgroupImageMediaBlockWriteINTEL";
                }
                case unchecked((int)Spv.Op.OpUCountLeadingZerosINTEL):
                {
                    return "OpUCountLeadingZerosINTEL";
                }
                case unchecked((int)Spv.Op.OpUCountTrailingZerosINTEL):
                {
                    return "OpUCountTrailingZerosINTEL";
                }
                case unchecked((int)Spv.Op.OpAbsISubINTEL):
                {
                    return "OpAbsISubINTEL";
                }
                case unchecked((int)Spv.Op.OpAbsUSubINTEL):
                {
                    return "OpAbsUSubINTEL";
                }
                case unchecked((int)Spv.Op.OpIAddSatINTEL):
                {
                    return "OpIAddSatINTEL";
                }
                case unchecked((int)Spv.Op.OpUAddSatINTEL):
                {
                    return "OpUAddSatINTEL";
                }
                case unchecked((int)Spv.Op.OpIAverageINTEL):
                {
                    return "OpIAverageINTEL";
                }
                case unchecked((int)Spv.Op.OpUAverageINTEL):
                {
                    return "OpUAverageINTEL";
                }
                case unchecked((int)Spv.Op.OpIAverageRoundedINTEL):
                {
                    return "OpIAverageRoundedINTEL";
                }
                case unchecked((int)Spv.Op.OpUAverageRoundedINTEL):
                {
                    return "OpUAverageRoundedINTEL";
                }
                case unchecked((int)Spv.Op.OpISubSatINTEL):
                {
                    return "OpISubSatINTEL";
                }
                case unchecked((int)Spv.Op.OpUSubSatINTEL):
                {
                    return "OpUSubSatINTEL";
                }
                case unchecked((int)Spv.Op.OpIMul32x16INTEL):
                {
                    return "OpIMul32x16INTEL";
                }
                case unchecked((int)Spv.Op.OpUMul32x16INTEL):
                {
                    return "OpUMul32x16INTEL";
                }
                case unchecked((int)Spv.Op.OpConstantFunctionPointerINTEL):
                {
                    return "OpConstantFunctionPointerINTEL";
                }
                case unchecked((int)Spv.Op.OpFunctionPointerCallINTEL):
                {
                    return "OpFunctionPointerCallINTEL";
                }
                case unchecked((int)Spv.Op.OpAsmTargetINTEL):
                {
                    return "OpAsmTargetINTEL";
                }
                case unchecked((int)Spv.Op.OpAsmINTEL):
                {
                    return "OpAsmINTEL";
                }
                case unchecked((int)Spv.Op.OpAsmCallINTEL):
                {
                    return "OpAsmCallINTEL";
                }
                case unchecked((int)Spv.Op.OpAtomicFMinEXT):
                {
                    return "OpAtomicFMinEXT";
                }
                case unchecked((int)Spv.Op.OpAtomicFMaxEXT):
                {
                    return "OpAtomicFMaxEXT";
                }
                case unchecked((int)Spv.Op.OpAssumeTrueKHR):
                {
                    return "OpAssumeTrueKHR";
                }
                case unchecked((int)Spv.Op.OpExpectKHR):
                {
                    return "OpExpectKHR";
                }
                case unchecked((int)Spv.Op.OpDecorateString):
                {
                    return "OpDecorateString";
                }
                case unchecked((int)Spv.Op.OpMemberDecorateString):
                {
                    return "OpMemberDecorateString";
                }
                case unchecked((int)Spv.Op.OpVmeImageINTEL):
                {
                    return "OpVmeImageINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeVmeImageINTEL):
                {
                    return "OpTypeVmeImageINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcImePayloadINTEL):
                {
                    return "OpTypeAvcImePayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcRefPayloadINTEL):
                {
                    return "OpTypeAvcRefPayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcSicPayloadINTEL):
                {
                    return "OpTypeAvcSicPayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcMcePayloadINTEL):
                {
                    return "OpTypeAvcMcePayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcMceResultINTEL):
                {
                    return "OpTypeAvcMceResultINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeResultINTEL):
                {
                    return "OpTypeAvcImeResultINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeResultSingleReferenceStreamoutINTEL):
                {
                    return "OpTypeAvcImeResultSingleReferenceStreamoutINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeResultDualReferenceStreamoutINTEL):
                {
                    return "OpTypeAvcImeResultDualReferenceStreamoutINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeSingleReferenceStreaminINTEL):
                {
                    return "OpTypeAvcImeSingleReferenceStreaminINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcImeDualReferenceStreaminINTEL):
                {
                    return "OpTypeAvcImeDualReferenceStreaminINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcRefResultINTEL):
                {
                    return "OpTypeAvcRefResultINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeAvcSicResultINTEL):
                {
                    return "OpTypeAvcSicResultINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultInterBaseMultiReferencePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL):
                {
                    return "OpSubgroupAvcMceSetInterBaseMultiReferencePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultInterShapePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetInterShapePenaltyINTEL):
                {
                    return "OpSubgroupAvcMceSetInterShapePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultInterDirectionPenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetInterDirectionPenaltyINTEL):
                {
                    return "OpSubgroupAvcMceSetInterDirectionPenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultIntraLumaShapePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultInterMotionVectorCostTableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultHighPenaltyCostTableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultMediumPenaltyCostTableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultLowPenaltyCostTableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL):
                {
                    return "OpSubgroupAvcMceSetMotionVectorCostFunctionINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultIntraLumaModePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultNonDcLumaIntraPenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL):
                {
                    return "OpSubgroupAvcMceGetDefaultIntraChromaModeBasePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetAcOnlyHaarINTEL):
                {
                    return "OpSubgroupAvcMceSetAcOnlyHaarINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL):
                {
                    return "OpSubgroupAvcMceSetSourceInterlacedFieldPolarityINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL):
                {
                    return "OpSubgroupAvcMceSetSingleReferenceInterlacedFieldPolarityINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL):
                {
                    return "OpSubgroupAvcMceSetDualReferenceInterlacedFieldPolaritiesINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToImePayloadINTEL):
                {
                    return "OpSubgroupAvcMceConvertToImePayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToImeResultINTEL):
                {
                    return "OpSubgroupAvcMceConvertToImeResultINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToRefPayloadINTEL):
                {
                    return "OpSubgroupAvcMceConvertToRefPayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToRefResultINTEL):
                {
                    return "OpSubgroupAvcMceConvertToRefResultINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToSicPayloadINTEL):
                {
                    return "OpSubgroupAvcMceConvertToSicPayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceConvertToSicResultINTEL):
                {
                    return "OpSubgroupAvcMceConvertToSicResultINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetMotionVectorsINTEL):
                {
                    return "OpSubgroupAvcMceGetMotionVectorsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterDistortionsINTEL):
                {
                    return "OpSubgroupAvcMceGetInterDistortionsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetBestInterDistortionsINTEL):
                {
                    return "OpSubgroupAvcMceGetBestInterDistortionsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterMajorShapeINTEL):
                {
                    return "OpSubgroupAvcMceGetInterMajorShapeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterMinorShapeINTEL):
                {
                    return "OpSubgroupAvcMceGetInterMinorShapeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterDirectionsINTEL):
                {
                    return "OpSubgroupAvcMceGetInterDirectionsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterMotionVectorCountINTEL):
                {
                    return "OpSubgroupAvcMceGetInterMotionVectorCountINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterReferenceIdsINTEL):
                {
                    return "OpSubgroupAvcMceGetInterReferenceIdsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL):
                {
                    return "OpSubgroupAvcMceGetInterReferenceInterlacedFieldPolaritiesINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeInitializeINTEL):
                {
                    return "OpSubgroupAvcImeInitializeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetSingleReferenceINTEL):
                {
                    return "OpSubgroupAvcImeSetSingleReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetDualReferenceINTEL):
                {
                    return "OpSubgroupAvcImeSetDualReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeRefWindowSizeINTEL):
                {
                    return "OpSubgroupAvcImeRefWindowSizeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeAdjustRefOffsetINTEL):
                {
                    return "OpSubgroupAvcImeAdjustRefOffsetINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeConvertToMcePayloadINTEL):
                {
                    return "OpSubgroupAvcImeConvertToMcePayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetMaxMotionVectorCountINTEL):
                {
                    return "OpSubgroupAvcImeSetMaxMotionVectorCountINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL):
                {
                    return "OpSubgroupAvcImeSetUnidirectionalMixDisableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL):
                {
                    return "OpSubgroupAvcImeSetEarlySearchTerminationThresholdINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeSetWeightedSadINTEL):
                {
                    return "OpSubgroupAvcImeSetWeightedSadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithSingleReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithDualReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithDualReferenceStreaminINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithSingleReferenceStreamoutINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithDualReferenceStreamoutINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithSingleReferenceStreaminoutINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL):
                {
                    return "OpSubgroupAvcImeEvaluateWithDualReferenceStreaminoutINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeConvertToMceResultINTEL):
                {
                    return "OpSubgroupAvcImeConvertToMceResultINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetSingleReferenceStreaminINTEL):
                {
                    return "OpSubgroupAvcImeGetSingleReferenceStreaminINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetDualReferenceStreaminINTEL):
                {
                    return "OpSubgroupAvcImeGetDualReferenceStreaminINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL):
                {
                    return "OpSubgroupAvcImeStripSingleReferenceStreamoutINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeStripDualReferenceStreamoutINTEL):
                {
                    return "OpSubgroupAvcImeStripDualReferenceStreamoutINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL):
                {
                    return "OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeMotionVectorsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL):
                {
                    return "OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeDistortionsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL):
                {
                    return "OpSubgroupAvcImeGetStreamoutSingleReferenceMajorShapeReferenceIdsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL):
                {
                    return "OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeMotionVectorsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL):
                {
                    return "OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeDistortionsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL):
                {
                    return "OpSubgroupAvcImeGetStreamoutDualReferenceMajorShapeReferenceIdsINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetBorderReachedINTEL):
                {
                    return "OpSubgroupAvcImeGetBorderReachedINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL):
                {
                    return "OpSubgroupAvcImeGetTruncatedSearchIndicationINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL):
                {
                    return "OpSubgroupAvcImeGetUnidirectionalEarlySearchTerminationINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL):
                {
                    return "OpSubgroupAvcImeGetWeightingPatternMinimumMotionVectorINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL):
                {
                    return "OpSubgroupAvcImeGetWeightingPatternMinimumDistortionINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcFmeInitializeINTEL):
                {
                    return "OpSubgroupAvcFmeInitializeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcBmeInitializeINTEL):
                {
                    return "OpSubgroupAvcBmeInitializeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefConvertToMcePayloadINTEL):
                {
                    return "OpSubgroupAvcRefConvertToMcePayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefSetBidirectionalMixDisableINTEL):
                {
                    return "OpSubgroupAvcRefSetBidirectionalMixDisableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefSetBilinearFilterEnableINTEL):
                {
                    return "OpSubgroupAvcRefSetBilinearFilterEnableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL):
                {
                    return "OpSubgroupAvcRefEvaluateWithSingleReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithDualReferenceINTEL):
                {
                    return "OpSubgroupAvcRefEvaluateWithDualReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL):
                {
                    return "OpSubgroupAvcRefEvaluateWithMultiReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL):
                {
                    return "OpSubgroupAvcRefEvaluateWithMultiReferenceInterlacedINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcRefConvertToMceResultINTEL):
                {
                    return "OpSubgroupAvcRefConvertToMceResultINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicInitializeINTEL):
                {
                    return "OpSubgroupAvcSicInitializeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConfigureSkcINTEL):
                {
                    return "OpSubgroupAvcSicConfigureSkcINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConfigureIpeLumaINTEL):
                {
                    return "OpSubgroupAvcSicConfigureIpeLumaINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConfigureIpeLumaChromaINTEL):
                {
                    return "OpSubgroupAvcSicConfigureIpeLumaChromaINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetMotionVectorMaskINTEL):
                {
                    return "OpSubgroupAvcSicGetMotionVectorMaskINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConvertToMcePayloadINTEL):
                {
                    return "OpSubgroupAvcSicConvertToMcePayloadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL):
                {
                    return "OpSubgroupAvcSicSetIntraLumaShapePenaltyINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL):
                {
                    return "OpSubgroupAvcSicSetIntraLumaModeCostFunctionINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL):
                {
                    return "OpSubgroupAvcSicSetIntraChromaModeCostFunctionINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetBilinearFilterEnableINTEL):
                {
                    return "OpSubgroupAvcSicSetBilinearFilterEnableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL):
                {
                    return "OpSubgroupAvcSicSetSkcForwardTransformEnableINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL):
                {
                    return "OpSubgroupAvcSicSetBlockBasedRawSkipSadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateIpeINTEL):
                {
                    return "OpSubgroupAvcSicEvaluateIpeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL):
                {
                    return "OpSubgroupAvcSicEvaluateWithSingleReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithDualReferenceINTEL):
                {
                    return "OpSubgroupAvcSicEvaluateWithDualReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL):
                {
                    return "OpSubgroupAvcSicEvaluateWithMultiReferenceINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL):
                {
                    return "OpSubgroupAvcSicEvaluateWithMultiReferenceInterlacedINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicConvertToMceResultINTEL):
                {
                    return "OpSubgroupAvcSicConvertToMceResultINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetIpeLumaShapeINTEL):
                {
                    return "OpSubgroupAvcSicGetIpeLumaShapeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL):
                {
                    return "OpSubgroupAvcSicGetBestIpeLumaDistortionINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL):
                {
                    return "OpSubgroupAvcSicGetBestIpeChromaDistortionINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetPackedIpeLumaModesINTEL):
                {
                    return "OpSubgroupAvcSicGetPackedIpeLumaModesINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetIpeChromaModeINTEL):
                {
                    return "OpSubgroupAvcSicGetIpeChromaModeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL):
                {
                    return "OpSubgroupAvcSicGetPackedSkcLumaCountThresholdINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL):
                {
                    return "OpSubgroupAvcSicGetPackedSkcLumaSumThresholdINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupAvcSicGetInterRawSadsINTEL):
                {
                    return "OpSubgroupAvcSicGetInterRawSadsINTEL";
                }
                case unchecked((int)Spv.Op.OpVariableLengthArrayINTEL):
                {
                    return "OpVariableLengthArrayINTEL";
                }
                case unchecked((int)Spv.Op.OpSaveMemoryINTEL):
                {
                    return "OpSaveMemoryINTEL";
                }
                case unchecked((int)Spv.Op.OpRestoreMemoryINTEL):
                {
                    return "OpRestoreMemoryINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinCosPiALTERA):
                {
                    return "OpArbitraryFloatSinCosPiALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCastALTERA):
                {
                    return "OpArbitraryFloatCastALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCastFromIntALTERA):
                {
                    return "OpArbitraryFloatCastFromIntALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCastToIntALTERA):
                {
                    return "OpArbitraryFloatCastToIntALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatAddALTERA):
                {
                    return "OpArbitraryFloatAddALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSubALTERA):
                {
                    return "OpArbitraryFloatSubALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatMulALTERA):
                {
                    return "OpArbitraryFloatMulALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatDivALTERA):
                {
                    return "OpArbitraryFloatDivALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatGTALTERA):
                {
                    return "OpArbitraryFloatGTALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatGEALTERA):
                {
                    return "OpArbitraryFloatGEALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLTALTERA):
                {
                    return "OpArbitraryFloatLTALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLEALTERA):
                {
                    return "OpArbitraryFloatLEALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatEQALTERA):
                {
                    return "OpArbitraryFloatEQALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatRecipALTERA):
                {
                    return "OpArbitraryFloatRecipALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatRSqrtALTERA):
                {
                    return "OpArbitraryFloatRSqrtALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCbrtALTERA):
                {
                    return "OpArbitraryFloatCbrtALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatHypotALTERA):
                {
                    return "OpArbitraryFloatHypotALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSqrtALTERA):
                {
                    return "OpArbitraryFloatSqrtALTERA";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLogINTEL):
                {
                    return "OpArbitraryFloatLogINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLog2INTEL):
                {
                    return "OpArbitraryFloatLog2INTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLog10INTEL):
                {
                    return "OpArbitraryFloatLog10INTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatLog1pINTEL):
                {
                    return "OpArbitraryFloatLog1pINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExpINTEL):
                {
                    return "OpArbitraryFloatExpINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExp2INTEL):
                {
                    return "OpArbitraryFloatExp2INTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExp10INTEL):
                {
                    return "OpArbitraryFloatExp10INTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatExpm1INTEL):
                {
                    return "OpArbitraryFloatExpm1INTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinINTEL):
                {
                    return "OpArbitraryFloatSinINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCosINTEL):
                {
                    return "OpArbitraryFloatCosINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinCosINTEL):
                {
                    return "OpArbitraryFloatSinCosINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatSinPiINTEL):
                {
                    return "OpArbitraryFloatSinPiINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatCosPiINTEL):
                {
                    return "OpArbitraryFloatCosPiINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatASinINTEL):
                {
                    return "OpArbitraryFloatASinINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatASinPiINTEL):
                {
                    return "OpArbitraryFloatASinPiINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatACosINTEL):
                {
                    return "OpArbitraryFloatACosINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatACosPiINTEL):
                {
                    return "OpArbitraryFloatACosPiINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatATanINTEL):
                {
                    return "OpArbitraryFloatATanINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatATanPiINTEL):
                {
                    return "OpArbitraryFloatATanPiINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatATan2INTEL):
                {
                    return "OpArbitraryFloatATan2INTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatPowINTEL):
                {
                    return "OpArbitraryFloatPowINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatPowRINTEL):
                {
                    return "OpArbitraryFloatPowRINTEL";
                }
                case unchecked((int)Spv.Op.OpArbitraryFloatPowNINTEL):
                {
                    return "OpArbitraryFloatPowNINTEL";
                }
                case unchecked((int)Spv.Op.OpLoopControlINTEL):
                {
                    return "OpLoopControlINTEL";
                }
                case unchecked((int)Spv.Op.OpAliasDomainDeclINTEL):
                {
                    return "OpAliasDomainDeclINTEL";
                }
                case unchecked((int)Spv.Op.OpAliasScopeDeclINTEL):
                {
                    return "OpAliasScopeDeclINTEL";
                }
                case unchecked((int)Spv.Op.OpAliasScopeListDeclINTEL):
                {
                    return "OpAliasScopeListDeclINTEL";
                }
                case unchecked((int)Spv.Op.OpFixedSqrtALTERA):
                {
                    return "OpFixedSqrtALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedRecipALTERA):
                {
                    return "OpFixedRecipALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedRsqrtALTERA):
                {
                    return "OpFixedRsqrtALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedSinALTERA):
                {
                    return "OpFixedSinALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedCosALTERA):
                {
                    return "OpFixedCosALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedSinCosALTERA):
                {
                    return "OpFixedSinCosALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedSinPiALTERA):
                {
                    return "OpFixedSinPiALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedCosPiALTERA):
                {
                    return "OpFixedCosPiALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedSinCosPiALTERA):
                {
                    return "OpFixedSinCosPiALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedLogALTERA):
                {
                    return "OpFixedLogALTERA";
                }
                case unchecked((int)Spv.Op.OpFixedExpALTERA):
                {
                    return "OpFixedExpALTERA";
                }
                case unchecked((int)Spv.Op.OpPtrCastToCrossWorkgroupALTERA):
                {
                    return "OpPtrCastToCrossWorkgroupALTERA";
                }
                case unchecked((int)Spv.Op.OpCrossWorkgroupCastToPtrALTERA):
                {
                    return "OpCrossWorkgroupCastToPtrALTERA";
                }
                case unchecked((int)Spv.Op.OpReadPipeBlockingALTERA):
                {
                    return "OpReadPipeBlockingALTERA";
                }
                case unchecked((int)Spv.Op.OpWritePipeBlockingALTERA):
                {
                    return "OpWritePipeBlockingALTERA";
                }
                case unchecked((int)Spv.Op.OpFPGARegALTERA):
                {
                    return "OpFPGARegALTERA";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetRayTMinKHR):
                {
                    return "OpRayQueryGetRayTMinKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetRayFlagsKHR):
                {
                    return "OpRayQueryGetRayFlagsKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionTKHR):
                {
                    return "OpRayQueryGetIntersectionTKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceCustomIndexKHR):
                {
                    return "OpRayQueryGetIntersectionInstanceCustomIndexKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceIdKHR):
                {
                    return "OpRayQueryGetIntersectionInstanceIdKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR):
                {
                    return "OpRayQueryGetIntersectionInstanceShaderBindingTableRecordOffsetKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionGeometryIndexKHR):
                {
                    return "OpRayQueryGetIntersectionGeometryIndexKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionPrimitiveIndexKHR):
                {
                    return "OpRayQueryGetIntersectionPrimitiveIndexKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionBarycentricsKHR):
                {
                    return "OpRayQueryGetIntersectionBarycentricsKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionFrontFaceKHR):
                {
                    return "OpRayQueryGetIntersectionFrontFaceKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionCandidateAABBOpaqueKHR):
                {
                    return "OpRayQueryGetIntersectionCandidateAABBOpaqueKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectRayDirectionKHR):
                {
                    return "OpRayQueryGetIntersectionObjectRayDirectionKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectRayOriginKHR):
                {
                    return "OpRayQueryGetIntersectionObjectRayOriginKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetWorldRayDirectionKHR):
                {
                    return "OpRayQueryGetWorldRayDirectionKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetWorldRayOriginKHR):
                {
                    return "OpRayQueryGetWorldRayOriginKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionObjectToWorldKHR):
                {
                    return "OpRayQueryGetIntersectionObjectToWorldKHR";
                }
                case unchecked((int)Spv.Op.OpRayQueryGetIntersectionWorldToObjectKHR):
                {
                    return "OpRayQueryGetIntersectionWorldToObjectKHR";
                }
                case unchecked((int)Spv.Op.OpAtomicFAddEXT):
                {
                    return "OpAtomicFAddEXT";
                }
                case unchecked((int)Spv.Op.OpTypeBufferSurfaceINTEL):
                {
                    return "OpTypeBufferSurfaceINTEL";
                }
                case unchecked((int)Spv.Op.OpTypeStructContinuedINTEL):
                {
                    return "OpTypeStructContinuedINTEL";
                }
                case unchecked((int)Spv.Op.OpConstantCompositeContinuedINTEL):
                {
                    return "OpConstantCompositeContinuedINTEL";
                }
                case unchecked((int)Spv.Op.OpSpecConstantCompositeContinuedINTEL):
                {
                    return "OpSpecConstantCompositeContinuedINTEL";
                }
                case unchecked((int)Spv.Op.OpCompositeConstructContinuedINTEL):
                {
                    return "OpCompositeConstructContinuedINTEL";
                }
                case unchecked((int)Spv.Op.OpConvertFToBF16INTEL):
                {
                    return "OpConvertFToBF16INTEL";
                }
                case unchecked((int)Spv.Op.OpConvertBF16ToFINTEL):
                {
                    return "OpConvertBF16ToFINTEL";
                }
                case unchecked((int)Spv.Op.OpControlBarrierArriveINTEL):
                {
                    return "OpControlBarrierArriveINTEL";
                }
                case unchecked((int)Spv.Op.OpControlBarrierWaitINTEL):
                {
                    return "OpControlBarrierWaitINTEL";
                }
                case unchecked((int)Spv.Op.OpArithmeticFenceEXT):
                {
                    return "OpArithmeticFenceEXT";
                }
                case unchecked((int)Spv.Op.OpTaskSequenceCreateALTERA):
                {
                    return "OpTaskSequenceCreateALTERA";
                }
                case unchecked((int)Spv.Op.OpTaskSequenceAsyncALTERA):
                {
                    return "OpTaskSequenceAsyncALTERA";
                }
                case unchecked((int)Spv.Op.OpTaskSequenceGetALTERA):
                {
                    return "OpTaskSequenceGetALTERA";
                }
                case unchecked((int)Spv.Op.OpTaskSequenceReleaseALTERA):
                {
                    return "OpTaskSequenceReleaseALTERA";
                }
                case unchecked((int)Spv.Op.OpTypeTaskSequenceALTERA):
                {
                    return "OpTypeTaskSequenceALTERA";
                }
                case unchecked((int)Spv.Op.OpSubgroupBlockPrefetchINTEL):
                {
                    return "OpSubgroupBlockPrefetchINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockLoadINTEL):
                {
                    return "OpSubgroup2DBlockLoadINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockLoadTransformINTEL):
                {
                    return "OpSubgroup2DBlockLoadTransformINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockLoadTransposeINTEL):
                {
                    return "OpSubgroup2DBlockLoadTransposeINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockPrefetchINTEL):
                {
                    return "OpSubgroup2DBlockPrefetchINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroup2DBlockStoreINTEL):
                {
                    return "OpSubgroup2DBlockStoreINTEL";
                }
                case unchecked((int)Spv.Op.OpSubgroupMatrixMultiplyAccumulateINTEL):
                {
                    return "OpSubgroupMatrixMultiplyAccumulateINTEL";
                }
                case unchecked((int)Spv.Op.OpBitwiseFunctionINTEL):
                {
                    return "OpBitwiseFunctionINTEL";
                }
                case unchecked((int)Spv.Op.OpUntypedVariableLengthArrayINTEL):
                {
                    return "OpUntypedVariableLengthArrayINTEL";
                }
                case unchecked((int)Spv.Op.OpConditionalExtensionINTEL):
                {
                    return "OpConditionalExtensionINTEL";
                }
                case unchecked((int)Spv.Op.OpConditionalEntryPointINTEL):
                {
                    return "OpConditionalEntryPointINTEL";
                }
                case unchecked((int)Spv.Op.OpConditionalCapabilityINTEL):
                {
                    return "OpConditionalCapabilityINTEL";
                }
                case unchecked((int)Spv.Op.OpSpecConstantTargetINTEL):
                {
                    return "OpSpecConstantTargetINTEL";
                }
                case unchecked((int)Spv.Op.OpSpecConstantArchitectureINTEL):
                {
                    return "OpSpecConstantArchitectureINTEL";
                }
                case unchecked((int)Spv.Op.OpSpecConstantCapabilitiesINTEL):
                {
                    return "OpSpecConstantCapabilitiesINTEL";
                }
                case unchecked((int)Spv.Op.OpConditionalCopyObjectINTEL):
                {
                    return "OpConditionalCopyObjectINTEL";
                }
                case unchecked((int)Spv.Op.OpGroupIMulKHR):
                {
                    return "OpGroupIMulKHR";
                }
                case unchecked((int)Spv.Op.OpGroupFMulKHR):
                {
                    return "OpGroupFMulKHR";
                }
                case unchecked((int)Spv.Op.OpGroupBitwiseAndKHR):
                {
                    return "OpGroupBitwiseAndKHR";
                }
                case unchecked((int)Spv.Op.OpGroupBitwiseOrKHR):
                {
                    return "OpGroupBitwiseOrKHR";
                }
                case unchecked((int)Spv.Op.OpGroupBitwiseXorKHR):
                {
                    return "OpGroupBitwiseXorKHR";
                }
                case unchecked((int)Spv.Op.OpGroupLogicalAndKHR):
                {
                    return "OpGroupLogicalAndKHR";
                }
                case unchecked((int)Spv.Op.OpGroupLogicalOrKHR):
                {
                    return "OpGroupLogicalOrKHR";
                }
                case unchecked((int)Spv.Op.OpGroupLogicalXorKHR):
                {
                    return "OpGroupLogicalXorKHR";
                }
                case unchecked((int)Spv.Op.OpRoundFToTF32INTEL):
                {
                    return "OpRoundFToTF32INTEL";
                }
                case unchecked((int)Spv.Op.OpMaskedGatherINTEL):
                {
                    return "OpMaskedGatherINTEL";
                }
                case unchecked((int)Spv.Op.OpMaskedScatterINTEL):
                {
                    return "OpMaskedScatterINTEL";
                }
                case unchecked((int)Spv.Op.OpConvertHandleToImageINTEL):
                {
                    return "OpConvertHandleToImageINTEL";
                }
                case unchecked((int)Spv.Op.OpConvertHandleToSamplerINTEL):
                {
                    return "OpConvertHandleToSamplerINTEL";
                }
                case unchecked((int)Spv.Op.OpConvertHandleToSampledImageINTEL):
                {
                    return "OpConvertHandleToSampledImageINTEL";
                }
                case unchecked((int)Spv.Op.OpFDot2MixAcc32VALVE):
                {
                    return "OpFDot2MixAcc32VALVE";
                }
                case unchecked((int)Spv.Op.OpFDot2MixAcc16VALVE):
                {
                    return "OpFDot2MixAcc16VALVE";
                }
                case unchecked((int)Spv.Op.OpFDot4MixAcc32VALVE):
                {
                    return "OpFDot4MixAcc32VALVE";
                }
                default:
                {
                    return "Unknown";
                }
            }
        }
    }
    public static Spv.ImageOperandsMask operator_or(Spv.ImageOperandsMask a, Spv.ImageOperandsMask b)
    {
        return unchecked((Spv.ImageOperandsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.ImageOperandsMask operator_and(Spv.ImageOperandsMask a, Spv.ImageOperandsMask b)
    {
        return unchecked((Spv.ImageOperandsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.ImageOperandsMask operator_xor(Spv.ImageOperandsMask a, Spv.ImageOperandsMask b)
    {
        return unchecked((Spv.ImageOperandsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.ImageOperandsMask operator_compl(Spv.ImageOperandsMask a)
    {
        return unchecked((Spv.ImageOperandsMask)~unchecked((uint)a));
    }
    public static Spv.FPFastMathModeMask operator_or(Spv.FPFastMathModeMask a, Spv.FPFastMathModeMask b)
    {
        return unchecked((Spv.FPFastMathModeMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.FPFastMathModeMask operator_and(Spv.FPFastMathModeMask a, Spv.FPFastMathModeMask b)
    {
        return unchecked((Spv.FPFastMathModeMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.FPFastMathModeMask operator_xor(Spv.FPFastMathModeMask a, Spv.FPFastMathModeMask b)
    {
        return unchecked((Spv.FPFastMathModeMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.FPFastMathModeMask operator_compl(Spv.FPFastMathModeMask a)
    {
        return unchecked((Spv.FPFastMathModeMask)~unchecked((uint)a));
    }
    public static Spv.SelectionControlMask operator_or(Spv.SelectionControlMask a, Spv.SelectionControlMask b)
    {
        return unchecked((Spv.SelectionControlMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.SelectionControlMask operator_and(Spv.SelectionControlMask a, Spv.SelectionControlMask b)
    {
        return unchecked((Spv.SelectionControlMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.SelectionControlMask operator_xor(Spv.SelectionControlMask a, Spv.SelectionControlMask b)
    {
        return unchecked((Spv.SelectionControlMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.SelectionControlMask operator_compl(Spv.SelectionControlMask a)
    {
        return unchecked((Spv.SelectionControlMask)~unchecked((uint)a));
    }
    public static Spv.LoopControlMask operator_or(Spv.LoopControlMask a, Spv.LoopControlMask b)
    {
        return unchecked((Spv.LoopControlMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.LoopControlMask operator_and(Spv.LoopControlMask a, Spv.LoopControlMask b)
    {
        return unchecked((Spv.LoopControlMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.LoopControlMask operator_xor(Spv.LoopControlMask a, Spv.LoopControlMask b)
    {
        return unchecked((Spv.LoopControlMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.LoopControlMask operator_compl(Spv.LoopControlMask a)
    {
        return unchecked((Spv.LoopControlMask)~unchecked((uint)a));
    }
    public static Spv.FunctionControlMask operator_or(Spv.FunctionControlMask a, Spv.FunctionControlMask b)
    {
        return unchecked((Spv.FunctionControlMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.FunctionControlMask operator_and(Spv.FunctionControlMask a, Spv.FunctionControlMask b)
    {
        return unchecked((Spv.FunctionControlMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.FunctionControlMask operator_xor(Spv.FunctionControlMask a, Spv.FunctionControlMask b)
    {
        return unchecked((Spv.FunctionControlMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.FunctionControlMask operator_compl(Spv.FunctionControlMask a)
    {
        return unchecked((Spv.FunctionControlMask)~unchecked((uint)a));
    }
    public static Spv.MemorySemanticsMask operator_or(Spv.MemorySemanticsMask a, Spv.MemorySemanticsMask b)
    {
        return unchecked((Spv.MemorySemanticsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.MemorySemanticsMask operator_and(Spv.MemorySemanticsMask a, Spv.MemorySemanticsMask b)
    {
        return unchecked((Spv.MemorySemanticsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.MemorySemanticsMask operator_xor(Spv.MemorySemanticsMask a, Spv.MemorySemanticsMask b)
    {
        return unchecked((Spv.MemorySemanticsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.MemorySemanticsMask operator_compl(Spv.MemorySemanticsMask a)
    {
        return unchecked((Spv.MemorySemanticsMask)~unchecked((uint)a));
    }
    public static Spv.MemoryAccessMask operator_or(Spv.MemoryAccessMask a, Spv.MemoryAccessMask b)
    {
        return unchecked((Spv.MemoryAccessMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.MemoryAccessMask operator_and(Spv.MemoryAccessMask a, Spv.MemoryAccessMask b)
    {
        return unchecked((Spv.MemoryAccessMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.MemoryAccessMask operator_xor(Spv.MemoryAccessMask a, Spv.MemoryAccessMask b)
    {
        return unchecked((Spv.MemoryAccessMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.MemoryAccessMask operator_compl(Spv.MemoryAccessMask a)
    {
        return unchecked((Spv.MemoryAccessMask)~unchecked((uint)a));
    }
    public static Spv.KernelProfilingInfoMask operator_or(Spv.KernelProfilingInfoMask a, Spv.KernelProfilingInfoMask b)
    {
        return unchecked((Spv.KernelProfilingInfoMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.KernelProfilingInfoMask operator_and(Spv.KernelProfilingInfoMask a, Spv.KernelProfilingInfoMask b)
    {
        return unchecked((Spv.KernelProfilingInfoMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.KernelProfilingInfoMask operator_xor(Spv.KernelProfilingInfoMask a, Spv.KernelProfilingInfoMask b)
    {
        return unchecked((Spv.KernelProfilingInfoMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.KernelProfilingInfoMask operator_compl(Spv.KernelProfilingInfoMask a)
    {
        return unchecked((Spv.KernelProfilingInfoMask)~unchecked((uint)a));
    }
    public static Spv.RayFlagsMask operator_or(Spv.RayFlagsMask a, Spv.RayFlagsMask b)
    {
        return unchecked((Spv.RayFlagsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.RayFlagsMask operator_and(Spv.RayFlagsMask a, Spv.RayFlagsMask b)
    {
        return unchecked((Spv.RayFlagsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.RayFlagsMask operator_xor(Spv.RayFlagsMask a, Spv.RayFlagsMask b)
    {
        return unchecked((Spv.RayFlagsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.RayFlagsMask operator_compl(Spv.RayFlagsMask a)
    {
        return unchecked((Spv.RayFlagsMask)~unchecked((uint)a));
    }
    public static Spv.FragmentShadingRateMask operator_or(Spv.FragmentShadingRateMask a, Spv.FragmentShadingRateMask b)
    {
        return unchecked((Spv.FragmentShadingRateMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.FragmentShadingRateMask operator_and(Spv.FragmentShadingRateMask a, Spv.FragmentShadingRateMask b)
    {
        return unchecked((Spv.FragmentShadingRateMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.FragmentShadingRateMask operator_xor(Spv.FragmentShadingRateMask a, Spv.FragmentShadingRateMask b)
    {
        return unchecked((Spv.FragmentShadingRateMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.FragmentShadingRateMask operator_compl(Spv.FragmentShadingRateMask a)
    {
        return unchecked((Spv.FragmentShadingRateMask)~unchecked((uint)a));
    }
    public static Spv.CooperativeMatrixOperandsMask operator_or(Spv.CooperativeMatrixOperandsMask a, Spv.CooperativeMatrixOperandsMask b)
    {
        return unchecked((Spv.CooperativeMatrixOperandsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.CooperativeMatrixOperandsMask operator_and(Spv.CooperativeMatrixOperandsMask a, Spv.CooperativeMatrixOperandsMask b)
    {
        return unchecked((Spv.CooperativeMatrixOperandsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.CooperativeMatrixOperandsMask operator_xor(Spv.CooperativeMatrixOperandsMask a, Spv.CooperativeMatrixOperandsMask b)
    {
        return unchecked((Spv.CooperativeMatrixOperandsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.CooperativeMatrixOperandsMask operator_compl(Spv.CooperativeMatrixOperandsMask a)
    {
        return unchecked((Spv.CooperativeMatrixOperandsMask)~unchecked((uint)a));
    }
    public static Spv.CooperativeMatrixReduceMask operator_or(Spv.CooperativeMatrixReduceMask a, Spv.CooperativeMatrixReduceMask b)
    {
        return unchecked((Spv.CooperativeMatrixReduceMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.CooperativeMatrixReduceMask operator_and(Spv.CooperativeMatrixReduceMask a, Spv.CooperativeMatrixReduceMask b)
    {
        return unchecked((Spv.CooperativeMatrixReduceMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.CooperativeMatrixReduceMask operator_xor(Spv.CooperativeMatrixReduceMask a, Spv.CooperativeMatrixReduceMask b)
    {
        return unchecked((Spv.CooperativeMatrixReduceMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.CooperativeMatrixReduceMask operator_compl(Spv.CooperativeMatrixReduceMask a)
    {
        return unchecked((Spv.CooperativeMatrixReduceMask)~unchecked((uint)a));
    }
    public static Spv.TensorAddressingOperandsMask operator_or(Spv.TensorAddressingOperandsMask a, Spv.TensorAddressingOperandsMask b)
    {
        return unchecked((Spv.TensorAddressingOperandsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.TensorAddressingOperandsMask operator_and(Spv.TensorAddressingOperandsMask a, Spv.TensorAddressingOperandsMask b)
    {
        return unchecked((Spv.TensorAddressingOperandsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.TensorAddressingOperandsMask operator_xor(Spv.TensorAddressingOperandsMask a, Spv.TensorAddressingOperandsMask b)
    {
        return unchecked((Spv.TensorAddressingOperandsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.TensorAddressingOperandsMask operator_compl(Spv.TensorAddressingOperandsMask a)
    {
        return unchecked((Spv.TensorAddressingOperandsMask)~unchecked((uint)a));
    }
    public static Spv.TensorOperandsMask operator_or(Spv.TensorOperandsMask a, Spv.TensorOperandsMask b)
    {
        return unchecked((Spv.TensorOperandsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.TensorOperandsMask operator_and(Spv.TensorOperandsMask a, Spv.TensorOperandsMask b)
    {
        return unchecked((Spv.TensorOperandsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.TensorOperandsMask operator_xor(Spv.TensorOperandsMask a, Spv.TensorOperandsMask b)
    {
        return unchecked((Spv.TensorOperandsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.TensorOperandsMask operator_compl(Spv.TensorOperandsMask a)
    {
        return unchecked((Spv.TensorOperandsMask)~unchecked((uint)a));
    }
    public static Spv.MatrixMultiplyAccumulateOperandsMask operator_or(Spv.MatrixMultiplyAccumulateOperandsMask a, Spv.MatrixMultiplyAccumulateOperandsMask b)
    {
        return unchecked((Spv.MatrixMultiplyAccumulateOperandsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.MatrixMultiplyAccumulateOperandsMask operator_and(Spv.MatrixMultiplyAccumulateOperandsMask a, Spv.MatrixMultiplyAccumulateOperandsMask b)
    {
        return unchecked((Spv.MatrixMultiplyAccumulateOperandsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.MatrixMultiplyAccumulateOperandsMask operator_xor(Spv.MatrixMultiplyAccumulateOperandsMask a, Spv.MatrixMultiplyAccumulateOperandsMask b)
    {
        return unchecked((Spv.MatrixMultiplyAccumulateOperandsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.MatrixMultiplyAccumulateOperandsMask operator_compl(Spv.MatrixMultiplyAccumulateOperandsMask a)
    {
        return unchecked((Spv.MatrixMultiplyAccumulateOperandsMask)~unchecked((uint)a));
    }
    public static Spv.RawAccessChainOperandsMask operator_or(Spv.RawAccessChainOperandsMask a, Spv.RawAccessChainOperandsMask b)
    {
        return unchecked((Spv.RawAccessChainOperandsMask)(unchecked((uint)a) | unchecked((uint)b)));
    }
    public static Spv.RawAccessChainOperandsMask operator_and(Spv.RawAccessChainOperandsMask a, Spv.RawAccessChainOperandsMask b)
    {
        return unchecked((Spv.RawAccessChainOperandsMask)(unchecked((uint)a) & unchecked((uint)b)));
    }
    public static Spv.RawAccessChainOperandsMask operator_xor(Spv.RawAccessChainOperandsMask a, Spv.RawAccessChainOperandsMask b)
    {
        return unchecked((Spv.RawAccessChainOperandsMask)(unchecked((uint)a) ^ unchecked((uint)b)));
    }
    public static Spv.RawAccessChainOperandsMask operator_compl(Spv.RawAccessChainOperandsMask a)
    {
        return unchecked((Spv.RawAccessChainOperandsMask)~unchecked((uint)a));
    }
}
