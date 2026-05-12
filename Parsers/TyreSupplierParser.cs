 
// Type: go.Parsers.TyreSupplierParser
 
 
 

using go.Utils;
using System;

#nullable disable
namespace go.Parsers
{
  public class TyreSupplierParser : GenericParser
  {
    public static TyreSupplier GetTyreSupplier()
    {
      return TyreSupplierParser.GetTyreSupplier(Datas.Communications.GetPage("Suppliers.asp"));
    }

    public static TyreSupplier GetTyreSupplier(string supplierPage)
    {
      try
      {
        TyreSupplier tyreSupplier = new TyreSupplier();
        int startIndex1 = supplierPage.IndexOf("Contract active");
        if (startIndex1 == -1)
          return tyreSupplier;
        int startIndex2 = supplierPage.LastIndexOf("Dry performance", startIndex1);
        int startIndex3 = supplierPage.IndexOf("lvl", startIndex2);
        int startIndex4;
        for (startIndex4 = supplierPage.IndexOf("</td>", startIndex3); startIndex3 < startIndex4; startIndex3 = supplierPage.IndexOf("lvl", startIndex3 + 1))
          ++tyreSupplier.dryPerf;
        int startIndex5 = supplierPage.IndexOf("Wet performance", startIndex4);
        int startIndex6 = supplierPage.IndexOf("lvl", startIndex5);
        int startIndex7;
        for (startIndex7 = supplierPage.IndexOf("</td>", startIndex6); startIndex6 < startIndex7; startIndex6 = supplierPage.IndexOf("lvl", startIndex6 + 1))
          ++tyreSupplier.wetPerf;
        int startIndex8 = supplierPage.IndexOf("Peak temperature", startIndex7);
        int startIndex9 = supplierPage.IndexOf("<td>", startIndex8) + 4;
        int num = supplierPage.IndexOf("&deg;", startIndex9);
        string s = supplierPage.Substring(startIndex9, num - startIndex9);
        tyreSupplier.peakTemp = int.Parse(s);
        int startIndex10 = supplierPage.IndexOf("Durability", startIndex9);
        int startIndex11 = supplierPage.IndexOf("lvl", startIndex10);
        int startIndex12;
        for (startIndex12 = supplierPage.IndexOf("</td>", startIndex11); startIndex11 < startIndex12; startIndex11 = supplierPage.IndexOf("lvl", startIndex11 + 1))
          ++tyreSupplier.durability;
        int startIndex13 = supplierPage.IndexOf("Warmup distance", startIndex12);
        int startIndex14 = supplierPage.IndexOf("lvl", startIndex13);
        for (int index = supplierPage.IndexOf("</td>", startIndex14); startIndex14 < index && startIndex14 > 0; startIndex14 = supplierPage.IndexOf("lvl", startIndex14 + 1))
          ++tyreSupplier.warmUpDistance;
        return tyreSupplier;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing tyresupplier", ex, supplierPage);
        return new TyreSupplier();
      }
    }
  }
}
