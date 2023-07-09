namespace FizzBuzz.Tests
{
    public class FizzBuzzTests : IFizzBuzzRuleTest
    {
        FizzBuzzRule fizzDefaultRule;
        public FizzBuzzTests()
        {
            fizzDefaultRule = new FizzBuzzRule();
        }

        [Fact]
        public void FizzDefaultRule_ShouldMatchDivisor()
        {
            Assert.True(ShouldMatchDivisor(3));
            Assert.True(ShouldMatchDivisor(5));
        }

        [Fact]
        public void FizzDefaultRule_ShouldNotMatchDivisor()
        {
            Assert.False(ShouldMatchDivisor(9));
            Assert.False(ShouldMatchDivisor(10));
        }

        [Fact]
        public void FizzDefaultRule_ShouldMatch()
        {
            Assert.True(ShouldMatch(15));
        }

        [Fact]
        public void FizzDefaultRule_ShouldNotMatch()
        {
            Assert.False(ShouldMatch(16));
        }

        public bool ShouldMatch(int number)
        {
            return fizzDefaultRule.IsMatch(number);
        }

        public bool ShouldMatchDivisor(int divisor)
        {
            return divisor == Constants.BuzzDivisor || divisor == Constants.FizzDivisor;
        }
    }
}