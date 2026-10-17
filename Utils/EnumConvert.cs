using go.Enums;
using System;
using System.Collections.Generic;

#nullable disable
namespace go.Utils
{
    public static class EnumConvert
    {
        #region Downforce

        private static readonly Dictionary<string, Downforce> _toDownforce = new Dictionary<string, Downforce>(StringComparer.OrdinalIgnoreCase)
        {
            ["Very low"] = Downforce.Verylow,
            ["Low"] = Downforce.Low,
            ["Medium"] = Downforce.Medium,
            ["High"] = Downforce.High,
            ["Very high"] = Downforce.VeryHigh,
        };

        private static readonly Dictionary<Downforce, string> _fromDownforce = new Dictionary<Downforce, string>()
        {
            [Downforce.Verylow] = "Very low",
            [Downforce.Low] = "Low",
            [Downforce.Medium] = "Medium",
            [Downforce.High] = "High",
            [Downforce.VeryHigh] = "Very high",
        };

        public static string Enum2String(Downforce df) =>
            _fromDownforce.TryGetValue(df, out var s) ? s : "undefined";

        public static Downforce String2Downforce(string noget) =>
            _toDownforce.TryGetValue(noget, out var v) ? v : Downforce.VeryHigh;

        #endregion

        #region FuelConsumption

        private static readonly Dictionary<string, FuelConsumption> _toFuel = new Dictionary<string, FuelConsumption>(StringComparer.OrdinalIgnoreCase)
        {
            ["Very low"] = FuelConsumption.VeryLow,
            ["Low"] = FuelConsumption.Low,
            ["Medium"] = FuelConsumption.Medium,
            ["High"] = FuelConsumption.High,
            ["Very high"] = FuelConsumption.VeryHigh,
        };

        private static readonly Dictionary<FuelConsumption, string> _fromFuel = new Dictionary<FuelConsumption, string>()
        {
            [FuelConsumption.VeryLow] = "Very low",
            [FuelConsumption.Low] = "Low",
            [FuelConsumption.Medium] = "Medium",
            [FuelConsumption.High] = "High",
            [FuelConsumption.VeryHigh] = "Very high",
        };

        public static string Enum2String(FuelConsumption fu) =>
            _fromFuel.TryGetValue(fu, out var s) ? s : "undefined";

        public static FuelConsumption String2Fuel(string noget) =>
            _toFuel.TryGetValue(noget, out var v) ? v : FuelConsumption.VeryHigh;

        #endregion

        #region TyreWear

        private static readonly Dictionary<string, TyreWear> _toTyreWear = new Dictionary<string, TyreWear>(StringComparer.OrdinalIgnoreCase)
        {
            ["Very low"] = TyreWear.VeryLow,
            ["Low"] = TyreWear.Low,
            ["Medium"] = TyreWear.Medium,
            ["High"] = TyreWear.High,
            ["Very high"] = TyreWear.VeryHigh,
        };

        private static readonly Dictionary<TyreWear, string> _fromTyreWear = new Dictionary<TyreWear, string>()
        {
            [TyreWear.VeryLow] = "Very low",
            [TyreWear.Low] = "Low",
            [TyreWear.Medium] = "Medium",
            [TyreWear.High] = "High",
            [TyreWear.VeryHigh] = "Very high",
        };

        public static string Enum2String(TyreWear ty) =>
            _fromTyreWear.TryGetValue(ty, out var s) ? s : "undefined";

        public static TyreWear String2TyreWear(string noget) =>
            _toTyreWear.TryGetValue(noget, out var v) ? v : TyreWear.VeryHigh;

        #endregion

        #region Grip

        private static readonly Dictionary<string, Grip> _toGrip = new Dictionary<string, Grip>(StringComparer.OrdinalIgnoreCase)
        {
            ["Very low"] = Grip.VeryLow,
            ["Low"] = Grip.Low,
            ["Normal"] = Grip.Medium,
            ["High"] = Grip.High,
            ["Very high"] = Grip.VeryHigh,
        };

        private static readonly Dictionary<Grip, string> _fromGrip = new Dictionary<Grip, string>()
        {
            [Grip.VeryLow] = "Very low",
            [Grip.Low] = "Low",
            [Grip.Medium] = "Normal",
            [Grip.High] = "High",
            [Grip.VeryHigh] = "Very high",
        };

        public static string Enum2String(Grip grip) =>
            _fromGrip.TryGetValue(grip, out var s) ? s : "Undefined";

        public static Grip String2Grip(string noget) =>
            _toGrip.TryGetValue(noget, out var v) ? v : Grip.Unknown;

        #endregion

        #region Skies

