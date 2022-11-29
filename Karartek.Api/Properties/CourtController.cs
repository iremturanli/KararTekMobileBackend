 using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Properties


{
    [Route("api/[controller]")]
    [ApiController]
    public class CourtController : ControllerBase
    {
        private ICourtService _courtService;

        public CourtController(ICourtService courtService)
        {
            _courtService = courtService;
        }

        [HttpPost("GetAll/{{id}}")]
        public CourtResponseDto GetAll( int id)
        {
            var courtToSearch = _courtService.GetCourt(id);
            return courtToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public Court GetById(int id)
        {
            var courtToSearch = _courtService.GetCourtById(id);
            return courtToSearch;
        }
    }
}
