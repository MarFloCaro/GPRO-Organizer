 
// Type: go.Race7
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race7
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
    public FinancialAnalysis2 finances = new FinancialAnalysis2();
    public DateTime realdate = DateTime.MinValue;

    public Race7(int laps) => this.laps = new Lap2[laps];

    public Race7(Race6 oldRace)
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
      this.car = oldRace.car;
      this.realdate = oldRace.realdate;
      this.finances = new FinancialAnalysis2(oldRace.finances);
    }

    public Race7(Race5 oldRace)
      : this(new Race6(oldRace))
    {
    }

    public Race7(Race4 oldRace)
      : this(new Race6(oldRace))
    {
    }

    public Race7(Race3 oldRace)
      : this(new Race6(oldRace))
    {
    }

    public Race7(Race2 oldRace)
      : this(new Race6(oldRace))
    {
    }

    public Race7(Race oldRace)
      : this(new Race6(oldRace))
    {
    }
  }
}
