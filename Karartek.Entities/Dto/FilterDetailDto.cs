﻿using System;
namespace Karartek.Entities.Dto
{
    public class FilterDetailDto
    {
        public int JudgmentTypeId { get; set; }
        public string CommisionName { get; set; } = null!;
        public string Court { get; set; } = null!;
        public string Decree { get; set; } = null!;
        public string DecreeType { get; set; } = null!;
        public string MeritsYear { get; set; } = null!;
        public string MeritsNo { get; set; } = null!;
        public string DecreeYear { get; set; } = null!;
        public string DecreeNo { get; set; } = null!;
        public string Decision { get; set; } = null!;
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }



    }
}

