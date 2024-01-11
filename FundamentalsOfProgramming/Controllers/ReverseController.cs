using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {

        private readonly IReverseService _reverseService;

        public ReverseController(IReverseService reverseService) //constructor
        {
            _reverseService = reverseService;
        }

        //http requests API controller
        [HttpGet]
        public IActionResult GetReverse(string sentence)
        {

            try
            {

                string reverseResult = _reverseService.reverseString(sentence); //getting method through service
                return Ok(reverseResult);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
                throw;
            }

        }

    }
}
