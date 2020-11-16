using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.Jogo;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.Jogo;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class JogoService : IJogoService
    {
        private IJogoRepository _repository;

        private readonly IMapper _mapper;

        public JogoService(IJogoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<JogoDto> Get(Guid id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<JogoDto>(entity);
        }

        public async Task<IEnumerable<JogoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<JogoDto>>(listEntity);
        }

        public async Task<JogoDtoCreateResult> Post(JogoDtoCreate jogo)
        {
            // Regras de negocios
            var model = _mapper.Map<JogoModel>(jogo);
            var entity = _mapper.Map<JogoEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<JogoDtoCreateResult>(result);
        }

        public async Task<JogoDtoUpdateResult> Put(JogoDtoUpdate jogo)
        {
            // Regras de negocios
            var model = _mapper.Map<JogoModel>(jogo);
            var entity = _mapper.Map<JogoEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<JogoDtoUpdateResult>(result);
        }
    }
}
