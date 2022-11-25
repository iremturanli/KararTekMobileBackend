using Karartek.Business.Abstract;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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
            if (judgmentToAdd)
            {
                return Ok(judgmentToAdd);

            }
            else

            { return BadRequest("Hata"); }

        }



















    }
}
