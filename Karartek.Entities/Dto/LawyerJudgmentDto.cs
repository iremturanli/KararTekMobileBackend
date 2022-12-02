namespace Karartek.Entities.Dto
{
    public class LawyerJudgmentDto
    {
        public int? Id { get; set; }
        public int? CommissionId { get; set; } 
        public int? CourtId { get; set; } 
        public string? Decree { get; set; } 
        public string? LawyerAssessment { get; set; } 
        public string? DecreeType { get; set; } 
        public string? MeritsYear { get; set; } 
        public string? MeritsNo { get; set; } 
        public string? DecreeYear { get; set; } 
        public string? DecreeNo { get; set; } 
        public string? Decision { get; set; } 
        public string? TBBComments { get; set; } 
        public int? UserId { get; set; }
        public int? StateId { get; set; }
        public int? Likes { get; set; }
        public DateTime? JudgmentDate { get; set; }
    }
}

