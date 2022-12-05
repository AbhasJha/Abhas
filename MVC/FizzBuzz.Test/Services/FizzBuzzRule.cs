namespace FizzBuzz.Test.Services
{
    public class FizzBuzzRule
    {
        [Fact]
        public void RuleTest()
        {
            FizzBuzz.Services.FizzBuzzRule fizzBuzzRule = new FizzBuzz.Services.FizzBuzzRule();
            Assert.True(fizzBuzzRule.IsMatch(15));
            Assert.Equal("FizzBuzz", fizzBuzzRule.Execute());
        }
    }
}
