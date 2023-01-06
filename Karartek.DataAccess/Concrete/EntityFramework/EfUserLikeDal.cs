using System;
using System.Linq;
using System.Linq.Expressions;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Karartek.DataAccess.Concrete.EntityFramework.Context
{
    public class EfUserLikeDal:IUserLikeDal
    {
    
            public UserLike Get(Expression<Func<UserLike, bool>>? filter = null)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    return context.Set<UserLike>().Include(x => x.User).SingleOrDefault(filter);
                }
            }

            public List<UserLike> GetAll(Expression<Func<UserLike, bool>>? filter = null)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    return filter == null
                        ? context.Set<UserLike>().ToList()
                        : context.Set<UserLike>().Where(filter).ToList();

                }
            }

            public UserLike Insert(UserLike userLike)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    context.UserLikes.Add(userLike);
                    context.SaveChanges();
                    return userLike;
                }
            }

            public UserLike Update(UserLike userLike)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    context.Update(userLike);
                    context.SaveChanges();

                    return userLike;
                }
            }
            public void Delete(UserLike userLike)
            {
                using (AppDbContext context = new AppDbContext())
                {
                    var deletedDecree = context.Entry(userLike);
                    deletedDecree.State = EntityState.Deleted;
                    context.SaveChanges();
                }


            }
    }
    
}

