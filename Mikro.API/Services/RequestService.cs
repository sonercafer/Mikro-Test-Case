using Microsoft.Extensions.Configuration;
using Mikro.API.Abstraction; 
using Newtonsoft.Json; 
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Mikro.API.Services
{
    public class RequestService : IRequestService
    {
        private readonly IConfiguration _configuration;
        public RequestService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<TResult> GetAsync<TResult>(string url)
        {
            using (var client = new HttpClient())
            { 
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("app-id", _configuration.GetSection("app-id").Value);
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var resp = await response.Content.ReadAsStringAsync();
                    var data = JsonConvert.DeserializeObject<TResult>(resp);
                    return data;
                }
                else
                {
                    return default;
                }
            }
        }
    }
}
