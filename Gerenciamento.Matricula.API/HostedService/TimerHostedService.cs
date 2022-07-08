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
        private readonly ITimerAppService _timerAppService;

        public TimerHostedService(IAlunoAppService alunoAppService, ITimerAppService timerAppService)
        {
            _alunoAppService = alunoAppService;
            _timerAppService = timerAppService;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {

            Task.Run(async() =>
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    //Lógica para informar o tempo que o sistema gere novas matrículas.
                    //Onde a variável "time" armazena o tempo e passa por uma validação para saber se há de fato algum tempo informado para gerar novas matrículas.
                    //Ela recebe a informação do banco caso exista, e repassa para informar de que tempo em tempo as novas matríclas serão inseridas.

                    var time = await _timerAppService.GetTimerAsync().ConfigureAwait(false);
                    if (time == 0) time = 30;

                    await _alunoAppService.CreateRandomAsync();
                    await Task.Delay(new TimeSpan(0, 0, time));
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
