namespace Offices.DataAccess.Repositories
{
    public interface IRepositoryBase<T> where T : class
    {
        Task AddAsync(T entity);
        Task DeleteAsync(T entity);
        Task UpdateAsync(T entity);
    }
}