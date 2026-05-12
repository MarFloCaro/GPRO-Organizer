 
// Type: go.Season5
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season5
  {
    public int season;
    public RaceEvent5[] events = new RaceEvent5[17];

    public Season5(Season4 oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent5(oldSeason.events[index]);
    }

    public Season5(Season3 oldSeason)
      : this(new Season4(oldSeason))
    {
    }

    public Season5(Season2 oldSeason)
      : this(new Season4(oldSeason))
    {
    }

    public Season5(Season oldSeason)
      : this(new Season4(oldSeason))
    {
    }

    public Season5()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent5();
    }
  }
}
