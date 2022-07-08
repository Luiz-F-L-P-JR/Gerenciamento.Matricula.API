using System.Net.Http;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Domain.Interfaces.HttpClient
{
    public interface IHttpClient
    {
        Task<HttpResponseMessage> GetAsync(string uri);

        Task<HttpResponseMessage> PostAsync<T>(string uri, T item);

        Task<HttpResponseMessage> PutAsync<T>(string uri, T item);

        Task<HttpResponseMessage> DeleteAsync(string uri);
    }
}
