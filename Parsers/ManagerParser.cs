 
// Type: go.Parsers.ManagerParser
 
 
 

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
