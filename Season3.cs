// Decompiled with JetBrains decompiler
// Type: go.Season3
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season3
  {
    public int season;
    public RaceEvent3[] events = new RaceEvent3[17];

    public Season3(Season2 oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent3(oldSeason.events[index]);
    }

    public Season3(Season oldSeason)
    {
      Season3 season3 = new Season3(new Season2(oldSeason));
    }

    public Season3()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent3();
    }
  }
}
