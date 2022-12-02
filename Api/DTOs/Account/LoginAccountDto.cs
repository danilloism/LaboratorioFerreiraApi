using System.ComponentModel.DataAnnotations;

namespace Api.DTOs.Account;

public class LoginAccountDto
{
    [Required] [EmailAddress] public string Email { get; init; }

    [Required]
    [MinLength(4)]
    [MaxLength(20)]
    public string Senha { get; init; }
}