using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Jogador;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class JogadorService : IJogadorService
    {
        private IJogadorRepository _repository;

        private readonly IMapper _mapper;

        public JogadorService(IJogadorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<JogadorDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<JogadorDto>(entity);
        }

        public async Task<IEnumerable<JogadorDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<JogadorDto>>(listEntity);
        }

        public async Task<JogadorDtoCreateResult> Post(JogadorDtoCreate jogador)
        {
            // Regras de negocios
            var model = _mapper.Map<JogadorModel>(jogador);
            var entity = _mapper.Map<JogadorEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<JogadorDtoCreateResult>(result);
        }

        public async Task<JogadorDtoUpdateResult> Put(JogadorDtoUpdate jogador)
        {
            // Regras de negocios
            var model = _mapper.Map<JogadorModel>(jogador);
            var entity = _mapper.Map<JogadorEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<JogadorDtoUpdateResult>(result);
        }
    }
}
