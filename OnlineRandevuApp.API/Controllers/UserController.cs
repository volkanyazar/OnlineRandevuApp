using Microsoft.AspNetCore.Mvc;
using OnlineRandevuApp.API.Business.Interfaces;
using OnlineRandevuApp.API.Core.Concrete;
using OnlineRandevuApp.API.Core.Utilities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OnlineRandevuApp.API.Controllers
{
    [Route("api/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            this._userService = userService;
        }

        [HttpGet("getall")]
        public async Task<BaseResponse<List<User>>> GetAll()
        {
            return await this._userService.GetAll();
        }
    }
}