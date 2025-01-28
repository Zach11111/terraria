// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.GenPass
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.IO;

#nullable disable
namespace Terraria.WorldBuilding
{
  public abstract class GenPass : GenBase
  {
    public string Name;
    public double Weight;

    public GenPass(string name, double loadWeight)
    {
      this.Name = name;
      this.Weight = loadWeight;
    }

    protected abstract void ApplyPass(GenerationProgress progress, GameConfiguration configuration);

    public void Apply(GenerationProgress progress, GameConfiguration configuration)
    {
      this.ApplyPass(progress, configuration);
    }
  }
}
