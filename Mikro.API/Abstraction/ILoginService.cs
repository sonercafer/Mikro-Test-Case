using Mikro.API.Models.Login;
using Mikro.API.ViewModels; 

namespace Mikro.API.Abstraction
{
    public interface ILoginService : IService
    {
        LoginViewModel Login(LoginRequest loginRequest);
    }
}
