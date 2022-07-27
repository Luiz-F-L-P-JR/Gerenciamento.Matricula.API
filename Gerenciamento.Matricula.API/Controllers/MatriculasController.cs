using Gerenciamento.Matricula.API.Application.Interfaces.Services;
using Gerenciamento.Matricula.API.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Gerenciamento.Matricula.API.Controllers
{
    [Route("api/")]
    [ApiController]
    public class MatriculasController : ControllerBase
    {
        private readonly IAlunoAppService _alunoAppService;

        public MatriculasController(IAlunoAppService alunoAppService)
        {
            _alunoAppService = alunoAppService;
        }

        /// <summary>Mostra uma lista dos alunos matriculados.</summary>
        /// <response code="200">Sucesso</response>   
        /// <response code="500">Erro interno</response>
        /// <returns> Retorna todos os alunos matriculados.</returns>
        [HttpGet]
        [Route("Matriculas")]
        [ProducesResponseType(typeof(Aluno), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _alunoAppService.GetAllAsync();
            return Ok(result);
        }

        /// <summary>Mostra um aluno matriculado.</summary>
        /// <param name="name"></param>
        /// <response code="200">Sucesso</response> 
        /// <response code="500">Erro interno</response>
        /// /// <returns> Retorna todos os alunos matriculados.</returns>
        [HttpGet]
        [Route("Matricula")]
        [ProducesResponseType(typeof(Aluno), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAsync(string name)
        {
            var result = await _alunoAppService.GetAsync(name);
            return Ok(result);
        }

        /// <summary>Matricula/Cadastra um aluno.</summary>
        /// <param name="aluno"></param>
        /// <response code="200">Sucesso</response>
        /// <response code="500">Erro interno</response>
        [HttpPost]
        [Route("Matricula")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CreateAsync([FromBody] Aluno aluno)
        {
            await _alunoAppService.CreateAsync(aluno);
            return NoContent();
        }

        /// <summary>Atualiza as informações de um aluno.</summary>
        /// <param name="aluno"></param>
        /// <response code="200">Sucesso</response>
        /// <response code="500">Erro interno</response>
        [HttpPut]
        [Route("Matricula")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAsync([FromBody] Aluno aluno)
        {
            await _alunoAppService.UpdateAsync(aluno);
            return NoContent();
        }

        /// <summary>Exclui um aluno matriculado.</summary>
        /// <param name="id"></param>
        /// <response code="200">Sucesso</response>
        /// <response code="500">Erro interno</response>
        [HttpDelete]
        [Route("Matricula")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAsync(int id)
        {
            await _alunoAppService.DeleteAsync(id);
            return NoContent();
        }

        /// <summary>Exclui todos os alunos matriculados.</summary>
        /// <response code="200">Sucesso</response>
        /// <response code="500">Erro interno</response>
        [HttpDelete]
        [Route("Matriculas")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAllAsync()
        {
            await _alunoAppService.DeleteAllAsync();
            return NoContent();
        }
    }
}
