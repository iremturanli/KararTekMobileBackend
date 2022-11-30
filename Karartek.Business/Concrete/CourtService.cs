using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.DataAccess.Abstract;
using Karartek.DataAccess.Concrete.EntityFramework;
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
        public IDataResult<List<CourtResponseListDto>> GetAllbyId(int id)
        {

            var result = _courtDal.GetAll(id);
            var listDto = new List<CourtResponseListDto>();

            foreach (var item in result)
            {

                var dto = new CourtResponseListDto()
                {
                    Name = item.Name,
                    Id = item.Id,
                };

                listDto.Add(dto);


            }



            if (result != null)
            {
                return new SuccessDataResult<List<CourtResponseListDto>>(listDto, "Success!");
            }

            else
            {
                return new ErrorDataResult<List<CourtResponseListDto>>("Not Found");
            }


        }
        public Court GetCourtById(int id)
        {
            return _courtDal.Get(id);
        }


    }
}
