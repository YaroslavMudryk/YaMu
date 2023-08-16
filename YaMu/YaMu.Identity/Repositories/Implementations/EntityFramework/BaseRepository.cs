using Microsoft.EntityFrameworkCore;
using YaMu.Identity.Db;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class BaseRepository<T, K> : IRepository<T, K> where T : class
    {
        private readonly IdentityDbContext _db;
        public BaseRepository(IdentityDbContext db)
        {
            _db = db;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await _db.Set<T>().AddAsync(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> CreateRangeAsync(IEnumerable<T> entities)
        {
            await _db.Set<T>().AddRangeAsync(entities);
            await _db.SaveChangesAsync();
            return entities;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _db.Set<T>().Remove(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> entities)
        {
            _db.Set<T>().RemoveRange(entities);
            await _db.SaveChangesAsync();
            return entities;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _db.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(K id)
        {
            return await _db.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _db.Set<T>().Update(entity);
            await _db.SaveChangesAsync();
            return entity;
        }

        public async Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities)
        {
            _db.Set<T>().UpdateRange(entities);
            await _db.SaveChangesAsync();
            return entities;
        }
    }
}
