 
// Type: go.Season16
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season16
  {
    public int season;
    public RaceEvent15[] events = new RaceEvent15[17];

    public Season16(Season15 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = new RaceEvent15[oldSeason.events.Length];
      for (int index = 0; index < oldSeason.events.Length; ++index)
        this.events[index] = new RaceEvent15(oldSeason.events[index]);
    }

    public Season16(Season14 oldSeason)
      : this(new Season15(oldSeason))
    {
    }

    public Season16(Season13 oldSeason)
      : this(new Season14(oldSeason))
    {
    }

    public Season16(Season12 oldSeason)
      : this(new Season13(oldSeason))
    {
    }

    public Season16(Season11 oldSeason)
      : this(new Season12(oldSeason))
    {
    }

    public Season16(Season10 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season9 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season8 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season7 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season6 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season5 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season4 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season3 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season2 oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16(Season oldSeason)
      : this(new Season11(oldSeason))
    {
    }

    public Season16()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent15();
    }
  }
}
