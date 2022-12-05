using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class DistrictResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
        public List<DistrictDto> Districts { get; set; } = null!;

    }

}