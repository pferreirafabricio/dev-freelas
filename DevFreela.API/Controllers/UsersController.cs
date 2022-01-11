using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevFreela.Application.InputModels;
using DevFreela.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DevFreela.API.Controllers
{
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userSerivice;

        public UsersController(IUserService userService)
        {
            _userSerivice = userService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var user = _userSerivice.GetUser(id);

            if (user == null) 
                return NotFound();

            return Ok(user);
        }

        // [HttpPost]
        // public IActionResult Post([FromBody] object teste)
        // {
        //     return CreatedAtAction(nameof(GetById), new { id = 1 }, teste);
        // }

        [HttpPost]
        public IActionResult Create([FromBody] CreateUserInputModel inputModel)
        {
            var id = _userSerivice.Create(inputModel);

            return CreatedAtAction(nameof(GetById), new { id = id }, inputModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] object teste)
        {
            return NoContent();
        }
    }
}
