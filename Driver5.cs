 
// Type: go.Driver5
 
 
 

using go.Enums;
using System;
using System.Collections;

#nullable disable
namespace go
{
  [Serializable]
  public class Driver5
  {
    public int id;
    public string name = "";
    public string nationality = "";
    public int energy;
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

    public Driver5()
    {
    }

    public Driver5(Driver driver)
      : this(new Driver4(driver))
    {
    }

    public Driver5(Driver2 driver)
      : this(new Driver4(driver))
    {
    }

    public Driver5(Driver3 driver)
      : this(new Driver4(driver))
    {
    }

    public Driver5(Driver4 driver)
    {
      this.id = driver.id;
      this.name = driver.name;
      this.nationality = driver.nationality;
      this.energy = 0;
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

    public Driver5 CopyNoHistory()
    {
      return new Driver5()
      {
        age = this.age,
        aggresiveness = this.aggresiveness,
        avPointsPerrace = this.avPointsPerrace,
        charisma = this.charisma,
        concentration = this.concentration,
        experience = this.experience,
        fastestLaps = this.fastestLaps,
        id = this.id,
        motivation = this.motivation,
        name = this.name,
        nationality = this.nationality,
        numberOfGps = this.numberOfGps,
        overall = this.overall,
        podiums = this.podiums,
        pointsScored = this.pointsScored,
        polePositions = this.polePositions,
        racesLeftOfContract = this.racesLeftOfContract,
        salary = this.salary,
        stamina = this.stamina,
        talent = this.talent,
        technicalInsight = this.technicalInsight,
        trophies = this.trophies,
        weight = this.weight,
        wins = this.wins,
        reputation = this.reputation,
        favoriteTracks = this.favoriteTracks
      };
    }

    public bool isSameDriver(int driverid) => this.id == driverid;

    public bool isEqual(Driver5 d)
    {
      return d.name == this.name && d.id == this.id && this.nationality == d.nationality && this.overall == d.overall && this.concentration == d.concentration && this.talent == d.talent && this.aggresiveness == d.aggresiveness && this.experience == d.experience && this.technicalInsight == d.technicalInsight && this.stamina == d.stamina && this.charisma == d.charisma && this.motivation == d.motivation && this.weight == d.weight && this.age == d.age && this.salary == d.salary && this.racesLeftOfContract == d.racesLeftOfContract && this.trophies == d.trophies && this.numberOfGps == d.numberOfGps && this.wins == d.wins && this.podiums == d.podiums && this.pointsScored == d.pointsScored && this.polePositions == d.polePositions && this.fastestLaps == d.fastestLaps && this.avPointsPerrace == d.avPointsPerrace && this.reputation == d.reputation && this.energy == d.energy;
    }

    public void UpdateDriver(Date date, Driver5 d, bool force)
    {
      if (force || d.trophies != this.trophies)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Trophies;
        driverHistoryItem2.newValue = (double) d.trophies;
        driverHistoryItem2.oldValue = (double) this.trophies;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.trophies = d.trophies;
      }
      if (force || d.numberOfGps != this.numberOfGps)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.NumberofGps;
        driverHistoryItem2.newValue = (double) d.numberOfGps;
        driverHistoryItem2.oldValue = (double) this.numberOfGps;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.numberOfGps = d.numberOfGps;
      }
      if (force || d.wins != this.wins)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Wins;
        driverHistoryItem2.newValue = (double) d.wins;
        driverHistoryItem2.oldValue = (double) this.wins;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.wins = d.wins;
      }
      if (force || d.podiums != this.podiums)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Podiums;
        driverHistoryItem2.newValue = (double) d.podiums;
        driverHistoryItem2.oldValue = (double) this.podiums;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.podiums = d.podiums;
      }
      if (force || d.pointsScored != this.pointsScored)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.PointsScored;
        driverHistoryItem2.newValue = (double) d.pointsScored;
        driverHistoryItem2.oldValue = (double) this.pointsScored;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.pointsScored = d.pointsScored;
      }
      if (force || d.polePositions != this.polePositions)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.PolePositions;
        driverHistoryItem2.newValue = (double) d.polePositions;
        driverHistoryItem2.oldValue = (double) this.polePositions;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.polePositions = d.polePositions;
      }
      if (force || d.fastestLaps != this.fastestLaps)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.FastestLaps;
        driverHistoryItem2.newValue = (double) d.fastestLaps;
        driverHistoryItem2.oldValue = (double) this.fastestLaps;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.fastestLaps = d.fastestLaps;
      }
      if (force || d.avPointsPerrace != this.avPointsPerrace)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.AvPointsPerRace;
        driverHistoryItem2.newValue = d.avPointsPerrace;
        driverHistoryItem2.oldValue = this.avPointsPerrace;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.avPointsPerrace = d.avPointsPerrace;
      }
      if (force || d.overall != this.overall)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Overall;
        driverHistoryItem2.newValue = (double) d.overall;
        driverHistoryItem2.oldValue = (double) this.overall;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.overall = d.overall;
      }
      if (force || d.concentration != this.concentration)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Concentration;
        driverHistoryItem2.newValue = (double) d.concentration;
        driverHistoryItem2.oldValue = (double) this.concentration;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.concentration = d.concentration;
      }
      if (force || d.talent != this.talent)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Talent;
        driverHistoryItem2.newValue = (double) d.talent;
        driverHistoryItem2.oldValue = (double) this.talent;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.talent = d.talent;
      }
      if (force || d.aggresiveness != this.aggresiveness)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Aggresiveness;
        driverHistoryItem2.newValue = (double) d.aggresiveness;
        driverHistoryItem2.oldValue = (double) this.aggresiveness;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.aggresiveness = d.aggresiveness;
      }
      if (force || d.experience != this.experience)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Experience;
        driverHistoryItem2.newValue = (double) d.experience;
        driverHistoryItem2.oldValue = (double) this.experience;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.experience = d.experience;
      }
      if (force || d.technicalInsight != this.technicalInsight)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.TechnicalInsight;
        driverHistoryItem2.newValue = (double) d.technicalInsight;
        driverHistoryItem2.oldValue = (double) this.technicalInsight;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.technicalInsight = d.technicalInsight;
      }
      if (force || d.stamina != this.stamina)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Stamina;
        driverHistoryItem2.newValue = (double) d.stamina;
        driverHistoryItem2.oldValue = (double) this.stamina;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.stamina = d.stamina;
      }
      if (force || d.charisma != this.charisma)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Charisma;
        driverHistoryItem2.newValue = (double) d.charisma;
        driverHistoryItem2.oldValue = (double) this.charisma;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.charisma = d.charisma;
      }
      if (force || d.motivation != this.motivation)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Motivation;
        driverHistoryItem2.newValue = (double) d.motivation;
        driverHistoryItem2.oldValue = (double) this.motivation;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.motivation = d.motivation;
      }
      if (force || d.weight != this.weight)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Weight;
        driverHistoryItem2.newValue = (double) d.weight;
        driverHistoryItem2.oldValue = (double) this.weight;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.weight = d.weight;
      }
      if (force || d.age != this.age)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Age;
        driverHistoryItem2.newValue = (double) d.age;
        driverHistoryItem2.oldValue = (double) this.age;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.age = d.age;
      }
      if (force || d.salary != this.salary)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Salary;
        driverHistoryItem2.newValue = (double) d.salary;
        driverHistoryItem2.oldValue = (double) this.salary;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.salary = d.salary;
      }
      if (force || d.racesLeftOfContract != this.racesLeftOfContract)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.RacesLeft;
        driverHistoryItem2.newValue = (double) d.racesLeftOfContract;
        driverHistoryItem2.oldValue = (double) this.racesLeftOfContract;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.racesLeftOfContract = d.racesLeftOfContract;
      }
      if (force || d.reputation != this.reputation)
      {
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        driverHistoryItem2.driverinfo = DriverInfo.Reputation;
        driverHistoryItem2.newValue = (double) d.reputation;
        driverHistoryItem2.oldValue = (double) this.reputation;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        this.reputation = d.reputation;
      }
      this.favoriteTracks = d.favoriteTracks;
      this.name = d.name;
      this.nationality = d.nationality;
    }

    public void UpdateOldDriverHistory(Date date)
    {
      this.history.historyList = new ArrayList();
      if (this.history.historyList.Count == 0)
      {
        this.InitDriver(date);
      }
      else
      {
        bool flag1 = true;
        bool flag2 = true;
        bool flag3 = true;
        bool flag4 = true;
        bool flag5 = true;
        bool flag6 = true;
        bool flag7 = true;
        bool flag8 = true;
        bool flag9 = true;
        bool flag10 = true;
        bool flag11 = true;
        bool flag12 = true;
        bool flag13 = true;
        bool flag14 = true;
        bool flag15 = true;
        bool flag16 = true;
        bool flag17 = true;
        bool flag18 = true;
        bool flag19 = true;
        bool flag20 = true;
        for (int index = 0; index < this.history.historyList.Count; ++index)
        {
          switch (((DriverHistoryItem) this.history.historyList[index]).driverinfo)
          {
            case DriverInfo.Overall:
              flag2 = false;
              break;
            case DriverInfo.Concentration:
              flag3 = false;
              break;
            case DriverInfo.Talent:
              flag4 = false;
              break;
            case DriverInfo.Aggresiveness:
              flag5 = false;
              break;
            case DriverInfo.Experience:
              flag6 = false;
              break;
            case DriverInfo.TechnicalInsight:
              flag7 = false;
              break;
            case DriverInfo.Stamina:
              flag8 = false;
              break;
            case DriverInfo.Charisma:
              flag9 = false;
              break;
            case DriverInfo.Motivation:
              flag10 = false;
              break;
            case DriverInfo.Weight:
              flag11 = false;
              break;
            case DriverInfo.Trophies:
              flag1 = false;
              break;
            case DriverInfo.NumberofGps:
              flag12 = false;
              break;
            case DriverInfo.Wins:
              flag13 = false;
              break;
            case DriverInfo.Podiums:
              flag17 = false;
              break;
            case DriverInfo.PointsScored:
              flag18 = false;
              break;
            case DriverInfo.PolePositions:
              flag14 = false;
              break;
            case DriverInfo.FastestLaps:
              flag15 = false;
              break;
            case DriverInfo.AvPointsPerRace:
              flag16 = false;
              break;
            case DriverInfo.RacesLeft:
              flag19 = false;
              break;
            case DriverInfo.Reputation:
              flag20 = false;
              break;
          }
        }
        DriverHistoryItem2 driverHistoryItem2 = new DriverHistoryItem2();
        if (flag1)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Trophies;
          driverHistoryItem2.newValue = (double) this.trophies;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag12)
        {
          driverHistoryItem2.driverinfo = DriverInfo.NumberofGps;
          driverHistoryItem2.newValue = (double) this.numberOfGps;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag13)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Wins;
          driverHistoryItem2.newValue = (double) this.wins;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag17)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Podiums;
          driverHistoryItem2.newValue = (double) this.podiums;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag18)
        {
          driverHistoryItem2.driverinfo = DriverInfo.PointsScored;
          driverHistoryItem2.newValue = (double) this.pointsScored;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag14)
        {
          driverHistoryItem2.driverinfo = DriverInfo.PolePositions;
          driverHistoryItem2.newValue = (double) this.polePositions;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag15)
        {
          driverHistoryItem2.driverinfo = DriverInfo.FastestLaps;
          driverHistoryItem2.newValue = (double) this.fastestLaps;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag16)
        {
          driverHistoryItem2.driverinfo = DriverInfo.AvPointsPerRace;
          driverHistoryItem2.newValue = this.avPointsPerrace;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag2)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Overall;
          driverHistoryItem2.newValue = (double) this.overall;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag3)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Concentration;
          driverHistoryItem2.newValue = (double) this.concentration;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag4)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Talent;
          driverHistoryItem2.newValue = (double) this.talent;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag5)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Aggresiveness;
          driverHistoryItem2.newValue = (double) this.aggresiveness;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag6)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Experience;
          driverHistoryItem2.newValue = (double) this.experience;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag7)
        {
          driverHistoryItem2.driverinfo = DriverInfo.TechnicalInsight;
          driverHistoryItem2.newValue = (double) this.technicalInsight;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag8)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Stamina;
          driverHistoryItem2.newValue = (double) this.stamina;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag9)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Charisma;
          driverHistoryItem2.newValue = (double) this.charisma;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag10)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Motivation;
          driverHistoryItem2.newValue = (double) this.motivation;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (flag11)
        {
          driverHistoryItem2.driverinfo = DriverInfo.Weight;
          driverHistoryItem2.newValue = (double) this.weight;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        driverHistoryItem2.driverinfo = DriverInfo.Age;
        driverHistoryItem2.newValue = (double) this.age;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        driverHistoryItem2.driverinfo = DriverInfo.Salary;
        driverHistoryItem2.newValue = (double) this.salary;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
        if (flag19)
        {
          driverHistoryItem2.driverinfo = DriverInfo.RacesLeft;
          driverHistoryItem2.newValue = (double) this.racesLeftOfContract;
          driverHistoryItem2.date = date.Clone();
          this.history.historyList.Add((object) driverHistoryItem2);
        }
        if (!flag20)
          return;
        driverHistoryItem2.driverinfo = DriverInfo.Reputation;
        driverHistoryItem2.newValue = (double) this.reputation;
        driverHistoryItem2.date = date.Clone();
        this.history.historyList.Add((object) driverHistoryItem2);
      }
    }

    public void InitDriver(Date date) => this.UpdateDriver(date, this, true);
  }
}
