using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Concrete
{
    public class City_District
    {
        [Key]
        public int Il_Ilce_Id { get; set; } 
        public int Il_Ilce_Turu_Id { get; set; }
        public int Plaka_Kodu { get; set; }
        public int Il_Id { get; set; }
        public string Il_Ilce_Adi { get; set; } = null!;

        public virtual ICollection<User>? Users { get; set; } = null!;
    }
}
