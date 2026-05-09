// Decompiled with JetBrains decompiler
// Type: go.Parsers.ManagerParser
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Utils;

#nullable disable
namespace go.Parsers
{
  internal class ManagerParser : GenericParser
  {
    public static Manager GetManager(int id)
    {
      return ManagerParser.GetManager(Datas.Communications.GetPage("ManagerProfile.asp?IDM=" + id.ToString()));
    }

    public static Manager GetManager(string page)
    {
      Manager manager = new Manager();
      if (page.IndexOf("supporter") > 0)
        manager.isSupporter = true;
      return manager;
    }
  }
}
