// Decompiled with JetBrains decompiler
// Type: go.Season2
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season2
  {
    public int season;
    public RaceEvent2[] events = new RaceEvent2[17];

    public Season2(Season oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent2(oldSeason.events[index]);
    }

    public Season2()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent2();
    }
  }
}
