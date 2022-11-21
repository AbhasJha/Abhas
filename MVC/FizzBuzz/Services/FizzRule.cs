using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class FizzRule : IRule
    {
        bool IRule.Any()
        {
            throw new NotImplementedException();
        }

        DisplayViewModel IRule.Execute()
        {
            DisplayViewModel dataDiplay = new DisplayViewModel();
            dataDiplay.Data = "Fizz";
            dataDiplay.Color = "blue";
            return dataDiplay;
        }

       bool IRule.IsMatch(int input)
        {
            return (input%3)==0;
        }
    }
}
