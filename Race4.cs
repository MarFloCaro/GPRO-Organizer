// Decompiled with JetBrains decompiler
// Type: go.Race4
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race4
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
    public CalculatedTyreWear[] calcTyres;
    public CalculatedFuelConsumption[] calcFuel;

    public Race4(int laps) => this.laps = new Lap2[laps];

    public Race4(Race3 oldRace)
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

    public Race4(Race2 oldRace)
      : this(new Race3(oldRace))
    {
    }

    public Race4(Race oldRace)
      : this(new Race3(oldRace))
    {
    }
  }
}
