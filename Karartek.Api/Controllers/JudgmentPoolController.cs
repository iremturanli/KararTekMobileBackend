using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Karartek.Business.Abstract;
using Karartek.Business.Concrete;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class JudgmentPoolController : ControllerBase
    {

        private IJudgmentPoolService _judgmentPoolService;

        public JudgmentPoolController(IJudgmentPoolService judgmentPoolService)
        {
            _judgmentPoolService = judgmentPoolService;
        }



        [HttpPost("judgmentPool")]
        public ActionResult AddJudgment(JudgmentPoolDto judgmentPoolDto, int id)
        {
            string userId =User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            judgmentPoolDto.UserId = Int32.Parse(userId);

            var judgmentToAdd = _judgmentPoolService.AddtoJudgmentPool(judgmentPoolDto, id);

            return Ok(judgmentToAdd);
        }


        [HttpGet("DeleteDecree/{{id}}")]
        public bool DeleteDecree(int id)
        {
            _judgmentPoolService.DeleteFromJudgmentPool(id);
            return true;

        }


        [HttpPost("GetAll")]
        public List<Judgment> GetAll(JudgmentPoolDto judgmentPoolDto)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            judgmentPoolDto.UserId = Int32.Parse(userId);

        
            var FavouriteJudgments=_judgmentPoolService.GetAll(judgmentPoolDto);
            return FavouriteJudgments;
           




        }




    }


}