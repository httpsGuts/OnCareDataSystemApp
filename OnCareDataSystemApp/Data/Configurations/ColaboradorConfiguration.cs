using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnCareDataSystemApp.Domain;
using OnCareDataSystemApp.Domain.Entities;

namespace OnCareDataSystemApp.Data.Configurations;

public class ColaboradorConfiguration : IEntityTypeConfiguration<Colaborador>
{
    public void Configure(EntityTypeBuilder<Colaborador> entity)
    {
        entity.HasKey(e => e.Id);
        entity.Property(e => e.Nome).IsRequired().HasMaxLength(50);
        entity.Property(e => e.Sobrenome).HasMaxLength(100);
        entity.Property(e => e.Nascimento).IsRequired();
        entity.Property(e => e.Sexo).IsRequired().HasMaxLength(1);
        entity.Property(e => e.Contato1).IsRequired().HasMaxLength(15);
        entity.Property(e => e.Contato2).HasMaxLength(15);
        entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
        entity.Property(e => e.Senha).IsRequired().HasMaxLength(16);
        entity.Property(e => e.RG).IsRequired().HasMaxLength(20);
        entity.Property(e => e.FotoRG).IsRequired();
        entity.Property(e => e.CPF).IsRequired().HasMaxLength(20);
        entity.Property(e => e.FotoCPF).IsRequired();
        entity.Property(e => e.Expedicao).IsRequired();
        entity.Property(e => e.NomeDaMae).IsRequired().HasMaxLength(100);
        entity.Property(e => e.Profissao).IsRequired().HasMaxLength(100);
        entity.Property(e => e.Especialidade).IsRequired();
        entity.Property(e => e.Registro).IsRequired();
        entity.Property(e => e.VencimentoCarteira).IsRequired();
        entity.Property(e => e.FotoREG).IsRequired();
        entity.Property(e => e.Ceep).IsRequired();
        entity.Property(e => e.Uf).IsRequired();
        entity.Property(e => e.Estado).IsRequired().HasMaxLength(20);
        entity.Property(e => e.Bairro).IsRequired();
        entity.Property(e => e.Cidade).IsRequired();
        entity.Property(e => e.NumeroCasa).IsRequired();
        entity.Property(e => e.ComprovanteResidencia).IsRequired();
        entity.Property(e => e.DataCadastro).IsRequired();
        entity.Property(e => e.DataAlterado).IsRequired();
        entity.Property(e => e.VistoPorUltimo).IsRequired();
    }
}
