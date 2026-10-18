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
using System.Runtime.CompilerServices;

namespace YotsubaShaderCross;

/// <summary>Subset of the C++ standard library used by SPIRV-Cross.</summary>
public static partial class Std
{
    public static T make_default<T>()
    {
        if (typeof(T) == typeof(string)) return default;
        if (typeof(T).IsValueType) return default;
        if (typeof(T).GetConstructor(Type.EmptyTypes) != null) return Activator.CreateInstance<T>();
        return default;
    }

    public static T[] new_array<T>(ulong n)
    {
        var a = new T[n];
        if (!typeof(T).IsValueType && typeof(T) != typeof(string) && typeof(T).GetConstructor(Type.EmptyTypes) != null)
            for (ulong i = 0; i < n; i++) a[i] = Activator.CreateInstance<T>();
        return a;
    }
    public static T[] new_array<T>(int n) => new_array<T>((ulong)n);
    public static T[] new_array<T>(uint n) => new_array<T>((ulong)n);

    public static T[] clone_array<T>(T[] a) => (T[])a.Clone();
    public static T[] clone_array<T>(T[] a, Func<T, T> c)
    {
        var r = new T[a.Length];
        for (int i = 0; i < a.Length; i++) r[i] = c(a[i]);
        return r;
    }

    public static ulong sizeof_<T>() => (ulong)Unsafe.SizeOf<T>();
    public static ulong alignof<T>() => 8;

    public static T move<T>(T v) => v;
    public static T forward<T>(T v) => v;

    public static T min<T>(T a, T b) where T : IComparable<T> => b.CompareTo(a) < 0 ? b : a;
    public static T max<T>(T a, T b) where T : IComparable<T> => a.CompareTo(b) < 0 ? b : a;
    public static void swap<T>(ref T a, ref T b) { var t = a; a = b; b = t; }

    public static VecIter<T> begin<T>(CppVector<T> v) => v.begin();
    public static VecIter<T> end<T>(CppVector<T> v) => v.end();
    public static MapIter<K, V> end<K, V>(UnorderedMap<K, V> m) => m.end();
    public static MapIter<K, V> begin<K, V>(UnorderedMap<K, V> m) => m.begin();
    public static SetIter<T> end<T>(UnorderedSet<T> m) => m.end();
    public static SetIter<T> begin<T>(UnorderedSet<T> m) => m.begin();

    public static void sort<T>(VecIter<T> first, VecIter<T> last)
        => System.Array.Sort(first.v.a, first.i, last.i - first.i);
    public static void sort<T>(VecIter<T> first, VecIter<T> last, Func<T, T, bool> less)
        => System.Array.Sort(first.v.a, first.i, last.i - first.i, Comparer<T>.Create((x, y) => less(x, y) ? -1 : less(y, x) ? 1 : 0));
    public static void stable_sort<T>(VecIter<T> first, VecIter<T> last, Func<T, T, bool> less)
    {
        var tmp = first.v.a.Skip(first.i).Take(last.i - first.i).ToList();
        var sorted = tmp.Select((v, i) => (v, i)).OrderBy(x => x, Comparer<(T v, int i)>.Create((x, y) => less(x.v, y.v) ? -1 : less(y.v, x.v) ? 1 : x.i.CompareTo(y.i))).Select(x => x.v).ToList();
        for (int i = 0; i < sorted.Count; i++) first.v.a[first.i + i] = sorted[i];
    }

    public static VecIter<T> unique<T>(VecIter<T> first, VecIter<T> last)
    {
        if (first.i == last.i) return last;
        var cmp = EqualityComparer<T>.Default;
        var r = first;
        while ((++first).i != last.i)
            if (!cmp.Equals(r.v.a[r.i], first.v.a[first.i])) { r.i++; r.v.a[r.i] = first.v.a[first.i]; }
        r.i++;
        return r;
    }
    public static void reverse<T>(VecIter<T> first, VecIter<T> last) => System.Array.Reverse(first.v.a, first.i, last.i - first.i);
    public static void fill<T>(VecIter<T> first, VecIter<T> last, T v) { for (; first.i < last.i; first.i++) first.v.a[first.i] = v; }
    public static ulong count<T>(VecIter<T> first, VecIter<T> last, T value)
    {
        ulong n = 0; var cmp = EqualityComparer<T>.Default;
        for (; first.i < last.i; first.i++) if (cmp.Equals(first.v.a[first.i], value)) n++;
        return n;
    }

