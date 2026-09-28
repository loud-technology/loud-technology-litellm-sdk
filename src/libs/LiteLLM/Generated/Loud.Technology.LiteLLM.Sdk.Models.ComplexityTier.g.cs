
#nullable enable

namespace Loud.Technology.LiteLLM.Sdk
{
    /// <summary>
    /// Complexity tiers for routing decisions.
    /// </summary>
    public enum ComplexityTier
    {
        /// <summary>
        ///
        /// </summary>
        Complex,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        NonReasoning,
        /// <summary>
        ///
        /// </summary>
        Reasoning,
        /// <summary>
        ///
        /// </summary>
        Simple,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ComplexityTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ComplexityTier value)
        {
            return value switch
            {
                ComplexityTier.Complex => "COMPLEX",
                ComplexityTier.Medium => "MEDIUM",
                ComplexityTier.NonReasoning => "NON_REASONING",
                ComplexityTier.Reasoning => "REASONING",
                ComplexityTier.Simple => "SIMPLE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ComplexityTier? ToEnum(string value)
        {
            return value switch
            {
                "COMPLEX" => ComplexityTier.Complex,
                "MEDIUM" => ComplexityTier.Medium,
                "NON_REASONING" => ComplexityTier.NonReasoning,
                "REASONING" => ComplexityTier.Reasoning,
                "SIMPLE" => ComplexityTier.Simple,
                _ => null,
            };
        }
    }
}