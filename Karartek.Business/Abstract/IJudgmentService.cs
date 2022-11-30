using Core.Utilities.Results;
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
    public interface IJudgmentService
    {
 
        bool AddJudgment(JudgmentDto judgmentDto);
        List<Judgment> GetAll();
        IDataResult <List<JudgmentResponseListDto>> GetJudgmentsByType(FilterDto filterDto);
        List<Judgment> GetbyKeyword(string keyword);
        bool DeleteDecree(int id);
        IResult Likes(int id, bool check);

    }
}
