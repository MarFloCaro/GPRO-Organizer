 
// Type: go.RaceSummaryLine
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceSummaryLine
  {
    public int pos;
    public int progress;
    public int managerID;
    public string managerName = "";
    public TimeSpan raceTime;
    public int laps;
    public int pitStops;
    public TimeSpan bestLap;
    public double averageSpeed;
    public TimeSpan bestPitTime;
    public bool BestLapOfAll;
    public string NoTimeReason = "";
  }
}
