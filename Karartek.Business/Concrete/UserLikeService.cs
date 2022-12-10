using System;
using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Concrete.Enum;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class UserLikeService : IUserLikeService
    {

        private readonly IUserLikeDal _userLikeDal;
        private readonly ILawyerJudgmentDal _lawyerJudgmentDal;
        private readonly IJudgmentDal _judgmentDal;


        public UserLikeService(IUserLikeDal userLikeDal,IJudgmentDal judgmentDal,ILawyerJudgmentDal lawyerJudgmentDal)
        {
            _userLikeDal = userLikeDal;
            _judgmentDal = judgmentDal;
            _lawyerJudgmentDal = lawyerJudgmentDal;
        }




        public IDataResult<List<UserLikeDto>> GetAll(int id,int searchTypeId)
        {
            var result = _userLikeDal.GetAll(p => p.UserId == id && p.TypeId==searchTypeId) ;
            UserLikeDto userLikeDto = new UserLikeDto();
            List<UserLikeDto> userLikeDtoList = new List<UserLikeDto>();

            foreach (var item in result)
            {

                userLikeDto.JudgmentId = item.JudgmentId;
                userLikeDto.isLike = item.isLike;


                userLikeDtoList.Add(userLikeDto);
            }
            

            
            

         
            if (result != null)
            {
                return new SuccessDataResult<List<UserLikeDto>>(userLikeDtoList, "Success");



            }
            else
                return new ErrorDataResult<List<UserLikeDto>>("Not Found");

        }
    }
}





