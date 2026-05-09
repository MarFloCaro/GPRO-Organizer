// Decompiled with JetBrains decompiler
// Type: go.Race6
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race6
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
    public FinancialAnalysis finances = new FinancialAnalysis();
    public DateTime realdate = DateTime.MinValue;

    public Race6(int laps) => this.laps = new Lap2[laps];

    public Race6(Race5 oldRace)
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
    }

    public Race6(Race4 oldRace)
      : this(new Race5(oldRace))
    {
    }

    public Race6(Race3 oldRace)
      : this(new Race5(oldRace))
    {
    }

    public Race6(Race2 oldRace)
      : this(new Race5(oldRace))
    {
    }

    public Race6(Race oldRace)
      : this(new Race5(oldRace))
    {
    }
  }
}
