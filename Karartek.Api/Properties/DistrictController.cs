using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Properties


{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictController : ControllerBase
    {
        private IDistrictService _districtService;

        public DistrictController(IDistrictService districtService)
        {
            _districtService = districtService;
        }

        [HttpGet("GetAll")]
        public IDataResult<List<DistrictResponseListDto>> GetAllbyId(int id)
        {
            var districtToSearch = _districtService.GetAllbyId(id);
            return districtToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public District GetById(int id)
        {
            var districtToSearch = _districtService.GetDistrictById(id);
            return districtToSearch;
        }
    }
}
