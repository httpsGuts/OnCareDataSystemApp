using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnCareDataSystemApp.Domain;
using OnCareDataSystemApp.Domain.Entities;

namespace OnCareDataSystemApp.Data.Configurations
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> entity)
        {
            entity.HasKey(e => e.Id); // Chave primária
            entity.Property(e => e.Nome).IsRequired().HasMaxLength(50); // Propriedade Nome é obrigatória e tem no máximo 50 caracteres
            entity.Property(e => e.Sobrenome).IsRequired().HasMaxLength(100); // Propriedade Nome é obrigatória e tem no máximo 100 caracteres
            entity.Property(e => e.Nascimento).IsRequired(); // Propriedade Nascimento é obrigatória
            entity.Property(e => e.Sexo).IsRequired().HasMaxLength(1); // Propriedade Sexo é obrigatória e tem no máximo 1 caractere
            entity.Property(e => e.Email).IsRequired().HasMaxLength(100); // Propriedade Email é obrigatória e tem no máximo 100 caracteres
            entity.Property(e => e.Senha).IsRequired(); // Propriedade Senha é obrigatória
            entity.Property(e => e.Padrão).IsRequired(); // Propriedade Padrão é obrigatória
            entity.Property(e => e.Moderador).IsRequired(); // Propriedade Moderador é Feita por um administrador
            entity.Property(e => e.Administrador).IsRequired(); // Propriedade Admin é Feita por um administrador
        }
    }
}
    