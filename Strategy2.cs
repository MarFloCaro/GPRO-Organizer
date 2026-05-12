 
// Type: go.Strategy2
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Strategy2
  {
    public bool isStrategyUpdated;
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

    public Strategy2()
    {
    }

    public Strategy2(Strategy oldStrat)
    {
      this.startFuel = oldStrat.startFuel;
      this.stop1Fuel = oldStrat.stop1Fuel;
      this.stop2Fuel = oldStrat.stop2Fuel;
      this.stop3Fuel = oldStrat.stop3Fuel;
      this.stop4Fuel = oldStrat.stop4Fuel;
      this.stop5Fuel = oldStrat.stop5Fuel;
      this.setup = oldStrat.setup;
      this.startTyres = oldStrat.startTyres;
      this.rainTyres = oldStrat.rainTyres;
      this.dryTyres = oldStrat.dryTyres;
      this.pitAfterRain = oldStrat.pitAfterRain;
      this.pitAfterDry = oldStrat.pitAfterDry;
      this.riskOvertake = oldStrat.riskOvertake;
      this.riskDefend = oldStrat.riskDefend;
      this.riskClear = oldStrat.riskClear;
      this.riskMalfunction = oldStrat.riskMalfunction;
      this.pitIfSolvableProblem = oldStrat.pitIfSolvableProblem;
      this.pitLapLimit = oldStrat.pitLapLimit;
      this.dontrefuelOnTechnicalProblems = oldStrat.dontrefuelOnTechnicalProblems;
      this.startStrategy = oldStrat.startStrategy;
    }
  }
}
