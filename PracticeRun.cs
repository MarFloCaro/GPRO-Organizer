 
// Type: go.PracticeRun
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class PracticeRun
  {
    public TimeSpan lapTime = new TimeSpan(0L);
    public TimeSpan driverMistake = new TimeSpan(0L);
    public TimeSpan netTime = new TimeSpan(0L);
    public CarSetup setup = new CarSetup();
    public string[] comments = new string[1];

    public PracticeRun() => this.comments[0] = "";
  }
}
