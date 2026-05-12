 
// Type: go.Season15
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season15
  {
    public int season;
    public RaceEvent14[] events = new RaceEvent14[17];

    public Season15(Season14 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent14[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent14(oldSeason.events[index]);
    }

    public Season15(Season13 oldSeason)
      : this(new Season14(oldSeason))
    {
    }

    public Season15(Season12 oldSeason)
      : this(new Season13(oldSeason))
    {
    }

    public Season15(Season11 oldSeason)
      : this(new Season12(oldSeason))
    {
    }

    public Season15(Season10 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season9 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season8 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season7 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season6 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season5 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season4 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season3 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season2 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15(Season oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season15()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent14();
    }
  }
}
