using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Mikro.API.Abstraction;
using Mikro.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IRequestService _requestService;
        public PostController(IRequestService requestService)
        {
            _requestService = requestService;
        }
        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            string url = "https://dummyapi.io/data/v1/post?limit=10";
            var data = await _requestService.GetAsync<PostViewModel>(url);
            return Ok(data);
        }
    }
}
