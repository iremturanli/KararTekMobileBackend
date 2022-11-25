using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;


namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfCommissionDal : ICommissionDal
    {
        public Commission Get(int id)
        {
            using var context = new AppDbContext();
            var commission = context.Commissions.SingleOrDefault(x => x.Id == id);
            return commission;
        }

        public List<Commission> GetAll()
        {
            using var context = new AppDbContext();
            return context.Commissions.ToList();
        }
    }
}
