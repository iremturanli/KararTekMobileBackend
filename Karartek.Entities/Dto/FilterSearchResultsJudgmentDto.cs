
namespace Karartek.Entities.Dto
{
    public class FilterSearchResultsJudgmentDto
    {
        public String? keyword { get; set; }
        public int? SearchTypeId { get; set; } 
        public int? OrderItem { get; set; }
        public int? CourtId { get; set; }
        public int? CommissionId { get; set; }
        public List<JudgmentResponseListDto>? JudgmentResponseListDto { get; set; }
        //public List<LawyerJudgmentResponseListDto>? LawyerJudgmentResponseListDto { get; set; }
    }
}
