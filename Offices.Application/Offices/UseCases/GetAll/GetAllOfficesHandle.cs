using MediatR;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Offices.UseCases.GetAll;

public sealed class GetAllOfficesHandle(IOfficeRepository officeRepository) : IRequestHandler<GetAllOfficesQuery, IEnumerable<GetAllOfficesResponse>>
{
    public async Task<IEnumerable<GetAllOfficesResponse>> Handle(GetAllOfficesQuery request, CancellationToken cancellationToken)
    {
        var offices = await officeRepository.GetAllAsync();
        return offices.Select(office => new GetAllOfficesResponse(office.Id, office.City, office.Street, office.HouseNumber,
            office.OfficeNumber, office.Longitude, office.Latitude, office.PhotoId, office.RegistryPhoneNumber, office.IsActive));
    }
}
