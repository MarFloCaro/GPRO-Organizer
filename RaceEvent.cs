 
// Type: go.RaceEvent
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceEvent
  {
    public int trackid;
    public Practice practise = new Practice();
    public Practice qualify = new Practice();
    public Strategy strat = new Strategy();
    public Race race;
    public Car startcar = new Car();
    public Car endcar = new Car();
    public bool isPractiseUpdated;
    public bool isDriverUpdated;
    public bool isQualifingUpdated;
    public bool isStrategyUpdated;
    public bool isRaceUpdated;
    public bool isCarUpdated;
  }
}
