﻿namespace FizzBuzz.Services
{
    public class FizzRule : IRule
    {
       
        public string Execute(bool isWednesday)
        {
            return isWednesday ? "Wizz" : "Fizz";
        }

       public bool IsMatch(int input)
        {
            return (input % 3) == 0;
        }
    }
}
