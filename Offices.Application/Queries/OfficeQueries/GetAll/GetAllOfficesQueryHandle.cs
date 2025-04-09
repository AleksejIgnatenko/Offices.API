using MediatR;
using Offices.Core.Models;
using Offices.DataAccess.Repositories;

namespace Offices.Application.Queries.OfficeQueries.GetAll;

public sealed class GetAllOfficesQueryHandle(IOfficeRepository officeRepository) : IRequestHandler<GetAllOfficesQuery, IEnumerable<OfficeEntity>>
{
    public async Task<IEnumerable<OfficeEntity>> Handle(GetAllOfficesQuery request, CancellationToken cancellationToken)
    {
        return await officeRepository.GetAllAsync();
    }
}
