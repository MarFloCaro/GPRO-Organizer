 
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
        string str = director.name = ExtractUntil(page, startIndex2, "<");
        int startIndex3 = page.IndexOf("(", startIndex2) + 1;
        str = director.nationality = ExtractUntil(page, startIndex3, ")");
        int startIndex4 = page.IndexOf("Trophies", startIndex3) + 1;
        int startIndex5 = page.IndexOf("<td>", startIndex4) + 4;
        director.trophies = ExtractIntUntil(page, startIndex5, "<");
        int startIndex6 = page.IndexOf("<td>", startIndex5) + 4;
        director.numberOfGps = ExtractIntUntil(page, startIndex6, "<");
        int startIndex7 = page.IndexOf("<td>", startIndex6) + 4;
        director.wins = ExtractIntUntil(page, startIndex7, "<");
        int startIndex8 = page.IndexOf("Overall", startIndex7) + 1;
        int startIndex9 = page.IndexOf("<td>", startIndex8) + 4;
        director.overall = ExtractIntUntil(page, startIndex9, "<");
        int startIndex10 = page.IndexOf("Leadership", startIndex9) + 10;
        int startIndex11 = page.IndexOf("<td>", startIndex10) + 4;
        director.leadership = ExtractIntUntil(page, startIndex11, "<");
        int startIndex12 = page.IndexOf("R&amp;D mechanics", startIndex11) + 17;
        int startIndex13 = page.IndexOf("<td>", startIndex12) + 4;
        director.mechanics = ExtractIntUntil(page, startIndex13, "<");
        int startIndex14 = page.IndexOf("R&amp;D electronics", startIndex13) + 19;
        int startIndex15 = page.IndexOf("<td>", startIndex14) + 4;
        director.electronics = ExtractIntUntil(page, startIndex15, "<");
        int startIndex16 = page.IndexOf("R&amp;D aerodynamics", startIndex15) + 19;
        int startIndex17 = page.IndexOf("<td>", startIndex16) + 4;
        director.aerodynamics = ExtractIntUntil(page, startIndex17, "<");
        int startIndex18 = page.IndexOf("Experience", startIndex17) + 10;
        int startIndex19 = page.IndexOf("<td>", startIndex18) + 4;
        director.experience = ExtractIntUntil(page, startIndex19, "<");
        int startIndex20 = page.IndexOf("Pit coordination", startIndex19) + 16;
        int startIndex21 = page.IndexOf("<td>", startIndex20) + 4;
        director.pitCoordination = ExtractIntUntil(page, startIndex21, "<");
        int startIndex22 = page.IndexOf("Motivation", startIndex21) + 10;
        int startIndex23 = page.IndexOf("<td>", startIndex22) + 4;
        director.motivation = ExtractIntUntil(page, startIndex23, "<");
        int startIndex24 = page.IndexOf("Age:", startIndex23) + 1;
        int startIndex25 = page.IndexOf("<td>", startIndex24) + 4;
        director.age = ExtractIntUntil(page, startIndex25, "<");
        int startIndex26 = page.IndexOf("Salary:", startIndex25) + 1;
        int startIndex27 = page.IndexOf("$", startIndex26) + 1;
        string noget = ExtractUntil(page, startIndex27, "<");
        director.salary = GenericParser.GetMoneyAmount(noget);
        int startIndex28 = page.IndexOf("Contract length", startIndex27) + 1;
        int startIndex29 = page.IndexOf("<td>", startIndex28) + 4;
        director.racesLeftOfContract = ExtractIntUntil(page, startIndex29, " ");
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
