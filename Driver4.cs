 
// Type: go.Driver4
 
 
 

using System;

#nullable disable
namespace go
{
  [Serializable]
  public class Driver4
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
    public int reputation;
    public int trophies;
    public int numberOfGps;
    public int wins;
    public int podiums;
    public int pointsScored;
    public int polePositions;
    public int fastestLaps;
    public double avPointsPerrace;
    public DriverHistory2 history = new DriverHistory2();
    public int[] favoriteTracks = new int[0];

    public Driver4()
    {
    }

    public Driver4(Driver driver)
      : this(new Driver3(driver))
    {
    }

    public Driver4(Driver2 driver)
      : this(new Driver3(driver))
    {
    }

    public Driver4(Driver3 driver)
    {
      this.id = driver.id;
      this.name = driver.name;
      this.nationality = driver.nationality;
      this.overall = driver.overall;
      this.concentration = driver.concentration;
      this.talent = driver.talent;
      this.aggresiveness = driver.aggresiveness;
      this.experience = driver.experience;
      this.technicalInsight = driver.technicalInsight;
      this.stamina = driver.stamina;
      this.charisma = driver.charisma;
      this.motivation = driver.motivation;
      this.weight = driver.weight;
      this.age = driver.age;
      this.salary = driver.salary;
      this.racesLeftOfContract = driver.racesLeftOfContract;
      this.trophies = driver.trophies;
      this.numberOfGps = driver.numberOfGps;
      this.wins = driver.wins;
      this.podiums = driver.podiums;
      this.pointsScored = driver.pointsScored;
      this.polePositions = driver.polePositions;
      this.fastestLaps = driver.fastestLaps;
      this.avPointsPerrace = driver.avPointsPerrace;
      this.history = driver.history;
      this.favoriteTracks = new int[0];
    }
  }
}
