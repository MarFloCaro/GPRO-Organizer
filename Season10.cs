// Decompiled with JetBrains decompiler
// Type: go.Season10
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season10
  {
    public int season;
    public RaceEvent9[] events = new RaceEvent9[17];

    public Season10(Season9 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent9[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent9(oldSeason.events[index]);
    }

    public Season10(Season8 oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10(Season7 oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10(Season6 oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10(Season5 oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10(Season4 oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10(Season3 oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10(Season2 oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10(Season oldSeason)
      : this(new Season9(oldSeason))
    {
    }

    public Season10()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent9();
    }
  }
}
