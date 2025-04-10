namespace Offices.Application.Offices.UseCases.GetById
{
    public record GetOfficeByIdResponse(
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