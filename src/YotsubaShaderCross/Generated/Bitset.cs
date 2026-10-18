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

public partial class Bitset
{
    public Bitset() { }
    public Bitset(ulong lower_)
    {
        this.lower = lower_;
        this.higher = new UnorderedSet<uint>();
    }
    public bool get(uint bit)
    {
        if (bit < 64u)
        {
            return (lower & 1UL << (int)bit) != 0UL;
        }
        else
        {
            return higher.count(bit) != 0UL;
        }
    }
    public void set(uint bit)
    {
        if (bit < 64u)
        {
            lower |= 1UL << (int)bit;
        }
        else
        {
            higher.insert(bit);
        }
    }
    public void clear(uint bit)
    {
        if (bit < 64u)
        {
            lower &= ~(1UL << (int)bit);
        }
        else
        {
            higher.erase(bit);
        }
    }
    public ulong get_lower()
    {
        return lower;
    }
    public void reset()
    {
        lower = 0UL;
        higher.clear();
    }
    public void merge_and(Bitset other)
    {
        lower &= other.lower;
        UnorderedSet<uint> tmp_set = new UnorderedSet<uint>();
        {
            foreach (uint v in higher)
            {
                if (other.higher.count(v) != 0UL)
                {
                    tmp_set.insert(v);
                }
            }
        }
        higher.CopyFrom(tmp_set);
    }
    public void merge_or(Bitset other)
    {
        lower |= other.lower;
        {
            foreach (uint v in other.higher)
            {
                higher.insert(v);
            }
        }
    }
    public bool operator_eq(Bitset other)
    {
        if (lower != other.lower)
        {
            return false;
        }
        if (higher.size() != other.higher.size())
        {
            return false;
        }
        {
            foreach (uint v in higher)
            {
                if (other.higher.count(v) == 0UL)
                {
                    return false;
                }
            }
        }
        return true;
    }
    public bool operator_ne(Bitset other)
    {
        return !this.operator_eq(other);
    }
    public bool empty()
    {
        return lower == 0UL && higher.empty();
    }
    public ulong lower = 0UL;
    public UnorderedSet<uint> higher = new UnorderedSet<uint>();
    public void for_each_bit__lambda(Action<uint> op)
    {
        {
            for (uint i = 0u; i < 64u; i++)
            {
                if ((lower & 1UL << (int)i) != 0UL)
                {
                    op(i);
                }
            }
        }
        if (higher.empty())
        {
            return;
        }
        CppVector<uint> bits = new CppVector<uint>();
        bits.reserve(higher.size());
        {
            foreach (uint v in higher)
            {
                bits.push_back(v);
            }
        }
        Std.sort(Std.begin(bits), Std.end(bits));
        {
            var __r0 = bits;
            for (int __i1 = 0; __i1 < (int)__r0.size(); __i1++)
            {
                ref uint v = ref __r0[__i1];
                op(v);
            }
        }
    }

    protected virtual void FixClone()
    {
        this.higher = this.higher.Clone();
    }

    public Bitset Clone()
    {
        var __c = (Bitset)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(Bitset o)
    {
        this.lower = o.lower;
        this.higher = o.higher.Clone();
    }

    public override bool Equals(object o) => o is Bitset t && operator_eq(t);
    public override int GetHashCode()
    {
        var h = new System.HashCode();
        h.Add(lower);
        return h.ToHashCode();
    }
}
