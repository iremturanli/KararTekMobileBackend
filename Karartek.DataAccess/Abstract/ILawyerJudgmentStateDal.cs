using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface ILawyerJudgmentStateDal
    {
        bool AddLawyerJudgmentStateType(LawyerJudgmentState lawyerJudgmentState);

        bool DeleteLawyerJudgmentState(LawyerJudgmentState lawyerJudgmentState);

        bool UpdateLawyerJudgmentState(LawyerJudgmentState lawyerJudgmentState);

        LawyerJudgmentState GetLawyerJudgmentStateById(int id);
        List<LawyerJudgmentState> GetLawyerJudgmentState();
    }
}

