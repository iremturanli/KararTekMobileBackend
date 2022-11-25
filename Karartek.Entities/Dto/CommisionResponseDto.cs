using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class CommisionResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
        public List<Commision> Commisions { get; set; } = null!;

    }

}