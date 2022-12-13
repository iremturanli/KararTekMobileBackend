using Core.Utilities.Results;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : IUserDal
    {
        public User GetUserByIdentity(string identityNumber)
        {
            using var context = new AppDbContext();
            var user = context.Users.Include(x => x.UserType).Include(c => c.City).ThenInclude(d => d.Districts).SingleOrDefault(x => x.IdentityNumber == identityNumber);
            return user;
        }



        public User Insert(User user)
        {
            using var context = new AppDbContext();
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }

        public User userForForgotPassword(string identityNumber, byte[] passwordHash, byte[] passwordSalt)
        {

            using var context = new AppDbContext();
            var user = GetUserByIdentity(identityNumber);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;

            context.Update(user);
            context.SaveChanges();

            return user;



        }

        public User Get(Expression<Func<User, bool>>? filter = null)
        {
            using (AppDbContext context = new AppDbContext())
            {
                return context.Set<User>().SingleOrDefault(filter);
            }
        }

        public User GetUserById(int id)
        {
            
            using var context = new AppDbContext();
            var user = context.Users.Where(x => x.Id == id).Include(x => x.UserType).Include(c => c.City).Include(d => d.District).Include(l=>l.Lawyer).Include(s => s.Student).SingleOrDefault();
            return user;
        }

        public User GetUserByEmail(string email)
        {
            using var context = new AppDbContext();
            var user = context.Users.Include(x => x.UserType).Include(c => c.City).ThenInclude(d => d.Districts).SingleOrDefault(x => x.Email == email);
            return user;

        }

        public User userForChangePassword(int id, byte[] passwordHash, byte[] passwordSalt)
        {
            using var context = new AppDbContext();
            var user = Get(p=>p.Id==id);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            context.Update(user);
            context.SaveChanges();

            return user;
        }

        public User GetUserByIdObj(int id)
        {
            using var context = new AppDbContext();
            var user = context.Users.Where(x => x.Id == id).Include(x => x.UserType).Include(c => c.City).Include(d => d.District).Include(l => l.Lawyer).Include(s => s.Student).SingleOrDefault();
            return user;
        }
    }
}
