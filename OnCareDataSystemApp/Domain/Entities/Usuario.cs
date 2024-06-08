namespace OnCareDataSystemApp.Domain.Entities;

public class Usuario
{
    public int Id { get; set; } //Id do Usuario
    public string Nome { get; set; } //Nome do usuario
    public string Sobrenome { get; set; } // Sobrenome do usuario
    public DateTime Nascimento { get; set; } // Data de nascimento do usuario
    public string Sexo { get; set; } //Sexo do usuario
    public string Email { get; set; } //Email do usuario
    public string Senha { get; set; } //Senha do usuario
    public bool Padrão { get; set; } //Primeiro nivél de Pemissão
    public bool? Moderador { get; set; } //Segundo nivél de Permissões
    public bool? Administrador { get; set; } //Terceiro Nivél Permissão total

}
