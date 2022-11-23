using System;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class SearchType : BaseEntity
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public IEnumerable<JudgmentPool>? JudgmentPools {get;set;}


    }
}

