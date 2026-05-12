using go.Enums;
using go.Utils;
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

#nullable disable
namespace go.Forms
{
  public class FormHandler
  {
    private int iniVersion = 2;
    private Hashtable forms = new Hashtable();
    private bool isDataChanged;
    private ColumnInfoCompare columnInfo = new ColumnInfoCompare();

    public FormHandler() => this.ReadFile();

    ~FormHandler() => this.Save(true);

    public FormInfo GetFormInfo(string FormName)
    {
      return this.forms.ContainsKey((object) FormName) ? (FormInfo) this.forms[(object) FormName] : new FormInfo();
    }

    public void SetFormInfo(string FormName, FormInfo info)
    {
      if (this.forms.ContainsKey((object) FormName))
        this.forms[(object) FormName] = (object) info;
      else
        this.forms.Add((object) FormName, (object) info);
      this.isDataChanged = true;
    }

    public void Save(bool force = false)
    {
      if (!this.isDataChanged)
        return;
      Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GO");
      IFormatter formatter = (IFormatter) new BinaryFormatter()
      {
        Binder = (SerializationBinder) new TypeBinder()
      };
      Stream serializationStream = (Stream) new FileStream(this.GetFileName(), FileMode.Create, FileAccess.Write, FileShare.None);
      try
      {
        formatter.Serialize(serializationStream, (object) this.iniVersion);
        formatter.Serialize(serializationStream, (object) this.forms);
      }
      finally
      {
        serializationStream?.Close();
      }
    }

    public HorizontalAlignment GetColumnAlignment(ColumnInfo col)
    {
      return this.columnInfo.GetAlignment(col);
    }

    public ListViewColumnSorter.CompareManner GetColumnSortOrder(ColumnInfo col)
    {
      return this.columnInfo.GetCompareManner(col);
    }

