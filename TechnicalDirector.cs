 
// Type: go.TechnicalDirector
 
 
 

using go.Enums;
using go.History;
using System;

#nullable disable
namespace go
{
  [Serializable]
  public class TechnicalDirector
  {
    public int id;
    public string name = "";
    public string nationality = "";
    public int trophies;
    public int numberOfGps;
    public int wins;
    public int overall;
    public int leadership;
    public int mechanics;
    public int electronics;
    public int aerodynamics;
    public int experience;
    public int pitCoordination;
    public int motivation;
    public int age;
    public int racesLeftOfContract;
    public int salary;
    public TechnicalDirectorHistory history = new TechnicalDirectorHistory();

    public TechnicalDirector CopyNoHistory()
    {
      return new TechnicalDirector()
      {
        aerodynamics = this.aerodynamics,
        age = this.age,
        electronics = this.electronics,
        experience = this.experience,
        id = this.id,
        leadership = this.leadership,
        mechanics = this.mechanics,
        motivation = this.motivation,
        name = this.name,
        nationality = this.nationality,
        numberOfGps = this.numberOfGps,
        overall = this.overall,
        pitCoordination = this.pitCoordination,
        racesLeftOfContract = this.racesLeftOfContract,
        salary = this.salary,
        trophies = this.trophies,
        wins = this.wins
      };
    }

    public bool IsSameTechnicalDirector(int id) => id == this.id;

    public bool IsEqual(TechnicalDirector td)
    {
      return td.aerodynamics == this.aerodynamics && td.age == this.age && td.electronics == this.electronics && td.experience == this.experience && td.id == this.id && td.leadership == this.leadership && td.mechanics == this.mechanics && td.motivation == this.motivation && td.name == this.name && td.nationality == this.nationality && td.numberOfGps == this.numberOfGps && td.overall == this.overall && td.pitCoordination == this.pitCoordination && td.racesLeftOfContract == this.racesLeftOfContract && td.salary == this.salary && td.trophies == this.trophies && td.wins == this.wins;
    }

