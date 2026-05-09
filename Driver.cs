// Decompiled with JetBrains decompiler
// Type: go.Driver
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Driver
  {
    public int id;
    public string name = "";
    public string nationality = "";
    public int overall;
    public int concentration;
    public int talent;
    public int aggresiveness;
    public int experience;
    public int technicalInsight;
    public int stamina;
    public int charisma;
    public int motivation;
    public int weight;
    public int age;
    public int salary;
    public int racesLeftOfContract;
    public int trophies;
    public int numberOfGps;
    public int wins;
    public int podiums;
    public int pointsScored;
    public int polePositions;
    public int fastestLaps;
    public double avPointsPerrace;
    public DriverHistory history = new DriverHistory();
  }
}
