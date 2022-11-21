using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class BuzzRule : IRule
    {
        bool IRule.Any()
        {
            throw new NotImplementedException();
        }

        DisplayViewModel IRule.Execute()
        {
            DisplayViewModel dataDiplay = new DisplayViewModel();
            dataDiplay.Data = "Buzz";
            dataDiplay.Color = "green";
            return dataDiplay;
        }

        bool IRule.IsMatch(int input)
        {
            return (input % 5) == 0;
        }
    }
}
