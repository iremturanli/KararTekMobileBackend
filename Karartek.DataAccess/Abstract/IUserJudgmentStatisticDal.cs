using System;
using System.Linq.Expressions;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface IUserJudgmentStatisticDal
    {
        UserJudgmentStatistic Insert(UserJudgmentStatistic userJudgmentStatistic);
        UserJudgmentStatistic Update(UserJudgmentStatistic userJudgmentStatistic);
        List<UserJudgmentStatistic> GetAll(Expression<Func<UserJudgmentStatistic, bool>>? filter = null);
        UserJudgmentStatistic Get(Expression<Func<UserJudgmentStatistic, bool>>? filter = null);


    }
}

