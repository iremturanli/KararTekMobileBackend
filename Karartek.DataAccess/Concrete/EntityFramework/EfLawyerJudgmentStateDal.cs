using System;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context
{
    public class EfLawyerJudgmentStateDal:ILawyerJudgmentStateDal
    {
        public EfLawyerJudgmentStateDal()
        {
        }

        public bool AddLawyerJudgmentStateType(LawyerJudgmentState lawyerJudgmentState)
        {
            using var context = new AppDbContext();
            context.LawyerJudgmentStates.Add(lawyerJudgmentState);
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

        public bool DeleteLawyerJudgmentState(LawyerJudgmentState lawyerJudgmentState)
        {
            using var context = new AppDbContext();
            context.LawyerJudgmentStates.Remove(lawyerJudgmentState);
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

        public List<LawyerJudgmentState> GetLawyerJudgmentState()
        {
            using var context = new AppDbContext();
            return context.LawyerJudgmentStates.ToList();
        }

        public LawyerJudgmentState GetLawyerJudgmentStateById(int id)
        {
            using var context = new AppDbContext();
            var state = context.LawyerJudgmentStates.SingleOrDefault(x => x.StateId == id);
            return state;
        }

        public bool UpdateLawyerJudgmentState(LawyerJudgmentState lawyerJudgmentState)
        {
            using var context = new AppDbContext();
            context.LawyerJudgmentStates.Update(lawyerJudgmentState);
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

