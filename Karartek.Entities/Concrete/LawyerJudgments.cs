using Karartek.Core.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karartek.Entities.Concrete
{
    public class LawyerJudgment : BaseEntity
    {

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
        public DateTime? JudgmentDate { get; set; }
        public int UserId { get; set; }
        public int StateId { get; set; }
        public int? Likes { get; set; }
        public User? User { get; set; } = null!;
        public Commission? Commission { get; set; } = null!;
        public Court? Court { get; set; }
        public LawyerJudgmentState? LawyerJudgmentState { get; set; } 
        public virtual ICollection<JudgmentPool>? JudgmentPools { get; set; } 



    }
}

