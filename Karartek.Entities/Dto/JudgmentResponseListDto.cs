using System;
using Karartek.Entities.Concrete;

namespace Karartek.Entities.Dto
{
    public class JudgmentResponseListDto
    {
        
        public int Id { get; set; }
        public int JudgmentTypeId { get; set; }
        public int CommissionId { get; set; }
        public int? CourtId { get; set; }
        public string Decree { get; set; } = null!;
        public string DecreeType { get; set; } = null!;
        public string MeritsYear { get; set; } = null!;
        public string MeritsNo { get; set; } = null!;
        public string DecreeYear { get; set; } = null!;
        public string DecreeNo { get; set; } = null!;
        public string Decision { get; set; } = null!;
        public int Likes { get; set; }
        public DateTime JudgmentDate { get; set; }
        public DateTime CreateDate { get; set; }
        public string CommissionName { get; set; } = null!;
        public string? CourtName { get; set; }
        public string JudgmentTypeName { get; set; } = null!;
            public DateTime CreateDate { get; set; }

    }
}

