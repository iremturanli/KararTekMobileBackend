using System;
using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class JudgmentLawyerJudgmentDto
    {
        public int userId { get; set; }
        public List<JudgmentResponseListDto> JudgmentResponseListDto { get; set; } 
        public List<LawyerJudgmentResponseListDto> LawyerJudgmentResponseListDto { get; set; }

    }
}

