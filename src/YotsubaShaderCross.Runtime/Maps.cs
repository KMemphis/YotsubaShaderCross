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

namespace YotsubaShaderCross;

/// <summary>Iterator over map entries (entries are shared Pair objects, so it->second = x updates the map).</summary>
public sealed class MapIter<K, V>
{
    internal IEnumerator<Pair<K, V>> e;
    internal Pair<K, V> cur;
    internal MapIter(IEnumerator<Pair<K, V>> en, Pair<K, V> c) { e = en; cur = c; }
    public Pair<K, V> deref() => cur;
    public static MapIter<K, V> operator ++(MapIter<K, V> it)
    {
        if (it.e != null && it.e.MoveNext()) it.cur = it.e.Current; else it.cur = null;
        return it;
    }
    public static bool operator ==(MapIter<K, V> a, MapIter<K, V> b) => ReferenceEquals(a?.cur, b?.cur);
    public static bool operator !=(MapIter<K, V> a, MapIter<K, V> b) => !ReferenceEquals(a?.cur, b?.cur);
    public override bool Equals(object o) => o is MapIter<K, V> m && ReferenceEquals(m.cur, cur);
    public override int GetHashCode() => cur == null ? 0 : System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(cur);
}

public class UnorderedMap<K, V> : IEnumerable<Pair<K, V>>
{
    protected IDictionary<K, Pair<K, V>> d;
    public UnorderedMap() { d = new Dictionary<K, Pair<K, V>>(); }
    protected UnorderedMap(IDictionary<K, Pair<K, V>> inner) { d = inner; }

    public ulong size() => (ulong)d.Count;
    public bool empty() => d.Count == 0;
    public void clear() => d.Clear();
    public ulong count(K k) => d.ContainsKey(k) ? 1UL : 0UL;

    public ref V this[K k]
    {
        get
        {
            if (!d.TryGetValue(k, out var p)) { p = new Pair<K, V>(k, Std.make_default<V>()); d[k] = p; }
            return ref p.second;
        }
    }
    public V at(K k) => d[k].second;

    public MapIter<K, V> find(K k)
    {
        if (d.TryGetValue(k, out var p)) return new MapIter<K, V>(null, p);
        return end();
    }
    public MapIter<K, V> begin()
    {
        var en = d.Values.GetEnumerator();
        return en.MoveNext() ? new MapIter<K, V>(en, en.Current) : end();
    }
    public MapIter<K, V> end() => new MapIter<K, V>(null, null);
    public MapIter<K, V> cbegin() => begin();
    public MapIter<K, V> cend() => end();

    public Pair<MapIter<K, V>, bool> insert(Pair<K, V> p)
    {
        if (d.TryGetValue(p.first, out var ex)) return new Pair<MapIter<K, V>, bool>(new MapIter<K, V>(null, ex), false);
        var np = new Pair<K, V>(p.first, p.second);
        d[p.first] = np;
        return new Pair<MapIter<K, V>, bool>(new MapIter<K, V>(null, np), true);
    }
    public Pair<MapIter<K, V>, bool> insert<K2, V2>(Pair<K2, V2> p) => insert(new Pair<K, V>((K)(dynamic)p.first, (V)(dynamic)p.second));
    public Pair<MapIter<K, V>, bool> emplace(K k, V v) => insert(new Pair<K, V>(k, v));
    public Pair<MapIter<K, V>, bool> emplace(Pair<K, V> p) => insert(p);

    public ulong erase(K k) => d.Remove(k) ? 1UL : 0UL;
    public MapIter<K, V> erase(MapIter<K, V> it)
    {
        var next = new MapIter<K, V>(null, null);
        var key = it.cur.first;
        // advance to the following entry before removing
        bool found = false;
        foreach (var p in d.Values.ToList())
        {
            if (found) { next = new MapIter<K, V>(null, p); break; }
            if (EqualityComparer<K>.Default.Equals(p.first, key)) found = true;
        }
        d.Remove(key);
        return next;
    }

    public UnorderedMap(IEnumerable<Pair<K, V>> items) : this() { foreach (var p in items) insert(p); }
    public void swap(UnorderedMap<K, V> o) { var t = d; d = o.d; o.d = t; }

    protected virtual UnorderedMap<K, V> NewEmpty() => new UnorderedMap<K, V>();
    public UnorderedMap<K, V> Clone() => Clone(null, null);
    public UnorderedMap<K, V> Clone(Func<K, K> ck, Func<V, V> cv)
    {
        var m = NewEmpty();
        foreach (var p in d.Values) m.d[p.first] = new Pair<K, V>(ck != null ? ck(p.first) : p.first, cv != null ? cv(p.second) : p.second);
        return m;
    }
    public void CopyFrom(UnorderedMap<K, V> o) { if (!ReferenceEquals(o, this)) { d = o.d; o.d = new Dictionary<K, Pair<K, V>>(); } }

