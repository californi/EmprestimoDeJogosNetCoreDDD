using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.EmprestimoJogo;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Dtos.Jogo;

namespace Api.Domain.Interfaces.Services.EmprestimoJogo
{
    public interface IEmprestimoJogo
    {
        Task<IEnumerable<EmprestimoJogoDto>> GetAll();
        Task<EmprestimoJogoDto> BuscarPorJogo(JogoDto jogo);
        Task<EmprestimoJogoDto> BuscarPorJogador(JogadorDto jogador);
        Task<EmprestimoJogoDtoCreateResult> Post(EmprestimoJogoDtoCreate jogador);
        Task<EmprestimoJogoDtoUpdateResult> Put(EmprestimoJogoDtoUpdate jogador);
        Task<bool> Delete(Guid id);
    }
}
