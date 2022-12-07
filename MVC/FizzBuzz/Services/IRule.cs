namespace FizzBuzz.Services
{
    public interface IRule
    {
        bool IsMatch(int input);
        string Execute(bool isWednesday);
        
    }

}
