using Gerenciamento.Matricula.API.Application.Interfaces.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System.Timers;

namespace Gerenciamento.Matricula.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimerController : ControllerBase
    {
        private readonly ITimerAppService _timerAppService;

        public TimerController(ITimerAppService timerAppService)
        {
            _timerAppService = timerAppService;
        }

        /// <summary>Consulta o tempo da inserção automática de novos alunos.</summary>
        /// <param name="time"></param>
        /// <response code="200">Sucesso</response>
        /// <response code="500">Erro interno</response>
        [HttpGet]
        [ProducesResponseType(typeof(Timer), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetTimerAsync()
        {
            return Ok(await _timerAppService.GetTimerAsync());
        }

        /// <summary>Atualiza o tempo de inserção de novos alunos.</summary>
        /// <param name="time"></param>
        /// <response code="204">Sucesso</response>
        /// <response code="500">Erro interno</response>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> UpdateAsync(int time)
        {
            await _timerAppService.UpdateTimerAsync(time);
            return NoContent();
        }
    }
}
