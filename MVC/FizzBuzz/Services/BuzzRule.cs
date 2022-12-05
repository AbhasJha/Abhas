namespace FizzBuzz.Services
{
    public class BuzzRule : IRule
    {

        public string Execute()
        {
            return "Buzz";
        }

        public bool IsMatch(int input)
        {
            return (input % 5) == 0;
        }
    }
}
