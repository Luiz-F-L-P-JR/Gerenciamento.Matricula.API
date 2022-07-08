using Gerenciamento.Matricula.API.Domain.Entities;
using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;

namespace Gerenciamento.Matricula.API.Data.Repositories
{
    public class TimerRepository : RepositoryBase<Timer>, ITimerRepository
    {
        public TimerRepository()
        {

        }
    }
}
