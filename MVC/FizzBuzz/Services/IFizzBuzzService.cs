using FizzBuzz.Models;

namespace FizzBuzz.Services
{
    public interface IFizzBuzzService
    {
        List<DisplayViewModel> GetFizzBuzzNumbers(int input);
    }
}
