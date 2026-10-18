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
// Upstream sources: spirv_reflect.cpp
// Upstream copyright: Copyright 2018-2021 Bradley Austin Davis
// Upstream licence: Apache-2.0 OR MIT (used here under the MIT License). See THIRD-PARTY-NOTICES.md.

#nullable disable
#pragma warning disable

namespace YotsubaShaderCross;

public partial class Stream
{
    public CppStack<Pair<Type, bool>> stack = new CppStack<Pair<Type, bool>>();
    public StringStream buffer = new StringStream();
    public uint indent = 0u;
    public char current_locale_radix_character = '.';
    public void set_current_locale_radix_character(char c)
    {
        current_locale_radix_character = c;
    }
    public void begin_json_object()
    {
        if (!stack.empty() && stack.top().second)
        {
            statement_inner(",\n");
        }
        statement("{");
        ++indent;
        stack.push(new Pair<Type, bool>(Type.Object, false));
    }
    public void end_json_object()
    {
        if (stack.empty() || stack.top().first != Type.Object)
        {
            throw new CompilerError("Invalid JSON state");
        }
        if (stack.top().second)
        {
            statement_inner("\n");
        }
        --indent;
        statement_no_return("}");
        stack.pop();
        if (!stack.empty())
        {
            stack.top().second = true;
        }
    }
    public void emit_json_key(CppString key)
    {
        if (stack.empty() || stack.top().first != Type.Object)
        {
            throw new CompilerError("Invalid JSON state");
        }
        if (stack.top().second)
        {
            statement_inner(",\n");
        }
        statement_no_return("\"", key, "\" : ");
        stack.top().second = true;
    }
    public void emit_json_key_value(CppString key, CppString value)
    {
        emit_json_key(key);
        statement_inner("\"", value, "\"");
    }
    public void emit_json_key_value(CppString key, bool value)
    {
        emit_json_key(key);
        statement_inner(value ? "true" : "false");
    }
    public void emit_json_key_value(CppString key, uint value)
    {
        emit_json_key(key);
        statement_inner(value);
    }
    public void emit_json_key_value(CppString key, int value)
    {
        emit_json_key(key);
        statement_inner(value);
    }
    public void emit_json_key_value(CppString key, float value)
    {
        emit_json_key(key);
        statement_inner(Globals.convert_to_string(value, current_locale_radix_character));
    }
    public void emit_json_key_object(CppString key)
    {
        emit_json_key(key);
        statement_inner("{\n");
        ++indent;
        stack.push(new Pair<Type, bool>(Type.Object, false));
    }
    public void emit_json_key_array(CppString key)
    {
        emit_json_key(key);
        statement_inner("[\n");
        ++indent;
        stack.push(new Pair<Type, bool>(Type.Array, false));
    }
    public void begin_json_array()
    {
        if (!stack.empty() && stack.top().second)
        {
            statement_inner(",\n");
        }
        statement("[");
        ++indent;
        stack.push(new Pair<Type, bool>(Type.Array, false));
    }
    public void end_json_array()
    {
        if (stack.empty() || stack.top().first != Type.Array)
        {
            throw new CompilerError("Invalid JSON state");
        }
        if (stack.top().second)
        {
            statement_inner("\n");
        }
        --indent;
        statement_no_return("]");
        stack.pop();
        if (!stack.empty())
        {
            stack.top().second = true;
        }
    }
    public void emit_json_array_value(CppString value)
    {
        if (stack.empty() || stack.top().first != Type.Array)
        {
            throw new CompilerError("Invalid JSON state");
        }
        if (stack.top().second)
        {
            statement_inner(",\n");
        }
        statement_no_return("\"", value, "\"");
        stack.top().second = true;
    }
    public void emit_json_array_value(uint value)
    {
        if (stack.empty() || stack.top().first != Type.Array)
        {
            throw new CompilerError("Invalid JSON state");
        }
        if (stack.top().second)
        {
            statement_inner(",\n");
        }
        statement_no_return(Std.to_string(value));
        stack.top().second = true;
    }
    public void emit_json_array_value(bool value)
    {
        if (stack.empty() || stack.top().first != Type.Array)
        {
            throw new CompilerError("Invalid JSON state");
        }
        if (stack.top().second)
        {
            statement_inner(",\n");
        }
        statement_no_return(value ? "true" : "false");
        stack.top().second = true;
    }
    public CppString str()
    {
        return buffer.str();
    }
    public void statement_indent()
    {
        {
            for (uint i = 0u; i < indent; i++)
            {
                _ = buffer << "    ";
            }
        }
    }

    protected virtual void FixClone()
    {
        this.stack = this.stack.Clone(__e => __e.Clone());
    }

    public Stream Clone()
    {
        var __c = (Stream)MemberwiseClone();
        __c.FixClone();
        return __c;
    }

    public void CopyFrom(Stream o)
    {
        this.stack = o.stack.Clone(__e => __e.Clone());
        this.buffer = o.buffer;
        this.indent = o.indent;
        this.current_locale_radix_character = o.current_locale_radix_character;
    }
}
