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

        [HttpGet("GetAll")]
        public CourtResponseDto GetAll([FromRoute] CommissionDto commissionDto)
        {
            var courtToSearch = _courtService.GetCourt(commissionDto);
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
