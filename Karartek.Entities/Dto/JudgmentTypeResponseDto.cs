using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class JudgmentTypeResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; }
        public List<JudgmentType> JudgmentTypes { get; set; } = null!;

    }


}
