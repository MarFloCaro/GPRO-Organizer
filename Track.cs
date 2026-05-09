// Decompiled with JetBrains decompiler
// Type: go.Track
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Track
  {
    public string name = "";
    public int number;
    public double distance;
    public int laps;
    public double lapDistance;
    public double averageSpeed;
    public int numberOfCorners;
    public double timeInPits;
    public int power;
    public int handling;
    public int acceleration;
    public Downforce downforce = Downforce.Medium;
    public Overtaking overtaking = Overtaking.Normal;
    public SupensionRigidity suspensionRigidity = SupensionRigidity.Medium;
    public FuelConsumption fuelConsumption = FuelConsumption.Medium;
    public TyreWear tyreWear = TyreWear.Medium;
    public Category category;
    public Grip grip;
  }
}
