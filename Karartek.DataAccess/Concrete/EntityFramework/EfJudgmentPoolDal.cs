using System;
using Karartek.Entities.Dto;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Linq;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfJudgmentPoolDal : IJudgmentPoolDal
    {
        public bool FavoriteJudgment(JudgmentPoolDto judgmentPoolDto, int userId)
        {
            throw new NotImplementedException();
        }
        public JudgmentPool Insert(JudgmentPool judgmentPool)
        {
            using var context = new AppDbContext();
            context.JudgmentPools.Add(judgmentPool);
            context.SaveChanges();
            return judgmentPool;
        }

        public void Delete(JudgmentPool judgmentPool)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedDecree = context.Entry(judgmentPool);
                deletedDecree.State = EntityState.Deleted;
                context.SaveChanges();
            }


        }

        public JudgmentPool Get(Expression<Func<JudgmentPool, bool>>? filter = null)
        {

            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<JudgmentPool>().SingleOrDefault(filter);
            }
        }

        public List<JudgmentPool> GetAll(Expression<Func<JudgmentPool, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return filter == null
                    ? context.Set<JudgmentPool>().ToList()
                    : context.Set<JudgmentPool>().Where(filter).ToList();

            }
        }
    }
}

