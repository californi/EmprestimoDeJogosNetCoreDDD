using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Jogador;

namespace Api.Domain.Interfaces.Services.Jogador
{
    public interface IJogadorService
    {
        Task<JogadorDto> Get(Guid id);
        Task<IEnumerable<JogadorDto>> GetAll();
        Task<JogadorDtoCreateResult> Post(JogadorDtoCreate jogador);
        Task<JogadorDtoUpdateResult> Put(JogadorDtoUpdate jogador);
        Task<bool> Delete(Guid id);
    }
}
