 
// Type: go.RaceWeather
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceWeather
  {
    public WeatherForecast forecast = new WeatherForecast();
    public Weather pracWeather = new Weather();
    public Weather qualWeather = new Weather();
  }
}
