using Core.Utilities.Results;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ILawyerJudgmentService
    {
        BaseResponseDto AddLawyerJudgment(LawyerJudgmentDto judgmentDto);
        List<LawyerJudgmentDto> GetAll();
        List<LawyerJudgment> GetbyKeyword(string keyword);
        bool DeleteDecree(int id);
        IResult Likes(int id, bool check);
        BaseResponseDto ApproveJudgment(JudgmentApprovalRequestDto judgmentApprovalRequestDto);
        IDataResult<List<LawyerJudgmentResponseListDto>> GetLawyerJudgmentsByUserId(int id);
        IDataResult<List<LawyerJudgmentResponseListDto>> GetAllLawyerJudgments();
        IDataResult<List<LawyerJudgmentResponseListDto>> GetLawyerJudgmentsByType(FilterDto filterDto);


    }
}

