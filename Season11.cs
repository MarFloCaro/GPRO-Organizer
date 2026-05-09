// Decompiled with JetBrains decompiler
// Type: go.Season11
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season11
  {
    public int season;
    public RaceEvent10[] events = new RaceEvent10[17];

    public Season11(Season10 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent10[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent10(oldSeason.events[index]);
    }

    public Season11(Season9 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season8 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season7 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season6 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season5 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season4 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season3 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season2 oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11(Season oldSeason)
      : this(new Season10(oldSeason))
    {
    }

    public Season11()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent10();
    }
  }
}
