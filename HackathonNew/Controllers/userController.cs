using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using HackathonNew.Interface;
using HackathonNew.Model;
using Microsoft.AspNetCore.Authorization;


namespace HackathonNew.Controllers
{
    [Authorize]
    [Route("api/controller")]
    [ApiController]
    [Produces ("application/json")]
    public class userController : Controller
    {
        public IConfiguration Configuration { get; }
        private IUserService _userService;
        public userController(IUserService _user)
        {
            _userService = _user;
        }
        // GET api/Users
        [HttpGet]
        public async Task<List<User>> Get()
        {
            return await _userService.GetAll();
        }

        // GET api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> Get(int id)
        {
            var response = await _userService.GetById(id);
            if (response == null) { return NotFound(); }
            return response;
        }

        // POST api/Users
        [HttpPost]
        public async Task Post([FromBody] User User)
        {
            await _userService.Insert(User);
        }

        // DELETE api/Users/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _userService.DeleteById(id);
        }


    }
}
