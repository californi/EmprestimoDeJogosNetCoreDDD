using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.EmprestimoJogo;
using Api.Domain.Interfaces.Services.EmprestimoJogo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmprestimoJogosController : ControllerBase
    {
        public IEmprestimoJogoService _service { get; set; }

        public EmprestimoJogosController(IEmprestimoJogoService service)
        {
            _service = service;
        }

        [Authorize("Bearer")]
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        /// <summary>
        /// Falta implementar nas camadas mais baixas
        /// </summary>
        /// <param name="idJogo"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{idJogo}", Name = "BuscarPorJogo")]
        public Task<ActionResult> BuscarPorJogo(Guid idJogo)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Falta implementar nas camadas mais baixas
        /// </summary>
        /// <param name="idJogador"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{idJogador}", Name = "BuscarPorJogador")]
        public Task<ActionResult> BuscarPorJogador(Guid idJogador)
        {
            throw new NotImplementedException();
        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] EmprestimoJogoDtoCreate emprestimo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                var result = await _service.Post(emprestimo);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(ModelState); // 400 bad request - requisicao invalida
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }

        }

        [Authorize("Bearer")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody] EmprestimoJogoDtoUpdate emprestimo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                var result = await _service.Put(emprestimo);
                if (result != null)
                {
                    return Ok(result);
                }
                else
                {
                    return BadRequest(ModelState); // 400 bad request - requisicao invalida
                }
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                return Ok(await _service.Delete(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