    public static CppString to_string(int v) => new CppString(v.ToString(CultureInfo.InvariantCulture));
    public static CppString to_string(uint v) => new CppString(v.ToString(CultureInfo.InvariantCulture));
    public static CppString to_string(long v) => new CppString(v.ToString(CultureInfo.InvariantCulture));
    public static CppString to_string(ulong v) => new CppString(v.ToString(CultureInfo.InvariantCulture));
    public static CppString to_string(short v) => to_string((int)v);
    public static CppString to_string(ushort v) => to_string((int)v);
    public static CppString to_string(byte v) => to_string((int)v);

    public static int stoi(CppString s) => int.Parse(s.str(), CultureInfo.InvariantCulture);
    public static ulong strlen(string s) => (ulong)(s ?? "").Length;

    public static T numeric_max<T>() => (T)typeof(T).GetField("MaxValue").GetValue(null);
    public static T numeric_min<T>() => (T)typeof(T).GetField("MinValue").GetValue(null);
    public static T numeric_lowest<T>() => numeric_min<T>();
    public static float numeric_infinity_f() => float.PositiveInfinity;
}

public static partial class Std
{
    public static ulong hash(uint v) => v;
    public static ulong hash(int v) => (ulong)v;
    public static ulong hash(ulong v) => v;
    public static ulong hash(long v) => (ulong)v;
    public static ulong hash<T>(T v) => (ulong)(v?.GetHashCode() ?? 0);
}

public static partial class Std
{
    public static T numeric_max<T>(int _) => numeric_max<T>();
    public static T numeric_epsilon<T>() => typeof(T) == typeof(float) ? (T)(object)1.1920929e-7f : (T)(object)2.220446049250313e-16;
    public static T numeric_infinity<T>() => typeof(T) == typeof(float) ? (T)(object)float.PositiveInfinity : (T)(object)double.PositiveInfinity;
    public static T numeric_quiet_NaN<T>() => typeof(T) == typeof(float) ? (T)(object)float.NaN : (T)(object)double.NaN;

    // ---- C string helpers working on Ptr<char> buffers
    public static ulong strlen(Ptr<char> p) { ulong n = 0; while (p[(long)n] != '\0') n++; return n; }
    public static Ptr<char> strchr(Ptr<char> p, int c)
    {
        for (long i = 0; ; i++)
        {
            if (p[i] == (char)c) return p + i;
            if (p[i] == '\0') return null;
        }
    }
    public static Ptr<char> strcat(Ptr<char> dst, string src)
    {
        long n = 0; while (dst[n] != '\0') n++;
        foreach (char c in src) dst[n++] = c;
        dst[n] = '\0';
        return dst;
    }
    public static CppString from_c_buffer(Ptr<char> p)
    {
        var sb = new System.Text.StringBuilder();
        for (long i = 0; p[i] != '\0'; i++) sb.Append(p[i]);
        return new CppString(sb.ToString());
    }
}

public static partial class Std
{
    /// <summary>Bit-level copy between typed pointers (the memcpy float/uint punning idiom).</summary>
    public static object memcpy(object dst, object src, ulong n)
    {
        var bytes = ReadBytes(src, (int)n);
        WriteBytes(dst, bytes);
        return dst;
    }

    static byte[] ReadBytes(object p, int n)
    {
        switch (p)
        {
            case Ptr<float> pf: return BitConverter.GetBytes(pf[0]);
            case Ptr<uint> pu: return Gather(pu, n, 4, i => BitConverter.GetBytes(pu[i]));
            case Ptr<int> pi: return Gather(pi, n, 4, i => BitConverter.GetBytes(pi[i]));
            case Ptr<double> pd: return BitConverter.GetBytes(pd[0]);
            case Ptr<ulong> pul: return Gather(pul, n, 8, i => BitConverter.GetBytes(pul[i]));
            case Ptr<long> pl: return Gather(pl, n, 8, i => BitConverter.GetBytes(pl[i]));
            case Ptr<ushort> ps: return Gather(ps, n, 2, i => BitConverter.GetBytes(ps[i]));
            case Ptr<short> psh: return Gather(psh, n, 2, i => BitConverter.GetBytes(psh[i]));
            case Ptr<byte> pb: { var r = new byte[n]; for (int i = 0; i < n; i++) r[i] = pb[i]; return r; }
            case Ptr<char> pc: { var r = new byte[n]; for (int i = 0; i < n; i++) r[i] = (byte)pc[i]; return r; }
        }
        throw new NotSupportedException("memcpy source " + p?.GetType());
    }

