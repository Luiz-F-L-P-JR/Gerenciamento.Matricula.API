using Gerenciamento.Matricula.API.Domain.Entities;
using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;
using Gerenciamento.Matricula.API.Domain.Interfaces.Services;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Domain.Services
{
    public class TimerService : ServiceBase<Timer>, ITimerService
    {
        private readonly ITimerRepository _timerRepository;

        public TimerService(ITimerRepository timerRepository)
            : base(timerRepository)
        {
            _timerRepository = timerRepository;
        }

        public new async Task UpdateTimerAsync(int time)
        {
            var repositoryTime = await _timerRepository.GetTimerAsync();

            if(repositoryTime == 0)
            {
                await _timerRepository.CreateTimerAsync(time);
            }else{
                await _timerRepository.UpdateTimerAsync(time);
            }
        }
    }
}
