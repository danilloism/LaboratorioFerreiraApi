using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Account;

public class CreateAccountDto : LoginAccountDto
{
    [Required] public string ContatoId { get; init; }
}