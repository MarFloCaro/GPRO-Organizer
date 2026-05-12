 
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
        string[] strArray1 = origpage.Substring(startIndex1, origpage.IndexOf("</table>", startIndex1) - startIndex1).Replace("<tr", "\u00BD").Split('\u00BD');
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
            int financeItemType = (int) String2Enum.GetFinanceItemType(financeItem);
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
        month = FinanceParser.GetMonth(noget.Substring(0, 3));
        int num = noget.IndexOf("th");
        if (num == -1)
          num = noget.IndexOf("st");
        if (num == -1)
          num = noget.IndexOf("nd");
        if (num == -1)
          num = noget.IndexOf("rd");
        day = int.Parse(noget.Substring(4, num - 4));
        year = int.Parse(noget.Substring(num + 2, noget.IndexOf(",", num + 2) - num - 2));
        startIndex2 = noget.IndexOf(",", num + 2) + 2;
      }
      int hour = int.Parse(noget.Substring(startIndex2, noget.IndexOf(":", startIndex2) - startIndex2));
      int startIndex3 = noget.IndexOf(":", startIndex2) + 1;
      int minute = int.Parse(noget.Substring(startIndex3, noget.IndexOf(":", startIndex3) - startIndex3));
      int startIndex4 = noget.IndexOf(":", startIndex3) + 1;
      int second = int.Parse(noget.Substring(startIndex4, noget.IndexOf("<", startIndex4) - startIndex4));
      return new DateTime(year, month, day, hour, minute, second);
    }

    private static int GetMonth(string month)
    {
      int month1;
      switch (month)
      {
        case "Apr":
          month1 = 4;
          break;
        case "Aug":
          month1 = 8;
          break;
        case "Dec":
          month1 = 12;
          break;
        case "Feb":
          month1 = 2;
          break;
        case "Jan":
          month1 = 1;
          break;
        case "Jul":
          month1 = 7;
          break;
        case "Jun":
          month1 = 6;
          break;
        case "Mar":
          month1 = 3;
          break;
        case "May":
          month1 = 5;
          break;
        case "Nov":
          month1 = 11;
          break;
        case "Oct":
          month1 = 10;
          break;
        case "Sep":
          month1 = 9;
          break;
        default:
          month1 = 0;
          break;
      }
      return month1;
    }
  }
}
