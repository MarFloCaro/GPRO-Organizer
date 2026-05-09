// Decompiled with JetBrains decompiler
// Type: go.Qualify
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Qualify
  {
    public TimeSpan time = new TimeSpan(0L);
    public CarSetup setup = new CarSetup();
    public int track;
    public Weather weather = new Weather();
    public QualifyRisk risk = QualifyRisk.Unknown;
    public int fuel;

    public Qualify()
    {
    }

    public Qualify(Practice3 oldQualify)
    {
      this.track = oldQualify.track;
      this.weather = oldQualify.weather;
      this.risk = QualifyRisk.Unknown;
      this.time = oldQualify.q1Run.netTime;
      this.setup = oldQualify.q1Run.setup;
      this.fuel = -1;
    }
  }
}
