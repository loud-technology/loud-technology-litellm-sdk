
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Type of fallback: 'general' (default), 'context_window', or 'content_policy'<br/>
    /// Default Value: general
    /// </summary>
    public enum FallbackCreateRequestFallbackType
    {
        /// <summary>
        /// 'general' (default), 'context_window', or 'content_policy'
        /// </summary>
        ContentPolicy,
        /// <summary>
        /// 'general' (default), 'context_window', or 'content_policy'
        /// </summary>
        ContextWindow,
        /// <summary>
        /// 'general' (default), 'context_window', or 'content_policy'
        /// </summary>
        General,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class FallbackCreateRequestFallbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this FallbackCreateRequestFallbackType value)
        {
            return value switch
            {
                FallbackCreateRequestFallbackType.ContentPolicy => "content_policy",
                FallbackCreateRequestFallbackType.ContextWindow => "context_window",
                FallbackCreateRequestFallbackType.General => "general",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static FallbackCreateRequestFallbackType? ToEnum(string value)
        {
            return value switch
            {
                "content_policy" => FallbackCreateRequestFallbackType.ContentPolicy,
                "context_window" => FallbackCreateRequestFallbackType.ContextWindow,
                "general" => FallbackCreateRequestFallbackType.General,
                _ => null,
            };
        }
    }
}