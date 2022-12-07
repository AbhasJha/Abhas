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
            //Act
            var result = buzzRule.IsMatch(5);
            //Assert
            Assert.True(result);            
        }
        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByFive()
        {
            //Arrange
            BuzzRule buzzRule = new BuzzRule();
            //Act
            var result= buzzRule.IsMatch(6);
            //Assert
            Assert.False(result);            
        }
        [Fact]
        public void ShouldReturnBuzzWhenDayIsNotWednesday()
        {
            //Arrange
            BuzzRule buzzRule = new BuzzRule();
            //Act
            var result = buzzRule.Execute(false);
            //Assert            
            Assert.Equal("Buzz", result);
        }
        [Fact]
        public void ShouldReturnWuzzWhenDayIsWednesday()
        {
            //Arrange
            BuzzRule buzzRule = new BuzzRule();
            //Act
            var result= buzzRule.Execute(true);
            //Assert
            Assert.Equal("Wuzz", result);
        }
    }
}
