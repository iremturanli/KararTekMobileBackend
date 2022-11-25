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
    public class CommisionService : ICommisionService
    {
        private ICommisionDal _commisionDal;
        public CommisionService(ICommisionDal commisionDal)
        {
            _commisionDal = commisionDal;
        }
        public CommisionResponseDto GetCommision()
        {
            var result = new CommisionResponseDto
            {

                Commisions = _commisionDal.GetAll(),
                HasError = false,
                Message = "Success"
            };
            return result;
        }
        public Commision GetCommisionById(int id)
        {
            return _commisionDal.Get(id);
        }


    }
}
