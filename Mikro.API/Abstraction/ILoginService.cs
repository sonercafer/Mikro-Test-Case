using Mikro.API.Models.Login;
using Mikro.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Abstraction
{
    public interface ILoginService : IService
    {
        LoginViewModel Login(LoginRequest loginRequest);
    }
}
