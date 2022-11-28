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
        //public List<Judgment> GetYargıtayJudgments(string keyword);
        //public List<Judgment> GetDanistayJudgments(string keyword);
        //public List<Judgment> GetAnayasaMahkemeJudgments(string keyword);
        public List<Judgment> GetJudgmentsByType(string keyword, JudgmentDto judgmentDto);
        List<Judgment> GetbyKeyword(string keyword);
        bool DeleteDecree(int id);
        ResponseDto Likes(int id);

    }
}
