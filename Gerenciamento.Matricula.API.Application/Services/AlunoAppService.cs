
using Gerenciamento.Matricula.API.Application.Interfaces.Services;
using Gerenciamento.Matricula.API.Domain.Entities;
using Gerenciamento.Matricula.API.Domain.Interfaces.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Application.Services
{
    public class AlunoAppService : AppServiceBase<Aluno>, IAlunoAppService
    {
        private readonly IAlunoService _alunoService;

        public AlunoAppService(IAlunoService alunoService)
            : base(alunoService)
        {
            _alunoService = alunoService;
        }

        public async Task CreateRandomAsync()
        {            
            var alunos = await _alunoService.GetNamesRandomAsync();

            for (int i = 0; i < alunos.Count(); i++)
            {
                await _alunoService.CreateAsync(alunos[i]);
            }
        }
    }
}
