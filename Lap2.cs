 
// Type: go.Lap2
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Lap2
  {
    public Weather weather = new Weather();
    public TimeSpan lapTime;
    public int position;
    public bool goodTyres = true;
    public int lapNumber;
    public TyreType tyres;
    public string events;

    public Lap2()
    {
    }

    public Lap2(Lap oldLap)
    {
      this.weather = oldLap.weather;
      this.lapTime = oldLap.lapTime;
      this.position = oldLap.position;
      this.lapNumber = oldLap.lapNumber;
      this.tyres = oldLap.tyres;
      this.events = oldLap.events;
    }
  }
}
