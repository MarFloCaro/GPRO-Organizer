 
// Type: go.Season14
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season14
  {
    public int season;
    public RaceEvent13[] events = new RaceEvent13[17];

    public Season14(Season13 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent13[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent13(oldSeason.events[index]);
    }

    public Season14(Season12 oldSeason)
      : this(new Season13(oldSeason))
    {
    }

    public Season14(Season11 oldSeason)
      : this(new Season12(oldSeason))
    {
    }

    public Season14(Season10 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season9 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season8 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season7 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season6 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season5 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season4 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season3 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season2 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14(Season oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season14()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent13();
    }
  }
}
