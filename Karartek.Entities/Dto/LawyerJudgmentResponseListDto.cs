using System;
namespace Karartek.Entities.Dto
{
    public class LawyerJudgmentResponseListDto
    {
        public int Id { get; set; }
        public int CommissionId { get; set; }
        public int? CourtId { get; set; }
        public string Decree { get; set; } = null!;
        public string DecreeType { get; set; } = null!;
        public string MeritsYear { get; set; } = null!;
        public string MeritsNo { get; set; } = null!;
        public string DecreeYear { get; set; } = null!;
        public string DecreeNo { get; set; } = null!;
        public string Decision { get; set; } = null!;
        public string TBBComments { get; set; } = null!;
        public int Likes { get; set; } //avukat ismi olacak mı
        public DateTime JudgmentDate { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public string CommissionName { get; set; } = null!;
        public string? CourtName { get; set; }
        public int? UserId { get; set; }
        public string? StateName { get; set; }
        public string? UserName { get; set; }
        public string? LastName { get; set; }
        public string? LawyerAssesment { get; set; }   


    }
}

