 
// Type: go.Testing
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Testing
  {
    public TestingRun[] runs = new TestingRun[10];
    public TestingPoints[] points = new TestingPoints[4];
    public Weather weather = new Weather();
    public int track;

    public Testing()
    {
      for (int index = 0; index < this.points.Length; ++index)
        this.points[index] = new TestingPoints();
    }
  }
}
