using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;

namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFConfirmRepository : BaseRepository<Confirm, Guid>, IConfirmRepository
    {
        private readonly IdentityDbContext _db;
        public EFConfirmRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}
