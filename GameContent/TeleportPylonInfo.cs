// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.TeleportPylonInfo
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System;
using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent
{
  public struct TeleportPylonInfo : IEquatable<TeleportPylonInfo>
  {
    public Point16 PositionInTiles;
    public TeleportPylonType TypeOfPylon;

    public bool Equals(TeleportPylonInfo other)
    {
      return this.PositionInTiles == other.PositionInTiles && this.TypeOfPylon == other.TypeOfPylon;
    }
  }
}
