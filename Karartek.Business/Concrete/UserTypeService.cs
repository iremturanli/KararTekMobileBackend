using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.Business.Concrete
{
    public class UserTypeService : IUserTypeService
    {
        private IUserTypeDal _userTypeDal;
        public UserTypeService(IUserTypeDal userTypeDal)
        {
            _userTypeDal = userTypeDal;
        }

        public bool AddUserType(UserTypeDto userType)
        {
            var userTypeEntity = new UserType
            {
                TypeName = userType.TypeName,
                CreateDate = DateTime.Now,
                TypeId = userType.TypeId,

            };
            return _userTypeDal.AddUserType(userTypeEntity);
        }

        public bool DeleteUserType(UserType userType)
        {
            return _userTypeDal.DeleteUserType(userType);
        }
        public List<UserType> GetUserTypes()
        {
            return _userTypeDal.GetUserTypes();
        }
        public UserType GetUserTypeById(int id)
        {
            return _userTypeDal.GetUserTypeById(id);
        }

        public bool UpdateUserType(UserType userType)
        {
            return _userTypeDal.UpdateUserType(userType);
        }
    }

}