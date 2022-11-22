using System;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfLawyerDal:ILawyerDal
    {
        public EfLawyerDal()
        {
        }

        public Lawyer Insert(Lawyer lawyer)
        {
          
                using var context = new AppDbContext();
                context.Lawyers.Add(lawyer);
                context.SaveChanges();
                return lawyer;
            

        }
    }
}

