using Enums;

namespace Models;

public class Contato
{
    public Guid Id { get; init; }
    public string Nome { get; init; } = null!;
    public List<string> Telefones { get; init; } = null!;
    public List<CategoriasEnum> Categorias { get; init; } = null!;
    public Account? Account { get; init; }
    public DateTime CriadoEm { get; init; }
    public DateTime AtualizadoEm { get; init; }
}