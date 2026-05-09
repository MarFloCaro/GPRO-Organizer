// Decompiled with JetBrains decompiler
// Type: go.CarPart
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class CarPart
  {
    public int level;
    public int wear;

    public bool IsEqual(CarPart part) => this.IsSameLevel(part) && this.wear == part.wear;

    public bool IsSameLevel(CarPart part) => this.level == part.level;
  }
}
