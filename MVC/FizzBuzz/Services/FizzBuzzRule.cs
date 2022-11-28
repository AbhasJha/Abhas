

using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class FizzBuzzRule : IRule
    {
        IDayFirstChar _dayFirstChar;
        public FizzBuzzRule(IDayFirstChar dayFirstChar)
        {
            _dayFirstChar = dayFirstChar;
        }
        DisplayViewModel IRule.Execute()
        {
            DisplayViewModel dataDiplay = new DisplayViewModel();
            dataDiplay.Data = _dayFirstChar.GetChar("Fizz") + _dayFirstChar.GetChar("Buzz");
            dataDiplay.Color = "black";
            return dataDiplay;
        }

        bool IRule.IsMatch(int input)
        {
            return ((input % 3) == 0 && (input % 5) == 0);
        }
    }
}
