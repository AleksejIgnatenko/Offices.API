using Offices.Core.Models;

namespace Offices.DataAccess.Repositories
{
    public interface IRepositoryBase<T> where T : EntityBase
    {
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}