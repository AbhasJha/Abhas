using FizzBuzz.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Test.Services
{
    public class FizzRule
    {
        [Fact]
        public void RuleTest()
        {
            FizzBuzz.Services.FizzRule fizzRule = new FizzBuzz.Services.FizzRule();
            Assert.True(fizzRule.IsMatch(3));
            Assert.Equal("Fizz", fizzRule.Execute());
        }
    }
}
