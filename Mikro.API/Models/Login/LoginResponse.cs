using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Models.Login
{
    public class LoginResponse
    {
        public bool isSuccess { get; set; }
        public string Token { get; set; }
        public string RefreshToken { get; set; }
    }
}
