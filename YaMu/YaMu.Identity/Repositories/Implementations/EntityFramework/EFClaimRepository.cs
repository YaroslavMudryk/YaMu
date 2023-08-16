using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFClaimRepository : BaseRepository<Claim, int>, IClaimRepository
    {
        private readonly IdentityDbContext _db;
        public EFClaimRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
