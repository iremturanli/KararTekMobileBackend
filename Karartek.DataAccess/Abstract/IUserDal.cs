using Core.Utilities.Results;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using System.Linq.Expressions;

namespace Karartek.DataAccess.Abstract
{
    public interface IUserDal
    {
        User GetUserByEmail(string email);
        User GetUserByIdentity(string identity);
        List<User> GetUserById(int id);
        User Insert(User user);
        User userForForgotPassword(string identityNumber, byte[] passwordHash, byte[] passwordSalt);
        User Get(Expression<Func<User, bool>>? filter = null);
    }
}
