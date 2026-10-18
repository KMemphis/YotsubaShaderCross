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

public enum StorageClass : int
{
    StorageClassUniformConstant = 0,
    StorageClassInput = 1,
    StorageClassUniform = 2,
    StorageClassOutput = 3,
    StorageClassWorkgroup = 4,
    StorageClassCrossWorkgroup = 5,
    StorageClassPrivate = 6,
    StorageClassFunction = 7,
    StorageClassGeneric = 8,
    StorageClassPushConstant = 9,
    StorageClassAtomicCounter = 10,
    StorageClassImage = 11,
    StorageClassStorageBuffer = 12,
    StorageClassTileImageEXT = 4172,
    StorageClassTileAttachmentQCOM = 4491,
    StorageClassNodePayloadAMDX = 5068,
    StorageClassCallableDataKHR = 5328,
    StorageClassCallableDataNV = 5328,
    StorageClassIncomingCallableDataKHR = 5329,
    StorageClassIncomingCallableDataNV = 5329,
    StorageClassRayPayloadKHR = 5338,
    StorageClassRayPayloadNV = 5338,
    StorageClassHitAttributeKHR = 5339,
    StorageClassHitAttributeNV = 5339,
    StorageClassIncomingRayPayloadKHR = 5342,
    StorageClassIncomingRayPayloadNV = 5342,
    StorageClassShaderRecordBufferKHR = 5343,
    StorageClassShaderRecordBufferNV = 5343,
    StorageClassPhysicalStorageBuffer = 5349,
    StorageClassPhysicalStorageBufferEXT = 5349,
    StorageClassHitObjectAttributeNV = 5385,
    StorageClassTaskPayloadWorkgroupEXT = 5402,
    StorageClassHitObjectAttributeEXT = 5411,
    StorageClassCodeSectionINTEL = 5605,
    StorageClassDeviceOnlyALTERA = 5936,
    StorageClassDeviceOnlyINTEL = 5936,
    StorageClassHostOnlyALTERA = 5937,
    StorageClassHostOnlyINTEL = 5937,
    StorageClassMax = 2147483647,
}
