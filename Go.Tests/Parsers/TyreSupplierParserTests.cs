using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class TyreSupplierParserTests
    {
        private readonly string _supplierPage = TestDataLoader.Load("Suppliers.html");

        [Fact]
        public void GetTyreSupplier_ParsesName()
        {
            var supplier = TyreSupplierParser.GetTyreSupplier(_supplierPage);
            Assert.Equal("Dunnolop", supplier.name);
        }

        [Fact]
        public void GetTyreSupplier_ParsesDryPerformance()
        {
            var supplier = TyreSupplierParser.GetTyreSupplier(_supplierPage);
            Assert.Equal(4, supplier.dryPerf);
        }

        [Fact]
        public void GetTyreSupplier_ParsesWetPerformance()
        {
            var supplier = TyreSupplierParser.GetTyreSupplier(_supplierPage);
            Assert.Equal(3, supplier.wetPerf);
        }

        [Fact]
        public void GetTyreSupplier_ParsesPeakTemperature()
        {
            var supplier = TyreSupplierParser.GetTyreSupplier(_supplierPage);
            Assert.Equal(21, supplier.peakTemp);
        }

        [Fact]
        public void GetTyreSupplier_ParsesDurability()
        {
            var supplier = TyreSupplierParser.GetTyreSupplier(_supplierPage);
            Assert.Equal(4, supplier.durability);
        }

        [Fact]
        public void GetTyreSupplier_ParsesWarmupDistance()
        {
            var supplier = TyreSupplierParser.GetTyreSupplier(_supplierPage);
            Assert.Equal(6, supplier.warmUpDistance);
        }

        [Fact]
        public void GetTyreSupplier_NoContract_ReturnsEmpty()
        {
            var supplier = TyreSupplierParser.GetTyreSupplier("<html>no contract here</html>");
            Assert.Equal(0, supplier.dryPerf);
            Assert.Equal(0, supplier.peakTemp);
        }
    }
}
