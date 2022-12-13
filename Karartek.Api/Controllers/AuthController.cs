using Karartek.Business.Abstract;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class AuthController : ControllerBase
    {
        private IUserService _userService;

        public AuthController(IUserService userService)
        {
            _userService = userService;
        }



        [HttpPost("Register")]
        public ActionResult Register(UserForRegister userForRegister)
        {
            var userToRegister = _userService.Register(userForRegister);
            if (userToRegister != null)
            {
                return Ok(userToRegister);

            }
            else
            return BadRequest("Registeration Failed");
        }
        [HttpPost("login")]
        public ActionResult Login(UserForLogin userForLogin)
        {
            var userToLogin = _userService.Login(userForLogin);
            if (userToLogin == null)
            {
                return BadRequest("Login Failed");
            }

            return Ok(userToLogin);
        }

        [HttpPost("forgotMyPassword")]
        public ActionResult ForgotMyPassword(ForgotMyPasswordDto forgotMyPasswordDto)
        {
            var userToLogin = _userService.ForgotMyPassword(forgotMyPasswordDto);
            if (userToLogin == null)
            {
                return BadRequest("Login Failed");
            }

            return Ok(userToLogin);
        }
    }
}
