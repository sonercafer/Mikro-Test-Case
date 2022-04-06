using Microsoft.AspNetCore.Mvc;
using Mikro.API.Abstraction;
using Mikro.API.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Mikro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRequestService _requestService;
        public UserController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            string url = "https://dummyapi.io/data/v1/user?limit=10";
            var data = await _requestService.GetAsync<UserViewModel>(url);
            return Ok(data);
        }
    }
}
