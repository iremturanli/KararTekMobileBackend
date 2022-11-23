using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class JudgmentTypeService : IJudgmentTypeService
    {
        private IJudgmentTypeDal _judgmentTypeDal;
        public JudgmentTypeService(IJudgmentTypeDal judgmentTypeDal)
        {
            _judgmentTypeDal = judgmentTypeDal;
        }

        public bool AddUserType(JudgmentTypeDto judgmentType)
        {
            var judgmentTypeEntity = new JudgmentType
            {
                TypeName = judgmentType.TypeName,
                CreateDate = DateTime.Now,
                TypeId = judgmentType.TypeId,

            };
            return _judgmentTypeDal.AddJudgmentType(judgmentTypeEntity);
        }

        public bool DeleteJudgmentType(JudgmentType judgmentType)
        {
            return _judgmentTypeDal.DeleteJudgmentType(judgmentType);
        }
        public JudgmentTypeResponseDto GetUserTypes()
        {
            var result = new JudgmentTypeResponseDto
            {
                JudgmentTypes = _judgmentTypeDal.GetJudgmentTypes(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }
        public JudgmentType GetJudgmentTypeById(int id)
        {
            return _judgmentTypeDal.GetJudgmentTypeById(id);
        }

        public bool UpdateJudgmentType(JudgmentType judgmentType)
        {
            return _judgmentTypeDal.UpdateJudgmentType(judgmentType);
        }

        public bool DeleteUserType(JudgmentType judgmentType)
        {

            return _judgmentTypeDal.DeleteJudgmentType(judgmentType);
        }

        public JudgmentTypeResponseDto GetJudgmentTypes()
        {
            var result = new JudgmentTypeResponseDto
            {
                JudgmentTypes = _judgmentTypeDal.GetJudgmentTypes(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }
    }

}