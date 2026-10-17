 
// Type: go.Parsers.QualifyParser
 
 
 

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  public class QualifyParser : GenericParser
  {
    public static Qualify ParseQualify1(string qualifyPage)
    {
      if (qualifyPage.IndexOf("<a href=\"SignRandomDriver.asp\"") > 0)
        throw new Exception("You do not have a driver");
      Qualify qualify1 = new Qualify();
      try
      {
        int startIndex1 = qualifyPage.IndexOf("TrackDetails.asp") + 20;
        qualify1.track = ExtractIntUntil(qualifyPage, startIndex1, "\"");
        int startIndex2 = qualifyPage.IndexOf("Practice / Qualify 1", startIndex1) + 15;
        int startIndex3 = qualifyPage.IndexOf("alt", startIndex2) + 5;
        qualify1.weather.skies = EnumConvert.String2Skies(ExtractUntil(qualifyPage, startIndex3, "\""));
        int startIndex4 = qualifyPage.IndexOf("Temp", startIndex3) + 6;
        qualify1.weather.temperature = ExtractIntUntil(qualifyPage, startIndex4, "&");
        int startIndex5 = qualifyPage.IndexOf("Humidity", startIndex4) + 10;
        qualify1.weather.humidity = ExtractIntUntil(qualifyPage, startIndex5, "%");
        int startIndex6 = qualifyPage.IndexOf("Qualify 1 lap data", startIndex5);
        if (startIndex6 < 0)
          return qualify1;
        int startIndex7 = qualifyPage.IndexOf("lime", startIndex6) + 9;
        string noget2 = qualifyPage.Substring(startIndex7, qualifyPage.IndexOf("<", startIndex7) - startIndex7 - 1);
        qualify1.time = EnumConvert.String2Time(noget2);
        int startIndex8 = qualifyPage.IndexOf("center", startIndex7) + 8;
        int startIndex9 = qualifyPage.IndexOf(">", startIndex8) + 1;
        qualify1.setup.fWing = ExtractIntUntil(qualifyPage, startIndex9, "<");
        int startIndex10 = qualifyPage.IndexOf("center", startIndex9) + 8;
        int startIndex11 = qualifyPage.IndexOf(">", startIndex10) + 1;
        qualify1.setup.rWing = ExtractIntUntil(qualifyPage, startIndex11, "<");
        int startIndex12 = qualifyPage.IndexOf("center", startIndex11) + 8;
        int startIndex13 = qualifyPage.IndexOf(">", startIndex12) + 1;
        qualify1.setup.engine = ExtractIntUntil(qualifyPage, startIndex13, "<");
        int startIndex14 = qualifyPage.IndexOf("center", startIndex13) + 8;
        int startIndex15 = qualifyPage.IndexOf(">", startIndex14) + 1;
        qualify1.setup.brakes = ExtractIntUntil(qualifyPage, startIndex15, "<");
        int startIndex16 = qualifyPage.IndexOf("center", startIndex15) + 8;
        int startIndex17 = qualifyPage.IndexOf(">", startIndex16) + 1;
        qualify1.setup.gear = ExtractIntUntil(qualifyPage, startIndex17, "<");
        int startIndex18 = qualifyPage.IndexOf("center", startIndex17) + 8;
        int startIndex19 = qualifyPage.IndexOf(">", startIndex18) + 1;
        qualify1.setup.susp = ExtractIntUntil(qualifyPage, startIndex19, "<");
        int startIndex20 = qualifyPage.IndexOf("center", startIndex19) + 8;
        int startIndex21 = qualifyPage.IndexOf(">", startIndex20) + 1;
        int startIndex22 = qualifyPage.IndexOf("center", startIndex21) + 8;
        int startIndex23 = qualifyPage.IndexOf(">", startIndex22) + 1;
        qualify1.setup.tyres = EnumConvert.String2Tyres(ExtractUntil(qualifyPage, startIndex23, "<"));
        int startIndex24 = qualifyPage.IndexOf("center", startIndex23) + 8;
        int startIndex25 = qualifyPage.IndexOf(">", startIndex24) + 1;
        qualify1.risk = EnumConvert.String2QualifyRisk(ExtractUntil(qualifyPage, startIndex25, "<"));
        return qualify1;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing qualify1", ex, qualifyPage);
        return qualify1;
      }
    }

    public static Qualify ParseQualify2(string qualifyPage)
    {
      Qualify qualify2 = new Qualify();
      if (qualifyPage.IndexOf("No qualify laps done") > 0)
        return qualify2;
      try
      {
        int startIndex1 = 0;
        int startIndex2 = qualifyPage.IndexOf("TrackDetails.asp", startIndex1) + 20;
        qualify2.track = ExtractIntUntil(qualifyPage, startIndex2, "\"");
        int startIndex3 = qualifyPage.IndexOf("Qualify 2 / Race start", startIndex2) + 15;
        int startIndex4 = qualifyPage.IndexOf("alt", startIndex3) + 5;
        qualify2.weather.skies = EnumConvert.String2Skies(ExtractUntil(qualifyPage, startIndex4, "\""));
        int startIndex5 = qualifyPage.IndexOf("Temp", startIndex4) + 6;
        qualify2.weather.temperature = ExtractIntUntil(qualifyPage, startIndex5, "&");
        int startIndex6 = qualifyPage.IndexOf("Humidity", startIndex5) + 10;
        qualify2.weather.humidity = ExtractIntUntil(qualifyPage, startIndex6, "%");
        int startIndex7 = qualifyPage.IndexOf("Qualify 2 lap data", startIndex6);
        int startIndex8 = qualifyPage.IndexOf("speccell\"", startIndex7) + 9;
        int startIndex9 = qualifyPage.IndexOf("<b>", startIndex8) + 3;
        if (startIndex9 <= 0)
          return qualify2;
        string noget2 = qualifyPage.Substring(startIndex9, qualifyPage.IndexOf("<", startIndex9) - startIndex9 - 1);
        qualify2.time = EnumConvert.String2Time(noget2);
        int startIndex10 = qualifyPage.IndexOf("center", startIndex9);
        int startIndex11 = qualifyPage.IndexOf(">", startIndex10) + 1;
        qualify2.setup.fWing = ExtractIntUntil(qualifyPage, startIndex11, "<");
        int startIndex12 = qualifyPage.IndexOf("center", startIndex11);
        int startIndex13 = qualifyPage.IndexOf(">", startIndex12) + 1;
        qualify2.setup.rWing = ExtractIntUntil(qualifyPage, startIndex13, "<");
        int startIndex14 = qualifyPage.IndexOf("center", startIndex13);
        int startIndex15 = qualifyPage.IndexOf(">", startIndex14) + 1;
        qualify2.setup.engine = ExtractIntUntil(qualifyPage, startIndex15, "<");
        int startIndex16 = qualifyPage.IndexOf("center", startIndex15);
        int startIndex17 = qualifyPage.IndexOf(">", startIndex16) + 1;
        qualify2.setup.brakes = ExtractIntUntil(qualifyPage, startIndex17, "<");
        int startIndex18 = qualifyPage.IndexOf("center", startIndex17);
        int startIndex19 = qualifyPage.IndexOf(">", startIndex18) + 1;
        qualify2.setup.gear = ExtractIntUntil(qualifyPage, startIndex19, "<");
        int startIndex20 = qualifyPage.IndexOf("center", startIndex19);
        int startIndex21 = qualifyPage.IndexOf(">", startIndex20) + 1;
        qualify2.setup.susp = ExtractIntUntil(qualifyPage, startIndex21, "<");
        int startIndex22 = qualifyPage.IndexOf("center", startIndex21);
        int startIndex23 = qualifyPage.IndexOf(">", startIndex22) + 1;
        qualify2.fuel = ExtractIntUntil(qualifyPage, startIndex23, "<");
        int startIndex24 = qualifyPage.IndexOf("center", startIndex23);
        int startIndex25 = qualifyPage.IndexOf(">", startIndex24) + 1;
        int startIndex26 = qualifyPage.IndexOf("center", startIndex25);
        int startIndex27 = qualifyPage.IndexOf(">", startIndex26) + 1;
        qualify2.setup.tyres = EnumConvert.String2Tyres(ExtractUntil(qualifyPage, startIndex27, "<"));
        int startIndex28 = qualifyPage.IndexOf("center", startIndex27);
        int startIndex29 = qualifyPage.IndexOf(">", startIndex28) + 1;
        qualify2.risk = EnumConvert.String2QualifyRisk(ExtractUntil(qualifyPage, startIndex29, "<"));
        return qualify2;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing qualify2", ex, qualifyPage);
        return qualify2;
      }
    }

    public static Qualify ParseQualify2()
    {
      return QualifyParser.ParseQualify2(Datas.Communications.GetPage("Qualify2.asp"));
    }

    public static Qualify ParseQualify1()
    {
      return QualifyParser.ParseQualify1(Datas.Communications.GetPage("Qualify.asp"));
    }
  }
}
