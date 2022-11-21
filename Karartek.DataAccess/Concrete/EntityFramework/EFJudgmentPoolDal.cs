using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EFJudgmentPoolDal : IJudgmentPoolDal
    {
        public JudgmentPool GetJudgmentPool(int userId)
        {
            throw new NotImplementedException();
        }

    
        public JudgmentPool Add(JudgmentPool judgmentPool)
        {
            
                using (AppDbContext context = new AppDbContext())
                {
                    context.JudgmentPools.Add(judgmentPool);
                    context.SaveChanges();
                    return judgmentPool;
                }


            }

            public JudgmentPool Remove(JudgmentPool judgmentPool)
        {
            using (AppDbContext context = new AppDbContext())
            {
                var removedJudgment = context.Entry(judgmentPool);
                removedJudgment.State = EntityState.Deleted;
                context.SaveChanges();
                return judgmentPool;
            }

        }

        public List<JudgmentPool> GetAllJudgmentsinPool(int userId)
        {
            throw new NotImplementedException();
        }
    }
}
