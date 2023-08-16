using Microsoft.EntityFrameworkCore;
using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFAppClaimRepository : BaseRepository<AppClaim, int>, IAppClaimRepository
    {
        private readonly IdentityDbContext _db;
        public EFAppClaimRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }

        public async Task<AppClaim> GetByIdsAsync(int appId, int claimId)
        {
            return await _db.AppClaims.FirstOrDefaultAsync(s => s.AppId == appId && s.ClaimId == claimId);
        }
    }
}
