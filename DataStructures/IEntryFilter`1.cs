// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.IEntryFilter`1
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.DataStructures
{
  public interface IEntryFilter<T>
  {
    bool FitsFilter(T entry);

    string GetDisplayNameKey();

    UIElement GetImage();
  }
}
