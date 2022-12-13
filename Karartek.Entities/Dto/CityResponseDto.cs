using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class CityResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
        public List<City> Cities { get; set; } = null!;

    }

}
