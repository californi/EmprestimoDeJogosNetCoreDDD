using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Repository;
using Api.Domain.Entities;
using Api.Domain.Repository;
using Microsoft.EntityFrameworkCore;

namespace Api.Data.Implementations
{
    public class EmprestimoJogoImplementation : BaseRepository<EmprestimoJogoEntity>, IEmprestimoJogoRepository
    {
        private DbSet<EmprestimoJogoEntity> _dataset;

        public EmprestimoJogoImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<EmprestimoJogoEntity>();
        }
    }
}
