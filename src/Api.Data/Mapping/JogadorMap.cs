using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class JogadorMap : IEntityTypeConfiguration<JogadorEntity>
    {
        public void Configure(EntityTypeBuilder<JogadorEntity> builder)
        {
            builder.ToTable("tabJogador");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(20);

            builder.Property(u => u.Cidade);

            //chave estrangeira
            builder.HasMany(u => u.Jogos)
                   .WithOne(m => m.JogadorDono);
        }
    }
}
