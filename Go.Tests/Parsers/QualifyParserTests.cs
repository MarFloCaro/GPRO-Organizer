using System;
using go.Enums;
using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class QualifyParserTests
    {
        private readonly string _q1Page = TestDataLoader.Load("PracticeQualify1.html");
        private readonly string _q2Page = TestDataLoader.Load("Qualify2.html");

        [Fact]
        public void ParseQualify1_ParsesTrack()
        {
            var q1 = QualifyParser.ParseQualify1(_q1Page);
            Assert.Equal(57, q1.track);
        }

        [Fact]
        public void ParseQualify1_ParsesWeather()
        {
            var q1 = QualifyParser.ParseQualify1(_q1Page);
            Assert.Equal(Skies.Cloudy, q1.weather.skies);
            Assert.Equal(22, q1.weather.temperature);
            Assert.Equal(55, q1.weather.humidity);
        }

        [Fact]
        public void ParseQualify1_ParsesTime()
        {
            var q1 = QualifyParser.ParseQualify1(_q1Page);
            Assert.Equal(new TimeSpan(0, 0, 1, 22, 100), q1.time);
        }

        [Fact]
        public void ParseQualify1_ParsesSetup()
        {
            var q1 = QualifyParser.ParseQualify1(_q1Page);
            Assert.Equal(520, q1.setup.fWing);
            Assert.Equal(470, q1.setup.rWing);
            Assert.Equal(590, q1.setup.engine);
            Assert.Equal(340, q1.setup.brakes);
            Assert.Equal(410, q1.setup.gear);
            Assert.Equal(290, q1.setup.susp);
        }

        [Fact]
        public void ParseQualify1_ParsesTyres()
        {
            var q1 = QualifyParser.ParseQualify1(_q1Page);
            Assert.Equal(TyreType.Hard, q1.setup.tyres);
        }

        [Fact]
        public void ParseQualify1_ParsesRisk()
        {
            var q1 = QualifyParser.ParseQualify1(_q1Page);
            Assert.Equal(QualifyRisk.PushTheCarALot, q1.risk);
        }

        [Fact]
        public void ParseQualify2_ParsesTrack()
        {
            var q2 = QualifyParser.ParseQualify2(_q2Page);
            Assert.Equal(57, q2.track);
        }

        [Fact]
        public void ParseQualify2_ParsesWeather()
        {
            var q2 = QualifyParser.ParseQualify2(_q2Page);
            Assert.Equal(Skies.Rain, q2.weather.skies);
            Assert.Equal(18, q2.weather.temperature);
            Assert.Equal(80, q2.weather.humidity);
        }

        [Fact]
        public void ParseQualify2_ParsesTime()
        {
            var q2 = QualifyParser.ParseQualify2(_q2Page);
            Assert.Equal(new TimeSpan(0, 0, 1, 25, 678), q2.time);
        }

        [Fact]
        public void ParseQualify2_ParsesSetup()
        {
            var q2 = QualifyParser.ParseQualify2(_q2Page);
            Assert.Equal(530, q2.setup.fWing);
            Assert.Equal(460, q2.setup.rWing);
            Assert.Equal(580, q2.setup.engine);
            Assert.Equal(330, q2.setup.brakes);
            Assert.Equal(400, q2.setup.gear);
            Assert.Equal(280, q2.setup.susp);
        }

        [Fact]
        public void ParseQualify2_ParsesFuel()
        {
            var q2 = QualifyParser.ParseQualify2(_q2Page);
            Assert.Equal(48, q2.fuel);
        }

        [Fact]
        public void ParseQualify2_ParsesTyres()
        {
            var q2 = QualifyParser.ParseQualify2(_q2Page);
            Assert.Equal(TyreType.Rain, q2.setup.tyres);
        }

        [Fact]
        public void ParseQualify2_ParsesRisk()
        {
            var q2 = QualifyParser.ParseQualify2(_q2Page);
            Assert.Equal(QualifyRisk.PushTheCarToTheLimit, q2.risk);
        }

        [Fact]
        public void ParseQualify2_NoLapsDone_ReturnsEmpty()
        {
            var q2 = QualifyParser.ParseQualify2("<html>No qualify laps done</html>");
            Assert.Equal(TimeSpan.Zero, q2.time);
        }
    }
}
