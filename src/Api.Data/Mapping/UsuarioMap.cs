using Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.Data.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<UsuarioEntity>
    {
        public void Configure(EntityTypeBuilder<UsuarioEntity> builder)
        {
            builder.ToTable("tabUsuario");

            builder.HasKey(p => p.Id);

            builder.HasIndex(p => p.Email)
                   .IsUnique();

            builder.Property(u => u.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(u => u.Email)
                .HasMaxLength(100);
        }
    }
}
