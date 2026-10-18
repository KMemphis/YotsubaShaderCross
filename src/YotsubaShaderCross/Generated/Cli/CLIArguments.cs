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
// Upstream sources: main.cpp
// Upstream copyright: Copyright 2015-2021 Arm Limited
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross.Cli;

public partial class CLIArguments
{
    public string input = null;
    public string output = null;
    public string cpp_interface_name = null;
    public uint version = 0u;
    public uint shader_model = 0u;
    public uint msl_version = 0u;
    public bool es = false;
    public bool set_version = false;
    public bool set_shader_model = false;
    public bool set_msl_version = false;
    public bool set_es = false;
    public bool dump_resources = false;
    public bool force_temporary = false;
    public bool flatten_ubo = false;
    public bool fixup = false;
    public bool yflip = false;
    public bool sso = false;
    public bool support_nonzero_baseinstance = true;
    public bool msl_capture_output_to_buffer = false;
    public bool msl_swizzle_texture_samples = false;
    public bool msl_ios = false;
    public bool msl_pad_fragment_output = false;
    public bool msl_domain_lower_left = false;
    public bool msl_argument_buffers = false;
    public uint msl_argument_buffers_tier = 0u;
    public bool msl_texture_buffer_native = false;
    public bool msl_framebuffer_fetch = false;
    public bool msl_invariant_float_math = false;
    public bool msl_emulate_cube_array = false;
    public bool msl_multiview = false;
    public bool msl_multiview_layered_rendering = true;
    public bool msl_view_index_from_device_index = false;
    public bool msl_dispatch_base = false;
    public bool msl_decoration_binding = false;
    public bool msl_force_active_argument_buffer_resources = false;
    public bool msl_force_native_arrays = false;
    public bool msl_enable_frag_depth_builtin = true;
    public bool msl_enable_frag_stencil_ref_builtin = true;
    public uint msl_enable_frag_output_mask = 4294967295u;
    public bool msl_enable_clip_distance_user_varying = true;
    public bool msl_raw_buffer_tese_input = false;
    public bool msl_multi_patch_workgroup = false;
    public bool msl_vertex_for_tessellation = false;
    public uint msl_additional_fixed_sample_mask = 4294967295u;
    public bool msl_arrayed_subpass_input = false;
    public uint msl_r32ui_linear_texture_alignment = 4u;
    public uint msl_r32ui_alignment_constant_id = 65535u;
    public bool msl_texture_1d_as_2d = false;
    public bool msl_ios_use_simdgroup_functions = false;
    public bool msl_emulate_subgroups = false;
    public uint msl_fixed_subgroup_size = 0u;
    public bool msl_force_sample_rate_shading = false;
    public bool msl_manual_helper_invocation_updates = true;
    public bool msl_check_discarded_frag_stores = false;
    public bool msl_force_fragment_with_side_effects_execution = false;
    public bool msl_emulate_reversed_depth_viewport = false;
    public bool msl_emulate_depth_clip_enable = false;
    public bool msl_sample_dref_lod_array_as_grad = false;
    public bool msl_runtime_array_rich_descriptor = false;
    public bool msl_replace_recursive_inputs = false;
    public bool msl_readwrite_texture_fences = true;
    public bool msl_agx_manual_cube_grad_fixup = false;
    public bool msl_input_attachment_is_ds_attachment = false;
    public bool msl_disable_rasterization = false;
    public bool msl_auto_disable_rasterization = false;
    public bool msl_enable_point_size_default = false;
    public float msl_default_point_size = 1.0f;
    public string msl_combined_sampler_suffix = null;
    public bool glsl_emit_push_constant_as_ubo = false;
    public bool glsl_emit_ubo_as_plain_uniforms = false;
    public bool glsl_force_flattened_io_blocks = false;
    public uint glsl_ovr_multiview_view_count = 0u;
    public CppVector<Pair<uint, uint>> glsl_ext_framebuffer_fetch = new CppVector<Pair<uint, uint>>();
    public bool glsl_ext_framebuffer_fetch_noncoherent = false;
    public uint glsl_descriptor_heap_set = 4294967295u;
    public uint glsl_descriptor_heap_binding = 4294967295u;
    public bool vulkan_glsl_disable_ext_samplerless_texture_functions = false;
    public bool emit_line_directives = false;
    public bool enable_storage_image_qualifier_deduction = true;
    public bool force_zero_initialized_variables = false;
    public bool relax_nan_checks = false;
    public uint force_recompile_max_debug_iterations = 3u;
    public CppVector<uint> msl_discrete_descriptor_sets = new CppVector<uint>();
    public CppVector<uint> msl_device_argument_buffers = new CppVector<uint>();
    public CppVector<Pair<uint, uint>> msl_dynamic_buffers = new CppVector<Pair<uint, uint>>();
    public CppVector<Pair<uint, uint>> msl_inline_uniform_blocks = new CppVector<Pair<uint, uint>>();
    public CppVector<MSLShaderInterfaceVariable> msl_shader_inputs = new CppVector<MSLShaderInterfaceVariable>();
    public CppVector<MSLShaderInterfaceVariable> msl_shader_outputs = new CppVector<MSLShaderInterfaceVariable>();
    public CppVector<Cli.PLSArg> pls_in = new CppVector<Cli.PLSArg>();
    public CppVector<Cli.PLSArg> pls_out = new CppVector<Cli.PLSArg>();
    public CppVector<Cli.Remap> remaps = new CppVector<Cli.Remap>();
    public CppVector<CppString> extensions = new CppVector<CppString>();
    public CppVector<Cli.VariableTypeRemap> variable_type_remaps = new CppVector<Cli.VariableTypeRemap>();
    public CppVector<Cli.InterfaceVariableRename> interface_variable_renames = new CppVector<Cli.InterfaceVariableRename>();
    public CppVector<HLSLVertexAttributeRemap> hlsl_attr_remap = new CppVector<HLSLVertexAttributeRemap>();
    public CppVector<Cli.HLSLVertexAttributeRemapNamed> hlsl_attr_remap_named = new CppVector<Cli.HLSLVertexAttributeRemapNamed>();
    public CppVector<Pair<uint, uint>> masked_stage_outputs = new CppVector<Pair<uint, uint>>();
    public CppVector<Spv.BuiltIn> masked_stage_builtins = new CppVector<Spv.BuiltIn>();
    public CppString entry;
    public CppString entry_stage;
    public CppVector<Cli.CLIArguments.Rename> entry_point_rename = new CppVector<Cli.CLIArguments.Rename>();
    public uint iterations = 1u;
    public bool cpp = false;
    public CppString reflect;
    public bool msl = false;
    public bool hlsl = false;
    public bool hlsl_compat = false;
    public bool hlsl_support_nonzero_base = false;
    public bool hlsl_base_vertex_index_explicit_binding = false;
    public uint hlsl_base_vertex_index_register_index = 0u;
    public uint hlsl_base_vertex_index_register_space = 0u;
    public bool hlsl_force_storage_buffer_as_uav = false;
    public bool hlsl_nonwritable_uav_texture_as_srv = false;
    public bool hlsl_enable_16bit_types = false;
    public bool hlsl_flatten_matrix_vertex_input_semantics = false;
    public bool hlsl_preserve_structured_buffers = false;
    public bool hlsl_user_semantic = false;
    public uint hlsl_binding_flags = 0u;
    public bool vulkan_semantics = false;
    public bool flatten_multidimensional_arrays = false;
    public bool use_420pack_extension = true;
    public bool remove_unused = false;
    public bool combined_samplers_inherit_bindings = false;

