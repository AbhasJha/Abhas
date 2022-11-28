using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class FizzRule : IRule
    {
        IDayFirstChar _dayFirstChar;
        public FizzRule(IDayFirstChar dayFirstChar)
        {
            _dayFirstChar = dayFirstChar;
        }
        DisplayViewModel IRule.Execute()
        {
            DisplayViewModel dataDiplay = new DisplayViewModel();
            dataDiplay.Data = _dayFirstChar.GetChar("Fizz");
            dataDiplay.Color = "blue";
            return dataDiplay;
        }

       bool IRule.IsMatch(int input)
        {
            return (input%3)==0;
        }
    }
}
