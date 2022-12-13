namespace Karartek.Entities.Dto
{
    public class JudgmentApprovalRequestDto
    {
        public int Id { get; set; }
        public int StateId { get; set; }
        public string? RejectMessage { get; set; } = null!;
    }

}
