using Microsoft.AspNetCore.Http;
using YaMu.Helpers.Extensions;
using YaMu.Identity.Sessions;

namespace YaMu.Identity.Middlewares
{
    internal class SessionMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ISessionManager _sessionManager;
        public SessionMiddleware(RequestDelegate next, ISessionManager sessionManager)
        {
            _next = next;
            _sessionManager = sessionManager;
        }

        public async Task InvokeAsync(HttpContext httpContext)
        {
            var token = httpContext.GetBearerToken();
            if (httpContext.IsAuthNeeded())
            {
                if (token == null || !_sessionManager.IsActiveSession(token))
                {
                    httpContext.Response.StatusCode = 401;
                    await httpContext.Response.WriteAsJsonAsync(new { error = "Unauhorized" });
                    return;
                }
            }
            await _next(httpContext);
        }
    }
}
