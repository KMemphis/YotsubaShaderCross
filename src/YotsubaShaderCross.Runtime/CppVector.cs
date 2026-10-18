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

using System.Collections;
using System.Runtime.CompilerServices;

namespace YotsubaShaderCross;

/// <summary>Mirror of std::vector. Elements of reference types are shared, value types are copied.</summary>
public class CppVector<T> : IEnumerable<T>
{
    internal T[] a;
    internal int n;

    public CppVector() { a = System.Array.Empty<T>(); }
    public CppVector(ulong count) { a = new T[count]; n = (int)count; Fill(0, n); }
    public CppVector(uint count) : this((ulong)count) { }
    public CppVector(int count) : this((ulong)count) { }
    public CppVector(ulong count, T value) { a = new T[count]; n = (int)count; for (int i = 0; i < n; i++) a[i] = value; }
    /// <summary>Builds a vector from an array of a convertible element type (std::vector&lt;T&gt;(array) written for another id type).</summary>
    public static CppVector<T> From<U>(U[] src)
    {
        var v = new CppVector<T>(); v.a = new T[src.Length]; v.n = src.Length;
        for (int i = 0; i < src.Length; i++) v.a[i] = Std.convert<T>(src[i]);
        return v;
    }
    public CppVector(T[] init) { a = (T[])init.Clone(); n = a.Length; }
    public CppVector(CppVector<T> other) { a = new T[other.n]; System.Array.Copy(other.a, a, other.n); n = other.n; }
    public CppVector(Ptr<T> first, Ptr<T> last)
    {
        long cnt = last - first;
        a = new T[cnt]; n = (int)cnt;
        for (long i = 0; i < cnt; i++) a[i] = first[i];
    }
    public Ptr<T> ptr_back() => new ArrayPtr<T>(a, n - 1);
    public Ptr<T> ptr_front() => new ArrayPtr<T>(a, 0);
    public CppVector(VecIter<T> first, VecIter<T> last)
    {
        int cnt = (int)(last.i - first.i);
        a = new T[cnt]; n = cnt;
        for (int i = 0; i < cnt; i++) a[i] = first.v.a[first.i + i];
    }

    void Fill(int from, int to)
    {
        if (!typeof(T).IsValueType && typeof(T) != typeof(string) && !IsPointerLike)
            for (int i = from; i < to; i++) a[i] = Std.make_default<T>();
    }

    // Pointer-typed elements (vector<Foo*>) must stay null; the transpiler never default-constructs those through this path.
    static bool IsPointerLike => false;

    public ref T this[ulong i] { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => ref a[(int)i]; }
    public ref T this[uint i] { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => ref a[(int)i]; }
    public ref T this[int i] { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => ref a[i]; }
    public ref T this[long i] { [MethodImpl(MethodImplOptions.AggressiveInlining)] get => ref a[(int)i]; }

    public ref T at(ulong i) { if (i >= (ulong)n) throw new IndexOutOfRangeException(); return ref a[(int)i]; }
    public ulong size() => (ulong)n;
    public bool empty() => n == 0;
    public ulong capacity() => (ulong)a.Length;
    public ref T back() => ref a[n - 1];
    public ref T front() => ref a[0];
    public Ptr<T> data() => new ArrayPtr<T>(a, 0);
    public Ptr<T> ptr_at(long i) => new ArrayPtr<T>(a, i);
    public Ptr<T> ptr_at(ulong i) => new ArrayPtr<T>(a, (long)i);
    public Ptr<T> ptr_at(uint i) => new ArrayPtr<T>(a, i);

    public void reserve(ulong cap) { if ((ulong)a.Length < cap) System.Array.Resize(ref a, (int)cap); }
    public void shrink_to_fit() { }

    void Grow(int need)
    {
        if (need <= a.Length) return;
        int cap = Math.Max(Math.Max(4, a.Length * 2), need);
        System.Array.Resize(ref a, cap);
    }

    public void push_back(T v) { Grow(n + 1); a[n++] = v; }
    public void emplace_back(T v) { push_back(v); }
    public void pop_back() { n--; a[n] = default; }
    public void clear() { System.Array.Clear(a, 0, n); n = 0; }

    public void resize(ulong count)
    {
        int c = (int)count;
        Grow(c);
        if (c > n) { Fill(n, c); }
        else System.Array.Clear(a, c, n - c);
        n = c;
    }
    public void resize(ulong count, T value)
    {
        int c = (int)count;
        Grow(c);
        for (int i = n; i < c; i++) a[i] = value;
        if (c < n) System.Array.Clear(a, c, n - c);
        n = c;
    }

    public void assign(ulong count, T value) { clear(); resize(count, value); }
    public void assign(VecIter<T> first, VecIter<T> last)
    {
        var tmp = new T[(int)(last.i - first.i)];
        System.Array.Copy(first.v.a, first.i, tmp, 0, tmp.Length);
        a = tmp; n = tmp.Length;
    }

    public VecIter<T> begin() => new VecIter<T>(this, 0);
    public VecIter<T> end() => new VecIter<T>(this, n);
    public VecIter<T> cbegin() => begin();
    public VecIter<T> cend() => end();

