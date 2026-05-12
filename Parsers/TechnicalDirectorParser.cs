 
// Type: go.Parsers.TechnicalDirectorParser
 
 
 

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  internal class TechnicalDirectorParser : GenericParser
  {
    public static TechnicalDirector ParseDirector(int id)
    {
      return id == 0 ? new TechnicalDirector() : TechnicalDirectorParser.ParseDirector(Datas.Communications.GetPage("TechDProfile.asp?ID=" + id.ToString()), id);
    }

    public static TechnicalDirector ParseDirector(string page, int id)
    {
      if (page.IndexOf("OfferContract") > 1)
        return (TechnicalDirector) null;
      TechnicalDirector director = new TechnicalDirector();
      try
      {
        director.id = id;
        int startIndex1 = page.IndexOf("Name:");
        int startIndex2 = page.IndexOf("<td>", startIndex1) + 4;
        string str = director.name = page.Substring(startIndex2, page.IndexOf("<", startIndex2) - startIndex2);
        int startIndex3 = page.IndexOf("(", startIndex2) + 1;
        str = director.nationality = page.Substring(startIndex3, page.IndexOf(")", startIndex3) - startIndex3);
        int startIndex4 = page.IndexOf("Trophies", startIndex3) + 1;
        int startIndex5 = page.IndexOf("<td>", startIndex4) + 4;
        string s1 = page.Substring(startIndex5, page.IndexOf("<", startIndex5) - startIndex5);
        director.trophies = int.Parse(s1);
        int startIndex6 = page.IndexOf("<td>", startIndex5) + 4;
        string s2 = page.Substring(startIndex6, page.IndexOf("<", startIndex6) - startIndex6);
        director.numberOfGps = int.Parse(s2);
        int startIndex7 = page.IndexOf("<td>", startIndex6) + 4;
        string s3 = page.Substring(startIndex7, page.IndexOf("<", startIndex7) - startIndex7);
        director.wins = int.Parse(s3);
        int startIndex8 = page.IndexOf("Overall", startIndex7) + 1;
        int startIndex9 = page.IndexOf("<td>", startIndex8) + 4;
        string s4 = page.Substring(startIndex9, page.IndexOf("<", startIndex9) - startIndex9);
        director.overall = int.Parse(s4);
        int startIndex10 = page.IndexOf("Leadership", startIndex9) + 10;
        int startIndex11 = page.IndexOf("<td>", startIndex10) + 4;
        string s5 = page.Substring(startIndex11, page.IndexOf("<", startIndex11) - startIndex11);
        director.leadership = int.Parse(s5);
        int startIndex12 = page.IndexOf("R&amp;D mechanics", startIndex11) + 17;
        int startIndex13 = page.IndexOf("<td>", startIndex12) + 4;
        string s6 = page.Substring(startIndex13, page.IndexOf("<", startIndex13) - startIndex13);
        director.mechanics = int.Parse(s6);
        int startIndex14 = page.IndexOf("R&amp;D electronics", startIndex13) + 19;
        int startIndex15 = page.IndexOf("<td>", startIndex14) + 4;
        string s7 = page.Substring(startIndex15, page.IndexOf("<", startIndex15) - startIndex15);
        director.electronics = int.Parse(s7);
        int startIndex16 = page.IndexOf("R&amp;D aerodynamics", startIndex15) + 19;
        int startIndex17 = page.IndexOf("<td>", startIndex16) + 4;
        string s8 = page.Substring(startIndex17, page.IndexOf("<", startIndex17) - startIndex17);
        director.aerodynamics = int.Parse(s8);
        int startIndex18 = page.IndexOf("Experience", startIndex17) + 10;
        int startIndex19 = page.IndexOf("<td>", startIndex18) + 4;
        string s9 = page.Substring(startIndex19, page.IndexOf("<", startIndex19) - startIndex19);
        director.experience = int.Parse(s9);
        int startIndex20 = page.IndexOf("Pit coordination", startIndex19) + 16;
        int startIndex21 = page.IndexOf("<td>", startIndex20) + 4;
        string s10 = page.Substring(startIndex21, page.IndexOf("<", startIndex21) - startIndex21);
        director.pitCoordination = int.Parse(s10);
        int startIndex22 = page.IndexOf("Motivation", startIndex21) + 10;
        int startIndex23 = page.IndexOf("<td>", startIndex22) + 4;
        string s11 = page.Substring(startIndex23, page.IndexOf("<", startIndex23) - startIndex23);
        director.motivation = int.Parse(s11);
        int startIndex24 = page.IndexOf("Age:", startIndex23) + 1;
        int startIndex25 = page.IndexOf("<td>", startIndex24) + 4;
        string s12 = page.Substring(startIndex25, page.IndexOf("<", startIndex25) - startIndex25);
        director.age = int.Parse(s12);
        int startIndex26 = page.IndexOf("Salary:", startIndex25) + 1;
        int startIndex27 = page.IndexOf("$", startIndex26) + 1;
        string noget = page.Substring(startIndex27, page.IndexOf("<", startIndex27) - startIndex27);
        director.salary = GenericParser.GetMoneyAmount(noget);
        int startIndex28 = page.IndexOf("Contract length", startIndex27) + 1;
        int startIndex29 = page.IndexOf("<td>", startIndex28) + 4;
        string s13 = page.Substring(startIndex29, page.IndexOf(" ", startIndex29) - startIndex29);
        director.racesLeftOfContract = int.Parse(s13);
        return director;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing Technical Director", ex, page);
        return director;
      }
    }
  }
}
