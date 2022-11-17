
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class Judgment : BaseEntity
    {
        public string CommisionName { get; set; } = null!;
        public string Court { get; set; } = null!;
        public string Decree { get; set; } = null!;
        public string DecreeType { get; set; } = null!;
        public string MeritsYear { get; set; } = null!;
        public string MeritsNo { get; set; } = null!;
        public string DecreeYear { get; set; } = null!;
        public string DecreeNo { get; set; } = null!;
    }
}