    public VecIter<T> insert(VecIter<T> pos, T v)
    {
        Grow(n + 1);
        System.Array.Copy(a, pos.i, a, pos.i + 1, n - pos.i);
        a[pos.i] = v; n++;
        return pos;
    }
    public VecIter<T> insert(VecIter<T> pos, VecIter<T> first, VecIter<T> last)
    {
        int cnt = (int)(last.i - first.i);
        var tmp = new T[cnt];
        System.Array.Copy(first.v.a, first.i, tmp, 0, cnt);
        Grow(n + cnt);
        System.Array.Copy(a, pos.i, a, pos.i + cnt, n - pos.i);
        System.Array.Copy(tmp, 0, a, pos.i, cnt);
        n += cnt;
        return pos;
    }
    public VecIter<T> insert(VecIter<T> pos, ulong count, T v)
    {
        Grow(n + (int)count);
        System.Array.Copy(a, pos.i, a, pos.i + (int)count, n - pos.i);
        for (int i = 0; i < (int)count; i++) a[pos.i + i] = v;
        n += (int)count;
        return pos;
    }
    public VecIter<T> insert(VecIter<T> pos, Ptr<T> first, Ptr<T> last)
    {
        int cnt = (int)(last - first);
        var tmp = new T[cnt];
        for (int i = 0; i < cnt; i++) tmp[i] = first[i];
        Grow(n + cnt);
        System.Array.Copy(a, pos.i, a, pos.i + cnt, n - pos.i);
        System.Array.Copy(tmp, 0, a, pos.i, cnt);
        n += cnt;
        return pos;
    }
    public VecIter<T> erase(VecIter<T> pos)
    {
        System.Array.Copy(a, pos.i + 1, a, pos.i, n - pos.i - 1);
        n--; a[n] = default;
        return pos;
    }
    public VecIter<T> erase(VecIter<T> first, VecIter<T> last)
    {
        int cnt = (int)(last.i - first.i);
        System.Array.Copy(a, last.i, a, first.i, n - last.i);
        System.Array.Clear(a, n - cnt, cnt);
        n -= cnt;
        return first;
    }

    public void swap(CppVector<T> o)
    {
        (a, o.a) = (o.a, a);
        (n, o.n) = (o.n, n);
    }

    public CppVector<T> Clone()
    {
        var c = new CppVector<T>();
        c.a = new T[n]; System.Array.Copy(a, c.a, n); c.n = n;
        return c;
    }
    public CppVector<T> Clone(Func<T, T> elem)
    {
        var c = new CppVector<T>();
        c.a = new T[n]; for (int i = 0; i < n; i++) c.a[i] = elem(a[i]); c.n = n;
        return c;
    }
    public void CopyFrom(CppVector<T> o)
    {
        if (ReferenceEquals(o, this)) return;
        a = o.a; n = o.n;
        // o is an owned temporary or a clone made by the caller; steal its storage
        o.a = System.Array.Empty<T>(); o.n = 0;
    }

    public override bool Equals(object obj) => obj is CppVector<T> o && n == o.n && EqualsRange(o);
    bool EqualsRange(CppVector<T> o)
    {
        var cmp = EqualityComparer<T>.Default;
        for (int i = 0; i < n; i++) if (!cmp.Equals(a[i], o.a[i])) return false;
        return true;
    }
    public override int GetHashCode() => n;
    public static bool operator ==(CppVector<T> x, CppVector<T> y) => x is null ? y is null : x.Equals(y);
    public static bool operator !=(CppVector<T> x, CppVector<T> y) => !(x == y);

    public Enumerator GetEnumerator() => new Enumerator(this);
    IEnumerator<T> IEnumerable<T>.GetEnumerator() => GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

    public struct Enumerator : IEnumerator<T>
    {
        readonly CppVector<T> v;
        int i;
        public Enumerator(CppVector<T> vec) { v = vec; i = -1; }
        public T Current => v.a[i];
        object IEnumerator.Current => Current;
        public bool MoveNext() => ++i < v.n;
        public void Reset() { i = -1; }
        public void Dispose() { }
    }
}

/// <summary>Random-access iterator over a CppVector.</summary>
public struct VecIter<T>
{
    internal CppVector<T> v;
    internal int i;
    public VecIter(CppVector<T> vec, int idx) { v = vec; i = idx; }
    public ref T deref() => ref v.a[i];
    public ref T this[long k] => ref v.a[i + (int)k];
    public Ptr<T> ptr() => new ArrayPtr<T>(v.a, i);
    public static VecIter<T> operator ++(VecIter<T> a) { a.i++; return a; }
    public static VecIter<T> operator --(VecIter<T> a) { a.i--; return a; }
    public static VecIter<T> operator +(VecIter<T> a, long n) { a.i += (int)n; return a; }
    public static VecIter<T> operator +(VecIter<T> a, ulong n) { a.i += (int)n; return a; }
    public static VecIter<T> operator -(VecIter<T> a, long n) { a.i -= (int)n; return a; }
    public static VecIter<T> operator -(VecIter<T> a, ulong n) { a.i -= (int)n; return a; }
    public static long operator -(VecIter<T> a, VecIter<T> b) => a.i - b.i;
    public static bool operator ==(VecIter<T> a, VecIter<T> b) => a.i == b.i && ReferenceEquals(a.v, b.v);
    public static bool operator !=(VecIter<T> a, VecIter<T> b) => !(a == b);
    public static bool operator <(VecIter<T> a, VecIter<T> b) => a.i < b.i;
    public static bool operator >(VecIter<T> a, VecIter<T> b) => a.i > b.i;
    public static bool operator <=(VecIter<T> a, VecIter<T> b) => a.i <= b.i;
    public static bool operator >=(VecIter<T> a, VecIter<T> b) => a.i >= b.i;
    public override bool Equals(object o) => o is VecIter<T> b && this == b;
    public override int GetHashCode() => i;
}
