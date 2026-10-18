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

public enum Decoration : int
{
    DecorationRelaxedPrecision = 0,
    DecorationSpecId = 1,
    DecorationBlock = 2,
    DecorationBufferBlock = 3,
    DecorationRowMajor = 4,
    DecorationColMajor = 5,
    DecorationArrayStride = 6,
    DecorationMatrixStride = 7,
    DecorationGLSLShared = 8,
    DecorationGLSLPacked = 9,
    DecorationCPacked = 10,
    DecorationBuiltIn = 11,
    DecorationNoPerspective = 13,
    DecorationFlat = 14,
    DecorationPatch = 15,
    DecorationCentroid = 16,
    DecorationSample = 17,
    DecorationInvariant = 18,
    DecorationRestrict = 19,
    DecorationAliased = 20,
    DecorationVolatile = 21,
    DecorationConstant = 22,
    DecorationCoherent = 23,
    DecorationNonWritable = 24,
    DecorationNonReadable = 25,
    DecorationUniform = 26,
    DecorationUniformId = 27,
    DecorationSaturatedConversion = 28,
    DecorationStream = 29,
    DecorationLocation = 30,
    DecorationComponent = 31,
    DecorationIndex = 32,
    DecorationBinding = 33,
    DecorationDescriptorSet = 34,
    DecorationOffset = 35,
    DecorationXfbBuffer = 36,
    DecorationXfbStride = 37,
    DecorationFuncParamAttr = 38,
    DecorationFPRoundingMode = 39,
    DecorationFPFastMathMode = 40,
    DecorationLinkageAttributes = 41,
    DecorationNoContraction = 42,
    DecorationInputAttachmentIndex = 43,
    DecorationAlignment = 44,
    DecorationMaxByteOffset = 45,
    DecorationAlignmentId = 46,
    DecorationMaxByteOffsetId = 47,
    DecorationSaturatedToLargestFloat8NormalConversionEXT = 4216,
    DecorationNoSignedWrap = 4469,
    DecorationNoUnsignedWrap = 4470,
    DecorationWeightTextureQCOM = 4487,
    DecorationBlockMatchTextureQCOM = 4488,
    DecorationBlockMatchSamplerQCOM = 4499,
    DecorationExplicitInterpAMD = 4999,
    DecorationNodeSharesPayloadLimitsWithAMDX = 5019,
    DecorationNodeMaxPayloadsAMDX = 5020,
    DecorationTrackFinishWritingAMDX = 5078,
    DecorationPayloadNodeNameAMDX = 5091,
    DecorationPayloadNodeBaseIndexAMDX = 5098,
    DecorationPayloadNodeSparseArrayAMDX = 5099,
    DecorationPayloadNodeArraySizeAMDX = 5100,
    DecorationPayloadDispatchIndirectAMDX = 5105,
    DecorationArrayStrideIdEXT = 5124,
    DecorationOffsetIdEXT = 5125,
    DecorationUTFEncodedKHR = 5145,
    DecorationOverrideCoverageNV = 5248,
    DecorationPassthroughNV = 5250,
    DecorationViewportRelativeNV = 5252,
    DecorationSecondaryViewportRelativeNV = 5256,
    DecorationPerPrimitiveEXT = 5271,
    DecorationPerPrimitiveNV = 5271,
    DecorationPerViewNV = 5272,
    DecorationPerTaskNV = 5273,
    DecorationPerVertexKHR = 5285,
    DecorationPerVertexNV = 5285,
    DecorationNonUniform = 5300,
    DecorationNonUniformEXT = 5300,
    DecorationRestrictPointer = 5355,
    DecorationRestrictPointerEXT = 5355,
    DecorationAliasedPointer = 5356,
    DecorationAliasedPointerEXT = 5356,
    DecorationMemberOffsetNV = 5358,
    DecorationHitObjectShaderRecordBufferNV = 5386,
    DecorationHitObjectShaderRecordBufferEXT = 5389,
    DecorationBankNV = 5397,
    DecorationBindlessSamplerNV = 5398,
    DecorationBindlessImageNV = 5399,
    DecorationBoundSamplerNV = 5400,
    DecorationBoundImageNV = 5401,
    DecorationSIMTCallINTEL = 5599,
    DecorationReferencedIndirectlyINTEL = 5602,
    DecorationClobberINTEL = 5607,
    DecorationSideEffectsINTEL = 5608,
    DecorationVectorComputeVariableINTEL = 5624,
    DecorationFuncParamIOKindINTEL = 5625,
    DecorationVectorComputeFunctionINTEL = 5626,
    DecorationStackCallINTEL = 5627,
    DecorationGlobalVariableOffsetINTEL = 5628,
    DecorationCounterBuffer = 5634,
    DecorationHlslCounterBufferGOOGLE = 5634,
    DecorationHlslSemanticGOOGLE = 5635,
    DecorationUserSemantic = 5635,
    DecorationUserTypeGOOGLE = 5636,
    DecorationFunctionRoundingModeINTEL = 5822,
    DecorationFunctionDenormModeINTEL = 5823,
    DecorationRegisterALTERA = 5825,
    DecorationRegisterINTEL = 5825,
    DecorationMemoryALTERA = 5826,
    DecorationMemoryINTEL = 5826,
    DecorationNumbanksALTERA = 5827,
    DecorationNumbanksINTEL = 5827,
    DecorationBankwidthALTERA = 5828,
    DecorationBankwidthINTEL = 5828,
    DecorationMaxPrivateCopiesALTERA = 5829,
    DecorationMaxPrivateCopiesINTEL = 5829,
    DecorationSinglepumpALTERA = 5830,
    DecorationSinglepumpINTEL = 5830,
    DecorationDoublepumpALTERA = 5831,
    DecorationDoublepumpINTEL = 5831,
    DecorationMaxReplicatesALTERA = 5832,
    DecorationMaxReplicatesINTEL = 5832,
    DecorationSimpleDualPortALTERA = 5833,
    DecorationSimpleDualPortINTEL = 5833,
    DecorationMergeALTERA = 5834,
    DecorationMergeINTEL = 5834,
    DecorationBankBitsALTERA = 5835,
    DecorationBankBitsINTEL = 5835,
    DecorationForcePow2DepthALTERA = 5836,
    DecorationForcePow2DepthINTEL = 5836,
    DecorationStridesizeALTERA = 5883,
    DecorationStridesizeINTEL = 5883,
    DecorationWordsizeALTERA = 5884,
    DecorationWordsizeINTEL = 5884,
    DecorationTrueDualPortALTERA = 5885,
    DecorationTrueDualPortINTEL = 5885,
    DecorationBurstCoalesceALTERA = 5899,
    DecorationBurstCoalesceINTEL = 5899,
    DecorationCacheSizeALTERA = 5900,
    DecorationCacheSizeINTEL = 5900,
    DecorationDontStaticallyCoalesceALTERA = 5901,
    DecorationDontStaticallyCoalesceINTEL = 5901,
    DecorationPrefetchALTERA = 5902,
    DecorationPrefetchINTEL = 5902,
    DecorationStallEnableALTERA = 5905,
    DecorationStallEnableINTEL = 5905,
    DecorationFuseLoopsInFunctionALTERA = 5907,
    DecorationFuseLoopsInFunctionINTEL = 5907,
    DecorationMathOpDSPModeALTERA = 5909,
    DecorationMathOpDSPModeINTEL = 5909,
    DecorationAliasScopeINTEL = 5914,
    DecorationNoAliasINTEL = 5915,
    DecorationInitiationIntervalALTERA = 5917,
    DecorationInitiationIntervalINTEL = 5917,
    DecorationMaxConcurrencyALTERA = 5918,
    DecorationMaxConcurrencyINTEL = 5918,
    DecorationPipelineEnableALTERA = 5919,
    DecorationPipelineEnableINTEL = 5919,
    DecorationBufferLocationALTERA = 5921,
    DecorationBufferLocationINTEL = 5921,
    DecorationIOPipeStorageALTERA = 5944,
    DecorationIOPipeStorageINTEL = 5944,
    DecorationFunctionFloatingPointModeINTEL = 6080,
    DecorationSingleElementVectorINTEL = 6085,
    DecorationVectorComputeCallableFunctionINTEL = 6087,
    DecorationMediaBlockIOINTEL = 6140,
    DecorationStallFreeALTERA = 6151,
    DecorationStallFreeINTEL = 6151,
    DecorationFPMaxErrorDecorationINTEL = 6170,
    DecorationLatencyControlLabelALTERA = 6172,
    DecorationLatencyControlLabelINTEL = 6172,
    DecorationLatencyControlConstraintALTERA = 6173,
    DecorationLatencyControlConstraintINTEL = 6173,
    DecorationConduitKernelArgumentALTERA = 6175,
    DecorationConduitKernelArgumentINTEL = 6175,
    DecorationRegisterMapKernelArgumentALTERA = 6176,
    DecorationRegisterMapKernelArgumentINTEL = 6176,
    DecorationMMHostInterfaceAddressWidthALTERA = 6177,
    DecorationMMHostInterfaceAddressWidthINTEL = 6177,
    DecorationMMHostInterfaceDataWidthALTERA = 6178,
    DecorationMMHostInterfaceDataWidthINTEL = 6178,
    DecorationMMHostInterfaceLatencyALTERA = 6179,
    DecorationMMHostInterfaceLatencyINTEL = 6179,
    DecorationMMHostInterfaceReadWriteModeALTERA = 6180,
    DecorationMMHostInterfaceReadWriteModeINTEL = 6180,
    DecorationMMHostInterfaceMaxBurstALTERA = 6181,
    DecorationMMHostInterfaceMaxBurstINTEL = 6181,
    DecorationMMHostInterfaceWaitRequestALTERA = 6182,
    DecorationMMHostInterfaceWaitRequestINTEL = 6182,
    DecorationStableKernelArgumentALTERA = 6183,
    DecorationStableKernelArgumentINTEL = 6183,
    DecorationHostAccessINTEL = 6188,
    DecorationInitModeALTERA = 6190,
    DecorationInitModeINTEL = 6190,
    DecorationImplementInRegisterMapALTERA = 6191,
    DecorationImplementInRegisterMapINTEL = 6191,
    DecorationConditionalINTEL = 6247,
    DecorationCacheControlLoadINTEL = 6442,
    DecorationCacheControlStoreINTEL = 6443,
    DecorationMax = 2147483647,
}
