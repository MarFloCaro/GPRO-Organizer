 
// Type: go.Qualify
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Qualify
  {
    public TimeSpan time = new TimeSpan(0L);
    public CarSetup setup = new CarSetup();
    public int track;
    public Weather weather = new Weather();
    public QualifyRisk risk = QualifyRisk.Unknown;
    public int fuel;

    public Qualify()
    {
    }

    public Qualify(Practice3 oldQualify)
    {
      this.track = oldQualify.track;
      this.weather = oldQualify.weather;
      this.risk = QualifyRisk.Unknown;
      this.time = oldQualify.q1Run.netTime;
      this.setup = oldQualify.q1Run.setup;
      this.fuel = -1;
    }
  }
}
