// Decompiled with JetBrains decompiler
// Type: go.Utils.EnumToString
// Assembly: go, Version=3.2.21.32438, Culture=neutral, PublicKeyToken=null
// MVID: B03B51CA-999B-45A2-A270-4FB8C2970A64
// Assembly location: C:\Users\rafalcelejewski\AppData\Local\Programs\GPro Organiser\Go.exe

using go.Enums;
using System;

#nullable disable
namespace go.Utils
{
  public static class EnumToString
  {
    public static string Enum2String(Downforce df)
    {
      switch (df)
      {
        case Downforce.Verylow:
          return "Very low";
        case Downforce.Low:
          return "Low";
        case Downforce.Medium:
          return "Medium";
        case Downforce.High:
          return "High";
        case Downforce.VeryHigh:
          return "Very high";
        default:
          return "undefined";
      }
    }

    public static string Enum2String(SponsorPriority sp)
    {
      switch (sp)
      {
        case SponsorPriority.VeryLow:
          return "Very low";
        case SponsorPriority.Low:
          return "Low";
        case SponsorPriority.Medium:
          return "Medium";
        case SponsorPriority.High:
          return "High";
        case SponsorPriority.VeryHigh:
          return "Very high";
        default:
          return "undefined";
      }
    }

    public static string Enum2String(TestPriority tp)
    {
      switch (tp)
      {
        case TestPriority.NoSpecialPriority:
          return "No special priority";
        case TestPriority.TopSpeed:
          return "Top speed";
        case TestPriority.Cornering:
          return "Cornering";
        case TestPriority.Hairpins:
          return "Hairpins";
        case TestPriority.Braking:
          return "Braking";
        case TestPriority.Overtaking:
          return "Overtaking";
        case TestPriority.Chicanes:
          return "Chicanes";
        case TestPriority.TestCarLimits:
          return "Car limits";
        case TestPriority.SetupTuning:
          return "Setup tuning";
        case TestPriority.Unknown:
          return "Unknown";
        default:
          return "undefined";
      }
    }

    public static string Enum2String(Overtaking ov)
    {
      switch (ov)
      {
        case Overtaking.VeryEasy:
          return "Very easy";
        case Overtaking.Easy:
          return "Easy";
        case Overtaking.Normal:
          return "Normal";
        case Overtaking.Hard:
          return "Hard";
        case Overtaking.VeryHard:
          return "Very hard";
        default:
          return "undefined";
      }
    }

    public static string Enum2String(SupensionRigidity su)
    {
      switch (su)
      {
        case SupensionRigidity.VerySoft:
          return "Very soft";
        case SupensionRigidity.Soft:
          return "Soft";
        case SupensionRigidity.Medium:
          return "Medium";
        case SupensionRigidity.Hard:
          return "Hard";
        case SupensionRigidity.VeryHard:
          return "Very hard";
        default:
          return "undefined";
      }
    }

    public static string Enum2String(FuelConsumption fu)
    {
      return EnumToString.Enum2String((Downforce) fu);
    }

    public static string Enum2String(TyreWear ty) => EnumToString.Enum2String((Downforce) ty);

    public static string Enum2String(Grip grip)
    {
      switch (grip)
      {
        case Grip.VeryLow:
          return "Very low";
        case Grip.Low:
          return "Low";
        case Grip.Medium:
          return "Normal";
        case Grip.High:
          return "High";
        case Grip.VeryHigh:
          return "Very high";
        default:
          return "Undefined";
      }
    }

    public static string Enum2String(Skies sk)
    {
      switch (sk)
      {
        case Skies.Rain:
          return "Rain";
        case Skies.VeryCloudy:
          return "Very Cloudy";
        case Skies.Cloudy:
          return "Cloudy";
        case Skies.PartiallyCloudy:
          return "Partially Cloudy";
        case Skies.Sunny:
          return "Sunny";
        default:
          return "Undefined";
      }
    }

    public static string Enum2String(TyreType ty)
    {
      switch (ty)
      {
        case TyreType.ExtraSoft:
          return "Extra Soft";
        case TyreType.Soft:
          return "Soft";
        case TyreType.Medium:
          return "Medium";
        case TyreType.Hard:
          return "Hard";
        case TyreType.Rain:
          return "Rain";
        default:
          return "Unknown";
      }
    }

