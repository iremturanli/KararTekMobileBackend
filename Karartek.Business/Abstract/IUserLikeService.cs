using System;
using Core.Utilities.Results;
using Karartek.Entities.Concrete;

namespace Karartek.Business.Abstract
{
    public interface IUserLikeService
    {

        public IDataResult<List<UserLike>> GetAll(int id, int searchTypeId);
    }
}

