using System;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfJudgmentTypeDal:IJudgmentTypeDal
    {
        public EfJudgmentTypeDal()
        {
        }

        public bool AddJudgmentType(JudgmentType judgmentType)
        {
            using var context = new AppDbContext();
            context.JudgmentTypes.Add(judgmentType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteJudgmentType(JudgmentType judgmentType)
        {
            using var context = new AppDbContext();
            context.JudgmentTypes.Remove(judgmentType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public JudgmentType GetJudgmentTypeById(int id)
        {
            using var context = new AppDbContext();
            var judgmentType = context.JudgmentTypes.SingleOrDefault(x => x.TypeId == id);
            return judgmentType;
        }

        public List<JudgmentType> GetJudgmentTypes()
        {
            using var context = new AppDbContext();
            return context.JudgmentTypes.ToList();
        }

        public bool UpdateJudgmentType(JudgmentType judgmentType)
        {
            using var context = new AppDbContext();
            context.JudgmentTypes.Update(judgmentType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

