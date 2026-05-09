// Decompiled with JetBrains decompiler
// Type: go.Parsers.TrackParser
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using go.Utils;

#nullable disable
namespace go.Parsers
{
  public class TrackParser : GenericParser
  {
    public static Track[] GetAllTracks()
    {
      string page = Datas.Communications.GetPage("ViewTracks.asp");
      int length = 0;
      for (int index = page.IndexOf("TrackDetails.asp?"); index > 0; index = page.IndexOf("TrackDetails.asp?", index + 1))
        ++length;
      Track[] allTracks = new Track[length];
      for (int index = 0; index < length; ++index)
        allTracks[index] = TrackParser.parseTrackPage(index + 1);
      return allTracks;
    }

    private static Track parseTrackPage(int num)
    {
      string page = Datas.Communications.GetPage("TrackDetails.asp?id=" + num.ToString());
      Track trackPage = new Track();
      int startIndex1 = page.IndexOf("<div id=\"contentinner\"");
      int length = page.IndexOf("</h1>", startIndex1);
      int startIndex2 = page.Substring(0, length).LastIndexOf(">") + 1;
      trackPage.name = page.Substring(startIndex2, length - startIndex2).Trim();
      trackPage.number = num;
      int startIndex3 = page.IndexOf("Power:</TD>") + 11;
      trackPage.power = 0;
      int num1 = page.IndexOf("</TD>", startIndex3);
      for (int index = page.IndexOf("lvl", startIndex3 + 1); index < num1; index = page.IndexOf("lvl", index + 1))
        ++trackPage.power;
      int num2 = page.IndexOf("Handling:</TD>") + 14;
      trackPage.handling = 0;
      int num3 = page.IndexOf("</TD>", num2 + 1);
      for (int index = page.IndexOf("lvl", num2 + 1); index < num3; index = page.IndexOf("lvl", index + 1))
        ++trackPage.handling;
      int startIndex4 = page.IndexOf("Race distance:</TD>") + 19;
      int startIndex5 = page.IndexOf(">", startIndex4) + 1;
      int startIndex6 = page.IndexOf(".", startIndex5);
      int num4 = page.IndexOf("<", startIndex5);
      if (startIndex6 > 0 && startIndex6 < num4)
      {
        trackPage.distance = (double) int.Parse(page.Substring(startIndex5, startIndex6 - startIndex5));
        string s = page.Substring(startIndex6 + 1, page.IndexOf("km", startIndex6) - 1 - startIndex6);
        switch (s.Length)
        {
          case 1:
            trackPage.distance += (double) int.Parse(s) / 10.0;
            break;
          case 2:
            trackPage.distance += (double) int.Parse(s) / 100.0;
            break;
          default:
            trackPage.distance += (double) int.Parse(s) / 1000.0;
            break;
        }
      }
      else
      {
        string s = page.Substring(startIndex5, num4 - startIndex5 - 2);
        trackPage.distance = (double) int.Parse(s);
      }
      int num5 = page.IndexOf("Acceleration:</TD>") + 18;
      int num6 = page.IndexOf("</TD>", num5 + 1);
      trackPage.acceleration = 0;
      for (int index = page.IndexOf("lvl", num5 + 1); index < num6 && index > 0; index = page.IndexOf("lvl", index + 1))
        ++trackPage.acceleration;
      int num7 = page.IndexOf("Laps:</TD>") + 10;
      int startIndex7 = page.IndexOf(">", num7 + 1) + 1;
      trackPage.laps = int.Parse(page.Substring(startIndex7, page.IndexOf("<", startIndex7 + 1) - startIndex7));
      int num8 = page.IndexOf("Downforce:</TD>") + 15;
      int startIndex8 = page.IndexOf(">", num8 + 1) + 1;
      string noget1 = page.Substring(startIndex8, page.IndexOf("<", startIndex8 + 1) - startIndex8);
      trackPage.downforce = StringToEnum.String2Downforce(noget1);
      int num9 = page.IndexOf("Lap distance:</TD>") + 18;
      int startIndex9 = page.IndexOf(">", num9 + 1) + 1;
      int startIndex10 = page.IndexOf(".", startIndex9);
      int num10 = page.IndexOf("<", startIndex9);
      if (startIndex10 > 0 && startIndex10 < num10)
      {
        trackPage.lapDistance = (double) int.Parse(page.Substring(startIndex9, startIndex10 - startIndex9));
        string s = page.Substring(startIndex10 + 1, page.IndexOf("&nbsp", startIndex10) - 1 - startIndex10);
        switch (s.Length)
        {
          case 1:
            trackPage.lapDistance += (double) int.Parse(s) / 10.0;
            break;
          case 2:
            trackPage.lapDistance += (double) int.Parse(s) / 100.0;
            break;
          default:
            trackPage.lapDistance += (double) int.Parse(s) / 1000.0;
            break;
        }
      }
      else
        trackPage.lapDistance = (double) int.Parse(page.Substring(startIndex9, num10 - startIndex9 - 1));
      int num11 = page.IndexOf("Overtaking:</TD>") + 16;
      int startIndex11 = page.IndexOf(">", num11 + 1) + 1;
      string noget2 = page.Substring(startIndex11, page.IndexOf("<", startIndex11 + 1) - startIndex11);
      trackPage.overtaking = StringToEnum.String2Overtaking(noget2);
      int num12 = page.IndexOf("Average speed:</TD>") + 19;
      int startIndex12 = page.IndexOf(">", num12 + 1) + 1;
      int startIndex13 = page.IndexOf(".", startIndex12);
      int num13 = page.IndexOf("km", startIndex12);
      int num14 = page.IndexOf("</TD>", startIndex12);
      if (startIndex13 > 0 && startIndex13 < num13 && num13 < num14)
      {
        trackPage.averageSpeed = (double) int.Parse(page.Substring(startIndex12, startIndex13 - startIndex12));
        string s = page.Substring(startIndex13 + 1, page.IndexOf("&nbsp", startIndex13) - 1 - startIndex13);
        switch (s.Length)
        {
          case 1:
            trackPage.averageSpeed += (double) int.Parse(s) / 10.0;
            break;
          case 2:
            trackPage.averageSpeed += (double) int.Parse(s) / 100.0;
            break;
          default:
            trackPage.averageSpeed += (double) int.Parse(s) / 1000.0;
            break;
        }
      }
      else
        trackPage.averageSpeed = !page.Substring(startIndex12).StartsWith("?") ? (double) int.Parse(page.Substring(startIndex12, page.IndexOf("&nbsp", startIndex12) - startIndex12)) : 0.0;
      int num15 = page.IndexOf("Suspension rigidity:</TD>") + 25;
      int startIndex14 = page.IndexOf(">", num15 + 1) + 1;
      string noget3 = page.Substring(startIndex14, page.IndexOf("<", startIndex14 + 1) - startIndex14);
      trackPage.suspensionRigidity = StringToEnum.String2Suspension(noget3);
      int num16 = page.IndexOf("Fuel consumption:</TD>") + 22;
      int startIndex15 = page.IndexOf(">", num16 + 1) + 1;
      string noget4 = page.Substring(startIndex15, page.IndexOf("<", startIndex15 + 1) - startIndex15);
      trackPage.fuelConsumption = StringToEnum.String2Fuel(noget4);
      int num17 = page.IndexOf("Number of corners:</TD>") + 23;
      int startIndex16 = page.IndexOf(">", num17 + 1) + 1;
      page.Substring(startIndex16, page.IndexOf("<", startIndex16 + 1) - startIndex16);
      trackPage.numberOfCorners = int.Parse(page.Substring(startIndex16, page.IndexOf("<", startIndex16 + 1) - startIndex16));
      int num18 = page.IndexOf("Tyre wear:</TD>") + 14;
      int startIndex17 = page.IndexOf(">", num18 + 1) + 1;
      string noget5 = page.Substring(startIndex17, page.IndexOf("<", startIndex17 + 1) - startIndex17);
      trackPage.tyreWear = StringToEnum.String2TyreWear(noget5);
      int num19 = page.IndexOf("Grip level:</TD>") + 15;
      int startIndex18 = page.IndexOf(">", num19 + 1) + 1;
      string noget6 = page.Substring(startIndex18, page.IndexOf("<", startIndex18 + 1) - startIndex18);
      trackPage.grip = StringToEnum.String2Grip(noget6);
      int num20 = page.IndexOf("Time in/out of pits:</TD>") + 25;
      int startIndex19 = page.IndexOf(">", num20 + 1) + 1;
      int startIndex20 = page.IndexOf(".", startIndex19);
      int num21 = page.IndexOf("<", startIndex19);
      if (startIndex20 > 0 && startIndex20 < num21)
      {
        trackPage.timeInPits = (double) int.Parse(page.Substring(startIndex19, startIndex20 - startIndex19));
        string s = page.Substring(startIndex20 + 1, page.IndexOf("s", startIndex20) - 1 - startIndex20);
        switch (s.Length)
        {
          case 1:
            trackPage.timeInPits += (double) int.Parse(s) / 10.0;
            break;
          case 2:
            trackPage.timeInPits += (double) int.Parse(s) / 100.0;
            break;
          default:
            trackPage.timeInPits += (double) int.Parse(s) / 1000.0;
            break;
        }
      }
      else
        trackPage.timeInPits = (double) int.Parse(page.Substring(startIndex19, num21 - startIndex19 - 1));
      int num22 = page.IndexOf("Category:</TD>") + 13;
      int startIndex21 = page.IndexOf(">", num22 + 1) + 1;
      switch (page.Substring(startIndex21, page.IndexOf("<", startIndex21 + 1) - startIndex21))
      {
        case "F1":
          trackPage.category = Category.F1;
          break;
        case "Ex F1":
          trackPage.category = Category.ExF1;
          break;
        default:
          trackPage.category = Category.NonF1;
          break;
      }
      return trackPage;
    }
  }
}
