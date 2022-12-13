using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Properties


{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase
    {
        private ICityService _cityService;

        public CityController(ICityService cityService)
        {
            _cityService = cityService;
        }

        [HttpGet("GetAll")]
        public CityResponseDto GetAll()
        {
            var cityToSearch = _cityService.GetCities();
            return cityToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public City GetById(int id)
        {
            var citySearch = _cityService.GetCitiesById(id);
            return citySearch;
        }
    }
}
