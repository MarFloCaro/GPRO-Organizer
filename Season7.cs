// Decompiled with JetBrains decompiler
// Type: go.Season7
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season7
  {
    public int season;
    public RaceEvent7[] events = new RaceEvent7[17];

    public Season7(Season6 oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent7(oldSeason.events[index]);
    }

    public Season7(Season5 oldSeason)
      : this(new Season6(oldSeason))
    {
    }

    public Season7(Season4 oldSeason)
      : this(new Season6(oldSeason))
    {
    }

    public Season7(Season3 oldSeason)
      : this(new Season6(oldSeason))
    {
    }

    public Season7(Season2 oldSeason)
      : this(new Season6(oldSeason))
    {
    }

    public Season7(Season oldSeason)
      : this(new Season6(oldSeason))
    {
    }

    public Season7()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent7();
    }
  }
}
