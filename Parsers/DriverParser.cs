
// Type: go.Parsers.DriverParser




using go.Utils;
using System;
using System.Collections;
using System.Web;

#nullable disable
namespace go.Parsers
{
    public class DriverParser : GenericParser
    {
        public static Driver5 GetDriver(int id)
        {
            Driver5 driver5 = new Driver5();
            return id == 0 ? driver5 : DriverParser.GetDriver(Datas.Communications.GetPage("DriverProfile.asp?ID=" + id.ToString()), id);
        }

        public static Driver5 GetDriver(string driverPage, int id)
        {
            Driver5 driver = new Driver5();
            string str1 = "";
            try
            {
                int startIndex1 = driverPage.IndexOf("<th align=left>Name:") + 20;
                int startIndex2 = driverPage.IndexOf(">", startIndex1) + 1;
                string s1 = driverPage.Substring(startIndex2, driverPage.IndexOf("<", startIndex2) - startIndex2);
                driver.id = id;
                driver.name = HttpUtility.HtmlDecode(s1);
                str1 = "parsing nationality";
                int startIndex3 = driverPage.IndexOf("(", startIndex2) + 1;
                string str2 = driver.nationality = driverPage.Substring(startIndex3, driverPage.IndexOf(")", startIndex3) - startIndex3);
                str1 = "parsing trophies";
                int startIndex4 = driverPage.IndexOf("Trophies", startIndex3) + 1;
                int startIndex5 = driverPage.IndexOf("<td>", startIndex4) + 4;
                string s2 = driverPage.Substring(startIndex5, driverPage.IndexOf("<", startIndex5) - startIndex5);
                driver.trophies = int.Parse(s2);
                str1 = "parsing gps";
                int startIndex6 = driverPage.IndexOf("<td>", startIndex5) + 4;
                string s3 = driverPage.Substring(startIndex6, driverPage.IndexOf("<", startIndex6) - startIndex6);
                driver.numberOfGps = int.Parse(s3);
                str1 = "parsing wins";
                int startIndex7 = driverPage.IndexOf("<td>", startIndex6) + 4;
                string s4 = driverPage.Substring(startIndex7, driverPage.IndexOf("<", startIndex7) - startIndex7);
                driver.wins = int.Parse(s4);
                str1 = "parsing podiums";
                int startIndex8 = driverPage.IndexOf("<td>", startIndex7) + 4;
                string s5 = driverPage.Substring(startIndex8, driverPage.IndexOf("<", startIndex8) - startIndex8);
                driver.podiums = int.Parse(s5);
                str1 = "parsing points";
                int startIndex9 = driverPage.IndexOf("<td>", startIndex8) + 4;
                string s6 = driverPage.Substring(startIndex9, driverPage.IndexOf("<", startIndex9) - startIndex9);
                driver.pointsScored = int.Parse(s6);
                str1 = "parsing poles";
                int startIndex10 = driverPage.IndexOf("<td>", startIndex9) + 4;
                string s7 = driverPage.Substring(startIndex10, driverPage.IndexOf("<", startIndex10) - startIndex10);
                driver.polePositions = int.Parse(s7);
                str1 = "parsing fastest laps";
                int startIndex11 = driverPage.IndexOf("<td>", startIndex10) + 4;
                string s8 = driverPage.Substring(startIndex11, driverPage.IndexOf("<", startIndex11) - startIndex11);
                driver.fastestLaps = int.Parse(s8);
                str1 = "parsing avg. points";
                int startIndex12 = driverPage.IndexOf("<td>", startIndex11) + 4;
                int num1 = driverPage.IndexOf(".", startIndex12);
                int num2 = driverPage.IndexOf("<", startIndex12);
                if (driver.numberOfGps > 0)
                {
                    if (num1 > 0 && num1 < num2)
                    {
                        driver.avPointsPerrace = (double)int.Parse(driverPage.Substring(startIndex12, num1 - startIndex12));
                        string s9 = driverPage.Substring(num1 + 1, num2 - num1 - 1).Trim();
                        switch (s9.Length)
                        {
                            case 1:
                                driver.avPointsPerrace += (double)int.Parse(s9) / 10.0;
                                break;
                            case 2:
                                driver.avPointsPerrace += (double)int.Parse(s9) / 100.0;
                                break;
                            default:
                                driver.avPointsPerrace += (double)int.Parse(s9) / 1000.0;
                                break;
                        }
                    }
                    else
                    {
                        string s10 = driverPage.Substring(startIndex12, driverPage.IndexOf("<", startIndex12) - startIndex12).Trim();
                        driver.avPointsPerrace = (double)int.Parse(s10);
                    }
                }
                str1 = "parsing favorite tracks";
                ArrayList arrayList = new ArrayList();
                int startIndex13 = driverPage.IndexOf("Favorite tracks", startIndex12);
                int num3 = driverPage.IndexOf("</table>", startIndex13);
                int startIndex14;
                for (int startIndex15 = driverPage.IndexOf("TrackDetails.asp", startIndex13); startIndex15 < num3 && startIndex15 > 0; startIndex15 = driverPage.IndexOf("TrackDetails.asp", startIndex14))
                {
                    int startIndex16 = driverPage.IndexOf("id=", startIndex15) + 3;
                    startIndex14 = driverPage.IndexOf("\"", startIndex16);
                    string s11 = driverPage.Substring(startIndex16, startIndex14 - startIndex16);
                    arrayList.Add((object)int.Parse(s11));
                }
                driver.favoriteTracks = (int[])arrayList.ToArray(typeof(int));
                str1 = "parsing energy";
                int startIndex17 = driverPage.IndexOf("Driver energy", startIndex13) + 13;
                int startIndex18 = driverPage.IndexOf("barLabel", startIndex17) + 8;
                int startIndex19 = driverPage.IndexOf(">", startIndex18) + 1;
                string s12 = driverPage.Substring(startIndex19, driverPage.IndexOf("%", startIndex19) - startIndex19);
                driver.energy = int.Parse(s12);
                str1 = "parsing overall";
                int startIndex20 = driverPage.IndexOf("Overall", startIndex19) + 1;
                int startIndex21 = driverPage.IndexOf("nowrap>", startIndex20) + 7;
                string s13 = driverPage.Substring(startIndex21, driverPage.IndexOf("<", startIndex21) - startIndex21);
                driver.overall = int.Parse(s13);
                str1 = "parsing concentration";
                int startIndex22 = driverPage.IndexOf("Concentration", startIndex21) + 6;
                int startIndex23 = driverPage.IndexOf("<td", startIndex22) + 2;
                int startIndex24 = driverPage.IndexOf(">", startIndex23) + 1;
                string s14 = driverPage.Substring(startIndex24, driverPage.IndexOf("&", startIndex24) - startIndex24);
                driver.concentration = int.Parse(s14);
                str1 = "parsing talent";
                int startIndex25 = driverPage.IndexOf("Talent", startIndex24) + 6;
                int startIndex26 = driverPage.IndexOf("<td", startIndex25) + 2;
                int startIndex27 = driverPage.IndexOf(">", startIndex26) + 1;
                string s15 = driverPage.Substring(startIndex27, driverPage.IndexOf("&", startIndex27) - startIndex27);
                driver.talent = int.Parse(s15);
                str1 = "parsing aggresiveness";
                int startIndex28 = driverPage.IndexOf("Aggressiveness", startIndex27) + 6;
                int startIndex29 = driverPage.IndexOf("<td", startIndex28) + 2;
                int startIndex30 = driverPage.IndexOf(">", startIndex29) + 1;
                string s16 = driverPage.Substring(startIndex30, driverPage.IndexOf("&", startIndex30) - startIndex30);
                driver.aggresiveness = int.Parse(s16);
                str1 = "parsing Experience";
                int startIndex31 = driverPage.IndexOf("Experience", startIndex30) + 6;
                int startIndex32 = driverPage.IndexOf("<td", startIndex31) + 2;
                int startIndex33 = driverPage.IndexOf(">", startIndex32) + 1;
                string s17 = driverPage.Substring(startIndex33, driverPage.IndexOf("&", startIndex33) - startIndex33);
                driver.experience = int.Parse(s17);
                str1 = "parsing insight";
                int startIndex34 = driverPage.IndexOf("Technical", startIndex33) + 6;
                int startIndex35 = driverPage.IndexOf("<td", startIndex34) + 2;
                int startIndex36 = driverPage.IndexOf(">", startIndex35) + 1;
                string s18 = driverPage.Substring(startIndex36, driverPage.IndexOf("&", startIndex36) - startIndex36);
                driver.technicalInsight = int.Parse(s18);
                str1 = "parsing stamina";
                int startIndex37 = driverPage.IndexOf("Stamina", startIndex36) + 6;
                int startIndex38 = driverPage.IndexOf("<td", startIndex37) + 2;
                int startIndex39 = driverPage.IndexOf(">", startIndex38) + 1;
                string s19 = driverPage.Substring(startIndex39, driverPage.IndexOf("&", startIndex39) - startIndex39);
                driver.stamina = int.Parse(s19);
                str1 = "parsing charisma";
                int startIndex40 = driverPage.IndexOf("Charisma", startIndex39) + 7;
                int startIndex41 = driverPage.IndexOf("<td", startIndex40) + 2;
                int startIndex42 = driverPage.IndexOf(">", startIndex41) + 1;
                string s20 = driverPage.Substring(startIndex42, driverPage.IndexOf("&", startIndex42) - startIndex42);
                driver.charisma = int.Parse(s20);
                str1 = "parsing motivation";
                int startIndex43 = driverPage.IndexOf("Motivation", startIndex42) + 7;
                int startIndex44 = driverPage.IndexOf("<td", startIndex43) + 2;
                int startIndex45 = driverPage.IndexOf(">", startIndex44) + 1;
                string s21 = driverPage.Substring(startIndex45, driverPage.IndexOf("&", startIndex45) - startIndex45);
                driver.motivation = int.Parse(s21);
                str1 = "parsing reputation";
                int startIndex46 = driverPage.IndexOf("Reputation", startIndex45) + 7;
                int startIndex47 = driverPage.IndexOf("<td", startIndex46) + 2;
                int startIndex48 = driverPage.IndexOf(">", startIndex47) + 1;
                string s22 = driverPage.Substring(startIndex48, driverPage.IndexOf("&", startIndex48) - startIndex48);
                driver.reputation = int.Parse(s22);
                str1 = "parsing weight";
                int startIndex49 = driverPage.IndexOf("Weight", startIndex48) + 7;
                int startIndex50 = driverPage.IndexOf("<td", startIndex49) + 2;
                int startIndex51 = driverPage.IndexOf(">", startIndex50) + 1;
                string s23 = driverPage.Substring(startIndex51, driverPage.IndexOf("&", startIndex51) - startIndex51);
                driver.weight = int.Parse(s23);
                str1 = "parsing age";
                int startIndex52 = driverPage.IndexOf("Age", startIndex51) + 7;
                int startIndex53 = driverPage.IndexOf("<td", startIndex52) + 2;
                int startIndex54 = driverPage.IndexOf(">", startIndex53) + 1;
                string s24 = driverPage.Substring(startIndex54, driverPage.IndexOf("&", startIndex54) - startIndex54);
                driver.age = int.Parse(s24);
                str1 = "parsing salary";
                int startIndex55 = driverPage.IndexOf("Salary", startIndex54) + 7;
                int startIndex56 = driverPage.IndexOf("<td", startIndex55) + 2;
                int startIndex57 = driverPage.IndexOf(">", startIndex56) + 2;
                foreach (string s25 in driverPage.Substring(startIndex57, driverPage.IndexOf("<", startIndex57) - startIndex57).Split(".".ToCharArray()))
                {
                    driver.salary *= 1000;
                    driver.salary += int.Parse(s25);
                }
                str1 = "parsing contract length";
                int startIndex58 = driverPage.IndexOf("Contract", startIndex57) + 7;
                int startIndex59 = driverPage.IndexOf("<td", startIndex58) + 2;
                int startIndex60 = driverPage.IndexOf(">", startIndex59) + 1;
                string s26 = driverPage.Substring(startIndex60, driverPage.IndexOf(" ", startIndex60) - startIndex60);
                driver.racesLeftOfContract = int.Parse(s26);
                return driver;
            }
            catch (Exception ex)
            {
                GenericParser.HandleError("Error in parsing driver " + str1, ex, driverPage);
                return driver;
            }
        }
    }
}
