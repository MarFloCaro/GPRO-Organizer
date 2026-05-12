 
// Type: go.Season6
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season6
  {
    public int season;
    public RaceEvent6[] events = new RaceEvent6[17];

    public Season6(Season5 oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent6(oldSeason.events[index]);
    }

    public Season6(Season4 oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6(Season3 oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6(Season2 oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6(Season oldSeason)
      : this(new Season5(oldSeason))
    {
    }

    public Season6()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent6();
    }
  }
}
