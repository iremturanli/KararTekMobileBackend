﻿using System;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class UserLike:BaseEntity
    {
        public int UserId { get; set; }
        public int LawyerJudgmentId { get; set; }
        public bool isLike { get; set; }
        public User? User { get; set; } = null!;
    }
}

