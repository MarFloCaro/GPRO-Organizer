 
// Type: go.RaceEvent6
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent6
  {
    public int trackid;
    public Practice2 practise = new Practice2();
    public Practice2 qualify = new Practice2();
    public Strategy2 strat = new Strategy2();
    public Race4 race;
    public Car startcar = new Car();
    public Car endcar = new Car();
    public Driver2 driver = new Driver2();
    public RaceWeather weather = new RaceWeather();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;

    public RaceEvent6()
    {
    }

    public RaceEvent6(RaceEvent5 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = new Practice2(oldEvent.practise);
      this.qualify = new Practice2(oldEvent.qualify);
      this.strat = new Strategy2(oldEvent.strat);
      this.race = oldEvent.race;
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.driver = oldEvent.driver;
      this.isPractiseUpdated = oldEvent.isPractiseUpdated;
      this.isDriverUpdated = oldEvent.isDriverUpdated;
      this.isQualifingUpdated = oldEvent.isQualifingUpdated;
      this.isStrategyUpdated = oldEvent.isStrategyUpdated;
      this.isRaceUpdated = oldEvent.isRaceUpdated;
      this.isCarUpdated = oldEvent.isCarUpdated;
    }

    public RaceEvent6(RaceEvent4 oldEvent)
      : this(new RaceEvent5(oldEvent))
    {
    }

    public RaceEvent6(RaceEvent3 oldEvent)
      : this(new RaceEvent5(oldEvent))
    {
    }

    public RaceEvent6(RaceEvent2 oldEvent)
      : this(new RaceEvent5(oldEvent))
    {
    }

    public RaceEvent6(RaceEvent oldEvent)
      : this(new RaceEvent5(oldEvent))
    {
    }
  }
}
