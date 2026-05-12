 
// Type: go.Parsers.TestingParser
 
 
 

using go.Utils;
using System;
using System.Collections;

#nullable disable
namespace go.Parsers
{
  public class TestingParser : GenericParser
  {
    public static Testing ParseTest()
    {
      return TestingParser.ParseTest(Datas.Communications.GetPage("Testing.asp"));
    }

    public static Testing ParseTest(string testPage)
    {
      int startIndex1 = 0;
      int num1 = 0;
      Testing test = new Testing();
      if (testPage.IndexOf("<a href=\"SignRandomDriver.asp\"") > 0)
        return test;
      try
      {
        int startIndex2 = testPage.IndexOf("comments[0]", startIndex1) + 11;
        num1 = testPage.IndexOf("[lap]", startIndex2);
        for (int index1 = 0; index1 < 10 && testPage.IndexOf("comments[" + (index1 + 1).ToString() + "]") >= 0; ++index1)
        {
          int startIndex3 = testPage.IndexOf("comments[" + (index1 + 1).ToString() + "]");
          int startIndex4 = testPage.IndexOf("]", startIndex3) + 9;
          int startIndex5 = testPage.IndexOf(">", startIndex4) + 1;
          int startIndex6 = startIndex5;
          int num2 = testPage.IndexOf("\";", startIndex5);
          ArrayList arrayList = new ArrayList();
          for (; startIndex5 < num2; startIndex5 = testPage.IndexOf("<b>", startIndex5) + 3)
          {
            string str1 = testPage.Substring(startIndex5, testPage.IndexOf("<", startIndex5) - startIndex5);
            if (str1.StartsWith("I am satisfied"))
              arrayList.Add((object) "I am satisfied with the setup of the car");
            else if (str1.StartsWith("No comments available"))
            {
              arrayList.Add((object) "No comments available");
            }
            else
            {
              arrayList.Add((object) str1);
              startIndex5 = testPage.IndexOf(">", startIndex5) + 3;
              int num3 = testPage.IndexOf("\"", startIndex5);
              int num4 = testPage.IndexOf("<", startIndex5);
              if (num3 < num4)
                num4 = num3;
              string str2 = testPage.Substring(startIndex5, num4 - startIndex5);
              arrayList.Add((object) str2);
            }
          }
          int startIndex7 = testPage.IndexOf("(Stint research priority: ", startIndex6) + 26;
          string noget = testPage.Substring(startIndex7, testPage.IndexOf(")", startIndex7) - startIndex7);
          test.runs[index1] = new TestingRun();
          test.runs[index1].priority = StringToEnum.String2Priority(noget);
          test.runs[index1].comments = new string[arrayList.Count];
          for (int index2 = 0; index2 < arrayList.Count; ++index2)
            test.runs[index1].comments[index2] = (string) arrayList[index2];
        }
        for (int index3 = 9; index3 >= 0; --index3)
        {
          if (test.runs[index3] != null && index3 <= 9)
          {
            TestingRun[] testingRunArray = new TestingRun[index3 + 1];
            for (int index4 = 0; index4 < index3 + 1; ++index4)
              testingRunArray[index4] = test.runs[index4];
            test.runs = testingRunArray;
            break;
          }
        }
        int startIndex8 = testPage.IndexOf("TrackDetails.asp") + 20;
        string s1 = testPage.Substring(startIndex8, testPage.IndexOf("\"", startIndex8) - startIndex8);
        test.track = int.Parse(s1);
        int startIndex9 = testPage.IndexOf("Current weather", startIndex8);
        int startIndex10 = testPage.IndexOf("title=", startIndex9) + 7;
        string noget1 = testPage.Substring(startIndex10, testPage.IndexOf("\"", startIndex10) - startIndex10);
        test.weather.skies = StringToEnum.String2Skies(noget1);
        int startIndex11 = testPage.IndexOf("Temp", startIndex10) + 6;
        string s2 = testPage.Substring(startIndex11, testPage.IndexOf("°", startIndex11) - startIndex11);
        test.weather.temperature = int.Parse(s2);
        int startIndex12 = testPage.IndexOf("Humidity", startIndex11) + 10;
        string s3 = testPage.Substring(startIndex12, testPage.IndexOf("%", startIndex12) - startIndex12);
        test.weather.humidity = int.Parse(s3);
        int startIndex13 = testPage.IndexOf("Current points distribution", startIndex12);
        for (int index = 0; index < test.points.Length; ++index)
        {
          int startIndex14 = testPage.IndexOf("<td", startIndex13) + 3;
          int startIndex15 = testPage.IndexOf(">", startIndex14) + 1;
          string noget2 = testPage.Substring(startIndex15, testPage.IndexOf("<", startIndex15) - startIndex15);
          test.points[index].power = Util.ParseDouble(noget2);
          int startIndex16 = testPage.IndexOf("<td", startIndex15) + 3;
          int startIndex17 = testPage.IndexOf(">", startIndex16) + 1;
          string noget3 = testPage.Substring(startIndex17, testPage.IndexOf("<", startIndex17) - startIndex17);
          test.points[index].handling = Util.ParseDouble(noget3);
          int startIndex18 = testPage.IndexOf("<td", startIndex17) + 3;
          startIndex13 = testPage.IndexOf(">", startIndex18) + 1;
          string noget4 = testPage.Substring(startIndex13, testPage.IndexOf("<", startIndex13) - startIndex13);
          test.points[index].acceleration = Util.ParseDouble(noget4);
        }
        if (testPage.IndexOf("No testing stints done", startIndex13) >= 0)
          return test;
        int startIndex19 = testPage.IndexOf("<b>Comm</b>", startIndex13);
        int num5 = testPage.IndexOf("/table", startIndex19);
        int index5 = 0;
        ArrayList arrayList1 = new ArrayList();
        int startIndex20;
        for (int startIndex21 = testPage.IndexOf("<tr", startIndex19); startIndex21 < num5; startIndex21 = testPage.IndexOf("<tr", startIndex20))
        {
          int startIndex22 = testPage.IndexOf("align=\"center\">", startIndex21) + 15;
          string s4 = testPage.Substring(startIndex22, testPage.IndexOf("/", startIndex22) - startIndex22);
          test.runs[index5].lapsDone = int.Parse(s4);
          int startIndex23 = startIndex22 + (s4.Length + 1);
          string s5 = testPage.Substring(startIndex23, testPage.IndexOf("<", startIndex23) - startIndex23);
          test.runs[index5].lapLimit = int.Parse(s5);
          int startIndex24 = testPage.IndexOf("<b>", startIndex23) + 3;
          string noget5 = testPage.Substring(startIndex24, testPage.IndexOf("s", startIndex24) - startIndex24);
          test.runs[index5].bestTime = StringToEnum.String2Time(noget5);
          int startIndex25 = testPage.IndexOf("<b>", startIndex24) + 3;
          string noget6 = testPage.Substring(startIndex25, testPage.IndexOf("s", startIndex25) - startIndex25);
          test.runs[index5].meanTime = StringToEnum.String2Time(noget6);
          int startIndex26 = testPage.IndexOf("'>", startIndex25) + 2;
          string s6 = testPage.Substring(startIndex26, testPage.IndexOf("<", startIndex26) - startIndex26);
          test.runs[index5].setup.fWing = int.Parse(s6);
          int startIndex27 = testPage.IndexOf("'>", startIndex26) + 2;
          string s7 = testPage.Substring(startIndex27, testPage.IndexOf("<", startIndex27) - startIndex27);
          test.runs[index5].setup.rWing = int.Parse(s7);
          int startIndex28 = testPage.IndexOf("'>", startIndex27) + 2;
          string s8 = testPage.Substring(startIndex28, testPage.IndexOf("<", startIndex28) - startIndex28);
          test.runs[index5].setup.engine = int.Parse(s8);
          int startIndex29 = testPage.IndexOf("'>", startIndex28) + 2;
          string s9 = testPage.Substring(startIndex29, testPage.IndexOf("<", startIndex29) - startIndex29);
          test.runs[index5].setup.brakes = int.Parse(s9);
          int startIndex30 = testPage.IndexOf("'>", startIndex29) + 2;
          string s10 = testPage.Substring(startIndex30, testPage.IndexOf("<", startIndex30) - startIndex30);
          test.runs[index5].setup.gear = int.Parse(s10);
          int startIndex31 = testPage.IndexOf("'>", startIndex30) + 2;
          string s11 = testPage.Substring(startIndex31, testPage.IndexOf("<", startIndex31) - startIndex31);
          test.runs[index5].setup.susp = int.Parse(s11);
          int startIndex32 = testPage.IndexOf("'>", startIndex31) + 2;
          string noget7 = testPage.Substring(startIndex32, testPage.IndexOf("<", startIndex32) - startIndex32);
          test.runs[index5].setup.tyres = StringToEnum.String2Tyres(noget7);
          int startIndex33 = testPage.IndexOf("'>", startIndex32) + 2;
          string s12 = testPage.Substring(startIndex33, testPage.IndexOf("<", startIndex33) - startIndex33);
          test.runs[index5].fuelStart = int.Parse(s12);
          int startIndex34 = testPage.IndexOf("nowrap>", startIndex33) + 7;
          string s13 = testPage.Substring(startIndex34, testPage.IndexOf("%", startIndex34) - startIndex34);
          test.runs[index5].tyresCondition = int.Parse(s13);
          startIndex20 = testPage.IndexOf("nowrap>", startIndex34) + 7;
          string s14 = testPage.Substring(startIndex20, testPage.IndexOf("<", startIndex20) - startIndex20);
          test.runs[index5].fuelLeft = int.Parse(s14);
          ++index5;
        }
        return test;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing testing", ex, testPage);
        return (Testing) null;
      }
    }
  }
}
