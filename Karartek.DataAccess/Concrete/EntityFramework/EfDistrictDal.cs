using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfDistrictDal :IDistrictDal
    {
        public District Get(int id)
        {
            using var context = new AppDbContext();
            var district = context.Districts.SingleOrDefault(x => x.Id == id);
            return district;
        }

        public List<District> GetAll(int id)
        {
            using var context = new AppDbContext();
            var districtList = context.Districts.Where(x => x.CityId == id);
            return districtList.ToList();
        }
    }
}
