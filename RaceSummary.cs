// Decompiled with JetBrains decompiler
// Type: go.RaceSummary
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class RaceSummary
  {
    public RaceSummaryLine[] classified;
    public RaceSummaryLine[] notClassified;
  }
}