    public IEnumerator<Pair<K, V>> GetEnumerator() => d.Values.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public sealed class OrderedMap<K, V> : UnorderedMap<K, V>
{
    public OrderedMap() : base(new SortedDictionary<K, Pair<K, V>>()) { }
    protected override UnorderedMap<K, V> NewEmpty() => new OrderedMap<K, V>();
    public new OrderedMap<K, V> Clone() => (OrderedMap<K, V>)base.Clone();
    public new OrderedMap<K, V> Clone(Func<K, K> ck, Func<V, V> cv) => (OrderedMap<K, V>)base.Clone(ck, cv);
}

public sealed class SetIter<T>
{
    internal IEnumerator<T> e;
    internal bool valid;
    internal T cur;
    internal SetIter(IEnumerator<T> en, bool v, T c) { e = en; valid = v; cur = c; }
    public T deref() => cur;
    public static SetIter<T> operator ++(SetIter<T> it)
    {
        if (it.e != null && it.e.MoveNext()) { it.cur = it.e.Current; it.valid = true; } else it.valid = false;
        return it;
    }
    public static bool operator ==(SetIter<T> a, SetIter<T> b) => a.valid == b.valid && (!a.valid || EqualityComparer<T>.Default.Equals(a.cur, b.cur));
    public static bool operator !=(SetIter<T> a, SetIter<T> b) => !(a == b);
    public override bool Equals(object o) => o is SetIter<T> s && this == s;
    public override int GetHashCode() => 0;
}

public class UnorderedSet<T> : IEnumerable<T>
{
    protected ISet<T> s;
    public UnorderedSet() { s = new HashSet<T>(); }
    protected UnorderedSet(ISet<T> inner) { s = inner; }

    public ulong size() => (ulong)s.Count;
    public bool empty() => s.Count == 0;
    public void clear() => s.Clear();
    public ulong count(T v) => s.Contains(v) ? 1UL : 0UL;
    public Pair<SetIter<T>, bool> insert(T v)
    {
        bool added = s.Add(v);
        return new Pair<SetIter<T>, bool>(new SetIter<T>(null, true, v), added);
    }
    public Pair<SetIter<T>, bool> emplace(T v) => insert(v);
    public ulong erase(T v) => s.Remove(v) ? 1UL : 0UL;
    public SetIter<T> find(T v) => s.Contains(v) ? new SetIter<T>(null, true, v) : end();
    public SetIter<T> begin()
    {
        var en = s.GetEnumerator();
        return en.MoveNext() ? new SetIter<T>(en, true, en.Current) : end();
    }
    public SetIter<T> end() => new SetIter<T>(null, false, default);
    public void swap(UnorderedSet<T> o) { var t = s; s = o.s; o.s = t; }

    public UnorderedSet(IEnumerable<T> items) : this() { foreach (var v in items) s.Add(v); }
    public void insert(VecIter<T> first, VecIter<T> last) { for (; first.i < last.i; first.i++) s.Add(first.v.a[first.i]); }
    public void insert<U>(VecIter<U> first, VecIter<U> last) { for (; first.i < last.i; first.i++) s.Add((T)(dynamic)first.v.a[first.i]); }
    public void insert(Ptr<T> first, Ptr<T> last) { for (long i = 0; i < last - first; i++) s.Add(first[i]); }
    public void insert(SetIter<T> first, SetIter<T> last) { for (; first != last; first++) s.Add(first.deref()); }
    protected virtual UnorderedSet<T> NewEmpty() => new UnorderedSet<T>();
    public UnorderedSet<T> Clone() => Clone(null);
    public UnorderedSet<T> Clone(Func<T, T> c)
    {
        var r = NewEmpty();
        foreach (var v in s) r.s.Add(c != null ? c(v) : v);
        return r;
    }
    public void CopyFrom(UnorderedSet<T> o) { if (!ReferenceEquals(o, this)) { s = o.s; o.s = new HashSet<T>(); } }

    public IEnumerator<T> GetEnumerator() => s.GetEnumerator();
    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public sealed class OrderedSet<T> : UnorderedSet<T>
{
    public OrderedSet() : base(new SortedSet<T>()) { }
    public OrderedSet(IEnumerable<T> items) : this() { foreach (var v in items) s.Add(v); }
    protected override UnorderedSet<T> NewEmpty() => new OrderedSet<T>();
    public new OrderedSet<T> Clone() => (OrderedSet<T>)base.Clone();
    public new OrderedSet<T> Clone(Func<T, T> c) => (OrderedSet<T>)base.Clone(c);
}

public sealed class CppStack<T>
{
    readonly List<T> l = new();
    public void push(T v) => l.Add(v);
    public void pop() => l.RemoveAt(l.Count - 1);
    public ref T top() => ref System.Runtime.InteropServices.CollectionsMarshal.AsSpan(l)[l.Count - 1];
    public bool empty() => l.Count == 0;
    public ulong size() => (ulong)l.Count;
    public CppStack<T> Clone() => Clone(null);
    public CppStack<T> Clone(Func<T, T> c)
    {
        var r = new CppStack<T>();
        foreach (var v in l) r.l.Add(c != null ? c(v) : v);
        return r;
    }
    public void CopyFrom(CppStack<T> o) { l.Clear(); l.AddRange(o.l); }
}
