// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.ContainerTransferContext
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Microsoft.Xna.Framework;

#nullable disable
namespace Terraria.DataStructures
{
  public struct ContainerTransferContext
  {
    private Vector2 _position;
    public bool CanVisualizeTransfers;

    public static ContainerTransferContext FromProjectile(Projectile projectile)
    {
      return new ContainerTransferContext(projectile.Center);
    }

    public static ContainerTransferContext FromBlockPosition(int x, int y)
    {
      return new ContainerTransferContext(new Vector2((float) (x * 16 + 16), (float) (y * 16 + 16)));
    }

    public static ContainerTransferContext FromUnknown(Player player)
    {
      return new ContainerTransferContext()
      {
        CanVisualizeTransfers = false
      };
    }

    public ContainerTransferContext(Vector2 position)
    {
      this._position = position;
      this.CanVisualizeTransfers = true;
    }

    public Vector2 GetContainerWorldPosition() => this._position;
  }
}
