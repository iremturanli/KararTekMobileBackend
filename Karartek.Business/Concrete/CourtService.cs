using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karartek.Business.Concrete
{
    public class CourtService : ICourtService
    {
        private ICourtDal _courtDal;
        public CourtService(ICourtDal courtDal)
        {
            _courtDal = courtDal;
        }
        public CourtResponseDto GetCourt(CommissionDto commissionDto)
        {

            var result = new CourtResponseDto
            {

                Courts = _courtDal.GetAll(commissionDto),
                HasError = false,
                Message = "Success"
            };
            return result;
        }
        public Court GetCourtById(int id)
        {
            return _courtDal.Get(id);
        }


    }
}
