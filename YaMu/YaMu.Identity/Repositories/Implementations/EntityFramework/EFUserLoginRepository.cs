using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFUserLoginRepository : BaseRepository<UserLogin, int>, IUserLoginRepository
    {
        private readonly IdentityDbContext _db;
        public EFUserLoginRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
