using System;
using go.Enums;
using go.Parsers;
using go.Tests.TestData;
using go.Utils;
using Xunit;

namespace go.Tests.Parsers
{
    public class RaceAnalysisParserTests : IDisposable
    {
        private readonly string _racePage = TestDataLoader.Load("RaceAnalysis.html");

        public RaceAnalysisParserTests()
        {
            Datas.Tracks = new Track[] { new Track { laps = 2 } };
        }

        public void Dispose()
        {
            Datas.Tracks = null;
        }

        [Fact]
        public void ParseRace_DidFinishRace_IsTrue()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.True(race.DidFinishRace);
        }

        [Fact]
        public void ParseRace_Laps_CorrectCount()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(3, race.Laps.Length);
        }

        [Fact]
        public void ParseRace_Lap0_TimeIsZero()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(TimeSpan.Zero, race.Laps[0].lapTime);
        }

        [Fact]
        public void ParseRace_Lap1_ParsesTime()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(new TimeSpan(0, 0, 1, 30, 89), race.Laps[1].lapTime);
        }

        [Fact]
        public void ParseRace_Lap2_ParsesTime()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(new TimeSpan(0, 0, 1, 31, 220), race.Laps[2].lapTime);
        }

        [Fact]
        public void ParseRace_Lap0_ParsesPosition()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(9, race.Laps[0].position);
        }

        [Fact]
        public void ParseRace_Lap1_ParsesPosition()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(7, race.Laps[1].position);
        }

        [Fact]
        public void ParseRace_Lap1_ParsesTyres()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(TyreType.Medium, race.Laps[1].tyres);
        }

        [Fact]
        public void ParseRace_Lap1_ParsesWeatherSkies()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(Skies.Cloudy, race.Laps[1].weather.skies);
        }

        [Fact]
        public void ParseRace_Lap1_ParsesTemperature()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(26, race.Laps[1].weather.temperature);
        }

        [Fact]
        public void ParseRace_Lap1_ParsesHumidity()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(48, race.Laps[1].weather.humidity);
        }

        [Fact]
        public void ParseRace_DriverEnergy_AllValues()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(95, race.DriverEnergy.BeforeQ1);
            Assert.Equal(92, race.DriverEnergy.AfterQ1);
            Assert.Equal(92, race.DriverEnergy.BeforeQ2);
            Assert.Equal(88, race.DriverEnergy.AfterQ2);
            Assert.Equal(95, race.DriverEnergy.BeforeRace);
            Assert.Equal(45, race.DriverEnergy.AfterRace);
        }

        [Fact]
        public void ParseRace_RaceStartWeather_IsSunny()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(Skies.Sunny, race.Laps[0].weather.skies);
        }

        [Fact]
        public void ParseRace_CarSetup_AllValues()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(520, race.CarSetup.fWing);
            Assert.Equal(470, race.CarSetup.rWing);
            Assert.Equal(590, race.CarSetup.engine);
            Assert.Equal(340, race.CarSetup.brakes);
            Assert.Equal(410, race.CarSetup.gear);
            Assert.Equal(290, race.CarSetup.susp);
        }

        [Fact]
        public void ParseRace_StartFuel_Is55()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(55, race.StartFuel);
        }

        [Fact]
        public void ParseRace_PitStops_Count()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Single(race.PitStops);
        }

        [Fact]
        public void ParseRace_PitStop_Lap()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(1, race.PitStops[0].lap);
        }

        [Fact]
        public void ParseRace_PitStop_Reason()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(PitStopReason.Fuel, race.PitStops[0].pitstopreason);
        }

        [Fact]
        public void ParseRace_PitStop_TyresCondition()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(8, race.PitStops[0].tyresCondition);
        }

        [Fact]
        public void ParseRace_PitStop_FuelLeft()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(1, race.PitStops[0].fuelLeft);
        }

        [Fact]
        public void ParseRace_PitStop_RefilledTo()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(55, race.PitStops[0].refilledTo);
        }

        [Fact]
        public void ParseRace_PitStop_PitTime()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(new TimeSpan(0, 0, 0, 22, 41), race.PitStops[0].pitTime);
        }

        [Fact]
        public void ParseRace_TyresAfterFinish()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(18, race.TyresAfterFinish);
        }

        [Fact]
        public void ParseRace_EndFuel()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(4, race.EndFuel);
        }

        [Fact]
        public void ParseRace_OvertakingAttempts_InitiatedBlocked()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(19, race.OvertakingAttemps.InitiatedBlocked);
        }

        [Fact]
        public void ParseRace_OvertakingAttempts_InitiatedSuccessful()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(2, race.OvertakingAttemps.InitiatedSucceful);
        }

        [Fact]
        public void ParseRace_OvertakingAttempts_SufferedBlocked()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(8, race.OvertakingAttemps.SufferedBlocked);
        }

        [Fact]
        public void ParseRace_OvertakingAttempts_SufferedSuccessful()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(2, race.OvertakingAttemps.SufferedSuccessful);
        }

        [Fact]
        public void ParseRace_Finances_EndPosition()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(19, race.Finances.endPosition);
        }

        [Fact]
        public void ParseRace_Finances_EndPositionMoney()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(9187692, race.Finances.endPositionMoney);
        }

        [Fact]
        public void ParseRace_Finances_QualPosition()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(9, race.Finances.qualPosition);
        }

        [Fact]
        public void ParseRace_Finances_QualPositionMoney()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(768000, race.Finances.qualPositionMoney);
        }

        [Fact]
        public void ParseRace_Finances_SponsorMoney()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(1878587, race.Finances.sponsorMoney);
        }

        [Fact]
        public void ParseRace_Finances_DriverSalary()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(-520150, race.Finances.driverSalary);
        }

        [Fact]
        public void ParseRace_Finances_StaffSalary()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(-385200, race.Finances.staffSalary);
        }

        [Fact]
        public void ParseRace_Finances_FacilityCost()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(-472800, race.Finances.facilityCost);
        }

        [Fact]
        public void ParseRace_Finances_TyresContractCost()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(-2008000, race.Finances.tyresContractCost);
        }

        [Fact]
        public void ParseRace_Finances_Total()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(8448129, race.Finances.total);
        }

        [Fact]
        public void ParseRace_Finances_CurrentBalance()
        {
            var race = RaceAnalysisParser.ParseRace(_racePage, raceEvent: null);
            Assert.Equal(83217546, race.Finances.currentBalance);
        }

        [Fact]
        public void ParseRace_LockedRace_ReturnsNull()
        {
            var lockedPage = "<html>The race analysis and all other information for this race is locked</html>";
            var result = RaceAnalysisParser.ParseRace(lockedPage, raceEvent: null);
            Assert.Null(result);
        }

        [Fact]
        public void ParseRace_NotAvailable_ThrowsException()
        {
            var notAvailablePage = "<html>The race analysis will be available shortly after the end of the race</html>";
            Assert.Throws<Exception>(() => RaceAnalysisParser.ParseRace(notAvailablePage, raceEvent: null));
        }
    }
}
