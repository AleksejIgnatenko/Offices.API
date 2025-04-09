using MediatR;
using Offices.Core.Models;

namespace Offices.Application.Queries.OfficeQueries.GetAll;

public sealed class GetAllOfficesQuery : IRequest<IEnumerable<OfficeEntity>>
{
}