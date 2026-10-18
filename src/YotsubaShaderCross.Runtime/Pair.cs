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

namespace YotsubaShaderCross;

/// <summary>Mirror of std::pair (a class so that map entries can be updated through iterators).</summary>
public sealed class Pair<A, B> : IEquatable<Pair<A, B>>
{
    public A first;
    public B second;
    public Pair() { }
    public Pair(A a, B b) { first = a; second = b; }
    public Pair(Pair<A, B> o) { first = o.first; second = o.second; }

    public Pair<A, B> Clone() => new Pair<A, B>(first, second);
    public Pair<A, B> Clone(Func<A, A> ca, Func<B, B> cb) => new Pair<A, B>(ca != null ? ca(first) : first, cb != null ? cb(second) : second);
    public void CopyFrom(Pair<A, B> o) { first = o.first; second = o.second; }

    public bool Equals(Pair<A, B> o) => o is not null && EqualityComparer<A>.Default.Equals(first, o.first) && EqualityComparer<B>.Default.Equals(second, o.second);
    public override bool Equals(object obj) => obj is Pair<A, B> p && Equals(p);
    public override int GetHashCode() => HashCode.Combine(first, second);
    public static bool operator ==(Pair<A, B> x, Pair<A, B> y) => x is null ? y is null : x.Equals(y);
    public static bool operator !=(Pair<A, B> x, Pair<A, B> y) => !(x == y);
    public static bool operator <(Pair<A, B> x, Pair<A, B> y)
    {
        int c = Comparer<A>.Default.Compare(x.first, y.first);
        return c < 0 || (c == 0 && Comparer<B>.Default.Compare(x.second, y.second) < 0);
    }
    public static bool operator >(Pair<A, B> x, Pair<A, B> y) => y < x;
    public static bool operator <=(Pair<A, B> x, Pair<A, B> y) => !(y < x);
    public static bool operator >=(Pair<A, B> x, Pair<A, B> y) => !(x < y);
}
