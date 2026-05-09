// Decompiled with JetBrains decompiler
// Type: go.Season6
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season6
  {
    public int season;
    public RaceEvent6[] events = new RaceEvent6[17];

    public Season6(Season5 oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent6(oldSeason.events[index]);
    }

    public Season6(Season4 oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6(Season3 oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6(Season2 oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6(Season oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent6();
    }
  }
}
