﻿using Offices.Application.Offices.Models;

namespace Offices.DataAccess.Repositories
{
    public interface IOfficeRepository : IRepositoryBase<OfficeEntity>
    {
        Task<IEnumerable<OfficeEntity>> GetAllAsync();
        Task<OfficeEntity> GetByIdAsync(Guid id);
    }
}