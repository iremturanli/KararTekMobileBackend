using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete

{
    public class JudgmentPool : BaseEntity
    {
        public int UserId { get; set; }
        public int JudgmentId { get; set; }
        public int SearchTypeId { get; set; }
        public User? User { get; set; } = null!;
        public Judgment? Judgment { get; set; } = null!;
        public LawyerJudgment? LawyerJudgment { get; set; } = null!;
        public SearchType? SearchType { get; set; } = null!;


    }
}
