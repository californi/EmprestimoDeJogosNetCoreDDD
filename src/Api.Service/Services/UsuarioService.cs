using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Usuario;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IRepository<UsuarioEntity> _repository;
        public UsuarioService(IRepository<UsuarioEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UsuarioEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id);
        }

        public async Task<IEnumerable<UsuarioEntity>> GetAll()
        {
            return await _repository.SelectAsync();
        }

        public async Task<UsuarioEntity> Post(UsuarioEntity usuario)
        {
            // Regras de negocios

            return await _repository.InsertAsync(usuario);
        }

        public async Task<UsuarioEntity> Put(UsuarioEntity usuario)
        {
            return await _repository.UpdateAsync(usuario);
        }
    }
}
