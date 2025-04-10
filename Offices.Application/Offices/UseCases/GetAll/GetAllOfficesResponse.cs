namespace Offices.Application.Offices.UseCases.GetAll
{
    public sealed record GetAllOfficesResponse(
            Guid Id,
            string City,
            string Street,
            string HouseNumber,
            string OfficeNumber,
            string Longitude,
            string Latitude,
            string? PhotoId,
            string RegistryPhoneNumber,
            bool IsActive
        );
}
