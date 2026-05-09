// Decompiled with JetBrains decompiler
// Type: go.Season8
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;
using System.Collections;

#nullable disable
namespace go
{
  [Serializable]
  public class Season8
  {
    public int season;
    public RaceEvent7[] events = new RaceEvent7[17];
    public ArrayList financeHistory = new ArrayList();

    public Season8(Season7 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = oldSeason.events;
    }

    public Season8(Season6 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season5 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season4 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season3 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season2 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent7();
    }
  }
}
