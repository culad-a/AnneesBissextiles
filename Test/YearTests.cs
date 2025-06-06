using Xunit;
using AnneesBissextiles;

namespace AnneesBissextiles.Tests
{
    public class YearTests
    {
        [Fact]
        public void TestYearNotDivisibleBy4()
        {
            bool result = Year.Check(2001);
            Assert.False(result);
        }
        [Fact]
        public void TestYearDivisibleBy100ButNot400()
        {
            bool result = Year.Check(1900);
            Assert.False(result);
        }
        [Fact]
        public void TestYearDivisibleBy4ButNot100()
        {
            bool result = Year.Check(1996);
            Assert.True(result);
        }
    }
}
