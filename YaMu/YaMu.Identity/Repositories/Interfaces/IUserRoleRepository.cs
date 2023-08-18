using YaMu.Identity.Models;
namespace YaMu.Identity.Repositories.Interfaces
{
    public interface IUserRoleRepository : IRepository<UserRole, int>
    {
        Task<UserRole> GetByIdsAsync(int userId, int roleId);
    }
}