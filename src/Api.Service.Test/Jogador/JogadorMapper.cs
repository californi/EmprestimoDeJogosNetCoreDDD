using System;
using Api.Domain.Entities;
using Api.Domain.Models;
using Xunit;

namespace Api.Service.Test.Jogador
{
    public class JogadorMapper : BaseTestService
    {
        [Fact(DisplayName = "Possivel fazer mapeamento")]
        public void PossivelMapearModelos()
        {
            var model = new JogadorModel
            {
                Id = Guid.NewGuid(),
                Nome = "Bento",
                Cidade = "São Paulo"
            };

            var entity = Mapper.Map<JogadorEntity>(model);
            Assert.NotNull(entity);
            Assert.Equal(entity.Nome, model.Nome);

        }
    }
}
