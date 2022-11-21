using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IList<IRule> rules;
        public FizzBuzzService()
        {
            rules = new List<IRule> { new FizzBuzzRule(), new FizzRule(), new BuzzRule() };
        }
        List<DisplayViewModel> IFizzBuzzService.GetFizzBuzzNumbers(int input)
        {
            List<DisplayViewModel> dataDiplay = new List<DisplayViewModel>();
            for (var i = 1; i <= input; i++)
            {
                DisplayViewModel data = new DisplayViewModel();
                data.Color = "black";
                data.Data = i.ToString();
                var applicableRules = rules.FirstOrDefault(x => x.IsMatch(i));
                var fizzBuzzNumber = applicableRules == null ? data : applicableRules.Execute();
                dataDiplay.Add(fizzBuzzNumber);
            }
            return dataDiplay;
        }
    }
}
