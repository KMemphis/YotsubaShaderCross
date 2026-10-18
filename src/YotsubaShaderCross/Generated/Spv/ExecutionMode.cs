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

public enum ExecutionMode : int
{
    ExecutionModeInvocations = 0,
    ExecutionModeSpacingEqual = 1,
    ExecutionModeSpacingFractionalEven = 2,
    ExecutionModeSpacingFractionalOdd = 3,
    ExecutionModeVertexOrderCw = 4,
    ExecutionModeVertexOrderCcw = 5,
    ExecutionModePixelCenterInteger = 6,
    ExecutionModeOriginUpperLeft = 7,
    ExecutionModeOriginLowerLeft = 8,
    ExecutionModeEarlyFragmentTests = 9,
    ExecutionModePointMode = 10,
    ExecutionModeXfb = 11,
    ExecutionModeDepthReplacing = 12,
    ExecutionModeDepthGreater = 14,
    ExecutionModeDepthLess = 15,
    ExecutionModeDepthUnchanged = 16,
    ExecutionModeLocalSize = 17,
    ExecutionModeLocalSizeHint = 18,
    ExecutionModeInputPoints = 19,
    ExecutionModeInputLines = 20,
    ExecutionModeInputLinesAdjacency = 21,
    ExecutionModeTriangles = 22,
    ExecutionModeInputTrianglesAdjacency = 23,
    ExecutionModeQuads = 24,
    ExecutionModeIsolines = 25,
    ExecutionModeOutputVertices = 26,
    ExecutionModeOutputPoints = 27,
    ExecutionModeOutputLineStrip = 28,
    ExecutionModeOutputTriangleStrip = 29,
    ExecutionModeVecTypeHint = 30,
    ExecutionModeContractionOff = 31,
    ExecutionModeInitializer = 33,
    ExecutionModeFinalizer = 34,
    ExecutionModeSubgroupSize = 35,
    ExecutionModeSubgroupsPerWorkgroup = 36,
    ExecutionModeSubgroupsPerWorkgroupId = 37,
    ExecutionModeLocalSizeId = 38,
    ExecutionModeLocalSizeHintId = 39,
    ExecutionModeNonCoherentColorAttachmentReadEXT = 4169,
    ExecutionModeNonCoherentDepthAttachmentReadEXT = 4170,
    ExecutionModeNonCoherentStencilAttachmentReadEXT = 4171,
    ExecutionModeSubgroupUniformControlFlowKHR = 4421,
    ExecutionModePostDepthCoverage = 4446,
    ExecutionModeDenormPreserve = 4459,
    ExecutionModeDenormFlushToZero = 4460,
    ExecutionModeSignedZeroInfNanPreserve = 4461,
    ExecutionModeRoundingModeRTE = 4462,
    ExecutionModeRoundingModeRTZ = 4463,
    ExecutionModeNonCoherentTileAttachmentReadQCOM = 4489,
    ExecutionModeTileShadingRateQCOM = 4490,
    ExecutionModeEarlyAndLateFragmentTestsAMD = 5017,
    ExecutionModeStencilRefReplacingEXT = 5027,
    ExecutionModeCoalescingAMDX = 5069,
    ExecutionModeIsApiEntryAMDX = 5070,
    ExecutionModeMaxNodeRecursionAMDX = 5071,
    ExecutionModeStaticNumWorkgroupsAMDX = 5072,
    ExecutionModeShaderIndexAMDX = 5073,
    ExecutionModeMaxNumWorkgroupsAMDX = 5077,
    ExecutionModeStencilRefUnchangedFrontAMD = 5079,
    ExecutionModeStencilRefGreaterFrontAMD = 5080,
    ExecutionModeStencilRefLessFrontAMD = 5081,
    ExecutionModeStencilRefUnchangedBackAMD = 5082,
    ExecutionModeStencilRefGreaterBackAMD = 5083,
    ExecutionModeStencilRefLessBackAMD = 5084,
    ExecutionModeQuadDerivativesKHR = 5088,
    ExecutionModeRequireFullQuadsKHR = 5089,
    ExecutionModeSharesInputWithAMDX = 5102,
    ExecutionModeArithmeticPoisonKHR = 5157,
    ExecutionModeOutputLinesEXT = 5269,
    ExecutionModeOutputLinesNV = 5269,
    ExecutionModeOutputPrimitivesEXT = 5270,
    ExecutionModeOutputPrimitivesNV = 5270,
    ExecutionModeDerivativeGroupQuadsKHR = 5289,
    ExecutionModeDerivativeGroupQuadsNV = 5289,
    ExecutionModeDerivativeGroupLinearKHR = 5290,
    ExecutionModeDerivativeGroupLinearNV = 5290,
    ExecutionModeOutputTrianglesEXT = 5298,
    ExecutionModeOutputTrianglesNV = 5298,
    ExecutionModePixelInterlockOrderedEXT = 5366,
    ExecutionModePixelInterlockUnorderedEXT = 5367,
    ExecutionModeSampleInterlockOrderedEXT = 5368,
    ExecutionModeSampleInterlockUnorderedEXT = 5369,
    ExecutionModeShadingRateInterlockOrderedEXT = 5370,
    ExecutionModeShadingRateInterlockUnorderedEXT = 5371,
    ExecutionModeShader64BitIndexingEXT = 5427,
    ExecutionModeSharedLocalMemorySizeINTEL = 5618,
    ExecutionModeRoundingModeRTPINTEL = 5620,
    ExecutionModeRoundingModeRTNINTEL = 5621,
    ExecutionModeFloatingPointModeALTINTEL = 5622,
    ExecutionModeFloatingPointModeIEEEINTEL = 5623,
    ExecutionModeMaxWorkgroupSizeINTEL = 5893,
    ExecutionModeMaxWorkDimINTEL = 5894,
    ExecutionModeNoGlobalOffsetINTEL = 5895,
    ExecutionModeNumSIMDWorkitemsINTEL = 5896,
    ExecutionModeSchedulerTargetFmaxMhzINTEL = 5903,
    ExecutionModeMaximallyReconvergesKHR = 6023,
    ExecutionModeFPFastMathDefault = 6028,
    ExecutionModeStreamingInterfaceINTEL = 6154,
    ExecutionModeRegisterMapInterfaceINTEL = 6160,
    ExecutionModeNamedBarrierCountINTEL = 6417,
    ExecutionModeMaximumRegistersINTEL = 6461,
    ExecutionModeMaximumRegistersIdINTEL = 6462,
    ExecutionModeNamedMaximumRegistersINTEL = 6463,
    ExecutionModeMax = 2147483647,
}
