using System;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;

namespace Karartek.DataAccess.Abstract
{
    public interface ICourtDal
    {
        Court Get(int id);
        List<Court> GetAll(int id);
        

        
    }
}

