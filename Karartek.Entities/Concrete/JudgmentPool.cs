using Karartek.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Concrete
{
   public class JudgmentPool:BaseEntity
    {
        public int UserId { get; set; }
        public int JudgmentId { get; set; }
        public User? User { get; set; }=null!;
        public Judgment? Judgment { get; set; } = null!;
      
    }
}
