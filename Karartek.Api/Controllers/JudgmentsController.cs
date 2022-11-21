using Karartek.Business.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Controllers
{ 
    [Route("api/[controller]")]
    [ApiController]

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
    public List<Judgment>GetAll()
    {
        var judgments = _judgmentService.GetAll();
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
        [HttpGet("JudgmentsToLike{{id}}")]
        public bool JudgmentsToLike(int id)
        {
            _judgmentService.Likes(id);
            return true;


        }





    }
}
