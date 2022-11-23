using System;
using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class LawyerJudgmentStateResponseDto
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public List<LawyerJudgmentState> LawyerJudgmentStates { get; set; } = null!;
    }
}

