// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.UI.States.UISortableElement
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.UI;

#nullable disable
namespace Terraria.GameContent.UI.States
{
  public class UISortableElement : UIElement
  {
    public int OrderIndex;

    public UISortableElement(int index) => this.OrderIndex = index;

    public override int CompareTo(object obj)
    {
      return obj is UISortableElement uiSortableElement ? this.OrderIndex.CompareTo(uiSortableElement.OrderIndex) : base.CompareTo(obj);
    }
  }
}
