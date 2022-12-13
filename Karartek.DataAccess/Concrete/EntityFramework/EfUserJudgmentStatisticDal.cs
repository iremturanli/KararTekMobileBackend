using System;
using System.Linq;
using System.Linq.Expressions;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context
{
    public class EfUserJudgmentStatisticDal:IUserJudgmentStatisticDal
    {


        public UserJudgmentStatistic Get(Expression<Func<UserJudgmentStatistic, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<UserJudgmentStatistic>().Include(x=>x.User).SingleOrDefault(filter);
            }
        }

            public List<UserJudgmentStatistic> GetAll(Expression<Func<UserJudgmentStatistic, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return filter == null
                    ? context.Set<UserJudgmentStatistic>().ToList()
                    : context.Set<UserJudgmentStatistic>().Where(filter).ToList();

            }
        }

        public UserJudgmentStatistic Insert(UserJudgmentStatistic userJudgmentStatistic)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.UserJudgmentStatistics.Add(userJudgmentStatistic);
                context.SaveChanges();
                return userJudgmentStatistic;
            }
        }

        public UserJudgmentStatistic Update(UserJudgmentStatistic userJudgmentStatistic)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Update(userJudgmentStatistic);
                context.SaveChanges();

                return userJudgmentStatistic;
            }
        }
    }
}

