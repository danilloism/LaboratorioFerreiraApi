namespace Models;

public class Account
{
    public string Email { get; init; } = null!;
    public string Senha { get; init; } = null!;
    public DateTime CriadoEm { get; init; }
    public DateTime AtualizadoEm { get; init; }
    public bool? Ativo { get; init; }
    public Contato Contato { get; init; } = null!;
    public Guid ContatoId { get; init; }
}