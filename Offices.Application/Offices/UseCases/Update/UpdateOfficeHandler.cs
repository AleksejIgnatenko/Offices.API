using MediatR;
using Offices.Application.Offices.Models;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Offices.UseCases.Update;

public sealed class UpdateOfficeHandler(IOfficeRepository officeRepository) : IRequestHandler<UpdateOfficeCommand, OfficeEntity>
{
    public async Task<OfficeEntity> Handle(UpdateOfficeCommand request, CancellationToken cancellationToken)
    {
        var office = await officeRepository.GetByIdAsync(request.Id);

        office.City = request.City;
        office.Street = request.Street;
        office.HouseNumber = request.HouseNumber;
        office.OfficeNumber = request.OfficeNumber;
        office.Longitude = request.Longitude;
        office.Latitude = request.Latitude;
        office.PhotoId = request.PhotoId;
        office.RegistryPhoneNumber = request.RegistryPhoneNumber;
        office.IsActive = request.IsActive;

        await officeRepository.UpdateAsync(office);

        return office;
    }
}
