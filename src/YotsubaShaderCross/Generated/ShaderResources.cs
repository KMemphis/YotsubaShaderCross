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
// Upstream sources: spirv_cross.hpp
// Upstream copyright: Copyright 2015-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class ShaderResources
{
    public CppVector<Resource> uniform_buffers = new CppVector<Resource>();
    public CppVector<Resource> storage_buffers = new CppVector<Resource>();
    public CppVector<Resource> stage_inputs = new CppVector<Resource>();
    public CppVector<Resource> stage_outputs = new CppVector<Resource>();
    public CppVector<Resource> subpass_inputs = new CppVector<Resource>();
    public CppVector<Resource> storage_images = new CppVector<Resource>();
    public CppVector<Resource> sampled_images = new CppVector<Resource>();
    public CppVector<Resource> atomic_counters = new CppVector<Resource>();
    public CppVector<Resource> acceleration_structures = new CppVector<Resource>();
    public CppVector<Resource> gl_plain_uniforms = new CppVector<Resource>();
    public CppVector<Resource> tensors = new CppVector<Resource>();
    public CppVector<Resource> push_constant_buffers = new CppVector<Resource>();
    public CppVector<Resource> shader_record_buffers = new CppVector<Resource>();
    public CppVector<Resource> separate_images = new CppVector<Resource>();
    public CppVector<Resource> separate_samplers = new CppVector<Resource>();
    public CppVector<BuiltInResource> builtin_inputs = new CppVector<BuiltInResource>();
    public CppVector<BuiltInResource> builtin_outputs = new CppVector<BuiltInResource>();

    protected virtual void FixClone()
    {
        this.uniform_buffers = this.uniform_buffers.Clone(__e => __e.Clone());
        this.storage_buffers = this.storage_buffers.Clone(__e => __e.Clone());
        this.stage_inputs = this.stage_inputs.Clone(__e => __e.Clone());
        this.stage_outputs = this.stage_outputs.Clone(__e => __e.Clone());
        this.subpass_inputs = this.subpass_inputs.Clone(__e => __e.Clone());
        this.storage_images = this.storage_images.Clone(__e => __e.Clone());
        this.sampled_images = this.sampled_images.Clone(__e => __e.Clone());
        this.atomic_counters = this.atomic_counters.Clone(__e => __e.Clone());
        this.acceleration_structures = this.acceleration_structures.Clone(__e => __e.Clone());
        this.gl_plain_uniforms = this.gl_plain_uniforms.Clone(__e => __e.Clone());
        this.tensors = this.tensors.Clone(__e => __e.Clone());
        this.push_constant_buffers = this.push_constant_buffers.Clone(__e => __e.Clone());
        this.shader_record_buffers = this.shader_record_buffers.Clone(__e => __e.Clone());
        this.separate_images = this.separate_images.Clone(__e => __e.Clone());
        this.separate_samplers = this.separate_samplers.Clone(__e => __e.Clone());
        this.builtin_inputs = this.builtin_inputs.Clone(__e => __e.Clone());
        this.builtin_outputs = this.builtin_outputs.Clone(__e => __e.Clone());
    }

    public ShaderResources Clone()
    {
        var __c = (ShaderResources)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(ShaderResources o)
    {
        this.uniform_buffers = o.uniform_buffers.Clone(__e => __e.Clone());
        this.storage_buffers = o.storage_buffers.Clone(__e => __e.Clone());
        this.stage_inputs = o.stage_inputs.Clone(__e => __e.Clone());
        this.stage_outputs = o.stage_outputs.Clone(__e => __e.Clone());
        this.subpass_inputs = o.subpass_inputs.Clone(__e => __e.Clone());
        this.storage_images = o.storage_images.Clone(__e => __e.Clone());
        this.sampled_images = o.sampled_images.Clone(__e => __e.Clone());
        this.atomic_counters = o.atomic_counters.Clone(__e => __e.Clone());
        this.acceleration_structures = o.acceleration_structures.Clone(__e => __e.Clone());
        this.gl_plain_uniforms = o.gl_plain_uniforms.Clone(__e => __e.Clone());
        this.tensors = o.tensors.Clone(__e => __e.Clone());
        this.push_constant_buffers = o.push_constant_buffers.Clone(__e => __e.Clone());
        this.shader_record_buffers = o.shader_record_buffers.Clone(__e => __e.Clone());
        this.separate_images = o.separate_images.Clone(__e => __e.Clone());
        this.separate_samplers = o.separate_samplers.Clone(__e => __e.Clone());
        this.builtin_inputs = o.builtin_inputs.Clone(__e => __e.Clone());
        this.builtin_outputs = o.builtin_outputs.Clone(__e => __e.Clone());
    }
}
