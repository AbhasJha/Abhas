namespace FizzBuzz.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        private readonly IEnumerable<IRule> rules;
        private readonly IWeekdayVerifier weekdayverifier;

        
        public FizzBuzzService(IWeekdayVerifier weekdayverifier, IEnumerable<IRule> rules)
        {
            this.rules = rules;
            this.weekdayverifier = weekdayverifier;
        }
       public List<string> GetFizzBuzzNumbers(int input)
        {

            bool isWednesday = weekdayverifier.IsWednesday();
            List<String> dataDisplay = new List<string>();
            for (var number = 1; number <= input; number++)
            {
                var applicableRules = rules.FirstOrDefault(x => x.IsMatch(number));
                var fizzBuzzNumber = applicableRules == null ? number.ToString() : applicableRules.Execute(isWednesday);
                dataDisplay.Add(fizzBuzzNumber);
            }
            return dataDisplay;
        }
    }
}
