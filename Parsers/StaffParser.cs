 
// Type: go.Parsers.StaffParser
 
 
 

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  public class StaffParser : GenericParser
  {
    public static Staff ParseStaff()
    {
      return StaffParser.ParseStaff(Datas.Communications.GetPage("StaffAndFacilities.asp"));
    }

    public static Staff ParseStaff(string staffPage)
    {
      Staff staff = new Staff();
      try
      {
        int startIndex1 = staffPage.IndexOf("Overall:");
        int startIndex2 = staffPage.IndexOf("<td", startIndex1) + 3;
        int startIndex3 = staffPage.IndexOf(">", startIndex2) + 1;
        staff.overall = ExtractIntUntil(staffPage, startIndex3, "<");
        int startIndex4 = staffPage.IndexOf("Staff salary:", startIndex3);
        int startIndex5 = staffPage.IndexOf(":", startIndex4);
        string noget1 = ExtractUntil(staffPage, startIndex5, "&");
        staff.salary = GenericParser.GetMoneyAmount(noget1);
        int startIndex6 = staffPage.IndexOf("Facilities maintenance:", startIndex5);
        int startIndex7 = staffPage.IndexOf(":", startIndex6);
        string noget2 = ExtractUntil(staffPage, startIndex7, "<");
        staff.maintenance = GenericParser.GetMoneyAmount(noget2);
        int startIndex8 = staffPage.IndexOf("Experience:", startIndex7);
        int startIndex9 = staffPage.IndexOf("<td", startIndex8) + 3;
        int startIndex10 = staffPage.IndexOf(">", startIndex9) + 1;
        staff.experience = ExtractIntUntil(staffPage, startIndex10, "<");
        int startIndex11 = staffPage.IndexOf("Motivation:", startIndex10);
        int startIndex12 = staffPage.IndexOf("<td", startIndex11) + 3;
        int startIndex13 = staffPage.IndexOf(">", startIndex12) + 1;
        staff.motivation = ExtractIntUntil(staffPage, startIndex13, "<");
        int startIndex14 = staffPage.IndexOf("Technical skill:", startIndex13);
        int startIndex15 = staffPage.IndexOf("<td", startIndex14) + 3;
        int startIndex16 = staffPage.IndexOf(">", startIndex15) + 1;
        staff.technicalSkill = ExtractIntUntil(staffPage, startIndex16, "<");
        int startIndex17 = staffPage.IndexOf("Stress handling:", startIndex16);
        int startIndex18 = staffPage.IndexOf("<td", startIndex17) + 3;
        int startIndex19 = staffPage.IndexOf(">", startIndex18) + 1;
        staff.stressHandling = ExtractIntUntil(staffPage, startIndex19, "<");
        int startIndex20 = staffPage.IndexOf("Concentration:", startIndex19);
        int startIndex21 = staffPage.IndexOf("<td", startIndex20) + 3;
        int startIndex22 = staffPage.IndexOf(">", startIndex21) + 1;
        staff.concentration = ExtractIntUntil(staffPage, startIndex22, "<");
        int startIndex23 = staffPage.IndexOf("Efficiency:", startIndex22);
        int startIndex24 = staffPage.IndexOf("<td", startIndex23) + 3;
        int startIndex25 = staffPage.IndexOf(">", startIndex24) + 1;
        staff.efficiency = ExtractIntUntil(staffPage, startIndex25, "<");
        int startIndex26 = staffPage.IndexOf("Windtunnel:", startIndex25);
        int startIndex27 = staffPage.IndexOf("<td", startIndex26) + 3;
        int startIndex28 = staffPage.IndexOf(">", startIndex27) + 1;
        staff.windtunnel = ExtractIntUntil(staffPage, startIndex28, "<");
        int startIndex29 = staffPage.IndexOf("Pitstop training center:", startIndex28);
        int startIndex30 = staffPage.IndexOf("<td", startIndex29) + 3;
        int startIndex31 = staffPage.IndexOf(">", startIndex30) + 1;
        staff.pitstopTrainingCenter = ExtractIntUntil(staffPage, startIndex31, "<");
        int startIndex32 = staffPage.IndexOf("R&amp;D workshop:", startIndex31);
        int startIndex33 = staffPage.IndexOf("<td", startIndex32) + 3;
        int startIndex34 = staffPage.IndexOf(">", startIndex33) + 1;
        staff.rDWorkshop = ExtractIntUntil(staffPage, startIndex34, "<");
        int startIndex35 = staffPage.IndexOf("R&amp;D design center:", startIndex34);
        int startIndex36 = staffPage.IndexOf("<td", startIndex35) + 3;
        int startIndex37 = staffPage.IndexOf(">", startIndex36) + 1;
        staff.rDDesignCenter = ExtractIntUntil(staffPage, startIndex37, "<");
        int startIndex38 = staffPage.IndexOf("Engineering workshop:", startIndex37);
        int startIndex39 = staffPage.IndexOf("<td", startIndex38) + 3;
        int startIndex40 = staffPage.IndexOf(">", startIndex39) + 1;
        staff.engineeringWorkshop = ExtractIntUntil(staffPage, startIndex40, "<");
        int startIndex41 = staffPage.IndexOf("Alloy and chemical lab:", startIndex40);
        int startIndex42 = staffPage.IndexOf("<td", startIndex41) + 3;
        int startIndex43 = staffPage.IndexOf(">", startIndex42) + 1;
        staff.alloyAndChemicalLab = ExtractIntUntil(staffPage, startIndex43, "<");
        int startIndex44 = staffPage.IndexOf("Commercial:", startIndex43);
        int startIndex45 = staffPage.IndexOf("<td", startIndex44) + 3;
        int startIndex46 = staffPage.IndexOf(">", startIndex45) + 1;
        staff.commercial = ExtractIntUntil(staffPage, startIndex46, "<");
        return staff;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Failure during Staff parsing", ex, staffPage);
        return staff;
      }
    }
  }
}
