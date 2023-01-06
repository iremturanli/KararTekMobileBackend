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
    public class CourtController : ControllerBase
    {
        private ICourtService _courtService;

        public CourtController(ICourtService courtService)
        {
            _courtService = courtService;
        }

        [HttpGet("GetAll")]
        public ActionResult<List<CourtResponseListDto>> GetAllbyId(int id)
        {
            var courtToSearch = _courtService.GetAllbyId(id);
            if (courtToSearch != null)
            {
                return Ok(courtToSearch);
            }
            else
                return BadRequest("Hata!");
        }

        [HttpGet("GetById/{{id}}")]
        public Court GetById(int id)
        {
            var courtToSearch = _courtService.GetCourtById(id);
            return courtToSearch;
        }

        [HttpGet("GetAllCourts")]
        public ActionResult<List<CourtResponseListDto>> GetAllCourts()
        {
            var courtToSearch = _courtService.GetAllCourts();
            if (courtToSearch != null)
            {
                return Ok(courtToSearch);
            }
            else
                return BadRequest("Hata!");
        }
    }
}
