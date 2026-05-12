 
// Type: go.Season8
 
 
 

using System;
using System.Collections;

#nullable disable
namespace go
{
  [Serializable]
  public class Season8
  {
    public int season;
    public RaceEvent7[] events = new RaceEvent7[17];
    public ArrayList financeHistory = new ArrayList();

    public Season8(Season7 oldSeason)
    {
      this.season = oldSeason.season;
      this.events = oldSeason.events;
    }

    public Season8(Season6 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season5 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season4 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season3 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season2 oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8(Season oldSeason)
      : this(new Season7(oldSeason))
    {
    }

    public Season8()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent7();
    }
  }
}
