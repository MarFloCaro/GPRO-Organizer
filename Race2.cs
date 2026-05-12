 
// Type: go.Race2
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race2
  {
    public int track;
    public Date date = new Date();
    public Car car = new Car();
    public CarSetup carSetup = new CarSetup();
    public Lap2[] laps;
    public int startFuel;
    public PitStop[] pitStops;
    public int tyresAfterFinish;
    public int endFuel;

    public Race2(int laps) => this.laps = new Lap2[laps];

    public Race2(Race oldRace)
    {
      if (oldRace == null)
        return;
      this.track = oldRace.track;
      this.date = oldRace.date;
      this.car = oldRace.car;
      this.carSetup = oldRace.carSetup;
      this.laps = new Lap2[oldRace.laps.Length];
      for (int index = 0; index < this.laps.Length; ++index)
        this.laps[index] = new Lap2(oldRace.laps[index]);
      this.startFuel = oldRace.startFuel;
      this.pitStops = oldRace.pitStops;
      this.tyresAfterFinish = oldRace.tyresAfterFinish;
      this.endFuel = oldRace.endFuel;
    }
  }
}
