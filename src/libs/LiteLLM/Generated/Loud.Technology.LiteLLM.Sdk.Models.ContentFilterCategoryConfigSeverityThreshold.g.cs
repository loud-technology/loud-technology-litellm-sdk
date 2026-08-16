
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// The severity threshold to detect the category<br/>
    /// Default Value: medium
    /// </summary>
    public enum ContentFilterCategoryConfigSeverityThreshold
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Medium,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ContentFilterCategoryConfigSeverityThresholdExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContentFilterCategoryConfigSeverityThreshold value)
        {
            return value switch
            {
                ContentFilterCategoryConfigSeverityThreshold.High => "high",
                ContentFilterCategoryConfigSeverityThreshold.Low => "low",
                ContentFilterCategoryConfigSeverityThreshold.Medium => "medium",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContentFilterCategoryConfigSeverityThreshold? ToEnum(string value)
        {
            return value switch
            {
                "high" => ContentFilterCategoryConfigSeverityThreshold.High,
                "low" => ContentFilterCategoryConfigSeverityThreshold.Low,
                "medium" => ContentFilterCategoryConfigSeverityThreshold.Medium,
                _ => null,
            };
        }
    }
}