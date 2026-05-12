 
// Type: go.Season
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Season
  {
    public int season;
    public RaceEvent[] events = new RaceEvent[17];

    public Season()
    {
      for (int index = 0; index < this.events.Length; ++index)
        this.events[index] = new RaceEvent();
    }
  }
}
