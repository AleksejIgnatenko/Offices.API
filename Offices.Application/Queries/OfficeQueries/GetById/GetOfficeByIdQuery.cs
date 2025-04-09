using MediatR;
using Offices.Core.Models;

namespace Offices.Application.Queries.OfficeQueries.GetById;

public sealed class GetOfficeByIdQuery : IRequest<OfficeEntity>
{
    public Guid Id { get; }

    public GetOfficeByIdQuery(Guid id)
    {
        Id = id;
    }
}
