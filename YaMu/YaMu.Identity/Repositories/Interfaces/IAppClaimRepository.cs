using YaMu.Identity.Models;

namespace YaMu.Identity.Repositories.Interfaces
{
    public interface IAppClaimRepository : IRepository<AppClaim, int>
    {
        Task<AppClaim> GetByIdsAsync(int appId, int claimId);
    }
}