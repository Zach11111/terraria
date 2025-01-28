// Decompiled with JetBrains decompiler
// Type: Terraria.DataStructures.GeneralIssueReporter
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using System.Collections.Generic;

#nullable disable
namespace Terraria.DataStructures
{
  public class GeneralIssueReporter : IProvideReports
  {
    private List<IssueReport> _reports = new List<IssueReport>();

    public void AddReport(string textToShow) => this._reports.Add(new IssueReport(textToShow));

    public List<IssueReport> GetReports() => this._reports;
  }
}
