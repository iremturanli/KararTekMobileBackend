using System;
using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class UserLikeService : IUserLikeService
    {

        private readonly IUserLikeDal _userLikeDal;


        public UserLikeService(IUserLikeDal userLikeDal)
        {
            _userLikeDal = userLikeDal;
        }




        public IDataResult<List<UserLike>> GetAll(int id,int searchTypeId)
        {
            var result = _userLikeDal.GetAll(p => p.UserId == id && p.TypeId==searchTypeId) ;

            foreach (var item in result)
            {


                var userLikeDto = new UserLikeDto()
                {
                    JudgmentId = item.JudgmentId,
                    isLike=item.isLike
                    

                };
                 
    
                  
            }
          
            if (result != null)
            {
                return new SuccessDataResult<List<UserLike>>(result, "Success");

            }
            else
                return new ErrorDataResult<List<UserLike>>("Not Found");

        }
    }
}





