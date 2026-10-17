using System;
using System.Collections;
using go.Parsers;
using go.Tests.TestData;
using go.Utils;
using Xunit;

namespace go.Tests.Parsers
{
    public class FinanceParserTests : IDisposable
    {
        private readonly string _financePage = TestDataLoader.Load("EconomyHistory.html");

        public FinanceParserTests()
        {
            Datas.FinanceHistory = new ArrayList();
        }

        public void Dispose()
        {
            Datas.FinanceHistory = null;
        }

        [Fact]
        public void UpdateFinancialHistory_ParsesCorrectNumberOfItems()
        {
            var result = FinanceParser.UpdateFinancialHistory(_financePage);

            Assert.Equal(7, result.Count);
        }

        [Fact]
        public void UpdateFinancialHistory_ParsesDescriptions()
        {
            var result = FinanceParser.UpdateFinancialHistory(_financePage);

            Assert.Equal("Tyre supplier costs (Dunnolop)", ((FinanceItem)result[0]).Description);
            Assert.Equal("Facility costs", ((FinanceItem)result[1]).Description);
            Assert.Equal("Salary for your staff", ((FinanceItem)result[2]).Description);
            Assert.Equal("Sponsor money", ((FinanceItem)result[3]).Description);
            Assert.Equal("Race 1 finish position (19)", ((FinanceItem)result[4]).Description);
            Assert.Equal("Qualify 2 lap costs", ((FinanceItem)result[5]).Description);
            Assert.Equal("Practice lap costs x 8", ((FinanceItem)result[6]).Description);
        }

        [Fact]
        public void UpdateFinancialHistory_ParsesAmounts()
        {
            var result = FinanceParser.UpdateFinancialHistory(_financePage);

            Assert.Equal(-2510000, ((FinanceItem)result[0]).Amount);
            Assert.Equal(-546700, ((FinanceItem)result[1]).Amount);
            Assert.Equal(-466470, ((FinanceItem)result[2]).Amount);
            Assert.Equal(2348234, ((FinanceItem)result[3]).Amount);
            Assert.Equal(11484615, ((FinanceItem)result[4]).Amount);
            Assert.Equal(-100000, ((FinanceItem)result[5]).Amount);
            Assert.Equal(-400000, ((FinanceItem)result[6]).Amount);
        }

        [Fact]
        public void UpdateFinancialHistory_ParsesBalanceBefore()
        {
            var result = FinanceParser.UpdateFinancialHistory(_financePage);

            Assert.Equal(50781932, ((FinanceItem)result[0]).BalanceBefore);
            Assert.Equal(51328632, ((FinanceItem)result[1]).BalanceBefore);
            Assert.Equal(49446868, ((FinanceItem)result[3]).BalanceBefore);
        }

        [Fact]
        public void UpdateFinancialHistory_ParsesBalanceAfter()
        {
            var result = FinanceParser.UpdateFinancialHistory(_financePage);

            Assert.Equal(48271932, ((FinanceItem)result[0]).BalanceAfter);
            Assert.Equal(50781932, ((FinanceItem)result[1]).BalanceAfter);
            Assert.Equal(51795102, ((FinanceItem)result[3]).BalanceAfter);
        }

        [Fact]
        public void UpdateFinancialHistory_ParsesDates()
        {
            var result = FinanceParser.UpdateFinancialHistory(_financePage);

            var expectedDate1 = new DateTime(2026, 10, 16, 22, 0, 57);
            var expectedDate2 = new DateTime(2026, 10, 15, 21, 11, 20);
            var expectedDate3 = new DateTime(2026, 10, 15, 21, 4, 32);

            Assert.Equal(expectedDate1, ((FinanceItem)result[0]).Date);
            Assert.Equal(expectedDate1, ((FinanceItem)result[1]).Date);
            Assert.Equal(expectedDate2, ((FinanceItem)result[5]).Date);
            Assert.Equal(expectedDate3, ((FinanceItem)result[6]).Date);
        }

        [Fact]
        public void UpdateFinancialHistory_ReturnsEmptyForNoTransactions()
        {
            var page = "<html><body><b>No transactions recorded<b></body></html>";

            var result = FinanceParser.UpdateFinancialHistory(page);

            Assert.Empty(result);
        }

        [Fact]
        public void UpdateFinancialHistory_StopsAtExistingHistoryDate()
        {
            // Pre-populate history with an item dated Oct 16th - the parser should
            // stop when it encounters items at or before this date.
            var existingItem = new FinanceItem
            {
                Date = new DateTime(2026, 10, 16, 22, 0, 57),
                Description = "Old item"
            };
            Datas.FinanceHistory.Add(existingItem);

            var result = FinanceParser.UpdateFinancialHistory(_financePage);

            // The first item's date (Oct 16 22:00:57) is NOT greater than the
            // existing history date (also Oct 16 22:00:57), so the parser should
            // stop immediately and merge with existing history.
            // Result = 0 new items + 1 existing = 1
            var single = Assert.Single(result);
            Assert.Equal("Old item", ((FinanceItem)single).Description);
        }
    }
}
