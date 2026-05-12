 
// Type: go.Season4
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season4
  {
    public int season;
    public RaceEvent4[] events = new RaceEvent4[17];

    public Season4(Season3 oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent4(oldSeason.events[index]);
    }

    public Season4(Season2 oldSeason)
      : this(new Season3(oldSeason))
    {
    }

    public Season4(Season oldSeason)
      : this(new Season3(oldSeason))
    {
    }

    public Season4()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent4();
    }
  }
}
