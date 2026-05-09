// Decompiled with JetBrains decompiler
// Type: go.RaceSummaryLine
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceSummaryLine
  {
    public int pos;
    public int progress;
    public int managerID;
    public string managerName = "";
    public TimeSpan raceTime;
    public int laps;
    public int pitStops;
    public TimeSpan bestLap;
    public double averageSpeed;
    public TimeSpan bestPitTime;
    public bool BestLapOfAll;
    public string NoTimeReason = "";
  }
}
