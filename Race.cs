// Decompiled with JetBrains decompiler
// Type: go.Race
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
