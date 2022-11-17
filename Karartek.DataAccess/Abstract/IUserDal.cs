using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface IUserDal
    {
        User GetUserByIdentity(string identity);
        User Insert(User user);
    }
}
