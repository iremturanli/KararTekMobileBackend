using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Karartek.Business.Abstract;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Properties
{
    [Route("api/[controller]")]
    [ApiController]

    public class LawyerJudgmentStateController : ControllerBase {
        private ILawyerJudgmentStateService _lawyerJudgmentStateService;

        public LawyerJudgmentStateController(ILawyerJudgmentStateService lawyerJudgmentStateService)
        {
            _lawyerJudgmentStateService = lawyerJudgmentStateService;
        }



        [HttpGet("GetAll")]
        public LawyerJudgmentStateResponseDto GetAll()
        {
            var judgmentStateToSearch = _lawyerJudgmentStateService.GetLawyerJudgmentStateTypes();
            return judgmentStateToSearch;
        }
    }
}
