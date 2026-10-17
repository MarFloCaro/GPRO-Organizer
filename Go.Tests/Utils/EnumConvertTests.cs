using go.Enums;
using go.Utils;
using Xunit;

namespace go.Tests.Utils
{
    public class EnumConvertTests
    {
        [Theory]
        [InlineData("Very low", Downforce.Verylow)]
        [InlineData("Low", Downforce.Low)]
        [InlineData("Medium", Downforce.Medium)]
        [InlineData("High", Downforce.High)]
        [InlineData("Very high", Downforce.VeryHigh)]
        [InlineData("VERY HIGH", Downforce.VeryHigh)]
        [InlineData("???", Downforce.VeryHigh)]
        public void String2Downforce_MapsCorrectly(string input, Downforce expected)
        {
            Assert.Equal(expected, EnumConvert.String2Downforce(input));
        }

        [Theory]
        [InlineData(Downforce.Verylow, "Very low")]
        [InlineData(Downforce.VeryHigh, "Very high")]
        public void Enum2String_Downforce(Downforce input, string expected)
        {
            Assert.Equal(expected, EnumConvert.Enum2String(input));
        }

        [Theory]
        [InlineData("Normal", Grip.Medium)]
        [InlineData("Very low", Grip.VeryLow)]
        [InlineData("???", Grip.Unknown)]
        public void String2Grip_NormalMapsMedium(string input, Grip expected)
        {
            Assert.Equal(expected, EnumConvert.String2Grip(input));
        }

        [Fact]
        public void Enum2String_Grip_MediumReturnsNormal()
        {
            Assert.Equal("Normal", EnumConvert.Enum2String(Grip.Medium));
        }

        [Theory]
        [InlineData("Normal", SponsorPriority.Medium)]
        [InlineData("Medium", SponsorPriority.Medium)]
        [InlineData("???", SponsorPriority.Medium)]
        public void String2SponsorPriority_AliasAndDefault(string input, SponsorPriority expected)
        {
            Assert.Equal(expected, EnumConvert.String2SponsorPriority(input));
        }

        [Theory]
        [InlineData("Partially Cloudy", Skies.PartiallyCloudy)]
        [InlineData("partially cloudy", Skies.PartiallyCloudy)]
        [InlineData("Sunny", Skies.Sunny)]
        [InlineData("???", Skies.Rain)]
        public void String2Skies_CaseInsensitive(string input, Skies expected)
        {
            Assert.Equal(expected, EnumConvert.String2Skies(input));
        }

        [Theory]
        [InlineData("Extra Soft", TyreType.ExtraSoft)]
        [InlineData("Rain", TyreType.Rain)]
        [InlineData("???", TyreType.Unknown)]
        public void String2Tyres_MapsCorrectly(string input, TyreType expected)
        {
            Assert.Equal(expected, EnumConvert.String2Tyres(input));
        }

        [Theory]
        [InlineData("Keep the car on the track", QualifyRisk.KeepTheCarOnTheTrack)]
        [InlineData("Push the car to the limit", QualifyRisk.PushTheCarToTheLimit)]
        [InlineData("???", QualifyRisk.Unknown)]
        public void String2QualifyRisk_MapsCorrectly(string input, QualifyRisk expected)
        {
            Assert.Equal(expected, EnumConvert.String2QualifyRisk(input));
        }

        [Theory]
        [InlineData("Avoid trouble", RaceStartStrategy.AvoidTrouble)]
        [InlineData("???", RaceStartStrategy.ForceTowardsFront)]
        public void String2Strategy_MapsCorrectly(string input, RaceStartStrategy expected)
        {
            Assert.Equal(expected, EnumConvert.String2Strategy(input));
        }

        [Theory]
        [InlineData("No special priority", TestPriority.NoSpecialPriority)]
        [InlineData("Car limits", TestPriority.TestCarLimits)]
        [InlineData("Test car limits", TestPriority.TestCarLimits)]
        [InlineData("???", TestPriority.Unknown)]
        public void String2Priority_IncludingAlias(string input, TestPriority expected)
        {
            Assert.Equal(expected, EnumConvert.String2Priority(input));
        }

        [Fact]
        public void Enum2String_PitStopReason_DefaultIsTyres()
        {
            Assert.Equal("Tyres", EnumConvert.Enum2String(PitStopReason.WornTyres));
        }

        [Theory]
        [InlineData(TyreType.ExtraSoft, "Extra Soft")]
        [InlineData(TyreType.Rain, "Rain")]
        public void Roundtrip_TyreType(TyreType value, string display)
        {
            Assert.Equal(display, EnumConvert.Enum2String(value));
            Assert.Equal(value, EnumConvert.String2Tyres(display));
        }

        [Theory]
        [InlineData(Skies.Sunny, "Sunny")]
        [InlineData(Skies.VeryCloudy, "Very Cloudy")]
        [InlineData(Skies.Rain, "Rain")]
        public void Roundtrip_Skies(Skies value, string display)
        {
            Assert.Equal(display, EnumConvert.Enum2String(value));
            Assert.Equal(value, EnumConvert.String2Skies(display));
        }
    }
}
