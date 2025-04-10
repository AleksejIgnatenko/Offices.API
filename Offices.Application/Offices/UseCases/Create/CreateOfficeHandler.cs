using MediatR;
using Offices.Application.Offices.Models;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Offices.UseCases.Create;

public sealed class CreateOfficeHandler(IOfficeRepository officeRepository) : IRequestHandler<CreateOfficeCommand, OfficeEntity>
{
    public async Task<OfficeEntity> Handle(CreateOfficeCommand request, CancellationToken cancellationToken)
    {
        var office = new OfficeEntity
        {
            City = request.City,
            Street = request.Street,
            HouseNumber = request.HouseNumber,
            OfficeNumber = request.OfficeNumber,
            Longitude = request.Longitude,
            Latitude = request.Latitude,
            PhotoId = request.PhotoId,
            RegistryPhoneNumber = request.RegistryPhoneNumber,
            IsActive = request.IsActive
        };

        await officeRepository.AddAsync(office);

        return office;
    }
}
