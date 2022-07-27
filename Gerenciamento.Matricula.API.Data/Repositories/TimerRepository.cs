using Gerenciamento.Matricula.API.Domain.Entities;
using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;

namespace Gerenciamento.Matricula.API.Data.Repositories
{
    public class TimerRepository : RepositoryBase<Timer>, ITimerRepository
    {
        private readonly IConfiguration _configuration;

        public TimerRepository(IConfiguration configuration)
            : base(configuration)
        {
            _configuration = configuration;
        }
    }
}
