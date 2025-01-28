// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.Achievements.CustomFlagCondition
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Terraria.Achievements;

#nullable disable
namespace Terraria.GameContent.Achievements
{
  public class CustomFlagCondition : AchievementCondition
  {
    private CustomFlagCondition(string name)
      : base(name)
    {
    }

    public static AchievementCondition Create(string name)
    {
      return (AchievementCondition) new CustomFlagCondition(name);
    }
  }
}
