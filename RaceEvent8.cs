// Decompiled with JetBrains decompiler
// Type: go.RaceEvent8
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent8
  {
    public int trackid;
    public Practice3 practise = new Practice3();
    public Practice3 qualify = new Practice3();
    public Strategy2 strat = new Strategy2();
    public Race6 race;
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

    public RaceEvent8()
    {
    }

    public RaceEvent8(RaceEvent7 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify = oldEvent.qualify;
      this.strat = oldEvent.strat;
      this.race = new Race6(oldEvent.race);
      this.startcar = oldEvent.startcar;
      this.endcar = oldEvent.endcar;
      this.driver = oldEvent.driver;
      this.weather = oldEvent.weather;
      this.test = oldEvent.test;
      this.isPractiseUpdated = oldEvent.isPractiseUpdated;
      this.isDriverUpdated = oldEvent.isDriverUpdated;
      this.isQualifingUpdated = oldEvent.isQualifingUpdated;
      this.isStrategyUpdated = oldEvent.isStrategyUpdated;
      this.isRaceUpdated = oldEvent.isRaceUpdated;
      this.isCarUpdated = oldEvent.isCarUpdated;
      this.isTestingUpdated = oldEvent.isTestingUpdated;
    }

    public RaceEvent8(RaceEvent6 oldEvent)
      : this(new RaceEvent7(oldEvent))
    {
    }

    public RaceEvent8(RaceEvent5 oldEvent)
      : this(new RaceEvent7(oldEvent))
    {
    }

    public RaceEvent8(RaceEvent4 oldEvent)
      : this(new RaceEvent7(oldEvent))
    {
    }

    public RaceEvent8(RaceEvent3 oldEvent)
      : this(new RaceEvent7(oldEvent))
    {
    }

    public RaceEvent8(RaceEvent2 oldEvent)
      : this(new RaceEvent7(oldEvent))
    {
    }

    public RaceEvent8(RaceEvent oldEvent)
      : this(new RaceEvent7(oldEvent))
    {
    }
  }
}
