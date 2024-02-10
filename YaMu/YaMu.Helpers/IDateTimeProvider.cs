using Microsoft.Extensions.DependencyInjection;

namespace YaMu.Helpers
{
    public interface IDateTimeProvider
    {
        DateTime UtcNow { get; }
        DateTime Today { get; }
    }

    public class DefaultDateTimeProvider : IDateTimeProvider
    {
        public DateTime UtcNow => DateTime.UtcNow;
        public DateTime Today => DateTime.UtcNow.Date;
    }

    public static class DateTimeProviderExt
    {
        public static void AddDateTimeProvider(this IServiceCollection services)
        {
            services.AddSingleton<IDateTimeProvider, DefaultDateTimeProvider>();
        }
    }
}
