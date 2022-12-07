using System;
using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;

namespace Karartek.Business.Concrete
{
    public class UserLikeService : IUserLikeService
    {

        private readonly IUserLikeDal _userLikeDal;


        public UserLikeService(IUserLikeDal userLikeDal)
        {
            _userLikeDal = userLikeDal;
        }




        public IDataResult<List<UserLike>> GetAll()
        {
            var result = _userLikeDal.GetAll();
            if (result != null)
            {
                return new SuccessDataResult<List<UserLike>>(result, "Success");

            }
            else
                return new ErrorDataResult<List<UserLike>>("Not Found");

        }
    }
}





