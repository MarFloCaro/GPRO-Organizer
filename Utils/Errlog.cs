 
// Type: go.Utils.Errlog
 
 
 

using System;
using System.IO;

#nullable disable
namespace go.Utils
{
  internal static class Errlog
  {
    private static bool begun = false;
    private static StreamWriter stream = new StreamWriter((Stream) new FileStream(Errlog.getFileName(), FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite));

    public static void Close() => Errlog.stream.Close();

    public static void AddToLog(string noget)
    {
      if (!Errlog.begun)
        Errlog.BeginLog();
      Errlog.stream.WriteLine(noget);
    }

    private static void BeginLog()
    {
      Errlog.stream.WriteLine();
      Errlog.begun = true;
    }

    public static string getFileName()
    {
      return Datas.KeepDataWithApp ? "error.log" : Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GO\\error.log";
    }
  }
}
