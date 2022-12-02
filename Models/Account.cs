namespace Models;

public class Account
{
    public string Email { get; init; }
    public string Senha { get; init; }
    public DateTime CriadoEm { get; init; }
    public DateTime AtualizadoEm { get; init; }
    public bool? Ativo { get; init; }
    public Contato Contato { get; init; }
    public Guid ContatoId { get; init; }
}