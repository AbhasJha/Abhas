namespace FizzBuzz.Services
{
    public class FizzBuzzRule : IRule
    {
       public string Execute()
        {
            return "FizzBuzz";
        }

        public bool IsMatch(int input)
        {
            return ((input % 3) == 0 && (input % 5) == 0);
        }
    }
}