        private static readonly Dictionary<string, Skies> _toSkies = new Dictionary<string, Skies>(StringComparer.OrdinalIgnoreCase)
        {
            ["Sunny"] = Skies.Sunny,
            ["Partially Cloudy"] = Skies.PartiallyCloudy,
            ["Cloudy"] = Skies.Cloudy,
            ["Very Cloudy"] = Skies.VeryCloudy,
            ["Rain"] = Skies.Rain,
        };

        private static readonly Dictionary<Skies, string> _fromSkies = new Dictionary<Skies, string>()
        {
            [Skies.Sunny] = "Sunny",
            [Skies.PartiallyCloudy] = "Partially Cloudy",
            [Skies.Cloudy] = "Cloudy",
            [Skies.VeryCloudy] = "Very Cloudy",
            [Skies.Rain] = "Rain",
        };

        public static string Enum2String(Skies sk) =>
            _fromSkies.TryGetValue(sk, out var s) ? s : "Undefined";

        public static Skies String2Skies(string noget) =>
            _toSkies.TryGetValue(noget, out var v) ? v : Skies.Rain;

        #endregion

        #region TyreType

        private static readonly Dictionary<string, TyreType> _toTyreType = new Dictionary<string, TyreType>(StringComparer.OrdinalIgnoreCase)
        {
            ["Extra Soft"] = TyreType.ExtraSoft,
            ["Soft"] = TyreType.Soft,
            ["Medium"] = TyreType.Medium,
            ["Hard"] = TyreType.Hard,
            ["Rain"] = TyreType.Rain,
        };

        private static readonly Dictionary<TyreType, string> _fromTyreType = new Dictionary<TyreType, string>()
        {
            [TyreType.ExtraSoft] = "Extra Soft",
            [TyreType.Soft] = "Soft",
            [TyreType.Medium] = "Medium",
            [TyreType.Hard] = "Hard",
            [TyreType.Rain] = "Rain",
        };

        public static string Enum2String(TyreType ty) =>
            _fromTyreType.TryGetValue(ty, out var s) ? s : "Unknown";

        public static TyreType String2Tyres(string noget) =>
            _toTyreType.TryGetValue(noget, out var v) ? v : TyreType.Unknown;

        #endregion

        #region Overtaking

        private static readonly Dictionary<string, Overtaking> _toOvertaking = new Dictionary<string, Overtaking>(StringComparer.OrdinalIgnoreCase)
        {
            ["Very easy"] = Overtaking.VeryEasy,
            ["Easy"] = Overtaking.Easy,
            ["Normal"] = Overtaking.Normal,
            ["Hard"] = Overtaking.Hard,
            ["Very hard"] = Overtaking.VeryHard,
        };

        private static readonly Dictionary<Overtaking, string> _fromOvertaking = new Dictionary<Overtaking, string>()
        {
            [Overtaking.VeryEasy] = "Very easy",
            [Overtaking.Easy] = "Easy",
            [Overtaking.Normal] = "Normal",
            [Overtaking.Hard] = "Hard",
            [Overtaking.VeryHard] = "Very hard",
        };

        public static string Enum2String(Overtaking ov) =>
            _fromOvertaking.TryGetValue(ov, out var s) ? s : "undefined";

        public static Overtaking String2Overtaking(string noget) =>
            _toOvertaking.TryGetValue(noget, out var v) ? v : Overtaking.VeryEasy;

        #endregion

        #region SupensionRigidity

        private static readonly Dictionary<string, SupensionRigidity> _toSuspension = new Dictionary<string, SupensionRigidity>(StringComparer.OrdinalIgnoreCase)
        {
            ["Very soft"] = SupensionRigidity.VerySoft,
            ["Soft"] = SupensionRigidity.Soft,
            ["Medium"] = SupensionRigidity.Medium,
            ["Hard"] = SupensionRigidity.Hard,
            ["Very hard"] = SupensionRigidity.VeryHard,
        };

        private static readonly Dictionary<SupensionRigidity, string> _fromSuspension = new Dictionary<SupensionRigidity, string>()
        {
            [SupensionRigidity.VerySoft] = "Very soft",
            [SupensionRigidity.Soft] = "Soft",
            [SupensionRigidity.Medium] = "Medium",
            [SupensionRigidity.Hard] = "Hard",
            [SupensionRigidity.VeryHard] = "Very hard",
        };

        public static string Enum2String(SupensionRigidity su) =>
            _fromSuspension.TryGetValue(su, out var s) ? s : "undefined";

        public static SupensionRigidity String2Suspension(string noget) =>
            _toSuspension.TryGetValue(noget, out var v) ? v : SupensionRigidity.VeryHard;

        #endregion

        #region SponsorPriority

