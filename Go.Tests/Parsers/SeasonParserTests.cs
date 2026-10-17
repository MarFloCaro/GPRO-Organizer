using go.Parsers;
using go.Tests.TestData;
using Xunit;

namespace go.Tests.Parsers
{
    public class SeasonParserTests
    {
        private readonly string _seasonPage = TestDataLoader.Load("Calendar.html");

        [Fact]
        public void ParseSeason_Returns17Events()
        {
            var season = SeasonParser.ParseSeason(_seasonPage);

            Assert.Equal(17, season.Events.Length);
        }

        [Fact]
        public void ParseSeason_AllEventsHaveTrackIds()
        {
            var season = SeasonParser.ParseSeason(_seasonPage);

            for (int i = 0; i < season.Events.Length; i++)
            {
                Assert.True(season.Events[i].Trackid > 0,
                    $"Event at index {i} should have a positive track ID");
            }
        }

        [Fact]
        public void ParseSeason_FirstEventTrackId_IsCorrect()
        {
            var season = SeasonParser.ParseSeason(_seasonPage);

            Assert.Equal(49, season.Events[0].Trackid);
        }

        [Fact]
        public void ParseSeason_LastEventTrackId_IsCorrect()
        {
            var season = SeasonParser.ParseSeason(_seasonPage);

            Assert.Equal(15, season.Events[16].Trackid);
        }

        [Fact]
        public void ParseSeason_AllTrackIds_MatchExpected()
        {
            var expected = new[] { 49, 57, 51, 45, 22, 24, 1, 23, 52, 34, 64, 65, 63, 43, 40, 13, 15 };

            var season = SeasonParser.ParseSeason(_seasonPage);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.Equal(expected[i], season.Events[i].Trackid);
            }
        }

        [Fact]
        public void ParseSeason_DriverFavoriteTrack_ParsedCorrectly()
        {
            // Event 7 (index 6) has a driver favorite track span wrapping the link text
            var season = SeasonParser.ParseSeason(_seasonPage);

            Assert.Equal(1, season.Events[6].Trackid);
        }

        [Fact]
        public void ParseSeason_DoesNotParseTestTrack()
        {
            // The test track (Kyalami, id=20) appears after the 17 race events
            // and should not be included in the parsed events
            var season = SeasonParser.ParseSeason(_seasonPage);

            for (int i = 0; i < season.Events.Length; i++)
            {
                Assert.NotEqual(20, season.Events[i].Trackid);
            }
        }
    }
}
