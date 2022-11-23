using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface IJudgmentTypeService
    {
        bool AddUserType(JudgmentTypeDto judgmentTypeDto);
        bool DeleteUserType(JudgmentType judgmentType);
        JudgmentType GetJudgmentTypeById(int id);
        bool UpdateJudgmentType(JudgmentType judgmentType);
       JudgmentTypeResponseDto GetJudgmentTypes();
    }
}
