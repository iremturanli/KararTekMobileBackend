using System;
using Karartek.Core.Entities;

namespace Karartek.Entities.Concrete
{
    public class Lawyer:BaseEntity
    {
        public string BarRegisterNo { get; set; } = null!;
        public User? User;
    }
}

