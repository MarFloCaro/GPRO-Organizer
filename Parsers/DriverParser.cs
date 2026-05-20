
// Type: go.Parsers.DriverParser




using go.Utils;
using System;
using System.Collections;
using System.Text.RegularExpressions;
using System.Web;
using System.Windows.Forms;

#nullable disable

namespace go.Parsers
{
    public class DriverParser : GenericParser
    {
        public static Driver5 GetDriver(int id)
        {
            Driver5 driver5 = new Driver5();

            return id == 0
                ? driver5
                : DriverParser.GetDriver(
                    Datas.Communications.GetPage("DriverProfile.asp?ID=" + id.ToString()),
                    id
                );
        }

        public static Driver5 GetDriver(string driverPage, int id)
        {
            Driver5 driver = new Driver5();
            string str1 = "";

            try
            {
                driver.id = id;

                // -------------------------------------------------
                // NAME
                // -------------------------------------------------

                str1 = "parsing name";

                driver.name = ExtractTdValueAfterTh(driverPage, "Name:");

                driver.name = HttpUtility.HtmlDecode(driver.name).Trim();

                // -------------------------------------------------
                // NATIONALITY
                // -------------------------------------------------

                str1 = "parsing nationality";

                string nationalityCell = ExtractTdHtmlAfterTh(driverPage, "Nat:");

                Match natMatch = Regex.Match(nationalityCell, @"\((.*?)\)");

                if (natMatch.Success)
                {
                    driver.nationality = natMatch.Groups[1].Value.Trim();
                }
                else
                {
                    driver.nationality = "";
                }

                // -------------------------------------------------
                // TROPHIES
                // -------------------------------------------------

                str1 = "parsing trophies";

                int startIndex4 = driverPage.IndexOf("Trophies");
                int startIndex5 = driverPage.IndexOf("<td", startIndex4);
                startIndex5 = driverPage.IndexOf(">", startIndex5) + 1;

                string s2 = driverPage.Substring(
                    startIndex5,
                    driverPage.IndexOf("<", startIndex5) - startIndex5
                );

                driver.trophies = int.Parse(s2);

                // -------------------------------------------------
                // GPS
                // -------------------------------------------------

                str1 = "parsing gps";

                int startIndex6 = driverPage.IndexOf("<td", startIndex5);
                startIndex6 = driverPage.IndexOf(">", startIndex6) + 1;

                string s3 = driverPage.Substring(
                    startIndex6,
                    driverPage.IndexOf("<", startIndex6) - startIndex6
                );

                driver.numberOfGps = int.Parse(s3);

                // -------------------------------------------------
                // WINS
                // -------------------------------------------------

                str1 = "parsing wins";

                int startIndex7 = driverPage.IndexOf("<td", startIndex6);
                startIndex7 = driverPage.IndexOf(">", startIndex7) + 1;

                string s4 = driverPage.Substring(
                    startIndex7,
                    driverPage.IndexOf("<", startIndex7) - startIndex7
                );

                driver.wins = int.Parse(s4);

                // -------------------------------------------------
                // PODIUMS
                // -------------------------------------------------

                str1 = "parsing podiums";

                int startIndex8 = driverPage.IndexOf("<td", startIndex7);
                startIndex8 = driverPage.IndexOf(">", startIndex8) + 1;

                string s5 = driverPage.Substring(
                    startIndex8,
                    driverPage.IndexOf("<", startIndex8) - startIndex8
                );

                driver.podiums = int.Parse(s5);

                // -------------------------------------------------
                // POINTS
                // -------------------------------------------------

                str1 = "parsing points";

                int startIndex9 = driverPage.IndexOf("<td", startIndex8);
                startIndex9 = driverPage.IndexOf(">", startIndex9) + 1;

                string s6 = driverPage.Substring(
                    startIndex9,
                    driverPage.IndexOf("<", startIndex9) - startIndex9
                );

                driver.pointsScored = int.Parse(s6);

                // -------------------------------------------------
                // POLES
                // -------------------------------------------------

                str1 = "parsing poles";

                int startIndex10 = driverPage.IndexOf("<td", startIndex9);
                startIndex10 = driverPage.IndexOf(">", startIndex10) + 1;

                string s7 = driverPage.Substring(
                    startIndex10,
                    driverPage.IndexOf("<", startIndex10) - startIndex10
                );

                driver.polePositions = int.Parse(s7);

                // -------------------------------------------------
                // FASTEST LAPS
                // -------------------------------------------------

                str1 = "parsing fastest laps";

                int startIndex11 = driverPage.IndexOf("<td", startIndex10);
                startIndex11 = driverPage.IndexOf(">", startIndex11) + 1;

                string s8 = driverPage.Substring(
                    startIndex11,
                    driverPage.IndexOf("<", startIndex11) - startIndex11
                );

                driver.fastestLaps = int.Parse(s8);

                // -------------------------------------------------
                // AVG POINTS
                // -------------------------------------------------

                str1 = "parsing avg. points";

                int startIndex12 = driverPage.IndexOf("<td", startIndex11);
                startIndex12 = driverPage.IndexOf(">", startIndex12) + 1;

                int num1 = driverPage.IndexOf(".", startIndex12);
                int num2 = driverPage.IndexOf("<", startIndex12);

                if (driver.numberOfGps > 0)
                {
                    if (num1 > 0 && num1 < num2)
                    {
                        driver.avPointsPerrace =
                            (double)int.Parse(
                                driverPage.Substring(startIndex12, num1 - startIndex12)
                            );

                        string s9 = driverPage.Substring(
                            num1 + 1,
                            num2 - num1 - 1
                        ).Trim();

                        switch (s9.Length)
                        {
                            case 1:
                                driver.avPointsPerrace +=
                                    (double)int.Parse(s9) / 10.0;
                                break;

                            case 2:
                                driver.avPointsPerrace +=
                                    (double)int.Parse(s9) / 100.0;
                                break;

                            default:
                                driver.avPointsPerrace +=
                                    (double)int.Parse(s9) / 1000.0;
                                break;
                        }
                    }
                    else
                    {
                        string s10 = driverPage.Substring(
                            startIndex12,
                            driverPage.IndexOf("<", startIndex12) - startIndex12
                        ).Trim();

                        driver.avPointsPerrace = (double)int.Parse(s10);
                    }
                }

                // -------------------------------------------------
                // FAVORITE TRACKS
                // -------------------------------------------------

                str1 = "parsing favorite tracks";

                ArrayList arrayList = new ArrayList();

                int startIndex13 = driverPage.IndexOf("Favorite tracks", startIndex12);
                int num3 = driverPage.IndexOf("</table>", startIndex13);

                int startIndex14;

                for (
                    int startIndex15 = driverPage.IndexOf("TrackDetails.asp", startIndex13);
                    startIndex15 < num3 && startIndex15 > 0;
                    startIndex15 = driverPage.IndexOf("TrackDetails.asp", startIndex14)
                )
                {
                    int startIndex16 = driverPage.IndexOf("id=", startIndex15) + 3;

                    startIndex14 = driverPage.IndexOf("\"", startIndex16);

                    string s11 = driverPage.Substring(
                        startIndex16,
                        startIndex14 - startIndex16
                    );

                    arrayList.Add((object)int.Parse(s11));
                }

                driver.favoriteTracks =
                    (int[])arrayList.ToArray(typeof(int));

                // -------------------------------------------------
                // ENERGY
                // -------------------------------------------------

                str1 = "parsing energy";

                int startIndex17 = driverPage.IndexOf("Driver energy", startIndex13) + 13;
                int startIndex18 = driverPage.IndexOf("barLabel", startIndex17) + 8;
                int startIndex19 = driverPage.IndexOf(">", startIndex18) + 1;

                string s12 = driverPage.Substring(
                    startIndex19,
                    driverPage.IndexOf("%", startIndex19) - startIndex19
                );

                driver.energy = int.Parse(s12);

                // -------------------------------------------------
                // OVERALL
                // -------------------------------------------------

                str1 = "parsing overall";

                int startIndex20 = driverPage.IndexOf("Overall", startIndex19) + 1;
                int startIndex21 = driverPage.IndexOf("nowrap>", startIndex20) + 7;

                string s13 = driverPage.Substring(
                    startIndex21,
                    driverPage.IndexOf("<", startIndex21) - startIndex21
                );

                driver.overall = int.Parse(s13);

                // -------------------------------------------------
                // ATTRIBUTES
                // -------------------------------------------------

                driver.concentration = ParseAttribute(driverPage, "Concentration");
                driver.talent = ParseAttribute(driverPage, "Talent");
                driver.aggresiveness = ParseAttribute(driverPage, "Aggressiveness");
                driver.experience = ParseAttribute(driverPage, "Experience");
                driver.technicalInsight = ParseAttribute(driverPage, "Technical");
                driver.stamina = ParseAttribute(driverPage, "Stamina");
                driver.charisma = ParseAttribute(driverPage, "Charisma");
                driver.motivation = ParseAttribute(driverPage, "Motivation");
                driver.reputation = ParseAttribute(driverPage, "Reputation");
                driver.weight = ParseAttribute(driverPage, "Weight");
                driver.age = ParseAttribute(driverPage, "Age");

                // -------------------------------------------------
                // SALARY
                // -------------------------------------------------

                str1 = "parsing salary";

                int startIndex55 = driverPage.IndexOf("<th>Salary:</th>");

                int startIndex56 = driverPage.IndexOf("<td", startIndex55);
                startIndex56 = driverPage.IndexOf(">", startIndex56) + 1;

                int endIndex56 = driverPage.IndexOf("</td>", startIndex56);

                string salaryString = driverPage.Substring(
                    startIndex56,
                    endIndex56 - startIndex56
                );

                salaryString = HttpUtility.HtmlDecode(salaryString);

                salaryString = salaryString
                    .Replace("$", "")
                    .Replace(".", "")
                    .Replace(",", "")
                    .Replace(" ", "")
                    .Trim();

                driver.salary = int.Parse(salaryString);

                // -------------------------------------------------
                // CONTRACT
                // -------------------------------------------------

                str1 = "parsing contract length";

                int startIndex58 = driverPage.IndexOf("Contract", startIndex56);
                int startIndex59 = driverPage.IndexOf("<td", startIndex58);
                startIndex59 = driverPage.IndexOf(">", startIndex59) + 1;

                string s26 = driverPage.Substring(
                    startIndex59,
                    driverPage.IndexOf(" ", startIndex59) - startIndex59
                );

                driver.racesLeftOfContract = int.Parse(s26);

                return driver;
            }
            catch (Exception ex)
            {
                GenericParser.HandleError(
                    "Error in parsing driver " + str1,
                    ex,
                    driverPage
                );

                return driver;
            }
        }

