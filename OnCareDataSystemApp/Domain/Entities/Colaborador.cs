namespace OnCareDataSystemApp.Domain.Entities;

public class Colaborador
{
    //Primeira etapa do cadastro.
    public int Id { get; set; } //Chave Primária
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public DateTime Nascimento { get; set; }
    public string Sexo { get; set; }
    public string Contato1 { get; set; }
    public string? Contato2 { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }
    //Dados da documentação
    public string RG { get; set; }
    public string FotoRG { get; set; } //Upload imagem do RG
    public string CPF { get; set; }
    public string FotoCPF { get; set; } //Upload imagem do CPF
    public DateTime Expedicao { get; set; }
    public string NomeDaMae {  get; set; }
    //Dados de trabalho
    public string Profissao { get; set; }
    public string Especialidade { get; set; }
    public string Registro { get; set; }
    public DateTime VencimentoCarteira { get; set; }
    public string FotoREG { get; set; } //Upload Da Carteira de Atuação
    //Dados de Endereço
    public string Ceep { get; set; }
    public string Uf { get; set; }
    public string Estado { get; set; }
    public string Bairro { get; set; }
    public string Cidade {  get; set; }
    public string NumeroCasa { get; set; }
    public string ComprovanteResidencia {  get; set; } //Upload do Comprovante de residencia
    //Finalização
    public DateTime DataCadastro { get; set; }
    public DateTime DataAlterado { get; set; }
    public DateTime VistoPorUltimo { get; set; }
        

}
