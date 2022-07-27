using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;
using Gerenciamento.Matricula.API.Domain.Entities;
using Microsoft.Extensions.Configuration;

namespace Gerenciamento.Matricula.API.Data.Repositories
{
    public class AlunoRepository : RepositoryBase<Aluno>, IAlunoRepository
    {
        private readonly IConfiguration _configuration;

        public AlunoRepository(IConfiguration configuration)
            :base(configuration)
        {
            _configuration = configuration;
        }
    }
}
