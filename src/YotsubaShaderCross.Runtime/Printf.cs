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
using System.Numerics;
using System.Text;

namespace YotsubaShaderCross;

/// <summary>Faithful subset of C's printf family (glibc/libc++ semantics for %g are bit-exact).</summary>
public static class CFormat
{
    public static string Format(string fmt, object[] args)
    {
        var sb = new StringBuilder();
        int ai = 0;
        for (int i = 0; i < fmt.Length; i++)
        {
            char c = fmt[i];
            if (c != '%') { sb.Append(c); continue; }
            i++;
            if (i >= fmt.Length) break;
            if (fmt[i] == '%') { sb.Append('%'); continue; }

            bool left = false, plus = false, space = false, alt = false, zero = false;
            for (; i < fmt.Length; i++)
            {
                char f = fmt[i];
                if (f == '-') left = true; else if (f == '+') plus = true; else if (f == ' ') space = true;
                else if (f == '#') alt = true; else if (f == '0') zero = true; else break;
            }
            int width = 0;
            if (i < fmt.Length && fmt[i] == '*') { width = Convert.ToInt32(args[ai++]); i++; }
            else while (i < fmt.Length && char.IsDigit(fmt[i])) width = width * 10 + (fmt[i++] - '0');
            int prec = -1;
            if (i < fmt.Length && fmt[i] == '.')
            {
                i++; prec = 0;
                if (i < fmt.Length && fmt[i] == '*') { prec = Convert.ToInt32(args[ai++]); i++; }
                else while (i < fmt.Length && char.IsDigit(fmt[i])) prec = prec * 10 + (fmt[i++] - '0');
            }
            while (i < fmt.Length && (fmt[i] is 'h' or 'l' or 'z' or 'j' or 't' or 'L' or 'q')) i++;
            char conv = fmt[i];
            string body;
            switch (conv)
            {
                case 'd': case 'i':
                {
                    long v = ToLong(args[ai++]);
                    body = Math.Abs((decimal)v).ToString(CultureInfo.InvariantCulture);
                    if (prec >= 0) body = body.PadLeft(prec, '0');
                    body = (v < 0 ? "-" : plus ? "+" : space ? " " : "") + body;
                    break;
                }
                case 'u':
                    body = ToULong(args[ai++]).ToString(CultureInfo.InvariantCulture);
                    if (prec >= 0) body = body.PadLeft(prec, '0');
                    break;
                case 'x': case 'X':
                    body = ToULong(args[ai++]).ToString(conv == 'x' ? "x" : "X", CultureInfo.InvariantCulture);
                    if (prec >= 0) body = body.PadLeft(prec, '0');
                    if (alt && body != "0") body = (conv == 'x' ? "0x" : "0X") + body;
                    break;
                case 'o':
                    body = Convert.ToString((long)ToULong(args[ai++]), 8);
                    break;
                case 'c': body = ((char)Convert.ToInt32(args[ai++])).ToString(); break;
                case 's':
                {
                    object a = args[ai++];
                    body = a is Ptr<char> pc ? Std.from_c_buffer(pc).str() : a?.ToString() ?? "(null)";
                    if (prec >= 0 && body.Length > prec) body = body.Substring(0, prec);
                    break;
                }
                case 'g': case 'G': case 'e': case 'E': case 'f': case 'F':
                {
                    double v = Convert.ToDouble(args[ai++], CultureInfo.InvariantCulture);
                    body = FormatFloat(v, conv, prec < 0 ? 6 : prec, alt);
                    if (!body.StartsWith("-") && !body.StartsWith("N") && !body.StartsWith("I")) { if (plus) body = "+" + body; else if (space) body = " " + body; }
                    break;
                }
                default: body = "%" + conv; break;
            }
            if (body.Length < width)
            {
                if (left) body = body.PadRight(width);
                else if (zero && conv != 's' && conv != 'c')
                {
                    int signLen = body.Length > 0 && (body[0] is '-' or '+' or ' ') ? 1 : 0;
                    body = body.Substring(0, signLen) + new string('0', width - body.Length) + body.Substring(signLen);
                }
                else body = body.PadLeft(width);
            }
            sb.Append(body);
        }
        return sb.ToString();
    }

    static long ToLong(object o) => o switch { long l => l, int i => i, uint u => u, ulong ul => (long)ul, short s => s, ushort us => us, byte b => b, sbyte sb => sb, char c => c, _ => Convert.ToInt64(o) };
    static ulong ToULong(object o) => o switch { ulong ul => ul, uint u => u, long l => (ulong)l, int i => (ulong)(uint)i, ushort us => us, short s => (ushort)s, byte b => b, sbyte sb => (byte)sb, char c => c, _ => Convert.ToUInt64(o) };

    public static string FormatFloat(double v, char conv, int prec, bool alt)
    {
        if (double.IsNaN(v)) return char.IsUpper(conv) ? "NAN" : "nan";
        if (double.IsInfinity(v)) return (v < 0 ? "-" : "") + (char.IsUpper(conv) ? "INF" : "inf");
        bool neg = v < 0 || (v == 0 && double.IsNegative(v));
        v = Math.Abs(v);
        string r;
        switch (char.ToLowerInvariant(conv))
        {
            case 'f': r = FixedStr(v, prec, alt); break;
            case 'e': r = ExpStr(v, prec, alt, char.IsUpper(conv)); break;
            default: r = GStr(v, prec, alt, char.IsUpper(conv)); break;
        }
        return (neg ? "-" : "") + r;
    }

