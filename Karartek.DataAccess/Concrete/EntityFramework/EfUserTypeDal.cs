using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfUserTypeDal : IUserTypeDal
    {
        public bool AddUserType(UserType userType)
        {
            using var context = new AppDbContext();
            context.UserTypes.Add(userType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteUserType(UserType userType)
        {
            using var context = new AppDbContext();
            context.UserTypes.Remove(userType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<UserType> GetUserTypes()
        {
            using var context = new AppDbContext();
            return context.UserTypes.ToList();
        }

        public UserType GetUserTypeById(int id)
        {
            using var context = new AppDbContext();
            var userType = context.UserTypes.SingleOrDefault(x => x.TypeId == id);
            return userType;
        }

        public bool UpdateUserType(UserType userType)
        {
            using var context = new AppDbContext();
            context.UserTypes.Update(userType);
            var result = context.SaveChanges();
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
