using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace YaMu.Helpers.Extensions
{
    public static class HttpContextExtensions
    {
        public static bool IsAuthNeeded(this HttpContext httpContext)
        {
            var endpoint = httpContext.Features.Get<IEndpointFeature>()?.Endpoint;
            if (endpoint == null)
                return false;
            var metadata = endpoint.Metadata;

            var existAuthAttrbt = metadata.Any(s => s is AuthorizeAttribute);
            if (existAuthAttrbt)
            {
                if (metadata.Any(s => s is AllowAnonymousAttribute))
                {
                    return false;
                }
                return true;
            }
            return false;
        }

        public static async Task WriteAsJsonAsync(this HttpResponse response, object data)
        {
            var json = JsonSerializer.Serialize(data, new JsonSerializerOptions
            {
                DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
            });

            response.ContentType = "applications/json";
            await response.WriteAsync(json);
        }

        public static string GetBearerToken(this HttpContext context)
        {
            var bearerWord = "Bearer ";
            var bearerToken = context.Request.Headers["Authorization"].ToString();
            if (bearerToken.StartsWith(bearerWord, StringComparison.OrdinalIgnoreCase))
                return bearerToken.Substring(bearerWord.Length).Trim();
            return bearerToken;
        }
    }
}
