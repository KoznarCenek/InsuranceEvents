using AutoMapper;
using Insurance.Api.Dto.Input;
using Insurance.Api.Dto.Output;
using Insurance.Application.Features.InsuredPerson;
using MediatR;
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
    private readonly ISender _sender;
    private readonly IMapper _mapper;

    public InsuredPersonController(IMapper mapper,ILogger<InsuredPersonController> logger, ISender sender)
    {
        _logger = logger;
        _sender = sender;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(typeof(InsuredPersonDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetById(Guid id)
    {
        var command = new GetInsuredPersonByIdCommand()
        {
            Id = id
        };
        var result = await _sender.Send(command);
        return Ok(_mapper.Map<InsuredPersonDto>(result));
    }

    [HttpGet(nameof(GetByFilter), Name = nameof(GetByFilter))]
    [ProducesResponseType(typeof(InsuredPersonDto), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetByFilter(InsuredPersonFilter filter)
    {
        throw new NotImplementedException();
    }
}
