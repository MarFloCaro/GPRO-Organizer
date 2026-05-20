 
// Type: go.Parsers.SponsorParser
 
 
 

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  public class SponsorParser : GenericParser
  {
    public static SponsorState GetSponsor()
    {
      return SponsorParser.GetSponsor(Datas.Communications.GetPage("NegotiationsOverview.asp"));
    }

    public static SponsorState GetSponsor(string sponsorPage)
    {
      SponsorState sponsor = new SponsorState();
      string str1 = "";
      try
      {
        str1 = "ongoing contracts";
        if (sponsorPage.IndexOf("During the race and the update all representatives of the sponsor companies") > 0)
          return (SponsorState) null;
        int startIndex1 = sponsorPage.IndexOf("<th nowrap>Sponsor name</th>") + 28;
        for (int index = 0; index < 5; ++index)
        {
          OngoingSponsors ongoingSponsors = new OngoingSponsors();
          int startIndex2 = sponsorPage.IndexOf("<td", startIndex1) + 3;
          int startIndex3 = sponsorPage.IndexOf(">", startIndex2) + 1;
          if (sponsorPage.Substring(startIndex3).StartsWith("<"))
            startIndex3 = sponsorPage.IndexOf(">", startIndex3) + 1;
          string str2 = ongoingSponsors.name = sponsorPage.Substring(startIndex3, sponsorPage.IndexOf("<", startIndex3) - startIndex3);
          int startIndex4 = sponsorPage.IndexOf("<td", startIndex3) + 3;
          int startIndex5 = sponsorPage.IndexOf(">", startIndex4) + 1;
          str2 = ongoingSponsors.spot = sponsorPage.Substring(startIndex5, sponsorPage.IndexOf("<", startIndex5) - startIndex5);
          int startIndex6 = sponsorPage.IndexOf("<td", startIndex5) + 3;
          int startIndex7 = sponsorPage.IndexOf(">", startIndex6) + 1;
          string noget = sponsorPage.Substring(startIndex7, sponsorPage.IndexOf("<", startIndex7) - startIndex7);
          ongoingSponsors.amountPerRace = !noget.Equals("-") ? (double) GenericParser.GetMoneyAmount(noget) : 0.0;
          int startIndex8 = sponsorPage.IndexOf("<td", startIndex7) + 3;
          int startIndex9 = sponsorPage.IndexOf(">", startIndex8) + 1;
          str2 = ongoingSponsors.contractStatus = sponsorPage.Substring(startIndex9, sponsorPage.IndexOf("<", startIndex9) - startIndex9);
          int startIndex10 = sponsorPage.IndexOf("<td", startIndex9) + 3;
          int startIndex11 = sponsorPage.IndexOf(">", startIndex10) + 1;
          string s = sponsorPage.Substring(startIndex11, sponsorPage.IndexOf("<", startIndex11) - startIndex11);
          ongoingSponsors.racesLeft = !s.Equals("-") ? int.Parse(s) : 0;
          int startIndex12 = sponsorPage.IndexOf("<td", startIndex11) + 3;
          int startIndex13 = sponsorPage.IndexOf(">", startIndex12) + 1;
          
          string satisfactionCell =
              sponsorPage.Substring(
                  startIndex13,
                  sponsorPage.IndexOf("</td>", startIndex13) - startIndex13
              );
          
          if (satisfactionCell.Contains("title=\""))
          {
              int titleStart =
                  satisfactionCell.IndexOf("title=\"") + 7;
          
              string satisfaction =
                  satisfactionCell.Substring(
                      titleStart,
                      satisfactionCell.IndexOf("\"", titleStart) - titleStart
                  );
          
              ongoingSponsors.sponsorSatisfaction =
                  int.Parse(satisfaction);
          }
          else
          {
              ongoingSponsors.sponsorSatisfaction = 0;
          }
          
          startIndex1 = sponsorPage.IndexOf("</tr>", startIndex13);
          
          sponsor.ongoing[index] = ongoingSponsors;
        }
        int startIndex14 = sponsorPage.IndexOf("<h2>Ongoing negotiations</h2>", startIndex1) + 29;
        int startIndex15 = sponsorPage.IndexOf("<tbody>", startIndex14);
        if (startIndex15 == -1)
          return sponsor;
        int startIndex16 = sponsorPage.LastIndexOf("Change negotiation priorities");
        int num1 = sponsorPage.LastIndexOf("</tr>", startIndex16);
        int num2 = 0;
        int startIndex17;
        for (; startIndex15 < num1; startIndex15 = sponsorPage.IndexOf("</tr>", startIndex17))
        {
          SponsorNegotiations sponsorNegotiations = new SponsorNegotiations();
          int startIndex18 = sponsorPage.IndexOf("<td", startIndex15) + 3;
          int startIndex19 = sponsorPage.IndexOf("NegotiateSponsor.asp?ID=", startIndex18) + 24;
          if (startIndex19 == 23 || startIndex19 > num1)
            return sponsor;
          string s1 = sponsorPage.Substring(startIndex19, sponsorPage.IndexOf("\"", startIndex19) - startIndex19);
          sponsorNegotiations.sponsorId = int.Parse(s1);
          int startIndex20 = sponsorPage.IndexOf(">", startIndex19) + 1;
          string str3 = sponsorNegotiations.name = sponsorPage.Substring(startIndex20, sponsorPage.IndexOf("<", startIndex20) - startIndex20);
          int startIndex21 = sponsorPage.IndexOf("<td", startIndex20) + 3;
          int startIndex22 = sponsorPage.IndexOf(">", startIndex21) + 1;
          str3 = sponsorNegotiations.spot = sponsorPage.Substring(startIndex22, sponsorPage.IndexOf("<", startIndex22) - startIndex22);
          int startIndex23 = sponsorPage.IndexOf("<td", startIndex22) + 3;
          int startIndex24 = sponsorPage.IndexOf(">", startIndex23) + 1;
          if (sponsorPage.Substring(startIndex24).StartsWith("<font"))
          {
            sponsorNegotiations.amountPerRace = 0.0;
          }
          else
          {
            startIndex24 = sponsorPage.IndexOf("$", startIndex24) + 1;
            string noget = sponsorPage.Substring(startIndex24, sponsorPage.IndexOf("<", startIndex24) - startIndex24);
            sponsorNegotiations.amountPerRace = (double) GenericParser.GetMoneyAmount(noget);
          }
          int startIndex25 = sponsorPage.IndexOf("<td", startIndex24) + 3;
          int startIndex26 = sponsorPage.IndexOf(">", startIndex25) + 1;
          if (sponsorPage.Substring(startIndex26).StartsWith("<font"))
          {
            sponsorNegotiations.duration = 0;
          }
          else
          {
            string s2 = sponsorPage.Substring(startIndex26, sponsorPage.IndexOf(" ", startIndex26) - startIndex26);
            sponsorNegotiations.duration = int.Parse(s2);
          }
          int startIndex27 = sponsorPage.IndexOf("<td", startIndex26) + 3;
          int startIndex28 = sponsorPage.IndexOf(">", startIndex27) + 1;
          int startIndex29 = sponsorPage.IndexOf(">", startIndex28) + 1;
          int startIndex30 = sponsorPage.IndexOf(">", startIndex29) + 1;
          string noget1 = sponsorPage.Substring(startIndex30, sponsorPage.IndexOf("%<", startIndex30) - startIndex30);
          sponsorNegotiations.progress = Util.ParseDouble(noget1);
          startIndex17 = sponsorPage.IndexOf("selected>", startIndex30) + 9;
          string noget2 = sponsorPage.Substring(startIndex17, sponsorPage.IndexOf("<", startIndex17) - startIndex17);
          sponsorNegotiations.priority = StringToEnum.String2SponsorPriority(noget2);
          sponsor.negotiations[num2++] = sponsorNegotiations;
        }
        return sponsor;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing SponsorState " + str1, ex, sponsorPage);
        return sponsor;
      }
    }
  }
}
