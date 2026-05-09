// Decompiled with JetBrains decompiler
// Type: go.Practice
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
