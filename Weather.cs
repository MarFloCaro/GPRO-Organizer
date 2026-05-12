 
// Type: go.Weather
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Weather
  {
    public Skies skies = Skies.Cloudy;
    public int temperature;
    public int humidity;
  }
}
