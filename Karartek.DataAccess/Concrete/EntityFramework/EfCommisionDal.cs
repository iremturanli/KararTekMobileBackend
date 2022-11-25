using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;


namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfCommisionDal : ICommisionDal
    {
        public Commision Get(int id)
        {
            using var context = new AppDbContext();
            var commision = context.Commisions.SingleOrDefault(x => x.Id == id);
            return commision;
        }

        public List<Commision> GetAll()
        {
            using var context = new AppDbContext();
            return context.Commisions.ToList();
        }
    }
}
