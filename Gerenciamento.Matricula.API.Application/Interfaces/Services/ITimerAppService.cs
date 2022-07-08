using Gerenciamento.Matricula.API.Domain.Entities;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Application.Interfaces.Services
{
    public interface ITimerAppService : IAppServiceBase<Timer>
    {
        new Task UpdateTimerAsync(int time);
    }
}
