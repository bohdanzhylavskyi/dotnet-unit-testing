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
    }
}