        // =====================================================
        // HELPERS
        // =====================================================

        private static string ExtractTdValueAfterTh(
            string html,
            string thText
        )
        {
            int thIndex = html.IndexOf(thText);

            if (thIndex < 0)
            {
                throw new Exception("Could not find TH: " + thText);
            }

            int tdStart = html.IndexOf("<td", thIndex);

            tdStart = html.IndexOf(">", tdStart) + 1;

            int tdEnd = html.IndexOf("</td>", tdStart);

            string value = html.Substring(tdStart, tdEnd - tdStart);

            value = Regex.Replace(value, "<.*?>", "");

            return HttpUtility.HtmlDecode(value).Trim();
        }

        private static string ExtractTdHtmlAfterTh(
            string html,
            string thText
        )
        {
            int thIndex = html.IndexOf(thText);

            if (thIndex < 0)
            {
                throw new Exception("Could not find TH: " + thText);
            }

            int tdStart = html.IndexOf("<td", thIndex);

            tdStart = html.IndexOf(">", tdStart) + 1;

            int tdEnd = html.IndexOf("</td>", tdStart);

            return html.Substring(tdStart, tdEnd - tdStart);
        }

        private static int ParseAttribute(
            string driverPage,
            string attributeName
        )
        {
            int startIndex = driverPage.IndexOf(attributeName);

            startIndex = driverPage.IndexOf("<td", startIndex);
            startIndex = driverPage.IndexOf(">", startIndex) + 1;

            string value = driverPage.Substring(
                startIndex,
                driverPage.IndexOf("&", startIndex) - startIndex
            );

            return int.Parse(value);
        }
    }
}