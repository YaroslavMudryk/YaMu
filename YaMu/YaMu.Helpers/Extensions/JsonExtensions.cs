using System.Text.Json;
using System.Text.Json.Serialization;

namespace YaMu.Helpers.Extensions
{
    public static class JsonExtensions
    {
        private static readonly JsonSerializerOptions _options = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull
        };

        public static string ToJson(this object obj)
        {
            return JsonSerializer.Serialize(obj, _options);
        }

        public static T FromJson<T>(this string json)
        {
            return JsonSerializer.Deserialize<T>(json, _options);
        }
    }
}
