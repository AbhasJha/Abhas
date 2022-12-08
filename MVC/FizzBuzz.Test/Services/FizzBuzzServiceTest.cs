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
        private Mock<IWeekdayverfier> weekdayverfier;

        [Fact]
        public void ShouldReturnFizzBuzzWhenDayIsNotWednesday()
        {
            //Arrange
            weekdayverfier = new Mock<IWeekdayverfier>();
            weekdayverfier.Setup(q => q.IsWednesday()).Returns(false);

            //Act
            var fizzbuzzservice = new FizzBuzzService(weekdayverfier.Object);   
            var result= fizzbuzzservice.GetFizzBuzzNumbers(10);

            //Assert

            Assert.Equal(result, new List<string> { "1", "2", "Fizz", "4", "Buzz", "Fizz", "7" , "8" , "Fizz", "Buzz" });

        }

        [Fact]
        public void ShouldReturnWizzWuzzWhenDayIsNotWednesday()
        {
            //Arrange
            weekdayverfier = new Mock<IWeekdayverfier>();
            weekdayverfier.Setup(q => q.IsWednesday()).Returns(true);

            //Act
            var fizzbuzzservice = new FizzBuzzService(weekdayverfier.Object);
            var result = fizzbuzzservice.GetFizzBuzzNumbers(10);

            //Assert

            Assert.Equal(result, new List<string> { "1", "2", "Wizz", "4", "Wuzz", "Wizz", "7", "8", "Wizz", "Wuzz" });

        }

    }
}
