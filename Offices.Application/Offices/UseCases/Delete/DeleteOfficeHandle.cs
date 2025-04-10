using MediatR;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Offices.UseCases.Delete;

public sealed class DeleteOfficeHandle(IOfficeRepository officeRepository) : IRequestHandler<DeleteOfficeCommand>
{
    public async Task Handle(DeleteOfficeCommand request, CancellationToken cancellationToken)
    {
        var office = await officeRepository.GetByIdAsync(request.Id);

        await officeRepository.DeleteAsync(office);
    }
}
