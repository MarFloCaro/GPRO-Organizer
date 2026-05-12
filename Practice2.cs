 
// Type: go.Practice2
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Practice2
  {
    public PracticeRun[] runs = new PracticeRun[8];
    public PracticeRun q1Run = new PracticeRun();
    public int track;
    public Weather weather = new Weather();
    public Car car = new Car();

    public Practice2(Practice oldPractice)
    {
      this.runs = oldPractice.runs;
      this.q1Run = oldPractice.q1Run;
      this.track = oldPractice.track;
      this.weather = oldPractice.weather;
    }

    public Practice2()
    {
      for (int index = 0; index < this.runs.Length; ++index)
        this.runs[index] = new PracticeRun();
    }
  }
}
