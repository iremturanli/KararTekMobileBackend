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
    public class CityService : ICityService
    {
        private ICityDal _cityDal;
        public CityService(ICityDal cityDal)
        {
            _cityDal = cityDal;
        }
        public CityResponseDto GetCities()
        {
            var result = new CityResponseDto
            {
                Cities = _cityDal.GetAll(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }
        public City GetCitiesById(int id)
        {
            return _cityDal.Get(id);
        }

        
    }
}
