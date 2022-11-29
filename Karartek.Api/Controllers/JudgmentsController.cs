using Core.Utilities.Results;
using Karartek.Business.Abstract;
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

        public IDataResult<List<JudgmentResponseListDto>> GetJudgmentByType([FromBody] FilterDto filterDto)


        {
            var judgments = _judgmentService.GetJudgmentsByType(filterDto);
            return judgments;



        }


        [HttpGet("GetByKeyword/{{keyword}}")]
        public List<Judgment> GetbyKeyword(string keyword)
        {
            var judgmentToSearch = _judgmentService.GetbyKeyword(keyword);
            return judgmentToSearch;


        }

        [HttpGet("DeleteDecree/{{id}}")]
        public bool DeleteDecree(int id)
        {
            _judgmentService.DeleteDecree(id);
            return true;


        }
        [HttpGet("JudgmentsToLike/{id}")]
        public ActionResult JudgmentsToLike(int id)
        {
            var result=_judgmentService.Likes(id);
            if (result.Success)
            {
                return Ok(result);
            }
            else {
                return Ok(result);
                    }

        }





    }
}
