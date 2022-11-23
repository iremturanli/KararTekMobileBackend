using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Concrete
{
    public class District
    {
        [Key]
        public int Id { get; set; }
        public int CityId { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public City City { get; set; }

       
    }
}
