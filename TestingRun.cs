// Decompiled with JetBrains decompiler
// Type: go.TestingRun
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