    protected virtual void FixClone()
    {
        this.glsl_ext_framebuffer_fetch = this.glsl_ext_framebuffer_fetch.Clone(__e => __e.Clone());
        this.msl_discrete_descriptor_sets = this.msl_discrete_descriptor_sets.Clone();
        this.msl_device_argument_buffers = this.msl_device_argument_buffers.Clone();
        this.msl_dynamic_buffers = this.msl_dynamic_buffers.Clone(__e => __e.Clone());
        this.msl_inline_uniform_blocks = this.msl_inline_uniform_blocks.Clone(__e => __e.Clone());
        this.msl_shader_inputs = this.msl_shader_inputs.Clone(__e => __e.Clone());
        this.msl_shader_outputs = this.msl_shader_outputs.Clone(__e => __e.Clone());
        this.pls_in = this.pls_in.Clone(__e => __e.Clone());
        this.pls_out = this.pls_out.Clone(__e => __e.Clone());
        this.remaps = this.remaps.Clone(__e => __e.Clone());
        this.extensions = this.extensions.Clone();
        this.variable_type_remaps = this.variable_type_remaps.Clone(__e => __e.Clone());
        this.interface_variable_renames = this.interface_variable_renames.Clone(__e => __e.Clone());
        this.hlsl_attr_remap = this.hlsl_attr_remap.Clone(__e => __e.Clone());
        this.hlsl_attr_remap_named = this.hlsl_attr_remap_named.Clone(__e => __e.Clone());
        this.masked_stage_outputs = this.masked_stage_outputs.Clone(__e => __e.Clone());
        this.masked_stage_builtins = this.masked_stage_builtins.Clone();
        this.entry_point_rename = this.entry_point_rename.Clone(__e => __e.Clone());
    }

