using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Business.Abstract
{
    public interface ICityService
    {
        City GetCitiesById(int id);
        CityResponseDto GetCities();
    }
}
