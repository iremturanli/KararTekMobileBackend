using System;
using Core.Utilities.Results;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface IUserJudgmentStatisticService
    {
        //List<UserJudgmentStatistic> GetAll();
        IDataResult<List<UserJudgmentStatistic>> GetAll();
        IDataResult<List<UserJudgmentStatistic>> GetAllbyKeyword(FilterStatisticDto filterStatisticDto);

    }
}

