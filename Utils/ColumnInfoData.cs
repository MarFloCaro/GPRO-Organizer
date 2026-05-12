 
// Type: go.Utils.ColumnInfoData
 
 
 

using go.Enums;
using System.Collections.Generic;

#nullable disable
namespace go.Utils
{
  internal class ColumnInfoData
  {
    private static Dictionary<ColumnInfo, string> infoToLongText = new Dictionary<ColumnInfo, string>();
    private static Dictionary<ColumnInfo, string> infoToShortText = new Dictionary<ColumnInfo, string>();
    private static Dictionary<string, ColumnInfo> longTextToInfo = new Dictionary<string, ColumnInfo>();
    private static bool initialized;

    public static void initialize()
    {
      if (ColumnInfoData.initialized)
        return;
      ColumnInfoData columnInfoData1 = new ColumnInfoData(ColumnInfo.CarAccelerationLevel, "Car Acceleration", "Acceleration");
      ColumnInfoData columnInfoData2 = new ColumnInfoData(ColumnInfo.CarBrakesLevel, "Car Brakes Level", "Brakes");
      ColumnInfoData columnInfoData3 = new ColumnInfoData(ColumnInfo.CarBrakesWear, "Car Brakes Wear", "Brakes Wear");
      ColumnInfoData columnInfoData4 = new ColumnInfoData(ColumnInfo.CarChassisLevel, "Car Chassis Level", "Chassis");
      ColumnInfoData columnInfoData5 = new ColumnInfoData(ColumnInfo.CarChassisWear, "Car Chassis Wear", "Chassis Wear");
      ColumnInfoData columnInfoData6 = new ColumnInfoData(ColumnInfo.CarCoolingLevel, "Car Cooling Level", "Cooling");
      ColumnInfoData columnInfoData7 = new ColumnInfoData(ColumnInfo.CarCoolingWear, "Car Cooling Wear", "Cooling Wear");
      ColumnInfoData columnInfoData8 = new ColumnInfoData(ColumnInfo.CarElectronicsLevel, "Car Electronics Level", "Electronics");
      ColumnInfoData columnInfoData9 = new ColumnInfoData(ColumnInfo.CarElectronicsWear, "Car Electronics Wear", "Electronics Wear");
      ColumnInfoData columnInfoData10 = new ColumnInfoData(ColumnInfo.CarEngineLevel, "Car Engine Level", "Engine");
      ColumnInfoData columnInfoData11 = new ColumnInfoData(ColumnInfo.CarEngineWear, "Car Engine Wear", "Engine Wear");
      ColumnInfoData columnInfoData12 = new ColumnInfoData(ColumnInfo.CarFrontWingLevel, "Car Front Wing Level", "Front Wing");
      ColumnInfoData columnInfoData13 = new ColumnInfoData(ColumnInfo.CarFrontWingWear, "Car Front Wing Wear", "Front Wing Wear");
      ColumnInfoData columnInfoData14 = new ColumnInfoData(ColumnInfo.CarGearboxLevel, "Car Gearbox Level", "Gearbox");
      ColumnInfoData columnInfoData15 = new ColumnInfoData(ColumnInfo.CarGearboxWear, "Car Gearbox Wear", "Gearbox Wear");
      ColumnInfoData columnInfoData16 = new ColumnInfoData(ColumnInfo.CarHandlingLevel, "Car Handling", "Handling");
      ColumnInfoData columnInfoData17 = new ColumnInfoData(ColumnInfo.CarPowerLevel, "Car Power", "Power");
      ColumnInfoData columnInfoData18 = new ColumnInfoData(ColumnInfo.CarRearWingLevel, "Car Rear Wing Level", "Rear Wing");
      ColumnInfoData columnInfoData19 = new ColumnInfoData(ColumnInfo.CarRearWingWear, "Car Rear Wing Wear", "Rear Wing Wear");
      ColumnInfoData columnInfoData20 = new ColumnInfoData(ColumnInfo.CarSidepodsLevel, "Car Sidepods Level", "Sidepods");
      ColumnInfoData columnInfoData21 = new ColumnInfoData(ColumnInfo.CarSidepodsWear, "Car Sidepods Wear", "Sidepods Wear");
      ColumnInfoData columnInfoData22 = new ColumnInfoData(ColumnInfo.CarSuspensionLevel, "Car Suspension Level", "Suspension");
      ColumnInfoData columnInfoData23 = new ColumnInfoData(ColumnInfo.CarSuspensionWear, "Car Suspension Wear", "Suspension Wear");
      ColumnInfoData columnInfoData24 = new ColumnInfoData(ColumnInfo.CarUnderbodyLevel, "Car Underbody Level", "Underbody");
      ColumnInfoData columnInfoData25 = new ColumnInfoData(ColumnInfo.CarUnderbodyWear, "Car Underbody Wear", "Underbody Wear");
      ColumnInfoData columnInfoData26 = new ColumnInfoData(ColumnInfo.DriverAge, "Driver Age", "Age");
      ColumnInfoData columnInfoData27 = new ColumnInfoData(ColumnInfo.DriverAggresiveness, "Driver Aggresiveness", "Aggresiveness");
      ColumnInfoData columnInfoData28 = new ColumnInfoData(ColumnInfo.DriverAvPointsPerRace, "Driver Avg. Points/Race", "Avg. Points/Race");
      ColumnInfoData columnInfoData29 = new ColumnInfoData(ColumnInfo.DriverCharisma, "Driver Charisma", "Charisma");
      ColumnInfoData columnInfoData30 = new ColumnInfoData(ColumnInfo.DriverConcentration, "Driver Concentration", "Concentration");
      ColumnInfoData columnInfoData31 = new ColumnInfoData(ColumnInfo.DriverExperience, "Driver Experience", "Experience");
      ColumnInfoData columnInfoData32 = new ColumnInfoData(ColumnInfo.DriverFastestLaps, "Driver Fastest Laps", "Fastest Laps");
      ColumnInfoData columnInfoData33 = new ColumnInfoData(ColumnInfo.DriverMotivation, "Driver Motivation", "Motivation");
      ColumnInfoData columnInfoData34 = new ColumnInfoData(ColumnInfo.DriverEnergy, "Driver Energy", "Energy");
      ColumnInfoData columnInfoData35 = new ColumnInfoData(ColumnInfo.DriverName, "Driver Name", "Name");
      ColumnInfoData columnInfoData36 = new ColumnInfoData(ColumnInfo.DriverNumberofGps, "Driver Number of GPs", "Number of GPs");
      ColumnInfoData columnInfoData37 = new ColumnInfoData(ColumnInfo.DriverOverall, "Driver Overall", "Overall");
      ColumnInfoData columnInfoData38 = new ColumnInfoData(ColumnInfo.DriverPodiums, "Driver Podiums", "Podiums");
      ColumnInfoData columnInfoData39 = new ColumnInfoData(ColumnInfo.DriverPointsScored, "Driver Points Scored", "Points Scored");
      ColumnInfoData columnInfoData40 = new ColumnInfoData(ColumnInfo.DriverPolePositions, "Driver Pole Positions", "Pole Positions");
      ColumnInfoData columnInfoData41 = new ColumnInfoData(ColumnInfo.DriverRacesLeft, "Driver Races Left", "Races Left");
      ColumnInfoData columnInfoData42 = new ColumnInfoData(ColumnInfo.DriverSalary, "Driver Salary", "Salary");
      ColumnInfoData columnInfoData43 = new ColumnInfoData(ColumnInfo.DriverStamina, "Driver Stamina", "Stamina");
      ColumnInfoData columnInfoData44 = new ColumnInfoData(ColumnInfo.DriverTalent, "Driver Talent", "Talent");
      ColumnInfoData columnInfoData45 = new ColumnInfoData(ColumnInfo.DriverTechnicalInsight, "Driver Tech. Insight", "Tech. Insight");
      ColumnInfoData columnInfoData46 = new ColumnInfoData(ColumnInfo.DriverTrainingType, "Driver Training Type", "Training Type");
      ColumnInfoData columnInfoData47 = new ColumnInfoData(ColumnInfo.DriverTrophies, "Driver Trophies", "Trophies");
      ColumnInfoData columnInfoData48 = new ColumnInfoData(ColumnInfo.DriverWeight, "Driver Weight", "Weight");
      ColumnInfoData columnInfoData49 = new ColumnInfoData(ColumnInfo.DriverWins, "Driver Wins", "Wins");
      ColumnInfoData columnInfoData50 = new ColumnInfoData(ColumnInfo.FinanceItemType, "Financial Item Type", "Financial Item Type");
      ColumnInfoData columnInfoData51 = new ColumnInfoData(ColumnInfo.PitFuelLeft, "Pit Fuel Left", "Fuel Left");
      ColumnInfoData columnInfoData52 = new ColumnInfoData(ColumnInfo.PitFuelPutOnCar, "Pit Tanked", "Tanked");
      ColumnInfoData columnInfoData53 = new ColumnInfoData(ColumnInfo.PitLap, "Pit Lap", "Lap");
      ColumnInfoData columnInfoData54 = new ColumnInfoData(ColumnInfo.PitReason, "Pit Reason", "Reason");
      ColumnInfoData columnInfoData55 = new ColumnInfoData(ColumnInfo.PitRefilled, "Pit Fuel Refilled", "Refilled to");
      ColumnInfoData columnInfoData56 = new ColumnInfoData(ColumnInfo.PitSecondsPerLiterFuel, "Pit litres fuel/second", "l/s");
      ColumnInfoData columnInfoData57 = new ColumnInfoData(ColumnInfo.PitTime, "Pit Time", "Time");
      ColumnInfoData columnInfoData58 = new ColumnInfoData(ColumnInfo.PitTyresLeft, "Pit Tyres Left", "Tyres Left");
      ColumnInfoData columnInfoData59 = new ColumnInfoData(ColumnInfo.PracticeBrakes, "Practice Brakes", "Brakes");
      ColumnInfoData columnInfoData60 = new ColumnInfoData(ColumnInfo.PracticeDriverMistake, "Practice Driver Mistake", "Driver Mistake");
      ColumnInfoData columnInfoData61 = new ColumnInfoData(ColumnInfo.PracticeEngine, "Practice Engine", "Engine");
      ColumnInfoData columnInfoData62 = new ColumnInfoData(ColumnInfo.PracticeFrontWing, "Practice Front Wing", "Front Wing");
      ColumnInfoData columnInfoData63 = new ColumnInfoData(ColumnInfo.PracticeGear, "Practice Gear", "Gear");
      ColumnInfoData columnInfoData64 = new ColumnInfoData(ColumnInfo.PracticeHumidity, "Practice Humidity", "Humidity");
      ColumnInfoData columnInfoData65 = new ColumnInfoData(ColumnInfo.PracticeLapNumber, "Practice Lap Number", "Lap Number");
      ColumnInfoData columnInfoData66 = new ColumnInfoData(ColumnInfo.PracticeLapTime, "Practice Lap Time", "Lap Time");
      ColumnInfoData columnInfoData67 = new ColumnInfoData(ColumnInfo.PracticeNetTime, "Practice Net Time", "Net Time");
      ColumnInfoData columnInfoData68 = new ColumnInfoData(ColumnInfo.PracticeRearWing, "Practice Rear Wing", "Rear Wing");
      ColumnInfoData columnInfoData69 = new ColumnInfoData(ColumnInfo.PracticeSuspension, "Practice Suspension", "Suspension");
      ColumnInfoData columnInfoData70 = new ColumnInfoData(ColumnInfo.PracticeTemperature, "Practice Temperature", "Temperature");
      ColumnInfoData columnInfoData71 = new ColumnInfoData(ColumnInfo.PracticeTyreType, "Practice Tyre Type", "Tyre Type");
      ColumnInfoData columnInfoData72 = new ColumnInfoData(ColumnInfo.PracticeWeather, "Practice Weather", "Weather");
      ColumnInfoData columnInfoData73 = new ColumnInfoData(ColumnInfo.RacePitStopReason, "Pit Stop Reason", "Pit Stop Reason");
      ColumnInfoData columnInfoData74 = new ColumnInfoData(ColumnInfo.RaceSkies, "Weather", "Weather");
      ColumnInfoData columnInfoData75 = new ColumnInfoData(ColumnInfo.RaceStartStrategy, "Start Strategy", "Start Strategy");
      ColumnInfoData columnInfoData76 = new ColumnInfoData(ColumnInfo.RaceSetupBrakes, "Race Setup Brakes", "Brakes");
      ColumnInfoData columnInfoData77 = new ColumnInfoData(ColumnInfo.RaceSetupEngine, "Race Setup Engine", "Engine");
      ColumnInfoData columnInfoData78 = new ColumnInfoData(ColumnInfo.RaceSetupFrontWing, "Race Setup Front Wing", "Front Wing");
      ColumnInfoData columnInfoData79 = new ColumnInfoData(ColumnInfo.RaceSetupGear, "Race Setup Gear", "Gear");
      ColumnInfoData columnInfoData80 = new ColumnInfoData(ColumnInfo.RaceSetupRearWing, "Race Setup Rear Wing", "Rear Wing");
      ColumnInfoData columnInfoData81 = new ColumnInfoData(ColumnInfo.RaceSetupSuspension, "Race Setup Suspension", "Suspension");
      ColumnInfoData columnInfoData82 = new ColumnInfoData(ColumnInfo.RaceSetupTyreType, "Race Setup Tyre Type", "Tyre Type");
      ColumnInfoData columnInfoData83 = new ColumnInfoData(ColumnInfo.RaceSetupWeatherMinTemp, "Race Setup Weather Min Temp", "Min temp");
      ColumnInfoData columnInfoData84 = new ColumnInfoData(ColumnInfo.RaceSetupWeatherMaxTemp, "Race Setup Weather Max Temp", "Max temp");
      ColumnInfoData columnInfoData85 = new ColumnInfoData(ColumnInfo.RaceSetupWeatherMinHum, "Race Setup Weather Min Humidity", "Min hum");
      ColumnInfoData columnInfoData86 = new ColumnInfoData(ColumnInfo.RaceSetupWeatherMaxHum, "Race Setup Weather Max Humidity", "Max hum");
      ColumnInfoData columnInfoData87 = new ColumnInfoData(ColumnInfo.Q1SetupBrakes, "Q1 Setup Brakes", "Brakes");
      ColumnInfoData columnInfoData88 = new ColumnInfoData(ColumnInfo.Q1SetupEngine, "Q1 Setup Engine", "Engine");
      ColumnInfoData columnInfoData89 = new ColumnInfoData(ColumnInfo.Q1SetupFrontWing, "Q1 Setup Front Wing", "Front Wing");
      ColumnInfoData columnInfoData90 = new ColumnInfoData(ColumnInfo.Q1SetupGear, "Q1 Setup Gear", "Gear");
      ColumnInfoData columnInfoData91 = new ColumnInfoData(ColumnInfo.Q1SetupRearWing, "Q1 Setup Rear Wing", "Rear Wing");
      ColumnInfoData columnInfoData92 = new ColumnInfoData(ColumnInfo.Q1SetupSuspension, "Q1 Setup Suspension", "Suspension");
      ColumnInfoData columnInfoData93 = new ColumnInfoData(ColumnInfo.Q1SetupTyreType, "Q1 Setup Tyre Type", "Tyre Type");
      ColumnInfoData columnInfoData94 = new ColumnInfoData(ColumnInfo.Q1SetupWeatherTemp, "Q1 Setup Weather Temp", "Temp");
      ColumnInfoData columnInfoData95 = new ColumnInfoData(ColumnInfo.Q1SetupWeatherHum, "Q1 Setup Weather Hum", "Hum");
      ColumnInfoData columnInfoData96 = new ColumnInfoData(ColumnInfo.Q1SetupWeatherSkies, "Q1 Setup Weather", "Weather");
      ColumnInfoData columnInfoData97 = new ColumnInfoData(ColumnInfo.Q1Time, "Q1 Time", "Time");
      ColumnInfoData columnInfoData98 = new ColumnInfoData(ColumnInfo.RiskClear, "Risk Clear", "Clear");
      ColumnInfoData columnInfoData99 = new ColumnInfoData(ColumnInfo.RiskWet, "Risk Wet", "Wet");
      ColumnInfoData columnInfoData100 = new ColumnInfoData(ColumnInfo.RiskDefend, "Risk Defend", "Defend");
      ColumnInfoData columnInfoData101 = new ColumnInfoData(ColumnInfo.RiskMalfunction, "Risk Malfunction", "Malfunction");
      ColumnInfoData columnInfoData102 = new ColumnInfoData(ColumnInfo.RiskOvertake, "Risk Overtake", "Overtake");
      ColumnInfoData columnInfoData103 = new ColumnInfoData(ColumnInfo.StaffAlloyAndChemicalLab, "Staff Alloy&Chemical Lab", "Alloy&Chemical Lab");
      ColumnInfoData columnInfoData104 = new ColumnInfoData(ColumnInfo.StaffCommercial, "Staff Commercial", "Commercial");
      ColumnInfoData columnInfoData105 = new ColumnInfoData(ColumnInfo.StaffConcentration, "Staff Concentration", "Concentration");
      ColumnInfoData columnInfoData106 = new ColumnInfoData(ColumnInfo.StaffEfficiency, "Staff Efficiency", "Efficiency");
      ColumnInfoData columnInfoData107 = new ColumnInfoData(ColumnInfo.StaffEngineeringWorkshop, "Staff Engineering Workshop", "Engineering Workshop");
      ColumnInfoData columnInfoData108 = new ColumnInfoData(ColumnInfo.StaffExperience, "Staff Experience", "Experience");
      ColumnInfoData columnInfoData109 = new ColumnInfoData(ColumnInfo.StaffMaintenance, "Staff Maintenance", "Maintenance");
      ColumnInfoData columnInfoData110 = new ColumnInfoData(ColumnInfo.StaffMotivation, "Staff Motivation", "Motivation");
      ColumnInfoData columnInfoData111 = new ColumnInfoData(ColumnInfo.StaffOverall, "Staff Overall", "Overall");
      ColumnInfoData columnInfoData112 = new ColumnInfoData(ColumnInfo.StaffPitstopTrainingCenter, "Staff Pitstop Training Center", "Pitstop Training Center");
      ColumnInfoData columnInfoData113 = new ColumnInfoData(ColumnInfo.StaffRDDesignCenter, "Staff R&D Design Center", "R&D Design Center");
      ColumnInfoData columnInfoData114 = new ColumnInfoData(ColumnInfo.StaffRDWorkshop, "Staff R&D Workshop", "R&D Workshop");
      ColumnInfoData columnInfoData115 = new ColumnInfoData(ColumnInfo.StaffSalary, "Staff Salary", "Salary");
      ColumnInfoData columnInfoData116 = new ColumnInfoData(ColumnInfo.StaffStressHandling, "Staff Stress Handling", "Stress Handling");
      ColumnInfoData columnInfoData117 = new ColumnInfoData(ColumnInfo.StaffTechnicalSkill, "Staff Technical Skill", "Technical Skill");
      ColumnInfoData columnInfoData118 = new ColumnInfoData(ColumnInfo.StaffTrainingType, "Staff Training Type", "Training Type");
      ColumnInfoData columnInfoData119 = new ColumnInfoData(ColumnInfo.StaffWindtunnel, "Staff Wind Tunnel", "Wind Tunnel");
      ColumnInfoData columnInfoData120 = new ColumnInfoData(ColumnInfo.StintAvgHum, "Stint Avg. Humidity", "Avg. Humidity");
      ColumnInfoData columnInfoData121 = new ColumnInfoData(ColumnInfo.StintAvgTemp, "Stint Avg. Temperature", "Avg. Temperature");
      ColumnInfoData columnInfoData122 = new ColumnInfoData(ColumnInfo.StintBadKm, "Stint Bad Km", "Bad Km");
      ColumnInfoData columnInfoData123 = new ColumnInfoData(ColumnInfo.StintBadPercent, "Stint Bad %", "Bad%");
      ColumnInfoData columnInfoData124 = new ColumnInfoData(ColumnInfo.StintEstimatedTyreDuration, "Stint Estimated Tyre Duration", "Estimated");
      ColumnInfoData columnInfoData125 = new ColumnInfoData(ColumnInfo.StintFinalPercent, "Stint Final %", "Final%");
      ColumnInfoData columnInfoData126 = new ColumnInfoData(ColumnInfo.StintFuel, "Stint Fuel", "Fuel");
      ColumnInfoData columnInfoData127 = new ColumnInfoData(ColumnInfo.StintFuelConsumption, "Stint Fuel Consumption", "Consumption");
      ColumnInfoData columnInfoData128 = new ColumnInfoData(ColumnInfo.StintKm, "Stint Km", "Km");
      ColumnInfoData columnInfoData129 = new ColumnInfoData(ColumnInfo.StintLaps, "Stint Laps", "Laps");
      ColumnInfoData columnInfoData130 = new ColumnInfoData(ColumnInfo.StintMaxHum, "Stint Max Humidity", "Max Humidity");
      ColumnInfoData columnInfoData131 = new ColumnInfoData(ColumnInfo.StintMaxTemp, "Stint Max Temperature", "Max Temperature");
      ColumnInfoData columnInfoData132 = new ColumnInfoData(ColumnInfo.StintMinHum, "Stint Min Humidity", "Min Humidity");
      ColumnInfoData columnInfoData133 = new ColumnInfoData(ColumnInfo.StintMinTemp, "Stint Min Temperature", "Min Temperature");
      ColumnInfoData columnInfoData134 = new ColumnInfoData(ColumnInfo.StintNumber, "Stint Number", "Stint");
      ColumnInfoData columnInfoData135 = new ColumnInfoData(ColumnInfo.StintRace, "Race Number", "Race");
      ColumnInfoData columnInfoData136 = new ColumnInfoData(ColumnInfo.StintSeason, "Season Number", "Season");
      ColumnInfoData columnInfoData137 = new ColumnInfoData(ColumnInfo.StintTyreType, "Stint Tyre Type", "Tyre Type");
      ColumnInfoData columnInfoData138 = new ColumnInfoData(ColumnInfo.StintWeather, "Stint Weather", "Weather");
      ColumnInfoData columnInfoData139 = new ColumnInfoData(ColumnInfo.SummaryAverageSpeed, "Race Average Speed", "Avg. Speed");
      ColumnInfoData columnInfoData140 = new ColumnInfoData(ColumnInfo.SummaryBestLap, "Race Best Lap", "Best Lap");
      ColumnInfoData columnInfoData141 = new ColumnInfoData(ColumnInfo.SummaryBestPitTime, "Race Best Pit Time", "Best Pit Time");
      ColumnInfoData columnInfoData142 = new ColumnInfoData(ColumnInfo.SummaryLaps, "Race Laps", "Laps");
      ColumnInfoData columnInfoData143 = new ColumnInfoData(ColumnInfo.SummaryPitStops, "Race Pit Stops", "Pit Stops");
      ColumnInfoData columnInfoData144 = new ColumnInfoData(ColumnInfo.SummaryPosition, "Race Position", "Position");
      ColumnInfoData columnInfoData145 = new ColumnInfoData(ColumnInfo.SummaryProgress, "Race Progress", "Progress");
      ColumnInfoData columnInfoData146 = new ColumnInfoData(ColumnInfo.SummaryRaceTime, "Race Time", "Race Time");
      ColumnInfoData columnInfoData147 = new ColumnInfoData(ColumnInfo.SummaryStartPosition, "Race Start Position", "Start Position");
      ColumnInfoData columnInfoData148 = new ColumnInfoData(ColumnInfo.SummaryWinnerAverageSpeed, "Race Winner Average Speed", "Winner Avg. Speed");
      ColumnInfoData columnInfoData149 = new ColumnInfoData(ColumnInfo.SummaryWinnerBestLap, "Race Winner Best Lap", "Winner Best Lap");
      ColumnInfoData columnInfoData150 = new ColumnInfoData(ColumnInfo.SummaryWinnerBestPitTime, "Race Winner Best Pit Time", "Winner Best Pit Time");
      ColumnInfoData columnInfoData151 = new ColumnInfoData(ColumnInfo.SummaryWinnerPitStops, "Race Winner Pit Stops", "Winner Pit Stops");
      ColumnInfoData columnInfoData152 = new ColumnInfoData(ColumnInfo.SummaryWinnerRaceTime, "Race Winner Race Time", "Winner Race Time");
      ColumnInfoData columnInfoData153 = new ColumnInfoData(ColumnInfo.TestPriority, "Test Priority", "Priority");
      ColumnInfoData columnInfoData154 = new ColumnInfoData(ColumnInfo.TrackAcceleration, "Track Acceleration", "Acceleration (Track)");
      ColumnInfoData columnInfoData155 = new ColumnInfoData(ColumnInfo.TrackAvgSpeed, "Track Avg. Speed", "Avg. Speed (Track)");
      ColumnInfoData columnInfoData156 = new ColumnInfoData(ColumnInfo.TrackCorners, "Track Corners", "No of Corners (Track)");
      ColumnInfoData columnInfoData157 = new ColumnInfoData(ColumnInfo.TrackDownForce, "Track Downforce", "Downforce (Track)");
      ColumnInfoData columnInfoData158 = new ColumnInfoData(ColumnInfo.TrackFuelConsumption, "Track Fuel Consumption", "Fuel Consumption (Track)");
      ColumnInfoData columnInfoData159 = new ColumnInfoData(ColumnInfo.TrackHandling, "Track Handling", "Handling (Track)");
      ColumnInfoData columnInfoData160 = new ColumnInfoData(ColumnInfo.TrackLapLength, "Track Lap Length", "Lap Length (Track)");
      ColumnInfoData columnInfoData161 = new ColumnInfoData(ColumnInfo.TrackLaps, "Track Laps", "Laps (Track)");
      ColumnInfoData columnInfoData162 = new ColumnInfoData(ColumnInfo.TrackName, "Track Name", "Name (Track)");
      ColumnInfoData columnInfoData163 = new ColumnInfoData(ColumnInfo.TrackNote, "Track Note", "Note (Track)");
      ColumnInfoData columnInfoData164 = new ColumnInfoData(ColumnInfo.TrackOvertaking, "Track Overtaking", "Overtaking (Track)");
      ColumnInfoData columnInfoData165 = new ColumnInfoData(ColumnInfo.TrackPitInOutTime, "Track Pit In/Out Time", "In/Out Time");
      ColumnInfoData columnInfoData166 = new ColumnInfoData(ColumnInfo.TrackPower, "Track Power", "Power (Track)");
      ColumnInfoData columnInfoData167 = new ColumnInfoData(ColumnInfo.TrackRaceDistance, "Track Race Distance", "Distance (Track)");
      ColumnInfoData columnInfoData168 = new ColumnInfoData(ColumnInfo.TrackSuspensionRigidity, "Track Suspension Rigidity", "Suspension (Track)");
      ColumnInfoData columnInfoData169 = new ColumnInfoData(ColumnInfo.TrackTyreWear, "Track Tyre Wear", "Tyre Wear (Track)");
      ColumnInfoData columnInfoData170 = new ColumnInfoData(ColumnInfo.TrackGrip, "Track Grip", "Grip (Track)");
      ColumnInfoData columnInfoData171 = new ColumnInfoData(ColumnInfo.TyreSupplierDryPerf, "Tyre Sup. Dry Performance", "Dry Performance (Tyre Sup)");
      ColumnInfoData columnInfoData172 = new ColumnInfoData(ColumnInfo.TyreSupplierWetPerf, "Tyre Sup. Wet Performance", "Wet Performance (Tyre Sup)");
      ColumnInfoData columnInfoData173 = new ColumnInfoData(ColumnInfo.TyreSupplierPeakTemp, "Tyre Sup. Peak Temperature", "Peak Temperature (Tyre Sup)");
      ColumnInfoData columnInfoData174 = new ColumnInfoData(ColumnInfo.TyreSupplierDurability, "Tyre Sup. Durability", "Durability (Tyre Sup)");
      ColumnInfoData columnInfoData175 = new ColumnInfoData(ColumnInfo.TyreSupplierWarmupDist, "Tyre Sup. Warmup Distance", "Warmup Distance (Tyre Sup)");
      ColumnInfoData columnInfoData176 = new ColumnInfoData(ColumnInfo.TechDirectorName, "Technical Director Name", "TD Name");
      ColumnInfoData columnInfoData177 = new ColumnInfoData(ColumnInfo.TechDirectorAerodynamics, "Technical Director Aerodynamics", "TD AeroDynamics");
      ColumnInfoData columnInfoData178 = new ColumnInfoData(ColumnInfo.TechDirectorElectronics, "Technical Director Electronics", "TD Electronics");
      ColumnInfoData columnInfoData179 = new ColumnInfoData(ColumnInfo.TechDirectorExperience, "Technical Director Experience", "TD Experience");
      ColumnInfoData columnInfoData180 = new ColumnInfoData(ColumnInfo.TechDirectorLeadership, "Technical Director Leadership", "TD Leadership");
      ColumnInfoData columnInfoData181 = new ColumnInfoData(ColumnInfo.TechDirectorMechanics, "Technical Director Mechanics", "TD Mechanics");
      ColumnInfoData columnInfoData182 = new ColumnInfoData(ColumnInfo.TechDirectorMotivation, "Technical Director Motivation", "TD Motivation");
      ColumnInfoData columnInfoData183 = new ColumnInfoData(ColumnInfo.TechDirectorOverall, "Technical Director Overall", "TD Overall");
      ColumnInfoData columnInfoData184 = new ColumnInfoData(ColumnInfo.TechDirectorPitCoordination, "Technical Director Pit Coordination", "TD Pit Coordination");
      ColumnInfoData.initialized = true;
    }

    internal ColumnInfoData(ColumnInfo info, string longText, string shortText)
    {
      ColumnInfoData.infoToLongText.Add(info, longText);
      ColumnInfoData.infoToShortText.Add(info, shortText);
      ColumnInfoData.longTextToInfo.Add(longText, info);
    }

    public static ColumnInfo GetColumnInfoForLongString(string longstring)
    {
      ColumnInfoData.initialize();
      ColumnInfo columnInfo;
      return ColumnInfoData.longTextToInfo.TryGetValue(longstring, out columnInfo) ? columnInfo : ColumnInfo.Unknown;
    }

    public static string GetLongStringForColumninfo(ColumnInfo info)
    {
      ColumnInfoData.initialize();
      string str;
      return ColumnInfoData.infoToLongText.TryGetValue(info, out str) ? str : "Unknown";
    }

    public static string GetShortStringForColumninfo(ColumnInfo info)
    {
      ColumnInfoData.initialize();
      string str;
      return ColumnInfoData.infoToShortText.TryGetValue(info, out str) ? str : "Unknown";
    }
  }
}
