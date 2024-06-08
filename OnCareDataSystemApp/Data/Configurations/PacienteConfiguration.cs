using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnCareDataSystemApp.Domain;
using OnCareDataSystemApp.Domain.Entities;

namespace OnCareDataSystemApp.Data.Configurations;

public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> entity)
    {
        entity.HasKey(e => e.Id); // chave primária
        entity.Property(e => e.Nome).IsRequired().HasMaxLength(100); // nome do paciente
        entity.Property(e => e.Sobrenome).IsRequired().HasMaxLength(100); // nome do paciente
        entity.Property(e => e.Nascimento).IsRequired(); // data de nascimento do paciente
        entity.Property(e => e.Sexo).IsRequired().HasMaxLength(1); // sexo do paciente
        entity.Property(e => e.Ceep).IsRequired().HasMaxLength(10); // CEEP do paciente
        entity.Property(e => e.Uf).IsRequired().HasMaxLength(2); // unidade federativa
        entity.Property(e => e.NumeroCasa).IsRequired().HasMaxLength(10); // número da casa do paciente
        entity.Property(e => e.Endereco).IsRequired().HasMaxLength(200); // endereço do paciente
        entity.Property(e => e.ContatoFamiliar1).IsRequired().HasMaxLength(15);  // contato da família
        entity.Property(e => e.ContatoFamiliar2).HasMaxLength(15); // contato da família
        entity.Property(e => e.EmpresaResponsavel).IsRequired().HasMaxLength(100); // empresa responsável pelo paciente
        entity.Property(e => e.EscalistaResponsavel).HasMaxLength(100); // responsável pelo paciente
        entity.Property(e => e.Valor).HasColumnType("decimal(18,2)"); // valor do paciente
        entity.Property(e => e.Repasse).HasColumnType("decimal(18,2)"); // Valor de repasse para os profissionais
        entity.Property(e => e.CriadoPor).IsRequired().HasMaxLength(100); // Usuario que criou
        entity.Property(e => e.DataCriado).IsRequired(); //Data da criação
        entity.Property(e => e.AlteradoPor).IsRequired().HasMaxLength(100); // Nome do ultimo que alterou
        entity.Property(e => e.DataAlterado).IsRequired(); // Data da Ultima Alteração
    }
}