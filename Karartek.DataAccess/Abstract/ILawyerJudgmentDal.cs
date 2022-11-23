using System;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;

namespace Karartek.DataAccess.Abstract
{
    public interface ILawyerJudgmentDal
    {
        LawyerJudgment GetLawyerJudgmentByDecreeNo(string decreeNo, string decreeYear);
        LawyerJudgment Insert(LawyerJudgment lawyerJudgment);
        void Delete(LawyerJudgment lawyerjudgment);
        LawyerJudgment Get(Expression<Func<LawyerJudgment, bool>>? filter = null);
        List<LawyerJudgment> GetAll(Expression<Func<LawyerJudgment, bool>>? filter = null);
        LawyerJudgment Update(LawyerJudgment lawyerjudgment);
    }
}

