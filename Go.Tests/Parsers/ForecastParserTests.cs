using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class ForecastParserTests
    {
        private readonly string _forecastPage = TestDataLoader.Load("RaceForecast.html");

        [Fact]
        public void ParseForecast_IsReady()
        {
            var forecast = ForecastParser.ParseForecast(_forecastPage);
            Assert.True(forecast.isReady);
        }

        [Fact]
        public void ParseForecast_ParsesTemp()
        {
            var forecast = ForecastParser.ParseForecast(_forecastPage);
            Assert.Equal(18, forecast.minTemp[0]);
            Assert.Equal(21, forecast.maxTemp[0]);
            Assert.Equal(15, forecast.minTemp[1]);
            Assert.Equal(19, forecast.maxTemp[1]);
            Assert.Equal(16, forecast.minTemp[2]);
            Assert.Equal(19, forecast.maxTemp[2]);
            Assert.Equal(14, forecast.minTemp[3]);
            Assert.Equal(17, forecast.maxTemp[3]);
        }

        [Fact]
        public void ParseForecast_ParsesHumidity()
        {
            var forecast = ForecastParser.ParseForecast(_forecastPage);
            Assert.Equal(26, forecast.minHum[0]);
            Assert.Equal(35, forecast.maxHum[0]);
            Assert.Equal(27, forecast.minHum[1]);
            Assert.Equal(38, forecast.maxHum[1]);
            Assert.Equal(25, forecast.minHum[2]);
            Assert.Equal(36, forecast.maxHum[2]);
            Assert.Equal(24, forecast.minHum[3]);
            Assert.Equal(34, forecast.maxHum[3]);
        }

        [Fact]
        public void ParseForecast_ParsesRainZero()
        {
            var forecast = ForecastParser.ParseForecast(_forecastPage);
            Assert.Equal(0, forecast.minRain[0]);
            Assert.Equal(0, forecast.minRain[1]);
            Assert.Equal(0, forecast.minRain[2]);
        }

        [Fact]
        public void ParseForecast_ParsesRainRange()
        {
            var forecast = ForecastParser.ParseForecast(_forecastPage);
            Assert.Equal(5, forecast.minRain[3]);
            Assert.Equal(15, forecast.maxRain[3]);
        }
    }
}
