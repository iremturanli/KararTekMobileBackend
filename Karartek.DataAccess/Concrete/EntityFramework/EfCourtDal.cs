using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;


namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfCourtDal : ICourtDal
    {
        public Court Get(int id)
        {
            using var context = new AppDbContext();
            var court = context.Courts.SingleOrDefault(x => x.Id == id);
            return court;
        }

        public List<Court> GetAll()
        {
            using var context = new AppDbContext();
            return context.Courts.ToList();
        }
    }
}
