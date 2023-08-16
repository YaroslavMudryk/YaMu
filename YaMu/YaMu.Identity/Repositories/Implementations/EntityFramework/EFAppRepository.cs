using Microsoft.EntityFrameworkCore;
using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFAppRepository : BaseRepository<App, int>, IAppRepository
    {
        private readonly IdentityDbContext _db;
        public EFAppRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<IEnumerable<App>> GetUserAppsAsync(int userId)
        {
            return await _db.Apps.AsNoTracking().Where(s => s.UserId == userId).ToListAsync();
        }
    }
}
