using MediatR;
using Offices.Application.Offices.Models;
using Offices.Application.Offices.UseCases.Create;
using Offices.Application.Offices.UseCases.Delete;
using Offices.Application.Offices.UseCases.GetAll;
using Offices.Application.Offices.UseCases.GetById;
using Offices.Application.Offices.UseCases.Update;

namespace Offices.API.Extensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddCQRSHandlers(this IServiceCollection services)
    {
        services.AddScoped<IRequestHandler<CreateOfficeCommand, OfficeEntity>, CreateOfficeHandler>();
        services.AddScoped<IRequestHandler<GetOfficeByIdQuery, GetOfficeByIdResponse>, GetOfficeByIdHandler>();
        services.AddScoped<IRequestHandler<GetAllOfficesQuery, IEnumerable<GetAllOfficesResponse>>, GetAllOfficesHandle>();
        services.AddScoped<IRequestHandler<UpdateOfficeCommand, OfficeEntity>, UpdateOfficeHandler>();
        services.AddScoped<IRequestHandler<DeleteOfficeCommand>, DeleteOfficeHandle>();

        return services;
    }
}
