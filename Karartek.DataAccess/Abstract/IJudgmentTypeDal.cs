using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface IJudgmentTypeDal
    {
        bool AddJudgmentType(JudgmentType judgmentType);

        bool DeleteJudgmentType(JudgmentType judgmentType);

        bool UpdateJudgmentType(JudgmentType judgmentType);

        JudgmentType GetJudgmentTypeById(int id);
        List<JudgmentType> GetJudgmentTypes();
    }
}
