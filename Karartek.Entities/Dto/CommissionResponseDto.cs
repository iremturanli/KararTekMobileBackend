using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class CommissionResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; } = null!;
        public List<Commission> Commissions { get; set; } = null!;

    }

}