    public static string Enum2String(QualifyRisk risk)
    {
      switch (risk)
      {
        case QualifyRisk.KeepTheCarOnTheTrack:
          return "Keep the car on the track";
        case QualifyRisk.PushTheCarALittle:
          return "Push the car a little";
        case QualifyRisk.PushTheCarALot:
          return "Push the car a lot";
        case QualifyRisk.PushTheCarToTheLimit:
          return "Push the car to the limit";
        default:
          return "Unknown";
      }
    }

    public static string Enum2String(PitStopReason reason)
    {
      switch (reason)
      {
        case PitStopReason.Fuel:
          return "Out of Fuel";
        case PitStopReason.WeatherChange:
          return "Weather change";
        case PitStopReason.TechnicalProblem:
          return "Technical Problem";
        default:
          return "Tyres";
      }
    }

    public static string Enum2String(RaceStartStrategy strat)
    {
      switch (strat)
      {
        case RaceStartStrategy.AvoidTrouble:
          return "Avoid trouble";
        case RaceStartStrategy.MaintainPosition:
          return "Maintain his position";
        case RaceStartStrategy.Overtake:
          return "Overtake where possible";
        case RaceStartStrategy.ForceTowardsFront:
          return "Force his way to the front";
        default:
          return "Unknown strategy";
      }
    }

    public static string Enum2String(DriverTrainingType type)
    {
      switch (type)
      {
        case DriverTrainingType.None:
          return "None";
        case DriverTrainingType.Yoga:
          return "Yoga";
        case DriverTrainingType.Fitness:
          return "Fitness class";
        case DriverTrainingType.PR:
          return "PR training";
        case DriverTrainingType.Psychologist:
          return "Sports Psychologist";
        case DriverTrainingType.Tech:
          return "Tech training";
        case DriverTrainingType.Ninja:
          return "Ninja classes";
        case DriverTrainingType.Spa:
          return "Spa resort";
        default:
          return "Unknown";
      }
    }

    public static string Enum2String(ColumnInfo info)
    {
      return ColumnInfoData.GetLongStringForColumninfo(info);
    }

    public static string Enum2ShortString(ColumnInfo info)
    {
      return ColumnInfoData.GetShortStringForColumninfo(info);
    }

    public static string Time2PracExportString(TimeSpan time, bool includeMilliSecondsEvenIfZero)
    {
      return EnumToString.Time2String(time, includeMilliSecondsEvenIfZero, true);
    }

    public static string Time2String(TimeSpan time, bool includeMilliSecondsEvenIfZero)
    {
      return EnumToString.Time2String(time, includeMilliSecondsEvenIfZero, false);
    }

    public static string Time2String(
      TimeSpan time,
      bool includeMilliSecondsEvenIfZero,
      bool ignoreEmptyTime)
    {
      string str1 = "";
      if (time == TimeSpan.Zero && !ignoreEmptyTime)
        return "-";
      if (time.Hours > 0)
        str1 = time.Hours.ToString() + "h";
      if (time.Minutes > 0)
        str1 = str1 + time.Minutes.ToString() + ":";
      if (time.Seconds < 10)
        str1 += "0";
      string str2 = str1 + time.Seconds.ToString();
      if (time.Milliseconds > 0 | includeMilliSecondsEvenIfZero)
      {
        string str3 = str2 + ".";
        if (time.Milliseconds < 10)
          str3 += "0";
        if (time.Milliseconds < 100)
          str3 += "0";
        str2 = str3 + time.Milliseconds.ToString();
      }
      return str2;
    }

    public static string Speed2String(float speed)
    {
      return !speed.Equals(0.0f) ? speed.ToString("N2") + " km/h" : "";
    }

    public static string Wage2String(int wage)
    {
      string str1 = wage.ToString();
      string str2 = "";
      for (int index = 0; index < str1.Length; ++index)
      {
        str2 += str1[index].ToString();
        if ((str1.Length - index - 1) % 3 == 0 && index < str1.Length - 1 && str1[index] != '-')
          str2 += ".";
      }
      return str2;
    }
  }
}
