// Decompiled with JetBrains decompiler
// Type: go.Race2
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
