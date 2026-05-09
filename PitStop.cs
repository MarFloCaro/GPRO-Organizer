// Decompiled with JetBrains decompiler
// Type: go.PitStop
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class PitStop
  {
    public int lap;
    public PitStopReason pitstopreason = PitStopReason.WornTyres;
    public int tyresCondition;
    public int fuelLeft;
    public int refilledTo;
    public TimeSpan pitTime;
  }
}
