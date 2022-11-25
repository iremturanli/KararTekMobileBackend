using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ILawyerJudgmentService
    {
        bool AddLawyerJudgment(LawyerJudgmentDto judgmentDto);
        List<LawyerJudgmentDto> GetAll();
        List<LawyerJudgment> GetbyKeyword(string keyword);
        bool DeleteDecree(int id);
        ResponseDto Likes(int id);
        BaseResponseDto ApproveJudgment(JudgmentApprovalRequestDto judgmentApprovalRequestDto);
      
    }
}

