using System;
using System.Collections.Generic;
using System.Linq; 
using System.Threading.Tasks;

namespace Mikro.API.Abstraction
{
    public interface IRequestService : IService
    {
        Task<TResult> GetAsync<TResult>(string url);
    }
}
