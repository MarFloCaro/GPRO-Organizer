using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class CarParserTests
    {
        private readonly string _carPage = TestDataLoader.Load("UpdateCar.html");

        [Fact]
        public void GetCar_ParsesPower()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(75, car.power);
        }

        [Fact]
        public void GetCar_ParsesHandling()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(68, car.handling);
        }

        [Fact]
        public void GetCar_ParsesAcceleration()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(72, car.acceleration);
        }

        [Fact]
        public void GetCar_ParsesChassisLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(5, car.chassis.level);
        }

        [Fact]
        public void GetCar_ParsesChassisWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(22, car.chassis.wear);
        }

        [Fact]
        public void GetCar_ParsesEngineLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(7, car.engine.level);
        }

        [Fact]
        public void GetCar_ParsesEngineWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(18, car.engine.wear);
        }

        [Fact]
        public void GetCar_ParsesFrontWingLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(4, car.frontWing.level);
        }

        [Fact]
        public void GetCar_ParsesFrontWingWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(31, car.frontWing.wear);
        }

        [Fact]
        public void GetCar_ParsesRearWingLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(6, car.rearWing.level);
        }

        [Fact]
        public void GetCar_ParsesRearWingWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(14, car.rearWing.wear);
        }

        [Fact]
        public void GetCar_ParsesUnderbodyLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(3, car.underbody.level);
        }

        [Fact]
        public void GetCar_ParsesUnderbodyWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(45, car.underbody.wear);
        }

        [Fact]
        public void GetCar_ParsesSidepodsLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(8, car.sidepods.level);
        }

        [Fact]
        public void GetCar_ParsesSidepodsWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(9, car.sidepods.wear);
        }

        [Fact]
        public void GetCar_ParsesCoolingLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(2, car.cooling.level);
        }

        [Fact]
        public void GetCar_ParsesCoolingWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(55, car.cooling.wear);
        }

        [Fact]
        public void GetCar_ParsesGearboxLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(6, car.gearBox.level);
        }

        [Fact]
        public void GetCar_ParsesGearboxWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(20, car.gearBox.wear);
        }

        [Fact]
        public void GetCar_ParsesBrakesLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(4, car.brakes.level);
        }

        [Fact]
        public void GetCar_ParsesBrakesWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(37, car.brakes.wear);
        }

        [Fact]
        public void GetCar_ParsesSuspensionLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(5, car.suspension.level);
        }

        [Fact]
        public void GetCar_ParsesSuspensionWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(28, car.suspension.wear);
        }

        [Fact]
        public void GetCar_ParsesElectronicsLevel()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(7, car.electronics.level);
        }

        [Fact]
        public void GetCar_ParsesElectronicsWear()
        {
            var car = CarParser.GetCar(_carPage);
            Assert.Equal(11, car.electronics.wear);
        }
    }
}
