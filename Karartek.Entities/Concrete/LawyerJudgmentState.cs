using System;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class LawyerJudgmentState:BaseEntity
    {
        public int StateId { get; set; }
        public string StateName { get; set; } = null!;
        public IEnumerable<LawyerJudgment>? LawyerJudgments { get; set; } = null!;
    }
}

