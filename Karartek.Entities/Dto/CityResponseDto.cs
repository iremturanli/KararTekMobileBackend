using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Dto
{
    public class CityResponseDto
    {

        public bool HasError { get; set; }
        public string Message { get; set; }
        public List<City> Cities { get; set; } = null!;

    }

}
