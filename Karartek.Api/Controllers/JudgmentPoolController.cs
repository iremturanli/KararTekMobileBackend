using Karartek.Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;


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



        [HttpPost("AddJudgmentPool")]
        public ActionResult AddJudgment([FromQuery] int id, int searchTypeId)
        {
            string userID = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            int UserId = Int32.Parse(userID);

            var judgmentToAdd = _judgmentPoolService.AddtoJudgmentPool(UserId, id, searchTypeId);

            return Ok(judgmentToAdd);
        }


        [HttpGet("DeleteDecree/{{id}}")]
        public bool DeleteDecree(int id)
        {
            _judgmentPoolService.DeleteFromJudgmentPool(id);
            return true;

        }


        [HttpPost("GetAll")]
        public ActionResult GetAll()
        {

            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            int UserId = Int32.Parse(userId);


            var FavouriteJudgments = _judgmentPoolService.GetAll(UserId);
            if (FavouriteJudgments != null)
            {
                return Ok(FavouriteJudgments);

            }
            else
                return BadRequest("Hata!");



        }


    }


}