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
            //Act
            var result = fizzBuzzRule.IsMatch(15);
            //Assert
            Assert.True(result);
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByThreeAndFive()
        {
            //Arrange
            FizzBuzzRule fizzBuzzRule = new FizzBuzzRule();
            //Act
            var result = fizzBuzzRule.IsMatch(13);
            //Assert
            Assert.False(result);    
        }
       [Fact]
        public void ShouldReturnFizzBuzzWhenDayIsNotWednesday()
        {
            //Arrange
           FizzBuzzRule fizzBuzzRule = new FizzBuzzRule();
            //Act
            var result = fizzBuzzRule.Execute(false);
            //Assert
            Assert.Equal("FizzBuzz", result);
        }
        [Fact]
        public void ShouldReturnWizzWuzzWhenDayIsWednesday()
        {
            //Arrange
            FizzBuzzRule fizzBuzzRule = new FizzBuzzRule();
            //Act
            var result = fizzBuzzRule.Execute(true);
            //Assert
            Assert.Equal("WizzWuzz", result);
        }
    }
}
