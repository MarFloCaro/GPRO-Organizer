 
// Type: go.Utils.String2Enum
 
 
 

using go.Enums;
using System;

#nullable disable
namespace go.Utils
{
  public static class String2Enum
  {
    public static TyreType String2Tyres(string noget)
    {
      switch (noget.ToLower())
      {
        case "extra soft":
          return TyreType.ExtraSoft;
        case "soft":
          return TyreType.Soft;
        case "medium":
          return TyreType.Medium;
        case "hard":
          return TyreType.Hard;
        case "rain":
          return TyreType.Rain;
        default:
          return TyreType.Unknown;
      }
    }

    public static Grip String2Grip(string noget)
    {
      switch (noget.ToLower())
      {
        case "very low":
          return Grip.VeryLow;
        case "low":
          return Grip.Low;
        case "normal":
          return Grip.Medium;
        case "high":
          return Grip.High;
        case "very high":
          return Grip.VeryHigh;
        default:
          return Grip.Unknown;
      }
    }

    public static TyreWear String2TyreWear(string noget)
    {
      return (TyreWear) String2Enum.String2Fuel(noget);
    }

    public static FuelConsumption String2Fuel(string noget)
    {
      switch (noget.ToLower())
      {
        case "very low":
          return FuelConsumption.VeryLow;
        case "low":
          return FuelConsumption.Low;
        case "medium":
          return FuelConsumption.Medium;
        case "high":
          return FuelConsumption.High;
        default:
          return FuelConsumption.VeryHigh;
      }
    }

    public static Skies String2Skies(string noget)
    {
      switch (noget.ToLower())
      {
        case "partially cloudy":
          return Skies.PartiallyCloudy;
        case "cloudy":
          return Skies.Cloudy;
        case "very cloudy":
          return Skies.VeryCloudy;
        case "sunny":
          return Skies.Sunny;
        default:
          return Skies.Rain;
      }
    }

    public static TimeSpan String2Time(string noget)
    {
      noget = noget.Trim();
      if (noget.Equals(""))
        return new TimeSpan(0L);
      int hours = 0;
      int minutes = 0;
      int seconds = 0;
      try
      {
        if (noget[noget.Length - 1] == 's')
          noget = noget.Substring(0, noget.Length - 1);
        int startIndex1 = noget.IndexOf("h") + 1;
        if (startIndex1 > 0)
          hours = int.Parse(noget.Substring(0, startIndex1 - 1));
        int num = noget.IndexOf(":") + 1;
        if (num > 0)
          minutes = int.Parse(noget.Substring(startIndex1, num - startIndex1 - 1));
        int startIndex2 = num;
        int startIndex3 = noget.IndexOf(".") + 1;
        if (startIndex3 > 0)
          seconds = int.Parse(noget.Substring(startIndex2, startIndex3 - startIndex2 - 1));
        int milliseconds = int.Parse(noget.Substring(startIndex3));
        return new TimeSpan(0, hours, minutes, seconds, milliseconds);
      }
      catch (Exception ex)
      {
        return TimeSpan.MinValue;
      }
    }

    public static RaceStartStrategy String2Strategy(string noget)
    {
      switch (noget.ToLower())
      {
        case "avoid trouble":
          return RaceStartStrategy.AvoidTrouble;
        case "maintain his position":
          return RaceStartStrategy.MaintainPosition;
        case "overtake where possible":
          return RaceStartStrategy.Overtake;
        default:
          return RaceStartStrategy.ForceTowardsFront;
      }
    }

    public static TestPriority String2Priority(string noget)
    {
      switch (noget.ToLower())
      {
        case "braking":
          return TestPriority.Braking;
        case "chicanes":
          return TestPriority.Chicanes;
        case "cornering":
          return TestPriority.Cornering;
        case "hairpins":
          return TestPriority.Hairpins;
        case "no special priority":
          return TestPriority.NoSpecialPriority;
        case "overtaking":
          return TestPriority.Overtaking;
        case "setup tuning":
          return TestPriority.SetupTuning;
        case "test car limits":
          return TestPriority.TestCarLimits;
        case "top speed":
          return TestPriority.TopSpeed;
        default:
          return TestPriority.Unknown;
      }
    }

    public static Overtaking String2Overtaking(string noget)
    {
      switch (noget.ToLower())
      {
        case "very easy":
          return Overtaking.VeryEasy;
        case "easy":
          return Overtaking.Easy;
        case "normal":
          return Overtaking.Normal;
        case "hard":
          return Overtaking.Hard;
        case "very hard":
          return Overtaking.VeryHard;
        default:
          return Overtaking.VeryEasy;
      }
    }

    public static SupensionRigidity String2Suspension(string noget)
    {
      switch (noget.ToLower())
      {
        case "very soft":
          return SupensionRigidity.VerySoft;
        case "soft":
          return SupensionRigidity.Soft;
        case "medium":
          return SupensionRigidity.Medium;
        case "hard":
          return SupensionRigidity.Hard;
        default:
          return SupensionRigidity.VeryHard;
      }
    }

    public static Downforce String2Downforce(string noget)
    {
      switch (noget.ToLower())
      {
        case "high":
          return Downforce.High;
        case "medium":
          return Downforce.Medium;
        case "low":
          return Downforce.Low;
        case "very Low":
          return Downforce.Verylow;
        default:
          return Downforce.VeryHigh;
      }
    }

    public static DriverTrainingType String2DriverTrainingType(string noget)
    {
      noget = noget.Substring(23).ToLower();
      switch (noget)
      {
        case "fitness class":
          return DriverTrainingType.Fitness;
        case "ninja classes":
          return DriverTrainingType.Ninja;
        case "pr training":
          return DriverTrainingType.PR;
        case "spa resort":
          return DriverTrainingType.Spa;
        case "sports psychologist":
          return DriverTrainingType.Psychologist;
        case "tech training":
          return DriverTrainingType.Tech;
        case "yoga":
          return DriverTrainingType.Yoga;
        default:
          return DriverTrainingType.Unknown;
      }
    }

    public static SponsorPriority String2SponsorPriority(string noget)
    {
      switch (noget.ToLower())
      {
        case "very low":
          return SponsorPriority.VeryLow;
        case "low":
          return SponsorPriority.Low;
        case "normal":
          return SponsorPriority.Medium;
        case "high":
          return SponsorPriority.High;
        case "very high":
          return SponsorPriority.VeryHigh;
        default:
          return SponsorPriority.Medium;
      }
    }

    public static ColumnInfo String2ColumnType(string noget)
    {
      return ColumnInfoData.GetColumnInfoForLongString(noget);
    }

    public static QualifyRisk String2QualifyRisk(string noget)
    {
      switch (noget.ToLower())
      {
        case "keep the car on the track":
          return QualifyRisk.KeepTheCarOnTheTrack;
        case "push the car a little":
          return QualifyRisk.PushTheCarALittle;
        case "push the car a lot":
          return QualifyRisk.PushTheCarALot;
        case "push the car to the limit":
          return QualifyRisk.PushTheCarToTheLimit;
        default:
          return QualifyRisk.Unknown;
      }
    }

    public static FinanceItemType GetFinanceItemType(FinanceItem item)
    {
      return String2Enum.GetFinanceItemType((FinanceItem2) item);
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
