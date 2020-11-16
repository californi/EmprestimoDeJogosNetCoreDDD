using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Dtos.EmprestimoJogo;
using Api.Domain.Dtos.Jogador;
using Api.Domain.Dtos.Jogo;
using Api.Domain.Entities;
using Api.Domain.Interfaces.Services.EmprestimoJogo;
using Api.Domain.Models;
using Api.Domain.Repository;
using AutoMapper;

namespace Api.Service.Services
{
    public class EmprestimoJogoService : IEmprestimoJogoService
    {

        private IEmprestimoJogoRepository _repository;

        private readonly IMapper _mapper;

        public EmprestimoJogoService(IEmprestimoJogoRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<IEnumerable<EmprestimoJogoDto>> GetAll()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<EmprestimoJogoDto>>(listEntity);
        }

        public async Task<EmprestimoJogoDtoCreateResult> Post(EmprestimoJogoDtoCreate emprestimoJogo)
        {
            // Regras de negocios
            var model = _mapper.Map<EmprestimoJogoModel>(emprestimoJogo);
            var entity = _mapper.Map<EmprestimoJogoEntity>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<EmprestimoJogoDtoCreateResult>(result);
        }

        public async Task<EmprestimoJogoDtoUpdateResult> Put(EmprestimoJogoDtoUpdate emprestimoJogo)
        {
            // Regras de negocios
            var model = _mapper.Map<EmprestimoJogoModel>(emprestimoJogo);
            var entity = _mapper.Map<EmprestimoJogoEntity>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<EmprestimoJogoDtoUpdateResult>(result);
        }



        public Task<EmprestimoJogoDto> BuscarPorJogador(JogadorDto jogador)
        {
            throw new NotImplementedException();
        }

        public Task<EmprestimoJogoDto> BuscarPorJogo(JogoDto jogo)
        {
            throw new NotImplementedException();
        }

    }
}
