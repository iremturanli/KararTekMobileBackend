using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface ICommisionDal
    {
        Commision Get(int id);
        List<Commision> GetAll();
    }
}

