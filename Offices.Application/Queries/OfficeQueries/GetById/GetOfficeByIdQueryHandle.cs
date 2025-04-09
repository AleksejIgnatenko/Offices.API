using MediatR;
using Offices.Core.Models;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Queries.OfficeQueries.GetById;

public sealed class GetOfficeByIdQueryHandle(IOfficeRepository officeRepository) : IRequestHandler<GetOfficeByIdQuery, OfficeEntity>
{
    public async Task<OfficeEntity> Handle(GetOfficeByIdQuery request, CancellationToken cancellationToken)
    {
        return await officeRepository.GetByIdAsync(request.Id);
    }
}