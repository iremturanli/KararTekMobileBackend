using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class JudgmentTypeResponseDto:BaseResponseDto
    {

        public List<JudgmentType> JudgmentTypes { get; set; } = null!;

    }


}
