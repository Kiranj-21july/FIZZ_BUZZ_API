using FIZZ_BUZZ_API.Models;
using FIZZ_BUZZ_API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FIZZ_BUZZ_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FizzBuzzController : ControllerBase
    {
        private readonly IFizzBuzzService _fizzBuzzService;

        public FizzBuzzController(IFizzBuzzService fizzBuzzService)
        {
            _fizzBuzzService = fizzBuzzService;
        }

        [HttpPost]
        public ActionResult<List<FizzBuzzResult>> Post([FromBody] int[] values)
        {
            var results = _fizzBuzzService.ProcessValues(values);
            return Ok(results);
        }
    }
}
