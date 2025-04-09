using Microsoft.EntityFrameworkCore;
using Offices.Core.Models;
using Offices.DataAccess.Context;

namespace Offices.DataAccess.Repositories
{
    public class OfficeRepository : RepositoryBase<OfficeEntity>, IOfficeRepository
    {
        public OfficeRepository(OfficesDbContext context) : base(context) { }

        public async Task<IEnumerable<OfficeEntity>> GetAllAsync()
        {
            return await _context.Offices
                .ToListAsync();
        }

        public async Task<OfficeEntity> GetByIdAsync(Guid id)
        {
            return await _context.Offices
                .FirstOrDefaultAsync(p => p.Id == id)
                ?? throw new Exception("Office not found");
        }
    }
}
