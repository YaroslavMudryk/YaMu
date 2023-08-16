using DeviceDetector.Extensions;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using YaMu.Helpers;
using YaMu.Identity.Db;
using YaMu.Identity.Repositories.Implementations.EntityFramework;
using YaMu.Identity.Repositories.Interfaces;
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

            #region Repositories

            services.AddScoped<IAppClaimRepository, EFAppClaimRepository>();
            services.AddScoped<IAppRepository, EFAppRepository>();
            services.AddScoped<IClaimRepository, EFClaimRepository>();
            services.AddScoped<IConfirmRepository, EFConfirmRepository>();
            services.AddScoped<ILoginAttemptRepository, EFLoginAttemptRepository>();
            services.AddScoped<ILoginChangeRepository, EFLoginChangeRepository>();
            services.AddScoped<IMFARepository, EFMFARepository>();
            services.AddScoped<IPasswordRepository, EFPasswordRepository>();
            services.AddScoped<IQrRepository, EFQrRepository>();
            services.AddScoped<IRoleClaimRepository, EFRoleClaimRepository>();
            services.AddScoped<IRoleRepository, EFRoleRepository>();
            services.AddScoped<ISessionRepository, EFSessionRepository>();
            services.AddScoped<ITokenRepository, EFTokenRepository>();
            services.AddScoped<IUserLoginRepository, EFUserLoginRepository>();
            services.AddScoped<IUserRepository, EFUserRepository>();
            services.AddScoped<IUserRoleRepository, EFUserRoleRepository>();

            #endregion

            #region Services

            #endregion

            services.AddDeviceDetector();

            return services;
        }
    }
}