
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: general
    /// </summary>
    public enum DeleteFallbackFallbackModelDeleteFallbackType
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
    public static class DeleteFallbackFallbackModelDeleteFallbackTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeleteFallbackFallbackModelDeleteFallbackType value)
        {
            return value switch
            {
                DeleteFallbackFallbackModelDeleteFallbackType.ContentPolicy => "content_policy",
                DeleteFallbackFallbackModelDeleteFallbackType.ContextWindow => "context_window",
                DeleteFallbackFallbackModelDeleteFallbackType.General => "general",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeleteFallbackFallbackModelDeleteFallbackType? ToEnum(string value)
        {
            return value switch
            {
                "content_policy" => DeleteFallbackFallbackModelDeleteFallbackType.ContentPolicy,
                "context_window" => DeleteFallbackFallbackModelDeleteFallbackType.ContextWindow,
                "general" => DeleteFallbackFallbackModelDeleteFallbackType.General,
                _ => null,
            };
        }
    }
}