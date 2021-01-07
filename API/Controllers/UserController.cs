using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]/[action]/")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private UserService _userService;

        public UserController()
        {
            _userService = new UserService();
        }

        [HttpPost]
        public int Register([FromBody] Models.User value)
        {
            return _userService.Insert(value);
        }

        [HttpGet]
        public Models.User Details(int id)
        {
            return _userService.Get(id);
        }

        [HttpPost]
        public int CheckPassword(string pseudo, string pwd)
        {
            return _userService.CheckPassword(pseudo,pwd);
        }
    }
}
