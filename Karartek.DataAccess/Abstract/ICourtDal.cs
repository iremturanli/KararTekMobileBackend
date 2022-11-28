using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface ICourtDal
    {
        Court Get(int id);
        List<Court> GetAll();
    }
}

