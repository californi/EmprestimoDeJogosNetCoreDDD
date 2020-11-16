using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class EmprestimoJogoMap : IEntityTypeConfiguration<EmprestimoJogoEntity>
    {
        public void Configure(EntityTypeBuilder<EmprestimoJogoEntity> builder)
        {
            builder.ToTable("tabEmprestimoJogo");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Devolvido);


            //chave estrangeira
            builder.HasOne(u => u.Jogador)
                   .WithMany(m => m.Emprestimos);

            builder.HasOne(u => u.Jogo)
                   .WithMany(m => m.Emprestimos);
        }
    }
}
