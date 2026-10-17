using Xunit;

namespace go.Tests.Parsers
{
    public class GetRidOfLinksTests
    {
        // GetRidOfLinks is protected, so we test via a subclass
        private class TestableParser : go.Parsers.GenericParser
        {
            public static string CallGetRidOfLinks(string input) => GetRidOfLinks(input);
        }

        [Fact]
        public void GetRidOfLinks_RemovesSimpleTag()
        {
            Assert.Equal("hello", TestableParser.CallGetRidOfLinks("hello"));
        }

        [Fact]
        public void GetRidOfLinks_RemovesAnchorTag()
        {
            Assert.Equal("click here",
                TestableParser.CallGetRidOfLinks("<a href=\"test\">click here</a>"));
        }

        [Fact]
        public void GetRidOfLinks_RemovesMultipleTags()
        {
            Assert.Equal("one two three",
                TestableParser.CallGetRidOfLinks("one <b>two</b> three"));
        }

        [Fact]
        public void GetRidOfLinks_RemovesNestedContent()
        {
            Assert.Equal("before after",
                TestableParser.CallGetRidOfLinks("before <font color=\"red\">after</font>"));
        }

        [Fact]
        public void GetRidOfLinks_EmptyString()
        {
            Assert.Equal("", TestableParser.CallGetRidOfLinks(""));
        }

        [Fact]
        public void GetRidOfLinks_NoTags()
        {
            Assert.Equal("plain text", TestableParser.CallGetRidOfLinks("plain text"));
        }

        [Fact]
        public void GetRidOfLinks_ComplexHtml()
        {
            string input = "Pit, <a href=\"racescreen.asp?Lap=17\">Stop 1</a>, Weather";
            string expected = "Pit, Stop 1, Weather";
            Assert.Equal(expected, TestableParser.CallGetRidOfLinks(input));
        }
    }
}
