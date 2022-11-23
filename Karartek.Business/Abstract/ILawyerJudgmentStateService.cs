using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface ILawyerJudgmentStateService
    {
        bool AddLawyyerJudgmentState(LawyerJudgmentStateDto lawyerJudgmentStateDto);
        bool DeleteLawyterJudgmentsState(LawyerJudgmentState lawyerJudgmentState);
        LawyerJudgmentState GetLawyerJudgmentStateById(int id);
        bool UpdateLawyerJudgmentState( LawyerJudgmentState lawyerJudgmentState);
        LawyerJudgmentStateResponseDto GetLawyerJudgmentStateTypes();
    }
}

