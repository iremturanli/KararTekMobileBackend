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
    public class CommissionService : ICommissionService
    {
        private ICommissionDal _commissionDal;
        public CommissionService(ICommissionDal commissionDal)
        {
            _commissionDal = commissionDal;
        }
        public CommissionResponseDto GetCommission()
        {
            var result = new CommissionResponseDto
            {

                Commissions = _commissionDal.GetAll(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }
        public Commission GetCommissionById(int id)
        {
            return _commissionDal.Get(id);
        }


    }
}
