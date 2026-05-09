// Decompiled with JetBrains decompiler
// Type: go.Utils.Util
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using Microsoft.Win32;

#nullable disable
namespace go.Utils
{
  public static class Util
  {
    public static string URI = "https://gpro.net/gb/";

    public static int GetRegistryInt(ref RegistryKey hkey, string name)
    {
      object obj = hkey.GetValue(name);
      return obj == null ? 0 : (int) obj;
    }

    public static double ParseDouble(string noget)
    {
      if (noget.Equals("&nbsp;"))
        return 0.0;
      int length = noget.IndexOf(".");
      if (length <= 0)
        return (double) int.Parse(noget);
      double num1 = (double) int.Parse(noget.Substring(0, length));
      noget = noget.Substring(length + 1);
      double num2;
      switch (noget.Length)
      {
        case 1:
          num2 = num1 + (double) int.Parse(noget) / 10.0;
          break;
        case 2:
          num2 = num1 + (double) int.Parse(noget) / 100.0;
          break;
        default:
          num2 = num1 + (double) int.Parse(noget) / 1000.0;
          break;
      }
      return num2;
    }
  }
}
