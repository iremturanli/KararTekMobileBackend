using System;
using Core.Utilities.Results;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface IUserLikeService
    {

        public IDataResult<List<UserLikeDto>> GetAll(int id, int searchTypeId);
    }
}

