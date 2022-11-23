using Karartek.Entities.Concrete;
using System.Linq.Expressions;

namespace Karartek.DataAccess.Abstract
{
    public interface IUserDal
    {
        User GetUserByIdentity(string identity);
        User GetUserById(int id);
        User Insert(User user);
        User userForForgotPassword(string identityNumber, byte[] passwordHash, byte[] passwordSalt);
        User Get(Expression<Func<User, bool>>? filter = null);
    }
}
