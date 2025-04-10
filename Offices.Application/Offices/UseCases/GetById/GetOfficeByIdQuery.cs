using MediatR;
using Offices.Application.Offices.Models;

namespace Offices.Application.Offices.UseCases.GetById;

public sealed class GetOfficeByIdQuery : IRequest<GetOfficeByIdResponse>
{
    public Guid Id { get; }

    public GetOfficeByIdQuery(Guid id)
    {
        Id = id;
    }
}
