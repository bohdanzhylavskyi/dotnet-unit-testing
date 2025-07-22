namespace Utils.Tests
{
    public class IsLeapYearTests
    {
        [Theory]
        [InlineData(424)]
        [InlineData(1992)]
        [InlineData(2004)]
        [InlineData(2016)]
        [InlineData(2020)]
        public void IsLeapYear_TypicalLeapYears_ReturnsTrue(int year)
        {
            var actualResult = Utils.IsLeapYear(year);

            Assert.True(actualResult, $"'{year}' is a typical leap year");
        }
    }
}