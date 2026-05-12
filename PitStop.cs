 
// Type: go.PitStop
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class PitStop
  {
    public int lap;
    public PitStopReason pitstopreason = PitStopReason.WornTyres;
    public int tyresCondition;
    public int fuelLeft;
    public int refilledTo;
    public TimeSpan pitTime;
  }
}
