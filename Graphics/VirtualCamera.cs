// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.VirtualCamera
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.Graphics
{
  public struct VirtualCamera
  {
    public readonly Player Player;

    public VirtualCamera(Player player) => this.Player = player;

    public Vector2 Position => this.Center - this.Size * 0.5f;

    public Vector2 Size => new Vector2((float) Main.maxScreenW, (float) Main.maxScreenH);

    public Vector2 Center => this.Player.Center;
  }
}
