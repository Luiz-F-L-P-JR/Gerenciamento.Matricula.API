using Gerenciamento.Matricula.API.Domain.Entities;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Domain.Interfaces.Services
{
    public interface ITimerService : IServiceBase<Timer>
    {
        new Task UpdateTimerAsync(int time);
    }
}
