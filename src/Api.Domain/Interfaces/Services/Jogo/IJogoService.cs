using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Jogo;

namespace Api.Domain.Interfaces.Services.Jogo
{
    public interface IJogoService
    {
        Task<JogoDto> Get(Guid id);
        Task<IEnumerable<JogoDto>> GetAll();
        Task<JogoDtoCreateResult> Post(JogoDtoCreate jogo);
        Task<JogoDtoUpdateResult> Put(JogoDtoUpdate jogo);
        Task<bool> Delete(Guid id);
    }
}
