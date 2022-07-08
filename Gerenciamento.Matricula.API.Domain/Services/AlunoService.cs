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
            // A variavel "quantidadeDeNomes" é uma variável criada para indicar a quantidade de nomes que serão obtidos através da requisição a API externa.

            var uri = $"https://gerador-nomes.herokuapp.com/nomes/5";
            var response = await _httpCliente.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                var result = JsonSerializer.Deserialize<string[]>(await response.Content.ReadAsStringAsync());

                var alunos = new List<Aluno>();

                var aluno = new Aluno() { NomeCompleto = result[0], DataDaMatricula = DateTime.Now };
                var aluno2 = new Aluno() { NomeCompleto = result[1], DataDaMatricula = DateTime.Now };
                var aluno3 = new Aluno() { NomeCompleto = result[2], DataDaMatricula = DateTime.Now };
                var aluno4 = new Aluno() { NomeCompleto = result[3], DataDaMatricula = DateTime.Now };
                var aluno5 = new Aluno() { NomeCompleto = result[4], DataDaMatricula = DateTime.Now };

                alunos.Add(aluno);
                alunos.Add(aluno2);
                alunos.Add(aluno3);
                alunos.Add(aluno4);
                alunos.Add(aluno5);

                return alunos;
            }

            return null;
        }
    }
}
