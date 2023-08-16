using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFMFARepository : BaseRepository<MFA, int>, IMFARepository
    {
        private readonly IdentityDbContext _db;
        public EFMFARepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
