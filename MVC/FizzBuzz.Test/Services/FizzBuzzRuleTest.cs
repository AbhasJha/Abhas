namespace FizzBuzz.Test.Services
{
    public class FizzBuzzRuleTest 
    {
        [Fact]
        public void Should_Return_True_when_number_is_divisible_by_Three_and_Five()
        {
            //Arrange

            FizzBuzz.Services.FizzBuzzRule fizzBuzzRule = new FizzBuzz.Services.FizzBuzzRule();

            //Assert

            Assert.True(fizzBuzzRule.IsMatch(15));
            Assert.Equal("FizzBuzz", fizzBuzzRule.Execute());
        }

        [Fact]
        public void Should_Return_True_when_number_is_not_divisible_by_Three_and_Five()
        {
            //Arrange

            FizzBuzz.Services.FizzBuzzRule fizzBuzzRule = new FizzBuzz.Services.FizzBuzzRule();

            //Assert

            Assert.True(fizzBuzzRule.IsMatch(13));
            Assert.Equal("FizzBuzz", fizzBuzzRule.Execute());
        }
    }
}
