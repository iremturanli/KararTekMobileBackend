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
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("GetUserInformation")]
        [Authorize]
        public ActionResult GetUser()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var identity = Int32.Parse(userId);
            var user = _userService.GetUser(identity);

            if (user == null)
            {
                return BadRequest("Kullanıcı bilgileri bulunamadı");
            }

            return Ok(user);

        }
        [HttpPost("ChangePassword")]
        public ActionResult ChangedPassword(ChangePasswordDto changePasswordDto)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var id = Int32.Parse(userId);
            var user = _userService.ChangePassword(changePasswordDto, id);

            if (user == null)
            {
                return BadRequest("Kullanıcı bilgileri bulunamadı");
            }

            return Ok(user);

        }

        [HttpGet("GetUser")]
        [Authorize]
        public ActionResult GetUserId()
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var id = Int32.Parse(userId);
            var user = _userService.GetUser(id);

            if (user == null)
            {
                return BadRequest("Kullanıcı bilgileri bulunamadı");
            }

            return Ok(user);

        }

    }
}
