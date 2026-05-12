 
// Type: go.Parsers.PracticeParser
 
 
 

using go.Utils;
using System;
using System.Collections;

#nullable disable
namespace go.Parsers
{
  public class PracticeParser : GenericParser
  {
    public static Practice3 ParsePractice(string practicePage, ref RaceWeather wf)
    {
      if (practicePage.IndexOf("<a href=\"SignRandomDriver.asp\"") > 0)
        throw new Exception("You do not have a driver");
      Practice3 practice = new Practice3();
      try
      {
        int startIndex1 = 0;
        int startIndex2 = practicePage.IndexOf("laps done&nbsp;") + 15;
        int num1 = int.Parse(practicePage.Substring(startIndex2, practicePage.IndexOf("/", startIndex2) - startIndex2));
        for (int index1 = 0; index1 < 8; ++index1)
        {
          int startIndex3 = practicePage.IndexOf("comments[" + (index1 + 1).ToString() + "]");
          if (startIndex3 > 0)
          {
            ArrayList arrayList = new ArrayList();
            int startIndex4 = practicePage.IndexOf("\"", startIndex3) + 1;
            startIndex1 = practicePage.IndexOf("\"", startIndex4) + 1;
            int startIndex5 = practicePage.IndexOf(">", startIndex4) + 1;
            int startIndex6;
            for (int startIndex7 = practicePage.IndexOf(">", startIndex5) + 1; startIndex7 < startIndex1; startIndex7 = practicePage.IndexOf(">", startIndex6) + 1)
            {
              if (practicePage.Substring(startIndex7).StartsWith("I am satisfied"))
              {
                arrayList.Add((object) "I am satisfied with the setup of the car");
              }
              else
              {
                string str1 = practicePage.Substring(startIndex7, practicePage.IndexOf(":", startIndex7) - startIndex7);
                arrayList.Add((object) str1);
                startIndex7 = practicePage.IndexOf(">", startIndex7) + 3;
                int num2 = practicePage.IndexOf("\"", startIndex7);
                int num3 = practicePage.IndexOf("<", startIndex7);
                if (num3 > num2)
                  num3 = num2;
                string str2 = practicePage.Substring(startIndex7, num3 - startIndex7);
                arrayList.Add((object) str2);
              }
              startIndex6 = practicePage.IndexOf(">", startIndex7) + 1;
            }
            practice.runs[index1].comments = new string[arrayList.Count];
            for (int index2 = 0; index2 < arrayList.Count; ++index2)
              practice.runs[index1].comments[index2] = (string) arrayList[index2];
          }
        }
        int startIndex8 = practicePage.IndexOf("TrackDetails.asp", startIndex1) + 20;
        string s1 = practicePage.Substring(startIndex8, practicePage.IndexOf("\"", startIndex8) - startIndex8);
        practice.track = int.Parse(s1);
        int startIndex9 = practicePage.IndexOf("Practice / Qualify 1", startIndex8) + 15;
        int startIndex10 = practicePage.IndexOf("alt", startIndex9) + 5;
        string noget1 = practicePage.Substring(startIndex10, practicePage.IndexOf("\"", startIndex10) - startIndex10);
        practice.weather.skies = StringToEnum.String2Skies(noget1);
        int startIndex11 = practicePage.IndexOf("Temp", startIndex10) + 6;
        string s2 = practicePage.Substring(startIndex11, practicePage.IndexOf("&", startIndex11) - startIndex11);
        practice.weather.temperature = int.Parse(s2);
        int startIndex12 = practicePage.IndexOf("Humidity", startIndex11) + 10;
        string s3 = practicePage.Substring(startIndex12, practicePage.IndexOf("%", startIndex12) - startIndex12);
        practice.weather.humidity = int.Parse(s3);
        wf.pracWeather = practice.weather;
        int startIndex13 = practicePage.IndexOf("alt", startIndex12) + 5;
        string noget2 = practicePage.Substring(startIndex13, practicePage.IndexOf("\"", startIndex13) - startIndex13);
        wf.qualWeather.skies = StringToEnum.String2Skies(noget2);
        int startIndex14 = practicePage.IndexOf("Temp", startIndex13) + 6;
        string s4 = practicePage.Substring(startIndex14, practicePage.IndexOf("&", startIndex14) - startIndex14);
        wf.qualWeather.temperature = int.Parse(s4);
        int startIndex15 = practicePage.IndexOf("Humidity", startIndex14) + 10;
        string s5 = practicePage.Substring(startIndex15, practicePage.IndexOf("%", startIndex15) - startIndex15);
        wf.qualWeather.humidity = int.Parse(s5);
        wf.forecast = ForecastParser.ParseForecast(practicePage.Substring(practicePage.IndexOf("Race forecast", startIndex15)));
        int startIndex16 = practicePage.IndexOf("<b>FWing</b>", startIndex15) + 20;
        for (int index = 0; index < num1; ++index)
        {
          int startIndex17 = index != num1 - 1 ? practicePage.IndexOf("<td class=\"speccellnobot", startIndex16) + 20 : practicePage.IndexOf("<td class=\"speccell", startIndex16) + 20;
          int startIndex18 = practicePage.IndexOf("<b>", startIndex17) + 3;
          int startIndex19 = practicePage.IndexOf("s", startIndex18);
          string str3 = practicePage.Substring(startIndex18, startIndex19 - startIndex18);
          int length1 = str3.IndexOf(":");
          int minutes1 = length1 <= 0 ? 0 : int.Parse(str3.Substring(0, length1));
          int seconds1 = int.Parse(str3.Substring(length1 + 1, str3.IndexOf(".") - length1 - 1));
          int num4 = str3.IndexOf(".");
          int milliseconds1 = int.Parse(str3.Substring(num4 + 1));
          practice.runs[index].lapTime = new TimeSpan(0, 0, minutes1, seconds1, milliseconds1);
          int startIndex20 = practicePage.IndexOf("<b>", startIndex19) + 3;
          int startIndex21 = practicePage.IndexOf("s", startIndex20);
          string str4 = practicePage.Substring(startIndex20, startIndex21 - startIndex20);
          int num5 = str4.IndexOf(":");
          int minutes2 = num5 <= 0 ? 0 : int.Parse(str4.Substring(0, num5 - 1));
          int seconds2 = int.Parse(str4.Substring(num5 + 1, str4.IndexOf(".") - num5 - 1));
          int num6 = str4.IndexOf(".");
          int milliseconds2 = int.Parse(str4.Substring(num6 + 1));
          practice.runs[index].driverMistake = new TimeSpan(0, 0, minutes2, seconds2, milliseconds2);
          int startIndex22 = practicePage.IndexOf("<b>", startIndex21) + 3;
          int startIndex23 = practicePage.IndexOf("s", startIndex22);
          string str5 = practicePage.Substring(startIndex22, startIndex23 - startIndex22);
          int length2 = str5.IndexOf(":");
          int minutes3 = length2 <= 0 ? 0 : int.Parse(str5.Substring(0, length2));
          int seconds3 = int.Parse(str5.Substring(length2 + 1, str5.IndexOf(".") - length2 - 1));
          int num7 = str5.IndexOf(".");
          int milliseconds3 = int.Parse(str5.Substring(num7 + 1));
          practice.runs[index].netTime = new TimeSpan(0, 0, minutes3, seconds3, milliseconds3);
          int startIndex24 = practicePage.IndexOf("<td", startIndex23) + 3;
          int startIndex25 = practicePage.IndexOf(">", startIndex24) + 1;
          string s6 = practicePage.Substring(startIndex25, practicePage.IndexOf("<", startIndex25) - startIndex25);
          practice.runs[index].setup.fWing = int.Parse(s6);
          int startIndex26 = practicePage.IndexOf("<td", startIndex25) + 3;
          int startIndex27 = practicePage.IndexOf(">", startIndex26) + 1;
          string s7 = practicePage.Substring(startIndex27, practicePage.IndexOf("<", startIndex27) - startIndex27);
          practice.runs[index].setup.rWing = int.Parse(s7);
          int startIndex28 = practicePage.IndexOf("<td", startIndex27) + 3;
          int startIndex29 = practicePage.IndexOf(">", startIndex28) + 1;
          string s8 = practicePage.Substring(startIndex29, practicePage.IndexOf("<", startIndex29) - startIndex29);
          practice.runs[index].setup.engine = int.Parse(s8);
          int startIndex30 = practicePage.IndexOf("<td", startIndex29) + 3;
          int startIndex31 = practicePage.IndexOf(">", startIndex30) + 1;
          string s9 = practicePage.Substring(startIndex31, practicePage.IndexOf("<", startIndex31) - startIndex31);
          practice.runs[index].setup.brakes = int.Parse(s9);
          int startIndex32 = practicePage.IndexOf("<td", startIndex31) + 3;
          int startIndex33 = practicePage.IndexOf(">", startIndex32) + 1;
          string s10 = practicePage.Substring(startIndex33, practicePage.IndexOf("<", startIndex33) - startIndex33);
          practice.runs[index].setup.gear = int.Parse(s10);
          int startIndex34 = practicePage.IndexOf("<td", startIndex33) + 3;
          int startIndex35 = practicePage.IndexOf(">", startIndex34) + 1;
          string s11 = practicePage.Substring(startIndex35, practicePage.IndexOf("<", startIndex35) - startIndex35);
          practice.runs[index].setup.susp = int.Parse(s11);
          int startIndex36 = practicePage.IndexOf("<td", startIndex35) + 3;
          startIndex16 = practicePage.IndexOf(">", startIndex36) + 1;
          string noget3 = practicePage.Substring(startIndex16, practicePage.IndexOf("<", startIndex16) - startIndex16);
          practice.runs[index].setup.tyres = StringToEnum.String2Tyres(noget3);
        }
        int startIndex37 = practicePage.IndexOf("Front wing", startIndex16) + 15;
        if (practicePage.Substring(startIndex37, 10).StartsWith("<font"))
          startIndex37 = practicePage.IndexOf(">", startIndex37) + 1;
        int startIndex38 = practicePage.IndexOf("align=\"center\"", startIndex37) + 15;
        if (practicePage.Substring(startIndex38, 10).StartsWith("<font"))
          startIndex38 = practicePage.IndexOf(">", startIndex38) + 1;
        string s12 = practicePage.Substring(startIndex38, practicePage.IndexOf("<", startIndex38) - startIndex38);
        practice.car.frontWing.level = int.Parse(s12);
        int startIndex39 = practicePage.IndexOf("align=\"center\"", startIndex38) + 15;
        if (practicePage.Substring(startIndex39, 10).StartsWith("<font"))
          startIndex39 = practicePage.IndexOf(">", startIndex39) + 1;
        string s13 = practicePage.Substring(startIndex39, practicePage.IndexOf("%", startIndex39) - startIndex39);
        practice.car.frontWing.wear = int.Parse(s13);
        int startIndex40 = practicePage.IndexOf("Chassis", startIndex39) + 15;
        int startIndex41 = practicePage.IndexOf("align=\"center\"", startIndex40) + 15;
        if (practicePage.Substring(startIndex41, 10).StartsWith("<font"))
          startIndex41 = practicePage.IndexOf(">", startIndex41) + 1;
        string s14 = practicePage.Substring(startIndex41, practicePage.IndexOf("<", startIndex41) - startIndex41);
        practice.car.chassis.level = int.Parse(s14);
        int startIndex42 = practicePage.IndexOf("align=\"center\"", startIndex41) + 15;
        if (practicePage.Substring(startIndex42, 10).StartsWith("<font"))
          startIndex42 = practicePage.IndexOf(">", startIndex42) + 1;
        string s15 = practicePage.Substring(startIndex42, practicePage.IndexOf("%", startIndex42) - startIndex42);
        practice.car.chassis.wear = int.Parse(s15);
        int startIndex43 = practicePage.IndexOf("Rear wing", startIndex42) + 15;
        int startIndex44 = practicePage.IndexOf("align=\"center\"", startIndex43) + 15;
        if (practicePage.Substring(startIndex44, 10).StartsWith("<font"))
          startIndex44 = practicePage.IndexOf(">", startIndex44) + 1;
        string s16 = practicePage.Substring(startIndex44, practicePage.IndexOf("<", startIndex44) - startIndex44);
        practice.car.rearWing.level = int.Parse(s16);
        int startIndex45 = practicePage.IndexOf("align=\"center\"", startIndex44) + 15;
        if (practicePage.Substring(startIndex45, 10).StartsWith("<font"))
          startIndex45 = practicePage.IndexOf(">", startIndex45) + 1;
        string s17 = practicePage.Substring(startIndex45, practicePage.IndexOf("%", startIndex45) - startIndex45);
        practice.car.rearWing.wear = int.Parse(s17);
        int startIndex46 = practicePage.IndexOf("Underbody", startIndex45) + 15;
        int startIndex47 = practicePage.IndexOf("align=\"center\"", startIndex46) + 15;
        if (practicePage.Substring(startIndex47, 10).StartsWith("<font"))
          startIndex47 = practicePage.IndexOf(">", startIndex47) + 1;
        string s18 = practicePage.Substring(startIndex47, practicePage.IndexOf("<", startIndex47) - startIndex47);
        practice.car.underbody.level = int.Parse(s18);
        int startIndex48 = practicePage.IndexOf("align=\"center\"", startIndex47) + 15;
        if (practicePage.Substring(startIndex48, 10).StartsWith("<font"))
          startIndex48 = practicePage.IndexOf(">", startIndex48) + 1;
        string s19 = practicePage.Substring(startIndex48, practicePage.IndexOf("%", startIndex48) - startIndex48);
        practice.car.underbody.wear = int.Parse(s19);
        int startIndex49 = practicePage.IndexOf("Engine", startIndex48) + 15;
        int startIndex50 = practicePage.IndexOf("align=\"center\"", startIndex49) + 15;
        if (practicePage.Substring(startIndex50, 10).StartsWith("<font"))
          startIndex50 = practicePage.IndexOf(">", startIndex50) + 1;
        string s20 = practicePage.Substring(startIndex50, practicePage.IndexOf("<", startIndex50) - startIndex50);
        practice.car.engine.level = int.Parse(s20);
        int startIndex51 = practicePage.IndexOf("align=\"center\"", startIndex50) + 15;
        if (practicePage.Substring(startIndex51, 10).StartsWith("<font"))
          startIndex51 = practicePage.IndexOf(">", startIndex51) + 1;
        string s21 = practicePage.Substring(startIndex51, practicePage.IndexOf("%", startIndex51) - startIndex51);
        practice.car.engine.wear = int.Parse(s21);
        int startIndex52 = practicePage.IndexOf("Sidepods", startIndex51) + 15;
        int startIndex53 = practicePage.IndexOf("align=\"center\"", startIndex52) + 15;
        if (practicePage.Substring(startIndex53, 10).StartsWith("<font"))
          startIndex53 = practicePage.IndexOf(">", startIndex53) + 1;
        string s22 = practicePage.Substring(startIndex53, practicePage.IndexOf("<", startIndex53) - startIndex53);
        practice.car.sidepods.level = int.Parse(s22);
        int startIndex54 = practicePage.IndexOf("align=\"center\"", startIndex53) + 15;
        if (practicePage.Substring(startIndex54, 10).StartsWith("<font"))
          startIndex54 = practicePage.IndexOf(">", startIndex54) + 1;
        string s23 = practicePage.Substring(startIndex54, practicePage.IndexOf("%", startIndex54) - startIndex54);
        practice.car.sidepods.wear = int.Parse(s23);
        int startIndex55 = practicePage.IndexOf("Brakes", startIndex54) + 15;
        int startIndex56 = practicePage.IndexOf("align=\"center\"", startIndex55) + 15;
        if (practicePage.Substring(startIndex56, 10).StartsWith("<font"))
          startIndex56 = practicePage.IndexOf(">", startIndex56) + 1;
        string s24 = practicePage.Substring(startIndex56, practicePage.IndexOf("<", startIndex56) - startIndex56);
        practice.car.brakes.level = int.Parse(s24);
        int startIndex57 = practicePage.IndexOf("align=\"center\"", startIndex56) + 15;
        if (practicePage.Substring(startIndex57, 10).StartsWith("<font"))
          startIndex57 = practicePage.IndexOf(">", startIndex57) + 1;
        string s25 = practicePage.Substring(startIndex57, practicePage.IndexOf("%", startIndex57) - startIndex57);
        practice.car.brakes.wear = int.Parse(s25);
        int startIndex58 = practicePage.IndexOf("Cooling", startIndex57) + 15;
        int startIndex59 = practicePage.IndexOf("align=\"center\"", startIndex58) + 15;
        if (practicePage.Substring(startIndex59, 10).StartsWith("<font"))
          startIndex59 = practicePage.IndexOf(">", startIndex59) + 1;
        string s26 = practicePage.Substring(startIndex59, practicePage.IndexOf("<", startIndex59) - startIndex59);
        practice.car.cooling.level = int.Parse(s26);
        int startIndex60 = practicePage.IndexOf("align=\"center\"", startIndex59) + 15;
        if (practicePage.Substring(startIndex60, 10).StartsWith("<font"))
          startIndex60 = practicePage.IndexOf(">", startIndex60) + 1;
        string s27 = practicePage.Substring(startIndex60, practicePage.IndexOf("%", startIndex60) - startIndex60);
        practice.car.cooling.wear = int.Parse(s27);
        int startIndex61 = practicePage.IndexOf("Gear", startIndex60) + 15;
        int startIndex62 = practicePage.IndexOf("align=\"center\"", startIndex61) + 15;
        if (practicePage.Substring(startIndex62, 10).StartsWith("<font"))
          startIndex62 = practicePage.IndexOf(">", startIndex62) + 1;
        string s28 = practicePage.Substring(startIndex62, practicePage.IndexOf("<", startIndex62) - startIndex62);
        practice.car.gearBox.level = int.Parse(s28);
        int startIndex63 = practicePage.IndexOf("align=\"center\"", startIndex62) + 15;
        if (practicePage.Substring(startIndex63, 10).StartsWith("<font"))
          startIndex63 = practicePage.IndexOf(">", startIndex63) + 1;
        string s29 = practicePage.Substring(startIndex63, practicePage.IndexOf("%", startIndex63) - startIndex63);
        practice.car.gearBox.wear = int.Parse(s29);
        int startIndex64 = practicePage.IndexOf("Electronics", startIndex63) + 15;
        int startIndex65 = practicePage.IndexOf("align=\"center\"", startIndex64) + 15;
        if (practicePage.Substring(startIndex65, 10).StartsWith("<font"))
          startIndex65 = practicePage.IndexOf(">", startIndex65) + 1;
        string s30 = practicePage.Substring(startIndex65, practicePage.IndexOf("<", startIndex65) - startIndex65);
        practice.car.electronics.level = int.Parse(s30);
        int startIndex66 = practicePage.IndexOf("align=\"center\"", startIndex65) + 15;
        if (practicePage.Substring(startIndex66, 10).StartsWith("<font"))
          startIndex66 = practicePage.IndexOf(">", startIndex66) + 1;
        string s31 = practicePage.Substring(startIndex66, practicePage.IndexOf("%", startIndex66) - startIndex66);
        practice.car.electronics.wear = int.Parse(s31);
        int startIndex67 = practicePage.IndexOf("Suspension", startIndex66) + 15;
        int startIndex68 = practicePage.IndexOf("align=\"center\"", startIndex67) + 15;
        if (practicePage.Substring(startIndex68, 10).StartsWith("<font"))
          startIndex68 = practicePage.IndexOf(">", startIndex68) + 1;
        string s32 = practicePage.Substring(startIndex68, practicePage.IndexOf("<", startIndex68) - startIndex68);
        practice.car.suspension.level = int.Parse(s32);
        int startIndex69 = practicePage.IndexOf("align=\"center\"", startIndex68) + 15;
        if (practicePage.Substring(startIndex69, 10).StartsWith("<font"))
          startIndex69 = practicePage.IndexOf(">", startIndex69) + 1;
        string s33 = practicePage.Substring(startIndex69, practicePage.IndexOf("%", startIndex69) - startIndex69);
        practice.car.suspension.wear = int.Parse(s33);
        return practice;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing practice", ex, practicePage);
        return practice;
      }
    }

    public static Practice3 ParsePractice(ref RaceWeather wf)
    {
      return PracticeParser.ParsePractice(Datas.Communications.GetPage("Qualify.asp"), ref wf);
    }
  }
}
