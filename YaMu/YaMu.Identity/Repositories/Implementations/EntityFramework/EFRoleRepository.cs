using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFRoleRepository : BaseRepository<Role, int>, IRoleRepository
    {
        private readonly IdentityDbContext _db;
        public EFRoleRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
