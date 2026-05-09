// Decompiled with JetBrains decompiler
// Type: go.Season12
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season12
  {
    public int season;
    public RaceEvent11[] events = new RaceEvent11[17];

    public Season12(Season11 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent11[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent11(oldSeason.events[index]);
    }

    public Season12(Season10 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season9 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season8 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season7 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season6 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season5 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season4 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season3 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season2 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12(Season oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season12()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent11();
    }
  }
}
