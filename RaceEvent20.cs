 
// Type: go.RaceEvent20
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent20
  {
    private int trackid;
    private Practice3 practise = new Practice3();
    private Qualify qualify1 = new Qualify();
    private Qualify qualify2 = new Qualify();
    private Strategy4 strat = new Strategy4();
    private Race9 race;
    private Car2 startcar = new Car2();
    private Car2 endcar = new Car2();
    private Driver5 driver = new Driver5();
    private RaceWeather weather = new RaceWeather();
    private Testing test = new Testing();
    private Staff staff = new Staff();
    private TechnicalDirector technicalDirector = new TechnicalDirector();
    private RaceSummary summary = new RaceSummary();
    private TyreSupplier tyresupplier = new TyreSupplier();
    private SponsorState sponsorState = new SponsorState();
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

    public int Trackid
    {
      get => this.trackid;
      set => this.trackid = value;
    }

    public Practice3 Practise
    {
      get => this.practise;
      set
      {
        this.practise = value;
        this.isPractiseUpdated = true;
      }
    }

    public Qualify Qualify1
    {
      get => this.qualify1;
      set
      {
        this.qualify1 = value;
        this.isQualifingUpdated = true;
      }
    }

    public Qualify Qualify2
    {
      get => this.qualify2;
      set
      {
        this.qualify2 = value;
        this.isQualifing2Updated = true;
      }
    }

    public Strategy4 Strat
    {
      get => this.strat;
      set
      {
        this.strat = value;
        this.isStrategyUpdated = true;
      }
    }

    public Race9 Race
    {
      get => this.race;
      set
      {
        this.race = value;
        this.isRaceUpdated = true;
      }
    }

    public Car2 Startcar
    {
      get => this.startcar;
      set => this.startcar = value;
    }

    public Car2 Endcar
    {
      get => this.endcar;
      set => this.endcar = value;
    }

    public Driver5 Driver
    {
      get => this.driver;
      set
      {
        this.driver = value;
        this.isDriverUpdated = true;
      }
    }

    public RaceWeather Weather
    {
      get => this.weather;
      set => this.weather = value;
    }

    public Testing Test
    {
      get => this.test;
      set
      {
        this.test = value;
        this.isTestingUpdated = true;
      }
    }

    public Staff Staff
    {
      get => this.staff;
      set
      {
        this.staff = value;
        this.isStaffUpdated = true;
      }
    }

    public TechnicalDirector TechnicalDirector
    {
      get => this.technicalDirector;
      set
      {
        this.technicalDirector = value;
        this.isTechnicalDirectorUpdated = true;
      }
    }

    public RaceSummary Summary
    {
      get => this.summary;
      set
      {
        this.summary = value;
        this.isSummaryUpdated = true;
      }
    }

    public TyreSupplier Tyresupplier
    {
      get => this.tyresupplier;
      set
      {
        this.tyresupplier = value;
        this.isTyreSupplierUpdated = true;
      }
    }

    public SponsorState SponsorState
    {
      get => this.sponsorState;
      set
      {
        this.sponsorState = value;
        this.isSponsorStateUpdated = true;
      }
    }

    public RaceEvent20()
    {
    }

    public RaceEvent20(RaceEvent19 oldEvent)
    {
      this.trackid = oldEvent.Trackid;
      this.practise = oldEvent.Practise;
      this.qualify1 = oldEvent.Qualify1;
      this.qualify2 = oldEvent.Qualify2;
      this.strat = oldEvent.Strat;
      this.race = new Race9(oldEvent.Race);
      this.startcar = oldEvent.Startcar;
      this.endcar = oldEvent.Endcar;
      this.driver = oldEvent.Driver;
      this.weather = oldEvent.Weather;
      this.test = oldEvent.Test;
      this.staff = oldEvent.Staff;
      this.TechnicalDirector = oldEvent.TechnicalDirector;
      this.summary = oldEvent.Summary;
      this.tyresupplier = oldEvent.Tyresupplier;
      this.sponsorState = oldEvent.SponsorState;
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

    public RaceEvent20(RaceEvent18 oldEvent)
      : this(new RaceEvent19(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent17 oldEvent)
      : this(new RaceEvent18(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent16 oldEvent)
      : this(new RaceEvent17(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent15 oldEvent)
      : this(new RaceEvent16(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent14 oldEvent)
      : this(new RaceEvent15(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent13 oldEvent)
      : this(new RaceEvent14(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent12 oldEvent)
      : this(new RaceEvent13(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent11 oldEvent)
      : this(new RaceEvent12(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent10 oldEvent)
      : this(new RaceEvent11(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent9 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent8 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent7 oldEvent)
      : this(new RaceEvent8(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent6 oldEvent)
      : this(new RaceEvent7(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent5 oldEvent)
      : this(new RaceEvent6(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent4 oldEvent)
      : this(new RaceEvent5(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent3 oldEvent)
      : this(new RaceEvent4(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent2 oldEvent)
      : this(new RaceEvent3(oldEvent))
    {
    }

    public RaceEvent20(RaceEvent oldEvent)
      : this(new RaceEvent2(oldEvent))
    {
    }
  }
}
