using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class DriverParserTests
    {
        private readonly string _driverPage = TestDataLoader.Load("DriverProfile.html");

        [Fact]
        public void GetDriver_ParsesName()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal("John Doe", driver.name);
        }

        [Fact]
        public void GetDriver_ParsesNationality()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal("United Kingdom", driver.nationality);
        }

        [Fact]
        public void GetDriver_ParsesTrophies()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(0, driver.trophies);
        }

        [Fact]
        public void GetDriver_ParsesNumberOfGps()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(143, driver.numberOfGps);
        }

        [Fact]
        public void GetDriver_ParsesWins()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(11, driver.wins);
        }

        [Fact]
        public void GetDriver_ParsesPodiums()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(18, driver.podiums);
        }

        [Fact]
        public void GetDriver_ParsesPointsScored()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(190, driver.pointsScored);
        }

        [Fact]
        public void GetDriver_ParsesPolePositions()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(11, driver.polePositions);
        }

        [Fact]
        public void GetDriver_ParsesFastestLaps()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(4, driver.fastestLaps);
        }

        [Fact]
        public void GetDriver_ParsesOverall()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(133, driver.overall);
        }

        [Fact]
        public void GetDriver_ParsesSalary()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(610326, driver.salary);
        }

        [Fact]
        public void GetDriver_ParsesRacesLeftOfContract()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(10, driver.racesLeftOfContract);
        }

        [Fact]
        public void GetDriver_ParsesConcentration()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(172, driver.concentration);
        }

        [Fact]
        public void GetDriver_ParsesTalent()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(201, driver.talent);
        }

        [Fact]
        public void GetDriver_ParsesAggressiveness()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(7, driver.aggresiveness);
        }

        [Fact]
        public void GetDriver_ParsesExperience()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(156, driver.experience);
        }

        [Fact]
        public void GetDriver_ParsesTechnicalInsight()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(152, driver.technicalInsight);
        }

        [Fact]
        public void GetDriver_ParsesStamina()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(150, driver.stamina);
        }

        [Fact]
        public void GetDriver_ParsesCharisma()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(59, driver.charisma);
        }

        [Fact]
        public void GetDriver_ParsesMotivation()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(0, driver.motivation);
        }

        [Fact]
        public void GetDriver_ParsesEnergy()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(59, driver.energy);
        }

        [Fact]
        public void GetDriver_ParsesFavoriteTracks()
        {
            var driver = DriverParser.GetDriver(_driverPage, 1);
            Assert.Equal(new[] { 1, 19 }, driver.favoriteTracks);
        }

        [Fact]
        public void GetDriver_SetsId()
        {
            var driver = DriverParser.GetDriver(_driverPage, 42);
            Assert.Equal(42, driver.id);
        }
    }
}
