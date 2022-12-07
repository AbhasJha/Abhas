using FizzBuzz.Services;

namespace FizzBuzz.Test.Services
{
    public class FizzBuzzRuleTest 
    {
        [Fact]
        public void ShouldReturnTrueWhenNumberIsNotDivisibleByThreeAndFive()
        {
            //Arrange

            FizzBuzzRule fizzBuzzRule = new FizzBuzzRule();

            //Assert

            Assert.True(fizzBuzzRule.IsMatch(15));
           
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByThreeAndFive()
        {
            //Arrange

            FizzBuzzRule fizzBuzzRule = new FizzBuzzRule();

            //Assert

            Assert.False(fizzBuzzRule.IsMatch(13));
           
        }

        [Fact]
        public void ShouldReturnFizzBuzzWhenDayIsNotWednesday()
        {
            //Arrange

           FizzBuzzRule fizzBuzzRule = new FizzBuzzRule();

            //Assert


            Assert.Equal("FizzBuzz", fizzBuzzRule.Execute(false));
        }
        [Fact]
        public void ShouldReturnWizzWuzzWhenDayIsWednesday()
        {
            //Arrange

            FizzBuzzRule fizzBuzzRule = new FizzBuzzRule();

            //Assert


            Assert.Equal("WizzWuzz", fizzBuzzRule.Execute(true));
        }
    }
}
