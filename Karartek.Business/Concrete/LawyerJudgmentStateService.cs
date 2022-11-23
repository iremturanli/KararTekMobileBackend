using System;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class LawyerJudgmentStateService : ILawyerJudgmentStateService
    {
        private ILawyerJudgmentStateDal _lawyerJudgmentStateDal;
        public LawyerJudgmentStateService(ILawyerJudgmentStateDal lawyerJudgmentStateDal)
        {
            _lawyerJudgmentStateDal = lawyerJudgmentStateDal;
        }

        public bool AddLawyyerJudgmentState(LawyerJudgmentStateDto lawyerJudgmentStateDto)
        {
            var stateTypeEntity = new LawyerJudgmentState
            {
                StateName = lawyerJudgmentStateDto.StateName,
                CreateDate = DateTime.Now,
                StateId = lawyerJudgmentStateDto.StateId,

            };
            return _lawyerJudgmentStateDal.AddLawyerJudgmentStateType(stateTypeEntity);
        }

        public bool DeleteLawyterJudgmentsState(LawyerJudgmentState lawyerJudgmentState)
        {
            return _lawyerJudgmentStateDal.DeleteLawyerJudgmentState(lawyerJudgmentState);
        }

        public LawyerJudgmentState GetLawyerJudgmentStateById(int id)
        {
            return _lawyerJudgmentStateDal.GetLawyerJudgmentStateById(id);
        }

        public LawyerJudgmentStateResponseDto GetLawyerJudgmentStateTypes()
        {
            var result = new LawyerJudgmentStateResponseDto
            {
                LawyerJudgmentStates = _lawyerJudgmentStateDal.GetLawyerJudgmentState(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }

        public bool UpdateLawyerJudgmentState(LawyerJudgmentState lawyerJudgmentState)
        {
            return _lawyerJudgmentStateDal.UpdateLawyerJudgmentState(lawyerJudgmentState);
        }
    }
}

