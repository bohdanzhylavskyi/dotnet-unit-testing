namespace Utils.Tests
{
    public class StringSumTests
    {
        [Fact]
        public void Sum_EmptyStringNums_ReturnsZeroStr()
        {
            var actualResult = Utils.Sum("","");

            Assert.Equal("0", actualResult);
        }

        [Theory]
        [InlineData("10", "4", "14")]
        [InlineData("5", "50", "55")]
        [InlineData("0", "50", "50")]
        public void Sum_NaturalNums_ReturnsCorrectSum(string num1, string num2, string expectedSum)
        {
            var actualResult = Utils.Sum(num1, num2);

            Assert.Equal(expectedSum, actualResult);
        }

        [Theory]
        [InlineData("-10", "4", "4")]
        [InlineData("5", "NAN", "5")]
        [InlineData("NAN", "NAN", "0")]
        [InlineData("10", "0.5", "10")]
        [InlineData("", "30", "30")]
        public void Sum_OneOrBothOperandsAreNonNatural_ReturnsCorrectSum(string num1, string num2, string expectedSum)
        {
            var actualResult = Utils.Sum(num1, num2);

            Assert.Equal(expectedSum, actualResult);
        }
    }
}