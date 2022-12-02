using System.ComponentModel.DataAnnotations;
using Enums;

namespace Api.DTOs.Contato;

public class UpdateContatoDto
{
    public string? Nome { get; init; }
    [MinLength(1)] public IEnumerable<string>? Telefones { get; init; }
    [MinLength(1)] public IEnumerable<CategoriasEnum>? Categorias { get; init; }
    public bool? Ativo { get; init; }
}