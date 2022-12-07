using System;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;

namespace Karartek.DataAccess.Abstract
{
    public interface IUserLikeDal
    {
        UserLike Insert(UserLike userLike);
        UserLike Update(UserLike userLike);
        List<UserLike> GetAll(Expression<Func<UserLike, bool>>? filter = null);
        UserLike Get(Expression<Func<UserLike, bool>>? filter = null);
    }
}

