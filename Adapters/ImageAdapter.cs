using Services.Interfaces;

namespace Adapters
{
    public class ImageAdapter  : IImageAdapter
    {

        public string GenerateDog()
        {
            return "https://images.dog.ceo/breeds/hound-basset/n02088238_7487.jpg";
        }

    }
}
