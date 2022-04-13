using System.Threading.Tasks;

namespace Mikro.API.Abstraction
{
    public interface IRequestService : IService
    {
        Task<TResult> GetAsync<TResult>(string url);
    }
}
