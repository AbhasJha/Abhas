namespace FizzBuzz.Services
{
    public class FizzRule : IRule
    {
       public string Execute()
        {
            return "Fizz";
        }

       public bool IsMatch(int input)
        {
            return (input % 3) == 0;
        }
    }
}
