using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Concrete
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public string PlateCode { get; set; }
        public IEnumerable<District> Districts { get; set; }
        public IEnumerable<User> Users { get; set; }
    }
}
