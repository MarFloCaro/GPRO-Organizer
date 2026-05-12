 
// Type: go.CalculatedFuelConsumption
 
 
 

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
