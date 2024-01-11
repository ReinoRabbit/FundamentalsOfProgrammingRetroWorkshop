using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;

namespace API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ImageGenerateController : ControllerBase
    {

      private readonly IImageServices _imageService;

        public ImageGenerateController(IImageServices imageServices) 
        {
            _imageService = imageServices;
        }

        [HttpGet]
        public string GenerateDogImage()
        {

            return _imageService.GenerateDog();

        }

    }
}
