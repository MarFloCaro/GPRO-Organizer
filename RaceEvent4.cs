 
// Type: go.RaceEvent4
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent4
  {
    public int trackid;
    public Practice practise = new Practice();
    public Practice qualify = new Practice();
    public Strategy strat = new Strategy();
    public Race3 race;
    public Car startcar = new Car();
    public Car endcar = new Car();
    public Driver2 driver = new Driver2();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;

    public RaceEvent4()
    {
    }

    public RaceEvent4(RaceEvent3 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify = oldEvent.qualify;
      this.strat = oldEvent.strat;
      this.race = oldEvent.race;
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.driver = new Driver2(oldEvent.driver);
      this.isPractiseUpdated = oldEvent.isPractiseUpdated;
      this.isDriverUpdated = oldEvent.isDriverUpdated;
      this.isQualifingUpdated = oldEvent.isQualifingUpdated;
      this.isStrategyUpdated = oldEvent.isStrategyUpdated;
      this.isRaceUpdated = oldEvent.isRaceUpdated;
      this.isCarUpdated = oldEvent.isCarUpdated;
    }

    public RaceEvent4(RaceEvent2 oldEvent)
    {
      RaceEvent4 raceEvent4 = new RaceEvent4(new RaceEvent3(oldEvent));
    }

    public RaceEvent4(RaceEvent oldEvent)
    {
      RaceEvent4 raceEvent4 = new RaceEvent4(new RaceEvent3(oldEvent));
    }
  }
}
