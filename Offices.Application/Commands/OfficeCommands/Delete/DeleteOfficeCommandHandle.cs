using MediatR;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Commands.OfficeCommands.Delete;

public sealed class DeleteOfficeCommandHandle(IOfficeRepository officeRepository) : IRequestHandler<DeleteOfficeCommand>
{
    public async Task Handle(DeleteOfficeCommand request, CancellationToken cancellationToken)
    {
        var office = await officeRepository.GetByIdAsync(request.Id);

        await officeRepository.DeleteAsync(office);
    }
}
