using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.EmprestimoJogo;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Dtos.Jogo;

namespace Api.Domain.Interfaces.Services.EmprestimoJogo
{
    public interface IEmprestimoJogoService
    {
        Task<IEnumerable<EmprestimoJogoDto>> GetAll();
        Task<EmprestimoJogoDto> BuscarPorJogo(JogoDto jogo);
        Task<EmprestimoJogoDto> BuscarPorJogador(JogadorDto jogador);
        Task<EmprestimoJogoDtoCreateResult> Post(EmprestimoJogoDtoCreate emprestimoJogo);
        Task<EmprestimoJogoDtoUpdateResult> Put(EmprestimoJogoDtoUpdate emprestimoJogo);
        Task<bool> Delete(Guid id);
    }
}
