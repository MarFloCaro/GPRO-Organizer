// Decompiled with JetBrains decompiler
// Type: go.CalculatedFuelConsumption
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class CalculatedFuelConsumption
  {
    public int laps;
    public double km;
    public double fuelUsed;
    public double consumption;
    public int minTemp;
    public int maxTemp;
    public double avgTemp;
    public int minHum;
    public int maxHum;
    public double avgHum;
    public string weather = "";

    public CalculatedFuelConsumption(
      int laps,
      double km,
      double fuelUsed,
      double consumption,
      int minTemp,
      int maxTemp,
      double avgTemp,
      int minHum,
      int maxHum,
      double avgHum,
      string weather)
    {
      this.laps = laps;
      this.km = km;
      this.fuelUsed = fuelUsed;
      this.consumption = consumption;
      this.minTemp = minTemp;
      this.maxTemp = maxTemp;
      this.avgTemp = avgTemp;
      this.minHum = minHum;
      this.maxHum = maxHum;
      this.avgHum = avgHum;
      this.weather = weather;
    }
  }
}
