using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mikro.API.Abstraction;
using Mikro.API.Entities;
using Mikro.API.ViewModels; 
using System.Threading.Tasks;

namespace Mikro.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRequestService _requestService;
        private readonly ILogger<UserController> _logger;
        
        public UserController(IRequestService requestService, ILogger<UserController> logger)
        {
            _requestService = requestService;
            _logger = logger;
        }
        [HttpGet("get")]
        public async Task<IActionResult> Get()
        {
            string url = "https://dummyapi.io/data/v1/user?limit=10";
            var data = await _requestService.GetAsync<UserViewModel>(url);
            _logger.LogInformation("UserList method end.");
            return Ok(data);
        }
    }
}