    public void UpdateTechnicalDirector(Date date, TechnicalDirector td, bool force)
    {
      TechnicalDirectorHistoryItem directorHistoryItem1 = new TechnicalDirectorHistoryItem();
      if (force || td.aerodynamics != this.aerodynamics)
      {
        TechnicalDirectorHistoryItem directorHistoryItem2 = new TechnicalDirectorHistoryItem();
        directorHistoryItem2.date = date.Clone();
        directorHistoryItem2.info = TechnicalDirectorInfo.Aerodynamics;
        directorHistoryItem2.oldValue = (double) this.aerodynamics;
        directorHistoryItem2.newValue = (double) td.aerodynamics;
        this.history.historyList.Add((object) directorHistoryItem2);
        this.aerodynamics = td.aerodynamics;
      }
      if (force || td.age != this.age)
      {
        TechnicalDirectorHistoryItem directorHistoryItem3 = new TechnicalDirectorHistoryItem();
        directorHistoryItem3.date = date.Clone();
        directorHistoryItem3.info = TechnicalDirectorInfo.Age;
        directorHistoryItem3.oldValue = (double) this.age;
        directorHistoryItem3.newValue = (double) td.age;
        this.history.historyList.Add((object) directorHistoryItem3);
        this.age = td.age;
      }
      if (force || td.electronics != this.electronics)
      {
        TechnicalDirectorHistoryItem directorHistoryItem4 = new TechnicalDirectorHistoryItem();
        directorHistoryItem4.date = date.Clone();
        directorHistoryItem4.info = TechnicalDirectorInfo.Electronics;
        directorHistoryItem4.oldValue = (double) this.electronics;
        directorHistoryItem4.newValue = (double) td.electronics;
        this.history.historyList.Add((object) directorHistoryItem4);
        this.electronics = td.electronics;
      }
      if (force || td.experience != this.experience)
      {
        TechnicalDirectorHistoryItem directorHistoryItem5 = new TechnicalDirectorHistoryItem();
        directorHistoryItem5.date = date.Clone();
        directorHistoryItem5.info = TechnicalDirectorInfo.Experience;
        directorHistoryItem5.oldValue = (double) this.experience;
        directorHistoryItem5.newValue = (double) td.experience;
        this.history.historyList.Add((object) directorHistoryItem5);
        this.experience = td.experience;
      }
      if (force || td.leadership != this.leadership)
      {
        TechnicalDirectorHistoryItem directorHistoryItem6 = new TechnicalDirectorHistoryItem();
        directorHistoryItem6.date = date.Clone();
        directorHistoryItem6.info = TechnicalDirectorInfo.Leadership;
        directorHistoryItem6.oldValue = (double) this.leadership;
        directorHistoryItem6.newValue = (double) td.leadership;
        this.history.historyList.Add((object) directorHistoryItem6);
        this.leadership = td.leadership;
      }
      if (force || td.mechanics != this.mechanics)
      {
        TechnicalDirectorHistoryItem directorHistoryItem7 = new TechnicalDirectorHistoryItem();
        directorHistoryItem7.date = date.Clone();
        directorHistoryItem7.info = TechnicalDirectorInfo.Mechanics;
        directorHistoryItem7.oldValue = (double) this.mechanics;
        directorHistoryItem7.newValue = (double) td.mechanics;
        this.history.historyList.Add((object) directorHistoryItem7);
        this.mechanics = td.mechanics;
      }
      if (force || td.motivation != this.motivation)
      {
        TechnicalDirectorHistoryItem directorHistoryItem8 = new TechnicalDirectorHistoryItem();
        directorHistoryItem8.date = date.Clone();
        directorHistoryItem8.info = TechnicalDirectorInfo.Motivation;
        directorHistoryItem8.oldValue = (double) this.motivation;
        directorHistoryItem8.newValue = (double) td.motivation;
        this.history.historyList.Add((object) directorHistoryItem8);
        this.motivation = td.motivation;
      }
      if (force || td.numberOfGps != this.numberOfGps)
      {
        TechnicalDirectorHistoryItem directorHistoryItem9 = new TechnicalDirectorHistoryItem();
        directorHistoryItem9.date = date.Clone();
        directorHistoryItem9.info = TechnicalDirectorInfo.NumberOfGps;
        directorHistoryItem9.oldValue = (double) this.numberOfGps;
        directorHistoryItem9.newValue = (double) td.numberOfGps;
        this.history.historyList.Add((object) directorHistoryItem9);
        this.numberOfGps = td.numberOfGps;
      }
      if (force || td.overall != this.overall)
      {
        TechnicalDirectorHistoryItem directorHistoryItem10 = new TechnicalDirectorHistoryItem();
        directorHistoryItem10.date = date.Clone();
        directorHistoryItem10.info = TechnicalDirectorInfo.Overall;
        directorHistoryItem10.oldValue = (double) this.overall;
        directorHistoryItem10.newValue = (double) td.overall;
        this.history.historyList.Add((object) directorHistoryItem10);
        this.overall = td.overall;
      }
      if (force || td.pitCoordination != this.pitCoordination)
      {
        TechnicalDirectorHistoryItem directorHistoryItem11 = new TechnicalDirectorHistoryItem();
        directorHistoryItem11.date = date.Clone();
        directorHistoryItem11.info = TechnicalDirectorInfo.PitCoordination;
        directorHistoryItem11.oldValue = (double) this.pitCoordination;
        directorHistoryItem11.newValue = (double) td.pitCoordination;
        this.history.historyList.Add((object) directorHistoryItem11);
        this.pitCoordination = td.pitCoordination;
      }
      if (force || td.racesLeftOfContract != this.racesLeftOfContract)
      {
        TechnicalDirectorHistoryItem directorHistoryItem12 = new TechnicalDirectorHistoryItem();
        directorHistoryItem12.date = date.Clone();
        directorHistoryItem12.info = TechnicalDirectorInfo.ContractLength;
        directorHistoryItem12.oldValue = (double) this.racesLeftOfContract;
        directorHistoryItem12.newValue = (double) td.racesLeftOfContract;
        this.history.historyList.Add((object) directorHistoryItem12);
        this.racesLeftOfContract = td.racesLeftOfContract;
      }
      if (force || td.salary != this.salary)
      {
        TechnicalDirectorHistoryItem directorHistoryItem13 = new TechnicalDirectorHistoryItem();
        directorHistoryItem13.date = date.Clone();
        directorHistoryItem13.info = TechnicalDirectorInfo.Salary;
        directorHistoryItem13.oldValue = (double) this.salary;
        directorHistoryItem13.newValue = (double) td.salary;
        this.history.historyList.Add((object) directorHistoryItem13);
        this.salary = td.salary;
      }
      if (force || td.trophies != this.trophies)
      {
        TechnicalDirectorHistoryItem directorHistoryItem14 = new TechnicalDirectorHistoryItem();
        directorHistoryItem14.date = date.Clone();
        directorHistoryItem14.info = TechnicalDirectorInfo.Trophies;
        directorHistoryItem14.oldValue = (double) this.trophies;
        directorHistoryItem14.newValue = (double) td.trophies;
        this.history.historyList.Add((object) directorHistoryItem14);
        this.trophies = td.trophies;
      }
      if (!force && td.wins == this.wins)
        return;
      TechnicalDirectorHistoryItem directorHistoryItem15 = new TechnicalDirectorHistoryItem();
      directorHistoryItem15.date = date.Clone();
      directorHistoryItem15.info = TechnicalDirectorInfo.Wins;
      directorHistoryItem15.oldValue = (double) this.wins;
      directorHistoryItem15.newValue = (double) td.wins;
      this.history.historyList.Add((object) directorHistoryItem15);
      this.wins = td.wins;
    }

    public void Init(Date date) => this.UpdateTechnicalDirector(date, this, true);
  }
}
