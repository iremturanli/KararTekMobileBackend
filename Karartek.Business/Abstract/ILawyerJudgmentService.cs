using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ILawyerJudgmentService
    {
        bool AddLawyerJudgment(LawyerJudgmentDto judgmentDto);
        List<LawyerJudgment> GetAll();
        List<LawyerJudgment> GetbyKeyword(string keyword);
        bool DeleteDecree(int id);
        ResponseDto Likes(int id);
    }
}

