using Microsoft.AspNetCore.Builder;
using YaMu.Identity.Middlewares;
namespace YaMu.Identity.Extensions
{
    public static class SessionMiddlewareExtensions
    {
        public static void UseYaMuSessionHandler(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<SessionMiddleware>();
        }
    }
}