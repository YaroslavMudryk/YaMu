using Microsoft.EntityFrameworkCore;
using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFLoginAttemptRepository : BaseRepository<LoginAttempt, int>, ILoginAttemptRepository
    {
        private readonly IdentityDbContext _db;
        public EFLoginAttemptRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
