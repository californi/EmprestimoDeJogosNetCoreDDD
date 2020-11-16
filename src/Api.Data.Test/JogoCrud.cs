using System;
using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class JogoCrud : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvider;
        public JogoCrud(DbTeste dbTest)
        {
            _serviceProvider = dbTest.ServiceProvider;
        }

        [Fact(DisplayName = "Registro de Jogo")]
        [Trait("CRUD", "JogoEntity")]
        public async Task testRealizandoCrudJogo()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {

                //inserindo jogador 
                JogadorImplementation _repositorioJogador = new JogadorImplementation(context);
                JogadorEntity _entityJogador = new JogadorEntity
                {
                    Nome = "Bento",
                    Cidade = "São Carlos",
                };
                var _jogador = await _repositorioJogador.InsertAsync(_entityJogador);

                //INsert
                JogoImplementation _repositorio = new JogoImplementation(context);
                JogoEntity _entity = new JogoEntity
                {
                    Nome = "Mario Kart",
                    Descricao = "teste",
                    Tipo = "teste2",
                    JogadorId = _jogador.Id

                };
                var _registroCriado = await _repositorio.InsertAsync(_entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal(_entity.Nome, _registroCriado.Nome);


                //Update
                _entity.Nome = Faker.Name.First();
                var _registroAtualizado = await _repositorio.UpdateAsync(_entity);
                Assert.NotNull(_registroAtualizado);
                Assert.Equal(_entity.Nome, _registroAtualizado.Nome);

                //Selecao
                var _registroSelecao = await _repositorio.SelectAsync(_registroAtualizado.Id);
                Assert.NotNull(_registroSelecao);

                //Delete
                var _registroRemovido = await _repositorio.DeleteAsync(_registroAtualizado.Id);
                Assert.True(_registroRemovido);
            }
        }


    }
}
