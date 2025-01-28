// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.ResourceSets.IPlayerResourcesDisplaySet
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.DataStructures;

#nullable disable
namespace Terraria.GameContent.UI.ResourceSets
{
  public interface IPlayerResourcesDisplaySet : IConfigKeyHolder
  {
    void Draw();

    void TryToHover();
  }
}
