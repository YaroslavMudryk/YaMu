namespace YaMu.Identity.Repositories
{
    public interface IRepository<T, K>
    {
        Task<T> CreateAsync(T entity);
        Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities);

        Task<T> UpdateAsync(T entity);
        Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities);

        Task<T> DeleteAsync(T entity);
        Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> entities);

        Task<T> GetByIdAsync(K id);

        Task<IEnumerable<T>> GetAllAsync();
    }
}