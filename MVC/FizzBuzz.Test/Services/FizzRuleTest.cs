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
        public void ShouldReturnTrueWhenNumberIsDivisibleByThree()
        {
            //Arrange

            FizzBuzz.Services.FizzRule fizzRule = new FizzBuzz.Services.FizzRule();

            //Assert

            Assert.True(fizzRule.IsMatch(3));
            
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByThree()
        {
            //Arrange

            FizzBuzz.Services.FizzRule fizzRule = new FizzBuzz.Services.FizzRule();

            //Assert

            Assert.False(fizzRule.IsMatch(4));
            
        }

        [Fact]
        public void ShouldReturnFizz()
        {
            //Arrange

            FizzBuzz.Services.FizzRule fizzRule = new FizzBuzz.Services.FizzRule();

            //Assert


            Assert.Equal("Fizz", fizzRule.Execute());
        }
    }
}