    static byte[] Gather(object _, int n, int size, Func<long, byte[]> get)
    {
        var r = new byte[n];
        for (int i = 0; i * size < n; i++) Array.Copy(get(i), 0, r, i * size, Math.Min(size, n - i * size));
        return r;
    }

    static void WriteBytes(object p, byte[] b)
    {
        switch (p)
        {
            case Ptr<float> pf: pf[0] = BitConverter.ToSingle(b, 0); return;
            case Ptr<double> pd: pd[0] = BitConverter.ToDouble(b, 0); return;
            case Ptr<uint> pu: for (int i = 0; i * 4 < b.Length; i++) pu[i] = BitConverter.ToUInt32(b, i * 4); return;
            case Ptr<int> pi: for (int i = 0; i * 4 < b.Length; i++) pi[i] = BitConverter.ToInt32(b, i * 4); return;
            case Ptr<ulong> pul: for (int i = 0; i * 8 < b.Length; i++) pul[i] = BitConverter.ToUInt64(b, i * 8); return;
            case Ptr<long> pl: for (int i = 0; i * 8 < b.Length; i++) pl[i] = BitConverter.ToInt64(b, i * 8); return;
            case Ptr<ushort> ps: for (int i = 0; i * 2 < b.Length; i++) ps[i] = BitConverter.ToUInt16(b, i * 2); return;
            case Ptr<short> psh: for (int i = 0; i * 2 < b.Length; i++) psh[i] = BitConverter.ToInt16(b, i * 2); return;
            case Ptr<byte> pb: for (int i = 0; i < b.Length; i++) pb[i] = b[i]; return;
            case Ptr<char> pc: for (int i = 0; i < b.Length; i++) pc[i] = (char)b[i]; return;
        }
        throw new NotSupportedException("memcpy destination " + p?.GetType());
    }

    public static object memset(object dst, int value, ulong n)
    {
        var t = dst.GetType();
        if (t.IsGenericType && t.GetGenericTypeDefinition() == typeof(ArrayPtr<>) && value == 0)
        {
            // clear whole elements of a struct array
            var elem = t.GetGenericArguments()[0];
            int size = System.Runtime.InteropServices.Marshal.SizeOf(elem);
            var arr = (Array)t.GetField("Array").GetValue(dst);
            long index = (long)t.GetField("Index").GetValue(dst);
            Array.Clear(arr, (int)index, (int)Math.Min((ulong)(arr.Length - index), (n + (ulong)size - 1) / (ulong)size));
            return dst;
        }
        WriteBytes(dst, Enumerable.Repeat((byte)value, (int)n).ToArray());
        return dst;
    }

    public static T reinterpret<T>(object o) => (T)o;
}

public static partial class Std
{
    public static ulong sizeof_expr<T>(T v)
    {
        if (v is Array a) return (ulong)a.Length * ElemSize(a.GetType().GetElementType());
        return ElemSize(typeof(T));
    }

    static ulong ElemSize(Type t)
    {
        if (!t.IsValueType) return 8;                        // pointers / references
        try { return (ulong)System.Runtime.InteropServices.Marshal.SizeOf(t); }
        catch { return (ulong)System.Runtime.CompilerServices.Unsafe.SizeOf<byte>() * 8; }
    }
}

public static partial class Std
{
    public static Pair<A, B> make_pair<A, B>(A a, B b) => new Pair<A, B>(a, b);

