namespace FizzBuzz.Services
{
    public class BuzzRule : IRule
    {
       
        public string Execute(bool isWednesday)
        {
            return isWednesday ? "Wuzz":"Buzz";
        }

        public bool IsMatch(int input)
        {
            return (input % 5) == 0;
        }
    }
}
