// Decompiled with JetBrains decompiler
// Type: go.Parsers.QualifyParser
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
        string s1 = qualifyPage.Substring(startIndex1, qualifyPage.IndexOf("\"", startIndex1) - startIndex1);
        qualify1.track = int.Parse(s1);
        int startIndex2 = qualifyPage.IndexOf("Practice / Qualify 1", startIndex1) + 15;
        int startIndex3 = qualifyPage.IndexOf("alt", startIndex2) + 5;
        string noget1 = qualifyPage.Substring(startIndex3, qualifyPage.IndexOf("\"", startIndex3) - startIndex3);
        qualify1.weather.skies = StringToEnum.String2Skies(noget1);
        int startIndex4 = qualifyPage.IndexOf("Temp", startIndex3) + 6;
        string s2 = qualifyPage.Substring(startIndex4, qualifyPage.IndexOf("&", startIndex4) - startIndex4);
        qualify1.weather.temperature = int.Parse(s2);
        int startIndex5 = qualifyPage.IndexOf("Humidity", startIndex4) + 10;
        string s3 = qualifyPage.Substring(startIndex5, qualifyPage.IndexOf("%", startIndex5) - startIndex5);
        qualify1.weather.humidity = int.Parse(s3);
        int startIndex6 = qualifyPage.IndexOf("Qualify 1 lap data", startIndex5);
        if (startIndex6 < 0)
          return qualify1;
        int startIndex7 = qualifyPage.IndexOf("lime", startIndex6) + 9;
        string noget2 = qualifyPage.Substring(startIndex7, qualifyPage.IndexOf("<", startIndex7) - startIndex7 - 1);
        qualify1.time = StringToEnum.String2Time(noget2);
        int startIndex8 = qualifyPage.IndexOf("center", startIndex7) + 8;
        int startIndex9 = qualifyPage.IndexOf(">", startIndex8) + 1;
        string s4 = qualifyPage.Substring(startIndex9, qualifyPage.IndexOf("<", startIndex9) - startIndex9);
        qualify1.setup.fWing = int.Parse(s4);
        int startIndex10 = qualifyPage.IndexOf("center", startIndex9) + 8;
        int startIndex11 = qualifyPage.IndexOf(">", startIndex10) + 1;
        string s5 = qualifyPage.Substring(startIndex11, qualifyPage.IndexOf("<", startIndex11) - startIndex11);
        qualify1.setup.rWing = int.Parse(s5);
        int startIndex12 = qualifyPage.IndexOf("center", startIndex11) + 8;
        int startIndex13 = qualifyPage.IndexOf(">", startIndex12) + 1;
        string s6 = qualifyPage.Substring(startIndex13, qualifyPage.IndexOf("<", startIndex13) - startIndex13);
        qualify1.setup.engine = int.Parse(s6);
        int startIndex14 = qualifyPage.IndexOf("center", startIndex13) + 8;
        int startIndex15 = qualifyPage.IndexOf(">", startIndex14) + 1;
        string s7 = qualifyPage.Substring(startIndex15, qualifyPage.IndexOf("<", startIndex15) - startIndex15);
        qualify1.setup.brakes = int.Parse(s7);
        int startIndex16 = qualifyPage.IndexOf("center", startIndex15) + 8;
        int startIndex17 = qualifyPage.IndexOf(">", startIndex16) + 1;
        string s8 = qualifyPage.Substring(startIndex17, qualifyPage.IndexOf("<", startIndex17) - startIndex17);
        qualify1.setup.gear = int.Parse(s8);
        int startIndex18 = qualifyPage.IndexOf("center", startIndex17) + 8;
        int startIndex19 = qualifyPage.IndexOf(">", startIndex18) + 1;
        string s9 = qualifyPage.Substring(startIndex19, qualifyPage.IndexOf("<", startIndex19) - startIndex19);
        qualify1.setup.susp = int.Parse(s9);
        int startIndex20 = qualifyPage.IndexOf("center", startIndex19) + 8;
        int startIndex21 = qualifyPage.IndexOf(">", startIndex20) + 1;
        int startIndex22 = qualifyPage.IndexOf("center", startIndex21) + 8;
        int startIndex23 = qualifyPage.IndexOf(">", startIndex22) + 1;
        string noget3 = qualifyPage.Substring(startIndex23, qualifyPage.IndexOf("<", startIndex23) - startIndex23);
        qualify1.setup.tyres = StringToEnum.String2Tyres(noget3);
        int startIndex24 = qualifyPage.IndexOf("center", startIndex23) + 8;
        int startIndex25 = qualifyPage.IndexOf(">", startIndex24) + 1;
        string noget4 = qualifyPage.Substring(startIndex25, qualifyPage.IndexOf("<", startIndex25) - startIndex25);
        qualify1.risk = StringToEnum.String2QualifyRisk(noget4);
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
        string s1 = qualifyPage.Substring(startIndex2, qualifyPage.IndexOf("\"", startIndex2) - startIndex2);
        qualify2.track = int.Parse(s1);
        int startIndex3 = qualifyPage.IndexOf("Qualify 2 / Race start", startIndex2) + 15;
        int startIndex4 = qualifyPage.IndexOf("alt", startIndex3) + 5;
        string noget1 = qualifyPage.Substring(startIndex4, qualifyPage.IndexOf("\"", startIndex4) - startIndex4);
        qualify2.weather.skies = StringToEnum.String2Skies(noget1);
        int startIndex5 = qualifyPage.IndexOf("Temp", startIndex4) + 6;
        string s2 = qualifyPage.Substring(startIndex5, qualifyPage.IndexOf("&", startIndex5) - startIndex5);
        qualify2.weather.temperature = int.Parse(s2);
        int startIndex6 = qualifyPage.IndexOf("Humidity", startIndex5) + 10;
        string s3 = qualifyPage.Substring(startIndex6, qualifyPage.IndexOf("%", startIndex6) - startIndex6);
        qualify2.weather.humidity = int.Parse(s3);
        int startIndex7 = qualifyPage.IndexOf("Qualify 2 lap data", startIndex6);
        int startIndex8 = qualifyPage.IndexOf("speccell\"", startIndex7) + 9;
        int startIndex9 = qualifyPage.IndexOf("<b>", startIndex8) + 3;
        if (startIndex9 <= 0)
          return qualify2;
        string noget2 = qualifyPage.Substring(startIndex9, qualifyPage.IndexOf("<", startIndex9) - startIndex9 - 1);
        qualify2.time = StringToEnum.String2Time(noget2);
        int startIndex10 = qualifyPage.IndexOf("center", startIndex9);
        int startIndex11 = qualifyPage.IndexOf(">", startIndex10) + 1;
        string s4 = qualifyPage.Substring(startIndex11, qualifyPage.IndexOf("<", startIndex11) - startIndex11);
        qualify2.setup.fWing = int.Parse(s4);
        int startIndex12 = qualifyPage.IndexOf("center", startIndex11);
        int startIndex13 = qualifyPage.IndexOf(">", startIndex12) + 1;
        string s5 = qualifyPage.Substring(startIndex13, qualifyPage.IndexOf("<", startIndex13) - startIndex13);
        qualify2.setup.rWing = int.Parse(s5);
        int startIndex14 = qualifyPage.IndexOf("center", startIndex13);
        int startIndex15 = qualifyPage.IndexOf(">", startIndex14) + 1;
        string s6 = qualifyPage.Substring(startIndex15, qualifyPage.IndexOf("<", startIndex15) - startIndex15);
        qualify2.setup.engine = int.Parse(s6);
        int startIndex16 = qualifyPage.IndexOf("center", startIndex15);
        int startIndex17 = qualifyPage.IndexOf(">", startIndex16) + 1;
        string s7 = qualifyPage.Substring(startIndex17, qualifyPage.IndexOf("<", startIndex17) - startIndex17);
        qualify2.setup.brakes = int.Parse(s7);
        int startIndex18 = qualifyPage.IndexOf("center", startIndex17);
        int startIndex19 = qualifyPage.IndexOf(">", startIndex18) + 1;
        string s8 = qualifyPage.Substring(startIndex19, qualifyPage.IndexOf("<", startIndex19) - startIndex19);
        qualify2.setup.gear = int.Parse(s8);
        int startIndex20 = qualifyPage.IndexOf("center", startIndex19);
        int startIndex21 = qualifyPage.IndexOf(">", startIndex20) + 1;
        string s9 = qualifyPage.Substring(startIndex21, qualifyPage.IndexOf("<", startIndex21) - startIndex21);
        qualify2.setup.susp = int.Parse(s9);
        int startIndex22 = qualifyPage.IndexOf("center", startIndex21);
        int startIndex23 = qualifyPage.IndexOf(">", startIndex22) + 1;
        string s10 = qualifyPage.Substring(startIndex23, qualifyPage.IndexOf("<", startIndex23) - startIndex23);
        qualify2.fuel = int.Parse(s10);
        int startIndex24 = qualifyPage.IndexOf("center", startIndex23);
        int startIndex25 = qualifyPage.IndexOf(">", startIndex24) + 1;
        int startIndex26 = qualifyPage.IndexOf("center", startIndex25);
        int startIndex27 = qualifyPage.IndexOf(">", startIndex26) + 1;
        string noget3 = qualifyPage.Substring(startIndex27, qualifyPage.IndexOf("<", startIndex27) - startIndex27);
        qualify2.setup.tyres = StringToEnum.String2Tyres(noget3);
        int startIndex28 = qualifyPage.IndexOf("center", startIndex27);
        int startIndex29 = qualifyPage.IndexOf(">", startIndex28) + 1;
        string noget4 = qualifyPage.Substring(startIndex29, qualifyPage.IndexOf("<", startIndex29) - startIndex29);
        qualify2.risk = StringToEnum.String2QualifyRisk(noget4);
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
