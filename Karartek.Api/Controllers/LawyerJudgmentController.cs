using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Protocol;
using System.Security.Claims;

namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LawyerJudgmentController : ControllerBase
    {
        private ILawyerJudgmentService _lawyerJudgmentService;

        public LawyerJudgmentController(ILawyerJudgmentService lawyerJudgmentService)
        {
            _lawyerJudgmentService = lawyerJudgmentService;
        }



        [HttpPost("Approval")]
        public ActionResult ApproveJudgment(JudgmentApprovalRequestDto judgmentApprovalRequestDto)
        {

            var judgmentToApproval = _lawyerJudgmentService.ApproveJudgment(judgmentApprovalRequestDto);
            if (judgmentToApproval is not null)

            {
                return Ok(judgmentToApproval);

            }
            else

            { return BadRequest("Hata"); }

        }
        [HttpGet("GetAll")]
        public ActionResult GetAll()
        {

            var judgmentToApproval = _lawyerJudgmentService.GetAll();
            if (judgmentToApproval is not null)

            {
                return Ok(judgmentToApproval);

            }
            else

            { return BadRequest("Hata"); }

        }


        [HttpPost("AddLawyerJudgments")]
        public ActionResult AddLawyerJudgments(LawyerJudgmentDto lawyerJudgmentDto)
        {
            lawyerJudgmentDto.UserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var judgmentToAdd = _lawyerJudgmentService.AddLawyerJudgment(lawyerJudgmentDto);
            if (judgmentToAdd is not null)
            {
                return Ok(judgmentToAdd);

            }
            else

            { return BadRequest("Hata"); }

        }


        [HttpGet("GetLawyerJudgmentByUserId")]

        public IDataResult<List<LawyerJudgmentResponseListDto>> GetLawyerJudgmentByUserId()


        {
            var UserId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var judgments = _lawyerJudgmentService.GetLawyerJudgmentsByUserId(UserId);
            return judgments;



        }

        [HttpGet("GetAllLawyerJudgments")]

        public IDataResult<List<LawyerJudgmentResponseListDto>> GetAllLawyerJudgments()


        {
            var judgments = _lawyerJudgmentService.GetAllLawyerJudgments();
            return judgments;



        }
        [HttpPost("GetLawyerJudgmentsByType")]

        public IDataResult<List<LawyerJudgmentResponseListDto>> GetLawyerJudgmentsByType([FromBody] FilterDto filterDto)


        {
            var judgments = _lawyerJudgmentService.GetLawyerJudgmentsByType(filterDto);
            return judgments;



        }






















    }
}
