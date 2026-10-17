using System;
using go.Enums;
using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class PracticeParserTests
    {
        private readonly string _page = TestDataLoader.Load("PracticeQualify1Full.html");

        private Practice3 Parse(out RaceWeather wf)
        {
            wf = new RaceWeather();
            return PracticeParser.ParsePractice(_page, ref wf);
        }

        // --- Track ---

        [Fact]
        public void ParsePractice_ParsesTrack()
        {
            var p = Parse(out _);
            Assert.Equal(57, p.track);
        }

        // --- Practice weather ---

        [Fact]
        public void ParsePractice_ParsesPracticeWeather()
        {
            var p = Parse(out var wf);
            Assert.Equal(Skies.Cloudy, p.weather.skies);
            Assert.Equal(15, p.weather.temperature);
            Assert.Equal(29, p.weather.humidity);
            // RaceWeather.pracWeather should match
            Assert.Equal(Skies.Cloudy, wf.pracWeather.skies);
            Assert.Equal(15, wf.pracWeather.temperature);
            Assert.Equal(29, wf.pracWeather.humidity);
        }

        // --- Qualify weather ---

        [Fact]
        public void ParsePractice_ParsesQualifyWeather()
        {
            Parse(out var wf);
            Assert.Equal(Skies.Cloudy, wf.qualWeather.skies);
            Assert.Equal(16, wf.qualWeather.temperature);
            Assert.Equal(26, wf.qualWeather.humidity);
        }

        // --- Forecast ---

        [Fact]
        public void ParsePractice_ParsesForecast()
        {
            Parse(out var wf);
            Assert.True(wf.forecast.isReady);
            // Slot 0: 18-21 deg, 26-35% hum, 0% rain
            Assert.Equal(18, wf.forecast.minTemp[0]);
            Assert.Equal(21, wf.forecast.maxTemp[0]);
            Assert.Equal(26, wf.forecast.minHum[0]);
            Assert.Equal(35, wf.forecast.maxHum[0]);
            Assert.Equal(0, wf.forecast.minRain[0]);
            // Slot 1: 15-19 deg, 27-38% hum
            Assert.Equal(15, wf.forecast.minTemp[1]);
            Assert.Equal(19, wf.forecast.maxTemp[1]);
            Assert.Equal(27, wf.forecast.minHum[1]);
            Assert.Equal(38, wf.forecast.maxHum[1]);
        }

        // --- Lap 1 data ---

        [Fact]
        public void ParsePractice_Lap1_ParsesLapTime()
        {
            var p = Parse(out _);
            Assert.Equal(new TimeSpan(0, 0, 1, 48, 856), p.runs[0].lapTime);
        }

        [Fact]
        public void ParsePractice_Lap1_ParsesDriverMistake()
        {
            var p = Parse(out _);
            Assert.Equal(new TimeSpan(0, 0, 0, 0, 107), p.runs[0].driverMistake);
        }

        [Fact]
        public void ParsePractice_Lap1_ParsesNetTime()
        {
            var p = Parse(out _);
            Assert.Equal(new TimeSpan(0, 0, 1, 48, 749), p.runs[0].netTime);
        }

        [Fact]
        public void ParsePractice_Lap1_ParsesSetup()
        {
            var p = Parse(out _);
            Assert.Equal(619, p.runs[0].setup.fWing);
            Assert.Equal(619, p.runs[0].setup.rWing);
            Assert.Equal(782, p.runs[0].setup.engine);
            Assert.Equal(517, p.runs[0].setup.brakes);
            Assert.Equal(525, p.runs[0].setup.gear);
            Assert.Equal(693, p.runs[0].setup.susp);
            Assert.Equal(TyreType.ExtraSoft, p.runs[0].setup.tyres);
        }

        // --- Lap 5 data (different setup values) ---

        [Fact]
        public void ParsePractice_Lap5_ParsesLapTime()
        {
            var p = Parse(out _);
            Assert.Equal(new TimeSpan(0, 0, 1, 48, 593), p.runs[4].lapTime);
        }

        [Fact]
        public void ParsePractice_Lap5_ParsesSetup()
        {
            var p = Parse(out _);
            Assert.Equal(711, p.runs[4].setup.fWing);
            Assert.Equal(595, p.runs[4].setup.rWing);
            Assert.Equal(821, p.runs[4].setup.engine);
            Assert.Equal(554, p.runs[4].setup.brakes);
            Assert.Equal(564, p.runs[4].setup.gear);
            Assert.Equal(730, p.runs[4].setup.susp);
            Assert.Equal(TyreType.ExtraSoft, p.runs[4].setup.tyres);
        }

        // --- Lap 8 (last lap, uses "speccell" not "speccellnobot") ---

        [Fact]
        public void ParsePractice_Lap8_ParsesLapTime()
        {
            var p = Parse(out _);
            Assert.Equal(new TimeSpan(0, 0, 1, 48, 455), p.runs[7].lapTime);
        }

        [Fact]
        public void ParsePractice_Lap8_ParsesNetTime()
        {
            var p = Parse(out _);
            Assert.Equal(new TimeSpan(0, 0, 1, 48, 407), p.runs[7].netTime);
        }

        [Fact]
        public void ParsePractice_Lap8_ParsesSetup()
        {
            var p = Parse(out _);
            Assert.Equal(595, p.runs[7].setup.fWing);
            Assert.Equal(711, p.runs[7].setup.rWing);
            Assert.Equal(821, p.runs[7].setup.engine);
            Assert.Equal(554, p.runs[7].setup.brakes);
            Assert.Equal(564, p.runs[7].setup.gear);
            Assert.Equal(730, p.runs[7].setup.susp);
        }

        // --- Car parts ---

        [Fact]
        public void ParsePractice_ParsesFrontWing()
        {
            var p = Parse(out _);
            Assert.Equal(6, p.car.frontWing.level);
            Assert.Equal(30, p.car.frontWing.wear);
        }

        [Fact]
        public void ParsePractice_ParsesChassis()
        {
            var p = Parse(out _);
            Assert.Equal(6, p.car.chassis.level);
            Assert.Equal(24, p.car.chassis.wear);
        }

        [Fact]
        public void ParsePractice_ParsesRearWing()
        {
            var p = Parse(out _);
            Assert.Equal(6, p.car.rearWing.level);
            Assert.Equal(32, p.car.rearWing.wear);
        }

        [Fact]
        public void ParsePractice_ParsesUnderbody()
        {
            var p = Parse(out _);
            Assert.Equal(7, p.car.underbody.level);
            Assert.Equal(39, p.car.underbody.wear);
        }

        [Fact]
        public void ParsePractice_ParsesEngine()
        {
            var p = Parse(out _);
            Assert.Equal(6, p.car.engine.level);
            Assert.Equal(25, p.car.engine.wear);
        }

        [Fact]
        public void ParsePractice_ParsesSidepods()
        {
            var p = Parse(out _);
            Assert.Equal(7, p.car.sidepods.level);
            Assert.Equal(22, p.car.sidepods.wear);
        }

        [Fact]
        public void ParsePractice_ParsesBrakes()
        {
            var p = Parse(out _);
            Assert.Equal(4, p.car.brakes.level);
            Assert.Equal(34, p.car.brakes.wear);
        }

        [Fact]
        public void ParsePractice_ParsesCooling()
        {
            var p = Parse(out _);
            Assert.Equal(5, p.car.cooling.level);
            Assert.Equal(26, p.car.cooling.wear);
        }

        [Fact]
        public void ParsePractice_ParsesGearBox()
        {
            var p = Parse(out _);
            Assert.Equal(6, p.car.gearBox.level);
            Assert.Equal(32, p.car.gearBox.wear);
        }

        [Fact]
        public void ParsePractice_ParsesElectronics()
        {
            var p = Parse(out _);
            Assert.Equal(6, p.car.electronics.level);
            Assert.Equal(19, p.car.electronics.wear);
        }

        [Fact]
        public void ParsePractice_ParsesSuspension()
        {
            var p = Parse(out _);
            Assert.Equal(6, p.car.suspension.level);
            Assert.Equal(43, p.car.suspension.wear);
        }

        // --- Comments ---

        [Fact]
        public void ParsePractice_Lap1_ParsesComments()
        {
            var p = Parse(out _);
            // Lap 1: Engine + Gear comments (part names include trailing </b> from HTML)
            Assert.Equal(4, p.runs[0].comments.Length);
            Assert.Contains("Engine", p.runs[0].comments[0]);
            Assert.Contains("engine power", p.runs[0].comments[1]);
            Assert.Contains("Gear", p.runs[0].comments[2]);
            Assert.Contains("red", p.runs[0].comments[3]);
        }

        [Fact]
        public void ParsePractice_Lap5_SatisfiedComment()
        {
            var p = Parse(out _);
            // Lap 5: "I am satisfied with the setup of the car"
            Assert.Single(p.runs[4].comments);
            Assert.Equal("I am satisfied with the setup of the car", p.runs[4].comments[0]);
        }

        // --- No driver edge case ---

        [Fact]
        public void ParsePractice_NoDriver_ThrowsException()
        {
            var noDriverPage = "<html><body><a href=\"SignRandomDriver.asp\" >Sign a driver</a></body></html>";
            var wf = new RaceWeather();
            var ex = Assert.Throws<Exception>(() => PracticeParser.ParsePractice(noDriverPage, ref wf));
            Assert.Equal("You do not have a driver", ex.Message);
        }
    }
}
