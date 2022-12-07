namespace FizzBuzz.Services
{
    public class FizzRule : IRule
    {
       
        public string Execute(bool isWednesday)
        {
            
            if (isWednesday)
                return "Wizz";
            else
                return "Fizz";
            
        }

       public bool IsMatch(int input)
        {
            return (input % 3) == 0;
        }
    }
}
