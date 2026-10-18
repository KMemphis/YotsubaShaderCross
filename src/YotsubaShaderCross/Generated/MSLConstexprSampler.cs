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
// Upstream sources: spirv_msl.hpp
// Upstream copyright: Copyright 2016-2021 The Brenwill Workshop Ltd.
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class MSLConstexprSampler
{
    public MSLSamplerCoord coord = MSLSamplerCoord.MSL_SAMPLER_COORD_NORMALIZED;
    public MSLSamplerFilter min_filter = MSLSamplerFilter.MSL_SAMPLER_FILTER_NEAREST;
    public MSLSamplerFilter mag_filter = MSLSamplerFilter.MSL_SAMPLER_FILTER_NEAREST;
    public MSLSamplerMipFilter mip_filter = MSLSamplerMipFilter.MSL_SAMPLER_MIP_FILTER_NONE;
    public MSLSamplerAddress s_address = MSLSamplerAddress.MSL_SAMPLER_ADDRESS_CLAMP_TO_EDGE;
    public MSLSamplerAddress t_address = MSLSamplerAddress.MSL_SAMPLER_ADDRESS_CLAMP_TO_EDGE;
    public MSLSamplerAddress r_address = MSLSamplerAddress.MSL_SAMPLER_ADDRESS_CLAMP_TO_EDGE;
    public MSLSamplerCompareFunc compare_func = MSLSamplerCompareFunc.MSL_SAMPLER_COMPARE_FUNC_NEVER;
    public MSLSamplerBorderColor border_color = MSLSamplerBorderColor.MSL_SAMPLER_BORDER_COLOR_TRANSPARENT_BLACK;
    public float lod_clamp_min = 0.0f;
    public float lod_clamp_max = 1000.0f;
    public int max_anisotropy = 1;
    public uint planes = 0u;
    public MSLFormatResolution resolution = MSLFormatResolution.MSL_FORMAT_RESOLUTION_444;
    public MSLSamplerFilter chroma_filter = MSLSamplerFilter.MSL_SAMPLER_FILTER_NEAREST;
    public MSLChromaLocation x_chroma_offset = MSLChromaLocation.MSL_CHROMA_LOCATION_COSITED_EVEN;
    public MSLChromaLocation y_chroma_offset = MSLChromaLocation.MSL_CHROMA_LOCATION_COSITED_EVEN;
    public MSLComponentSwizzle[] swizzle = new MSLComponentSwizzle[4];
    public MSLSamplerYCbCrModelConversion ycbcr_model = MSLSamplerYCbCrModelConversion.MSL_SAMPLER_YCBCR_MODEL_CONVERSION_RGB_IDENTITY;
    public MSLSamplerYCbCrRange ycbcr_range = MSLSamplerYCbCrRange.MSL_SAMPLER_YCBCR_RANGE_ITU_FULL;
    public uint bpc = 8u;
    public bool compare_enable = false;
    public bool lod_clamp_enable = false;
    public bool anisotropy_enable = false;
    public bool ycbcr_conversion_enable = false;
    public MSLConstexprSampler()
    {
        {
            for (uint i = 0u; i < 4u; i++)
            {
                swizzle[i] = MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_IDENTITY;
            }
        }
    }
    public bool swizzle_is_identity()
    {
        return unchecked((int)swizzle[0]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_IDENTITY) && unchecked((int)swizzle[1]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_IDENTITY) && unchecked((int)swizzle[2]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_IDENTITY) && unchecked((int)swizzle[3]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_IDENTITY);
    }
    public bool swizzle_has_one_or_zero()
    {
        return unchecked((int)swizzle[0]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ZERO) || unchecked((int)swizzle[0]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ONE) || unchecked((int)swizzle[1]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ZERO) || unchecked((int)swizzle[1]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ONE) || unchecked((int)swizzle[2]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ZERO) || unchecked((int)swizzle[2]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ONE) || unchecked((int)swizzle[3]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ZERO) || unchecked((int)swizzle[3]) == unchecked((int)MSLComponentSwizzle.MSL_COMPONENT_SWIZZLE_ONE);
    }

    protected virtual void FixClone()
    {
        this.swizzle = Std.clone_array(this.swizzle);
    }

    public MSLConstexprSampler Clone()
    {
        var __c = (MSLConstexprSampler)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(MSLConstexprSampler o)
    {
        this.coord = o.coord;
        this.min_filter = o.min_filter;
        this.mag_filter = o.mag_filter;
        this.mip_filter = o.mip_filter;
        this.s_address = o.s_address;
        this.t_address = o.t_address;
        this.r_address = o.r_address;
        this.compare_func = o.compare_func;
        this.border_color = o.border_color;
        this.lod_clamp_min = o.lod_clamp_min;
        this.lod_clamp_max = o.lod_clamp_max;
        this.max_anisotropy = o.max_anisotropy;
        this.planes = o.planes;
        this.resolution = o.resolution;
        this.chroma_filter = o.chroma_filter;
        this.x_chroma_offset = o.x_chroma_offset;
        this.y_chroma_offset = o.y_chroma_offset;
        this.swizzle = Std.clone_array(o.swizzle);
        this.ycbcr_model = o.ycbcr_model;
        this.ycbcr_range = o.ycbcr_range;
        this.bpc = o.bpc;
        this.compare_enable = o.compare_enable;
        this.lod_clamp_enable = o.lod_clamp_enable;
        this.anisotropy_enable = o.anisotropy_enable;
        this.ycbcr_conversion_enable = o.ycbcr_conversion_enable;
    }
}
