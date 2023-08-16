using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFQrRepository : BaseRepository<Qr, Guid>, IQrRepository
    {
        private readonly IdentityDbContext _db;
        public EFQrRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
