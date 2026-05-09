// Decompiled with JetBrains decompiler
// Type: go.Testing
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

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