    public CLIArguments Clone()
    {
        var __c = (CLIArguments)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(CLIArguments o)
    {
        this.input = o.input;
        this.output = o.output;
        this.cpp_interface_name = o.cpp_interface_name;
        this.version = o.version;
        this.shader_model = o.shader_model;
        this.msl_version = o.msl_version;
        this.es = o.es;
        this.set_version = o.set_version;
        this.set_shader_model = o.set_shader_model;
        this.set_msl_version = o.set_msl_version;
        this.set_es = o.set_es;
        this.dump_resources = o.dump_resources;
        this.force_temporary = o.force_temporary;
        this.flatten_ubo = o.flatten_ubo;
        this.fixup = o.fixup;
        this.yflip = o.yflip;
        this.sso = o.sso;
        this.support_nonzero_baseinstance = o.support_nonzero_baseinstance;
        this.msl_capture_output_to_buffer = o.msl_capture_output_to_buffer;
        this.msl_swizzle_texture_samples = o.msl_swizzle_texture_samples;
        this.msl_ios = o.msl_ios;
        this.msl_pad_fragment_output = o.msl_pad_fragment_output;
        this.msl_domain_lower_left = o.msl_domain_lower_left;
        this.msl_argument_buffers = o.msl_argument_buffers;
        this.msl_argument_buffers_tier = o.msl_argument_buffers_tier;
        this.msl_texture_buffer_native = o.msl_texture_buffer_native;
        this.msl_framebuffer_fetch = o.msl_framebuffer_fetch;
        this.msl_invariant_float_math = o.msl_invariant_float_math;
        this.msl_emulate_cube_array = o.msl_emulate_cube_array;
        this.msl_multiview = o.msl_multiview;
        this.msl_multiview_layered_rendering = o.msl_multiview_layered_rendering;
        this.msl_view_index_from_device_index = o.msl_view_index_from_device_index;
        this.msl_dispatch_base = o.msl_dispatch_base;
        this.msl_decoration_binding = o.msl_decoration_binding;
        this.msl_force_active_argument_buffer_resources = o.msl_force_active_argument_buffer_resources;
        this.msl_force_native_arrays = o.msl_force_native_arrays;
        this.msl_enable_frag_depth_builtin = o.msl_enable_frag_depth_builtin;
        this.msl_enable_frag_stencil_ref_builtin = o.msl_enable_frag_stencil_ref_builtin;
        this.msl_enable_frag_output_mask = o.msl_enable_frag_output_mask;
        this.msl_enable_clip_distance_user_varying = o.msl_enable_clip_distance_user_varying;
        this.msl_raw_buffer_tese_input = o.msl_raw_buffer_tese_input;
        this.msl_multi_patch_workgroup = o.msl_multi_patch_workgroup;
        this.msl_vertex_for_tessellation = o.msl_vertex_for_tessellation;
        this.msl_additional_fixed_sample_mask = o.msl_additional_fixed_sample_mask;
        this.msl_arrayed_subpass_input = o.msl_arrayed_subpass_input;
        this.msl_r32ui_linear_texture_alignment = o.msl_r32ui_linear_texture_alignment;
        this.msl_r32ui_alignment_constant_id = o.msl_r32ui_alignment_constant_id;
        this.msl_texture_1d_as_2d = o.msl_texture_1d_as_2d;
        this.msl_ios_use_simdgroup_functions = o.msl_ios_use_simdgroup_functions;
        this.msl_emulate_subgroups = o.msl_emulate_subgroups;
        this.msl_fixed_subgroup_size = o.msl_fixed_subgroup_size;
        this.msl_force_sample_rate_shading = o.msl_force_sample_rate_shading;
        this.msl_manual_helper_invocation_updates = o.msl_manual_helper_invocation_updates;
        this.msl_check_discarded_frag_stores = o.msl_check_discarded_frag_stores;
        this.msl_force_fragment_with_side_effects_execution = o.msl_force_fragment_with_side_effects_execution;
        this.msl_emulate_reversed_depth_viewport = o.msl_emulate_reversed_depth_viewport;
        this.msl_emulate_depth_clip_enable = o.msl_emulate_depth_clip_enable;
        this.msl_sample_dref_lod_array_as_grad = o.msl_sample_dref_lod_array_as_grad;
        this.msl_runtime_array_rich_descriptor = o.msl_runtime_array_rich_descriptor;
        this.msl_replace_recursive_inputs = o.msl_replace_recursive_inputs;
        this.msl_readwrite_texture_fences = o.msl_readwrite_texture_fences;
        this.msl_agx_manual_cube_grad_fixup = o.msl_agx_manual_cube_grad_fixup;
        this.msl_input_attachment_is_ds_attachment = o.msl_input_attachment_is_ds_attachment;
        this.msl_disable_rasterization = o.msl_disable_rasterization;
        this.msl_auto_disable_rasterization = o.msl_auto_disable_rasterization;
        this.msl_enable_point_size_default = o.msl_enable_point_size_default;
        this.msl_default_point_size = o.msl_default_point_size;
        this.msl_combined_sampler_suffix = o.msl_combined_sampler_suffix;
        this.glsl_emit_push_constant_as_ubo = o.glsl_emit_push_constant_as_ubo;
        this.glsl_emit_ubo_as_plain_uniforms = o.glsl_emit_ubo_as_plain_uniforms;
        this.glsl_force_flattened_io_blocks = o.glsl_force_flattened_io_blocks;
        this.glsl_ovr_multiview_view_count = o.glsl_ovr_multiview_view_count;
        this.glsl_ext_framebuffer_fetch = o.glsl_ext_framebuffer_fetch.Clone(__e => __e.Clone());
        this.glsl_ext_framebuffer_fetch_noncoherent = o.glsl_ext_framebuffer_fetch_noncoherent;
        this.glsl_descriptor_heap_set = o.glsl_descriptor_heap_set;
        this.glsl_descriptor_heap_binding = o.glsl_descriptor_heap_binding;
        this.vulkan_glsl_disable_ext_samplerless_texture_functions = o.vulkan_glsl_disable_ext_samplerless_texture_functions;
        this.emit_line_directives = o.emit_line_directives;
        this.enable_storage_image_qualifier_deduction = o.enable_storage_image_qualifier_deduction;
        this.force_zero_initialized_variables = o.force_zero_initialized_variables;
        this.relax_nan_checks = o.relax_nan_checks;
        this.force_recompile_max_debug_iterations = o.force_recompile_max_debug_iterations;
        this.msl_discrete_descriptor_sets = o.msl_discrete_descriptor_sets.Clone();
        this.msl_device_argument_buffers = o.msl_device_argument_buffers.Clone();
        this.msl_dynamic_buffers = o.msl_dynamic_buffers.Clone(__e => __e.Clone());
        this.msl_inline_uniform_blocks = o.msl_inline_uniform_blocks.Clone(__e => __e.Clone());
        this.msl_shader_inputs = o.msl_shader_inputs.Clone(__e => __e.Clone());
        this.msl_shader_outputs = o.msl_shader_outputs.Clone(__e => __e.Clone());
        this.pls_in = o.pls_in.Clone(__e => __e.Clone());
        this.pls_out = o.pls_out.Clone(__e => __e.Clone());
        this.remaps = o.remaps.Clone(__e => __e.Clone());
        this.extensions = o.extensions.Clone();
        this.variable_type_remaps = o.variable_type_remaps.Clone(__e => __e.Clone());
        this.interface_variable_renames = o.interface_variable_renames.Clone(__e => __e.Clone());
        this.hlsl_attr_remap = o.hlsl_attr_remap.Clone(__e => __e.Clone());
        this.hlsl_attr_remap_named = o.hlsl_attr_remap_named.Clone(__e => __e.Clone());
        this.masked_stage_outputs = o.masked_stage_outputs.Clone(__e => __e.Clone());
        this.masked_stage_builtins = o.masked_stage_builtins.Clone();
        this.entry = o.entry;
        this.entry_stage = o.entry_stage;
        this.entry_point_rename = o.entry_point_rename.Clone(__e => __e.Clone());
        this.iterations = o.iterations;
        this.cpp = o.cpp;
        this.reflect = o.reflect;
        this.msl = o.msl;
        this.hlsl = o.hlsl;
        this.hlsl_compat = o.hlsl_compat;
        this.hlsl_support_nonzero_base = o.hlsl_support_nonzero_base;
        this.hlsl_base_vertex_index_explicit_binding = o.hlsl_base_vertex_index_explicit_binding;
        this.hlsl_base_vertex_index_register_index = o.hlsl_base_vertex_index_register_index;
        this.hlsl_base_vertex_index_register_space = o.hlsl_base_vertex_index_register_space;
        this.hlsl_force_storage_buffer_as_uav = o.hlsl_force_storage_buffer_as_uav;
        this.hlsl_nonwritable_uav_texture_as_srv = o.hlsl_nonwritable_uav_texture_as_srv;
        this.hlsl_enable_16bit_types = o.hlsl_enable_16bit_types;
        this.hlsl_flatten_matrix_vertex_input_semantics = o.hlsl_flatten_matrix_vertex_input_semantics;
        this.hlsl_preserve_structured_buffers = o.hlsl_preserve_structured_buffers;
        this.hlsl_user_semantic = o.hlsl_user_semantic;
        this.hlsl_binding_flags = o.hlsl_binding_flags;
        this.vulkan_semantics = o.vulkan_semantics;
        this.flatten_multidimensional_arrays = o.flatten_multidimensional_arrays;
        this.use_420pack_extension = o.use_420pack_extension;
        this.remove_unused = o.remove_unused;
        this.combined_samplers_inherit_bindings = o.combined_samplers_inherit_bindings;
    }

    public partial class Rename
    {
        public CppString old_name;
        public CppString new_name;
        public Spv.ExecutionModel execution_model;

        protected virtual void FixClone()
        {
        }

        public Rename Clone()
        {
            var __c = (Rename)MemberwiseClone();
            __c.FixClone();
            return __c;
        }

        public void CopyFrom(Rename o)
        {
            this.old_name = o.old_name;
            this.new_name = o.new_name;
            this.execution_model = o.execution_model;
        }
    }
}
