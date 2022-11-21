using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.DataAccess.Abstract
{
    public interface IJudgmentDal
    {
        Judgment GetJudgmentByDecreeNo(string decreeNo,string decreeYear);
        Judgment Insert(Judgment judgment);
        void Delete(Judgment judgment);
        Judgment Get(Expression<Func<Judgment,bool>>? filter =null);
        List<Judgment> GetAll(Expression<Func<Judgment, bool>>? filter = null);
        Judgment Update(Judgment judgment);

    }
}