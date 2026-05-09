// Decompiled with JetBrains decompiler
// Type: go.Parsers.SeasonParser
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  public class SeasonParser : GenericParser
  {
    public static Season20 ParseSeason()
    {
      return SeasonParser.ParseSeason(Datas.Communications.GetPage("Calendar.asp"));
    }

    public static Season20 ParseSeason(string seasonPage)
    {
      Season20 season = new Season20();
      try
      {
        int startIndex = 0;
        for (int index = 0; index < season.Events.Length; ++index)
        {
          startIndex = seasonPage.IndexOf("TrackDetails.asp", startIndex) + 20;
          string s = seasonPage.Substring(startIndex, seasonPage.IndexOf("\"", startIndex) - startIndex);
          season.Events[index].Trackid = int.Parse(s);
        }
        return season;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing season", ex, seasonPage);
        return season;
      }
    }
  }
}
