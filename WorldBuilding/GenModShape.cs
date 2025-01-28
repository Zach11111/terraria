// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenModShape
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.WorldBuilding
{
  public abstract class GenModShape : GenShape
  {
    protected ShapeData _data;

    public GenModShape(ShapeData data) => this._data = data;
  }
}
