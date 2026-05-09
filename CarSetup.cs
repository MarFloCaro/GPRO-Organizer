// Decompiled with JetBrains decompiler
// Type: go.CarSetup
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class CarSetup
  {
    public int fWing;
    public int rWing;
    public int engine;
    public int brakes;
    public int gear;
    public int susp;
    public TyreType tyres;

    public bool IsEqual(CarSetup oldSetup)
    {
      return this.fWing == oldSetup.fWing && this.rWing == oldSetup.rWing && this.engine == oldSetup.engine && this.brakes == oldSetup.brakes && this.gear == oldSetup.gear && this.susp == oldSetup.susp && this.tyres == oldSetup.tyres;
    }
  }
}
