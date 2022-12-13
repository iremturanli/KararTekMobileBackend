using System;
using Core.Utilities.Results;
using Karartek.Entities.Concrete;

namespace Karartek.Business.Abstract
{
    public interface IUserJudgmentStatisticService
    {
        //List<UserJudgmentStatistic> GetAll();
        IDataResult<List<UserJudgmentStatistic>> GetAll();

    }
}

