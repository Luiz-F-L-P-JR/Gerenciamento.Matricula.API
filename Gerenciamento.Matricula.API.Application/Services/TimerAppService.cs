using Gerenciamento.Matricula.API.Application.Interfaces.Services;
using Gerenciamento.Matricula.API.Domain.Entities;
using Gerenciamento.Matricula.API.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Application.Services
{
    public class TimerAppService : AppServiceBase<Timer>, ITimerAppService
    {
        private readonly ITimerService _timerService;

        public TimerAppService(ITimerService timerService)
            : base(timerService)
        {
            _timerService = timerService;
        }

        public new async Task UpdateTimerAsync(int time)
        {
            await _timerService.UpdateTimerAsync(time);
        }
    }
}