        private static readonly Dictionary<string, SponsorPriority> _toSponsorPriority = new Dictionary<string, SponsorPriority>(StringComparer.OrdinalIgnoreCase)
        {
            ["Very low"] = SponsorPriority.VeryLow,
            ["Low"] = SponsorPriority.Low,
            ["Medium"] = SponsorPriority.Medium,
            ["Normal"] = SponsorPriority.Medium,
            ["High"] = SponsorPriority.High,
            ["Very high"] = SponsorPriority.VeryHigh,
        };

        private static readonly Dictionary<SponsorPriority, string> _fromSponsorPriority = new Dictionary<SponsorPriority, string>()
        {
            [SponsorPriority.VeryLow] = "Very low",
            [SponsorPriority.Low] = "Low",
            [SponsorPriority.Medium] = "Medium",
            [SponsorPriority.High] = "High",
            [SponsorPriority.VeryHigh] = "Very high",
        };

        public static string Enum2String(SponsorPriority sp) =>
            _fromSponsorPriority.TryGetValue(sp, out var s) ? s : "undefined";

        public static SponsorPriority String2SponsorPriority(string noget) =>
            _toSponsorPriority.TryGetValue(noget, out var v) ? v : SponsorPriority.Medium;

        #endregion

        #region TestPriority

        private static readonly Dictionary<string, TestPriority> _toTestPriority = new Dictionary<string, TestPriority>(StringComparer.OrdinalIgnoreCase)
        {
            ["No special priority"] = TestPriority.NoSpecialPriority,
            ["Top speed"] = TestPriority.TopSpeed,
            ["Cornering"] = TestPriority.Cornering,
            ["Hairpins"] = TestPriority.Hairpins,
            ["Braking"] = TestPriority.Braking,
            ["Overtaking"] = TestPriority.Overtaking,
            ["Chicanes"] = TestPriority.Chicanes,
            ["Test car limits"] = TestPriority.TestCarLimits,
            ["Car limits"] = TestPriority.TestCarLimits,
            ["Setup tuning"] = TestPriority.SetupTuning,
        };

        private static readonly Dictionary<TestPriority, string> _fromTestPriority = new Dictionary<TestPriority, string>()
        {
            [TestPriority.NoSpecialPriority] = "No special priority",
            [TestPriority.TopSpeed] = "Top speed",
            [TestPriority.Cornering] = "Cornering",
            [TestPriority.Hairpins] = "Hairpins",
            [TestPriority.Braking] = "Braking",
            [TestPriority.Overtaking] = "Overtaking",
            [TestPriority.Chicanes] = "Chicanes",
            [TestPriority.TestCarLimits] = "Car limits",
            [TestPriority.SetupTuning] = "Setup tuning",
            [TestPriority.Unknown] = "Unknown",
        };

        public static string Enum2String(TestPriority tp) =>
            _fromTestPriority.TryGetValue(tp, out var s) ? s : "undefined";

        public static TestPriority String2Priority(string noget) =>
            _toTestPriority.TryGetValue(noget, out var v) ? v : TestPriority.Unknown;

        #endregion

        #region QualifyRisk

        private static readonly Dictionary<string, QualifyRisk> _toQualifyRisk = new Dictionary<string, QualifyRisk>(StringComparer.OrdinalIgnoreCase)
        {
            ["Keep the car on the track"] = QualifyRisk.KeepTheCarOnTheTrack,
            ["Push the car a little"] = QualifyRisk.PushTheCarALittle,
            ["Push the car a lot"] = QualifyRisk.PushTheCarALot,
            ["Push the car to the limit"] = QualifyRisk.PushTheCarToTheLimit,
        };

        private static readonly Dictionary<QualifyRisk, string> _fromQualifyRisk = new Dictionary<QualifyRisk, string>()
        {
            [QualifyRisk.KeepTheCarOnTheTrack] = "Keep the car on the track",
            [QualifyRisk.PushTheCarALittle] = "Push the car a little",
            [QualifyRisk.PushTheCarALot] = "Push the car a lot",
            [QualifyRisk.PushTheCarToTheLimit] = "Push the car to the limit",
        };

        public static string Enum2String(QualifyRisk risk) =>
            _fromQualifyRisk.TryGetValue(risk, out var s) ? s : "Unknown";

        public static QualifyRisk String2QualifyRisk(string noget) =>
            _toQualifyRisk.TryGetValue(noget, out var v) ? v : QualifyRisk.Unknown;

        #endregion

        #region RaceStartStrategy