    public static bool isnan(float v) => float.IsNaN(v);
    public static bool isnan(double v) => double.IsNaN(v);
    public static bool isinf(float v) => float.IsInfinity(v);
    public static bool isinf(double v) => double.IsInfinity(v);
    public static int isdigit(int c) => c >= '0' && c <= '9' ? 1 : 0;
    public static int isalpha(int c) => char.IsLetter((char)c) && c < 128 ? 1 : 0;
    public static int isalnum(int c) => char.IsLetterOrDigit((char)c) && c < 128 ? 1 : 0;
    public static int isspace(int c) => c is ' ' or '\t' or '\n' or '\v' or '\f' or '\r' ? 1 : 0;
    public static int isupper(int c) => c >= 'A' && c <= 'Z' ? 1 : 0;
    public static int islower(int c) => c >= 'a' && c <= 'z' ? 1 : 0;
    public static int toupper(int c) => c >= 'a' && c <= 'z' ? c - 32 : c;
    public static int tolower(int c) => c >= 'A' && c <= 'Z' ? c + 32 : c;

    public static int strcmp(string a, string b) => Math.Sign(string.CompareOrdinal(a, b));
    public static int strcmp(Ptr<char> a, string b) => strcmp(from_c_buffer(a).str(), b);

    public static int memcmp(object a, object b, ulong n)
    {
        if (a is Ptr<uint> pa && b is Ptr<uint> pb)
        {
            for (long i = 0; i < (long)n / 4; i++) { int c = pa[i].CompareTo(pb[i]); if (c != 0) return c; }
            return 0;
        }
        if (a == null || b == null) return a == b ? 0 : 1;
        // structs / classes: compare public instance fields
        foreach (var f in a.GetType().GetFields())
        {
            var va = f.GetValue(a); var vb = f.GetValue(b);
            if (!Equals(va, vb)) return Comparer<object>.Default.Compare(va, vb) is var c && c != 0 ? c : 1;
        }
        return 0;
    }

    public sealed class Tie<A, B> : IComparable<Tie<A, B>>
    {
        public A a; public B b;
        public Tie(A a, B b) { this.a = a; this.b = b; }
        public int CompareTo(Tie<A, B> o) { int c = Comparer<A>.Default.Compare(a, o.a); return c != 0 ? c : Comparer<B>.Default.Compare(b, o.b); }
        public static bool operator <(Tie<A, B> x, Tie<A, B> y) => x.CompareTo(y) < 0;
        public static bool operator >(Tie<A, B> x, Tie<A, B> y) => x.CompareTo(y) > 0;
    }
    public static Tie<A, B> tie<A, B>(A a, B b) => new Tie<A, B>(a, b);

    public static void iota(VecIter<uint> first, VecIter<uint> last, uint v) { for (; first.i < last.i; first.i++) first.v.a[first.i] = v++; }
    public static void iota(VecIter<int> first, VecIter<int> last, int v) { for (; first.i < last.i; first.i++) first.v.a[first.i] = v++; }

    public static VecIter<T> remove<T>(VecIter<T> first, VecIter<T> last, T value)
    {
        var cmp = EqualityComparer<T>.Default;
        var r = first;
        for (; first.i < last.i; first.i++)
            if (!cmp.Equals(first.v.a[first.i], value)) { r.v.a[r.i] = first.v.a[first.i]; r.i++; }
        return r;
    }
    public static void transform<T>(VecIter<T> first, VecIter<T> last, VecIter<T> dst, Func<T, T> f)
    {
        for (; first.i < last.i; first.i++, dst.i++) dst.v.a[dst.i] = f(first.v.a[first.i]);
    }
    public static void sort<T>(Ptr<T> first, Ptr<T> last) where T : IComparable<T>
    {
        var a = ((ArrayPtr<T>)first); long n = last - first;
        System.Array.Sort(a.Array, (int)a.Index, (int)n);
    }
    public static void sort<T>(Ptr<T> first, Ptr<T> last, Func<T, T, bool> less)
    {
        var a = ((ArrayPtr<T>)first); long n = last - first;
        System.Array.Sort(a.Array, (int)a.Index, (int)n, Comparer<T>.Create((x, y) => less(x, y) ? -1 : less(y, x) ? 1 : 0));
    }
    public static VecIter<T> find<T, U>(VecIter<T> first, VecIter<T> last, U value)
    {
        dynamic v = value;
        for (; first.i < last.i; first.i++) { T cur = first.v.a[first.i]; if (cur.Equals((T)v)) return first; }
        return last;
    }
}

