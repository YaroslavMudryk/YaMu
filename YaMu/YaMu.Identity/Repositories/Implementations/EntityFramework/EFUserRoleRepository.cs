using Microsoft.EntityFrameworkCore;
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

        public async Task<UserRole> GetByIdsAsync(int userId, int roleId)
        {
            return await _db.UserRoles.FirstOrDefaultAsync(s => s.UserId == userId && s.RoleId == roleId);
        }
    }
}
