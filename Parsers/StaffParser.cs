 
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
        string s1 = staffPage.Substring(startIndex3, staffPage.IndexOf("<", startIndex3) - startIndex3);
        staff.overall = int.Parse(s1);
        int startIndex4 = staffPage.IndexOf("Staff salary:", startIndex3);
        int startIndex5 = staffPage.IndexOf(":", startIndex4);
        string noget1 = staffPage.Substring(startIndex5, staffPage.IndexOf("&", startIndex5) - startIndex5);
        staff.salary = GenericParser.GetMoneyAmount(noget1);
        int startIndex6 = staffPage.IndexOf("Facilities maintenance:", startIndex5);
        int startIndex7 = staffPage.IndexOf(":", startIndex6);
        string noget2 = staffPage.Substring(startIndex7, staffPage.IndexOf("<", startIndex7) - startIndex7);
        staff.maintenance = GenericParser.GetMoneyAmount(noget2);
        int startIndex8 = staffPage.IndexOf("Experience:", startIndex7);
        int startIndex9 = staffPage.IndexOf("<td", startIndex8) + 3;
        int startIndex10 = staffPage.IndexOf(">", startIndex9) + 1;
        string s2 = staffPage.Substring(startIndex10, staffPage.IndexOf("<", startIndex10) - startIndex10);
        staff.experience = int.Parse(s2);
        int startIndex11 = staffPage.IndexOf("Motivation:", startIndex10);
        int startIndex12 = staffPage.IndexOf("<td", startIndex11) + 3;
        int startIndex13 = staffPage.IndexOf(">", startIndex12) + 1;
        string s3 = staffPage.Substring(startIndex13, staffPage.IndexOf("<", startIndex13) - startIndex13);
        staff.motivation = int.Parse(s3);
        int startIndex14 = staffPage.IndexOf("Technical skill:", startIndex13);
        int startIndex15 = staffPage.IndexOf("<td", startIndex14) + 3;
        int startIndex16 = staffPage.IndexOf(">", startIndex15) + 1;
        string s4 = staffPage.Substring(startIndex16, staffPage.IndexOf("<", startIndex16) - startIndex16);
        staff.technicalSkill = int.Parse(s4);
        int startIndex17 = staffPage.IndexOf("Stress handling:", startIndex16);
        int startIndex18 = staffPage.IndexOf("<td", startIndex17) + 3;
        int startIndex19 = staffPage.IndexOf(">", startIndex18) + 1;
        string s5 = staffPage.Substring(startIndex19, staffPage.IndexOf("<", startIndex19) - startIndex19);
        staff.stressHandling = int.Parse(s5);
        int startIndex20 = staffPage.IndexOf("Concentration:", startIndex19);
        int startIndex21 = staffPage.IndexOf("<td", startIndex20) + 3;
        int startIndex22 = staffPage.IndexOf(">", startIndex21) + 1;
        string s6 = staffPage.Substring(startIndex22, staffPage.IndexOf("<", startIndex22) - startIndex22);
        staff.concentration = int.Parse(s6);
        int startIndex23 = staffPage.IndexOf("Efficiency:", startIndex22);
        int startIndex24 = staffPage.IndexOf("<td", startIndex23) + 3;
        int startIndex25 = staffPage.IndexOf(">", startIndex24) + 1;
        string s7 = staffPage.Substring(startIndex25, staffPage.IndexOf("<", startIndex25) - startIndex25);
        staff.efficiency = int.Parse(s7);
        int startIndex26 = staffPage.IndexOf("Windtunnel:", startIndex25);
        int startIndex27 = staffPage.IndexOf("<td", startIndex26) + 3;
        int startIndex28 = staffPage.IndexOf(">", startIndex27) + 1;
        string s8 = staffPage.Substring(startIndex28, staffPage.IndexOf("<", startIndex28) - startIndex28);
        staff.windtunnel = int.Parse(s8);
        int startIndex29 = staffPage.IndexOf("Pitstop training center:", startIndex28);
        int startIndex30 = staffPage.IndexOf("<td", startIndex29) + 3;
        int startIndex31 = staffPage.IndexOf(">", startIndex30) + 1;
        string s9 = staffPage.Substring(startIndex31, staffPage.IndexOf("<", startIndex31) - startIndex31);
        staff.pitstopTrainingCenter = int.Parse(s9);
        int startIndex32 = staffPage.IndexOf("R&amp;D workshop:", startIndex31);
        int startIndex33 = staffPage.IndexOf("<td", startIndex32) + 3;
        int startIndex34 = staffPage.IndexOf(">", startIndex33) + 1;
        string s10 = staffPage.Substring(startIndex34, staffPage.IndexOf("<", startIndex34) - startIndex34);
        staff.rDWorkshop = int.Parse(s10);
        int startIndex35 = staffPage.IndexOf("R&amp;D design center:", startIndex34);
        int startIndex36 = staffPage.IndexOf("<td", startIndex35) + 3;
        int startIndex37 = staffPage.IndexOf(">", startIndex36) + 1;
        string s11 = staffPage.Substring(startIndex37, staffPage.IndexOf("<", startIndex37) - startIndex37);
        staff.rDDesignCenter = int.Parse(s11);
        int startIndex38 = staffPage.IndexOf("Engineering workshop:", startIndex37);
        int startIndex39 = staffPage.IndexOf("<td", startIndex38) + 3;
        int startIndex40 = staffPage.IndexOf(">", startIndex39) + 1;
        string s12 = staffPage.Substring(startIndex40, staffPage.IndexOf("<", startIndex40) - startIndex40);
        staff.engineeringWorkshop = int.Parse(s12);
        int startIndex41 = staffPage.IndexOf("Alloy and chemical lab:", startIndex40);
        int startIndex42 = staffPage.IndexOf("<td", startIndex41) + 3;
        int startIndex43 = staffPage.IndexOf(">", startIndex42) + 1;
        string s13 = staffPage.Substring(startIndex43, staffPage.IndexOf("<", startIndex43) - startIndex43);
        staff.alloyAndChemicalLab = int.Parse(s13);
        int startIndex44 = staffPage.IndexOf("Commercial:", startIndex43);
        int startIndex45 = staffPage.IndexOf("<td", startIndex44) + 3;
        int startIndex46 = staffPage.IndexOf(">", startIndex45) + 1;
        string s14 = staffPage.Substring(startIndex46, staffPage.IndexOf("<", startIndex46) - startIndex46);
        staff.commercial = int.Parse(s14);
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
