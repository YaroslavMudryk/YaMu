using YaMu.Identity.Db;
using YaMu.Identity.Models;
using YaMu.Identity.Repositories.Interfaces;
namespace YaMu.Identity.Repositories.Implementations.EntityFramework
{
    public class EFPasswordRepository : BaseRepository<Password, int>, IPasswordRepository
    {
        private readonly IdentityDbContext _db;
        public EFPasswordRepository(IdentityDbContext db) : base(db)
        {
            _db = db;
        }
    }
}