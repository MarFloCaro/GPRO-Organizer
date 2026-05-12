 
// Type: go.WeatherForecast
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class WeatherForecast
  {
    public int[] minTemp = new int[4];
    public int[] maxTemp = new int[4];
    public int[] minHum = new int[4];
    public int[] maxHum = new int[4];
    public int[] minRain = new int[4];
    public int[] maxRain = new int[4];
    public bool isReady;

    public WeatherForecast()
    {
    }

    public WeatherForecast(string page)
    {
      for (int index = 0; index < 4; ++index)
      {
        this.minHum[index] = 0;
        this.maxHum[index] = 0;
        this.minTemp[index] = 0;
        this.maxTemp[index] = 0;
        this.minRain[index] = 0;
        this.maxRain[index] = 0;
      }
      int startIndex1 = page.IndexOf("0h30m - 1h");
      for (int index = 0; index < 4; ++index)
      {
        int startIndex2 = page.IndexOf("Temp:", startIndex1) + 6;
        page.IndexOf(" ", startIndex2);
        page.IndexOf("°", startIndex2);
        string s1 = page.Substring(startIndex2, page.IndexOf("&", startIndex2) - startIndex2);
        this.minTemp[index] = int.Parse(s1);
        int startIndex3 = page.IndexOf("-", startIndex2) + 1;
        string s2 = page.Substring(startIndex3, page.IndexOf("&", startIndex3) - startIndex3);
        this.maxTemp[index] = int.Parse(s2);
        int startIndex4 = page.IndexOf("Humidity:", startIndex3) + 10;
        string s3 = page.Substring(startIndex4, page.IndexOf("%", startIndex4) - startIndex4);
        this.minHum[index] = int.Parse(s3);
        int startIndex5 = page.IndexOf("-", startIndex4) + 1;
        string s4 = page.Substring(startIndex5, page.IndexOf("%", startIndex5) - startIndex5);
        this.maxHum[index] = int.Parse(s4);
        int startIndex6 = page.IndexOf("Rain probability:", startIndex5) + 17;
        string s5 = page.Substring(startIndex6, page.IndexOf("%", startIndex6) - startIndex6);
        this.minRain[index] = int.Parse(s5);
        startIndex1 = startIndex6 + (s5.Length + 1);
        if (page.IndexOf("%", startIndex1) < page.IndexOf("</td>", startIndex1))
        {
          startIndex1 = page.IndexOf("-", startIndex1) + 1;
          string s6 = page.Substring(startIndex1, page.IndexOf("%", startIndex1) - startIndex1);
          this.maxRain[index] = int.Parse(s6);
        }
      }
      this.isReady = true;
    }
  }
}
