using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactorialController : ControllerBase
    {
        //Controller for factorial
        //Communication? endpoint? swagger?

        private readonly IFactorialService _factorialService;

        public FactorialController(IFactorialService factorialService) //constructor
        {
            _factorialService = factorialService;
        }
        
        //api controller that handles http requests (This will get the method and then execute logic?)
        // Controller = manages the work
        // Service = Executes the work
        [HttpGet]
        public IActionResult GetFactorial(int number) 
        {
        
            int factorialResult = _factorialService.giveFactorial(number); //getting method through service?
            return Ok(factorialResult);

            //try catch if something goes bad

        }

    }
}
