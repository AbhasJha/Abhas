namespace FizzBuzz.Test.Services
{
    public class BuzzRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenNumberIsDivisibleByFive()
        {
            //Arrange

            FizzBuzz.Services.BuzzRule buzzRule = new FizzBuzz.Services.BuzzRule();

            //Assert

            Assert.True(buzzRule.IsMatch(5));
            
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByFive()
        {
            //Arrange

            FizzBuzz.Services.BuzzRule buzzRule = new FizzBuzz.Services.BuzzRule();

            //Assert

            Assert.False(buzzRule.IsMatch(6));
            
        }
        [Fact]
        public void ShouldReturnBuzz()
        {
            //Arrange

            FizzBuzz.Services.BuzzRule buzzRule = new FizzBuzz.Services.BuzzRule();

            //Assert

            
            Assert.Equal("Buzz", buzzRule.Execute());
        }
    }
}