public static partial class Std
{
    public static MapIter<K, V> find_if<K, V>(MapIter<K, V> first, MapIter<K, V> last, Func<Pair<K, V>, bool> pred)
    {
        for (; first != last; first++) if (pred(first.deref())) return first;
        return last;
    }
    public static SetIter<T> find_if<T>(SetIter<T> first, SetIter<T> last, Func<T, bool> pred)
    {
        for (; first != last; first++) if (pred(first.deref())) return first;
        return last;
    }
    public static void sort<T>(VecIter<T> first, VecIter<T> last, Comparison<T> cmp) => System.Array.Sort(first.v.a, first.i, last.i - first.i, Comparer<T>.Create(cmp));
}

public static partial class Std
{
    public static long index_of<T>(CppVector<T> v, T element)
    {
        for (int i = 0; i < v.n; i++) if (ReferenceEquals(v.a[i], element)) return i;
        return -1;
    }
    public static void sort<T>(VecIter<T> first, VecIter<T> last, object functor)
        => System.Array.Sort(first.v.a, first.i, last.i - first.i, Comparer<T>.Create((x, y) => ((dynamic)functor).operator_call(x, y) ? -1 : ((dynamic)functor).operator_call(y, x) ? 1 : 0));
    public static void stable_sort<T>(VecIter<T> first, VecIter<T> last, object functor)
        => stable_sort(first, last, (Func<T, T, bool>)((x, y) => ((dynamic)functor).operator_call(x, y)));
    public static MapIter<K, V> find_if<K, V, K2, V2>(MapIter<K, V> first, MapIter<K, V> last, Func<Pair<K2, V2>, bool> pred)
    {
        for (; first != last; first++)
        {
            var p = first.deref();
            if (pred(new Pair<K2, V2>((K2)(dynamic)p.first, (V2)(dynamic)p.second))) return first;
        }
        return last;
    }
}

public static partial class Std
{
    public static StrIter begin(CppString s) => s.begin();
    public static StrIter end(CppString s) => s.end();

    /// <summary>Conversion used when a lambda declares a different (but convertible) parameter type than the element type.</summary>
    public static U convert<U>(object v)
    {
        if (v is U ok) return ok;
        var ut = typeof(U);
        if (ut.IsGenericType && ut.GetGenericTypeDefinition() == typeof(Pair<,>))
        {
            var args = ut.GetGenericArguments();
            dynamic p = v;
            var m = typeof(Std).GetMethod(nameof(convert)).MakeGenericMethod(args[0]);
            var m2 = typeof(Std).GetMethod(nameof(convert)).MakeGenericMethod(args[1]);
            return (U)Activator.CreateInstance(ut, m.Invoke(null, new object[] { (object)p.first }), m2.Invoke(null, new object[] { (object)p.second }));
        }
        return (U)(dynamic)v;
    }

    public static VecIter<T> find_if<T, U>(VecIter<T> first, VecIter<T> last, Func<U, bool> pred)
    {
        for (; first.i < last.i; first.i++) if (pred(convert<U>(first.v.a[first.i]))) return first;
        return last;
    }
}

public static partial class Std
{
    public static Ptr<T> begin<T>(T[] a) => new ArrayPtr<T>(a, 0);
    public static Ptr<T> end<T>(T[] a) => new ArrayPtr<T>(a, a.Length);
    public static Ptr<T> cbegin<T>(T[] a) => begin(a);
    public static Ptr<T> cend<T>(T[] a) => end(a);
    public static Ptr<T> find_if<T>(Ptr<T> first, Ptr<T> last, Func<T, bool> pred)
    {
        for (; first.Offset(0) is ArrayPtr<T> fa && last is ArrayPtr<T> la && fa.Index < la.Index; first = first.Offset(1))
            if (pred(first[0])) return first;
        return last;
    }
}

public static partial class Std
{
    /// <summary>Array-to-pointer decay for arguments forwarded to constructors taking pointers.</summary>
    public static Ptr<T> ptr_of<T>(object o) => o switch
    {
        Ptr<T> p => p,
        T[] a => new ArrayPtr<T>(a, 0),
        null => null,
        _ => throw new InvalidCastException(),
    };
}

public static partial class Std
{
    /// <summary>Indexing a C string: the terminating NUL is readable.</summary>
    public static char cat(string s, int i) => i < s.Length ? s[i] : '\0';
}