    public ArrayList GetAvailableColumns(string formName)
    {
      ArrayList al = new ArrayList();
      switch (formName)
      {
        case "AllTracks":
          this.addTrack((IList) al);
          break;
        case "CarHistory":
          al.Add((object) ColumnInfo.StintSeason);
          al.Add((object) ColumnInfo.StintRace);
          this.addCar((IList) al);
          break;
        case "DriverTraining":
          al.Add((object) ColumnInfo.StintSeason);
          al.Add((object) ColumnInfo.StintRace);
          this.addDriver((IList) al);
          al.Add((object) ColumnInfo.DriverTrainingType);
          break;
        case "FuelConsumption":
          al.Add((object) ColumnInfo.StintSeason);
          al.Add((object) ColumnInfo.StintRace);
          this.addTrack((IList) al);
          this.addCar((IList) al);
          this.addStint((IList) al);
          this.addDriver((IList) al);
          this.addRisk((IList) al);
          this.addStaff((IList) al);
          this.addTyreSupplier((IList) al);
          this.addTD((IList) al);
          break;
        case "HistoricalPractice":
          al.Add((object) ColumnInfo.StintRace);
          al.Add((object) ColumnInfo.StintSeason);
          this.addTrack((IList) al);
          this.addCar((IList) al);
          this.addDriver((IList) al);
          this.addStaff((IList) al);
          this.addTyreSupplier((IList) al);
          this.addTD((IList) al);
          al.Add((object) ColumnInfo.PracticeLapTime);
          al.Add((object) ColumnInfo.PracticeDriverMistake);
          al.Add((object) ColumnInfo.PracticeNetTime);
          al.Add((object) ColumnInfo.PracticeFrontWing);
          al.Add((object) ColumnInfo.PracticeRearWing);
          al.Add((object) ColumnInfo.PracticeEngine);
          al.Add((object) ColumnInfo.PracticeBrakes);
          al.Add((object) ColumnInfo.PracticeGear);
          al.Add((object) ColumnInfo.PracticeSuspension);
          al.Add((object) ColumnInfo.PracticeTyreType);
          al.Add((object) ColumnInfo.PracticeWeather);
          al.Add((object) ColumnInfo.PracticeTemperature);
          al.Add((object) ColumnInfo.PracticeHumidity);
          al.Add((object) ColumnInfo.PracticeLapNumber);
          break;
        case "HistoricalQ1Setup":
          al.Add((object) ColumnInfo.StintRace);
          al.Add((object) ColumnInfo.StintSeason);
          this.addTrack((IList) al);
          this.addCar((IList) al);
          this.addDriver((IList) al);
          this.addStaff((IList) al);
          this.addTyreSupplier((IList) al);
          this.addTD((IList) al);
          this.addWear((IList) al);
          al.Add((object) ColumnInfo.Q1SetupFrontWing);
          al.Add((object) ColumnInfo.Q1SetupRearWing);
          al.Add((object) ColumnInfo.Q1SetupEngine);
          al.Add((object) ColumnInfo.Q1SetupBrakes);
          al.Add((object) ColumnInfo.Q1SetupGear);
          al.Add((object) ColumnInfo.Q1SetupSuspension);
          al.Add((object) ColumnInfo.Q1SetupTyreType);
          al.Add((object) ColumnInfo.Q1SetupWeatherTemp);
          al.Add((object) ColumnInfo.Q1SetupWeatherHum);
          al.Add((object) ColumnInfo.Q1SetupWeatherSkies);
          al.Add((object) ColumnInfo.Q1Time);
          break;
        case "HistoricalRaceSetup":
          al.Add((object) ColumnInfo.StintRace);
          al.Add((object) ColumnInfo.StintSeason);
          this.addTrack((IList) al);
          this.addCar((IList) al);
          this.addDriver((IList) al);
          this.addStaff((IList) al);
          this.addTyreSupplier((IList) al);
          this.addTD((IList) al);
          al.Add((object) ColumnInfo.RaceSetupFrontWing);
          al.Add((object) ColumnInfo.RaceSetupFrontWing);
          al.Add((object) ColumnInfo.RaceSetupRearWing);
          al.Add((object) ColumnInfo.RaceSetupEngine);
          al.Add((object) ColumnInfo.RaceSetupBrakes);
          al.Add((object) ColumnInfo.RaceSetupGear);
          al.Add((object) ColumnInfo.RaceSetupSuspension);
          al.Add((object) ColumnInfo.RaceSetupTyreType);
          al.Add((object) ColumnInfo.RaceSetupWeatherMinTemp);
          al.Add((object) ColumnInfo.RaceSetupWeatherMaxTemp);
          al.Add((object) ColumnInfo.RaceSetupWeatherMinHum);
          al.Add((object) ColumnInfo.RaceSetupWeatherMaxHum);
          break;
        case "HistoricalWear":
          al.Add((object) ColumnInfo.StintSeason);
          al.Add((object) ColumnInfo.StintRace);
          this.addTrack((IList) al);
          this.addCar((IList) al);
          this.addDriver((IList) al);
          this.addStaff((IList) al);
          this.addTyreSupplier((IList) al);
          this.addTD((IList) al);
          this.addRisk((IList) al);
          this.addWear((IList) al);
          break;
        case "PitStopsForm":
          al.Add((object) ColumnInfo.StintSeason);
          al.Add((object) ColumnInfo.StintRace);
          this.addTrack((IList) al);
          this.addPit((IList) al);
          this.addDriver((IList) al);
          this.addStaff((IList) al);
          this.addTD((IList) al);
          break;
        case "SeasonForm":
          al.Add((object) ColumnInfo.StintRace);
          this.addTrack((IList) al);
          break;
        case "TyreWear":
          al.Add((object) ColumnInfo.StintSeason);
          al.Add((object) ColumnInfo.StintRace);
          this.addTrack((IList) al);
          this.addCar((IList) al);
          this.addStint((IList) al);
          this.addDriver((IList) al);
          this.addRisk((IList) al);
          this.addStaff((IList) al);
          this.addTyreSupplier((IList) al);
          this.addTD((IList) al);
          break;
      }
      return al;
    }

    private void addWear(IList al)
    {
      al.Add((object) ColumnInfo.CarFrontWingWear);
      al.Add((object) ColumnInfo.CarRearWingWear);
      al.Add((object) ColumnInfo.CarEngineWear);
      al.Add((object) ColumnInfo.CarBrakesWear);
      al.Add((object) ColumnInfo.CarGearboxWear);
      al.Add((object) ColumnInfo.CarSuspensionWear);
      al.Add((object) ColumnInfo.CarChassisWear);
      al.Add((object) ColumnInfo.CarCoolingWear);
      al.Add((object) ColumnInfo.CarElectronicsWear);
      al.Add((object) ColumnInfo.CarSidepodsWear);
      al.Add((object) ColumnInfo.CarUnderbodyWear);
    }

    private void addTyreSupplier(IList al)
    {
      al.Add((object) ColumnInfo.TyreSupplierDryPerf);
      al.Add((object) ColumnInfo.TyreSupplierWetPerf);
      al.Add((object) ColumnInfo.TyreSupplierPeakTemp);
      al.Add((object) ColumnInfo.TyreSupplierDurability);
      al.Add((object) ColumnInfo.TyreSupplierWarmupDist);
    }

