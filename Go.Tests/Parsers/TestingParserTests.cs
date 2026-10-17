using System;
using go.Enums;
using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class TestingParserTests
    {
        private readonly Testing _result;

        public TestingParserTests()
        {
            var html = TestDataLoader.Load("Testing.html");
            _result = TestingParser.ParseTest(html);
        }

        // --- Track ---

        [Fact]
        public void Track_Is20()
        {
            Assert.Equal(20, _result.track);
        }

        // --- Weather ---

        [Fact]
        public void Weather_Skies_IsPartiallyCloudy()
        {
            Assert.Equal(Skies.PartiallyCloudy, _result.weather.skies);
        }

        [Fact]
        public void Weather_Temperature_Is29()
        {
            Assert.Equal(29, _result.weather.temperature);
        }

        [Fact]
        public void Weather_Humidity_Is35()
        {
            Assert.Equal(35, _result.weather.humidity);
        }

        // --- Points ---

        [Fact]
        public void TestPoints_Power_Is65Point3()
        {
            Assert.Equal(65.3, _result.points[0].power);
        }

        [Fact]
        public void TestPoints_Handling_Is8Point2()
        {
            Assert.Equal(8.2, _result.points[0].handling);
        }

        [Fact]
        public void TestPoints_Acceleration_Is8Point2()
        {
            Assert.Equal(8.2, _result.points[0].acceleration);
        }

        [Fact]
        public void RnDPoints_AllZero()
        {
            Assert.Equal(0, _result.points[1].power);
            Assert.Equal(0, _result.points[1].handling);
            Assert.Equal(0, _result.points[1].acceleration);
        }

        [Fact]
        public void EngineeringPoints_AllZero()
        {
            Assert.Equal(0, _result.points[2].power);
            Assert.Equal(0, _result.points[2].handling);
            Assert.Equal(0, _result.points[2].acceleration);
        }

        [Fact]
        public void CarCharacterPoints_Are7_4_5()
        {
            Assert.Equal(7, _result.points[3].power);
            Assert.Equal(4, _result.points[3].handling);
            Assert.Equal(5, _result.points[3].acceleration);
        }

        // --- Runs count ---

        [Fact]
        public void Runs_Count_Is4()
        {
            Assert.Equal(4, _result.runs.Length);
        }

        // --- Run 1 ---

        [Fact]
        public void Run1_Priority_IsTopSpeed()
        {
            Assert.Equal(TestPriority.TopSpeed, _result.runs[0].priority);
        }

        [Fact]
        public void Run1_LapsDone_Is30()
        {
            Assert.Equal(30, _result.runs[0].lapsDone);
        }

        [Fact]
        public void Run1_LapLimit_Is30()
        {
            Assert.Equal(30, _result.runs[0].lapLimit);
        }

        [Fact]
        public void Run1_BestTime()
        {
            var expected = new TimeSpan(0, 0, 1, 16, 670);
            Assert.Equal(expected, _result.runs[0].bestTime);
        }

        [Fact]
        public void Run1_MeanTime()
        {
            var expected = new TimeSpan(0, 0, 1, 17, 33);
            Assert.Equal(expected, _result.runs[0].meanTime);
        }

        [Fact]
        public void Run1_Setup_FWing_Is450()
        {
            Assert.Equal(450, _result.runs[0].setup.fWing);
        }

        [Fact]
        public void Run1_Setup_RWing_Is450()
        {
            Assert.Equal(450, _result.runs[0].setup.rWing);
        }

        [Fact]
        public void Run1_Setup_Engine_Is450()
        {
            Assert.Equal(450, _result.runs[0].setup.engine);
        }

        [Fact]
        public void Run1_Setup_Brakes_Is450()
        {
            Assert.Equal(450, _result.runs[0].setup.brakes);
        }

        [Fact]
        public void Run1_Setup_Gear_Is450()
        {
            Assert.Equal(450, _result.runs[0].setup.gear);
        }

        [Fact]
        public void Run1_Setup_Susp_Is450()
        {
            Assert.Equal(450, _result.runs[0].setup.susp);
        }

        [Fact]
        public void Run1_Setup_Tyres_IsHard()
        {
            Assert.Equal(TyreType.Hard, _result.runs[0].setup.tyres);
        }

        [Fact]
        public void Run1_FuelStart_Is180()
        {
            Assert.Equal(180, _result.runs[0].fuelStart);
        }

        [Fact]
        public void Run1_TyresCondition_Is32()
        {
            Assert.Equal(32, _result.runs[0].tyresCondition);
        }

        [Fact]
        public void Run1_FuelLeft_Is100()
        {
            Assert.Equal(100, _result.runs[0].fuelLeft);
        }

        // --- Run 2 ---

        [Fact]
        public void Run2_LapsDone_Is30()
        {
            Assert.Equal(30, _result.runs[1].lapsDone);
        }

        [Fact]
        public void Run2_BestTime()
        {
            var expected = new TimeSpan(0, 0, 1, 15, 568);
            Assert.Equal(expected, _result.runs[1].bestTime);
        }

        [Fact]
        public void Run2_MeanTime()
        {
            var expected = new TimeSpan(0, 0, 1, 15, 868);
            Assert.Equal(expected, _result.runs[1].meanTime);
        }

        [Fact]
        public void Run2_FuelStart_Is90()
        {
            Assert.Equal(90, _result.runs[1].fuelStart);
        }

        [Fact]
        public void Run2_FuelLeft_Is10()
        {
            Assert.Equal(10, _result.runs[1].fuelLeft);
        }

        // --- Run 3 ---

        [Fact]
        public void Run3_BestTime()
        {
            var expected = new TimeSpan(0, 0, 1, 15, 454);
            Assert.Equal(expected, _result.runs[2].bestTime);
        }

        [Fact]
        public void Run3_MeanTime()
        {
            var expected = new TimeSpan(0, 0, 1, 15, 748);
            Assert.Equal(expected, _result.runs[2].meanTime);
        }

        [Fact]
        public void Run3_FuelStart_Is85()
        {
            Assert.Equal(85, _result.runs[2].fuelStart);
        }

        [Fact]
        public void Run3_FuelLeft_Is5()
        {
            Assert.Equal(5, _result.runs[2].fuelLeft);
        }

        // --- Run 4 ---

        [Fact]
        public void Run4_LapsDone_Is10()
        {
            Assert.Equal(10, _result.runs[3].lapsDone);
        }

        [Fact]
        public void Run4_LapLimit_Is10()
        {
            Assert.Equal(10, _result.runs[3].lapLimit);
        }

        [Fact]
        public void Run4_BestTime()
        {
            var expected = new TimeSpan(0, 0, 1, 15, 448);
            Assert.Equal(expected, _result.runs[3].bestTime);
        }

        [Fact]
        public void Run4_MeanTime()
        {
            var expected = new TimeSpan(0, 0, 1, 15, 844);
            Assert.Equal(expected, _result.runs[3].meanTime);
        }

        [Fact]
        public void Run4_TyresCondition_Is77()
        {
            Assert.Equal(77, _result.runs[3].tyresCondition);
        }

        [Fact]
        public void Run4_FuelLeft_Is58()
        {
            Assert.Equal(58, _result.runs[3].fuelLeft);
        }

        // --- Comments ---

        [Fact]
        public void Run1_Comments_ContainsNoDriverComments()
        {
            Assert.Contains("No driver comments available", _result.runs[0].comments[0]);
        }

        // --- All runs have same priority ---

        [Fact]
        public void AllRuns_Priority_IsTopSpeed()
        {
            foreach (var run in _result.runs)
            {
                Assert.Equal(TestPriority.TopSpeed, run.priority);
            }
        }
    }
}
