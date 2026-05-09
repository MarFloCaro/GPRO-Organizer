// Decompiled with JetBrains decompiler
// Type: go.Strategy
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Strategy
  {
    public int startFuel;
    public int stop1Fuel;
    public int stop2Fuel;
    public int stop3Fuel;
    public int stop4Fuel;
    public int stop5Fuel;
    public CarSetup setup = new CarSetup();
    public TyreType startTyres;
    public TyreType rainTyres;
    public TyreType dryTyres;
    public int pitAfterRain;
    public int pitAfterDry;
    public int riskOvertake;
    public int riskDefend;
    public int riskClear;
    public int riskMalfunction;
    public bool pitIfSolvableProblem = true;
    public int pitLapLimit;
    public bool dontrefuelOnTechnicalProblems;
    public RaceStartStrategy startStrategy;
  }
}
