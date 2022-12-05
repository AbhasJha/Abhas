namespace FizzBuzz.Test.Services
{
    public class BuzzRule
    {
        [Fact]
        public void RuleTest()
        {
            FizzBuzz.Services.BuzzRule buzzRule = new FizzBuzz.Services.BuzzRule();
            Assert.True(buzzRule.IsMatch(5));
            Assert.Equal("Buzz", buzzRule.Execute());
        }
    }
}
