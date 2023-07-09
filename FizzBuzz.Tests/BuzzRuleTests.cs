namespace FizzBuzz.Tests
{
    public class BuzzRuleTests : IFizzBuzzRuleTest
    {
        BuzzRule buzzRule;
        public BuzzRuleTests()
        {
            buzzRule = new BuzzRule();
        }

        [Fact]
        public void BuzzRule_ShouldMatchDivisor()
        {
            Assert.True(ShouldMatchDivisor(5));
        }

        [Fact]
        public void BuzzRule_ShouldNotMatchDivisor()
        {
            Assert.False(ShouldMatchDivisor(10));
        }

        [Fact]
        public void BuzzRule_ShouldMatch()
        {
            Assert.True(ShouldMatch(10));
        }

        [Fact]
        public void BuzzRule_ShouldNotMatch()
        {
            Assert.False(ShouldMatch(11));
        }

        public bool ShouldMatch(int number)
        {
            return buzzRule.IsMatch(number);
        }

        public bool ShouldMatchDivisor(int divisor)
        {
            return divisor == Constants.BuzzDivisor;
        }
    }
}