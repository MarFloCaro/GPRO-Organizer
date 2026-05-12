 
// Type: go.Season2
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season2
  {
    public int season;
    public RaceEvent2[] events = new RaceEvent2[17];

    public Season2(Season oldSeason)
    {
      this.season = oldSeason.season;
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent2(oldSeason.events[index]);
    }

    public Season2()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent2();
    }
  }
}
