using FizzBuzz.Services;
namespace FizzBuzz.Test.Services
{
    public class BuzzRuleTest
    {
        [Fact]
        public void ShouldReturnTrueWhenNumberIsDivisibleByFive()
        {
            //Arrange

          BuzzRule buzzRule = new BuzzRule();

            //Assert

            Assert.True(buzzRule.IsMatch(5));
            
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByFive()
        {
            //Arrange

            BuzzRule buzzRule = new BuzzRule();

            //Assert

            Assert.False(buzzRule.IsMatch(6));
            
        }
        [Fact]
        public void ShouldReturnBuzz()
        {
            //Arrange

            BuzzRule buzzRule = new BuzzRule();

            //Assert

            
            Assert.Equal("Buzz", buzzRule.Execute());
        }
    }
}
