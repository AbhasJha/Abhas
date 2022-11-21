

using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class FizzBuzzRule : IRule
    {
        bool IRule.Any()
        {
            throw new NotImplementedException();
        }

        DisplayViewModel IRule.Execute()
        {
            DisplayViewModel dataDiplay = new DisplayViewModel();
            dataDiplay.Data = "FizzBuzz";
            dataDiplay.Color = "black";
            return dataDiplay;
        }

        bool IRule.IsMatch(int input)
        {
            return ((input % 3) == 0 && (input % 5) == 0);
        }
    }
}
