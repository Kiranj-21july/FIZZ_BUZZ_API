using FIZZ_BUZZ_API.Models;

namespace FIZZ_BUZZ_API.Services
{
    public class FizzBuzzServices : IFizzBuzzService
    {
        public List<FizzBuzzResult> ProcessValues(int[] values)
        {
            var results = new List<FizzBuzzResult>();

            foreach (var value in values)
            {
                string result = string.Empty;            

                if (value % 3 == 0 && value % 5 == 0)
                {
                    result = "FizzBuzz";
                }
                else if (value % 3 == 0)
                {
                    result = "Fizz";
                }
                else if (value % 5 == 0)
                {
                    result = "Buzz";
                }
                else
                {
                    result = value.ToString();
                }

                results.Add(new FizzBuzzResult
                {
                    Value = value,
                    Result = result
                });
            }

            return results;
        }
    }
}
