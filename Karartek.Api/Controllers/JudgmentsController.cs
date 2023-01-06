using System.Security.Claims;
using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]

    public class JudgmentsController : ControllerBase
    {
        private IJudgmentService _judgmentService;

        public JudgmentsController(IJudgmentService judgmentService)
        {
            _judgmentService = judgmentService;
        }



        [HttpPost("Add Judgment")]
        public ActionResult AddJudgment(JudgmentDto judgmentDto)
        {

            var judgmentToAdd = _judgmentService.AddJudgment(judgmentDto);
            if (judgmentToAdd)
            {
                return Ok(judgmentToAdd);

            }
            else
            { return BadRequest("Adding Failed"); }

        }


        [HttpGet("AllJudgments")]
        public List<Judgment> GetAll()
        {
            var judgments = _judgmentService.GetAll();
            return judgments;


        }


        [HttpPost("GetJudgmentByType")]

        public ActionResult<List<JudgmentResponseListDto>> GetJudgmentByType([FromBody] FilterDto filterDto)


        {
            var judgments = _judgmentService.GetJudgmentsByType(filterDto);
            if (judgments!=null)
            {
                return Ok(judgments);

            }
            else
            { return BadRequest("Failed"); }



        }

        [HttpPost("GetJudgmentByDetailSearch")]

        public ActionResult<List<JudgmentResponseListDto>> GetJudgmentByDetailSearch([FromBody] GetJudgmentByDetailSearchDto detailSearchDto)


        {
            var judgments = _judgmentService.GetJudgmentsByDetailSearch(detailSearchDto);
            if (judgments != null)
            {
                return Ok(judgments);

            }
            else
            { return BadRequest("Failed"); }



        }


        [HttpGet("GetByKeyword/{keyword}")]
        public List<Judgment> GetbyKeyword(string keyword)
        {
            var judgmentToSearch = _judgmentService.GetbyKeyword(keyword);
            return judgmentToSearch;


        }

        [HttpGet("DeleteDecree/{id}")]
        public bool DeleteDecree(int id)
        {
            _judgmentService.DeleteDecree(id);
            return true;


        }
        [HttpPost("JudgmentToLike")]
        public ActionResult JudgmentsToLike([FromQuery] int id,bool check)
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var result=_judgmentService.Likes(id,check,userId);
            if (result.Success)
            {
                return Ok(result);
            }
            else {  
                return Ok(result);
                    }

        }


        [HttpGet("GetById")]

        public ActionResult<List<LawyerJudgment>> GetbyId(int id)


        {
            var judgments = _judgmentService.GetbyId(id);
            if (judgments != null)
            {
                return Ok(judgments);
        }

            else

            {

                return BadRequest("Hata!");

            }





        }







    }
}
