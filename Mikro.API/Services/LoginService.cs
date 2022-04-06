using Mikro.API.Abstraction;
using Mikro.API.Entities;
using Mikro.API.Models.Login;
using Mikro.API.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mikro.API.Services
{
    public class LoginService : ILoginService
    { 
        public LoginViewModel Login(LoginRequest loginRequest)
        {
            var user = GetUsers().FirstOrDefault(x => x.Email == loginRequest.Email && x.Password == loginRequest.Password);
            if (user != null)
            {
                return new LoginViewModel {  Id = user.Id, Email = user.Email };
            }
            return new LoginViewModel { };
        }

        public List<User> GetUsers() 
            => new() {
                new() { Id = 1, Email = "sonercafer@mikrogroup.com", Password = "123" },
                new() { Id = 2, Email = "eminkurtuldu@mikrogroup.com", Password = "123" },
                new() { Id = 3, Email = "info@mikrogroup.com", Password = "123" } 
            };
    }
}
