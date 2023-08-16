using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFTokenRepository : BaseRepository<Token, long>, ITokenRepository
    {
        private readonly IdentityDbContext _db;
        public EFTokenRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
