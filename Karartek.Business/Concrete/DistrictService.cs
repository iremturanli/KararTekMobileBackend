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
    public class DistrictService : IDistrictService
    {
        private IDistrictDal _districtDal;
        public DistrictService(IDistrictDal districtDal)
        {
            _districtDal = districtDal;
        }
        public IDataResult<List<DistrictResponseListDto>> GetAllbyId(int id)
        {

            var result = _districtDal.GetAll(id);
            var listDto = new List<DistrictResponseListDto>();

            foreach (var item in result)
            {

                var dto = new DistrictResponseListDto()
                {
                    Name = item.Name,
                    Id = item.Id,
                };

                listDto.Add(dto);


            }



            if (result != null)
            {
                return new SuccessDataResult<List<DistrictResponseListDto>>(listDto, "Success!");
            }

            else
            {
                return new ErrorDataResult<List<DistrictResponseListDto>>("Not Found");
            }


        }
        public District GetDistrictById(int id)
        {
            return _districtDal.Get(id);
        }


    }
}
