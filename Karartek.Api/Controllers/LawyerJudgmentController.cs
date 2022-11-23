using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Karartek.Business.Abstract;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LawyerJudgmentController : ControllerBase
    {
        private ILawyerJudgmentService _lawyerJudgmentService;

        public LawyerJudgmentController(ILawyerJudgmentService lawyerJudgmentService)
        {
            _lawyerJudgmentService = lawyerJudgmentService;
        }



        [HttpPost("Approval")]
        public ActionResult ApproveJudgment(LawyerJudgmentDto lawyerJudgmentDto)
        {

            var judgmentToApproval = _lawyerJudgmentService.ApproveJudgment(lawyerJudgmentDto.Id);
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

            var judgmentToAdd = _lawyerJudgmentService.AddLawyerJudgment(lawyerJudgmentDto);
            if (judgmentToAdd )
            {
                return Ok(judgmentToAdd);

            }
            else

            { return BadRequest("Hata"); }

        }



        [HttpPost("Decline")]
        public ActionResult DeclineJudgment(LawyerJudgmentDto lawyerJudgmentDto)
        {

            var judgmentToAdd = _lawyerJudgmentService.DeclineJudgment(lawyerJudgmentDto.Id,lawyerJudgmentDto.TBBComments);
            if (judgmentToAdd is not null)
            {
                return Ok(judgmentToAdd);

            }
            else

            { return BadRequest("Hata"); }

        }

















    }
}
