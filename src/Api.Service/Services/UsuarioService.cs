using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Usuario;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.Usuario;
using Api.Domain.Models;
using AutoMapper;

namespace Api.Service.Services
{
    public class UsuarioService : IUsuarioService
    {
        private IRepository<UsuarioEntity> _repository;
        private readonly IMapper _mapper;
        public UsuarioService(IRepository<UsuarioEntity> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<UsuarioDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<UsuarioDto>(entity) ?? new UsuarioDto();
        }

        public async Task<IEnumerable<UsuarioDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<UsuarioDto>>(listEntity);
        }

        public async Task<UsuarioDtoCreateResult> Post(UsuarioDtoCreate usuario)
        {
            // Regras de negocios
            var model = _mapper.Map<UsuarioModel>(usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<UsuarioDtoCreateResult>(result);
        }

        public async Task<UsuarioDtoUpdateResult> Put(UsuarioDtoUpdate usuario)
        {
            // Regras de negocios
            var model = _mapper.Map<UsuarioModel>(usuario);
            var entity = _mapper.Map<UsuarioEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<UsuarioDtoUpdateResult>(result);
        }
    }
}
