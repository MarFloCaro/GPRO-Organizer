using go.Enums;
using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class StrategyParserTests
    {
        private readonly string _strategyPage = TestDataLoader.Load("RaceSetup.html");

        [Fact]
        public void ParseStrategy_SetsIsStrategyUpdated()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);
            Assert.True(strategy.isStrategyUpdated);
        }

        [Fact]
        public void ParseStrategy_ParsesSetup()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);

            Assert.Equal(530, strategy.setup.fWing);
            Assert.Equal(410, strategy.setup.rWing);
            Assert.Equal(620, strategy.setup.engine);
            Assert.Equal(350, strategy.setup.brakes);
            Assert.Equal(480, strategy.setup.gear);
            Assert.Equal(290, strategy.setup.susp);
        }

        [Fact]
        public void ParseStrategy_ParsesFuel()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);

            Assert.Equal(55, strategy.startFuel);
            Assert.Equal(60, strategy.stop1Fuel);
            Assert.Equal(45, strategy.stop2Fuel);
            Assert.Equal(0, strategy.stop3Fuel);
            Assert.Equal(0, strategy.stop4Fuel);
            Assert.Equal(0, strategy.stop5Fuel);
        }

        [Fact]
        public void ParseStrategy_ParsesTyres()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);

            Assert.Equal(TyreType.Soft, strategy.startTyres);
            Assert.Equal(TyreType.Rain, strategy.rainTyres);
            Assert.Equal(TyreType.Hard, strategy.dryTyres);
        }

        [Fact]
        public void ParseStrategy_ParsesPitAfterWeatherChange()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);

            Assert.Equal(2, strategy.pitAfterRain);
            Assert.Equal(3, strategy.pitAfterDry);
        }

        [Fact]
        public void ParseStrategy_ParsesRisks()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);

            Assert.Equal(30, strategy.riskOvertake);
            Assert.Equal(40, strategy.riskDefend);
            Assert.Equal(50, strategy.riskClear);
            Assert.Equal(35, strategy.riskWet);
            Assert.Equal(10, strategy.riskMalfunction);
        }

        [Fact]
        public void ParseStrategy_ParsesBoostLaps()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);

            Assert.Equal(5, strategy.boostLap1);
            Assert.Equal(15, strategy.boostLap2);
            Assert.Equal(25, strategy.boostLap3);
        }

        [Fact]
        public void ParseStrategy_ParsesPitIfSolvableProblem()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);
            Assert.True(strategy.pitIfSolvableProblem);
        }

        [Fact]
        public void ParseStrategy_ParsesPitLapLimit()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);
            Assert.Equal(12, strategy.pitLapLimit);
        }

        [Fact]
        public void ParseStrategy_ParsesDontRefuelOnTechnicalProblems()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);
            Assert.True(strategy.dontrefuelOnTechnicalProblems);
        }

        [Fact]
        public void ParseStrategy_ParsesStartStrategy()
        {
            var strategy = StrategyParser.ParseStrategy(_strategyPage);
            Assert.Equal(RaceStartStrategy.ForceTowardsFront, strategy.startStrategy);
        }

        [Fact]
        public void ParseStrategy_GrayedOutPage_ReturnsDefaultStrategy()
        {
            var grayPage = " <font color=\"gray\">Get settings from Qualify 1";
            var strategy = StrategyParser.ParseStrategy(grayPage);

            Assert.False(strategy.isStrategyUpdated);
        }
    }
}
