 
// Type: go.RaceEvent3
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent3
  {
    public int trackid;
    public Practice practise = new Practice();
    public Practice qualify = new Practice();
    public Strategy strat = new Strategy();
    public Race3 race;
    public Car startcar = new Car();
    public Car endcar = new Car();
    public Driver driver = new Driver();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;

    public RaceEvent3()
    {
    }

    public RaceEvent3(RaceEvent2 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify = oldEvent.qualify;
      this.strat = oldEvent.strat;
      this.race = new Race3(oldEvent.race);
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.isPractiseUpdated = oldEvent.isPractiseUpdated;
      this.isDriverUpdated = oldEvent.isDriverUpdated;
      this.isQualifingUpdated = oldEvent.isQualifingUpdated;
      this.isStrategyUpdated = oldEvent.isStrategyUpdated;
      this.isRaceUpdated = oldEvent.isRaceUpdated;
      this.isCarUpdated = oldEvent.isCarUpdated;
    }

    public RaceEvent3(RaceEvent oldEvent)
    {
      RaceEvent3 raceEvent3 = new RaceEvent3(new RaceEvent2(oldEvent));
    }
  }
}
