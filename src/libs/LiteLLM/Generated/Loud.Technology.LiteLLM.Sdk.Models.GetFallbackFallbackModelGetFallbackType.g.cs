
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: general
    /// </summary>
    public enum GetFallbackFallbackModelGetFallbackType
    {
        /// <summary>
        /// 
        /// </summary>
        ContentPolicy,
        /// <summary>
        /// 
        /// </summary>
        ContextWindow,
        /// <summary>
        /// 
        /// </summary>
        General,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetFallbackFallbackModelGetFallbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetFallbackFallbackModelGetFallbackType value)
        {
            return value switch
            {
                GetFallbackFallbackModelGetFallbackType.ContentPolicy => "content_policy",
                GetFallbackFallbackModelGetFallbackType.ContextWindow => "context_window",
                GetFallbackFallbackModelGetFallbackType.General => "general",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetFallbackFallbackModelGetFallbackType? ToEnum(string value)
        {
            return value switch
            {
                "content_policy" => GetFallbackFallbackModelGetFallbackType.ContentPolicy,
                "context_window" => GetFallbackFallbackModelGetFallbackType.ContextWindow,
                "general" => GetFallbackFallbackModelGetFallbackType.General,
                _ => null,
            };
        }
    }
}