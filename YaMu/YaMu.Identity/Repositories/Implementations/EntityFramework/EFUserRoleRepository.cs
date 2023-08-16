using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFUserRoleRepository : BaseRepository<UserRole, int>, IUserRoleRepository
    {
        private readonly IdentityDbContext _db;
        public EFUserRoleRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
