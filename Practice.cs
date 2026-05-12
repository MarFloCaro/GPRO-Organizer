 
// Type: go.Practice
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Practice
  {
    public PracticeRun[] runs = new PracticeRun[8];
    public PracticeRun q1Run = new PracticeRun();
    public int track;
    public Weather weather = new Weather();

    public Practice()
    {
      for (int index = 0; index < this.runs.Length; ++index)
        this.runs[index] = new PracticeRun();
    }
  }
}
