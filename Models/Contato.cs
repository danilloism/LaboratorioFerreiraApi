using Enums;

namespace Models;

public class Contato
{
    public Guid Id { get; init; }
    public string Nome { get; init; }
    public HashSet<string> Telefones { get; init; }
    public HashSet<CategoriasEnum> Categorias { get; init; }
    public Account? Account { get; init; }
    public DateTime CriadoEm { get; init; }
    public DateTime AtualizadoEm { get; init; }
}