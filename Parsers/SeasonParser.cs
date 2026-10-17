 
// Type: go.Parsers.SeasonParser
 
 
 

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
          season.Events[index].Trackid = ExtractIntUntil(seasonPage, startIndex, "\"");
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
