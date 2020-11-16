using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Interfaces.Services.Jogador;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        public IJogadorService _service { get; set; }

        public JogadorController(IJogadorService service)
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

        [HttpGet]
        [Route("{id}", Name = "GetJogadorWithId")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException ex)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [Authorize("Bearer")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] JogadorDtoCreate jogador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                var result = await _service.Post(jogador);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetJogadorWithId", new { id = result.Id })), result);
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
        public async Task<ActionResult> Put([FromBody] JogadorDtoUpdate jogador)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                var result = await _service.Put(jogador);
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
