using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFSessionRepository : BaseRepository<Session, Guid>, ISessionRepository
    {
        private readonly IdentityDbContext _db;
        public EFSessionRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
