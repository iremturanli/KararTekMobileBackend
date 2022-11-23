using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class JudgmentType : BaseEntity
    {

        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public IEnumerable<Judgment>? Judgments { get; set; } = null!;
    }
}

