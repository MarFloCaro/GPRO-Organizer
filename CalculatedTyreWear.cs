// Decompiled with JetBrains decompiler
// Type: go.CalculatedTyreWear
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class CalculatedTyreWear
  {
    public TyreType tyres;
    public int laps;
    public double km;
    public int finalPercentage;
    public bool badTyres;
    public double badAtKm;
    public double badAtPercent;
    public double estimatedDuration;
    public int minTemp;
    public int maxTemp;
    public double avgTemp;
    public int minHum;
    public int maxHum;
    public double avgHum;
    public string weather = "";

    public CalculatedTyreWear(
      TyreType tyres,
      int laps,
      double km,
      int finalPercentage,
      bool badTyres,
      double badAtKm,
      double badAtPercent,
      double estimatedDuration,
      int minTemp,
      int maxTemp,
      double avgTemp,
      int minHum,
      int maxHum,
      double avgHum,
      string weather)
    {
      this.tyres = tyres;
      this.laps = laps;
      this.km = km;
      this.finalPercentage = finalPercentage;
      this.badTyres = badTyres;
      this.badAtKm = badTyres ? badAtKm : -1.0;
      this.badAtPercent = badTyres ? badAtPercent : -1.0;
      this.estimatedDuration = estimatedDuration;
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
