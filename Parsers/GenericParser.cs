 
// Type: go.Parsers.GenericParser
 
 
 

using go.Utils;
using System;
using System.Globalization;

#nullable disable
namespace go.Parsers
{
  public class GenericParser
  {
    protected static string GetRidOfLinks(string noget)
    {
      string[] strArray = noget.Split('<', '>');
      string ridOfLinks = "";
      for (int index = 0; index < strArray.Length; index += 2)
        ridOfLinks += strArray[index];
      return ridOfLinks;
    }

    public static void HandleError(string message, Exception e, string page)
    {
      Errlog.AddToLog("GO errorfile, version: " + Datas.Version.ToString());
      Errlog.AddToLog(message);
      Errlog.AddToLog("Message:");
      Errlog.AddToLog(e.Message);
      Errlog.AddToLog("Stacktrace:");
      Errlog.AddToLog(e.StackTrace);
      Errlog.AddToLog("Offending page:");
      Errlog.AddToLog(page);
      throw new Exception("Error during download. Please check that you are running the latest version, and if so, please send " + Errlog.GetFileName() + " to gpro.organizer@gmail.com for fixing");
    }

    public static int GetMoneyAmount(string noget)
    {
      int num1 = noget.IndexOf("$") + 1;
      bool flag = false;
      if (noget[num1] == '-')
      {
        flag = true;
        ++num1;
      }
      noget = noget.IndexOf("<", num1) <= 0 ? noget.Substring(num1) : noget.Substring(num1, noget.IndexOf("<", num1) - num1);
      int num2 = int.Parse(noget.Trim(), NumberStyles.AllowThousands, (IFormatProvider) new CultureInfo("da-DK"));
      return !flag ? num2 : -num2;
    }

    public static int GetMoneyAmount(string noget, string error)
    {
      int num1 = noget.IndexOf("$") + 1;
      bool flag1 = false;
      if (noget[num1] == '-')
      {
        flag1 = true;
        ++num1;
      }
      bool flag2 = true;
      if (noget.IndexOf("<", num1) > 0)
        flag2 = false;
      noget = noget.Substring(num1, (flag2 ? noget.Length : noget.IndexOf("<", num1)) - num1);
      int num2;
      try
      {
        num2 = int.Parse(noget, NumberStyles.AllowThousands, (IFormatProvider) new CultureInfo("da-DK"));
      }
      catch
      {
        Errlog.AddToLog("Could not parse int \"" + noget + " as " + error);
        throw;
      }
      return !flag1 ? num2 : -num2;
    }

    public static int GetMonth(string month)
    {
      switch (month)
      {
        case "Jan": return 1;
        case "Feb": return 2;
        case "Mar": return 3;
        case "Apr": return 4;
        case "May": return 5;
        case "Jun": return 6;
        case "Jul": return 7;
        case "Aug": return 8;
        case "Sep": return 9;
        case "Oct": return 10;
        case "Nov": return 11;
        case "Dec": return 12;
        default: return 0;
      }
    }

    public static TimeSpan ParseTimeSpan(string noget) => EnumConvert.String2Time(noget);
  }
}
