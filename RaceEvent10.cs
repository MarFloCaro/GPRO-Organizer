 
// Type: go.RaceEvent10
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent10
  {
    public int trackid;
    public Practice3 practise = new Practice3();
    public Practice3 qualify = new Practice3();
    public Strategy2 strat = new Strategy2();
    public Race6 race;
    public Car2 startcar = new Car2();
    public Car2 endcar = new Car2();
    public Driver3 driver = new Driver3();
    public RaceWeather weather = new RaceWeather();
    public Testing test = new Testing();
    public Staff staff = new Staff();
    public TechnicalDirector technicalDirector = new TechnicalDirector();
    public RaceSummary summary = new RaceSummary();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;
    public bool isTestingUpdated;
    public bool isStaffUpdated;
    public bool isTechnicalDirectorUpdated;
    public bool isSummaryUpdated;

    public RaceEvent10()
    {
    }

    public RaceEvent10(RaceEvent9 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify = oldEvent.qualify;
      this.strat = oldEvent.strat;
      this.race = oldEvent.race;
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.driver = new Driver3(oldEvent.driver);
      this.weather = oldEvent.weather;
      this.test = oldEvent.test;
      this.staff = oldEvent.staff;
      this.technicalDirector = oldEvent.technicalDirector;
      this.summary = oldEvent.summary;
      this.isPractiseUpdated = oldEvent.isPractiseUpdated;
      this.isDriverUpdated = oldEvent.isDriverUpdated;
      this.isQualifingUpdated = oldEvent.isQualifingUpdated;
      this.isStrategyUpdated = oldEvent.isStrategyUpdated;
      this.isRaceUpdated = oldEvent.isRaceUpdated;
      this.isCarUpdated = oldEvent.isCarUpdated;
      this.isTestingUpdated = oldEvent.isTestingUpdated;
      this.isStaffUpdated = oldEvent.isStaffUpdated;
      this.isTechnicalDirectorUpdated = oldEvent.isTechnicalDirectorUpdated;
      this.isSummaryUpdated = oldEvent.isSummaryUpdated;
    }

    public RaceEvent10(RaceEvent8 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent10(RaceEvent7 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent10(RaceEvent6 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent10(RaceEvent5 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent10(RaceEvent4 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent10(RaceEvent3 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent10(RaceEvent2 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent10(RaceEvent oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }
  }
}
