using FIZZ_BUZZ_API.Models;

namespace FIZZ_BUZZ_API.Services
{
    public interface IFizzBuzzService
    {
        List<FizzBuzzResult> ProcessValues(int[] values);
    }
}
