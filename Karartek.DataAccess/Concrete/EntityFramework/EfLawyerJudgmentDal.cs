using System;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Karartek.DataAccess.Abstract;

namespace Karartek.DataAccess.Concrete
{
    public class EfLawyerJudgmentDal:ILawyerJudgmentDal
    {
        public void Delete(LawyerJudgment lawyerjudgment)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var deletedDecree = context.Entry(lawyerjudgment);
                deletedDecree.State = EntityState.Deleted;
                context.SaveChanges();
            }


        }

        public LawyerJudgment Get(Expression<Func<LawyerJudgment, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<LawyerJudgment>().SingleOrDefault(filter);
            }
        }

        public List<LawyerJudgment> GetAll(Expression<Func<LawyerJudgment, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return filter == null
                    ? context.Set<LawyerJudgment>().ToList()
                    : context.Set<LawyerJudgment>().Where(filter).ToList();

            }
        }

        public LawyerJudgment GetLawyerJudgmentByDecreeNo(string decreeNo, string decreeYear)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var judgment = context.LawyerJudgments.SingleOrDefault(x => x.DecreeNo == decreeNo && x.DecreeYear == decreeYear);
                return judgment;


            }
        }


        public LawyerJudgment Insert(LawyerJudgment judgment)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.LawyerJudgments.Add(judgment);
                context.SaveChanges();
                return judgment;
            }


        }

        public LawyerJudgment Update(LawyerJudgment judgment)
        {
            using (AppDbContext context = new AppDbContext())
            {
                context.Update(judgment);
                context.SaveChanges();

                return judgment;
            }

        }
    }
}

