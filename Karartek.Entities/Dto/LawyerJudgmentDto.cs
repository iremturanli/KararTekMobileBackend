using System;
namespace Karartek.Entities.Dto
{
    public class LawyerJudgmentDto
    {
        public string CommisionName { get; set; } = null!;
        public string Court { get; set; } = null!;
        public string Decree { get; set; } = null!;
        public string LawyerAssessment { get; set; } = null!;
        public string DecreeType { get; set; } = null!;
        public string MeritsYear { get; set; } = null!;
        public string MeritsNo { get; set; } = null!;
        public string DecreeYear { get; set; } = null!;
        public string DecreeNo { get; set; } = null!;
        public string Decision { get; set; } = null!;
        public string TBBComments { get; set; } = null!;
        public int StateId { get; set; }
        public int Likes { get; set; }
    }
}

