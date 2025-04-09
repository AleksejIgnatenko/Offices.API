using MediatR;

namespace Offices.Application.Commands.OfficeCommands.Delete;

public sealed class DeleteOfficeCommand : IRequest
{
    public Guid Id { get; }
    public DeleteOfficeCommand(Guid id)
    {
        Id = id;
    }
}
