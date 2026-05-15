 
// Type: go.Utils.StringToEnum
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go.Utils
{
  public static class StringToEnum
  {
    public static TyreType String2Tyres(string noget)
    {
      TyreType tyreType;
      switch (noget)
      {
        case "Rain":
          tyreType = TyreType.Rain;
          break;
        case "Hard":
          tyreType = TyreType.Hard;
          break;
        case "Medium":
          tyreType = TyreType.Medium;
          break;
        case "Soft":
          tyreType = TyreType.Soft;
          break;
        case "Extra Soft":
          tyreType = TyreType.ExtraSoft;
          break;
        default:
          tyreType = TyreType.Unknown;
          break;
      }
      return tyreType;
    }

    public static Grip String2Grip(string noget)
    {
      Grip grip;
      switch (noget)
      {
        case "Very high":
          grip = Grip.VeryHigh;
          break;
        case "High":
          grip = Grip.High;
          break;
        case "Normal":
          grip = Grip.Medium;
          break;
        case "Low":
          grip = Grip.Low;
          break;
        case "Very low":
          grip = Grip.VeryLow;
          break;
        default:
          grip = Grip.Unknown;
          break;
      }
      return grip;
    }

    public static TyreWear String2TyreWear(string noget)
    {
      return (TyreWear) StringToEnum.String2Fuel(noget);
    }

    public static FuelConsumption String2Fuel(string noget)
    {
      FuelConsumption fuelConsumption;
      switch (noget)
      {
        case "High":
          fuelConsumption = FuelConsumption.High;
          break;
        case "Medium":
          fuelConsumption = FuelConsumption.Medium;
          break;
        case "Low":
          fuelConsumption = FuelConsumption.Low;
          break;
        case "Very low":
          fuelConsumption = FuelConsumption.VeryLow;
          break;
        default:
          fuelConsumption = FuelConsumption.VeryHigh;
          break;
      }
      return fuelConsumption;
    }

    public static Skies String2Skies(string noget)
    {
      switch (noget)
      {
        case "Sunny":
          return Skies.Sunny;
        case "Very Cloudy":
          return Skies.VeryCloudy;
        case "Cloudy":
          return Skies.Cloudy;
        case "Partially Cloudy":
        case "Partially cloudy":
          return Skies.PartiallyCloudy;
        default:
          return Skies.Rain;
      }
    }

    public static TimeSpan String2Time(string noget)
    {
        if (string.IsNullOrWhiteSpace(noget))
            return TimeSpan.MinValue;
    
        noget = noget.Trim();
    
        int hours = 0;
        int minutes = 0;
        int seconds = 0;
    
        try
        {
            if (noget.EndsWith("s"))
                noget = noget.Substring(0, noget.Length - 1);
    
            int startIndex1 = noget.IndexOf("h") + 1;
    
            if (startIndex1 > 0)
                hours = int.Parse(
                    noget.Substring(0, startIndex1 - 1)
                );
    
            int num = noget.IndexOf(":") + 1;
    
            if (num > 0)
                minutes = int.Parse(
                    noget.Substring(
                        startIndex1,
                        num - startIndex1 - 1
                    )
                );
    
            int startIndex2 = num;
    
            int startIndex3 = noget.IndexOf(".") + 1;
    
            if (startIndex3 > 0)
                seconds = int.Parse(
                    noget.Substring(
                        startIndex2,
                        startIndex3 - startIndex2 - 1
                    )
                );
    
            int milliseconds =
                int.Parse(noget.Substring(startIndex3));
    
            return new TimeSpan(
                0,
                hours,
                minutes,
                seconds,
                milliseconds
            );
        }
        catch
        {
            return TimeSpan.MinValue;
        }
    }

    public static RaceStartStrategy String2Strategy(string noget)
    {
      RaceStartStrategy raceStartStrategy;
      switch (noget)
      {
        case "Overtake where possible":
          raceStartStrategy = RaceStartStrategy.Overtake;
          break;
        case "Maintain his position":
          raceStartStrategy = RaceStartStrategy.MaintainPosition;
          break;
        case "Avoid trouble":
          raceStartStrategy = RaceStartStrategy.AvoidTrouble;
          break;
        default:
          raceStartStrategy = RaceStartStrategy.ForceTowardsFront;
          break;
      }
      return raceStartStrategy;
    }

    public static TestPriority String2Priority(string noget)
    {
      TestPriority testPriority;
      switch (noget)
      {
        case "Braking":
          testPriority = TestPriority.Braking;
          break;
        case "Chicanes":
          testPriority = TestPriority.Chicanes;
          break;
        case "Cornering":
          testPriority = TestPriority.Cornering;
          break;
        case "Hairpins":
          testPriority = TestPriority.Hairpins;
          break;
        case "No special priority":
          testPriority = TestPriority.NoSpecialPriority;
          break;
        case "Overtaking":
          testPriority = TestPriority.Overtaking;
          break;
        case "Setup tuning":
          testPriority = TestPriority.SetupTuning;
          break;
        case "Test car limits":
          testPriority = TestPriority.TestCarLimits;
          break;
        case "Top speed":
          testPriority = TestPriority.TopSpeed;
          break;
        default:
          testPriority = TestPriority.Unknown;
          break;
      }
      return testPriority;
    }

    public static Overtaking String2Overtaking(string noget)
    {
      Overtaking overtaking;
      switch (noget)
      {
        case "Very hard":
          overtaking = Overtaking.VeryHard;
          break;
        case "Hard":
          overtaking = Overtaking.Hard;
          break;
        case "Normal":
          overtaking = Overtaking.Normal;
          break;
        case "Easy":
          overtaking = Overtaking.Easy;
          break;
        case "Very easy":
          overtaking = Overtaking.VeryEasy;
          break;
        default:
          overtaking = Overtaking.VeryEasy;
          break;
      }
      return overtaking;
    }

    public static SupensionRigidity String2Suspension(string noget)
    {
      SupensionRigidity supensionRigidity;
      switch (noget)
      {
        case "Hard":
          supensionRigidity = SupensionRigidity.Hard;
          break;
        case "Medium":
          supensionRigidity = SupensionRigidity.Medium;
          break;
        case "Soft":
          supensionRigidity = SupensionRigidity.Soft;
          break;
        case "Very soft":
          supensionRigidity = SupensionRigidity.VerySoft;
          break;
        default:
          supensionRigidity = SupensionRigidity.VeryHard;
          break;
      }
      return supensionRigidity;
    }

    public static Downforce String2Downforce(string noget)
    {
      Downforce downforce;
      switch (noget)
      {
        case "Very Low":
          downforce = Downforce.Verylow;
          break;
        case "Low":
          downforce = Downforce.Low;
          break;
        case "Medium":
          downforce = Downforce.Medium;
          break;
        case "High":
          downforce = Downforce.High;
          break;
        default:
          downforce = Downforce.VeryHigh;
          break;
      }
      return downforce;
    }

    public static DriverTrainingType String2DriverTrainingType(string noget)
    {
      noget = noget.Substring(23);
      DriverTrainingType driverTrainingType;
      switch (noget)
      {
        case "Yoga":
          driverTrainingType = DriverTrainingType.Yoga;
          break;
        case "Fitness class":
          driverTrainingType = DriverTrainingType.Fitness;
          break;
        case "PR training":
          driverTrainingType = DriverTrainingType.PR;
          break;
        case "Tech training":
          driverTrainingType = DriverTrainingType.Tech;
          break;
        case "Sports psychologist":
          driverTrainingType = DriverTrainingType.Psychologist;
          break;
        case "Ninja classes":
          driverTrainingType = DriverTrainingType.Ninja;
          break;
        default:
          driverTrainingType = DriverTrainingType.Unknown;
          break;
      }
      return driverTrainingType;
    }

    public static SponsorPriority String2SponsorPriority(string noget)
    {
      SponsorPriority sponsorPriority;
      switch (noget)
      {
        case "Very high":
          sponsorPriority = SponsorPriority.VeryHigh;
          break;
        case "High":
          sponsorPriority = SponsorPriority.High;
          break;
        case "Normal":
          sponsorPriority = SponsorPriority.Medium;
          break;
        case "Low":
          sponsorPriority = SponsorPriority.Low;
          break;
        case "Very low":
          sponsorPriority = SponsorPriority.VeryLow;
          break;
        default:
          sponsorPriority = SponsorPriority.Medium;
          break;
      }
      return sponsorPriority;
    }

    public static ColumnInfo String2ColumnType(string noget)
    {
      return ColumnInfoData.GetColumnInfoForLongString(noget);
    }

    public static QualifyRisk String2QualifyRisk(string noget)
    {
      QualifyRisk qualifyRisk;
      switch (noget)
      {
        case "Push the car to the limit":
          qualifyRisk = QualifyRisk.PushTheCarToTheLimit;
          break;
        case "Push the car a lot":
          qualifyRisk = QualifyRisk.PushTheCarALot;
          break;
        case "Push the car a little":
          qualifyRisk = QualifyRisk.PushTheCarALittle;
          break;
        case "Keep the car on the track":
          qualifyRisk = QualifyRisk.KeepTheCarOnTheTrack;
          break;
        default:
          qualifyRisk = QualifyRisk.Unknown;
          break;
      }
      return qualifyRisk;
    }

    public static FinanceItemType GetFinanceItemType(FinanceItem item)
    {
      return StringToEnum.GetFinanceItemType((FinanceItem2) item);
    }

    public static FinanceItemType GetFinanceItemType(FinanceItem2 item)
    {
      string description = item.Description;
      if (description.Contains("Qualify"))
      {
        if (description.Contains("1 lap"))
          return FinanceItemType.Qualifying1;
        return !description.Contains("2 lap") ? FinanceItemType.QualifyingMoney : FinanceItemType.Qualifying2;
      }
      if (description.StartsWith("Practice"))
        return FinanceItemType.PracticeLaps;
      if (description.StartsWith("Race"))
        return !description.Contains("fastest lap") ? FinanceItemType.RaceMoney : FinanceItemType.FastestLap;
      if (description.StartsWith("Sponsor money"))
        return FinanceItemType.Sponsors;
      if (description.StartsWith("Car parts"))
        return FinanceItemType.CarParts;
      if (description.StartsWith("Staff training"))
        return FinanceItemType.StaffTraining;
      if (description.StartsWith("Facility"))
        return !description.Contains("upgrade") && !description.Contains("downgrade") ? FinanceItemType.FacilityCost : FinanceItemType.FacilityUpgrade;
      if (description.StartsWith("Driver training"))
        return FinanceItemType.DriverTraining;
      if (description.StartsWith("Contract compensation"))
      {
        if (description.Contains("driver"))
          return FinanceItemType.DriverCompensation;
        return !description.Contains("director") ? FinanceItemType.Sponsors : FinanceItemType.TDCompensation;
      }
      if (description.StartsWith("Salary for your"))
      {
        if (description.Contains("driver"))
          return FinanceItemType.DriverWage;
        return !description.Contains("staff") ? FinanceItemType.TDWage : FinanceItemType.StaffWage;
      }
      if (description.StartsWith("Signing fee for your new driver") || description.StartsWith("You extended the contract of your driver"))
        return FinanceItemType.DriverSigningFee;
      if (description.StartsWith("You offered a contract to the driver"))
        return FinanceItemType.DriverOffer;
      if (description.StartsWith("End of season"))
      {
        if (description.Contains("for finishing"))
          return FinanceItemType.EndOfSeasonBonus;
        if (description.Contains("team"))
          return FinanceItemType.TeamBonus;
        if (description.Contains("all races"))
          return FinanceItemType.AllRaceBonus;
        return !description.Contains("casual taxes") ? FinanceItemType.PointsBonus : FinanceItemType.CasualTaxes;
      }
      if (description.StartsWith("Testing session costs"))
        return FinanceItemType.TestingSession;
      if (description.StartsWith("Signing fee for your new technical director"))
        return FinanceItemType.TDSigningFee;
      if (description.StartsWith("You offered a contract to the tech director"))
        return FinanceItemType.TDOffer;
      if (description.EndsWith("GPRO Cup"))
        return FinanceItemType.CupEarnings;
      if (description.StartsWith("Tyre supplier"))
        return FinanceItemType.TyreSupplier;
      if (description.StartsWith("Bonus for the race"))
        return !description.Contains("(Driver)") ? FinanceItemType.TDBonus : FinanceItemType.DriverBonus;
      if (description.StartsWith("Selling of facilities"))
        return FinanceItemType.FacilityUpgrade;
      return description.StartsWith("Costs for") ? FinanceItemType.TeamAppliance : FinanceItemType.Unknown;
    }
  }
}
