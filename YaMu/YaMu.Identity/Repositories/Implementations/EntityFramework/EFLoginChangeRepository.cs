using Microsoft.EntityFrameworkCore;
using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFLoginChangeRepository : BaseRepository<LoginChange, int>, ILoginChangeRepository
    {
        private readonly IdentityDbContext _db;
        public EFLoginChangeRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
