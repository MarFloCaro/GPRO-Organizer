 
// Type: go.Season7
 
 
 

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