    private void addPit(IList al)
    {
      al.Add((object) ColumnInfo.PitFuelLeft);
      al.Add((object) ColumnInfo.PitLap);
      al.Add((object) ColumnInfo.PitReason);
      al.Add((object) ColumnInfo.PitRefilled);
      al.Add((object) ColumnInfo.PitTime);
      al.Add((object) ColumnInfo.PitTyresLeft);
      al.Add((object) ColumnInfo.PitFuelPutOnCar);
      al.Add((object) ColumnInfo.PitSecondsPerLiterFuel);
    }

    private void addStaff(IList al)
    {
      al.Add((object) ColumnInfo.StaffOverall);
      al.Add((object) ColumnInfo.StaffConcentration);
      al.Add((object) ColumnInfo.StaffEfficiency);
      al.Add((object) ColumnInfo.StaffExperience);
      al.Add((object) ColumnInfo.StaffMotivation);
      al.Add((object) ColumnInfo.StaffStressHandling);
      al.Add((object) ColumnInfo.StaffTechnicalSkill);
      al.Add((object) ColumnInfo.StaffAlloyAndChemicalLab);
      al.Add((object) ColumnInfo.StaffCommercial);
      al.Add((object) ColumnInfo.StaffEngineeringWorkshop);
      al.Add((object) ColumnInfo.StaffMaintenance);
      al.Add((object) ColumnInfo.StaffPitstopTrainingCenter);
      al.Add((object) ColumnInfo.StaffRDDesignCenter);
      al.Add((object) ColumnInfo.StaffRDWorkshop);
      al.Add((object) ColumnInfo.StaffSalary);
      al.Add((object) ColumnInfo.StaffWindtunnel);
    }

    private void addRisk(IList al)
    {
      al.Add((object) ColumnInfo.RiskClear);
      al.Add((object) ColumnInfo.RiskWet);
      al.Add((object) ColumnInfo.RiskDefend);
      al.Add((object) ColumnInfo.RiskMalfunction);
      al.Add((object) ColumnInfo.RiskOvertake);
    }

    private void addTD(IList al)
    {
      al.Add((object) ColumnInfo.TechDirectorName);
      al.Add((object) ColumnInfo.TechDirectorAerodynamics);
      al.Add((object) ColumnInfo.TechDirectorElectronics);
      al.Add((object) ColumnInfo.TechDirectorExperience);
      al.Add((object) ColumnInfo.TechDirectorLeadership);
      al.Add((object) ColumnInfo.TechDirectorMechanics);
      al.Add((object) ColumnInfo.TechDirectorMotivation);
      al.Add((object) ColumnInfo.TechDirectorOverall);
      al.Add((object) ColumnInfo.TechDirectorPitCoordination);
    }

    private void addDriver(IList al)
    {
      al.Add((object) ColumnInfo.DriverName);
      al.Add((object) ColumnInfo.DriverOverall);
      al.Add((object) ColumnInfo.DriverConcentration);
      al.Add((object) ColumnInfo.DriverTalent);
      al.Add((object) ColumnInfo.DriverAggresiveness);
      al.Add((object) ColumnInfo.DriverExperience);
      al.Add((object) ColumnInfo.DriverTechnicalInsight);
      al.Add((object) ColumnInfo.DriverStamina);
      al.Add((object) ColumnInfo.DriverCharisma);
      al.Add((object) ColumnInfo.DriverMotivation);
      al.Add((object) ColumnInfo.DriverEnergy);
      al.Add((object) ColumnInfo.DriverWeight);
      al.Add((object) ColumnInfo.DriverAge);
      al.Add((object) ColumnInfo.DriverTrophies);
      al.Add((object) ColumnInfo.DriverNumberofGps);
      al.Add((object) ColumnInfo.DriverWins);
      al.Add((object) ColumnInfo.DriverPodiums);
      al.Add((object) ColumnInfo.DriverPointsScored);
      al.Add((object) ColumnInfo.DriverPolePositions);
      al.Add((object) ColumnInfo.DriverFastestLaps);
      al.Add((object) ColumnInfo.DriverAvPointsPerRace);
      al.Add((object) ColumnInfo.DriverSalary);
      al.Add((object) ColumnInfo.DriverRacesLeft);
    }

