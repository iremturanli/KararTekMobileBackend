using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;


namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfCommissionDal : ICommisionDal
    {
        public Commission Get(int id)
        {
            using var context = new AppDbContext();
            var commision = context.Commissions.SingleOrDefault(x => x.Id == id);
            return commision;
        }

        public List<Commission> GetAll()
        {
            using var context = new AppDbContext();
            return context.Commissions.ToList();
        }
    }
}
