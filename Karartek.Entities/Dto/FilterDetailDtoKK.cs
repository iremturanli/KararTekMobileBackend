using System;
namespace Karartek.Entities.Dto
{
    public class FilterDetailDtoKK
    {
        
           
            public string Decree { get; set; } = null!;
            public string MeritsNo { get; set; } = null!;
            public string DecreeNo { get; set; } = null!;
            public string Decision { get; set; } = null!;
            public int? JudgmentStateId { get; set; }
            public string LawyerAssesment { get; set; } = null!;
            public DateTime StartDate { get; set; }
            public DateTime FinishDate { get; set; }




        
    }
}

