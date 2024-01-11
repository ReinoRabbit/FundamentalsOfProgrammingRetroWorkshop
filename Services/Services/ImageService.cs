using Services.Interfaces;
using System.Globalization;

namespace Services.Services
{

    public class ImageService : IImageServices
    {

        private readonly IImageAdapter _imageAdapter;


        public ImageService(IImageAdapter imageAdapter)
        {

            _imageAdapter = imageAdapter;
        }

        public string GenerateDog()
        {
            return _imageAdapter.GenerateDog();
        }


    }
}
