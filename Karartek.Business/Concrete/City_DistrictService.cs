using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Business.Concrete
{
    public class City_DistrictService : ICity_DistrictService
    {
        private ICity_DistrictDal _city_DistrictDal;
        public City_DistrictService(ICity_DistrictDal city_DistrictDal)
        {
            _city_DistrictDal = city_DistrictDal;
        }
        public City_DistrictResponseDto GetCityDistricts()
        {
            var result = new City_DistrictResponseDto
            {
                City_Districts = _city_DistrictDal.GetAll(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }
        public City_District GetCityDistrictById(int id)
        {
            return _city_DistrictDal.Get(id);
        }
    }
}
