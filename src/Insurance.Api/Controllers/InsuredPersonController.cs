using Insurance.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.Api.Controllers;
[ApiController]
[Route("[controller]")]
public class InsuredPersonController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<InsuredPersonController> _logger;

    public InsuredPersonController(ILogger<InsuredPersonController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    [ProducesResponseType(typeof(InsuredPersonDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> Get()
    {
        return Ok(new InsuredPersonDto());
    }
}
