using System;
using Core.Utilities.Results;
using Karartek.Entities.Concrete;

namespace Karartek.Business.Abstract
{
    public interface IUserLikeService
    {
        IDataResult<List<UserLike>> GetAll();
    }
}