    // exact decimal expansion: value = 0.d1d2d3... * 10^pointPos (digits without trailing zeros)
    static (string digits, int exp10) Exact(double v)
    {
        if (v == 0) return ("0", 0);
        long bits = BitConverter.DoubleToInt64Bits(v);
        int e = (int)((bits >> 52) & 0x7ff);
        long m = bits & 0xfffffffffffffL;
        if (e == 0) e++; else m |= 1L << 52;
        e -= 1075;
        BigInteger n = m;
        int pointShift;
        if (e >= 0) { n <<= e; pointShift = 0; }
        else { n *= BigInteger.Pow(5, -e); pointShift = -e; }
        string digits = n.ToString(CultureInfo.InvariantCulture);
        int exp10 = digits.Length - 1 - pointShift;
        digits = digits.TrimEnd('0');
        if (digits.Length == 0) digits = "0";
        return (digits, exp10);
    }

    // round to 'count' significant digits (half to even on the exact value)
    static (string digits, int exp10) Round(string digits, int exp10, int count)
    {
        if (count < 1) count = 1;
        if (digits.Length <= count) return (digits.PadRight(count, '0'), exp10);
        char next = digits[count];
        bool up;
        if (next > '5') up = true;
        else if (next < '5') up = false;
        else
        {
            bool restZero = digits.Substring(count + 1).All(ch => ch == '0');
            up = !restZero || ((digits[count - 1] - '0') % 2 == 1);
        }
        var arr = digits.Substring(0, count).ToCharArray();
        if (up)
        {
            int k = count - 1;
            while (k >= 0) { if (arr[k] == '9') { arr[k] = '0'; k--; } else { arr[k]++; break; } }
            if (k < 0) return ("1" + new string(arr, 0, count - 1 < 0 ? 0 : count - 1).PadRight(count - 1, '0'), exp10 + 1);
        }
        return (new string(arr), exp10);
    }

    static string GStr(double v, int p, bool alt, bool upper)
    {
        if (p == 0) p = 1;
        var (d, x) = Exact(v);
        if (v == 0) { d = "0"; x = 0; }
        var (rd, rx) = Round(d, x, p);
        string res;
        if (rx < -4 || rx >= p)
        {
            string mant = rd.Substring(0, 1);
            string frac = rd.Substring(1);
            if (!alt) frac = frac.TrimEnd('0');
            res = mant + (frac.Length > 0 || alt ? "." + frac : "") + (upper ? "E" : "e") + (rx < 0 ? "-" : "+") + Math.Abs(rx).ToString("00", CultureInfo.InvariantCulture);
        }
        else
        {
            string s;
            if (rx >= 0)
            {
                string ip = rd.Substring(0, Math.Min(rd.Length, rx + 1)).PadRight(rx + 1, '0');
                string fp = rd.Length > rx + 1 ? rd.Substring(rx + 1) : "";
                if (!alt) fp = fp.TrimEnd('0');
                s = ip + (fp.Length > 0 || alt ? "." + fp : "");
            }
            else
            {
                string fp = new string('0', -rx - 1) + rd;
                if (!alt) fp = fp.TrimEnd('0');
                s = "0" + (fp.Length > 0 || alt ? "." + fp : "");
            }
            res = s;
        }
        return res;
    }

    static string ExpStr(double v, int prec, bool alt, bool upper)
    {
        var (d, x) = Exact(v);
        if (v == 0) { d = "0"; x = 0; }
        var (rd, rx) = Round(d, x, prec + 1);
        string frac = rd.Substring(1).PadRight(prec, '0');
        return rd.Substring(0, 1) + (prec > 0 || alt ? "." + frac : "") + (upper ? "E" : "e") + (rx < 0 ? "-" : "+") + Math.Abs(rx).ToString("00", CultureInfo.InvariantCulture);
    }

    static string FixedStr(double v, int prec, bool alt)
    {
        var (d, x) = Exact(v);
        if (v == 0) return "0" + (prec > 0 || alt ? "." + new string('0', prec) : "");
        // digits d with decimal exponent x; keep x + 1 + prec significant digits
        int keep = x + 1 + prec;
        string rd; int rx;
        if (keep <= 0)
        {
            // value rounds to 0 or to 10^-prec
            bool up = keep == 0 && (d[0] > '5' || (d[0] == '5' && d.Length > 1));
            return "0" + (prec > 0 || alt ? "." + new string('0', Math.Max(0, prec - (up ? 1 : 0))) + (up && prec > 0 ? "1" : "") : "");
        }
        (rd, rx) = Round(d, x, keep);
        string all = rd.PadRight(rx + 1 + prec, '0');
        string ip = rx >= 0 ? all.Substring(0, rx + 1) : "0";
        string fp = rx >= 0 ? all.Substring(rx + 1) : new string('0', -rx - 1) + all;
        fp = fp.PadRight(prec, '0').Substring(0, prec);
        return ip + (prec > 0 || alt ? "." + fp : "");
    }
}

public static partial class Std
{
    public static int sprintf(Ptr<char> buf, string fmt, params object[] args)
    {
        string s = CFormat.Format(fmt, args);
        for (int i = 0; i < s.Length; i++) buf[i] = s[i];
        buf[s.Length] = '\0';
        return s.Length;
    }

    public static int snprintf(Ptr<char> buf, ulong size, string fmt, params object[] args)
    {
        string s = CFormat.Format(fmt, args);
        int n = (int)Math.Min((ulong)s.Length, size == 0 ? 0 : size - 1);
        for (int i = 0; i < n; i++) buf[i] = s[i];
        if (size > 0) buf[n] = '\0';
        return s.Length;
    }

    public static CppString format_double_g(double v, int precision) => new CppString(CFormat.FormatFloat(v, 'g', precision, false));
}
