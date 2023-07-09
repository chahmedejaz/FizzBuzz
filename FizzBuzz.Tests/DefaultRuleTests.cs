namespace FizzBuzz.Tests
{
    public class DefaultRuleTests : IFizzBuzzRuleTest
    {
        DefaultRule buzzRule;
        public DefaultRuleTests()
        {
            buzzRule = new DefaultRule();
        }

        [Fact]
        public void DefaultRule_ShouldMatch()
        {
            Assert.True(ShouldMatch(8));
        }

        [Fact]
        public void DefaultRule_ShouldNotMatch()
        {
            Assert.False(ShouldMatch(9));
        }

        public bool ShouldMatch(int number)
        {
            return buzzRule.IsMatch(number);
        }

        public bool ShouldMatchDivisor(int divisor)
        {
            return true;
        }
    }
}