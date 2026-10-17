using go.Enums;
using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class SponsorParserTests
    {
        private readonly string _sponsorPage = TestDataLoader.Load("Sponsors.html");

        [Fact]
        public void GetSponsor_ParsesOngoingName()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal("Turbo Energy", sponsor.ongoing[0].name);
            Assert.Equal("MegaCorp", sponsor.ongoing[1].name);
            Assert.Equal("SpeedWear", sponsor.ongoing[2].name);
            Assert.Equal("AeroTech", sponsor.ongoing[3].name);
            Assert.Equal("FuelMax", sponsor.ongoing[4].name);
        }

        [Fact]
        public void GetSponsor_ParsesOngoingSpot()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal("Car", sponsor.ongoing[0].spot);
            Assert.Equal("Helmet", sponsor.ongoing[1].spot);
            Assert.Equal("Overalls", sponsor.ongoing[2].spot);
            Assert.Equal("Cap", sponsor.ongoing[3].spot);
            Assert.Equal("Car", sponsor.ongoing[4].spot);
        }

        [Fact]
        public void GetSponsor_ParsesOngoingAmountPerRace()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(150000.0, sponsor.ongoing[0].amountPerRace);
            Assert.Equal(80000.0, sponsor.ongoing[1].amountPerRace);
            Assert.Equal(0.0, sponsor.ongoing[2].amountPerRace);
            Assert.Equal(45500.0, sponsor.ongoing[3].amountPerRace);
            Assert.Equal(200000.0, sponsor.ongoing[4].amountPerRace);
        }

        [Fact]
        public void GetSponsor_ParsesOngoingContractStatus()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal("Active", sponsor.ongoing[0].contractStatus);
            Assert.Equal("Active", sponsor.ongoing[1].contractStatus);
            Assert.Equal("Pending", sponsor.ongoing[2].contractStatus);
            Assert.Equal("Active", sponsor.ongoing[3].contractStatus);
            Assert.Equal("Active", sponsor.ongoing[4].contractStatus);
        }

        [Fact]
        public void GetSponsor_ParsesOngoingRacesLeft()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(8, sponsor.ongoing[0].racesLeft);
            Assert.Equal(5, sponsor.ongoing[1].racesLeft);
            Assert.Equal(0, sponsor.ongoing[2].racesLeft);
            Assert.Equal(3, sponsor.ongoing[3].racesLeft);
            Assert.Equal(12, sponsor.ongoing[4].racesLeft);
        }

        [Fact]
        public void GetSponsor_ParsesOngoingSponsorSatisfaction()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(75, sponsor.ongoing[0].sponsorSatisfaction);
            Assert.Equal(60, sponsor.ongoing[1].sponsorSatisfaction);
            Assert.Equal(0, sponsor.ongoing[2].sponsorSatisfaction);
            Assert.Equal(90, sponsor.ongoing[3].sponsorSatisfaction);
            Assert.Equal(50, sponsor.ongoing[4].sponsorSatisfaction);
        }

        [Fact]
        public void GetSponsor_ParsesNegotiationSponsorId()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(201, sponsor.negotiations[0].sponsorId);
            Assert.Equal(202, sponsor.negotiations[1].sponsorId);
        }

        [Fact]
        public void GetSponsor_ParsesNegotiationName()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal("FastFuel Inc", sponsor.negotiations[0].name);
            Assert.Equal("GripTyre Co", sponsor.negotiations[1].name);
        }

        [Fact]
        public void GetSponsor_ParsesNegotiationSpot()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal("Car", sponsor.negotiations[0].spot);
            Assert.Equal("Helmet", sponsor.negotiations[1].spot);
        }

        [Fact]
        public void GetSponsor_ParsesNegotiationAmountPerRace()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(120000.0, sponsor.negotiations[0].amountPerRace);
            Assert.Equal(0.0, sponsor.negotiations[1].amountPerRace);
        }

        [Fact]
        public void GetSponsor_ParsesNegotiationDuration()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(16, sponsor.negotiations[0].duration);
            Assert.Equal(0, sponsor.negotiations[1].duration);
        }

        [Fact]
        public void GetSponsor_ParsesNegotiationProgress()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(65.5, sponsor.negotiations[0].progress);
            Assert.Equal(30.0, sponsor.negotiations[1].progress);
        }

        [Fact]
        public void GetSponsor_ParsesNegotiationPriority()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Equal(SponsorPriority.High, sponsor.negotiations[0].priority);
            Assert.Equal(SponsorPriority.Low, sponsor.negotiations[1].priority);
        }

        [Fact]
        public void GetSponsor_ReturnsNullDuringRaceUpdate()
        {
            var page = " During the race and the update all representatives of the sponsor companies";
            var sponsor = SponsorParser.GetSponsor(page);

            Assert.Null(sponsor);
        }

        [Fact]
        public void GetSponsor_HasNoThirdNegotiation()
        {
            var sponsor = SponsorParser.GetSponsor(_sponsorPage);

            Assert.Null(sponsor.negotiations[2]);
        }
    }
}
