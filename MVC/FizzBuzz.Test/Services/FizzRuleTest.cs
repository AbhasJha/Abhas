using FizzBuzz.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test.Services
{
    public class FizzRuleTest
    {
        [Fact]
        public void Should_Return_True_when_number_is_divisible_by_Three()
        {
            //Arrange

            FizzBuzz.Services.FizzRule fizzRule = new FizzBuzz.Services.FizzRule();

            //Assert

            Assert.True(fizzRule.IsMatch(3));
            Assert.Equal("Fizz", fizzRule.Execute());
        }

        [Fact]
        public void Should_Return_True_when_number_is_not_divisible_by_Three()
        {
            //Arrange

            FizzBuzz.Services.FizzRule fizzRule = new FizzBuzz.Services.FizzRule();

            //Assert

            Assert.True(fizzRule.IsMatch(4));
            Assert.Equal("Fizzs", fizzRule.Execute());
        }
    }
}
