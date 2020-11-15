using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioEntity> Get(Guid id);
        Task<IEnumerable<UsuarioEntity>> GetAll();
        Task<UsuarioEntity> Post(UsuarioEntity usuario);
        Task<UsuarioEntity> Put(UsuarioEntity usuario);
        Task<bool> Delete(Guid id);
    }
}
