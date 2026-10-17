using System;
using go.Parsers;
using Xunit;

namespace go.Tests.Parsers
{
    public class GenericParserTests
    {
        [Theory]
        [InlineData("Jan", 1)]
        [InlineData("Feb", 2)]
        [InlineData("Mar", 3)]
        [InlineData("Apr", 4)]
        [InlineData("May", 5)]
        [InlineData("Jun", 6)]
        [InlineData("Jul", 7)]
        [InlineData("Aug", 8)]
        [InlineData("Sep", 9)]
        [InlineData("Oct", 10)]
        [InlineData("Nov", 11)]
        [InlineData("Dec", 12)]
        [InlineData("???", 0)]
        public void GetMonth_ReturnsCorrectNumber(string input, int expected)
        {
            Assert.Equal(expected, GenericParser.GetMonth(input));
        }

        [Fact]
        public void GetMoneyAmount_ParsesPositiveAmount()
        {
            Assert.Equal(1234, GenericParser.GetMoneyAmount("$1.234<br>"));
        }

        [Fact]
        public void GetMoneyAmount_ParsesNegativeAmount()
        {
            Assert.Equal(-500, GenericParser.GetMoneyAmount("$-500<br>"));
        }

        [Fact]
        public void GetMoneyAmount_WithErrorContext_ParsesAmount()
        {
            Assert.Equal(9876, GenericParser.GetMoneyAmount("$9.876<br>", "test"));
        }

        [Fact]
        public void ParseTimeSpan_ValidTime()
        {
            var result = GenericParser.ParseTimeSpan("1:23.456");
            Assert.Equal(new TimeSpan(0, 0, 1, 23, 456), result);
        }

        [Fact]
        public void ParseTimeSpan_EmptyString_ReturnsMinValue()
        {
            Assert.Equal(TimeSpan.MinValue, GenericParser.ParseTimeSpan(""));
        }
    }
}
