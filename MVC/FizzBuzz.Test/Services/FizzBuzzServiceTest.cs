using FizzBuzz.Controllers;
using FizzBuzz.Models;
using FizzBuzz.Services;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test.Services
{
    
    public class FizzBuzzServiceTest
    {
        private Mock<IWeekdayVerifier> weekdayverifier;
        private IEnumerable<IRule> rules;

        [Fact]
        public void ShouldReturnFizzBuzzWhenDayIsNotWednesday()
        {
            //Arrange
            weekdayverifier = new Mock<IWeekdayVerifier>();
            weekdayverifier.Setup(q => q.IsWednesday()).Returns(false);
            rules = new List<IRule> { new FizzBuzzRule(), new FizzRule(), new BuzzRule() };

            //Act

            var fizzbuzzservice = new FizzBuzzService(weekdayverifier.Object, rules);   
            var result= fizzbuzzservice.GetFizzBuzzNumbers(10);

            //Assert

            Assert.Equal(result, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" , "8" , "Fizz", "Buzz" });

        }

        [Fact]
        public void ShouldReturnWizzWuzzWhenDayIsNotWednesday()
        {
            //Arrange
            weekdayverifier = new Mock<IWeekdayVerifier>();
            weekdayverifier.Setup(q => q.IsWednesday()).Returns(true);
            rules = new List<IRule> { new FizzBuzzRule(), new FizzRule(), new BuzzRule() };

            //Act
            var fizzbuzzservice = new FizzBuzzService(weekdayverifier.Object, rules);
            var result = fizzbuzzservice.GetFizzBuzzNumbers(10);

            //Assert

            Assert.Equal(result, new List<string> { "1", "2", "Wizz", "4", "Wuzz", "Wizz", "7", "8", "Wizz", "Wuzz" });

        }

    }
}
