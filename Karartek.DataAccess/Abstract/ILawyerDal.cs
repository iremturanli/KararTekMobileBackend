using System;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Abstract
{
    public interface ILawyerDal
    {
        Lawyer Insert(Lawyer lawyer);
    }
}

