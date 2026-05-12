 
// Type: go.Race5
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race5
  {
    public int track;
    public Date date = new Date();
    public Car2 car = new Car2();
    public CarSetup carSetup = new CarSetup();
    public Lap2[] laps;
    public int startFuel;
    public PitStop[] pitStops;
    public int tyresAfterFinish;
    public int endFuel;
    public bool DidFinishRace = true;
    public TechnicalProblem[] technicalProblems;
    public CalculatedTyreWear[] calcTyres;
    public CalculatedFuelConsumption[] calcFuel;

    public Race5(int laps) => this.laps = new Lap2[laps];

    public Race5(Race4 oldRace)
    {
      if (oldRace == null)
        return;
      this.track = oldRace.track;
      this.date = oldRace.date;
      this.carSetup = oldRace.carSetup;
      this.laps = oldRace.laps;
      this.startFuel = oldRace.startFuel;
      this.pitStops = oldRace.pitStops;
      this.tyresAfterFinish = oldRace.tyresAfterFinish;
      this.DidFinishRace = oldRace.DidFinishRace;
      this.technicalProblems = oldRace.technicalProblems;
      this.endFuel = oldRace.endFuel;
      this.calcTyres = oldRace.calcTyres;
      this.calcFuel = oldRace.calcFuel;
      this.car = new Car2(oldRace.car);
    }

    public Race5(Race3 oldRace)
      : this(new Race4(oldRace))
    {
    }

    public Race5(Race2 oldRace)
      : this(new Race4(oldRace))
    {
    }

    public Race5(Race oldRace)
      : this(new Race4(oldRace))
    {
    }
  }
}
