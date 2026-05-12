 
// Type: go.Utils.ColumnInfoCompare
 
 
 

using go.Enums;
using System.Windows.Forms;

#nullable disable
namespace go.Utils
{
  internal class ColumnInfoCompare
  {
    public ListViewColumnSorter.CompareManner GetCompareManner(ColumnInfo type)
    {
      switch (type)
      {
        case ColumnInfo.Unknown:
        case ColumnInfo.TrackName:
        case ColumnInfo.TrackNote:
        case ColumnInfo.DriverName:
        case ColumnInfo.RaceSkies:
        case ColumnInfo.RacePitStopReason:
        case ColumnInfo.RaceStartStrategy:
        case ColumnInfo.TestPriority:
        case ColumnInfo.FinanceItemType:
        case ColumnInfo.DriverTrainingType:
        case ColumnInfo.StaffTrainingType:
        case ColumnInfo.PitReason:
        case ColumnInfo.PracticeWeather:
        case ColumnInfo.TechDirectorName:
          return ListViewColumnSorter.CompareManner.TEXT;
        case ColumnInfo.TrackDownForce:
          return ListViewColumnSorter.CompareManner.DOWNFORCE;
        case ColumnInfo.TrackOvertaking:
          return ListViewColumnSorter.CompareManner.OVERTAKING;
        case ColumnInfo.TrackSuspensionRigidity:
          return ListViewColumnSorter.CompareManner.SUSPENSION;
        case ColumnInfo.TrackFuelConsumption:
          return ListViewColumnSorter.CompareManner.FUEL_CONSUMPTION;
        case ColumnInfo.TrackTyreWear:
          return ListViewColumnSorter.CompareManner.TYREWEAR;
        case ColumnInfo.TrackLapLength:
        case ColumnInfo.TrackRaceDistance:
        case ColumnInfo.DriverAvPointsPerRace:
        case ColumnInfo.StintAvgTemp:
        case ColumnInfo.StintAvgHum:
        case ColumnInfo.StintKm:
        case ColumnInfo.StintBadKm:
        case ColumnInfo.StintBadPercent:
        case ColumnInfo.StintEstimatedTyreDuration:
        case ColumnInfo.StintFuel:
        case ColumnInfo.StintFuelConsumption:
        case ColumnInfo.TrackPitInOutTime:
        case ColumnInfo.PitTime:
        case ColumnInfo.PitFuelPutOnCar:
        case ColumnInfo.PitSecondsPerLiterFuel:
        case ColumnInfo.SummaryAverageSpeed:
        case ColumnInfo.SummaryBestPitTime:
        case ColumnInfo.SummaryWinnerBestLap:
        case ColumnInfo.SummaryWinnerAverageSpeed:
          return ListViewColumnSorter.CompareManner.Double;
        case ColumnInfo.TrackLaps:
        case ColumnInfo.TrackPower:
        case ColumnInfo.TrackHandling:
        case ColumnInfo.TrackAcceleration:
        case ColumnInfo.TrackAvgSpeed:
        case ColumnInfo.DriverOverall:
        case ColumnInfo.DriverConcentration:
        case ColumnInfo.DriverTalent:
        case ColumnInfo.DriverAggresiveness:
        case ColumnInfo.DriverExperience:
        case ColumnInfo.DriverTechnicalInsight:
        case ColumnInfo.DriverStamina:
        case ColumnInfo.DriverCharisma:
        case ColumnInfo.DriverMotivation:
        case ColumnInfo.DriverWeight:
        case ColumnInfo.DriverAge:
        case ColumnInfo.DriverTrophies:
        case ColumnInfo.DriverNumberofGps:
        case ColumnInfo.DriverWins:
        case ColumnInfo.DriverPodiums:
        case ColumnInfo.DriverPointsScored:
        case ColumnInfo.DriverPolePositions:
        case ColumnInfo.DriverFastestLaps:
        case ColumnInfo.DriverSalary:
        case ColumnInfo.DriverRacesLeft:
        case ColumnInfo.StaffOverall:
        case ColumnInfo.StaffExperience:
        case ColumnInfo.StaffMotivation:
        case ColumnInfo.StaffTechnicalSkill:
        case ColumnInfo.StaffStressHandling:
        case ColumnInfo.StaffConcentration:
        case ColumnInfo.StaffEfficiency:
        case ColumnInfo.StaffWindtunnel:
        case ColumnInfo.StaffPitstopTrainingCenter:
        case ColumnInfo.StaffRDWorkshop:
        case ColumnInfo.StaffRDDesignCenter:
        case ColumnInfo.StaffEngineeringWorkshop:
        case ColumnInfo.StaffAlloyAndChemicalLab:
        case ColumnInfo.StaffCommercial:
        case ColumnInfo.StaffSalary:
        case ColumnInfo.StaffMaintenance:
        case ColumnInfo.CarChassisLevel:
        case ColumnInfo.CarEngineLevel:
        case ColumnInfo.CarFrontWingLevel:
        case ColumnInfo.CarRearWingLevel:
        case ColumnInfo.CarUnderbodyLevel:
        case ColumnInfo.CarSidepodsLevel:
        case ColumnInfo.CarCoolingLevel:
        case ColumnInfo.CarGearboxLevel:
        case ColumnInfo.CarBrakesLevel:
        case ColumnInfo.CarSuspensionLevel:
        case ColumnInfo.CarElectronicsLevel:
        case ColumnInfo.CarPowerLevel:
        case ColumnInfo.CarHandlingLevel:
        case ColumnInfo.CarAccelerationLevel:
        case ColumnInfo.CarChassisWear:
        case ColumnInfo.CarEngineWear:
        case ColumnInfo.CarFrontWingWear:
        case ColumnInfo.CarRearWingWear:
        case ColumnInfo.CarUnderbodyWear:
        case ColumnInfo.CarSidepodsWear:
        case ColumnInfo.CarCoolingWear:
        case ColumnInfo.CarGearboxWear:
        case ColumnInfo.CarBrakesWear:
        case ColumnInfo.CarSuspensionWear:
        case ColumnInfo.CarElectronicsWear:
        case ColumnInfo.StintMinTemp:
        case ColumnInfo.StintMaxTemp:
        case ColumnInfo.StintMinHum:
        case ColumnInfo.StintMaxHum:
        case ColumnInfo.StintSeason:
        case ColumnInfo.StintRace:
        case ColumnInfo.StintNumber:
        case ColumnInfo.StintLaps:
        case ColumnInfo.StintFinalPercent:
        case ColumnInfo.RiskOvertake:
        case ColumnInfo.RiskDefend:
        case ColumnInfo.RiskClear:
        case ColumnInfo.RiskMalfunction:
        case ColumnInfo.PitLap:
        case ColumnInfo.PitTyresLeft:
        case ColumnInfo.PitFuelLeft:
        case ColumnInfo.PitRefilled:
        case ColumnInfo.SummaryPosition:
        case ColumnInfo.SummaryStartPosition:
        case ColumnInfo.SummaryProgress:
        case ColumnInfo.SummaryLaps:
        case ColumnInfo.SummaryPitStops:
        case ColumnInfo.SummaryWinnerPitStops:
        case ColumnInfo.PracticeFrontWing:
        case ColumnInfo.PracticeRearWing:
        case ColumnInfo.PracticeEngine:
        case ColumnInfo.PracticeBrakes:
        case ColumnInfo.PracticeGear:
        case ColumnInfo.PracticeSuspension:
        case ColumnInfo.PracticeTemperature:
        case ColumnInfo.PracticeHumidity:
        case ColumnInfo.PracticeLapNumber:
        case ColumnInfo.TyreSupplierDryPerf:
        case ColumnInfo.TyreSupplierWetPerf:
        case ColumnInfo.TyreSupplierPeakTemp:
        case ColumnInfo.TyreSupplierDurability:
        case ColumnInfo.TyreSupplierWarmupDist:
        case ColumnInfo.TechDirectorOverall:
        case ColumnInfo.TechDirectorLeadership:
        case ColumnInfo.TechDirectorMechanics:
        case ColumnInfo.TechDirectorElectronics:
        case ColumnInfo.TechDirectorAerodynamics:
        case ColumnInfo.TechDirectorExperience:
        case ColumnInfo.TechDirectorPitCoordination:
        case ColumnInfo.TechDirectorMotivation:
        case ColumnInfo.TrackCorners:
          return ListViewColumnSorter.CompareManner.INT32;
        case ColumnInfo.StintTyreType:
        case ColumnInfo.PracticeTyreType:
          return ListViewColumnSorter.CompareManner.TYRETYPE;
        case ColumnInfo.SummaryRaceTime:
        case ColumnInfo.SummaryBestLap:
        case ColumnInfo.SummaryWinnerRaceTime:
        case ColumnInfo.SummaryWinnerBestPitTime:
        case ColumnInfo.PracticeLapTime:
        case ColumnInfo.PracticeDriverMistake:
        case ColumnInfo.PracticeNetTime:
          return ListViewColumnSorter.CompareManner.TIMESPAN;
        case ColumnInfo.TrackGrip:
          return ListViewColumnSorter.CompareManner.GRIP;
        default:
          return ListViewColumnSorter.CompareManner.TEXT;
      }
    }

