using Karartek.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.DataAccess.Abstract
{
    public interface ICityDal
    {
        City Get(int id);
        List<City> GetAll();
    }
}
