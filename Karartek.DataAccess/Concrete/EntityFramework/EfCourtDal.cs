using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework.Context;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Karartek.DataAccess.Concrete.EntityFramework
{
    public class EfCourtDal : ICourtDal
    {
        public Court Get(int id)
        {
            using var context = new AppDbContext();
            var court = context.Courts.SingleOrDefault(x => x.Id == id);
            return court;
        }

        public List<Court> GetAll(int id)
        {
            using var context = new AppDbContext();
            var courtList= context.Courts.Where(x => x.CommissionId == id);
            return courtList.ToList();
        }
    }
}
