// Decompiled with JetBrains decompiler
// Type: go.Practice3
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Practice3
  {
    public PracticeRun[] runs = new PracticeRun[8];
    public PracticeRun q1Run = new PracticeRun();
    public int track;
    public Weather weather = new Weather();
    public Car2 car = new Car2();

    public Practice3(Practice2 oldPractice)
    {
      this.runs = oldPractice.runs;
      this.q1Run = oldPractice.q1Run;
      this.track = oldPractice.track;
      this.weather = oldPractice.weather;
      this.car = new Car2(oldPractice.car);
    }

    public Practice3(Practice oldpractice)
      : this(new Practice2(oldpractice))
    {
    }

    public Practice3()
    {
      for (int index = 0; index < this.runs.Length; ++index)
        this.runs[index] = new PracticeRun();
    }
  }
}
