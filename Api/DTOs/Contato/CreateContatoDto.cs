using System.ComponentModel.DataAnnotations;
using Api.DTOs.Account;
using Enums;

namespace Api.DTOs.Contato;

public class CreateContatoDto
{
    [Required] public string Nome { get; init; }
    [Required] [MinLength(1)] public IEnumerable<string> Telefones { get; init; }

    [Required] [MinLength(1)] public IEnumerable<CategoriasEnum> Categorias { get; init; }
    public LoginAccountDto? Account { get; init; }
}