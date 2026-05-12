 
// Type: go.Season20
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season20
  {
    private int season;
    private RaceEvent20[] events = new RaceEvent20[17];

    public int Season
    {
      get => this.season;
      set => this.season = value;
    }

    public RaceEvent20[] Events
    {
      get => this.events;
      set => this.events = value;
    }

    public Season20(Season19 oldSeason)
    {
      this.season = oldSeason.Season;
      this.events = new RaceEvent20[oldSeason.Events.Length];
      for (int index = 0; index < oldSeason.Events.Length; ++index)
        this.events[index] = new RaceEvent20(oldSeason.Events[index]);
    }

    public Season20(Season18 oldSeason)
      : this(new Season19(oldSeason))
    {
    }

    public Season20(Season17 oldSeason)
      : this(new Season18(oldSeason))
    {
    }

    public Season20(Season16 oldSeason)
      : this(new Season17(oldSeason))
    {
    }

    public Season20(Season15 oldSeason)
      : this(new Season16(oldSeason))
    {
    }

    public Season20(Season14 oldSeason)
      : this(new Season15(oldSeason))
    {
    }

    public Season20(Season13 oldSeason)
      : this(new Season14(oldSeason))
    {
    }

    public Season20(Season12 oldSeason)
      : this(new Season13(oldSeason))
    {
    }

    public Season20(Season11 oldSeason)
      : this(new Season12(oldSeason))
    {
    }

    public Season20(Season10 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season9 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season8 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season7 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season6 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season5 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season4 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season3 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(Season2 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20(go.Season oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season20()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent20();
    }
  }
}
