using FizzBuzz.Services;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test.Services
    {
        public class WeekdayVerifierTest
        {
            [Fact]
            public void ShouldReturnTrueWhenDayIsWednesday()
            {
                //Arrange
                WeekdayVerifier weekdayVerifier = new WeekdayVerifier(DayOfWeek.Wednesday.ToString());
                //Act
                var result = weekdayVerifier.IsWednesday();
                //Assert
                Assert.True(result);
            }
            [Fact]
            public void ShouldReturnFalseWhenDayIsWednesday()
            {
                //Arrange
                WeekdayVerifier weekdayVerifier = new WeekdayVerifier(DayOfWeek.Tuesday.ToString());
                //Act
                var result = weekdayVerifier.IsWednesday();
                //Assert
                Assert.False(result);
            }
        }
    }
  
