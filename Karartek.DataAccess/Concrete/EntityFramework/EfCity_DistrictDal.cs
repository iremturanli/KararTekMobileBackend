using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using System.Linq.Expressions;


namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfCity_DistrictDal : ICity_DistrictDal
    {
        public City_District Get(int id)
        {
            using var context = new AppDbContext();
            var cityDistrict = context.City_Districts.SingleOrDefault(x => x.Il_Ilce_Id == id);
            return cityDistrict;
        }

        public List<City_District> GetAll()
        {
            using var context = new AppDbContext();
            return context.City_Districts.ToList();
        }
    }
}
