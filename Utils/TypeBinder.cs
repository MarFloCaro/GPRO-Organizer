 
// Type: go.Utils.TypeBinder
 
 
 

using go.Enums;
using System;
using System.Runtime.Serialization;

#nullable disable
namespace go.Utils
{
  internal class TypeBinder : SerializationBinder
  {
    public override Type BindToType(string assemblyName, string typeName)
    {
      Type type;
      switch (typeName)
      {
        case "go.CarPartType":
          type = typeof (CarPartType);
          break;
        case "go.Category":
          type = typeof (Category);
          break;
        case "go.ColumnInfo":
          type = typeof (ColumnInfo);
          break;
        case "go.Downforce":
          type = typeof (Downforce);
          break;
        case "go.DriverInfo":
          type = typeof (DriverInfo);
          break;
        case "go.DriverTrainingType":
          type = typeof (DriverTrainingType);
          break;
        case "go.Entities.DriverEnergy":
          type = typeof (DriverEnergy);
          break;
        case "go.Entities.FinanceItem":
          type = typeof (FinanceItem);
          break;
        case "go.Entities.Manager":
          type = typeof (Manager);
          break;
        case "go.Entities.OvertakingAttempts":
          type = typeof (OvertakingAttempts);
          break;
        case "go.Entities.RaceSummary":
          type = typeof (RaceSummary);
          break;
        case "go.Entities.RaceSummaryLine":
          type = typeof (RaceSummaryLine);
          break;
        case "go.Entities.RaceWeather":
          type = typeof (RaceWeather);
          break;
        case "go.Entities.Staff":
          type = typeof (Staff);
          break;
        case "go.Entities.TechnicalDirector":
          type = typeof (TechnicalDirector);
          break;
        case "go.Entities.Testing":
          type = typeof (Testing);
          break;
        case "go.Entities.TestingPoints":
          type = typeof (TestingPoints);
          break;
        case "go.Entities.TestingRun":
          type = typeof (TestingRun);
          break;
        case "go.Entities.TyreSupplier":
          type = typeof (TyreSupplier);
          break;
        case "go.Entities.WeatherForecast":
          type = typeof (WeatherForecast);
          break;
        case "go.FinanceItemType":
          type = typeof (FinanceItemType);
          break;
        case "go.FuelConsumption":
          type = typeof (FuelConsumption);
          break;
        case "go.Grip":
          type = typeof (Grip);
          break;
        case "go.Overtaking":
          type = typeof (Overtaking);
          break;
        case "go.PitStopReason":
          type = typeof (PitStopReason);
          break;
        case "go.QualifyRisk":
          type = typeof (QualifyRisk);
          break;
        case "go.RaceStartStrategy":
          type = typeof (RaceStartStrategy);
          break;
        case "go.Skies":
          type = typeof (Skies);
          break;
        case "go.SponsorPriority":
          type = typeof (SponsorPriority);
          break;
        case "go.StaffTrainingType":
          type = typeof (StaffTrainingType);
          break;
        case "go.StaffType":
          type = typeof (StaffType);
          break;
        case "go.SupensionRigidity":
          type = typeof (SupensionRigidity);
          break;
        case "go.TechnicalDirectorInfo":
          type = typeof (TechnicalDirectorInfo);
          break;
        case "go.TestPriority":
          type = typeof (TestPriority);
          break;
        case "go.TyreType":
          type = typeof (TyreType);
          break;
        case "go.TyreWear":
          type = typeof (TyreWear);
          break;
        default:
          type = (Type) null;
          break;
      }
      return type;
    }
  }
}
