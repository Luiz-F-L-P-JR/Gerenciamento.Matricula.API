using Gerenciamento.Matricula.API.Domain.Entities;
using Gerenciamento.Matricula.API.Domain.Interfaces.HttpClient;
using Gerenciamento.Matricula.API.Domain.Interfaces.Repositories;
using Gerenciamento.Matricula.API.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Domain.Services
{
    public class AlunoService : ServiceBase<Aluno>, IAlunoService
    {
        private readonly IHttpClient _httpCliente;

        public AlunoService(IAlunoRepository alunoRepository, IHttpClient httpCliente)
            : base(alunoRepository)
        {
            _httpCliente = httpCliente;
        }


        public async Task<IList<Aluno>> GetNamesRandomAsync()
        {
            var uri = $"https://gerador-nomes.herokuapp.com/nomes/5";

            var response = await _httpCliente.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<string[]>(await response.Content.ReadAsStringAsync());

                var alunos = new List<Aluno>();

                for (int i = 0; i < result.Length; i++)
                {
                    alunos.Add(new Aluno() { NomeCompleto = result[i], DataDaMatricula = DateTime.Now });
                }

                return alunos;
            }

            return null;
        }
    }
}
