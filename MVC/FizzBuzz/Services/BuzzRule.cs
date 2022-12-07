namespace FizzBuzz.Services
{
    public class BuzzRule : IRule
    {
       
        public string Execute(bool isWednesday)
        {
            if (isWednesday)
                return "Wuzz";
            else
                return "Buzz";
        }

        public bool IsMatch(int input)
        {
            return (input % 5) == 0;
        }
    }
}
