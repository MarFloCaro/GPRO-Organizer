// Decompiled with JetBrains decompiler
// Type: go.Parsers.RaceSummaryParser
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Utils;
using System;
using System.Collections;

#nullable disable
namespace go.Parsers
{
  internal class RaceSummaryParser : GenericParser
  {
    public static RaceSummary GetRaceSummary(string groupName)
    {
      return RaceSummaryParser.GetRaceSummaryPage(Datas.Communications.GetPage("RaceSummary.asp?Group=" + Datas.Communications.ConvertToPageEncoding(groupName)));
    }

    private static RaceSummary GetRaceSummaryPage(string page)
    {
      RaceSummary raceSummaryPage = new RaceSummary();
      ArrayList list1 = new ArrayList();
      ArrayList list2 = new ArrayList();
      try
      {
        if (string.IsNullOrEmpty(page) || page.IndexOf("The race summary will be available shortly after the end of the race") > 0 || page.IndexOf("No race summary data is available for this group") > 0)
          return raceSummaryPage;
        int num1 = page.IndexOf("Best pit time");
        int num2 = page.IndexOf("Not classified");
        if (num2 < 0)
          num2 = page.Length;
        int num3 = page.IndexOf("</table>", num1);
        TimeSpan winnerTime = TimeSpan.MinValue;
        int num4 = 1;
        while (num1 + 42 < num3)
        {
          RaceSummaryLine raceSummaryLine = new RaceSummaryLine();
          int startIndex1 = page.IndexOf("<tr", num1);
          int startIndex2 = page.IndexOf("<td", startIndex1);
          num1 = page.IndexOf(">", startIndex2) + 1;
          if (page[num1] != '<')
          {
            raceSummaryLine.pos = num4;
            int startIndex3 = page.IndexOf("/images/", num1) + 8;
            int startIndex4 = page.IndexOf(" alt=", startIndex3) + 6;
            string s1 = page.Substring(startIndex4, page.IndexOf("\"", startIndex4) - startIndex4);
            if (s1 != "No change")
              raceSummaryLine.progress = int.Parse(s1);
            int startIndex5 = page.IndexOf("<td", startIndex4);
            int startIndex6 = page.IndexOf("<td", startIndex5);
            int startIndex7 = page.IndexOf("ManagerProfile.asp?IDM", startIndex6) + 23;
            string s2 = page.Substring(startIndex7, page.IndexOf("\"", startIndex7) - startIndex7);
            raceSummaryLine.managerID = int.Parse(s2);
            int startIndex8 = page.IndexOf(">", startIndex7) + 1;
            if (page.Substring(startIndex8).StartsWith("<font"))
              startIndex8 = page.IndexOf(">", startIndex8) + 1;
            raceSummaryLine.managerName = Datas.Communications.ConvertFromUrlEncoding(page.Substring(startIndex8, page.IndexOf("<", startIndex8) - startIndex8));
            int startIndex9 = page.IndexOf("<td", startIndex8);
            int startIndex10 = page.IndexOf(">", startIndex9) + 1;
            string noget1 = page.Substring(startIndex10, page.IndexOf("</td>", startIndex10) - startIndex10);
            if (num4 == 1)
            {
              raceSummaryLine.raceTime = GenericParser.ParseTimeSpan(noget1);
              winnerTime = raceSummaryLine.raceTime;
            }
            else
            {
              raceSummaryLine.raceTime = RaceSummaryParser.ParseSummaryGap(winnerTime, noget1);
              if (raceSummaryLine.raceTime == TimeSpan.MinValue)
                raceSummaryLine.NoTimeReason = noget1;
            }
            int startIndex11 = page.IndexOf("<td", startIndex10);
            int startIndex12 = page.IndexOf(">", startIndex11) + 1;
            string s3 = page.Substring(startIndex12, page.IndexOf("<", startIndex12) - startIndex12);
            raceSummaryLine.laps = int.Parse(s3);
            int startIndex13 = page.IndexOf("<td", startIndex12);
            int startIndex14 = page.IndexOf(">", startIndex13) + 1;
            string s4 = page.Substring(startIndex14, page.IndexOf("<", startIndex14) - startIndex14);
            raceSummaryLine.pitStops = int.Parse(s4);
            int startIndex15 = page.IndexOf("<td", startIndex14);
            int startIndex16 = page.IndexOf(">", startIndex15) + 1;
            if (page.Substring(startIndex16, page.IndexOf("<", startIndex16) - startIndex16) == "")
            {
              startIndex16 = page.IndexOf(">", startIndex16) + 1;
              raceSummaryLine.BestLapOfAll = true;
            }
            string noget2 = page.Substring(startIndex16, page.IndexOf("<", startIndex16) - startIndex16);
            raceSummaryLine.bestLap = !noget2.Equals("&nbsp;") ? GenericParser.ParseTimeSpan(noget2) : TimeSpan.Zero;
            int startIndex17 = page.IndexOf("<td", startIndex16);
            int startIndex18 = page.IndexOf(">", startIndex17) + 1;
            string noget3 = page.Substring(startIndex18, page.IndexOf("<", startIndex18) - startIndex18);
            raceSummaryLine.averageSpeed = !noget3.Equals("&nbsp;") ? Util.ParseDouble(noget3) : 0.0;
            int startIndex19 = page.IndexOf("<td", startIndex18) + 1;
            int startIndex20 = page.IndexOf("<td", startIndex19);
            num1 = page.IndexOf(">", startIndex20) + 1;
            int num5 = page.IndexOf("</td>", num1);
            if (page.IndexOf("<font", num1) < num5)
              num1 = page.IndexOf(">", num1) + 1;
            string noget4 = page.Substring(num1, page.IndexOf("<", num1) - num1);
            raceSummaryLine.bestPitTime = !noget4.Equals("&nbsp;") ? GenericParser.ParseTimeSpan(noget4) : TimeSpan.Zero;
            if (num1 < num2)
              list1.Add((object) raceSummaryLine);
            else
              list2.Add((object) raceSummaryLine);
            ++num4;
          }
        }
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Race Summary parsing failed", ex, page);
      }
      raceSummaryPage.classified = RaceSummaryParser.GetLine(list1);
      raceSummaryPage.notClassified = RaceSummaryParser.GetLine(list2);
      return raceSummaryPage;
    }

    private static RaceSummaryLine[] GetLine(ArrayList list)
    {
      RaceSummaryLine[] line = new RaceSummaryLine[list.Count];
      for (int index = 0; index < list.Count; ++index)
        line[index] = (RaceSummaryLine) list[index];
      return line;
    }

    private static TimeSpan ParseSummaryGap(TimeSpan winnerTime, string noget)
    {
      TimeSpan timeSpan = GenericParser.ParseTimeSpan(noget.Substring(2));
      return timeSpan == TimeSpan.MinValue ? timeSpan : timeSpan.Add(winnerTime);
    }
  }
}
