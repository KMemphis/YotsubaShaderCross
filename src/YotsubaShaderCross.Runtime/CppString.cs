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

using System.Globalization;
using System.Text;

namespace YotsubaShaderCross;

/// <summary>Value-semantics mirror of std::string (immutable payload, mutation rebinds the struct).</summary>
public struct CppString : IEquatable<CppString>, IComparable<CppString>
{
    string s;

    public const ulong npos = ulong.MaxValue;

    public CppString(string v) { s = v ?? ""; }
    public CppString(Ptr<char> p) { s = Std.from_c_buffer(p).str(); }
    public CppString(string v, ulong n) { s = (v ?? "").Substring(0, (int)Math.Min(n, (ulong)(v ?? "").Length)); }
    public CppString(ulong n, char c) { s = new string(c, (int)n); }
    public CppString(CppString other) { s = other.s ?? ""; }
    public CppString(CppString other, ulong pos, ulong len = npos) { s = other.substr(pos, len).s; }

    public static implicit operator CppString(string v) => new CppString(v);
    public static implicit operator string(CppString v) => v.s ?? "";

    string S => s ?? "";
    public override string ToString() => S;
    public string str() => S;

    public ulong size() => (ulong)S.Length;
    public ulong length() => (ulong)S.Length;
    public bool empty() => S.Length == 0;
    public string c_str() => S;
    public string data() => S;
    public ulong capacity() => (ulong)S.Length;
    public void reserve(ulong n) { }
    public void shrink_to_fit() { }
    public void clear() { s = ""; }

    public char this[ulong i]
    {
        get => (int)i == S.Length ? '\0' : S[(int)i];
        set { var a = S.ToCharArray(); a[(int)i] = value; s = new string(a); }
    }
    public char this[int i]
    {
        get => i == S.Length ? '\0' : S[i];
        set { var a = S.ToCharArray(); a[i] = value; s = new string(a); }
    }
    public char this[uint i]
    {
        get => (int)i == S.Length ? '\0' : S[(int)i];
        set { var a = S.ToCharArray(); a[(int)i] = value; s = new string(a); }
    }
    public char at(ulong i) => S[(int)i];
    public char back() => S[S.Length - 1];
    public char front() => S[0];

    public void push_back(char c) { s = S + c; }
    public void pop_back() { s = S.Substring(0, S.Length - 1); }

    public CppString append(CppString o) { s = S + o.S; return this; }
    public CppString append(string o) { s = S + o; return this; }
    public CppString append(char c) { s = S + c; return this; }
    public CppString append(ulong n, char c) { s = S + new string(c, (int)n); return this; }
    public CppString append(string o, ulong n) { s = S + o.Substring(0, (int)n); return this; }
    public CppString append(CppString o, ulong pos, ulong n = npos) { s = S + o.substr(pos, n).S; return this; }

    public CppString assign(CppString o) { s = o.S; return this; }
    public CppString assign(string o) { s = o; return this; }
    public CppString assign(ulong n, char c) { s = new string(c, (int)n); return this; }

    public static CppString operator +(CppString a, CppString b) => new CppString(a.S + b.S);
    public static CppString operator +(CppString a, string b) => new CppString(a.S + b);
    public static CppString operator +(string a, CppString b) => new CppString(a + b.S);
    public static CppString operator +(CppString a, char b) => new CppString(a.S + b);
    public static CppString operator +(char a, CppString b) => new CppString(a + b.S);

    public CppString substr(ulong pos = 0, ulong len = npos)
    {
        if (pos > (ulong)S.Length) throw new ArgumentOutOfRangeException("substr");
        ulong avail = (ulong)S.Length - pos;
        return new CppString(S.Substring((int)pos, (int)Math.Min(len, avail)));
    }

    public ulong find(CppString needle, ulong pos = 0) => Find(needle.S, pos);
    public ulong find(string needle, ulong pos = 0) => Find(needle, pos);
    public ulong find(char c, ulong pos = 0)
    {
        if (pos >= (ulong)S.Length) return npos;
        int i = S.IndexOf(c, (int)pos);
        return i < 0 ? npos : (ulong)i;
    }
    ulong Find(string n, ulong pos)
    {
        if (pos > (ulong)S.Length) return npos;
        int i = S.IndexOf(n, (int)pos, StringComparison.Ordinal);
        return i < 0 ? npos : (ulong)i;
    }
    public ulong rfind(CppString needle, ulong pos = npos) => RFind(needle.S, pos);
    public ulong rfind(string needle, ulong pos = npos) => RFind(needle, pos);
    public ulong rfind(char c, ulong pos = npos)
    {
        if (S.Length == 0) return npos;
        int start = (int)Math.Min(pos, (ulong)(S.Length - 1));
        int i = S.LastIndexOf(c, start);
        return i < 0 ? npos : (ulong)i;
    }
    ulong RFind(string n, ulong pos)
    {
        if (n.Length > S.Length) return npos;
        int start = (int)Math.Min(pos, (ulong)(S.Length - n.Length));
        for (int i = start; i >= 0; i--)
            if (string.CompareOrdinal(S, i, n, 0, n.Length) == 0) return (ulong)i;
        return npos;
    }

