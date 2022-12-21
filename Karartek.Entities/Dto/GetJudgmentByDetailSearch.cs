using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Dto
{
    public class GetJudgmentByDetailSearchDto
    {
        public String? keyword { get; set; }
        public int? searchTypeId { get; set; }
        public int? judgmentTypeId { get; set; } 
        public int? commissionId { get; set; }
        public int? courtId { get; set; }  
        public String? meritsYear { get; set; }
        public String? meritsFirstOrder { get; set; }
        public String? meritsLastOrder { get; set; }
        public String? decreeYear { get; set; }
        public String? decreeFirstOrder { get; set; }
        public String? decreeLastOrder { get; set; }
        public DateTime? firstDate { get; set; }
        public DateTime? lastDate { get; set; }

    }
}
