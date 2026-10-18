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

public enum BuiltIn : int
{
    BuiltInPosition = 0,
    BuiltInPointSize = 1,
    BuiltInClipDistance = 3,
    BuiltInCullDistance = 4,
    BuiltInVertexId = 5,
    BuiltInInstanceId = 6,
    BuiltInPrimitiveId = 7,
    BuiltInInvocationId = 8,
    BuiltInLayer = 9,
    BuiltInViewportIndex = 10,
    BuiltInTessLevelOuter = 11,
    BuiltInTessLevelInner = 12,
    BuiltInTessCoord = 13,
    BuiltInPatchVertices = 14,
    BuiltInFragCoord = 15,
    BuiltInPointCoord = 16,
    BuiltInFrontFacing = 17,
    BuiltInSampleId = 18,
    BuiltInSamplePosition = 19,
    BuiltInSampleMask = 20,
    BuiltInFragDepth = 22,
    BuiltInHelperInvocation = 23,
    BuiltInNumWorkgroups = 24,
    BuiltInWorkgroupSize = 25,
    BuiltInWorkgroupId = 26,
    BuiltInLocalInvocationId = 27,
    BuiltInGlobalInvocationId = 28,
    BuiltInLocalInvocationIndex = 29,
    BuiltInWorkDim = 30,
    BuiltInGlobalSize = 31,
    BuiltInEnqueuedWorkgroupSize = 32,
    BuiltInGlobalOffset = 33,
    BuiltInGlobalLinearId = 34,
    BuiltInSubgroupSize = 36,
    BuiltInSubgroupMaxSize = 37,
    BuiltInNumSubgroups = 38,
    BuiltInNumEnqueuedSubgroups = 39,
    BuiltInSubgroupId = 40,
    BuiltInSubgroupLocalInvocationId = 41,
    BuiltInVertexIndex = 42,
    BuiltInInstanceIndex = 43,
    BuiltInCoreIDARM = 4160,
    BuiltInCoreCountARM = 4161,
    BuiltInCoreMaxIDARM = 4162,
    BuiltInWarpIDARM = 4163,
    BuiltInWarpMaxIDARM = 4164,
    BuiltInSubgroupEqMask = 4416,
    BuiltInSubgroupEqMaskKHR = 4416,
    BuiltInSubgroupGeMask = 4417,
    BuiltInSubgroupGeMaskKHR = 4417,
    BuiltInSubgroupGtMask = 4418,
    BuiltInSubgroupGtMaskKHR = 4418,
    BuiltInSubgroupLeMask = 4419,
    BuiltInSubgroupLeMaskKHR = 4419,
    BuiltInSubgroupLtMask = 4420,
    BuiltInSubgroupLtMaskKHR = 4420,
    BuiltInBaseVertex = 4424,
    BuiltInBaseInstance = 4425,
    BuiltInDrawIndex = 4426,
    BuiltInPrimitiveShadingRateKHR = 4432,
    BuiltInDeviceIndex = 4438,
    BuiltInViewIndex = 4440,
    BuiltInShadingRateKHR = 4444,
    BuiltInTileOffsetQCOM = 4492,
    BuiltInTileDimensionQCOM = 4493,
    BuiltInTileApronSizeQCOM = 4494,
    BuiltInBaryCoordNoPerspAMD = 4992,
    BuiltInBaryCoordNoPerspCentroidAMD = 4993,
    BuiltInBaryCoordNoPerspSampleAMD = 4994,
    BuiltInBaryCoordSmoothAMD = 4995,
    BuiltInBaryCoordSmoothCentroidAMD = 4996,
    BuiltInBaryCoordSmoothSampleAMD = 4997,
    BuiltInBaryCoordPullModelAMD = 4998,
    BuiltInFragStencilRefEXT = 5014,
    BuiltInRemainingRecursionLevelsAMDX = 5021,
    BuiltInShaderIndexAMDX = 5073,
    BuiltInSamplerHeapEXT = 5122,
    BuiltInResourceHeapEXT = 5123,
    BuiltInViewportMaskNV = 5253,
    BuiltInSecondaryPositionNV = 5257,
    BuiltInSecondaryViewportMaskNV = 5258,
    BuiltInPositionPerViewNV = 5261,
    BuiltInViewportMaskPerViewNV = 5262,
    BuiltInFullyCoveredEXT = 5264,
    BuiltInTaskCountNV = 5274,
    BuiltInPrimitiveCountNV = 5275,
    BuiltInPrimitiveIndicesNV = 5276,
    BuiltInClipDistancePerViewNV = 5277,
    BuiltInCullDistancePerViewNV = 5278,
    BuiltInLayerPerViewNV = 5279,
    BuiltInMeshViewCountNV = 5280,
    BuiltInMeshViewIndicesNV = 5281,
    BuiltInBaryCoordKHR = 5286,
    BuiltInBaryCoordNV = 5286,
    BuiltInBaryCoordNoPerspKHR = 5287,
    BuiltInBaryCoordNoPerspNV = 5287,
    BuiltInFragSizeEXT = 5292,
    BuiltInFragmentSizeNV = 5292,
    BuiltInFragInvocationCountEXT = 5293,
    BuiltInInvocationsPerPixelNV = 5293,
    BuiltInPrimitivePointIndicesEXT = 5294,
    BuiltInPrimitiveLineIndicesEXT = 5295,
    BuiltInPrimitiveTriangleIndicesEXT = 5296,
    BuiltInCullPrimitiveEXT = 5299,
    BuiltInLaunchIdKHR = 5319,
    BuiltInLaunchIdNV = 5319,
    BuiltInLaunchSizeKHR = 5320,
    BuiltInLaunchSizeNV = 5320,
    BuiltInWorldRayOriginKHR = 5321,
    BuiltInWorldRayOriginNV = 5321,
    BuiltInWorldRayDirectionKHR = 5322,
    BuiltInWorldRayDirectionNV = 5322,
    BuiltInObjectRayOriginKHR = 5323,
    BuiltInObjectRayOriginNV = 5323,
    BuiltInObjectRayDirectionKHR = 5324,
    BuiltInObjectRayDirectionNV = 5324,
    BuiltInRayTminKHR = 5325,
    BuiltInRayTminNV = 5325,
    BuiltInRayTmaxKHR = 5326,
    BuiltInRayTmaxNV = 5326,
    BuiltInInstanceCustomIndexKHR = 5327,
    BuiltInInstanceCustomIndexNV = 5327,
    BuiltInObjectToWorldKHR = 5330,
    BuiltInObjectToWorldNV = 5330,
    BuiltInWorldToObjectKHR = 5331,
    BuiltInWorldToObjectNV = 5331,
    BuiltInHitTNV = 5332,
    BuiltInHitKindKHR = 5333,
    BuiltInHitKindNV = 5333,
    BuiltInCurrentRayTimeNV = 5334,
    BuiltInHitTriangleVertexPositionsKHR = 5335,
    BuiltInHitMicroTriangleVertexPositionsNV = 5337,
    BuiltInHitMicroTriangleVertexBarycentricsNV = 5344,
    BuiltInIncomingRayFlagsKHR = 5351,
    BuiltInIncomingRayFlagsNV = 5351,
    BuiltInRayGeometryIndexKHR = 5352,
    BuiltInHitIsSphereNV = 5359,
    BuiltInHitIsLSSNV = 5360,
    BuiltInHitSpherePositionNV = 5361,
    BuiltInWarpsPerSMNV = 5374,
    BuiltInSMCountNV = 5375,
    BuiltInWarpIDNV = 5376,
    BuiltInSMIDNV = 5377,
    BuiltInHitLSSPositionsNV = 5396,
    BuiltInHitKindFrontFacingMicroTriangleNV = 5405,
    BuiltInHitKindBackFacingMicroTriangleNV = 5406,
    BuiltInHitSphereRadiusNV = 5420,
    BuiltInHitLSSRadiiNV = 5421,
    BuiltInClusterIDNV = 5436,
    BuiltInCullMaskKHR = 6021,
    BuiltInMax = 2147483647,
}
