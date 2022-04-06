﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mikro.API.Abstraction;
using Mikro.API.Models.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILoginService _loginService;
        public LoginController(ILoginService loginService)
        {
            _loginService = loginService;
        }
        [HttpPost("login")]
        public IActionResult Login([FromBody] LoginRequest request)
        {
            var loginResponse = _loginService.Login(request);
            if (loginResponse.Id != 0)
            {
                return Ok(loginResponse);
            }
            return NoContent();
        }
    }
}
