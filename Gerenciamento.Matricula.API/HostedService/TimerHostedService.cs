using Gerenciamento.Matricula.API.Application.Interfaces.Services;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.HostedService
{
    public class TimerHostedService : IHostedService
    {
        private readonly IAlunoAppService _alunoAppService;

        public TimerHostedService(IAlunoAppService alunoAppService)
        {
            _alunoAppService = alunoAppService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {

            Task.Run(async() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    await _alunoAppService.CreateRandomAsync();
                    await Task.Delay(new TimeSpan(0, 0, 120));
                }
            });

            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
