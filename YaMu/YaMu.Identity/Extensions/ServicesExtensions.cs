using DeviceDetector.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YaMu.Helpers;
using YaMu.Identity.Db;
using YaMu.Identity.Sessions;

namespace YaMu.Identity.Extensions
{
    public static class ServicesExtensions
    {
        public static IServiceCollection AddYaMuIdentity<T>(this IServiceCollection services, Action<DbContextOptionsBuilder> optionsAction) where T : IdentityDbContext
        {
            services.AddDbContext<T>(optionsAction);

            services.AddScoped<IDateTimeProvider, DefaultDateTimeProvider>();

            services.AddSingleton<ISessionManager, SessionManager>();

            services.AddDeviceDetector();

            return services;
        }
    }
}