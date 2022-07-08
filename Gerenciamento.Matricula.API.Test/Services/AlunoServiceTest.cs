using Gerenciamento.Matricula.API.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using Xunit;

namespace Gerenciamento.Matricula.API.Test.Services
{
    public  class AlunoServiceTest
    {

        [Fact]
        public async Task TesteRetornoGetNamesRandomAsync()
        {
            var uri = $"https://gerador-nomes.herokuapp.com/nomes/5";

            var httpClient = new System.Net.Http.HttpClient();

            var response = await httpClient.GetAsync(uri);

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

                Assert.IsType<List<Aluno>>(alunos);
            }
        }
    }
}
