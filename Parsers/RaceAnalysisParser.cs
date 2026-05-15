 
// Type: go.Parsers.RaceAnalysisParser
 
 
 

using go.Enums;
using go.Utils;
using System;
using System.Collections;
using System.Globalization;

#nullable disable
namespace go.Parsers
{
  public class RaceAnalysisParser : GenericParser
  {
    public static Race9 ParseRace(RaceEvent20 raceEvent)
    {
      return RaceAnalysisParser.ParseRace(Datas.Communications.GetPage("RaceAnalysis.asp"), raceEvent);
    }

    public static Race9 ParseRace(string racePage, RaceEvent20 raceEvent)
    {
      if (racePage.IndexOf("The race analysis and all other information for this race is locked") > 0)
        return (Race9) null;
      if (racePage.IndexOf("The race analysis will be available shortly after the end of the race") > 0)
        throw new Exception("There is no available race analysis on the GPRO page to download.");
      try
      {
        int num2 = racePage.IndexOf("TrackDetails") + 20;
        string s1 = racePage.Substring(num2, racePage.IndexOf("\"", num2) - num2);
        int num1 = 0;
        int num3 = int.Parse(s1);
        int laps = Datas.GetTrack(num3).laps + 1;
        Race9 race = new Race9(laps);
        bool flag = false;
        if (racePage.IndexOf("Dropped out") > 0 || racePage.IndexOf("Tyre puncture") > 0 || racePage.IndexOf("Start accident") > 0)
          race.DidFinishRace = false;
        if (racePage.IndexOf("Start accident") > 0)
          flag = true;
        num2 = racePage.IndexOf("<h2>Car wear &amp; lap information</h2>");
        if (raceEvent != null)
        {
          num2 = racePage.IndexOf("<tr onmouseover=", num2);
          raceEvent.Startcar.chassis.level = nextCellValue("");
          raceEvent.Startcar.engine.level = nextCellValue("");
          raceEvent.Startcar.frontWing.level = nextCellValue("");
          raceEvent.Startcar.rearWing.level = nextCellValue("");
          raceEvent.Startcar.underbody.level = nextCellValue("");
          raceEvent.Startcar.sidepods.level = nextCellValue("");
          raceEvent.Startcar.cooling.level = nextCellValue("");
          raceEvent.Startcar.gearBox.level = nextCellValue("");
          raceEvent.Startcar.brakes.level = nextCellValue("");
          raceEvent.Startcar.suspension.level = nextCellValue("");
          raceEvent.Startcar.electronics.level = nextCellValue("");
          raceEvent.Endcar.CopyLevels(raceEvent.Startcar);
          num2 = racePage.IndexOf("<tr onmouseover=", num2);
          raceEvent.Startcar.chassis.wear = nextCellValue("%");
          raceEvent.Startcar.engine.wear = nextCellValue("%");
          raceEvent.Startcar.frontWing.wear = nextCellValue("%");
          raceEvent.Startcar.rearWing.wear = nextCellValue("%");
          raceEvent.Startcar.underbody.wear = nextCellValue("%");
          raceEvent.Startcar.sidepods.wear = nextCellValue("%");
          raceEvent.Startcar.cooling.wear = nextCellValue("%");
          raceEvent.Startcar.gearBox.wear = nextCellValue("%");
          raceEvent.Startcar.brakes.wear = nextCellValue("%");
          raceEvent.Startcar.suspension.wear = nextCellValue("%");
          raceEvent.Startcar.electronics.wear = nextCellValue("%");
          num2 = racePage.IndexOf("<tr onmouseover=", num2);
          raceEvent.Endcar.chassis.wear = nextCellValue("%");
          raceEvent.Endcar.engine.wear = nextCellValue("%");
          raceEvent.Endcar.frontWing.wear = nextCellValue("%");
          raceEvent.Endcar.rearWing.wear = nextCellValue("%");
          raceEvent.Endcar.underbody.wear = nextCellValue("%");
          raceEvent.Endcar.sidepods.wear = nextCellValue("%");
          raceEvent.Endcar.cooling.wear = nextCellValue("%");
          raceEvent.Endcar.gearBox.wear = nextCellValue("%");
          raceEvent.Endcar.brakes.wear = nextCellValue("%");
          raceEvent.Endcar.suspension.wear = nextCellValue("%");
          raceEvent.Endcar.electronics.wear = nextCellValue("%");
        }
        num2 = racePage.IndexOf("Lap", num2);
        for (int index = 0; index < laps; ++index)
        {
          Lap2 lap2 = new Lap2();
          num2 = racePage.IndexOf("racescreen.asp", num2);
          num2 = racePage.IndexOf(">", num2) + 1;
          string s2 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
          lap2.lapNumber = int.Parse(s2);
          if (flag)
          {
            lap2.lapTime = TimeSpan.Zero;
            num2 = racePage.IndexOf("</td>", num2) + 5;
            num2 = racePage.IndexOf("</td>", num2);
          }
          else
          {
            num2 = racePage.IndexOf("<td class=\"center", num2) + 18;
            num2 = racePage.IndexOf(">", num2) + 1;
            string str = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
            switch (str)
            {
              case "-":
                lap2.lapTime = TimeSpan.Zero;
                goto label_17;
              case "":
                num2 += 19;
                str = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
                break;
            }
            num1 = str.IndexOf(">") + 1;
            int length = str.IndexOf(":");
            int minutes = length <= 0 ? 0 : int.Parse(str.Substring(0, length));
            int seconds = int.Parse(str.Substring(length + 1, str.IndexOf(".") - length - 1));
            int milliseconds = int.Parse(str.Substring(str.IndexOf(".") + 1));
            lap2.lapTime = new TimeSpan(0, 0, minutes, seconds, milliseconds);
          }
label_17:
          num2 = racePage.IndexOf("<b>", num2) + 3;
          string s3 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
          lap2.position = int.Parse(s3);
          num2 = racePage.IndexOf("<font color", num2) + 13;
          if (racePage.Substring(num2, racePage.IndexOf("\"", num2) - num2) == "#8C8C8C")
            lap2.goodTyres = false;
          num2 = racePage.IndexOf("<b>", num2) + 3;
          string noget = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
          switch (noget)
          {
            case "Extra Soft":
              lap2.tyres = TyreType.ExtraSoft;
              break;
            case "Soft":
              lap2.tyres = TyreType.Soft;
              break;
            case "Medium":
              lap2.tyres = TyreType.Medium;
              break;
            case "Hard":
              lap2.tyres = TyreType.Hard;
              break;
            default:
              lap2.tyres = TyreType.Rain;
              break;
          }
          num2 = racePage.IndexOf("center", num2);
          num2 = racePage.IndexOf(">", num2) + 1;
          if (racePage.Substring(num2, 3) == "<b>")
            lap2.weather.skies = Skies.Rain;
          else
            noget = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
          lap2.weather.skies = StringToEnum.String2Skies(noget);
          num2 = racePage.IndexOf("\"center\"", num2);
          num2 = racePage.IndexOf(">", num2) + 1;
          string s4 = racePage.Substring(num2, racePage.IndexOf("&#176;", num2) - num2);
          lap2.weather.temperature = int.Parse(s4);
          num2 = racePage.IndexOf("\"center\"", num2);
          num2 = racePage.IndexOf(">", num2) + 1;
          string s5 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
          lap2.weather.humidity = int.Parse(s5);
          num2 = racePage.IndexOf("center", num2);
          int startIndex = racePage.IndexOf(">", num2) + 1;
          if (startIndex < racePage.IndexOf("</td>", num2))
            lap2.events = GenericParser.GetRidOfLinks(racePage.Substring(startIndex, racePage.IndexOf("</td>", num2) - startIndex));
          race.Laps[index] = lap2;
        }
        if (flag)
          race.Laps[1].events = "Start Accident";
        num2 = racePage.IndexOf("Driver energy", num2);
        num2 = racePage.IndexOf("<div class=\"barLabel", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s6 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
        race.DriverEnergy.BeforeQ1 = int.Parse(s6);
        num2 = racePage.IndexOf("<div class=\"barLabel", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s7 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
        race.DriverEnergy.AfterQ1 = int.Parse(s7);
        num2 = racePage.IndexOf("<div class=\"barLabel", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s8 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
        race.DriverEnergy.BeforeQ2 = int.Parse(s8);
        num2 = racePage.IndexOf("<div class=\"barLabel", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s9 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
        race.DriverEnergy.AfterQ2 = int.Parse(s9);
        num2 = racePage.IndexOf("<div class=\"barLabel", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s10 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
        race.DriverEnergy.BeforeRace = int.Parse(s10);
        num2 = racePage.IndexOf("<div class=\"barLabel", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s11 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
        race.DriverEnergy.AfterRace = int.Parse(s11);
        num2 = racePage.IndexOf("Qualify 2 / Race start") + 1;
        num2 = racePage.IndexOf("<img ", num2) + 1;
        num2 = racePage.IndexOf("<img ", num2) + 1;
        num2 = racePage.IndexOf("alt=", num2) + 5;
        string noget1 = racePage.Substring(num2, racePage.IndexOf("\"", num2) - num2);
        race.Laps[0].weather.skies = StringToEnum.String2Skies(noget1);
        num2 = racePage.IndexOf("Setups used");
        num2 = racePage.IndexOf("Race", num2);
        num2 = racePage.IndexOf("center", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s12 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
        race.CarSetup.fWing = int.Parse(s12);
        num2 = racePage.IndexOf("center", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s13 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
        race.CarSetup.rWing = int.Parse(s13);
        num2 = racePage.IndexOf("center", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s14 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
        race.CarSetup.engine = int.Parse(s14);
        num2 = racePage.IndexOf("center", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s15 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
        race.CarSetup.brakes = int.Parse(s15);
        num2 = racePage.IndexOf("center", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s16 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
        race.CarSetup.gear = int.Parse(s16);
        num2 = racePage.IndexOf("center", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s17 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
        race.CarSetup.susp = int.Parse(s17);
        num2 = racePage.IndexOf("Start fuel:", num2);
        num2 = racePage.IndexOf(">", num2) + 1;
        string s18 = racePage.Substring(num2, racePage.IndexOf("&nbsp;", num2) - num2);
        race.StartFuel = int.Parse(s18);
        int startIndex1 = num2;
        if (racePage.IndexOf("Pitstop reason", num2) > 0)
        {
          startIndex1 = racePage.IndexOf("</table>", num2);
          ArrayList arrayList = new ArrayList();
          for (num2 = racePage.IndexOf("Lap", num2); num2 < startIndex1 && num2 > 0; num2 = racePage.IndexOf("Lap", num2))
          {
            num2 += 4;
            PitStop pitStop = new PitStop();
            string str = racePage.Substring(num2, racePage.IndexOf(")", num2) - num2);
            pitStop.lap = int.Parse(str.Replace("nbsp;", ""));
            num2 = racePage.IndexOf("<td", num2) + 4;
            num2 = racePage.IndexOf(">", num2) + 1;
            switch (racePage.Substring(num2, racePage.IndexOf("<", num2) - num2))
            {
              case "The tyres could not do any more laps":
                pitStop.pitstopreason = PitStopReason.WornTyres;
                break;
              case "The car had a technical problem":
                pitStop.pitstopreason = PitStopReason.TechnicalProblem;
                break;
              case "No more fuel was left":
                pitStop.pitstopreason = PitStopReason.Fuel;
                break;
              default:
                pitStop.pitstopreason = PitStopReason.WeatherChange;
                break;
            }
            num2 = racePage.IndexOf("<b>", num2) + 3;
            string s19 = racePage.Substring(num2, racePage.IndexOf("<", num2) - 1 - num2);
            pitStop.tyresCondition = int.Parse(s19);
            num2 = racePage.IndexOf("<b>", num2) + 3;
            string s20 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
            if (s20 == "")
              s20 = "0";
            pitStop.fuelLeft = int.Parse(s20);
            num2 = racePage.IndexOf("<b>", num2) + 3;
            string s21 = racePage.Substring(num2, racePage.IndexOf(" ", num2) - num2);
            pitStop.refilledTo = !(s21 == "No") ? int.Parse(s21) : -1;
            num2 = racePage.IndexOf("<b>", num2) + 3;
            int num4 = racePage.IndexOf(".", num2);
            int num5 = racePage.IndexOf("s", num2);
            if (num4 > 0 && num4 < num5)
            {
              int seconds = int.Parse(racePage.Substring(num2, num4 - num2));
              string s22 = racePage.Substring(num4 + 1, num5 - num4 - 1);
              int milliseconds = int.Parse(s22);
              for (int length = s22.Length; length < 3; ++length)
                milliseconds *= 10;
              pitStop.pitTime = new TimeSpan(0, 0, 0, seconds, milliseconds);
            }
            else
              pitStop.pitTime = new TimeSpan(0, 0, 0, int.Parse(racePage.Substring(num2, num5 - num2 - 1)), 0);
            arrayList.Add((object) pitStop);
          }
          race.PitStops = new PitStop[arrayList.Count];
          for (int index = 0; index < race.PitStops.Length; ++index)
            race.PitStops[index] = (PitStop) arrayList[index];
        }
        if (racePage.IndexOf("Technical Problems") > 0)
        {
          num2 = racePage.IndexOf("Technical Problems") + 3;
          startIndex1 = racePage.IndexOf("</table>", num2);
          num2 = racePage.IndexOf("nowrap>", num2);
          ArrayList arrayList = new ArrayList();
          for (; num2 > 0 && num2 < startIndex1; num2 = racePage.IndexOf("nowrap>", num2))
          {
            TechnicalProblem technicalProblem = new TechnicalProblem();
            num2 += 11;
            string s23 = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
            technicalProblem.lap = int.Parse(s23);
            num2 = racePage.IndexOf("class=\"orange", num2) + 15;
            string str = technicalProblem.problem = racePage.Substring(num2, racePage.IndexOf("<", num2) - num2);
            arrayList.Add((object) technicalProblem);
          }
          race.TechnicalProblems = new TechnicalProblem[arrayList.Count];
          for (int index = 0; index < arrayList.Count; ++index)
            race.TechnicalProblems[index] = (TechnicalProblem) arrayList[index];
        }
        if (race.DidFinishRace)
        {
          num2 = racePage.IndexOf("<font color", startIndex1);
          num2 = racePage.IndexOf(">", num2) + 1;
          racePage.IndexOf("%", num2);
          string s24 = racePage.Substring(num2, racePage.IndexOf("%", num2) - num2);
          race.TyresAfterFinish = int.Parse(s24);
          num2 = racePage.IndexOf("<b>", num2) + 3;
          string s25 = racePage.Substring(num2, racePage.IndexOf(" ", num2) - num2);
          race.EndFuel = int.Parse(s25);
        }
        num2 = racePage.IndexOf("Overtaking attempts", num2);
        num2 = racePage.IndexOf("<font color=", num2) + 21;
        string s26 = racePage.Substring(num2, racePage.IndexOf("</font>", num2) - num2);
        race.OvertakingAttemps.InitiatedBlocked = int.Parse(s26);
        num2 = racePage.IndexOf("<font color=", num2) + 19;
        string s27 = racePage.Substring(num2, racePage.IndexOf("</font>", num2) - num2);
        race.OvertakingAttemps.InitiatedSucceful = int.Parse(s27);
        num2 = racePage.IndexOf("<font color=", num2) + 19;
        string s28 = racePage.Substring(num2, racePage.IndexOf("</font>", num2) - num2);
        race.OvertakingAttemps.SufferedBlocked = int.Parse(s28);
        num2 = racePage.IndexOf("<font color=", num2) + 21;
        string s29 = racePage.Substring(num2, racePage.IndexOf("</font>", num2) - num2);
        race.OvertakingAttemps.SufferedSuccessful = int.Parse(s29);
        num2 = racePage.IndexOf("Financial analysis of the last race");
        int startIndex2 = racePage.IndexOf("Driver race position", num2);
        if (startIndex2 > 0)
        {
          int startIndex3 = racePage.IndexOf("(", startIndex2) + 1;
          race.Finances.endPosition = int.Parse(racePage.Substring(startIndex3, racePage.IndexOf(")", startIndex3) - startIndex3));
          int startIndex4 = racePage.IndexOf("$", startIndex3);
          race.Finances.endPositionMoney = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex4, racePage.IndexOf("<", startIndex4) - startIndex4), "endPositionMoney");
        }
        int startIndex5 = racePage.IndexOf("Driver qualifying position", num2);
        if (startIndex5 > 0)
        {
          int startIndex6 = racePage.IndexOf("(", startIndex5) + 1;
          race.Finances.qualPosition = int.Parse(racePage.Substring(startIndex6, racePage.IndexOf(")", startIndex6) - startIndex6));
          int startIndex7 = racePage.IndexOf("$", startIndex6);
          race.Finances.qualPositionMoney = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex7, racePage.IndexOf("<", startIndex7) - startIndex7), "qualPositionMoney");
        }
        int startIndex8 = racePage.IndexOf("SponsorState money:", num2);
        if (startIndex8 > 0)
        {
          int startIndex9 = racePage.IndexOf("$", startIndex8);
          race.Finances.sponsorMoney = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex9, racePage.IndexOf("<", startIndex9) - startIndex9), "sponsorPositionMoney");
        }
        int startIndex10 = racePage.IndexOf("Driver salary:", num2);
        if (startIndex10 > 0)
        {
          int startIndex11 = racePage.IndexOf("$", startIndex10);
          race.Finances.driverSalary = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex11, racePage.IndexOf("<", startIndex11) - startIndex11), "driverSalary");
        }
        int startIndex12 = racePage.IndexOf("Staff salary:", num2);
        if (startIndex12 > 0)
        {
          int startIndex13 = racePage.IndexOf("$", startIndex12);
          race.Finances.staffSalary = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex13, racePage.IndexOf("<", startIndex13) - startIndex13), "staffSalary");
        }
        int startIndex14 = racePage.IndexOf("Facility costs:", num2);
        if (startIndex14 > 0)
        {
          int startIndex15 = racePage.IndexOf("$", startIndex14);
          race.Finances.facilityCost = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex15, racePage.IndexOf("<", startIndex15) - startIndex15), "facilityCosts");
        }
        int startIndex16 = racePage.IndexOf("Tyres contract", num2);
        if (startIndex16 > 0)
        {
          int startIndex17 = racePage.IndexOf("$", startIndex16);
          race.Finances.tyresContractCost = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex17, racePage.IndexOf("<", startIndex17) - startIndex17), "tyresContract");
        }
        int startIndex18 = racePage.IndexOf("Total:", num2);
        if (startIndex18 > 0)
        {
          int startIndex19 = racePage.IndexOf("$", startIndex18);
          race.Finances.total = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex19, racePage.IndexOf("<", startIndex19) - startIndex19), "total");
        }
        int startIndex20 = racePage.IndexOf("Current balance:", num2);
        if (startIndex20 > 0)
        {
          int startIndex21 = racePage.IndexOf("$", startIndex20);
          race.Finances.currentBalance = RaceAnalysisParser.GetMoneyAmount(racePage.Substring(startIndex21, racePage.IndexOf("<", startIndex21) - startIndex21), "currentBalance");
        }
        race.CalculateWear(Datas.GetTrack(num3));
        return race;

        int nextCellValue(string escape = "")
        {
          num2 = racePage.IndexOf("<td", num2);
          num2 = racePage.IndexOf(">", num2) + 1;
          return int.Parse(racePage.Substring(num2, racePage.IndexOf(escape + "</td>", num2) - num2));
        }
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing race analysis", ex, racePage);
        return (Race9) null;
      }
    }

    private static int GetMoneyAmount(string noget, string error)
    {
      int num1 = noget.IndexOf("$") + 1;
      bool flag1 = false;
      if (noget[num1] == '-')
      {
        flag1 = true;
        ++num1;
      }
      bool flag2 = true;
      if (noget.IndexOf("<", num1) > 0)
        flag2 = false;
      noget = noget.Substring(num1, (flag2 ? noget.Length : noget.IndexOf("<", num1)) - num1);
      int num2;
      try
      {
        num2 = int.Parse(noget, NumberStyles.AllowThousands, (IFormatProvider) new CultureInfo("da-DK"));
      }
      catch
      {
        Errlog.AddToLog("Could not parse int \"" + noget + " as " + error);
        throw;
      }
      return !flag1 ? num2 : -num2;
    }

    private static int GetMonth(string month)
    {
      int month1;
      switch (month)
      {
        case "Apr":
          month1 = 4;
          break;
        case "Aug":
          month1 = 8;
          break;
        case "Dec":
          month1 = 12;
          break;
        case "Feb":
          month1 = 2;
          break;
        case "Jan":
          month1 = 1;
          break;
        case "Jul":
          month1 = 7;
          break;
        case "Jun":
          month1 = 6;
          break;
        case "Mar":
          month1 = 3;
          break;
        case "May":
          month1 = 5;
          break;
        case "Nov":
          month1 = 11;
          break;
        case "Oct":
          month1 = 10;
          break;
        case "Sep":
          month1 = 9;
          break;
        default:
          month1 = 0;
          break;
      }
      return month1;
    }

    private static int GetDay(string noget)
    {
      int day = int.Parse(noget.Substring(0, 1));
      try
      {
        return int.Parse(noget.Substring(0, 2));
      }
      catch
      {
        return day;
      }
    }
  }
}
