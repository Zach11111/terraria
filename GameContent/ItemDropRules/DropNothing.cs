// Decompiled with JetBrains decompiler
// Type: Terraria.GameContent.ItemDropRules.DropNothing
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.GameContent.ItemDropRules
{
  public class DropNothing : IItemDropRule
  {
    public List<IItemDropRuleChainAttempt> ChainedRules { get; private set; }

    public DropNothing() => this.ChainedRules = new List<IItemDropRuleChainAttempt>();

    public bool CanDrop(DropAttemptInfo info) => false;

    public ItemDropAttemptResult TryDroppingItem(DropAttemptInfo info)
    {
      return new ItemDropAttemptResult()
      {
        State = ItemDropAttemptResultState.DoesntFillConditions
      };
    }

    public void ReportDroprates(List<DropRateInfo> drops, DropRateInfoChainFeed ratesInfo)
    {
      Chains.ReportDroprates(this.ChainedRules, 1f, drops, ratesInfo);
    }
  }
}
