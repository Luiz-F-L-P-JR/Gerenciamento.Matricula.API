using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using Gerenciamento.Matricula.API.Domain.Interfaces.HttpClient;

namespace Gerenciamento.Matricula.API.Data.HttpClient
{
    public class HttpClient : IHttpClient
    {
        private readonly System.Net.Http.HttpClient _httpClient;

        public HttpClient()
        {
            _httpClient = new System.Net.Http.HttpClient();
        }

        public async Task<HttpResponseMessage> GetAsync(string uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Get, uri);

            var response = await _httpClient.SendAsync(httpRequestMessage);

            return response;
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string uri, T item)
        {
            return await DoRequestAsync(HttpMethod.Post, uri, item);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string uri, T item)
        {
            return await DoRequestAsync(HttpMethod.Put, uri, item);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string uri)
        {
            var httpRequestMessage = new HttpRequestMessage(HttpMethod.Delete, uri);
            var response = await _httpClient.SendAsync(httpRequestMessage);

            return response;
        }

        private async Task<HttpResponseMessage> DoRequestAsync<T>(HttpMethod httpMethod, string uri, T item)
        {
            var httpRequestMessage = new HttpRequestMessage(httpMethod, uri)
            {
                Content = new StringContent(JsonConvert.SerializeObject(item), Encoding.UTF8, "application/json")
            };

            var response = await _httpClient.SendAsync(httpRequestMessage);

            return response;
        }
    }
}
