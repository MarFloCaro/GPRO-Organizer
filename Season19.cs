 
// Type: go.Season19
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season19
  {
    private int season;
    private RaceEvent19[] events = new RaceEvent19[17];

    public int Season
    {
      get => this.season;
      set => this.season = value;
    }

    public RaceEvent19[] Events
    {
      get => this.events;
      set => this.events = value;
    }

    public Season19(Season18 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent19[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent19(oldSeason.events[index]);
    }

    public Season19(Season17 oldSeason)
      : this(new Season18(oldSeason))
    {
    }

    public Season19(Season16 oldSeason)
      : this(new Season17(oldSeason))
    {
    }

    public Season19(Season15 oldSeason)
      : this(new Season16(oldSeason))
    {
    }

    public Season19(Season14 oldSeason)
      : this(new Season15(oldSeason))
    {
    }

    public Season19(Season13 oldSeason)
      : this(new Season14(oldSeason))
    {
    }

    public Season19(Season12 oldSeason)
      : this(new Season13(oldSeason))
    {
    }

    public Season19(Season11 oldSeason)
      : this(new Season12(oldSeason))
    {
    }

    public Season19(Season10 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season9 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season8 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season7 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season6 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season5 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season4 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season3 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(Season2 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19(go.Season oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season19()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent19();
    }
  }
}
