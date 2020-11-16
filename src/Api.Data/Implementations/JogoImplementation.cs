using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class JogoImplementation : BaseRepository<JogoEntity>, IJogoRepository
    {
        private DbSet<JogoEntity> _dataset;

        public JogoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<JogoEntity>();
        }
    }
}
