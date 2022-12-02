namespace Api.DTOs.Contato;

public class QueryContatoDto
{
    public byte? Take { get; init; }
    public short? Skip { get; init; }
    public string? Nome { get; init; }
}