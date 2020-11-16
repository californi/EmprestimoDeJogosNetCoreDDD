using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class JogadorCrud : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvider;
        public JogadorCrud(DbTeste dbTest)
        {
            _serviceProvider = dbTest.ServiceProvider;
        }

        [Fact(DisplayName = "Registro de Jogador")]
        [Trait("CRUD", "JogadorEntity")]
        public async Task testRealizandoCrudJogador()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {

                //INsert
                JogadorImplementation _repositorio = new JogadorImplementation(context);
                JogadorEntity _entity = new JogadorEntity
                {
                    Nome = "Bento",
                    Cidade = "São Carlos",
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
