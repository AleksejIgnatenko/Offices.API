using MediatR;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Offices.UseCases.GetById;

public sealed class GetOfficeByIdHandler(IOfficeRepository officeRepository) : IRequestHandler<GetOfficeByIdQuery, GetOfficeByIdResponse>
{
    public async Task<GetOfficeByIdResponse> Handle(GetOfficeByIdQuery request, CancellationToken cancellationToken)
    {
        var office = await officeRepository.GetByIdAsync(request.Id);
        return new GetOfficeByIdResponse(office.Id, office.City, office.Street, office.HouseNumber, office.OfficeNumber, office.Longitude, office.Latitude, office.PhotoId, office.RegistryPhoneNumber, office.IsActive);
    }
}