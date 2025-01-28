// Decompiled with JetBrains decompiler
// Type: Terraria.Social.Base.AWorkshopTagsCollection
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.Social.Base
{
  public abstract class AWorkshopTagsCollection
  {
    public readonly List<WorkshopTagOption> WorldTags = new List<WorkshopTagOption>();
    public readonly List<WorkshopTagOption> ResourcePackTags = new List<WorkshopTagOption>();

    protected void AddWorldTag(string tagNameKey, string tagInternalName)
    {
      this.WorldTags.Add(new WorkshopTagOption(tagNameKey, tagInternalName));
    }

    protected void AddResourcePackTag(string tagNameKey, string tagInternalName)
    {
      this.ResourcePackTags.Add(new WorkshopTagOption(tagNameKey, tagInternalName));
    }
  }
}
