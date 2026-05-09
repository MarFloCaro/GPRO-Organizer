// Decompiled with JetBrains decompiler
// Type: go.Utils.TrackNamesHandler
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System.Collections;

#nullable disable
namespace go.Utils
{
  public class TrackNamesHandler
  {
    private ArrayList names = new ArrayList();

    public void InsertTrackname(string name)
    {
      for (int index = 0; index < this.names.Count; ++index)
      {
        if (name == (string) this.names[index])
          return;
        if (name.CompareTo((string) this.names[index]) < 0)
        {
          this.names.Insert(index, (object) name);
          return;
        }
      }
      this.names.Add((object) name);
    }

    public ArrayList GetContents() => this.names;
  }
}
