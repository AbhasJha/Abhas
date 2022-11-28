using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class BuzzRule : IRule
    {
        IDayFirstChar _dayFirstChar;
        public BuzzRule(IDayFirstChar dayFirstChar)
        {
            _dayFirstChar = dayFirstChar;
        }

        DisplayViewModel IRule.Execute()
        {
            DisplayViewModel dataDiplay = new DisplayViewModel();
            dataDiplay.Data = _dayFirstChar.GetChar("Buzz");
            dataDiplay.Color = "green";
            return dataDiplay;
        }

        bool IRule.IsMatch(int input)
        {
            return (input % 5) == 0;
        }
    }
}