    public ulong find_first_of(string set, ulong pos = 0)
    {
        for (int i = (int)pos; i < S.Length; i++) if (set.IndexOf(S[i]) >= 0) return (ulong)i;
        return npos;
    }
    public ulong find_first_of(char c, ulong pos = 0) => find(c, pos);
    public ulong find_first_not_of(string set, ulong pos = 0)
    {
        for (int i = (int)pos; i < S.Length; i++) if (set.IndexOf(S[i]) < 0) return (ulong)i;
        return npos;
    }
    public ulong find_first_not_of(char c, ulong pos = 0)
    {
        for (int i = (int)pos; i < S.Length; i++) if (S[i] != c) return (ulong)i;
        return npos;
    }
    public ulong find_last_of(string set, ulong pos = npos)
    {
        for (int i = (int)Math.Min(pos, (ulong)(S.Length - 1)); i >= 0; i--) if (set.IndexOf(S[i]) >= 0) return (ulong)i;
        return npos;
    }
    public ulong find_last_of(char c, ulong pos = npos) => rfind(c, pos);
    public ulong find_last_not_of(string set, ulong pos = npos)
    {
        for (int i = (int)Math.Min(pos, (ulong)(S.Length - 1)); i >= 0; i--) if (set.IndexOf(S[i]) < 0) return (ulong)i;
        return npos;
    }
    public ulong find_last_not_of(char c, ulong pos = npos)
    {
        for (int i = (int)Math.Min(pos, (ulong)(S.Length - 1)); i >= 0; i--) if (S[i] != c) return (ulong)i;
        return npos;
    }

    public int compare(CppString o) => Math.Sign(string.CompareOrdinal(S, o.S));
    public int compare(string o) => Math.Sign(string.CompareOrdinal(S, o));
    public int compare(ulong pos, ulong len, CppString o) => substr(pos, len).compare(o);
    public int compare(ulong pos, ulong len, string o) => substr(pos, len).compare(o);
    public int compare(ulong pos, ulong len, string o, ulong n) => substr(pos, len).compare(o.Substring(0, (int)Math.Min(n, (ulong)o.Length)));

    public CppString erase(ulong pos = 0, ulong len = npos)
    {
        ulong avail = (ulong)S.Length - pos;
        s = S.Remove((int)pos, (int)Math.Min(len, avail));
        return this;
    }
    public StrIter erase(StrIter it) { s = S.Remove((int)it.i, 1); return it; }
    public StrIter erase(StrIter first, StrIter last) { s = S.Remove((int)first.i, (int)(last.i - first.i)); return first; }

    public CppString insert(ulong pos, CppString o) { s = S.Insert((int)pos, o.S); return this; }
    public CppString insert(ulong pos, string o) { s = S.Insert((int)pos, o); return this; }
    public CppString insert(ulong pos, ulong n, char c) { s = S.Insert((int)pos, new string(c, (int)n)); return this; }
    public StrIter insert(StrIter it, char c) { s = S.Insert((int)it.i, c.ToString()); return it; }

    public CppString replace(ulong pos, ulong len, CppString o)
    {
        ulong avail = (ulong)S.Length - pos;
        s = S.Remove((int)pos, (int)Math.Min(len, avail)).Insert((int)pos, o.S);
        return this;
    }
    public CppString replace(ulong pos, ulong len, string o) => replace(pos, len, new CppString(o));

    public void resize(ulong n, char c = '\0')
    {
        if ((ulong)S.Length >= n) s = S.Substring(0, (int)n);
        else s = S + new string(c, (int)(n - (ulong)S.Length));
    }

    public void swap(ref CppString o) { var t = s; s = o.s; o.s = t; }

    public StrIter begin() => new StrIter(this, 0);
    public StrIter end() => new StrIter(this, size());

    public CppString Clone() => this;

    public bool Equals(CppString o) => string.Equals(S, o.S, StringComparison.Ordinal);
    public override bool Equals(object obj) => obj is CppString o && Equals(o);
    public override int GetHashCode() => S.GetHashCode();
    public int CompareTo(CppString o) => string.CompareOrdinal(S, o.S);

    public static bool operator ==(CppString a, CppString b) => string.Equals(a.S, b.S, StringComparison.Ordinal);
    public static bool operator !=(CppString a, CppString b) => !(a == b);
    public static bool operator ==(CppString a, string b) => string.Equals(a.S, b ?? "", StringComparison.Ordinal);
    public static bool operator !=(CppString a, string b) => !(a == b);
    public static bool operator ==(string a, CppString b) => b == a;
    public static bool operator !=(string a, CppString b) => !(b == a);
    public static bool operator <(CppString a, CppString b) => string.CompareOrdinal(a.S, b.S) < 0;
    public static bool operator >(CppString a, CppString b) => string.CompareOrdinal(a.S, b.S) > 0;
    public static bool operator <=(CppString a, CppString b) => string.CompareOrdinal(a.S, b.S) <= 0;
    public static bool operator >=(CppString a, CppString b) => string.CompareOrdinal(a.S, b.S) >= 0;

    public IEnumerator<char> GetEnumerator() { foreach (char c in S) yield return c; }
}

/// <summary>Index based iterator over a CppString.</summary>
public struct StrIter
{
    internal CppString str;
    internal ulong i;
    public StrIter(CppString s, ulong idx) { str = s; i = idx; }
    public char deref() => str[i];
    public static StrIter operator ++(StrIter a) { a.i++; return a; }
    public static StrIter operator --(StrIter a) { a.i--; return a; }
    public static StrIter operator +(StrIter a, long n) { a.i = (ulong)((long)a.i + n); return a; }
    public static StrIter operator -(StrIter a, long n) { a.i = (ulong)((long)a.i - n); return a; }
    public static long operator -(StrIter a, StrIter b) => (long)a.i - (long)b.i;
    public static bool operator ==(StrIter a, StrIter b) => a.i == b.i;
    public static bool operator !=(StrIter a, StrIter b) => a.i != b.i;
    public override bool Equals(object o) => o is StrIter b && b.i == i;
    public override int GetHashCode() => (int)i;
}
