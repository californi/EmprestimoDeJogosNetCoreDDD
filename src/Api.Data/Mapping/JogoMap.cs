using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class JogoMap : IEntityTypeConfiguration<JogoEntity>
    {
        public void Configure(EntityTypeBuilder<JogoEntity> builder)
        {
            builder.ToTable("tabJogo");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.Descricao);

            builder.Property(u => u.Tipo);

            //chave estrangeira
            builder.HasOne(u => u.JogadorDono)
                   .WithMany(m => m.Jogos);
        }
    }
}
