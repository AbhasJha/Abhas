namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IList<IRule> rules;
        public FizzBuzzService()
        {
            rules = new List<IRule> { new FizzBuzzRule(), new FizzRule(), new BuzzRule()};
        }
        List<string> IFizzBuzzService.GetFizzBuzzNumbers(int input)
        {
            List<String> dataDiplay = new List<string>();
            for (var number = 1; number <= input; number++)
            {
                var applicableRules = rules.FirstOrDefault(x => x.IsMatch(number));
                var fizzBuzzNumber = applicableRules == null ? number.ToString() : applicableRules.Execute();
                dataDiplay.Add(fizzBuzzNumber);
            }
            return dataDiplay;
        }
    }
}
