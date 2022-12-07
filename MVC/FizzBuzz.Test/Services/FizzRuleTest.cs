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
            FizzRule fizzRule = new FizzRule();
            //Act
            var result = fizzRule.IsMatch(3);
            //Assert
            Assert.True(result);
        }
        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByThree()
        {
            //Arrange
            FizzRule fizzRule = new FizzRule();
            //Act
            var result = fizzRule.IsMatch(4);
            //Assert
            Assert.False(result);
        }

        [Fact]
        public void ShouldReturnFizzWhenDayIsNotWednesday()
        {
            //Arrange
            FizzRule fizzRule = new FizzRule();
            //Act
            var result = fizzRule.Execute(false);
            //Assert
            Assert.Equal("Fizz", result);
        }
        [Fact]
        public void ShouldReturnWizzWhenDayIsWednesday()
        {
            //Arrange
            FizzRule fizzRule = new FizzRule();
            //Act
            var result= fizzRule.Execute(true);
            //Assert
            Assert.Equal("Wizz", result);
        }
    }
}
