using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class LawyerJudgment : BaseEntity
    {

        public int CommissionId { get; set; } 
        public int? CourtId { get; set; } 
        public string Decree { get; set; } = null!;
        public string LawyerAssessment { get; set; } = null!;
        public string DecreeType { get; set; } = null!;
        public string MeritsYear { get; set; } = null!;
        public string MeritsNo { get; set; } = null!;
        public string DecreeYear { get; set; } = null!;
        public string DecreeNo { get; set; } = null!;
        public string Decision { get; set; } = null!;
        public string TBBComments { get; set; } = null!;
        public DateTime JudgmentDate { get; set; }
        public int UserId { get; set; }
        public int StateId { get; set; }
        public int Likes { get; set; }
        public User? User { get; set; } = null!;
        public Commission? Commission { get; set; } = null!;
        public Court? Court { get; set; }
        public LawyerJudgmentState? LawyerJudgmentState { get; set; } = null!;
        public virtual ICollection<JudgmentPool>? JudgmentPools { get; set; } = null!;



    }
}

