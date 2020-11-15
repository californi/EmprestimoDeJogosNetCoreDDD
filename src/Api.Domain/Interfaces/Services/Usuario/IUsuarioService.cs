using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuario;
using Api.Domain.Entities;

namespace Api.Domain.Interfaces.Services.Usuario
{
    public interface IUsuarioService
    {
        Task<UsuarioDto> Get(Guid id);
        Task<IEnumerable<UsuarioDto>> GetAll();
        Task<UsuarioDtoCreateResult> Post(UsuarioDtoCreate usuario);
        Task<UsuarioDtoUpdateResult> Put(UsuarioDtoUpdate usuario);
        Task<bool> Delete(Guid id);
    }
}
