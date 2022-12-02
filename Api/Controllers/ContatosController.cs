using Api.DTOs.Contato;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ContatosController : ControllerBase
{
    private readonly ILogger<ContatosController> _logger;

    public ContatosController(ILogger<ContatosController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult GetMany([FromQuery] QueryContatoDto? query)
    {
        return Ok(query);
    }

    [HttpGet("{id}")]
    public IActionResult GetOne([FromRoute] string id)
    {
        return Ok(id);
    }

    [HttpPost]
    public IActionResult Create([FromBody] CreateContatoDto dto)
    {
        return Ok(dto);
    }

    [HttpPut("{id}")]
    public IActionResult Update([FromBody] UpdateContatoDto dto, [FromRoute] string id)
    {
        return Ok(new { id, dto });
    }
}