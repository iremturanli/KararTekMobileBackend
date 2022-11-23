using System.Linq.Expressions;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface IUserDal
    {
        User GetUserByIdentity(string identity);
        User Insert(User user);
        User userForForgotPassword(string identityNumber, byte[] passwordHash, byte[] passwordSalt);
        User Get(Expression<Func<User, bool>>? filter = null);
    }
}
