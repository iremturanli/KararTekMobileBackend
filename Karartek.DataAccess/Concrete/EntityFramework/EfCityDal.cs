using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;


namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfCityDal : ICityDal
    {
        public City Get(int id)
        {
            using var context = new AppDbContext();
            var city = context.Cities.SingleOrDefault(x => x.Id == id);
            return city;
        }

        public List<City> GetAll()
        {
            using var context = new AppDbContext();
            return context.Cities.ToList();
        }
    }
}
