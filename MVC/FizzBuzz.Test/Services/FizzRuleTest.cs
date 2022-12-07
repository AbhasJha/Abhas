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

            //Assert

            Assert.True(fizzRule.IsMatch(3));
            
        }

        [Fact]
        public void ShouldReturnFalseWhenNumberIsNotDivisibleByThree()
        {
            //Arrange

            FizzRule fizzRule = new FizzRule();

            //Assert

            Assert.False(fizzRule.IsMatch(4));
            
        }

        [Fact]
        public void ShouldReturnFizzWhenDayIsNotWednesday()
        {
            //Arrange

            FizzRule fizzRule = new FizzRule();

            //Assert


            Assert.Equal("Fizz", fizzRule.Execute(false));
        }
        [Fact]
        public void ShouldReturnWizzWhenDayIsWednesday()
        {
            //Arrange

            FizzRule fizzRule = new FizzRule();

            //Assert


            Assert.Equal("Wizz", fizzRule.Execute(true));
        }
    }
}