        private static readonly Dictionary<string, RaceStartStrategy> _toStrategy = new Dictionary<string, RaceStartStrategy>(StringComparer.OrdinalIgnoreCase)
        {
            ["Avoid trouble"] = RaceStartStrategy.AvoidTrouble,
            ["Maintain his position"] = RaceStartStrategy.MaintainPosition,
            ["Overtake where possible"] = RaceStartStrategy.Overtake,
            ["Force his way to the front"] = RaceStartStrategy.ForceTowardsFront,
        };

        private static readonly Dictionary<RaceStartStrategy, string> _fromStrategy = new Dictionary<RaceStartStrategy, string>()
        {
            [RaceStartStrategy.AvoidTrouble] = "Avoid trouble",
            [RaceStartStrategy.MaintainPosition] = "Maintain his position",
            [RaceStartStrategy.Overtake] = "Overtake where possible",
            [RaceStartStrategy.ForceTowardsFront] = "Force his way to the front",
        };

        public static string Enum2String(RaceStartStrategy strat) =>
            _fromStrategy.TryGetValue(strat, out var s) ? s : "Unknown strategy";

        public static RaceStartStrategy String2Strategy(string noget) =>
            _toStrategy.TryGetValue(noget, out var v) ? v : RaceStartStrategy.ForceTowardsFront;

        #endregion

        #region PitStopReason

        private static readonly Dictionary<PitStopReason, string> _fromPitStopReason = new Dictionary<PitStopReason, string>()
        {
            [PitStopReason.Fuel] = "Out of Fuel",
            [PitStopReason.WeatherChange] = "Weather change",
            [PitStopReason.TechnicalProblem] = "Technical Problem",
            [PitStopReason.WornTyres] = "Tyres",
        };

        public static string Enum2String(PitStopReason reason) =>
            _fromPitStopReason.TryGetValue(reason, out var s) ? s : "Tyres";

        #endregion

        #region DriverTrainingType

        private static readonly Dictionary<string, DriverTrainingType> _toDriverTraining = new Dictionary<string, DriverTrainingType>(StringComparer.OrdinalIgnoreCase)
        {
            ["None"] = DriverTrainingType.None,
            ["Yoga"] = DriverTrainingType.Yoga,
            ["Fitness class"] = DriverTrainingType.Fitness,
            ["PR training"] = DriverTrainingType.PR,
            ["Sports Psychologist"] = DriverTrainingType.Psychologist,
            ["Tech training"] = DriverTrainingType.Tech,
            ["Ninja classes"] = DriverTrainingType.Ninja,
            ["Spa resort"] = DriverTrainingType.Spa,
        };

        private static readonly Dictionary<DriverTrainingType, string> _fromDriverTraining = new Dictionary<DriverTrainingType, string>()
        {
            [DriverTrainingType.None] = "None",
            [DriverTrainingType.Yoga] = "Yoga",
            [DriverTrainingType.Fitness] = "Fitness class",
            [DriverTrainingType.PR] = "PR training",
            [DriverTrainingType.Psychologist] = "Sports Psychologist",
            [DriverTrainingType.Tech] = "Tech training",
            [DriverTrainingType.Ninja] = "Ninja classes",
            [DriverTrainingType.Spa] = "Spa resort",
        };

        public static string Enum2String(DriverTrainingType type) =>
            _fromDriverTraining.TryGetValue(type, out var s) ? s : "Unknown";

        public static DriverTrainingType String2DriverTrainingType(string noget)
        {
            noget = noget.Substring(23);
            return _toDriverTraining.TryGetValue(noget, out var v) ? v : DriverTrainingType.Unknown;
        }

        #endregion

        #region ColumnInfo

        public static string Enum2String(ColumnInfo info) =>
            ColumnInfoData.GetLongStringForColumninfo(info);

        public static string Enum2ShortString(ColumnInfo info) =>
            ColumnInfoData.GetShortStringForColumninfo(info);

        public static ColumnInfo String2ColumnType(string noget) =>
            ColumnInfoData.GetColumnInfoForLongString(noget);

        #endregion

        #region Time utilities

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
            catch
            {
                return TimeSpan.MinValue;
            }
        }

        public static string Time2PracExportString(TimeSpan time, bool includeMilliSecondsEvenIfZero) =>
            Time2String(time, includeMilliSecondsEvenIfZero, true);

        public static string Time2String(TimeSpan time, bool includeMilliSecondsEvenIfZero) =>
            Time2String(time, includeMilliSecondsEvenIfZero, false);

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

        #endregion

        #region Other utilities

        public static string Speed2String(float speed) =>
            !speed.Equals(0.0f) ? speed.ToString("N2") + " km/h" : "";

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

        #endregion

        #region FinanceItemType

        public static FinanceItemType GetFinanceItemType(FinanceItem item) =>
            GetFinanceItemType((FinanceItem2) item);

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

        #endregion
    }
}
