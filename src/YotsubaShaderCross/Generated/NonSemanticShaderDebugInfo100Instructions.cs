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
// Upstream sources: NonSemanticShaderDebugInfo100.h
// Upstream copyright: Copyright 2018-2024 The Khronos Group Inc.
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public enum NonSemanticShaderDebugInfo100Instructions : int
{
    NonSemanticShaderDebugInfo100DebugInfoNone = 0,
    NonSemanticShaderDebugInfo100DebugCompilationUnit = 1,
    NonSemanticShaderDebugInfo100DebugTypeBasic = 2,
    NonSemanticShaderDebugInfo100DebugTypePointer = 3,
    NonSemanticShaderDebugInfo100DebugTypeQualifier = 4,
    NonSemanticShaderDebugInfo100DebugTypeArray = 5,
    NonSemanticShaderDebugInfo100DebugTypeVector = 6,
    NonSemanticShaderDebugInfo100DebugTypedef = 7,
    NonSemanticShaderDebugInfo100DebugTypeFunction = 8,
    NonSemanticShaderDebugInfo100DebugTypeEnum = 9,
    NonSemanticShaderDebugInfo100DebugTypeComposite = 10,
    NonSemanticShaderDebugInfo100DebugTypeMember = 11,
    NonSemanticShaderDebugInfo100DebugTypeInheritance = 12,
    NonSemanticShaderDebugInfo100DebugTypePtrToMember = 13,
    NonSemanticShaderDebugInfo100DebugTypeTemplate = 14,
    NonSemanticShaderDebugInfo100DebugTypeTemplateParameter = 15,
    NonSemanticShaderDebugInfo100DebugTypeTemplateTemplateParameter = 16,
    NonSemanticShaderDebugInfo100DebugTypeTemplateParameterPack = 17,
    NonSemanticShaderDebugInfo100DebugGlobalVariable = 18,
    NonSemanticShaderDebugInfo100DebugFunctionDeclaration = 19,
    NonSemanticShaderDebugInfo100DebugFunction = 20,
    NonSemanticShaderDebugInfo100DebugLexicalBlock = 21,
    NonSemanticShaderDebugInfo100DebugLexicalBlockDiscriminator = 22,
    NonSemanticShaderDebugInfo100DebugScope = 23,
    NonSemanticShaderDebugInfo100DebugNoScope = 24,
    NonSemanticShaderDebugInfo100DebugInlinedAt = 25,
    NonSemanticShaderDebugInfo100DebugLocalVariable = 26,
    NonSemanticShaderDebugInfo100DebugInlinedVariable = 27,
    NonSemanticShaderDebugInfo100DebugDeclare = 28,
    NonSemanticShaderDebugInfo100DebugValue = 29,
    NonSemanticShaderDebugInfo100DebugOperation = 30,
    NonSemanticShaderDebugInfo100DebugExpression = 31,
    NonSemanticShaderDebugInfo100DebugMacroDef = 32,
    NonSemanticShaderDebugInfo100DebugMacroUndef = 33,
    NonSemanticShaderDebugInfo100DebugImportedEntity = 34,
    NonSemanticShaderDebugInfo100DebugSource = 35,
    NonSemanticShaderDebugInfo100DebugFunctionDefinition = 101,
    NonSemanticShaderDebugInfo100DebugSourceContinued = 102,
    NonSemanticShaderDebugInfo100DebugLine = 103,
    NonSemanticShaderDebugInfo100DebugNoLine = 104,
    NonSemanticShaderDebugInfo100DebugBuildIdentifier = 105,
    NonSemanticShaderDebugInfo100DebugStoragePath = 106,
    NonSemanticShaderDebugInfo100DebugEntryPoint = 107,
    NonSemanticShaderDebugInfo100DebugTypeMatrix = 108,
    NonSemanticShaderDebugInfo100InstructionsMax = 2147483647,
}
