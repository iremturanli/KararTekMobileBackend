using Core.Utilities.Results;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Business.Abstract
{
    public interface IJudgmentPoolService
    {
        BaseResponseDto AddtoJudgmentPool(int userId,int judgmentId,int searchTypeId);
        BaseResponseDto DeleteFromJudgmentPool(int id, int searchTypeId, int userId);
        IDataResult<JudgmentLawyerJudgmentDto> GetAll(int userId);

    }
}
