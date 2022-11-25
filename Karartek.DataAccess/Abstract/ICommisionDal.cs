using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface ICommisionDal
    {
        Commission Get(int id);
        List<Commission> GetAll();
    }
}

