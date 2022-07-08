
using Gerenciamento.Matricula.API.Domain.Entities;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Application.Interfaces.Services
{
    public interface IAlunoAppService : IAppServiceBase<Aluno>
    {
        Task CreateRandomAsync();
    }
}