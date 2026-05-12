 
// Type: go.RaceEvent7
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent7
  {
    public int trackid;
    public Practice3 practise = new Practice3();
    public Practice3 qualify = new Practice3();
    public Strategy2 strat = new Strategy2();
    public Race5 race;
    public Car2 startcar = new Car2();
    public Car2 endcar = new Car2();
    public Driver2 driver = new Driver2();
    public RaceWeather weather = new RaceWeather();
    public Testing test = new Testing();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;
    public bool isTestingUpdated;

    public RaceEvent7()
    {
    }

    public RaceEvent7(RaceEvent6 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = new Practice3(oldEvent.practise);
      this.qualify = new Practice3(oldEvent.qualify);
      this.strat = oldEvent.strat;
      this.race = new Race5(oldEvent.race);
      this.startcar = new Car2(oldEvent.startcar);
      this.endcar = new Car2(oldEvent.endcar);
      this.driver = oldEvent.driver;
      this.weather = oldEvent.weather;
      this.isPractiseUpdated = oldEvent.isPractiseUpdated;
      this.isDriverUpdated = oldEvent.isDriverUpdated;
      this.isQualifingUpdated = oldEvent.isQualifingUpdated;
      this.isStrategyUpdated = oldEvent.isStrategyUpdated;
      this.isRaceUpdated = oldEvent.isRaceUpdated;
      this.isCarUpdated = oldEvent.isCarUpdated;
    }

    public RaceEvent7(RaceEvent5 oldEvent)
      : this(new RaceEvent6(oldEvent))
    {
    }

    public RaceEvent7(RaceEvent4 oldEvent)
      : this(new RaceEvent6(oldEvent))
    {
    }

    public RaceEvent7(RaceEvent3 oldEvent)
      : this(new RaceEvent6(oldEvent))
    {
    }

    public RaceEvent7(RaceEvent2 oldEvent)
      : this(new RaceEvent6(oldEvent))
    {
    }

    public RaceEvent7(RaceEvent oldEvent)
      : this(new RaceEvent6(oldEvent))
    {
    }
  }
}
