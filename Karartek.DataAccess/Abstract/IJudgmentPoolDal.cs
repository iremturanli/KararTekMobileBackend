using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.DataAccess.Abstract
{
    public interface IJudgmentPoolDal
    {
        public JudgmentPool Add(JudgmentPool judgmentPool);
        public JudgmentPool Remove(JudgmentPool judgmentPool);
        JudgmentPool GetJudgmentPool(int userId);
        List<JudgmentPool> GetAllJudgmentsinPool(int userId);
    }
}
