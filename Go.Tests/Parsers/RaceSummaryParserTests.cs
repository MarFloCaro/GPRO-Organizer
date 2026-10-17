using System;
using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class RaceSummaryParserTests
    {
        private readonly RaceSummary _result;

        public RaceSummaryParserTests()
        {
            var html = TestDataLoader.Load("RaceSummary.html");
            _result = RaceSummaryParser.GetRaceSummaryPage(html);
        }

        [Fact]
        public void Classified_Count_Is3()
        {
            Assert.Equal(3, _result.classified.Length);
        }

        [Fact]
        public void NotClassified_Count_Is1()
        {
            Assert.Single(_result.notClassified);
        }

        // --- Position ---

        [Fact]
        public void Winner_Position_Is1()
        {
            Assert.Equal(1, _result.classified[0].pos);
        }

        [Fact]
        public void Second_Position_Is2()
        {
            Assert.Equal(2, _result.classified[1].pos);
        }

        [Fact]
        public void Third_Position_Is3()
        {
            Assert.Equal(3, _result.classified[2].pos);
        }

        [Fact]
        public void NotClassified_Position_Is4()
        {
            Assert.Equal(4, _result.notClassified[0].pos);
        }

        // --- Progress ---

        [Fact]
        public void Winner_Progress_IsZero_WhenNoChange()
        {
            Assert.Equal(0, _result.classified[0].progress);
        }

        [Fact]
        public void Second_Progress_IsPositive()
        {
            Assert.Equal(4, _result.classified[1].progress);
        }

        [Fact]
        public void Third_Progress_IsNegative()
        {
            Assert.Equal(-1, _result.classified[2].progress);
        }

        // --- Manager ---

        [Fact]
        public void Winner_ManagerID()
        {
            Assert.Equal(10001, _result.classified[0].managerID);
        }

        [Fact]
        public void Winner_ManagerName()
        {
            Assert.Equal("Alex Thunder", _result.classified[0].managerName);
        }

        [Fact]
        public void Second_ManagerID()
        {
            Assert.Equal(20002, _result.classified[1].managerID);
        }

        // --- Race time ---

        [Fact]
        public void Winner_RaceTime_AbsoluteTime()
        {
            // 1h37:55.821
            var expected = new TimeSpan(0, 1, 37, 55, 821);
            Assert.Equal(expected, _result.classified[0].raceTime);
        }

        [Fact]
        public void Second_RaceTime_IsWinnerPlusGap()
        {
            // Winner 1h37:55.821 + gap 1:00.449 = 1h38:56.270
            var expected = new TimeSpan(0, 1, 38, 56, 270);
            Assert.Equal(expected, _result.classified[1].raceTime);
        }

        [Fact]
        public void Third_RaceTime_IsWinnerPlusGap()
        {
            // Winner 1h37:55.821 + gap 1:16.003 = 1h39:11.824
            var expected = new TimeSpan(0, 1, 39, 11, 824);
            Assert.Equal(expected, _result.classified[2].raceTime);
        }

        // --- Laps ---

        [Fact]
        public void Winner_Laps_Is66()
        {
            Assert.Equal(66, _result.classified[0].laps);
        }

        [Fact]
        public void NotClassified_Laps_Is43()
        {
            Assert.Equal(43, _result.notClassified[0].laps);
        }

        // --- Pit stops ---

        [Fact]
        public void Winner_PitStops_Is3()
        {
            Assert.Equal(3, _result.classified[0].pitStops);
        }

        [Fact]
        public void Second_PitStops_Is2()
        {
            Assert.Equal(2, _result.classified[1].pitStops);
        }

        // --- Best lap ---

        [Fact]
        public void Winner_BestLap_ParsesTime()
        {
            // 1:25.743
            var expected = new TimeSpan(0, 0, 1, 25, 743);
            Assert.Equal(expected, _result.classified[0].bestLap);
        }

        [Fact]
        public void Winner_BestLapOfAll_IsTrue()
        {
            Assert.True(_result.classified[0].BestLapOfAll);
        }

        [Fact]
        public void Second_BestLapOfAll_IsFalse()
        {
            Assert.False(_result.classified[1].BestLapOfAll);
        }

        [Fact]
        public void Second_BestLap_ParsesTime()
        {
            // 1:27.484
            var expected = new TimeSpan(0, 0, 1, 27, 484);
            Assert.Equal(expected, _result.classified[1].bestLap);
        }

        // --- Average speed ---

        [Fact]
        public void Winner_AverageSpeed()
        {
            Assert.Equal(189.75, _result.classified[0].averageSpeed);
        }

        [Fact]
        public void Second_AverageSpeed()
        {
            Assert.Equal(187.81, _result.classified[1].averageSpeed);
        }

        [Fact]
        public void NotClassified_AverageSpeed_IsZero_WhenNbsp()
        {
            Assert.Equal(0.0, _result.notClassified[0].averageSpeed);
        }

        // --- Best pit time ---

        [Fact]
        public void Winner_BestPitTime()
        {
            // 18.813s
            var expected = new TimeSpan(0, 0, 0, 18, 813);
            Assert.Equal(expected, _result.classified[0].bestPitTime);
        }

        [Fact]
        public void Second_BestPitTime()
        {
            // 22.676s
            var expected = new TimeSpan(0, 0, 0, 22, 676);
            Assert.Equal(expected, _result.classified[1].bestPitTime);
        }

        // --- Not classified: no time reason ---

        [Fact]
        public void NotClassified_RaceTime_IsMinValue()
        {
            Assert.Equal(TimeSpan.MinValue, _result.notClassified[0].raceTime);
        }

        [Fact]
        public void NotClassified_NoTimeReason_IsTyrePuncture()
        {
            Assert.Contains("Tyre puncture", _result.notClassified[0].NoTimeReason);
        }

        // --- Edge cases: no race summary ---

        [Fact]
        public void NullPage_ReturnsEmptyResult()
        {
            var result = RaceSummaryParser.GetRaceSummaryPage(null);
            Assert.Null(result.classified);
            Assert.Null(result.notClassified);
        }

        [Fact]
        public void EmptyPage_ReturnsEmptyResult()
        {
            var result = RaceSummaryParser.GetRaceSummaryPage("");
            Assert.Null(result.classified);
            Assert.Null(result.notClassified);
        }

        [Fact]
        public void NoRaceSummaryMessage_ReturnsEmptyResult()
        {
            var result = RaceSummaryParser.GetRaceSummaryPage(
                "<html>The race summary will be available shortly after the end of the race</html>");
            Assert.Null(result.classified);
            Assert.Null(result.notClassified);
        }

        [Fact]
        public void NoDataAvailableMessage_ReturnsEmptyResult()
        {
            var result = RaceSummaryParser.GetRaceSummaryPage(
                "<html>No race summary data is available for this group</html>");
            Assert.Null(result.classified);
            Assert.Null(result.notClassified);
        }
    }
}
