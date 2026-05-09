// Decompiled with JetBrains decompiler
// Type: go.RaceEvent11
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent11
  {
    public int trackid;
    public Practice3 practise = new Practice3();
    public Qualify qualify1 = new Qualify();
    public Qualify qualify2 = new Qualify();
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
    public bool isQualifing2Updated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;
    public bool isTestingUpdated;
    public bool isStaffUpdated;
    public bool isTechnicalDirectorUpdated;
    public bool isSummaryUpdated;

    public RaceEvent11()
    {
    }

    public RaceEvent11(RaceEvent10 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify1 = new Qualify(oldEvent.practise);
      this.qualify2 = new Qualify(oldEvent.qualify);
      this.strat = oldEvent.strat;
      this.race = oldEvent.race;
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.driver = oldEvent.driver;
      this.weather = oldEvent.weather;
      this.test = oldEvent.test;
      this.staff = oldEvent.staff;
      this.technicalDirector = oldEvent.technicalDirector;
      this.summary = oldEvent.summary;
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
    }

    public RaceEvent11(RaceEvent9 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent8 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent7 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent6 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent5 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent4 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent3 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent2 oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }

    public RaceEvent11(RaceEvent oldEvent)
      : this(new RaceEvent10(oldEvent))
    {
    }
  }
}
