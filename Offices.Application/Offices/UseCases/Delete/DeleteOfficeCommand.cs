using MediatR;

namespace Offices.Application.Offices.UseCases.Delete;

public sealed class DeleteOfficeCommand : IRequest
{
    public Guid Id { get; }
    public DeleteOfficeCommand(Guid id)
    {
        Id = id;
    }
}
