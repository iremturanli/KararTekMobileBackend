using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Karartek.Business.Abstract;
using Karartek.Entities.Concrete;
using Karartek.Entities.Dto;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Karartek.Api.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UserLikeController : ControllerBase
    {
        private IUserLikeService _userLikeService;

        public UserLikeController(IUserLikeService userLikeService)
        {
            _userLikeService = userLikeService;
        }

        [HttpPost("GetAll")]
        public IDataResult<List<UserLikeDto>> GetAll([FromQuery] int searchTypeId)
        {
            var userId = Int32.Parse(User.FindFirst(ClaimTypes.NameIdentifier)?.Value);
            var userTypeToLikes = _userLikeService.GetAll(userId, searchTypeId);
            return userTypeToLikes;




        }
    }
}

