using Gerenciamento.Matricula.API.Application.Interfaces.Services;
using Gerenciamento.Matricula.API.Application.Services;
using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;
using Gerenciamento.Matricula.API.Data.Repositories;
using Gerenciamento.Matricula.API.Domain.Interfaces.Services;
using Gerenciamento.Matricula.API.Data.HttpClient;
using Gerenciamento.Matricula.API.Domain.Services;
using Microsoft.Extensions.DependencyInjection;
using Gerenciamento.Matricula.API.Domain.Interfaces.HttpClient;

namespace Gerenciamento.Matricula.API.CrossCutting.IOC
{
    public static class IOC
    {
        public static void AddDependencyInjection(this IServiceCollection services)
        {
            services.AddTransient<IHttpClient, HttpClient>();
            services.AddTransient<IAlunoService, AlunoService>();
            services.AddTransient<IAlunoAppService, AlunoAppService>();
            services.AddTransient<IAlunoRepository, AlunoRepository>();

            services.AddTransient<ITimerService, TimerService>();
            services.AddTransient<ITimerAppService, TimerAppService>();
            services.AddTransient<ITimerRepository, TimerRepository>();
        }
    }
}