    private void addStint(IList al)
    {
      al.Add((object) ColumnInfo.StintMinTemp);
      al.Add((object) ColumnInfo.StintMaxTemp);
      al.Add((object) ColumnInfo.StintAvgTemp);
      al.Add((object) ColumnInfo.StintMinHum);
      al.Add((object) ColumnInfo.StintMaxHum);
      al.Add((object) ColumnInfo.StintAvgHum);
      al.Add((object) ColumnInfo.StintNumber);
      al.Add((object) ColumnInfo.StintLaps);
      al.Add((object) ColumnInfo.StintKm);
      al.Add((object) ColumnInfo.StintFuel);
      al.Add((object) ColumnInfo.StintFuelConsumption);
      al.Add((object) ColumnInfo.StintBadKm);
      al.Add((object) ColumnInfo.StintBadPercent);
      al.Add((object) ColumnInfo.StintFinalPercent);
      al.Add((object) ColumnInfo.StintEstimatedTyreDuration);
      al.Add((object) ColumnInfo.StintTyreType);
      al.Add((object) ColumnInfo.StintWeather);
    }

    private void addCar(IList al)
    {
      al.Add((object) ColumnInfo.CarChassisLevel);
      al.Add((object) ColumnInfo.CarEngineLevel);
      al.Add((object) ColumnInfo.CarFrontWingLevel);
      al.Add((object) ColumnInfo.CarRearWingLevel);
      al.Add((object) ColumnInfo.CarUnderbodyLevel);
      al.Add((object) ColumnInfo.CarSidepodsLevel);
      al.Add((object) ColumnInfo.CarCoolingLevel);
      al.Add((object) ColumnInfo.CarGearboxLevel);
      al.Add((object) ColumnInfo.CarBrakesLevel);
      al.Add((object) ColumnInfo.CarSuspensionLevel);
      al.Add((object) ColumnInfo.CarElectronicsLevel);
      al.Add((object) ColumnInfo.CarPowerLevel);
      al.Add((object) ColumnInfo.CarHandlingLevel);
      al.Add((object) ColumnInfo.CarAccelerationLevel);
    }

    private void addTrack(IList al)
    {
      al.Add((object) ColumnInfo.TrackName);
      al.Add((object) ColumnInfo.TrackDownForce);
      al.Add((object) ColumnInfo.TrackOvertaking);
      al.Add((object) ColumnInfo.TrackSuspensionRigidity);
      al.Add((object) ColumnInfo.TrackFuelConsumption);
      al.Add((object) ColumnInfo.TrackTyreWear);
      al.Add((object) ColumnInfo.TrackLapLength);
      al.Add((object) ColumnInfo.TrackLaps);
      al.Add((object) ColumnInfo.TrackRaceDistance);
      al.Add((object) ColumnInfo.TrackPower);
      al.Add((object) ColumnInfo.TrackHandling);
      al.Add((object) ColumnInfo.TrackAcceleration);
      al.Add((object) ColumnInfo.TrackAvgSpeed);
      al.Add((object) ColumnInfo.TrackNote);
      al.Add((object) ColumnInfo.TrackCorners);
      al.Add((object) ColumnInfo.TrackPitInOutTime);
      al.Add((object) ColumnInfo.TrackGrip);
    }

    private void ReadFile()
    {
      IFormatter formatter = (IFormatter) new BinaryFormatter()
      {
        Binder = (SerializationBinder) new TypeBinder()
      };
      formatter.Binder = (SerializationBinder) new TypeBinder();
      Stream iniStream = this.GetIniStream();
      try
      {
        this.iniVersion = (int) formatter.Deserialize(iniStream);
        if (this.iniVersion == 1)
        {
          this.forms = (Hashtable) formatter.Deserialize(iniStream);
          foreach (string key in (IEnumerable) this.forms.Keys)
            ;
        }
        else
          this.forms = (Hashtable) formatter.Deserialize(iniStream);
      }
      catch
      {
        this.forms = new Hashtable();
      }
      finally
      {
        iniStream?.Close();
      }
    }

    private Stream GetIniStream()
    {
      try
      {
        return (Stream) new FileStream(this.GetFileName(), FileMode.Open, FileAccess.Read, FileShare.Read);
      }
      catch (FileNotFoundException ex1)
      {
        try
        {
          return (Stream) new FileStream("go.ini", FileMode.Open, FileAccess.Read, FileShare.Read);
        }
        catch (FileNotFoundException ex2)
        {
          return (Stream) null;
        }
      }
      catch (DirectoryNotFoundException ex3)
      {
        try
        {
          return (Stream) new FileStream("go.ini", FileMode.Open, FileAccess.Read, FileShare.Read);
        }
        catch (FileNotFoundException ex4)
        {
          return (Stream) null;
        }
      }
    }

    private string GetFileName()
    {
      return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\GO\\go.conf.ini";
    }
  }
}
