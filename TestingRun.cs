 
// Type: go.TestingRun
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class TestingRun
  {
    public TimeSpan bestTime = new TimeSpan(0L);
    public TimeSpan meanTime = new TimeSpan(0L);
    public CarSetup setup = new CarSetup();
    public string[] comments = new string[1];
    public int lapLimit;
    public int lapsDone;
    public int fuelStart;
    public int tyresCondition;
    public int fuelLeft;
    public TestPriority priority = TestPriority.Unknown;

    public TestingRun() => this.comments[0] = "";
  }
}