    public HorizontalAlignment GetAlignment(ColumnInfo type)
    {
      HorizontalAlignment alignment;
      switch (this.GetCompareManner(type))
      {
        case ListViewColumnSorter.CompareManner.TEXT:
          alignment = HorizontalAlignment.Left;
          break;
        case ListViewColumnSorter.CompareManner.INT32:
          alignment = HorizontalAlignment.Right;
          break;
        case ListViewColumnSorter.CompareManner.Double:
          alignment = HorizontalAlignment.Right;
          break;
        case ListViewColumnSorter.CompareManner.TYRETYPE:
          alignment = HorizontalAlignment.Left;
          break;
        case ListViewColumnSorter.CompareManner.TYREWEAR:
          alignment = HorizontalAlignment.Left;
          break;
        case ListViewColumnSorter.CompareManner.DOWNFORCE:
          alignment = HorizontalAlignment.Left;
          break;
        case ListViewColumnSorter.CompareManner.OVERTAKING:
          alignment = HorizontalAlignment.Left;
          break;
        case ListViewColumnSorter.CompareManner.SUSPENSION:
          alignment = HorizontalAlignment.Left;
          break;
        case ListViewColumnSorter.CompareManner.FUEL_CONSUMPTION:
          alignment = HorizontalAlignment.Right;
          break;
        case ListViewColumnSorter.CompareManner.GRIP:
          alignment = HorizontalAlignment.Left;
          break;
        default:
          alignment = HorizontalAlignment.Left;
          break;
      }
      return alignment;
    }
  }
}
