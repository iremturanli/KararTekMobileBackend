using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface ICommissionDal
    {
        Commission Get(int id);
        List<Commission> GetAll();
    }
}

