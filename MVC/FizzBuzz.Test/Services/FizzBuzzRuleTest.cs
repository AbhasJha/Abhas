using FizzBuzz.Services;

namespace FizzBuzz.Test.Services
{
    public class FizzBuzzRuleTest 
    {
        [Fact]
        public void ShouldReturnTrueWhenNumberIsNotDivisibleByThreeAndFive()
        {
            //Arrange

            FizzBuzz.Services.FizzBuzzRule fizzBuzzRule = new FizzBuzz.Services.FizzBuzzRule();

            //Assert

            Assert.True(fizzBuzzRule.IsMatch(15));
           
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByThreeAndFive()
        {
            //Arrange

            FizzBuzz.Services.FizzBuzzRule fizzBuzzRule = new FizzBuzz.Services.FizzBuzzRule();

            //Assert

            Assert.False(fizzBuzzRule.IsMatch(13));
           
        }

        [Fact]
        public void ShouldReturnFizzBuzz()
        {
            //Arrange

            FizzBuzz.Services.FizzBuzzRule fizzBuzzRule = new FizzBuzz.Services.FizzBuzzRule();

            //Assert


            Assert.Equal("FizzBuzz", fizzBuzzRule.Execute());
        }
    }
}
