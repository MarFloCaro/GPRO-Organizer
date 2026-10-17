using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    /// <summary>
    /// TrackParser cannot be unit tested in isolation because:
    ///
    /// 1. GetAllTracks() is the only public method, and it calls
    ///    Datas.Communications.GetPage() internally to fetch the track list page.
    /// 2. parseTrackPage(int num) is private and also calls
    ///    Datas.Communications.GetPage() internally to fetch each track's detail page.
    /// 3. Neither method accepts an HTML string parameter, so there is no way
    ///    to inject test HTML without refactoring the parser.
    ///
    /// TODO: Refactor TrackParser to accept an HTML string (like DriverParser.GetDriver
    ///       and other parsers), so the parsing logic can be tested independently of
    ///       network calls. Suggested signature:
    ///
    ///         public static Track ParseTrackPage(string html, int trackNumber)
    ///
    /// A reference HTML file (TrackDetails.html) is saved in TestData for use once
    /// this refactoring is done. Expected values for Bremgarten (track ID 57):
    ///
    ///   Name:                 "Bremgarten"
    ///   Power:                8
    ///   Handling:             26
    ///   Acceleration:         17
    ///   Race distance:        305.8 km
    ///   Laps:                 42
    ///   Lap distance:         7.281 km
    ///   Average speed:        272.82 km/h
    ///   Downforce:            Medium
    ///   Overtaking:           Normal
    ///   Suspension rigidity:  Medium
    ///   Fuel consumption:     Medium
    ///   Number of corners:    16
    ///   Tyre wear:            Medium
    ///   Grip level:           Low
    ///   Time in/out of pits:  17s
    ///   Category:             Ex F1  (HTML shows "ex F1")
    /// </summary>
    public class TrackParserTests
    {
        [Fact]
        public void TestDataFile_CanBeLoaded()
        {
            // Verify the reference HTML is accessible as embedded resource
            var html = TestDataLoader.Load("TrackDetails.html");
            Assert.NotNull(html);
            Assert.Contains("Bremgarten", html);
        }

        [Fact]
        public void TestDataFile_ContainsExpectedTrackFields()
        {
            var html = TestDataLoader.Load("TrackDetails.html");

            // Verify the HTML contains all the field labels the parser looks for
            Assert.Contains("Power:</TD>", html);
            Assert.Contains("Handling:</TD>", html);
            Assert.Contains("Acceleration:</TD>", html);
            Assert.Contains("Race distance:</TD>", html);
            Assert.Contains("Laps:</TD>", html);
            Assert.Contains("Downforce:</TD>", html);
            Assert.Contains("Lap distance:</TD>", html);
            Assert.Contains("Overtaking:</TD>", html);
            Assert.Contains("Average speed:</TD>", html);
            Assert.Contains("Suspension rigidity:</TD>", html);
            Assert.Contains("Fuel consumption:</TD>", html);
            Assert.Contains("Number of corners:</TD>", html);
            Assert.Contains("Tyre wear:</TD>", html);
            Assert.Contains("Grip level:</TD>", html);
            Assert.Contains("Time in/out of pits:</TD>", html);
            Assert.Contains("Category:</TD>", html);
        }

        [Fact]
        public void TestDataFile_ContainsContentInnerDiv()
        {
            // The parser starts by finding this div
            var html = TestDataLoader.Load("TrackDetails.html");
            Assert.Contains("<div id=\"contentinner\"", html);
        }

        [Fact]
        public void TestDataFile_ContainsLvlImages_ForPowerHandlingAcceleration()
        {
            // The parser counts "lvl" occurrences between the label and </TD>
            // to determine power, handling, and acceleration values
            var html = TestDataLoader.Load("TrackDetails.html");
            Assert.Contains("lvl.gif", html);
            Assert.Contains("lvl_dark.gif", html);
        }
    }
}
