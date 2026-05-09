// Decompiled with JetBrains decompiler
// Type: go.Parsers.GenericParser
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
      throw new Exception("Error during download. Please check that you are running the latest version, and if so, please send " + Errlog.getFileName() + " to gpro.organizer@gmail.com for fixing");
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

    public static TimeSpan ParseTimeSpan(string noget) => StringToEnum.String2Time(noget);
  }
}