public static partial class Std
{
    // By-value lambda captures: the captured values are bound at creation time.
    public static R bind<A, R>(A a, Func<A, R> f) => f(a);
    public static R bind<A, B, R>(A a, B b, Func<A, B, R> f) => f(a, b);
    public static R bind<A, B, C, R>(A a, B b, C c, Func<A, B, C, R> f) => f(a, b, c);
    public static R bind<A, B, C, D, R>(A a, B b, C c, D d, Func<A, B, C, D, R> f) => f(a, b, c, d);
    public static R bind<A, B, C, D, E, R>(A a, B b, C c, D d, E e, Func<A, B, C, D, E, R> f) => f(a, b, c, d, e);
    public static R bind<A, B, C, D, E, F, R>(A a, B b, C c, D d, E e, F g, Func<A, B, C, D, E, F, R> f) => f(a, b, c, d, e, g);
    public static R bind<A, B, C, D, E, F, G, R>(A a, B b, C c, D d, E e, F g, G h, Func<A, B, C, D, E, F, G, R> f) => f(a, b, c, d, e, g, h);
}

/// <summary>Minimal C stdio used by the command line tool.</summary>
public sealed class CFile
{
    public readonly Stream Stream;
    readonly TextWriter writer;
    readonly Func<TextWriter> dynamicWriter;
    public TextWriter Writer => dynamicWriter != null ? dynamicWriter() : writer;
    public CFile(Stream s, TextWriter w = null) { Stream = s; writer = w; }
    public CFile(Func<TextWriter> w) { dynamicWriter = w; }
}

public static partial class Std
{
    public static readonly CFile stderr = new CFile(() => Console.Error);
    public static readonly CFile stdout = new CFile(() => Console.Out);
    public static CFile stdin => new CFile(Console.OpenStandardInput());

    public static int fprintf(CFile f, string fmt, params object[] args)
    {
        string s = CFormat.Format(fmt, args);
        f.Writer.Write(s);
        return s.Length;
    }
    public static int printf(string fmt, params object[] args)
    {
        string s = CFormat.Format(fmt, args);
        Console.Out.Write(s);
        return s.Length;
    }
    public static CFile fopen(string path, string mode)
    {
        try
        {
            if (mode.StartsWith("r")) return new CFile(File.OpenRead(path));
            if (mode.StartsWith("a")) { var fa = File.Open(path, FileMode.Append); return new CFile(fa, new StreamWriter(fa)); }
            var fw = File.Create(path);
            return new CFile(fw, new StreamWriter(fw, new System.Text.UTF8Encoding(false)));
        }
        catch { return null; }
    }
    public static int fclose(CFile f) { f.Writer?.Flush(); f.Stream?.Dispose(); return 0; }
    public static int fseek(CFile f, long off, int whence) { f.Stream.Seek(off, (SeekOrigin)whence); return 0; }
    public static long ftell(CFile f) => f.Stream.Position;
    public static void rewind(CFile f) { f.Stream.Position = 0; }
    public static ulong fread(Ptr<uint> buf, ulong size, ulong count, CFile f)
    {
        var bytes = new byte[size * count];
        int n = f.Stream.Read(bytes, 0, bytes.Length);
        for (int i = 0; i < n / 4; i++) buf[i] = BitConverter.ToUInt32(bytes, i * 4);
        return (ulong)n / size;
    }
    public static ulong fwrite(string s, ulong size, ulong count, CFile f) { f.Writer?.Write(s); return count; }
    public static void exit(int code) => Environment.Exit(code);
    public static ulong stoul(CppString s, Ptr<ulong> idx = null, int radix = 10) => Convert.ToUInt64(s.str(), radix);
    public static double stod(CppString s) => double.Parse(s.str(), System.Globalization.CultureInfo.InvariantCulture);
    public static int strncmp(string a, string b, ulong n) => Math.Sign(string.CompareOrdinal(a, 0, b, 0, (int)n));
}

public static partial class Std
{
    public static double stod(CppString s, Ptr<ulong> idx) => stod(s);
}

public static partial class Std
{
    /// <summary>Rows of a multi-dimensional C array.</summary>
    public static T[][] new_jagged<T>(int rows, Func<T[]> row)
    {
        var a = new T[rows][];
        for (int i = 0; i < rows; i++) a[i] = row();
        return a;
    }
}
