using Karartek.Business.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JudgmentTypesController : ControllerBase
    {
        private IJudgmentTypeService _judgmentTypeService;

        public JudgmentTypesController(IJudgmentTypeService judgmentTypeService)
        {
            _judgmentTypeService = judgmentTypeService;
        }

        [HttpGet("GetAll")]
        public JudgmentTypeResponseDto GetAll()
        {
            var judgmentTypeToSearch = _judgmentTypeService.GetJudgmentTypes();
            return judgmentTypeToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public JudgmentType GetById(int id)
        {
            var judgmentTypeToSearch = _judgmentTypeService.GetJudgmentTypeById(id);
            return judgmentTypeToSearch;
        }

        [HttpPost("Add")]
        public ActionResult Add(JudgmentTypeDto judgmentTypeDto)
        {
            var judgmentTypeToAdd = _judgmentTypeService.AddUserType(judgmentTypeDto);
            if (judgmentTypeToAdd)
            {
                return Ok(judgmentTypeToAdd);

            }
            else
            { return BadRequest("Adding Failed"); }

        }

        [HttpPost("Update")]
        public ActionResult Update(JudgmentType judgmentType)
        {
            var judgmentTypeToUpdate = _judgmentTypeService.UpdateJudgmentType(judgmentType);
            if (judgmentTypeToUpdate)
            {
                return Ok(judgmentTypeToUpdate);

            }
            else
            { return BadRequest("Updating Failed"); }

        }

        [HttpPost("Delete")]
        public ActionResult Delete(JudgmentType judgmentType)
        {
            var judgmentTypeToDelete = _judgmentTypeService.DeleteUserType(judgmentType);
            if (judgmentTypeToDelete)
            {
                return Ok(judgmentTypeToDelete);

            }
            else
            { return BadRequest("Deleting Failed"); }

        }
    }
}
