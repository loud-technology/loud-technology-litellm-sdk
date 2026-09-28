
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Default Value: all
    /// </summary>
    public enum GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter
    {
        /// <summary>
        ///
        /// </summary>
        All,
        /// <summary>
        ///
        /// </summary>
        Hits,
        /// <summary>
        ///
        /// </summary>
        Injected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilterExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter value)
        {
            return value switch
            {
                GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter.All => "all",
                GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter.Hits => "hits",
                GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter.Injected => "injected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter? ToEnum(string value)
        {
            return value switch
            {
                "all" => GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter.All,
                "hits" => GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter.Hits,
                "injected" => GetPromptCachingRequestsCostOptimizationPromptCachingRequestsGetFilter.Injected,
                _ => null,
            };
        }
    }
}