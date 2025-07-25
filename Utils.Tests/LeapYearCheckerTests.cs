namespace Utils.Tests
{
    public class LeapYearCheckerTests
    {
        [Theory]
        [InlineData(424)]
        [InlineData(1992)]
        [InlineData(2004)]
        [InlineData(2016)]
        [InlineData(2020)]
        public void IsLeapYear_TypicalLeapYears_ReturnsTrue(int year)
        {
            var actualResult = LeapYearChecker.IsLeapYear(year);

            Assert.True(actualResult, $"'{year}' is a typical leap year");
        }

        [Theory]
        [InlineData(2019)]
        [InlineData(2021)]
        [InlineData(2023)]
        [InlineData(2025)]
        public void IsLeapYear_TypicalCommonYears_ReturnsFalse(int year)
        {
            var actualResult = LeapYearChecker.IsLeapYear(year);

            Assert.False(actualResult, $"'{year}' is a common year");
        }

        [Theory]
        [InlineData(1700)]
        [InlineData(1800)]
        [InlineData(1900)]
        [InlineData(2100)]
        public void IsLeapYear_AtypicalCommonYears_ReturnsFalse(int year)
        {
            var actualResult = LeapYearChecker.IsLeapYear(year);

            Assert.False(actualResult, $"'{year}' is an atypical common year");
        }

        [Theory]
        [InlineData(1600)]
        [InlineData(2000)]
        [InlineData(2400)]
        public void IsLeapYear_AtypicalLeapYears_ReturnsTrue(int year)
        {
            var actualResult = LeapYearChecker.IsLeapYear(year);

            Assert.True(actualResult, $"'{year}' is an atypical leap year");
        }
    }
}