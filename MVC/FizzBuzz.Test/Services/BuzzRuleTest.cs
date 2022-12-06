namespace FizzBuzz.Test.Services
{
    public class BuzzRuleTest
    {
        [Fact]
        public void Should_Return_True_when_number_is_divisible_by_five()
        {
            //Arrange

            FizzBuzz.Services.BuzzRule buzzRule = new FizzBuzz.Services.BuzzRule();

            //Assert

            Assert.True(buzzRule.IsMatch(5));
            Assert.Equal("Buzz", buzzRule.Execute());
        }

        [Fact]
        public void Should_Return_false_when_number_is_not_divisible_by_five()
        {
            //Arrange

            FizzBuzz.Services.BuzzRule buzzRule = new FizzBuzz.Services.BuzzRule();

            //Assert

            Assert.True(buzzRule.IsMatch(6));
            Assert.Equal("Buzzs", buzzRule.Execute());
        }
    }
}
