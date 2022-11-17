using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface IUserTypeDal
    {
        bool AddUserType(UserType userType);

        bool DeleteUserType(UserType userType);

        bool UpdateUserType(UserType userType);

        UserType GetUserTypeById(int id);
        List<UserType> GetUserTypes();
    }
}
