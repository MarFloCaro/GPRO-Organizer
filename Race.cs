 
// Type: go.Race
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race
  {
    public int track;
    public Date date = new Date();
    public Car car = new Car();
    public CarSetup carSetup = new CarSetup();
    public Lap[] laps;
    public int startFuel;
    public PitStop[] pitStops;
    public int tyresAfterFinish;
    public int endFuel;

    public Race(int laps) => this.laps = new Lap[laps];
  }
}
