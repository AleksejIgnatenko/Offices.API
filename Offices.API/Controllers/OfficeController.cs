using MediatR;
using Microsoft.AspNetCore.Mvc;
using Offices.Application.Offices.UseCases.Create;
using Offices.Application.Offices.UseCases.Delete;
using Offices.Application.Offices.UseCases.GetAll;
using Offices.Application.Offices.UseCases.GetById;
using Offices.Application.Offices.UseCases.Update;

namespace Offices.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OfficeController(IMediator mediator) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateOffice([FromBody] CreateOfficeCommand command)
    {
        var office = await mediator.Send(command);
        return CreatedAtAction(nameof(GetOfficeById), new { id = office.Id }, office);
    }

    [HttpGet]
    public async Task<IActionResult> GetAllOffices()
    {
        return Ok(await mediator.Send(new GetAllOfficesQuery()));
    }

    [HttpGet("{id:guid}")]
    public async Task<IActionResult> GetOfficeById(Guid id)
    {
        return Ok(await mediator.Send(new GetOfficeByIdQuery(id)));
    }

    [HttpPut]
    public async Task<IActionResult> UpdateOffice([FromBody] UpdateOfficeCommand updateOfficeCommand)
    {
        var office = await mediator.Send(updateOfficeCommand);
        return CreatedAtAction(nameof(GetOfficeById), new { id = office.Id }, office);
    }

    [HttpDelete("{id:guid}")]
    public async Task<IActionResult> DeleteOffice(Guid id)
    {
        await mediator.Send(new DeleteOfficeCommand(id));
        return Ok();
    }
}