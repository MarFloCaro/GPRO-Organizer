// Decompiled with JetBrains decompiler
// Type: go.PracticeRun
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
