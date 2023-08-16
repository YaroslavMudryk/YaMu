using YaMu.Identity.Models;
namespace YaMu.Identity.Repositories.Interfaces
{
    public interface IAppRepository : IRepository<App, int>
    {
        Task<IEnumerable<App>> GetUserAppsAsync(int userId);
    }
}