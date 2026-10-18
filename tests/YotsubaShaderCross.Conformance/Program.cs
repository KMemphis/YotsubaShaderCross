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

using System.Diagnostics;
using YotsubaShaderCross;

// Conformance runner: executes the command line recorded from upstream's regression suite against the C# port
// (the translated main.cpp) and compares the produced text with the reference outputs shipped with SPIRV-Cross.
//
//   dotnet run -c Release -- <cases.tsv> [--filter text] [--diff N] [--out dir]
//
// cases.tsv (written by prepare_cases.py): name <TAB> spirv <TAB> reference <TAB> argument... ({IN} = the SPIR-V file)
public static class Program
{
    public static int Main(string[] args)
    {
        if (args.Length == 0) { Console.Error.WriteLine("usage: Conformance <cases.tsv> [--filter text] [--diff N] [--out dir]"); return 2; }
        string cases = args[0];
        string filter = null, outDir = null, native = null;
        int showDiffs = 3;
        for (int i = 1; i < args.Length; i++)
        {
            if (args[i] == "--filter") filter = args[++i];
            else if (args[i] == "--diff") showDiffs = int.Parse(args[++i]);
            else if (args[i] == "--out") outDir = args[++i];
            else if (args[i] == "--native") native = args[++i];
        }

        var perBackend = new SortedDictionary<string, (int pass, int fail, int crash)>();
        var failures = new List<string>();
        var crashes = new Dictionary<string, List<string>>();
        int shown = 0;
        var sw = Stopwatch.StartNew();
        foreach (var line in File.ReadLines(cases))
        {
            if (line.Length == 0) continue;
            var f = line.Split('\t');
            string name = f[0], spv = f[1], reference = f[2];
            string backend = name.Substring(0, name.IndexOf(':'));
            if (filter != null && !name.Contains(filter)) continue;
            var cur = perBackend.GetValueOrDefault(backend);

            string actual;
            try
            {
                actual = RunCli(spv, f.Skip(3).ToArray(), out string stderr, out int rc);
                if (rc != 0) throw new InvalidOperationException($"exit code {rc}: {stderr.Trim()}");
            }
            catch (Exception e)
            {
                cur.crash++; perBackend[backend] = cur;
                string key = e.GetType().Name + ": " + (e.Message.Length > 110 ? e.Message.Substring(0, 110) : e.Message).Replace('\n', ' ');
                if (!crashes.TryGetValue(key, out var l)) crashes[key] = l = new();
                l.Add(name);
                if (crashes.Count <= 2 && l.Count == 1) Console.WriteLine($"CRASH {name}: {e}");
                continue;
            }

            // Differential mode: compare against the native SPIRV-Cross build fed with the very same SPIR-V and options
            // (immune to differences between the tools that produced the SPIR-V and the ones upstream used).
            string expected;
            if (native != null) expected = RunNative(native, spv, f.Skip(3).ToArray());
            else
            {
                if (!File.Exists(reference)) { Console.WriteLine($"NOREF {name}"); continue; }
                expected = File.ReadAllText(reference);
            }
            if (Normalize(actual) == Normalize(expected)) { cur.pass++; perBackend[backend] = cur; continue; }
            cur.fail++; perBackend[backend] = cur;
            failures.Add(name);
            if (outDir != null)
            {
                Directory.CreateDirectory(outDir);
                File.WriteAllText(Path.Combine(outDir, name.Replace('/', '_').Replace(':', '_')), actual);
            }
            if (shown < showDiffs)
            {
                shown++;
                Console.WriteLine($"==== MISMATCH {name}");
                PrintDiff(Normalize(expected), Normalize(actual));
            }
        }
        Console.WriteLine();
        int p = 0, m = 0, c = 0;
        foreach (var (b, r) in perBackend)
        {
            Console.WriteLine($"{b,-8} pass={r.pass,5} mismatch={r.fail,4} crash={r.crash,4}");
            p += r.pass; m += r.fail; c += r.crash;
        }
        Console.WriteLine($"total    pass={p} mismatch={m} crash={c} ({sw.Elapsed.TotalSeconds:F1}s)");
        foreach (var kv in crashes.OrderByDescending(k => k.Value.Count).Take(15))
            Console.WriteLine($"  {kv.Value.Count,4} x {kv.Key}   e.g. {kv.Value[0]}");
        if (failures.Count > 0) File.WriteAllLines("conformance-failures.txt", failures);
        return m + c == 0 ? 0 : 1;
    }

    static string RunNative(string exe, string spv, string[] tokens)
    {
        string outPath = Path.GetTempFileName();
        var psi = new ProcessStartInfo(exe) { RedirectStandardError = true, UseShellExecute = false };
        foreach (var t in tokens) psi.ArgumentList.Add(t == "{IN}" ? spv : t);
        psi.ArgumentList.Add("--output");
        psi.ArgumentList.Add(outPath);
        using var p = Process.Start(psi)!;
        p.StandardError.ReadToEnd();
        p.WaitForExit();
        string text = File.ReadAllText(outPath);
        File.Delete(outPath);
        return text;
    }

    static string RunCli(string spv, string[] tokens, out string stderr, out int rc)
    {
        string outPath = Path.GetTempFileName();
        var argv = new List<string> { "ysc" };
        foreach (var t in tokens) argv.Add(t == "{IN}" ? spv : t);
        argv.Add("--output");
        argv.Add(outPath);

        var oldErr = Console.Error;
        var errBuf = new StringWriter();
        Console.SetError(errBuf);
        try { rc = YotsubaShaderCross.Cli.Globals.main(argv.Count, new ArrayPtr<string>(argv.ToArray(), 0)); }
        finally { Console.SetError(oldErr); }
        stderr = errBuf.ToString();
        string text = File.ReadAllText(outPath);
        File.Delete(outPath);
        return text;
    }

    static string Normalize(string s) => s.Replace("\r", "").TrimEnd('\n');

    static void PrintDiff(string expected, string actual)
    {
        var e = expected.Split('\n'); var a = actual.Split('\n');
        int n = Math.Min(e.Length, a.Length);
        int first = 0;
        while (first < n && e[first] == a[first]) first++;
        Console.WriteLine($"first difference at line {first + 1} (expected {e.Length} lines, got {a.Length})");
        for (int i = Math.Max(0, first - 2); i < Math.Min(Math.Max(e.Length, a.Length), first + 6); i++)
        {
            if (i < e.Length && (i >= a.Length || e[i] != a[i])) Console.WriteLine($"  - {e[i]}");
            if (i < a.Length && (i >= e.Length || e[i] != a[i])) Console.WriteLine($"  + {a[i]}");
            if (i < e.Length && i < a.Length && e[i] == a[i]) Console.WriteLine($"    {e[i]}");
        }
    }
}
