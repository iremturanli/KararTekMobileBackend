using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Entities.Dto
{
    public class ResponseDto
    {
        public bool HasError { get; set; }
        public string Message { get; set; }
        public string Token { get; set; } = null!;
    }


}
