 
// Type: go.Utils.DataMerger
 
 
 

using go.History;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

#nullable disable
namespace go.Utils
{
  internal class DataMerger
  {
    private int version;
    private int internalnumber;
    private string managername;
    private string teamname;
    private Date date;
    private Car2 car;
    private Driver5 driver;
    private CarHistory2 carHistory;
    private ArrayList oldDrivers;
    private List<Season20> seasons;
    private string[] trackNotes;
    private ArrayList financeHistory;
    private Staff staff;
    private ArrayList staffHistory;
    private TechnicalDirector technicalDirector;
    private ArrayList oldTechnicalDirectors;
    private Manager manager;

    public DataMerger(string filename, int numberOfTracks)
    {
      Loader loader = new Loader();
      IFormatter formatter = (IFormatter) new BinaryFormatter()
      {
        Binder = (SerializationBinder) new TypeBinder()
      };
      Stream goFile = this.GetGoFile(filename);
      this.version = (int) formatter.Deserialize(goFile);
      if (this.version < 13)
        throw new Exception("File is from old version of GO");
      this.internalnumber = (int) formatter.Deserialize(goFile);
      this.managername = (string) formatter.Deserialize(goFile);
      this.teamname = (string) formatter.Deserialize(goFile);
      this.date = (Date) formatter.Deserialize(goFile);
      int version1 = (int) formatter.Deserialize(goFile);
      this.car = loader.LoadCar(ref goFile, ref formatter, version1);
      int version2 = (int) formatter.Deserialize(goFile);
      this.driver = loader.LoadDriver(ref goFile, ref formatter, version2);
      int version3 = (int) formatter.Deserialize(goFile);
      this.carHistory = loader.LoadCarHistory(ref goFile, ref formatter, version3);
      int version4 = (int) formatter.Deserialize(goFile);
      this.oldDrivers = loader.LoadOldDrivers(ref goFile, ref formatter, version4);
      int version5 = (int) formatter.Deserialize(goFile);
      this.seasons = loader.LoadSeasons(ref goFile, ref formatter, version5);
      int version6 = (int) formatter.Deserialize(goFile);
      this.trackNotes = loader.LoadTrackNotes(ref goFile, ref formatter, version6, numberOfTracks);
      int version7 = (int) formatter.Deserialize(goFile);
      this.financeHistory = loader.LoadFinacialHistory(ref goFile, ref formatter, version7);
      int version8 = (int) formatter.Deserialize(goFile);
      this.staff = loader.LoadStaff(ref goFile, ref formatter, version8);
      int version9 = (int) formatter.Deserialize(goFile);
      this.staffHistory = loader.LoadStaffHistory(ref goFile, ref formatter, version9);
      int version10 = (int) formatter.Deserialize(goFile);
      this.technicalDirector = loader.LoadTechnicalDirector(ref goFile, ref formatter, version10);
      int version11 = (int) formatter.Deserialize(goFile);
      this.oldTechnicalDirectors = loader.LoadOldTechnicalDirectors(ref goFile, ref formatter, version11);
      int version12 = (int) formatter.Deserialize(goFile);
      this.manager = loader.LoadManager(ref goFile, ref formatter, version12);
      int num = (bool) formatter.Deserialize(goFile) ? 1 : 0;
    }

    public string getManagerName() => this.managername;

    private Stream GetGoFile(string filename)
    {
      return (Stream) new FileStream(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
    }

    public List<Season20> mergeSeasons(List<Season20> mergeSeasons) => (List<Season20>) null;

    private RaceEvent20[] mergeEvents(RaceEvent20[] events, RaceEvent20[] mergeevents)
    {
      for (int index = 0; index < events.Length; ++index)
        mergeevents[index] = this.mergeEvent(events[index], mergeevents[index]);
      return mergeevents;
    }

    private RaceEvent20 mergeEvent(RaceEvent20 oldEvent, RaceEvent20 mergeEvent)
    {
      if (oldEvent.isQualifingUpdated && !mergeEvent.isQualifingUpdated)
        mergeEvent.Qualify1 = oldEvent.Qualify1;
      if (oldEvent.isQualifing2Updated && !mergeEvent.isQualifing2Updated)
        mergeEvent.Qualify2 = oldEvent.Qualify2;
      if (oldEvent.isPractiseUpdated && !mergeEvent.isPractiseUpdated)
      {
        mergeEvent.Practise = oldEvent.Practise;
        mergeEvent.Weather = oldEvent.Weather;
      }
      if (oldEvent.isRaceUpdated && !mergeEvent.isRaceUpdated)
        mergeEvent.Race = oldEvent.Race;
      if (oldEvent.isCarUpdated && !mergeEvent.isCarUpdated)
      {
        mergeEvent.isCarUpdated = true;
        mergeEvent.Startcar = oldEvent.Startcar;
        mergeEvent.Endcar = oldEvent.Endcar;
      }
      if (oldEvent.isStrategyUpdated && !mergeEvent.isStrategyUpdated)
        mergeEvent.Strat = oldEvent.Strat;
      if (oldEvent.isSummaryUpdated && !mergeEvent.isSummaryUpdated)
        mergeEvent.Summary = oldEvent.Summary;
      if (oldEvent.isTestingUpdated && !mergeEvent.isTestingUpdated)
        mergeEvent.Test = oldEvent.Test;
      if (oldEvent.isDriverUpdated && !mergeEvent.isDriverUpdated)
        mergeEvent.Driver = oldEvent.Driver;
      if (oldEvent.isStaffUpdated && !mergeEvent.isStaffUpdated)
        mergeEvent.Staff = oldEvent.Staff;
      if (oldEvent.isTechnicalDirectorUpdated && !mergeEvent.isTechnicalDirectorUpdated)
        mergeEvent.TechnicalDirector = oldEvent.TechnicalDirector;
      if (oldEvent.isTyreSupplierUpdated && !mergeEvent.isTyreSupplierUpdated)
        mergeEvent.Tyresupplier = oldEvent.Tyresupplier;
      return mergeEvent;
    }

    public CarHistory2 mergeCarHistory(CarHistory2 mergeCarHistory)
    {
      foreach (CarHistoryItem2 history in this.carHistory.historyList)
      {
        Date date1 = history.date;
        for (int index = 0; index < mergeCarHistory.historyList.Count; ++index)
        {
          Date date2 = ((CarHistoryItem2) mergeCarHistory.historyList[index]).date;
          if (date1.season < date2.season || date1.season == date2.season && date1.race < date2.race)
          {
            mergeCarHistory.historyList.Insert(index, (object) history);
            break;
          }
          if (date1.season == date2.season && date1.race == date2.race)
            break;
        }
      }
      return mergeCarHistory;
    }

    public ArrayList mergeFinancialHistory(ArrayList mergeFinanceHistory)
    {
      foreach (FinanceItem financeItem in this.financeHistory)
      {
        DateTime date1 = financeItem.Date;
        for (int index = 0; index < mergeFinanceHistory.Count; ++index)
        {
          DateTime date2 = ((FinanceItem) mergeFinanceHistory[index]).Date;
          if (date1.CompareTo(date2) > 0)
          {
            mergeFinanceHistory.Insert(index, (object) financeItem);
            break;
          }
          if (date1.Equals(date2))
            break;
        }
      }
      return mergeFinanceHistory;
    }
  }
}
