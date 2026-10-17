using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class StaffParserTests
    {
        private readonly string _staffPage = TestDataLoader.Load("StaffAndFacilities.html");

        [Fact]
        public void ParseStaff_ParsesOverall()
        {
            var staff = StaffParser.ParseStaff(_staffPage);
            Assert.Equal(22, staff.overall);
        }

        [Fact]
        public void ParseStaff_ParsesSalary()
        {
            var staff = StaffParser.ParseStaff(_staffPage);
            Assert.Equal(385200, staff.salary);
        }

        [Fact]
        public void ParseStaff_ParsesMaintenance()
        {
            var staff = StaffParser.ParseStaff(_staffPage);
            Assert.Equal(472800, staff.maintenance);
        }

        [Fact]
        public void ParseStaff_ParsesSkills()
        {
            var staff = StaffParser.ParseStaff(_staffPage);

            Assert.Equal(15, staff.experience);
            Assert.Equal(8, staff.motivation);
            Assert.Equal(18, staff.technicalSkill);
            Assert.Equal(24, staff.stressHandling);
            Assert.Equal(20, staff.concentration);
            Assert.Equal(16, staff.efficiency);
        }

        [Fact]
        public void ParseStaff_ParsesFacilities()
        {
            var staff = StaffParser.ParseStaff(_staffPage);

            Assert.Equal(14, staff.windtunnel);
            Assert.Equal(35, staff.pitstopTrainingCenter);
            Assert.Equal(22, staff.rDWorkshop);
            Assert.Equal(16, staff.rDDesignCenter);
            Assert.Equal(18, staff.engineeringWorkshop);
            Assert.Equal(5, staff.alloyAndChemicalLab);
            Assert.Equal(25, staff.commercial);
        }
    }
}
