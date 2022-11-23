using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Properties


{
    [Route("api/[controller]")]
    [ApiController]
    public class City_DistrictController : ControllerBase
    {
        private ICity_DistrictService _city_DistrictService;

        public City_DistrictController(ICity_DistrictService city_DistrictService)
        {
            _city_DistrictService = city_DistrictService;
        }

        [HttpGet("GetAll")]
        public City_DistrictResponseDto GetAll()
        {
            var city_DistrictToSearch = _city_DistrictService.GetCityDistricts();
            return city_DistrictToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public City_District GetById(int id)
        {
            var city_DistrictToSearch = _city_DistrictService.GetCityDistrictById(id);
            return city_DistrictToSearch;
        }
    }
}
