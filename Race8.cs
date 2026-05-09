// Decompiled with JetBrains decompiler
// Type: go.Race8
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Race8
  {
    private int track;
    private Date date = new Date();
    private Car2 car = new Car2();
    private CarSetup carSetup = new CarSetup();
    private Lap2[] laps;
    private int startFuel;
    private PitStop[] pitStops;
    private int tyresAfterFinish;
    private int endFuel;
    private bool didFinishRace = true;
    private TechnicalProblem[] technicalProblems;
    private CalculatedTyreWear[] calcTyres;
    private CalculatedFuelConsumption[] calcFuel;
    private FinancialAnalysis2 finances = new FinancialAnalysis2();
    private DateTime realdate = DateTime.MinValue;
    private int driverEnergyBefore;
    private int driverEnergyAfter;

    public int Track
    {
      get => this.track;
      set => this.track = value;
    }

    public Date Date
    {
      get => this.date;
      set => this.date = value;
    }

    public Car2 Car
    {
      get => this.car;
      set => this.car = value;
    }

    public CarSetup CarSetup
    {
      get => this.carSetup;
      set => this.carSetup = value;
    }

    public Lap2[] Laps
    {
      get => this.laps;
      set => this.laps = value;
    }

    public int StartFuel
    {
      get => this.startFuel;
      set => this.startFuel = value;
    }

    public PitStop[] PitStops
    {
      get => this.pitStops;
      set => this.pitStops = value;
    }

    public int TyresAfterFinish
    {
      get => this.tyresAfterFinish;
      set => this.tyresAfterFinish = value;
    }

    public int EndFuel
    {
      get => this.endFuel;
      set => this.endFuel = value;
    }

    public bool DidFinishRace
    {
      get => this.didFinishRace;
      set => this.didFinishRace = value;
    }

    public TechnicalProblem[] TechnicalProblems
    {
      get => this.technicalProblems;
      set => this.technicalProblems = value;
    }

    public CalculatedTyreWear[] CalcTyres
    {
      get => this.calcTyres;
      set => this.calcTyres = value;
    }

    public CalculatedFuelConsumption[] CalcFuel
    {
      get => this.calcFuel;
      set => this.calcFuel = value;
    }

    public FinancialAnalysis2 Finances
    {
      get => this.finances;
      set => this.finances = value;
    }

    public DateTime Realdate
    {
      get => this.realdate;
      set => this.realdate = value;
    }

    public int DriverEnergyBefore
    {
      get => this.driverEnergyBefore;
      set => this.driverEnergyBefore = value;
    }

    public int DriverEnergyAfter
    {
      get => this.driverEnergyAfter;
      set => this.driverEnergyAfter = value;
    }

    public Race8(int laps) => this.laps = new Lap2[laps];

    public Race8(Race7 oldRace)
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
      this.finances = oldRace.finances;
      this.driverEnergyAfter = 0;
      this.driverEnergyBefore = 0;
    }

    public Race8(Race6 oldRace)
      : this(new Race7(oldRace))
    {
    }

    public Race8(Race5 oldRace)
      : this(new Race6(oldRace))
    {
    }

    public Race8(Race4 oldRace)
      : this(new Race5(oldRace))
    {
    }

    public Race8(Race3 oldRace)
      : this(new Race4(oldRace))
    {
    }

    public Race8(Race2 oldRace)
      : this(new Race3(oldRace))
    {
    }

    public Race8(Race oldRace)
      : this(new Race2(oldRace))
    {
    }

    public void CalculateWear(go.Track track)
    {
      if (this.pitStops == null && !this.DidFinishRace)
        return;
      int length1 = this.pitStops != null ? this.pitStops.Length : 0;
      int num1 = length1 + (this.DidFinishRace ? 1 : 0);
      int length2 = num1 == 0 ? 1 : num1;
      this.calcTyres = new CalculatedTyreWear[length2];
      this.calcFuel = new CalculatedFuelConsumption[length2 + 1];
      int[] numArray1 = new int[length2];
      int[] numArray2 = new int[length2];
      int[] numArray3 = new int[length2];
      int[] numArray4 = new int[length2];
      int[] numArray5 = new int[length2];
      TyreType[] tyreTypeArray = new TyreType[length2];
      double[] numArray6 = new double[length2];
      double[] numArray7 = new double[length2];
      string[] strArray = new string[length2];
      int num2 = this.laps.Length - 1;
      for (int index = 0; index < length2; ++index)
      {
        numArray1[index] = 100;
        numArray2[index] = 0;
        numArray3[index] = 100;
        numArray4[index] = 0;
        strArray[index] = "";
        numArray5[index] = 200;
        numArray7[index] = 0.0;
        numArray6[index] = 0.0;
      }
      int index1 = 0;
      for (int index2 = 1; index2 < this.laps.Length; ++index2)
      {
        Lap2 lap = this.laps[index2];
        numArray6[index1] += (double) lap.weather.temperature;
        numArray7[index1] += (double) lap.weather.humidity;
        if (lap.weather.temperature < numArray1[index1])
          numArray1[index1] = lap.weather.temperature;
        if (lap.weather.temperature > numArray2[index1])
          numArray2[index1] = lap.weather.temperature;
        if (lap.weather.humidity < numArray3[index1])
          numArray3[index1] = lap.weather.humidity;
        if (lap.weather.humidity > numArray4[index1])
          numArray4[index1] = lap.weather.humidity;
        if (strArray[index1].Equals(""))
          strArray[index1] = lap.weather.skies != Skies.Rain ? "Dry" : "Wet";
        else if (strArray[index1].Equals("Dry") && lap.weather.skies == Skies.Rain)
          strArray[index1] = "Dry*";
        else if (strArray[index1].Equals("Wet") && lap.weather.skies != Skies.Rain)
          strArray[index1] = "Wet*";
        else if (strArray[index1].Equals("Dry*") && lap.weather.skies == Skies.Rain)
          strArray[index1] = "Mixed";
        else if (strArray[index1].Equals("Wet*") && lap.weather.skies != Skies.Rain)
          strArray[index1] = "Mixed";
        if (lap.events != null && index2 < num2 && (lap.events.IndexOf("puncture") > 0 || lap.events.IndexOf("Dropped") > 0))
          num2 = index2;
        if (!lap.goodTyres && index2 < numArray5[index1])
          numArray5[index1] = index2 - 1;
        tyreTypeArray[index1] = lap.tyres;
        if (index1 < length1 && index2 == this.pitStops[index1].lap)
        {
          ++index1;
          if (index1 == length2)
            break;
        }
      }
      double fuelUsed1 = 0.0;
      int num3 = 0;
      double num4 = (double) this.startFuel;
      double km1 = 0.0;
      int laps1 = 0;
      int index3 = 0;
      bool flag = false;
      for (; index3 < length1; ++index3)
      {
        int laps2 = this.pitStops[index3].lap - num3;
        laps1 += laps2;
        double km2 = track.lapDistance * (double) laps2;
        km1 += km2;
        double fuelUsed2 = num4 - (double) (180 * this.pitStops[index3].fuelLeft) / 100.0;
        num4 = this.pitStops[index3].refilledTo <= 0 ? (double) (180 * this.pitStops[index3].fuelLeft) / 100.0 : (double) this.pitStops[index3].refilledTo;
        fuelUsed1 += fuelUsed2;
        double consumption = km2 / fuelUsed2;
        this.calcFuel[index3] = new CalculatedFuelConsumption(laps2, km2, fuelUsed2, consumption, numArray1[index3], numArray2[index3], numArray6[index3] / (double) laps2, numArray3[index3], numArray4[index3], numArray7[index3] / (double) laps2, strArray[index3]);
        double estimatedDuration = 100.0 * km2 / (double) (100 - this.pitStops[index3].tyresCondition);
        flag = numArray5[index3] < 200;
        double badAtKm = (double) (numArray5[index3] - num3) * track.lapDistance;
        double badAtPercent = 100.0 - 100.0 * badAtKm / estimatedDuration;
        this.calcTyres[index3] = new CalculatedTyreWear(tyreTypeArray[index3], laps2, km2, this.pitStops[index3].tyresCondition, numArray5[index3] < 200, badAtKm, badAtPercent, estimatedDuration, numArray1[index3], numArray2[index3], numArray6[index3] / (double) laps2, numArray3[index3], numArray4[index3], numArray7[index3] / (double) laps2, strArray[index3]);
        num3 = this.pitStops[index3].lap;
      }
      if (this.DidFinishRace)
      {
        int laps3 = num2 - num3;
        laps1 += laps3;
        double km3 = track.lapDistance * (double) laps3;
        km1 += km3;
        double fuelUsed3 = num4 - (double) this.endFuel;
        fuelUsed1 += fuelUsed3;
        double consumption = km3 / fuelUsed3;
        this.calcFuel[index3] = new CalculatedFuelConsumption(laps3, km3, fuelUsed3, consumption, numArray1[index3], numArray2[index3], numArray6[index3] / (double) laps3, numArray3[index3], numArray4[index3], numArray7[index3] / (double) laps3, strArray[index3]);
        double estimatedDuration = 100.0 * km3 / (double) (100 - this.tyresAfterFinish);
        bool badTyres = numArray5[index3] < 200;
        double badAtKm = (double) (numArray5[index3] - num3) * track.lapDistance;
        double badAtPercent = 100.0 - 100.0 * badAtKm / estimatedDuration;
        this.calcTyres[index3] = new CalculatedTyreWear(tyreTypeArray[index3], laps3, km3, this.tyresAfterFinish, badTyres, badAtKm, badAtPercent, estimatedDuration, numArray1[index3], numArray2[index3], numArray6[index3] / (double) laps3, numArray3[index3], numArray4[index3], numArray7[index3] / (double) laps3, strArray[index3]);
        int length3 = this.laps.Length;
      }
      else
      {
        CalculatedTyreWear[] calculatedTyreWearArray = new CalculatedTyreWear[this.calcTyres.Length];
        CalculatedFuelConsumption[] calculatedFuelConsumptionArray = new CalculatedFuelConsumption[index3 > 0 ? index3 + 1 : index3];
        for (int index4 = 0; index4 < calculatedTyreWearArray.Length; ++index4)
          calculatedTyreWearArray[index4] = this.calcTyres[index4];
        for (int index5 = 0; index5 < calculatedFuelConsumptionArray.Length - 1; ++index5)
          calculatedFuelConsumptionArray[index5] = this.calcFuel[index5];
        this.calcFuel = calculatedFuelConsumptionArray;
        this.calcTyres = calculatedTyreWearArray;
        --index3;
      }
      int maxTemp = 0;
      int minTemp = 100;
      int maxHum = 0;
      int minHum = 100;
      double num5 = 0.0;
      double num6 = 0.0;
      for (int index6 = 0; index6 < this.calcFuel.Length - 1; ++index6)
      {
        if (numArray4[index6] > maxHum)
          maxHum = numArray4[index6];
        if (numArray3[index6] < minHum)
          minHum = numArray3[index6];
        if (numArray2[index6] > maxTemp)
          maxTemp = numArray2[index6];
        if (numArray1[index6] < minTemp)
          minTemp = numArray1[index6];
        num5 += this.calcFuel[index6].avgTemp * (double) this.calcFuel[index6].laps;
        num6 += this.calcFuel[index6].avgHum * (double) this.calcFuel[index6].laps;
      }
      string weather = strArray[0];
      for (int index7 = 1; index7 < length2; ++index7)
      {
        if (!strArray[index7].Equals(weather))
          weather = "Mixed";
      }
      this.calcFuel[index3 + 1] = new CalculatedFuelConsumption(laps1, km1, fuelUsed1, km1 / fuelUsed1, minTemp, maxTemp, num5 / (double) laps1, minHum, maxHum, num6 / (double) laps1, weather);
    }
  }
}
