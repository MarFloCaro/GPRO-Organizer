 
// Type: go.Parsers.FinanceParser
 
 
 

using go.Utils;
using System;
using System.Collections;

#nullable disable
namespace go.Parsers
{
  public class FinanceParser : GenericParser
  {
    public static ArrayList UpdateFinancialHistory()
    {
      return FinanceParser.UpdateFinancialHistory(Datas.Communications.GetPage("EconomyHistory.asp"));
    }

    public static ArrayList UpdateFinancialHistory(string origpage)
    {
      if (origpage.IndexOf("<b>No transactions recorded<b>") > 0)
        return Datas.FinanceHistory;
      ArrayList arrayList = new ArrayList();
      DateTime dateTime = DateTime.MinValue;
      if (Datas.FinanceHistory.Count > 0)
        dateTime = ((FinanceItem) Datas.FinanceHistory[0]).Date;
      try
      {
        int startIndex1 = origpage.IndexOf("Date and time");
        string[] strArray1 = ExtractUntil(origpage, startIndex1, "</table>").Replace("<tr", "\u00BD").Split('\u00BD');
        for (int index1 = 1; index1 < strArray1.Length; ++index1)
        {
          if (!strArray1[index1].Contains("<th"))
          {
            FinanceItem financeItem = new FinanceItem();
            string[] strArray2 = strArray1[index1].Replace("<td", "\u00BD").Split('\u00BD');
            for (int index2 = 0; index2 < strArray2.Length; ++index2)
            {
              switch (index2)
              {
                case 1:
                  financeItem.Date = FinanceParser.GetDateTime(strArray2[index2]);
                  break;
                case 2:
                  int startIndex2 = strArray2[index2].IndexOf('>') + 1;
                  financeItem.Description = strArray2[index2].Substring(startIndex2, strArray2[index2].IndexOf('<', startIndex2) - startIndex2).Trim();
                  break;
                case 3:
                  financeItem.BalanceBefore = GenericParser.GetMoneyAmount(strArray2[index2]);
                  break;
                case 4:
                  financeItem.Amount = GenericParser.GetMoneyAmount(strArray2[index2]);
                  break;
                case 5:
                  financeItem.BalanceAfter = GenericParser.GetMoneyAmount(strArray2[index2]);
                  break;
              }
            }
            int financeItemType = (int) EnumConvert.GetFinanceItemType(financeItem);
            if (!(financeItem.Date > dateTime))
            {
              arrayList.AddRange((ICollection) Datas.FinanceHistory);
              return arrayList;
            }
            arrayList.Add((object) financeItem);
          }
        }
        return arrayList;
      }
      catch (Exception ex)
      {
        GenericParser.HandleError("Error in parsing Financial history", ex, origpage);
        return arrayList;
      }
    }

    private static DateTime GetDateTime(string noget)
    {
      DateTime now = DateTime.Now;
      int startIndex1 = noget.IndexOf("<b>") + 3;
      noget = noget.Substring(startIndex1);
      int month;
      int day;
      int year;
      int startIndex2;
      if (noget.StartsWith("<font color=\"yellow\"><b>Today"))
      {
        month = now.Month;
        day = now.Day;
        year = now.Year;
        startIndex2 = noget.IndexOf("at") + 3;
      }
      else if (noget.StartsWith("<strong class=\"orange\">Yesterday"))
      {
        DateTime dateTime = now.AddDays(-1.0);
        year = dateTime.Year;
        month = dateTime.Month;
        day = dateTime.Day;
        startIndex2 = noget.IndexOf("at") + 3;
      }
      else
      {
        month = GenericParser.GetMonth(noget.Substring(0, 3));
        int num = noget.IndexOf("th");
        if (num == -1)
          num = noget.IndexOf("st");
        if (num == -1)
          num = noget.IndexOf("nd");
        if (num == -1)
          num = noget.IndexOf("rd");
        day = int.Parse(noget.Substring(4, num - 4));
        year = ExtractIntUntil(noget, num + 2, ",");
        startIndex2 = noget.IndexOf(",", num + 2) + 2;
      }
      int hour = ExtractIntUntil(noget, startIndex2, ":");
      int startIndex3 = noget.IndexOf(":", startIndex2) + 1;
      int minute = ExtractIntUntil(noget, startIndex3, ":");
      int startIndex4 = noget.IndexOf(":", startIndex3) + 1;
      int second = ExtractIntUntil(noget, startIndex4, "<");
      return new DateTime(year, month, day, hour, minute, second);
    }

  }
}
