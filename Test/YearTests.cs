using Xunit;
using AnneesBissextiles;

namespace AnneesBissextiles.Tests
{
    public class YearTests
    {
        [Theory]
        [InlineData(2001)]
        [InlineData(2019)]
        [InlineData(2101)]
        [InlineData(1999)]
        public void YearsNotDivisibleBy4_AreNotLeapYears(int year)
        {
            bool result = Year.Check(year);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1900)]
        [InlineData(1800)]
        [InlineData(2100)]
        public void YearsDivisibleBy100ButNot400_AreNotLeapYears(int year)
        {
            bool result = Year.Check(year);
            Assert.False(result);
        }

        [Theory]
        [InlineData(1996)]
        [InlineData(2004)]
        [InlineData(2020)]
        public void YearsDivisibleBy4ButNot100_AreLeapYears(int year)
        {
            bool result = Year.Check(year);
            Assert.True(result);
        }

        [Theory]
        [InlineData(1600)]
        [InlineData(2000)]
        [InlineData(2400)]
        public void YearsDivisibleBy400_AreLeapYears(int year)
        {
            bool result = Year.Check(year);
            Assert.True(result);
        }
    }
}
