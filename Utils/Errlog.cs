 
// Type: go.Utils.Errlog
 
 
 

using System;
using System.IO;

#nullable disable
namespace go.Utils
{
    internal static class Errlog
    {
        private static readonly object _lock = new object();
    
        public static string getFileName()
        {
            return Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "error.log");
        }
    
        public static void AddToLog(string message)
        {
            try
            {
                lock (_lock)
                {
                    using (StreamWriter stream =
                        new StreamWriter(getFileName(), true))
                    {
                        stream.WriteLine(
                            $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] {message}");
                    }
                }
            }
            catch
            {
                // Never throw from logger
            }
        }
    
        public static void Close()
        {
            // Compatibility with legacy code
        }
    }
}
