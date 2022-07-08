
using Gerenciamento.Matricula.API.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Domain.Interfaces.Services
{
    public interface IAlunoService : IServiceBase<Aluno>
    {
        Task<IList<Aluno>> GetNamesRandomAsync();
    }
}
