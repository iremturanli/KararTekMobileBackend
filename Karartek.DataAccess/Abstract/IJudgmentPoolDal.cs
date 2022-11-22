using System;
using System.Linq.Expressions;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.DataAccess.Abstract
{
    public interface IJudgmentPoolDal
    {
        public JudgmentPool Insert(JudgmentPool judgmentPool);
        void Delete(JudgmentPool judgmentPool);
        JudgmentPool Get(Expression<Func<JudgmentPool, bool>>? filter = null);
        List<JudgmentPool> GetAll(Expression<Func<JudgmentPool, bool>>? filter = null);



    }
}

