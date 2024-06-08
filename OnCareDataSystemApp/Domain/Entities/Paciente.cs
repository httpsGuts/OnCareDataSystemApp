namespace OnCareDataSystemApp.Domain.Entities;

public class Paciente
{
    public int Id { get; set; } //Id do Paciente!
    public string Nome { get; set; } //Nome do paciente!
    public string Sobrenome { get; set; } //Sobre nome do Paciente!
    public DateTime Nascimento { get; set; } //Data de Nascimento!
    public string Sexo { get; set; } //O sexo do Paciente!
    public string Ceep { get; set; } //Ceep do paciente!
    public string Uf { get; set; } //Uf do Estado!
    public string NumeroCasa { get; set; } //O Numero da casa!
    public string Endereco { get; set; } //Endereço da casa do paciente!
    public string ContatoFamiliar1 { get; set; } //Contato de um responsável Familiar Obrigatório!
    public string? ContatoFamiliar2 { get; set; } //Segundo contato de um responsável Familiar não obrigatório!
    public string EmpresaResponsavel { get; set; } //Nome da empresa Tomadora
    public string? EscalistaResponsavel { get; set; } //Usuario responsável pela escala do paciente
    public decimal? Valor { get; set; } //Valor Entregue pela empresa
    public decimal? Repasse { get; set; } //Valor de repasse padrão
    public string CriadoPor { get; set; } //Usuario responsável pela inserção do paciente no Sistema!
    public DateTime DataCriado { get; set; } //Data da inserção no sistema!
    public string? AlteradoPor { get; set; } //Usuario responsável pela inserção do paciente no Sistema!
    public DateTime? DataAlterado { get; set; } //Data da ultima alteração.
}
