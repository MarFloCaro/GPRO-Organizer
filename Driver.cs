 
// Type: go.Driver
 
 
 

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
