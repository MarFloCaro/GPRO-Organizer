// Decompiled with JetBrains decompiler
// Type: go.RaceEvent19
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent19
  {
    private int trackid;
    private Practice3 practise = new Practice3();
    private Qualify qualify1 = new Qualify();
    private Qualify qualify2 = new Qualify();
    private Strategy4 strat = new Strategy4();
    private Race8 race;
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

    public Race8 Race
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

    public RaceEvent19()
    {
    }

    public RaceEvent19(RaceEvent18 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify1 = oldEvent.qualify1;
      this.qualify2 = oldEvent.qualify2;
      this.strat = oldEvent.strat;
      this.race = new Race8(oldEvent.race);
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.driver = oldEvent.driver;
      this.weather = oldEvent.weather;
      this.test = oldEvent.test;
      this.staff = oldEvent.staff;
      this.TechnicalDirector = oldEvent.technicalDirector;
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

    public RaceEvent19(RaceEvent17 oldEvent)
      : this(new RaceEvent18(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent16 oldEvent)
      : this(new RaceEvent17(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent15 oldEvent)
      : this(new RaceEvent16(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent14 oldEvent)
      : this(new RaceEvent15(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent13 oldEvent)
      : this(new RaceEvent14(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent12 oldEvent)
      : this(new RaceEvent13(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent11 oldEvent)
      : this(new RaceEvent12(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent10 oldEvent)
      : this(new RaceEvent11(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent9 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent8 oldEvent)
      : this(new RaceEvent9(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent7 oldEvent)
      : this(new RaceEvent8(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent6 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent5 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent4 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent3 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent2 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent19(RaceEvent oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }
  }
}
