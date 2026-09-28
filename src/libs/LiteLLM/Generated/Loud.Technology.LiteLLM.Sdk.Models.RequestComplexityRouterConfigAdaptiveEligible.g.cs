
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// When adaptive=True: 'all' scores every pool model with a tier-distance penalty (soft floors); 'classified_tier' Thompson-samples only inside the classified tier's pool<br/>
    /// Default Value: all
    /// </summary>
    public enum RequestComplexityRouterConfigAdaptiveEligible
    {
        /// <summary>
        /// 'all' scores every pool model with a tier-distance penalty (soft floors); 'classified_tier' Thompson-samples only inside the classified tier's pool
        /// </summary>
        All,
        /// <summary>
        /// 'all' scores every pool model with a tier-distance penalty (soft floors); 'classified_tier' Thompson-samples only inside the classified tier's pool
        /// </summary>
        ClassifiedTier,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RequestComplexityRouterConfigAdaptiveEligibleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RequestComplexityRouterConfigAdaptiveEligible value)
        {
            return value switch
            {
                RequestComplexityRouterConfigAdaptiveEligible.All => "all",
                RequestComplexityRouterConfigAdaptiveEligible.ClassifiedTier => "classified_tier",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RequestComplexityRouterConfigAdaptiveEligible? ToEnum(string value)
        {
            return value switch
            {
                "all" => RequestComplexityRouterConfigAdaptiveEligible.All,
                "classified_tier" => RequestComplexityRouterConfigAdaptiveEligible.ClassifiedTier,
                _ => null,
            };
        }
    }
}