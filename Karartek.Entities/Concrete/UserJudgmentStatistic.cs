using System;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class UserJudgmentStatistic:BaseEntity
    {
        public int UserId { get; set; }
        public int LawyerJudgmentId { get; set; }
        public int UserTypeId { get; set; }
        public string UserTypeName { get; set; }
        public string UserName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string CityName { get; set; } = null!;
        public int JudgmentCount { get; set; }
        public User? User { get; set; } = null!;

    }
}

