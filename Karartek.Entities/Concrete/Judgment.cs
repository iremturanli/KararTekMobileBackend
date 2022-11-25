
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class Judgment : BaseEntity
    {
        public int JudgmentTypeId { get; set; }
        public string CommisionId{ get; set; } = null!;
        public string CourtId { get; set; } = null!;
        public string Decree { get; set; } = null!;
        public string DecreeType { get; set; } = null!;
        public string MeritsYear { get; set; } = null!;
        public string MeritsNo { get; set; } = null!;
        public string DecreeYear { get; set; } = null!;
        public string DecreeNo { get; set; } = null!;
        public string Decision { get; set; } = null!;
        public int Likes { get; set; }
        public Commision? Commision { get; set; } = null!;
        public Court? Court { get; set; }
        public JudgmentType? JudgmentType{ get; set; } = null!;
        public virtual ICollection<JudgmentPool>? JudgmentPools { get; set; } = null!;

    }
}
