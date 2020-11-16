using System.Threading.Tasks;
using Api.Data.Context;
using Api.Data.Implementations;
using Api.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Api.Data.Test
{
    public class UsuarioCrud : BaseTest, IClassFixture<DbTeste>
    {
        private ServiceProvider _serviceProvider;

        public UsuarioCrud(DbTeste dbTeste)
        {
            _serviceProvider = dbTeste.ServiceProvider;
        }

        [Fact(DisplayName = "Registro de usuário")]
        [Trait("CRUD", "UsuarioEntity")]
        public async Task testRealizandoCrudUsuario()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {
                //Insert
                UsuarioImplementation _repositorio = new UsuarioImplementation(context);
                UsuarioEntity _entity = new UsuarioEntity
                {
                    Email = "bento@email.com",
                    Nome = "bento"
                };

                var _registroCriado = await _repositorio.InsertAsync(_entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal("bento@email.com", _registroCriado.Email);
                Assert.Equal("bento", _registroCriado.Nome);


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

        [Fact(DisplayName = "Registro de usuário Faker")]
        [Trait("CRUD2", "UsuarioEntity")]
        public async Task testRealizandoCrudUsuarioFaker()
        {
            using (var context = _serviceProvider.GetService<MyContext>())
            {
                UsuarioImplementation _repositorio = new UsuarioImplementation(context);
                UsuarioEntity _entity = new UsuarioEntity
                {
                    Email = Faker.Internet.Email(),
                    Nome = Faker.Name.FullName()
                };

                var _registroCriado = await _repositorio.InsertAsync(_entity);
                Assert.NotNull(_registroCriado);
                Assert.Equal(_entity.Email, _registroCriado.Email);
                Assert.Equal(_entity.Nome, _registroCriado.Nome);
            }
        }
    }
}
