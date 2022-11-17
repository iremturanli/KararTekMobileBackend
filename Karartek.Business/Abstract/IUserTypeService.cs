using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Abstract
{
    public interface IUserTypeService
    {
        bool AddUserType(UserTypeDto userType);
        bool DeleteUserType(UserType userType);
        UserType GetUserTypeById(int id);
        bool UpdateUserType(UserType userType);
        List<UserType> GetUserTypes();
    }
}
