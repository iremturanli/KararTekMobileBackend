using System;
using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class LawyerJudgmentStateResponseDto:BaseResponseDto
    {
    
        public List<LawyerJudgmentState> LawyerJudgmentStates { get; set; } = null!;
    }
}

