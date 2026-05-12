 
// Type: go.Race3
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race3
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
    public bool DidFinishRace = true;
    public TechnicalProblem[] technicalProblems;

    public Race3(int laps) => this.laps = new Lap2[laps];

    public Race3(Race2 oldRace)
    {
      if (oldRace == null)
        return;
      this.track = oldRace.track;
      this.date = oldRace.date;
      this.car = oldRace.car;
      this.carSetup = oldRace.carSetup;
      this.laps = oldRace.laps;
      this.startFuel = oldRace.startFuel;
      this.pitStops = oldRace.pitStops;
      this.tyresAfterFinish = oldRace.tyresAfterFinish;
      this.endFuel = oldRace.endFuel;
    }

    public Race3(Race oldRace)
      : this(new Race2(oldRace))
    {
    }
  }
}
