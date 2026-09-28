
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Type of pattern: 'prebuilt' for predefined patterns or 'regex' for custom
    /// </summary>
    public enum ContentFilterPatternPatternType
    {
        /// <summary>
        /// 'prebuilt' for predefined patterns or 'regex' for custom
        /// </summary>
        Prebuilt,
        /// <summary>
        /// 'prebuilt' for predefined patterns or 'regex' for custom
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterPatternPatternTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterPatternPatternType value)
        {
            return value switch
            {
                ContentFilterPatternPatternType.Prebuilt => "prebuilt",
                ContentFilterPatternPatternType.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterPatternPatternType? ToEnum(string value)
        {
            return value switch
            {
                "prebuilt" => ContentFilterPatternPatternType.Prebuilt,
                "regex" => ContentFilterPatternPatternType.Regex,
                _ => null,
            };
        }
    }
}