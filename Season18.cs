 
// Type: go.Season18
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season18
  {
    public int season;
    public RaceEvent17[] events = new RaceEvent17[17];

    public Season18(Season17 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent17[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent17(oldSeason.events[index]);
    }

    public Season18(Season16 oldSeason)
      : this(new Season17(oldSeason))
    {
    }

    public Season18(Season15 oldSeason)
      : this(new Season16(oldSeason))
    {
    }

    public Season18(Season14 oldSeason)
      : this(new Season15(oldSeason))
    {
    }

    public Season18(Season13 oldSeason)
      : this(new Season14(oldSeason))
    {
    }

    public Season18(Season12 oldSeason)
      : this(new Season13(oldSeason))
    {
    }

    public Season18(Season11 oldSeason)
      : this(new Season12(oldSeason))
    {
    }

    public Season18(Season10 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season9 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season8 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season7 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season6 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season5 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season4 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season3 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season2 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18(Season oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season18()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent17();
    }
  }
}
