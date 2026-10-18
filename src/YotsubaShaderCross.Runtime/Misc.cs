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

using System.Text;

namespace YotsubaShaderCross;

public class RuntimeError : Exception
{
    public RuntimeError(CppString what) : base(what.ToString()) { }
    public RuntimeError(string what) : base(what) { }
    public string what() => Message;
}

/// <summary>Replacement for the placement-new object pool: objects are plain heap allocations.</summary>
public class ObjectPoolBase
{
    public virtual void deallocate_opaque(object ptr) { }
}

public class ObjectPool<T> : ObjectPoolBase
{
    public ObjectPool() { }
    public ObjectPool(uint start) { }
    public void deallocate(T ptr) { }
    public void clear() { }
}

/// <summary>Mirror of SPIRV-Cross's StringStream: appends integers, chars and strings.</summary>
public sealed class StringStream
{
    readonly StringBuilder sb = new();
    public StringStream() { }

    public static StringStream operator <<(StringStream s, CppString v) { s.sb.Append(v.str()); return s; }
    public static StringStream operator <<(StringStream s, string v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, char v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, int v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, uint v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, long v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, ulong v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, short v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, ushort v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, byte v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, sbyte v) { s.sb.Append(v); return s; }
    public static StringStream operator <<(StringStream s, bool v) { s.sb.Append(v ? "1" : "0"); return s; }

    public StringStream Append(string v) { sb.Append(v); return this; }
    public StringStream Append(char v) { sb.Append(v); return this; }
    public CppString str() => new CppString(sb.ToString());
    public void reset() { sb.Clear(); }
}

/// <summary>Argument of the variadic join(...) helper: anything StringStream can stream.</summary>
public readonly struct JoinArg
{
    public readonly string S;
    JoinArg(string s) { S = s; }
    public static implicit operator JoinArg(string v) => new JoinArg(v ?? "");
    public static implicit operator JoinArg(CppString v) => new JoinArg(v.str());
    public static implicit operator JoinArg(char v) => new JoinArg(v.ToString());
    public static implicit operator JoinArg(int v) => new JoinArg(v.ToString(System.Globalization.CultureInfo.InvariantCulture));
    public static implicit operator JoinArg(uint v) => new JoinArg(v.ToString(System.Globalization.CultureInfo.InvariantCulture));
    public static implicit operator JoinArg(long v) => new JoinArg(v.ToString(System.Globalization.CultureInfo.InvariantCulture));
    public static implicit operator JoinArg(ulong v) => new JoinArg(v.ToString(System.Globalization.CultureInfo.InvariantCulture));
    public static implicit operator JoinArg(short v) => new JoinArg(v.ToString(System.Globalization.CultureInfo.InvariantCulture));
    public static implicit operator JoinArg(ushort v) => new JoinArg(v.ToString(System.Globalization.CultureInfo.InvariantCulture));
    public static implicit operator JoinArg(byte v) => new JoinArg(v.ToString(System.Globalization.CultureInfo.InvariantCulture));
    public static implicit operator JoinArg(bool v) => new JoinArg(v ? "1" : "0");
    public static implicit operator JoinArg(char[] v) => new JoinArg(CStr(v));
    public static implicit operator JoinArg(Ptr<char> v) => new JoinArg(Std.from_c_buffer(v).str());
    static string CStr(char[] v)
    {
        int n = Array.IndexOf(v, '\0');
        return new string(v, 0, n < 0 ? v.Length : n);
    }
}

public static partial class Std
{
    public static CppString join(params JoinArg[] parts)
    {
        var sb = new System.Text.StringBuilder();
        foreach (var p in parts) sb.Append(p.S);
        return new CppString(sb.ToString());
    }
}

/// <summary>RAII helper that restores a variable when disposed (ValueSaver&lt;T&gt;).</summary>
public sealed class ValueSaver<T> : IDisposable
{
    readonly Ptr<T> current;
    readonly T saved;
    public ValueSaver(Ptr<T> cur) { current = cur; saved = cur.Value; }
    public void release() { current.Value = saved; }
    public void Dispose() { release(); }
}
