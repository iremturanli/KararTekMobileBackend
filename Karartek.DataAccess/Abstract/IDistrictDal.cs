using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.DataAccess.Abstract
{
    public interface IDistrictDal
    {
        District Get(int id);
        List<District> GetAll(int id);
    }
}
