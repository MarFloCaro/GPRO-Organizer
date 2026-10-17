 
// Type: go.Parsers.StrategyParser
 
 
 

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  public class StrategyParser : GenericParser
  {
    public static Strategy4 ParseStrategy()
    {
      return StrategyParser.ParseStrategy(Datas.Communications.GetPage("RaceSetup.asp"));
    }

    public static Strategy4 ParseStrategy(string setupPage)
    {
      Strategy4 strategy = new Strategy4();
      try
      {
        int startIndex1 = 0;
        if (setupPage.IndexOf("<font color=\"gray\">Get settings from Qualify 1") > 0)
          return strategy;
        strategy.isStrategyUpdated = true;
        int startIndex2 = setupPage.IndexOf("Front wing", startIndex1) + 8;
        int startIndex3 = setupPage.IndexOf("value", startIndex2) + 7;
        strategy.setup.fWing = ExtractIntUntil(setupPage, startIndex3, "\"");
        int startIndex4 = setupPage.IndexOf("value", startIndex3) + 7;
        strategy.setup.rWing = ExtractIntUntil(setupPage, startIndex4, "\"");
        int startIndex5 = setupPage.IndexOf("value", startIndex4) + 7;
        strategy.setup.engine = ExtractIntUntil(setupPage, startIndex5, "\"");
        int startIndex6 = setupPage.IndexOf("value", startIndex5) + 7;
        strategy.setup.brakes = ExtractIntUntil(setupPage, startIndex6, "\"");
        int startIndex7 = setupPage.IndexOf("value", startIndex6) + 7;
        strategy.setup.gear = ExtractIntUntil(setupPage, startIndex7, "\"");
        int startIndex8 = setupPage.IndexOf("value", startIndex7) + 7;
        strategy.setup.susp = ExtractIntUntil(setupPage, startIndex8, "\"");
        int startIndex9 = setupPage.IndexOf("Fuel strategy", startIndex8) + 7;
        int startIndex10 = setupPage.IndexOf("value", startIndex9) + 7;
        strategy.startFuel = ExtractIntUntil(setupPage, startIndex10, "\"");
        int startIndex11 = setupPage.IndexOf("value", startIndex10) + 7;
        strategy.stop1Fuel = ExtractIntUntil(setupPage, startIndex11, "\"");
        int startIndex12 = setupPage.IndexOf("value", startIndex11) + 7;
        strategy.stop2Fuel = ExtractIntUntil(setupPage, startIndex12, "\"");
        int startIndex13 = setupPage.IndexOf("value", startIndex12) + 7;
        strategy.stop3Fuel = ExtractIntUntil(setupPage, startIndex13, "\"");
        int startIndex14 = setupPage.IndexOf("value", startIndex13) + 7;
        strategy.stop4Fuel = ExtractIntUntil(setupPage, startIndex14, "\"");
        int startIndex15 = setupPage.IndexOf("value", startIndex14) + 7;
        strategy.stop5Fuel = ExtractIntUntil(setupPage, startIndex15, "\"");
        int startIndex16 = setupPage.IndexOf("Tyres strategy", startIndex15) + 7;
        int startIndex17 = setupPage.IndexOf("selected", startIndex16) + 9;
        string noget1 = ExtractUntil(setupPage, startIndex17, "<").Trim();
        strategy.startTyres = EnumConvert.String2Tyres(noget1);
        int startIndex18 = setupPage.IndexOf("selected", startIndex17) + 9;
        string noget2 = ExtractUntil(setupPage, startIndex18, "<").Trim();
        strategy.rainTyres = EnumConvert.String2Tyres(noget2);
        int startIndex19 = setupPage.IndexOf("selected", startIndex18) + 9;
        string noget3 = ExtractUntil(setupPage, startIndex19, "<").Trim();
        strategy.dryTyres = EnumConvert.String2Tyres(noget3);
        int startIndex20 = setupPage.IndexOf("LapsWaitPitRain", startIndex19) + 9;
        int startIndex21 = setupPage.IndexOf("value", startIndex20) + 7;
        strategy.pitAfterRain = ExtractIntUntil(setupPage, startIndex21, "\"");
        int startIndex22 = setupPage.IndexOf("value", startIndex21) + 7;
        strategy.pitAfterDry = ExtractIntUntil(setupPage, startIndex22, "\"");
        int startIndex23 = setupPage.IndexOf("<input", startIndex22) + 6;
        int startIndex24 = setupPage.IndexOf("value", startIndex23) + 7;
        strategy.riskOvertake = ExtractIntUntil(setupPage, startIndex24, "\"");
        int startIndex25 = setupPage.IndexOf("value", startIndex24) + 7;
        strategy.riskDefend = ExtractIntUntil(setupPage, startIndex25, "\"");
        int startIndex26 = setupPage.IndexOf("value", startIndex25) + 7;
        strategy.riskClear = ExtractIntUntil(setupPage, startIndex26, "\"");
        int startIndex27 = setupPage.IndexOf("value", startIndex26) + 7;
        strategy.riskWet = ExtractIntUntil(setupPage, startIndex27, "\"");
        int startIndex28 = setupPage.IndexOf("value", startIndex27) + 7;
        strategy.riskMalfunction = ExtractIntUntil(setupPage, startIndex28, "\"");
        int startIndex29 = setupPage.IndexOf("Boost laps", startIndex28) + 10;
        int startIndex30 = setupPage.IndexOf("<input", startIndex29) + 6;
        int startIndex31 = setupPage.IndexOf("value", startIndex30) + 7;
        strategy.boostLap1 = ExtractIntUntil(setupPage, startIndex31, "\"");
        int startIndex32 = setupPage.IndexOf("value", startIndex31) + 7;
        strategy.boostLap2 = ExtractIntUntil(setupPage, startIndex32, "\"");
        int startIndex33 = setupPage.IndexOf("value", startIndex32) + 7;
        strategy.boostLap3 = ExtractIntUntil(setupPage, startIndex33, "\"");
        int startIndex34 = setupPage.IndexOf("If a problem occurs", startIndex33) + 7;
        int startIndex35 = setupPage.IndexOf("selected", startIndex34) + 9;
        string str = ExtractUntil(setupPage, startIndex35, "<");
        strategy.pitIfSolvableProblem = str == "Yes";
        int startIndex36 = setupPage.IndexOf("LapsStopProb", startIndex35) + 7;
        int startIndex37 = setupPage.IndexOf("value", startIndex36) + 7;
        strategy.pitLapLimit = ExtractIntUntil(setupPage, startIndex37, "\"");
        int startIndex38 = setupPage.IndexOf("checkbox", startIndex37);
        strategy.dontrefuelOnTechnicalProblems = setupPage.IndexOf(" checked ", startIndex38) > 0;
        int startIndex39 = setupPage.IndexOf("selected", startIndex38) + 9;
        string noget4 = ExtractUntil(setupPage, startIndex39, "<");
        strategy.startStrategy = EnumConvert.String2Strategy(noget4);
        return strategy;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing strategy", ex, setupPage);
        return strategy;
      }
    }
  }
}
