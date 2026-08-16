
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// 
    /// </summary>
    public enum APIKeySecuritySchemeIn
    {
        /// <summary>
        /// 
        /// </summary>
        Cookie,
        /// <summary>
        /// 
        /// </summary>
        Header,
        /// <summary>
        /// 
        /// </summary>
        Query,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class APIKeySecuritySchemeInExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this APIKeySecuritySchemeIn value)
        {
            return value switch
            {
                APIKeySecuritySchemeIn.Cookie => "cookie",
                APIKeySecuritySchemeIn.Header => "header",
                APIKeySecuritySchemeIn.Query => "query",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static APIKeySecuritySchemeIn? ToEnum(string value)
        {
            return value switch
            {
                "cookie" => APIKeySecuritySchemeIn.Cookie,
                "header" => APIKeySecuritySchemeIn.Header,
                "query" => APIKeySecuritySchemeIn.Query,
                _ => null,
            };
        }
    }
}