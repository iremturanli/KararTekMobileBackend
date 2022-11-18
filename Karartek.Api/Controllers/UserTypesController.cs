using Karartek.Business.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserTypesController : ControllerBase
    {
        private IUserTypeService _userTypeService;

        public UserTypesController(IUserTypeService userTypeService)
        {
            _userTypeService = userTypeService;
        }

        [HttpGet("GetAll")]
        public UserTypeResponseDto GetAll()
        {
            var userTypeToSearch = _userTypeService.GetUserTypes();
            return userTypeToSearch;
        }

        [HttpGet("GetById/{{id}}")]
        public UserType GetById(int id)
        {
            var userTypeToSearch = _userTypeService.GetUserTypeById(id);
            return userTypeToSearch;
        }

        [HttpPost("Add")]
        public ActionResult Add(UserTypeDto userType)
        {
            var userTypeToAdd = _userTypeService.AddUserType(userType);
            if (userTypeToAdd)
            {
                return Ok(userTypeToAdd);

            }
            else
            { return BadRequest("Adding Failed"); }

        }

        [HttpPost("Update")]
        public ActionResult Update(UserType userType)
        {
            var userTypeToUpdate = _userTypeService.UpdateUserType(userType);
            if (userTypeToUpdate)
            {
                return Ok(userTypeToUpdate);

            }
            else
            { return BadRequest("Updating Failed"); }

        }

        [HttpPost("Delete")]
        public ActionResult Delete(UserType userType)
        {
            var userTypeToDelete = _userTypeService.DeleteUserType(userType);
            if (userTypeToDelete)
            {
                return Ok(userTypeToDelete);

            }
            else
            { return BadRequest("Deleting Failed"); }

        }
    }
}
