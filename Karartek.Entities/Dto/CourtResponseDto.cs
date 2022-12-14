using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class CourtResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
        public List<CourtDto> Courts { get; set; } = null!;

    }

}