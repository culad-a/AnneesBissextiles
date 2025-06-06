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
    }
}
