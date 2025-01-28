// Decompiled with JetBrains decompiler
// Type: Terraria.Social.WeGame.IPCContent
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Threading;

#nullable disable
namespace Terraria.Social.WeGame
{
  public class IPCContent
  {
    public byte[] data;

    public CancellationToken CancelToken { get; set; }
  }
}
