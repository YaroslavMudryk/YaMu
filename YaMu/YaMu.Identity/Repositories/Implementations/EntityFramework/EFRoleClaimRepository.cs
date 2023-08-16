using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFRoleClaimRepository : BaseRepository<RoleClaim, int>, IRoleClaimRepository
    {
        private readonly IdentityDbContext _db;
        public EFRoleClaimRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
