using YaMu.Identity.Models;
namespace YaMu.Identity.Repositories.Interfaces
{
    public interface IRoleClaimRepository : IRepository<RoleClaim, int>
    {
        Task<RoleClaim> GetByIdsAsync(int roleId, int claimId);
    }
}