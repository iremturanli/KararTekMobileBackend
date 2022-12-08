using System;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class UserLike:BaseEntity
    {
        public int UserId { get; set; }
        public int JudgmentId { get; set; }//judgmentId yap
        public int TypeId { get; set; }
        public bool isLike { get; set; }
        public User? User { get; set; } = null!;
        public SearchType? SearchType { get; set; } = null!;
    }
}

