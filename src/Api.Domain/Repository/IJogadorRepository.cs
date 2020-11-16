using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;

namespace Api.Domain.Repository
{
    public interface IJogadorRepository : IRepository<JogadorEntity>
    {
        Task<IEnumerable<JogoEntity>> BuscarJogosPorJogador(Guid jogadorId);

        Task<IEnumerable<EmprestimoJogoEntity>> BuscarEmprestimosPorJogador(Guid jogadorId);
    }
}
