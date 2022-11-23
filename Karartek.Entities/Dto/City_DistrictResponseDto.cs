using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Dto
{
    public class City_DistrictResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; }
        public List<City_District> City_Districts { get; set; } = null!;

    }

}
