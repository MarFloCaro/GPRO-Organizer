// Decompiled with JetBrains decompiler
// Type: go.RaceEvent5
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent5
  {
    public int trackid;
    public Practice practise = new Practice();
    public Practice qualify = new Practice();
    public Strategy strat = new Strategy();
    public Race4 race;
    public Car startcar = new Car();
    public Car endcar = new Car();
    public Driver2 driver = new Driver2();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;

    public RaceEvent5()
    {
    }

    public RaceEvent5(RaceEvent4 oldEvent)
    {
      this.trackid = oldEvent.trackid;
      this.practise = oldEvent.practise;
      this.qualify = oldEvent.qualify;
      this.strat = oldEvent.strat;
      this.race = new Race4(oldEvent.race);
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

    public RaceEvent5(RaceEvent3 oldEvent)
      : this(new RaceEvent4(oldEvent))
    {
    }

    public RaceEvent5(RaceEvent2 oldEvent)
      : this(new RaceEvent4(oldEvent))
    {
    }

    public RaceEvent5(RaceEvent oldEvent)
      : this(new RaceEvent4(oldEvent))
    {
    }
  }
}
