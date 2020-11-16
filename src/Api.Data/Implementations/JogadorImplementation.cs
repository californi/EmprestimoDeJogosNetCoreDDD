using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class JogadorImplementation : BaseRepository<JogadorEntity>, IJogadorRepository
    {
        private DbSet<JogadorEntity> _dataset;

        public JogadorImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<JogadorEntity>();
        }

        public async Task<IEnumerable<EmprestimoJogoEntity>> BuscarEmprestimosPorJogador(Guid jogadorId)
        {
            return (IEnumerable<EmprestimoJogoEntity>)await _dataset.Include(j => j.Emprestimos)
                                .Where(k => k.Id.Equals(jogadorId))
                                .Select(l => l.Emprestimos)
                                .ToListAsync();
        }

        public async Task<IEnumerable<JogoEntity>> BuscarJogosPorJogador(Guid jogadorId)
        {
            return (IEnumerable<JogoEntity>)await _dataset.Include(j => j.Jogos)
                                .Where(k => k.Id.Equals(jogadorId))
                                .Select(l => l.Jogos)
                                .ToListAsync();
        }
    }
}
