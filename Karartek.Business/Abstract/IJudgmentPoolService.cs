using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Business.Abstract
{
    public interface IJudgmentPoolService
    {
        ResponseDto AddtoJudgmentPool(JudgmentPoolDto judgmentPool,int judgmentId);
        bool DeleteFromJudgmentPool(int id);
        List<Judgment> GetAll(JudgmentPoolDto judgmentPoolDto);

    }
}
