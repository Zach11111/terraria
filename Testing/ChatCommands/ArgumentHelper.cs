// Decompiled with JetBrains decompiler
// Type: Terraria.Testing.ChatCommands.ArgumentHelper
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using System.Collections.Generic;
using System.Linq;

#nullable disable
namespace Terraria.Testing.ChatCommands
{
  public static class ArgumentHelper
  {
    public static ArgumentListResult ParseList(string arguments)
    {
      return new ArgumentListResult(((IEnumerable<string>) arguments.Split(' ')).Select<string, string>((Func<string, string>) (arg => arg.Trim())).Where<string>((Func<string, bool>) (arg => arg.Length != 0)));
    }
  }
}
