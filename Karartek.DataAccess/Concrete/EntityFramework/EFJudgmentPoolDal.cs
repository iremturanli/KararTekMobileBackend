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
                return context.Set<JudgmentPool>().Include(x=>x.Judgment.Court).Include(x => x.Judgment.Commission).SingleOrDefault(filter);
            }
        }

        public List<JudgmentPool> GetAll(Expression<Func<JudgmentPool, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var result = filter == null
                     ? context.Set<JudgmentPool>().Include(x => x.LawyerJudgment).Include(x => x.Judgment).ToList()
                    : context.Set<JudgmentPool>().Include(x => x.LawyerJudgment).Include(x => x.Judgment).Where(filter).ToList();

                return result;
            }
        }
    }
}

