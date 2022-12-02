using System;
namespace Karartek.Entities.Dto
{
    public class LawyerJudgmentResponseListDto
    {
        public int Id { get; set; }
        public int? CommissionId { get; set; }
        public int? CourtId { get; set; }
        public string? Decree { get; set; } 
        public string? DecreeType { get; set; }  
        public string? MeritsYear { get; set; }  
        public string? MeritsNo { get; set; }  
        public string? DecreeYear { get; set; }  
        public string? DecreeNo { get; set; }  
        public string? Decision { get; set; }  
        public string? TBBComments { get; set; }  
        public int? Likes { get; set; } //avukat ismi olacak mı
        public DateTime? JudgmentDate { get; set; }
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        public string? CommissionName { get; set; }  
        public string? CourtName { get; set; }
        public int? UserId { get; set; }
        public string? StateName { get; set; }
        public string? UserName { get; set; }
        public string? LastName { get; set; }
        public string? LawyerAssesment { get; set; }
        public string? JudgmentTypeName { get; set; }
        public int? JudgmentTypeId { get; set; }


    }
}

