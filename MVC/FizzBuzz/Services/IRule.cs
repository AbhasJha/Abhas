using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public interface IRule
    {
        bool IsMatch(int input);
        DisplayViewModel Execute();
        bool Any();
    }

}
