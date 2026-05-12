 
// Type: go.RaceEvent17
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent17
  {
    public int trackid;
    public Practice3 practise = new Practice3();
    public Qualify qualify1 = new Qualify();
    public Qualify qualify2 = new Qualify();
    public Strategy4 strat = new Strategy4();
    public Race7 race;
    public Car2 startcar = new Car2();
    public Car2 endcar = new Car2();
    public Driver4 driver = new Driver4();
    public RaceWeather weather = new RaceWeather();
    public Testing test = new Testing();
    public Staff staff = new Staff();
    public TechnicalDirector technicalDirector = new TechnicalDirector();
    public RaceSummary summary = new RaceSummary();
    public TyreSupplier tyresupplier = new TyreSupplier();
    public SponsorState sponsorState = new SponsorState();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isQualifing2Updated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;
    public bool isTestingUpdated;
    public bool isStaffUpdated;
    public bool isTechnicalDirectorUpdated;
    public bool isSummaryUpdated;
    public bool isTyreSupplierUpdated;
    public bool isSponsorStateUpdated;

    public RaceEvent17()
    {
    }

    public RaceEvent17(RaceEvent16 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify1 = oldEvent.qualify1;
      this.qualify2 = oldEvent.qualify2;
      this.strat = new Strategy4(oldEvent.strat);
      this.race = oldEvent.race;
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.driver = oldEvent.driver;
      this.weather = oldEvent.weather;
      this.test = oldEvent.test;
      this.staff = oldEvent.staff;
      this.technicalDirector = oldEvent.technicalDirector;
      this.summary = oldEvent.summary;
      this.tyresupplier = oldEvent.tyresupplier;
      this.sponsorState = oldEvent.sponsorState;
      this.isSponsorStateUpdated = oldEvent.isSponsorStateUpdated;
      this.isPractiseUpdated = oldEvent.isPractiseUpdated;
      this.isDriverUpdated = oldEvent.isDriverUpdated;
      this.isQualifingUpdated = oldEvent.isQualifingUpdated;
      this.isQualifing2Updated = oldEvent.isQualifingUpdated;
      this.isStrategyUpdated = oldEvent.isStrategyUpdated;
      this.isRaceUpdated = oldEvent.isRaceUpdated;
      this.isCarUpdated = oldEvent.isCarUpdated;
      this.isTestingUpdated = oldEvent.isTestingUpdated;
      this.isStaffUpdated = oldEvent.isStaffUpdated;
      this.isTechnicalDirectorUpdated = oldEvent.isTechnicalDirectorUpdated;
      this.isSummaryUpdated = oldEvent.isSummaryUpdated;
      this.isTyreSupplierUpdated = oldEvent.isTyreSupplierUpdated;
    }

    public RaceEvent17(RaceEvent15 oldEvent)
      : this(new RaceEvent16(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent14 oldEvent)
      : this(new RaceEvent15(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent13 oldEvent)
      : this(new RaceEvent14(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent12 oldEvent)
      : this(new RaceEvent13(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent11 oldEvent)
      : this(new RaceEvent12(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent10 oldEvent)
      : this(new RaceEvent11(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent9 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent8 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent7 oldEvent)
      : this(new RaceEvent8(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent6 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent5 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent4 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent3 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent2 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent17(RaceEvent oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }
  }
}
