using System;
using go.Parsers;
using Xunit;

namespace go.Tests.Parsers
{
    public class ExtractUntilTests
    {
        [Fact]
        public void ExtractUntil_ReturnsSubstringBeforeDelimiter()
        {
            Assert.Equal("hello", GenericParser.ExtractUntil("hello<world", 0, "<"));
        }

        [Fact]
        public void ExtractUntil_WithOffset()
        {
            Assert.Equal("world", GenericParser.ExtractUntil("hello>world<end", 6, "<"));
        }

        [Fact]
        public void ExtractUntil_DelimiterNotFound_ReturnsRest()
        {
            Assert.Equal("all text", GenericParser.ExtractUntil("all text", 0, "<"));
        }

        [Fact]
        public void ExtractUntil_MultiCharDelimiter()
        {
            Assert.Equal("42", GenericParser.ExtractUntil("42%</td>more", 0, "%"));
        }

        [Fact]
        public void ExtractUntil_EmptyResult()
        {
            Assert.Equal("", GenericParser.ExtractUntil("<tag>", 0, "<"));
        }

        [Fact]
        public void ExtractUntil_HtmlEntityDelimiter()
        {
            Assert.Equal("25", GenericParser.ExtractUntil("25&#176;C", 0, "&#"));
        }

        [Fact]
        public void ExtractIntUntil_ParsesInteger()
        {
            Assert.Equal(42, GenericParser.ExtractIntUntil("42<br>", 0, "<"));
        }

        [Fact]
        public void ExtractIntUntil_WithWhitespace()
        {
            Assert.Equal(7, GenericParser.ExtractIntUntil(" 7%", 0, "%"));
        }

        [Fact]
        public void ExtractIntUntil_FromHtmlCell()
        {
            string html = "<td align=\"center\">150</td>";
            int start = html.IndexOf(">") + 1;
            Assert.Equal(150, GenericParser.ExtractIntUntil(html, start, "<"));
        }

        [Fact]
        public void ExtractIntUntil_InvalidValue_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
                GenericParser.ExtractIntUntil("abc<end>", 0, "<"));
        }

        [Fact]
        public void ExtractIntUntil_EmptyValue_ThrowsFormatException()
        {
            Assert.Throws<FormatException>(() =>
                GenericParser.ExtractIntUntil("<end>", 0, "<"));
        }
    }
}
