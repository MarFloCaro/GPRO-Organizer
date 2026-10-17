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
            Assert.Equal(17, staff.overall);
        }

        [Fact]
        public void ParseStaff_ParsesSalary()
        {
            var staff = StaffParser.ParseStaff(_staffPage);
            Assert.Equal(466470, staff.salary);
        }

        [Fact]
        public void ParseStaff_ParsesMaintenance()
        {
            var staff = StaffParser.ParseStaff(_staffPage);
            Assert.Equal(543150, staff.maintenance);
        }

        [Fact]
        public void ParseStaff_ParsesSkills()
        {
            var staff = StaffParser.ParseStaff(_staffPage);

            Assert.Equal(12, staff.experience);
            Assert.Equal(0, staff.motivation);
            Assert.Equal(12, staff.technicalSkill);
            Assert.Equal(21, staff.stressHandling);
            Assert.Equal(17, staff.concentration);
            Assert.Equal(18, staff.efficiency);
        }

        [Fact]
        public void ParseStaff_ParsesFacilities()
        {
            var staff = StaffParser.ParseStaff(_staffPage);

            Assert.Equal(19, staff.windtunnel);
            Assert.Equal(41, staff.pitstopTrainingCenter);
            Assert.Equal(26, staff.rDWorkshop);
            Assert.Equal(18, staff.rDDesignCenter);
            Assert.Equal(20, staff.engineeringWorkshop);
            Assert.Equal(0, staff.alloyAndChemicalLab);
            Assert.Equal(29, staff.commercial);
        }
    }
}
