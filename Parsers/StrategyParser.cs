 
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
        string s1 = setupPage.Substring(startIndex3, setupPage.IndexOf("\"", startIndex3) - startIndex3);
        strategy.setup.fWing = int.Parse(s1);
        int startIndex4 = setupPage.IndexOf("value", startIndex3) + 7;
        string s2 = setupPage.Substring(startIndex4, setupPage.IndexOf("\"", startIndex4) - startIndex4);
        strategy.setup.rWing = int.Parse(s2);
        int startIndex5 = setupPage.IndexOf("value", startIndex4) + 7;
        string s3 = setupPage.Substring(startIndex5, setupPage.IndexOf("\"", startIndex5) - startIndex5);
        strategy.setup.engine = int.Parse(s3);
        int startIndex6 = setupPage.IndexOf("value", startIndex5) + 7;
        string s4 = setupPage.Substring(startIndex6, setupPage.IndexOf("\"", startIndex6) - startIndex6);
        strategy.setup.brakes = int.Parse(s4);
        int startIndex7 = setupPage.IndexOf("value", startIndex6) + 7;
        string s5 = setupPage.Substring(startIndex7, setupPage.IndexOf("\"", startIndex7) - startIndex7);
        strategy.setup.gear = int.Parse(s5);
        int startIndex8 = setupPage.IndexOf("value", startIndex7) + 7;
        string s6 = setupPage.Substring(startIndex8, setupPage.IndexOf("\"", startIndex8) - startIndex8);
        strategy.setup.susp = int.Parse(s6);
        int startIndex9 = setupPage.IndexOf("Fuel strategy", startIndex8) + 7;
        int startIndex10 = setupPage.IndexOf("value", startIndex9) + 7;
        string s7 = setupPage.Substring(startIndex10, setupPage.IndexOf("\"", startIndex10) - startIndex10);
        strategy.startFuel = int.Parse(s7);
        int startIndex11 = setupPage.IndexOf("value", startIndex10) + 7;
        string s8 = setupPage.Substring(startIndex11, setupPage.IndexOf("\"", startIndex11) - startIndex11);
        strategy.stop1Fuel = int.Parse(s8);
        int startIndex12 = setupPage.IndexOf("value", startIndex11) + 7;
        string s9 = setupPage.Substring(startIndex12, setupPage.IndexOf("\"", startIndex12) - startIndex12);
        strategy.stop2Fuel = int.Parse(s9);
        int startIndex13 = setupPage.IndexOf("value", startIndex12) + 7;
        string s10 = setupPage.Substring(startIndex13, setupPage.IndexOf("\"", startIndex13) - startIndex13);
        strategy.stop3Fuel = int.Parse(s10);
        int startIndex14 = setupPage.IndexOf("value", startIndex13) + 7;
        string s11 = setupPage.Substring(startIndex14, setupPage.IndexOf("\"", startIndex14) - startIndex14);
        strategy.stop4Fuel = int.Parse(s11);
        int startIndex15 = setupPage.IndexOf("value", startIndex14) + 7;
        string s12 = setupPage.Substring(startIndex15, setupPage.IndexOf("\"", startIndex15) - startIndex15);
        strategy.stop5Fuel = int.Parse(s12);
        int startIndex16 = setupPage.IndexOf("Tyres strategy", startIndex15) + 7;
        int startIndex17 = setupPage.IndexOf("selected", startIndex16) + 9;
        string noget1 = setupPage.Substring(startIndex17, setupPage.IndexOf("<", startIndex17) - startIndex17).Trim();
        strategy.startTyres = StringToEnum.String2Tyres(noget1);
        int startIndex18 = setupPage.IndexOf("selected", startIndex17) + 9;
        string noget2 = setupPage.Substring(startIndex18, setupPage.IndexOf("<", startIndex18) - startIndex18).Trim();
        strategy.rainTyres = StringToEnum.String2Tyres(noget2);
        int startIndex19 = setupPage.IndexOf("selected", startIndex18) + 9;
        string noget3 = setupPage.Substring(startIndex19, setupPage.IndexOf("<", startIndex19) - startIndex19).Trim();
        strategy.dryTyres = StringToEnum.String2Tyres(noget3);
        int startIndex20 = setupPage.IndexOf("LapsWaitPitRain", startIndex19) + 9;
        int startIndex21 = setupPage.IndexOf("value", startIndex20) + 7;
        string s13 = setupPage.Substring(startIndex21, setupPage.IndexOf("\"", startIndex21) - startIndex21);
        strategy.pitAfterRain = int.Parse(s13);
        int startIndex22 = setupPage.IndexOf("value", startIndex21) + 7;
        string s14 = setupPage.Substring(startIndex22, setupPage.IndexOf("\"", startIndex22) - startIndex22);
        strategy.pitAfterDry = int.Parse(s14);
        int startIndex23 = setupPage.IndexOf("<input", startIndex22) + 6;
        int startIndex24 = setupPage.IndexOf("value", startIndex23) + 7;
        string s15 = setupPage.Substring(startIndex24, setupPage.IndexOf("\"", startIndex24) - startIndex24);
        strategy.riskOvertake = int.Parse(s15);
        int startIndex25 = setupPage.IndexOf("value", startIndex24) + 7;
        string s16 = setupPage.Substring(startIndex25, setupPage.IndexOf("\"", startIndex25) - startIndex25);
        strategy.riskDefend = int.Parse(s16);
        int startIndex26 = setupPage.IndexOf("value", startIndex25) + 7;
        string s17 = setupPage.Substring(startIndex26, setupPage.IndexOf("\"", startIndex26) - startIndex26);
        strategy.riskClear = int.Parse(s17);
        int startIndex27 = setupPage.IndexOf("value", startIndex26) + 7;
        string s18 = setupPage.Substring(startIndex27, setupPage.IndexOf("\"", startIndex27) - startIndex27);
        strategy.riskWet = int.Parse(s18);
        int startIndex28 = setupPage.IndexOf("value", startIndex27) + 7;
        string s19 = setupPage.Substring(startIndex28, setupPage.IndexOf("\"", startIndex28) - startIndex28);
        strategy.riskMalfunction = int.Parse(s19);
        int startIndex29 = setupPage.IndexOf("Boost laps", startIndex28) + 10;
        int startIndex30 = setupPage.IndexOf("<input", startIndex29) + 6;
        int startIndex31 = setupPage.IndexOf("value", startIndex30) + 7;
        string s20 = setupPage.Substring(startIndex31, setupPage.IndexOf("\"", startIndex31) - startIndex31);
        strategy.boostLap1 = int.Parse(s20);
        int startIndex32 = setupPage.IndexOf("value", startIndex31) + 7;
        string s21 = setupPage.Substring(startIndex32, setupPage.IndexOf("\"", startIndex32) - startIndex32);
        strategy.boostLap2 = int.Parse(s21);
        int startIndex33 = setupPage.IndexOf("value", startIndex32) + 7;
        string s22 = setupPage.Substring(startIndex33, setupPage.IndexOf("\"", startIndex33) - startIndex33);
        strategy.boostLap3 = int.Parse(s22);
        int startIndex34 = setupPage.IndexOf("If a problem occurs", startIndex33) + 7;
        int startIndex35 = setupPage.IndexOf("selected", startIndex34) + 9;
        string str = setupPage.Substring(startIndex35, setupPage.IndexOf("<", startIndex35) - startIndex35);
        strategy.pitIfSolvableProblem = str == "Yes";
        int startIndex36 = setupPage.IndexOf("LapsStopProb", startIndex35) + 7;
        int startIndex37 = setupPage.IndexOf("value", startIndex36) + 7;
        string s23 = setupPage.Substring(startIndex37, setupPage.IndexOf("\"", startIndex37) - startIndex37);
        strategy.pitLapLimit = int.Parse(s23);
        int startIndex38 = setupPage.IndexOf("checkbox", startIndex37);
        strategy.dontrefuelOnTechnicalProblems = setupPage.IndexOf(" checked ", startIndex38) > 0;
        int startIndex39 = setupPage.IndexOf("selected", startIndex38) + 9;
        string noget4 = setupPage.Substring(startIndex39, setupPage.IndexOf("<", startIndex39) - startIndex39);
        strategy.startStrategy = StringToEnum.String2Strategy(noget4);
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
