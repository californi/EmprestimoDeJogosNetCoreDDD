using System;
using System.Net;
using System.Threading.Tasks;
using Api.Domain.Dtos.Jogo;
using Api.Domain.Interfaces.Services.Jogo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogosController : ControllerBase
    {
        public IJogoService _service { get; set; }

        public JogosController(IJogoService service)
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
        [Route("{id}", Name = "GetJogoWithId")]
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
        public async Task<ActionResult> Post([FromBody] JogoDtoCreate jogo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                var result = await _service.Post(jogo);
                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetJogoWithId", new { id = result.Id })), result);
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
        public async Task<ActionResult> Put([FromBody] JogoDtoUpdate jogo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState); // 400 bad request - requisicao invalida
            }
            try
            {
                var result = await _service.Put(jogo);
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
