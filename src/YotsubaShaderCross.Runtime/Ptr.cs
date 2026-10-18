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

/// <summary>Pointer to a value-typed C++ object: either an array slice or a getter/setter pair.</summary>
public abstract class Ptr<T>
{
    public abstract T this[long i] { get; set; }
    public T Value { get => this[0]; set => this[0] = value; }
    public abstract Ptr<T> Offset(long n);
    public T this[ulong i] { get => this[(long)i]; set => this[(long)i] = value; }

    public static Ptr<T> operator +(Ptr<T> p, long n) => p.Offset(n);
    public static Ptr<T> operator -(Ptr<T> p, long n) => p.Offset(-n);
    public static Ptr<T> operator +(Ptr<T> p, ulong n) => p.Offset((long)n);
    public static Ptr<T> operator -(Ptr<T> p, ulong n) => p.Offset(-(long)n);
    public static Ptr<T> operator +(Ptr<T> p, int n) => p.Offset(n);
    public static Ptr<T> operator -(Ptr<T> p, int n) => p.Offset(-n);
    public static Ptr<T> operator +(Ptr<T> p, uint n) => p.Offset(n);
    public static Ptr<T> operator -(Ptr<T> p, uint n) => p.Offset(-(long)n);
    public static bool operator ==(Ptr<T> a, Ptr<T> b) => a is null ? b is null : a.Equals(b);
    public static bool operator !=(Ptr<T> a, Ptr<T> b) => !(a == b);
    public override bool Equals(object o) => ReferenceEquals(this, o);
    public override int GetHashCode() => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(this);
    public static Ptr<T> operator ++(Ptr<T> p) => p.Offset(1);
    public static Ptr<T> operator --(Ptr<T> p) => p.Offset(-1);
    public static long operator -(Ptr<T> a, Ptr<T> b) => ((ArrayPtr<T>)a).Index - ((ArrayPtr<T>)b).Index;
    public static bool operator <(Ptr<T> a, Ptr<T> b) => ((ArrayPtr<T>)a).Index < ((ArrayPtr<T>)b).Index;
    public static bool operator >(Ptr<T> a, Ptr<T> b) => ((ArrayPtr<T>)a).Index > ((ArrayPtr<T>)b).Index;
    public static bool operator <=(Ptr<T> a, Ptr<T> b) => ((ArrayPtr<T>)a).Index <= ((ArrayPtr<T>)b).Index;
    public static bool operator >=(Ptr<T> a, Ptr<T> b) => ((ArrayPtr<T>)a).Index >= ((ArrayPtr<T>)b).Index;
}

public sealed class ArrayPtr<T> : Ptr<T>
{
    public readonly T[] Array;
    public readonly long Index;

    public ArrayPtr(T[] array, long index) { Array = array; Index = index; }

    public override T this[long i]
    {
        get => Array[Index + i];
        set => Array[Index + i] = value;
    }

    public override Ptr<T> Offset(long n) => new ArrayPtr<T>(Array, Index + n);

    public override bool Equals(object o) => o is ArrayPtr<T> p && ReferenceEquals(p.Array, Array) && p.Index == Index;
    public override int GetHashCode() => System.Runtime.CompilerServices.RuntimeHelpers.GetHashCode(Array) ^ (int)Index;
}

public sealed class RefPtr<T> : Ptr<T>
{
    readonly Func<T> get;
    readonly Action<T> set;
    public RefPtr(Func<T> g, Action<T> s) { get = g; set = s; }
    public override T this[long i]
    {
        get { if (i != 0) throw new InvalidOperationException("pointer arithmetic on a scalar"); return get(); }
        set { if (i != 0) throw new InvalidOperationException("pointer arithmetic on a scalar"); set(value); }
    }
    public override Ptr<T> Offset(long n) => n == 0 ? this : throw new InvalidOperationException("pointer arithmetic on a scalar");
}

public static class Ptr
{
    public static Ptr<T> Ref<T>(Func<T> get, Action<T> set) => new RefPtr<T>(get, set);
    public static Ptr<T> From<T>(T[] a) => new ArrayPtr<T>(a, 0);
}
